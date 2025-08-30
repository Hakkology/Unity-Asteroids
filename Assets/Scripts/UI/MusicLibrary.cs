using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MusicLibrary", menuName = "Audio/Music Library", order = 1)]
public class MusicLibrary : ScriptableObject
{
    public List<AudioClip> musicClips;

    public AudioClip GetRandomClip()
    {
        if (musicClips == null || musicClips.Count == 0)
            return null;

        return musicClips[Random.Range(0, musicClips.Count)];
    }
}