using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioPlayer : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip Normal_State;
    public AudioClip Game_Start;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        StartCoroutine(playNormalState());
    }

    IEnumerator playNormalState() {

        audio.Play(); //Plays the Game_Start audio first

        yield return new WaitForSeconds(Game_Start.length); //Wait for Game_Start audio to stop playing

        audio.clip = Normal_State; //Change the Game_Start audio to the Normal_State audio
        audio.Play(); //Plays the Normal_State audio

        yield return null;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
