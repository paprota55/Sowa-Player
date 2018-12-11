using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;

namespace player
{
    public static class BassLike
    {
        //Inicjalizuje jaka czestotliwosc dzwieku jest puszczana
        private static int HZ = 44100;

        //inicjalizacja defaultowego urządzenia
        public static bool InitDefaultDevice;

        //zrodlo z ktorego bedzie "muzyka"
        public static int Stream;

        //poziom glosnosci
        public static int Volume = 100;

        //inicjalizujemy nasze urzadzenie defaultowe z narzucona czestotliwoscia
        private static bool InitBass(int hz)
        {
            if (!InitDefaultDevice)
                InitDefaultDevice = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            return InitDefaultDevice;
        }

        internal static double GetTimeOfStream(int stream)
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);

            return (int)Time;
        }

        //Uruchomienie pliku oraz zatrzymanie poprzedniego jesli byl uruchomiony.
        //Ustawienie nowego streama, a w przypadku gdy rozny od 0 ustawiamy glosnosc 
        //Parametr false odpowiada za odtwarzanie nie od poczatku, a od konkretnego miejsca zakonczenia
        public static void Play(string filename, int vol)
        {
            Stop();
            if (InitBass(HZ))
            {
                Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                if (Stream != 0)
                {
                    Volume = vol;
                    Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100);
                    Bass.BASS_ChannelPlay(Stream, false);
                }
            }
        }


        //zatrzymanie puszczanego streama oraz zwolnienie
        public static void Stop()
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
        }

        public static void Pause()
        {
            Bass.BASS_ChannelPause(Stream);
        }

        public static void Resume()
        {
            Bass.BASS_ChannelPlay(Stream, false);
        }
        //Uzyskanie dlugosci utworu oraz przekonwertowanie go na int zeby mozna bylo pozniej wyswietlac
        public static int GetTimeofStream(int stream)
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
    
            return (int)Time;
        }

        //Pozyskiwanie pozycji naszego streama oraz przekonwertowanie ja na sekundy zeby mozna bylo wyswietlac jaki jest czas utworu

        public static int GetPosOfStream(int stream)
        {
            long pos = Bass.BASS_ChannelGetPosition(stream);
            int posSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return posSec;
        }

        //Ustawiam wartość dźwięku zgodnie ze scrollem
        public static void SetPosOfScroll(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
       
        }

        //ustawianie atrybutu glosnosci
        public static void SetVolumeToStream(int stream, int vol)
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
        }
    }
}
