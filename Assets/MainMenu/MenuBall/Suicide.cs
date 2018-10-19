using System.Collections;
using UnityEngine;

public class Suicide : MonoBehaviour {

    public float KillTime = 5.0f;
	void Start ()
    {
        StartCoroutine(DestroySelf());
	}
	
    IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(KillTime);
        Destroy(this.gameObject);
    }
}
