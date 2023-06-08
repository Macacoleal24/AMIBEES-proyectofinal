using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float daño;
    [SerializeField] private float tiempodeVida;

    private Transform personaje;

    private void Start()
    {
        personaje = GameObject.FindGameObjectWithTag("Player").transform;

        Destroy(gameObject, tiempodeVida);
        transform.position = new Vector2(transform.position.x, personaje.position.y);

    }

    private void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Arbol"))
        {
            arbol plant = collision.GetComponent<arbol>();
            if (plant != null)
            {
                plant.ChangeSprite();
            }

            Destroy(gameObject);
        }
    }
}
