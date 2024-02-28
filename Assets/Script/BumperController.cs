using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;
    public float score;
    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;

    private Renderer rendered;
    private Animator animator;

    private void Start()
    {
        rendered = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        rendered.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            //animasi
            animator.SetTrigger("hit");

            //playSFX
            audioManager.PlaySFX(collision.transform.position);

            //playVFX
            vfxManager.PlayVFX(collision.transform.position);

            //score aa
            scoreManager.AddScore(score);
        }
    }
}
