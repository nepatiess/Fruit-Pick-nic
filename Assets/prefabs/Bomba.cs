using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    main main;
    public float speed = 0.12f; // düþme hýzý
    Transform tr;
    public AudioClip collectSound;
    private AudioSource audioSource;

    void Start()
    {
        tr = GetComponent<Transform>();
        main = GameObject.Find("Generator").GetComponent<main>();
        audioSource = GameObject.Find("Generator").GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        tr.position -= new Vector3(0f, speed, 0f);

        if (tr.position.y < -7f)
            Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("basket"))
        {
            if (collision.gameObject.CompareTag("basket"))
            {
                if (audioSource != null && collectSound != null)
                {
                    audioSource.PlayOneShot(collectSound); // Ses çal
                }

                Destroy(this.gameObject);
                Destroy(collision.gameObject);
                main.GameOver();
            }
        }
    }
}
