﻿using Client;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client {

    class StreamingPlayer {
        public static WaveOutEvent waveOutEvent { set; get; }
        public static WaveStream waveStream { set; get; }
        public static Queue<Track> queueTracks { set; get; }
        public static Queue<Track> historyTracks { set; get; }
        public static bool isTrackReady { set; get; }

        public StreamingPlayer() { }

        public static void Initialize() {
            waveOutEvent = new WaveOutEvent();
            isTrackReady = false;
            queueTracks = new Queue<Track>();
            historyTracks = new Queue<Track>();
        }

        public static async Task<bool> UploadTrackAsync(Track track) {
            try {
                RequestTrackAudio requestTrackAudio = new RequestTrackAudio();
                requestTrackAudio.Filename = track.StoragePath;
                TrackAudio trackAudio = await Session.streamingServerConnection.streamingService.GetTrackAudioAsync(requestTrackAudio);
                byte[] bytes = trackAudio.Song;
                StreamingPlayer.StopPlayer();
                Mp3FileReader mp3Reader = new Mp3FileReader(new MemoryStream(bytes));
                waveStream = new WaveChannel32(mp3Reader);
                waveOutEvent.Init(waveStream);
                isTrackReady = true;
                StreamingPlayer.StartPlayer();
                return true;
            } catch (Exception ex) {
                Console.WriteLine(ex);
                return false;
            }
        }

        public static async Task<Track> UploadNextTrack() {
            if (queueTracks.Count > 0) {
                StreamingPlayer.StopPlayer();
                Track track = queueTracks.Dequeue();
                StreamingPlayer.AddTrackToHistory(track);
                isTrackReady = false;
                if (await StreamingPlayer.UploadTrackAsync(track)) {
                    return track;
                } else {
                    return null;
                }
            } else {
                return null;
            }
        }

        public static bool StartPlayer() {
            if (isTrackReady) {
                waveOutEvent.Play();
                return true;
            } else {
                return false;
            }
        }

        public static bool IsTrackPlaying() {
            if (waveOutEvent.PlaybackState == PlaybackState.Playing) {
                return true;
            } else {
                return false;
            }
        }

        public static bool StopPlayer() {
            if (isTrackReady) {
                waveOutEvent.Stop();
                return true;
            } else {
                return false;
            }
        }

        public static void RestartTrack() {
            if (isTrackReady) {
                waveStream.Position = 0;

            }
        }

        public static void UpdateVolume(double volume) {
            if (waveOutEvent != null) {
                waveOutEvent.Volume = (Convert.ToSingle(volume)) / 100f;

            }
        }

        public static void UpdatePositionTrack(double position) {
            var totalSeconds = (position * waveStream.TotalTime.TotalSeconds) / 100;

            waveStream.CurrentTime = TimeSpan.FromSeconds(totalSeconds);
        }

        public static bool IsTrackOver() {
            if (waveStream.Position >= waveStream.Length) {
                return true;
            } else {
                return false;
            }
        }

        public static double GetTotalSecondsTrack() {
            return waveStream.TotalTime.TotalSeconds;
        }

        public static double GetCurretTimeSeconds() {
            return waveStream.CurrentTime.TotalSeconds;
        }

        public static double GetCurretTimeForSlider() {
            return (waveStream.CurrentTime.TotalSeconds * 100) / waveStream.TotalTime.TotalSeconds;
        }

        public static void AddTrackToQueue(Track track) {
            queueTracks.Enqueue(track);
        }

        public static void AddTrackToHistory(Track track) {
            historyTracks.Enqueue(track);
        }

        public static void AddListTracksToQueue(List<Track> tracks) {
            foreach (var item in tracks) {
                queueTracks.Enqueue(item);
            }
        }

    }
}