using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruits : MonoBehaviour
{
    main main;
    public float speed = 0.1f; // Düþme hýzý
    Transform tr;
    public AudioClip collectSound; // Ses dosyasý
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
        {
            main.GameOver(); // GameOver fonksiyonunu çaðýr
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("basket"))
        {
            if (audioSource != null && collectSound != null)
            {
                audioSource.PlayOneShot(collectSound); // Ses çal
            }

            Destroy(this.gameObject);
            main.ScoreAdd();
        }
    }
}
