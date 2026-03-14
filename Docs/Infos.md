# Generelle Informationen zum Projekt

Falls ihr Informationen zu dingen im PRojekt braucht findet ihr diese hier

----

- Zurück zum [ReadMe.md](../README.md)

----

## Rendering-methode : PictureBox & Bitmap

- Mit einer __PictureBox__ können texturen und Sprites geladen und genutzt werden  

  Es ermöglicht uns eigene Sprites/Texturen/Bilder zu verwenden, um dinge wie  
  Den Start oder das Ende in speziellen symbolen darzustellen

- Mehr über die [PictureBox](https://learn.microsoft.com/de-de/dotnet/api/system.windows.forms.picturebox?view=windowsdesktop-8.0)

  // So ladet ihr ein Bild in eine PictureBox:  
  pictureBox1.Image = Image.FromFile("Bild & Pfad");

----

- Eine __Bitmap__ ist ein Unkomprimiertes Bild, welches details wie Farbwert für jeden Pixel im Bild speichert  
  Wir benutzen es um das flackern des Dungeons beim rendern zu verhindern.  
  Das gesuchte Prinzip bezeichnet sich als [Double Buffering](https://de.wikipedia.org/wiki/Doppelpufferung)

- Wir erstellen ein Bild anhand des Dungeon Layout und malen alle gewollten FArben und texturen darauf,  
  erst wenn dieses Bild fertig ist, Malen wir es auf den Bildschirm. Und das alles auf einmal.

- Mehr über [Bitmaps](https://de.wikipedia.org/wiki/Windows_Bitmap)

----

- Mehr über mögliche Texturen und deren umsetzung in einem meiner anderen [Repos](https://github.com/lennoxMurg/Conways-Game-of-Life) zu Conways Spiel des Lebens
