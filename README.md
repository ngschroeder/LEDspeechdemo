# LEDspeechdemo
Control Arduino LED with speech commands

## Usage 

1. Insert an LED into pin 13 of your Arduino
2. Upload LEDSpeechdemo.ino
3. Open Program.cs and replace your port on line 28 and your key (see Azure Cognitive Services section below)
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