using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public AudioClip[] beats;

	public void GetBeats ()
    {
        beats = Resources.LoadAll<AudioClip>("Beats");
    }

    //Changing the Current Beat 
    public void newbeat(int beatno)
    {
        GetComponent<LineMaker>().CurrentBeat = beats[beatno];
        Debug.Log("the beat :" + beats[beatno].name); 
    }
	
	
}
