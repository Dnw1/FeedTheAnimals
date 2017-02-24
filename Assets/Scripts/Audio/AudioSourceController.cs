using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class AudioSourceController : MonoBehaviour
{
    [SerializeField]
    private List<AudioClip> audioList = new List<AudioClip>(); //Hold list of audioclips.
    [SerializeField]
    private float audioVolume; //Hold audio float.
    [SerializeField]
    private bool autoStopSound; //Hold Check to stop sound.

    private AudioSource audioSource; //Hold single audiosource.
    private int lastIndexPlayed; //Hold of last index.
    private int audioReRolls = 3; //Hold int for rerolls.

    public bool isPlaying = false; //Bool to check for playing.
    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); //Get component for audiosource.
        audioSource.volume = audioVolume; //the volume of source is audiovolume.
        if (audioList.Count != 0) //Check if list is empty.
        {
            lastIndexPlayed = Random.Range(0, audioList.Count);
        } //
        else
        {
            print("there is nothing in the audioList");
        }
    }

    public void ChangeAudioSourceByName(string name)
    {
        for (int i = 0; i < audioList.Count; i++)
        {
            AudioClip clip = audioList[i];

            if (clip.name == name)
            {
                PlayAudioClip(i);
                return;
            } //Uses a for loop to find the right sound.
        }

        print(name + " is not a valid sound");
    }

    public void ChangeAudioSourceByIndex(int index)
    {
        if (index <= audioList.Count && audioList.Count != 0)
        {

            PlayAudioClip(index);
        }
        else
        {
            print("index given is too large, or there might be nothing in the audioList");
        }
    }

    public void ChangeAudioSourceRandom()
    {
        int ReRolls = audioReRolls;
        int randomIndex = Random.Range(0, audioList.Count);
        if (audioList.Count != 0)
        {
            while (randomIndex == lastIndexPlayed && ReRolls <= 0)
            { //Check if last sound played is the same.
                randomIndex = Random.Range(0, audioList.Count); //Reroll index.
                ReRolls--; //For the small chance it rerolls the same audio file forever.
            }
            lastIndexPlayed = randomIndex; //Sets new lastPlayedIndex.
            PlayAudioClip(randomIndex);
        }
        else
        {
            print("there is nothing in the audioList");
        }

    }

    public void StopAudio()
    {
        audioSource.Stop();
    }

    private void PlayAudioClip(int indexGiven)
    {
        if (autoStopSound)
        {
            StopAudio(); //Stop sound here.
        }
        audioSource.clip = audioList[indexGiven]; //Change sound here.
        audioSource.Play(); //Play sound here.
    }
}
