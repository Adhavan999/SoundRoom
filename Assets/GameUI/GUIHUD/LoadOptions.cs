using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class LoadOptions : MonoBehaviour {

    Dropdown dropdown;
    public GameObject GameManager;
    
    int beatno;

    private void Start()
    {
        //Getting the beats from the AudioManger
        dropdown = GetComponent < Dropdown > ();
        AudioManager AudioManager = GameManager.GetComponent<AudioManager>();
        AudioManager.GetBeats();
        beatno = AudioManager.beats.Length;

        //Loading the beat values into the dropdown menu's options
        dropdown.ClearOptions();
        for (int i = 0; i < beatno; i++)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = AudioManager.beats[i].name ,});
            //Debug.Log(dropdown.value + "...."+AudioManager.beats[i].name);
        }
        OnOptionValueChange(ref AudioManager);

        dropdown.onValueChanged.AddListener(delegate { OnOptionValueChange(ref AudioManager); });  

    }

    void OnOptionValueChange(ref AudioManager AudioManager)
    {
        Debug.Log("value has been changed to " + dropdown.value + "....." + dropdown.options[dropdown.value].text);
        AudioManager.newbeat(dropdown.value);
    }
}
