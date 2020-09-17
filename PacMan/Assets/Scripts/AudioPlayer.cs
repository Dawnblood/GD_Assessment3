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

        audio.Play();

        yield return new WaitForSeconds(Game_Start.length);

        audio.clip = Normal_State;
        audio.Play();

        yield return null;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
