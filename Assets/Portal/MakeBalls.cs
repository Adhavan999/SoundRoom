using System.Collections;
using UnityEngine;

public class MakeBalls : MonoBehaviour {

    public GameObject ball;
    public float spawntime;
    public bool isgameportal = true;

	private void Start ()
    {
        StartCoroutine(createballs());
	}
	
	IEnumerator createballs()
    {
        while (true)
        {   
            yield return new WaitForSeconds(spawntime);
            if (isgameportal)
                Instantiate(ball, transform.position, transform.rotation);
            else
                Instantiate(ball, transform.position, transform.rotation, this.transform);
        }
    }
}
