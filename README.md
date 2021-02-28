# LEDspeechdemo
Control an Arduino LED with speech commands

## Usage 

1. Insert an LED into pin 13 of your Arduino (or edit /arduinofile/LEDspeechdemo.ino to use a differnt pin)
2. Upload /arduinofile/LEDspeechdemo.ino to your Arduino board
3. Open Program.cs and replace your serial port on line 28 and your key (see Azure Cognitive Services section below)
4. Do a `dotnet run` and then start talking

"Turn the light on" - Turns the light on.

"Turn the light off" - Turns the light off.

Riveting stuff.

> **NOTE**
> You should install the latest version of .NET 5, or use .NET Core 3.1 and update the target framework.

## Azure Cognitive Services

:bangbang: |  The speech-to-text in this example uses Azure Cognitive Services, which has a small cost associated. [Read more about the service here](https://azure.microsoft.com/en-us/services/cognitive-services/).
:---: | :---

You must replace the placeholder text on line 34 of Program.cs with your own key and location.


https://user-images.githubusercontent.com/16778828/109404925-e3170c00-7938-11eb-8e73-1d2004e3435c.mp4

