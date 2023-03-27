using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] songs;
    public int currentSong;

    public TextMeshProUGUI songName;

    void Start()
    {
        UpdateSongName();
    }

    public void UpdateSongName()
    {
        songName.text = songs[currentSong].name;
    }

    /*public void PlayButtonFunction()
    {
        playButton.interactable = false;
        pauseButton.interactable = true;
    }*/

    /*public void PlayButtonFunction()
    {
        playButton.interactable = false;
        pauseButton.interactable = true;
    }*/

    /*public void PlayButtonFunction(bool playButtonHasBeenPressed)
    {
        playButton.interactable = !playButtonHasBeenPressed;//false
        pauseButton.interactable = playButtonHasBeenPressed;//true
    }*/
}
