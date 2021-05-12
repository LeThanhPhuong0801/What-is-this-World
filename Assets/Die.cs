using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject deathEffect;
    private float deathEffectDelay = 1f;
    [Header("Death Signals")]
    public Signal roomSignal;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (roomSignal != null)
            {
                roomSignal.Raise();
            }
            DeathEffect();
            this.gameObject.SetActive(false);
        }
    }
    private void DeathEffect()
    {
        if (deathEffect != null)
        {
            GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(effect, deathEffectDelay);
        }
    }
}
