using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ItemCollector : MonoBehaviour
{
    public UnityEvent onEnter;
    public UnityEvent onHijau;
    public UnityEvent onBiru;

    private int hijau = 0;

    private int biru = 0;

    [SerializeField] private Text hijauText;
    [SerializeField] private Text biruText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Hijau"))
        {
            Destroy(collision.gameObject);
            hijau++;
            hijauText.text = "Hijau: " + hijau;
        }

        if (collision.gameObject.CompareTag("Biru"))
        {
            Destroy(collision.gameObject);
            biru++;
            biruText.text = "Biru: " + biru;
        }

        if (hijau == 2 && biru == 2)
        {
            onEnter?.Invoke();
        }

        if (hijau == 2)
        {

            onHijau?.Invoke();
        }

        if (biru == 2)
        {
            onBiru?.Invoke();
        }
    }
}
