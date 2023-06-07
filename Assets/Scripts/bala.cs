using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float da�o;
    [SerializeField] private float tiempodeVida;


    private void Start()
    {
        Destroy(gameObject,tiempodeVida);
    }

    private void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Arbol"))
        {
            collision.GetComponent<arbol>().TomarDa�o(da�o);
            Destroy(gameObject);
        }
    }
}