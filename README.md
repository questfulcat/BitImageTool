# BitImageTool

Simple binary image editor that encodes image in string format (each 6 pixels encoded to 6-bit and then to some ASCII character after adding base shift, it's like base64 but more simple)<br>
It might be used to draw glyphs for tool buttons and store graphics in string properties instead of loading images as resources.<br>
Basecode is base char code that will be added to each 6-bit value. For basecode=32 string char codes will be in range 32-96, for basecode=63 string char codes will be in range 63-127.

## Build

Build project with Visual Studio 2022

## Compatibility

- Windows (.NET Framework 4.0+)
- Linux (mono)

## How to use

Draw image

![01](https://github.com/user-attachments/assets/f72359df-08b3-4eaf-ab4c-c65757e50776)

Copy result string to your app or button property and generate image with code like this: (C# example)
```C#
Bitmap stringToBitmap(Color pen, string s)
{
    byte basecode = s[0];
    byte w = s[1] - basecode;
    byte h = s[2] - basecode;
    Bitmap bmp = new Bitmap(w, h);
    for (int y = 0; y < h; y++)
        for (int x = 0; x < w; x++)
            bmp.SetPixel(x, y, ((s[3 + (y * w + x) / 6] - basecode) & (1 << (y * w + x) % 6)) > 0 ? pen : Color.Transparent);
    return bmp;
}
```

## Javascript example
```javascript
<html>
    <body style="background-color: #333">
        <canvas class="textimage" image-data="0@@00080060ncWolI6HV0V1PI0H6@V1VigOnm706001000" image-color="0xFF4040FF"></canvas>
        <canvas class="textimage" image-data="0@@00Po18@0boP488iOB2TW019@h34R0QhOn0070P00000" image-color="0x40FF40FF"></canvas>
        <canvas class="textimage" image-data="0@@00084033h`1>LPW7`o0h70d00;0@30\00=0`30H0000" image-color="0x4040FFFF"></canvas>
        
        <script>
            let canvases = document.getElementsByClassName("textimage");
            Array.from(canvases).forEach(function(canvas)
            {
                let ctx = canvas.getContext("2d");
                let s = canvas.getAttribute("image-data");
                let pen = parseInt(canvas.getAttribute("image-color"));
                let penr = pen >> 24 & 0xFF;
                let peng = pen >> 16 & 0xFF;
                let penb = pen >> 8 & 0xFF;
                let pena = pen & 0xFF;
                
                let basecode = s.charCodeAt(0);
                let w = s.charCodeAt(1) - basecode;
                let h = s.charCodeAt(2) - basecode;
                canvas.width = w;
                canvas.height = h;
                let idata = ctx.getImageData(0, 0, w, h);
                let data = idata.data;
                for (let y = 0; y < h; y++)
                    for (let x = 0; x < w; x++)
                        if (((s.charCodeAt(3 + (y * w + x) / 6) - basecode) & (1 << (y * w + x) % 6)) > 0)
                        {
                            let p = (y * w + x) * 4;
                            data[p] = penr;
                            data[p + 1] = peng;
                            data[p + 2] = penb;
                            data[p + 3] = pena;
                        }
                ctx.putImageData(idata, 0, 0);
            });
        </script>
    </body>
</html>
```

this code will generate three images
![samp01](https://github.com/user-attachments/assets/c32dd933-cb99-4217-8c8a-4ac0de1320be)


## Python example
```python
from PIL import Image

s = "0@@00080060ncWolI6HV0V1PI0H6@V1VigOnm706001000"
pen = (255, 0, 0)

basecode = ord(s[0])
w = ord(s[1]) - basecode
h = ord(s[2]) - basecode
img = Image.new('RGBA', (w, h), (0, 0, 0, 0))

for y in range(w):
    for x in range(h):
        if ((ord(s[3 + (y * w + x) // 6]) - basecode) & (1 << (y * w + x) % 6)) > 0:
            img.putpixel((x, y), pen)

img.save('test.png', 'PNG')
```

## Antialiasing
Improved decoder with antialising option on C#

```C#
// decoder with antialiasing as option
Bitmap stringToBitmap(Color pen, string s, bool antialiasing)
{
    Color ppart = Color.FromArgb(pen.A / 4, pen.R, pen.G, pen.B);
    int basecode = s[0];
    int w = s[1] - basecode;
    int h = s[2] - basecode;
    var data = new Color[h, w];
    for (int y = 0; y < h; y++)
        for (int x = 0; x < w; x++)
            data[y, x] = ((s[3 + (y * w + x) / 6] - basecode) & (1 << (y * w + x) % 6)) > 0 ? pen : Color.Transparent; 

    // antialiasing and image fill
    Bitmap bmp = new Bitmap(w, h);
    for (int y = 1; y < h - 1; y++)
        for (int x = 1; x < w - 1; x++)
        {
            if (antialiasing)
            {
                int q = 0;
                if (data[y - 1, x] == pen) q++;
                if (data[y + 1, x] == pen) q++;
                if (data[y, x - 1] == pen) q++;
                if (data[y, x + 1] == pen) q++;
                if ((q == 2 || q == 3) && data[y, x] == Color.Transparent) data[y, x] = ppart;
            }
            bmp.SetPixel(x, y, data[y, x]);
        }
    return bmp;
}
```