using System;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;

class Program
{
    static SerialPort _serialPort;
    static char[] charsToTrim = {',', '.', '?'};

    async static Task FromMic(SpeechConfig speechConfig)
    {
        using var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
        using var recognizer = new SpeechRecognizer(speechConfig, audioConfig);

        Console.WriteLine("Speak into your microphone.");
        var result = await recognizer.RecognizeOnceAsync();
        Console.WriteLine($"RECOGNIZED: Text={result.Text}");
        _serialPort.WriteLine(result.Text.ToLower().TrimEnd(charsToTrim));
    }

    async static Task Main(string[] args)

    {
        _serialPort = new SerialPort();
        _serialPort.PortName = "/dev/cu.usbmodem142101"; //Set your board COM
        _serialPort.BaudRate = 9600;
        _serialPort.Open();

        while (true)
        {
            var speechConfig = SpeechConfig.FromSubscription("YOUR AZURE KEY", "YOUR AZURE LOCATION");
            await FromMic(speechConfig);
        }

    }
}