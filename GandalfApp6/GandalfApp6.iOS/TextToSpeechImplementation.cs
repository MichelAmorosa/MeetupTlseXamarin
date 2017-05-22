
using AVFoundation;
using Foundation;
using GandalfApp.iOS;
using GandalfApp6;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeechImplementation))]
namespace GandalfApp.iOS
{
    public class TextToSpeechImplementation : ITextToSpeech
    {
        public TextToSpeechImplementation() { }
        
        public void Speak(string text)
        {
            NSError error = new NSError();
            var audioSession = AVAudioSession.SharedInstance();
            audioSession.OverrideOutputAudioPort(AVAudioSessionPortOverride.Speaker, out error);

              var speechSynthesizer = new AVSpeechSynthesizer();

            var rate = AVSpeechUtterance.MaximumSpeechRate / 4;
            var voice = AVSpeechSynthesisVoice.FromLanguage("en-US");
            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = rate,
                Voice = voice,
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}
