using UnityEngine.Audio;
using UnityEngine;

public class makebeatball : MonoBehaviour
{
    [SerializeField]
    public AudioClip ballbeat;

    float ballimpactvelocity;
    AudioSource ballbeatmaker;
    Rigidbody2D ball;

    private void Start()
    {
        ballbeatmaker = GetComponent<AudioSource>();
        ball = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        ballimpactvelocity = ball.velocity.magnitude;
        ballbeatmaker.pitch = ballimpactvelocity / 16;
        ballbeatmaker.PlayOneShot(ballbeat);
    }



}
