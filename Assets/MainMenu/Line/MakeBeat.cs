using UnityEngine.Audio;
using UnityEngine;

public class MakeBeat : MonoBehaviour {

    float impactvelocity;
    public AudioClip beat;
    AudioSource beatmaker;
    Rigidbody2D impact;

    private void Start()
    {
        beatmaker = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        impact = col.gameObject.GetComponent<Rigidbody2D>();
        impactvelocity = impact.velocity.magnitude;
        beatmaker.pitch = impactvelocity / 16;
        beatmaker.PlayOneShot(beat);
    }
        
    

}
