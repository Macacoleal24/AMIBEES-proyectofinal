using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class arbol : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private GameObject efectoMuerte;

    public Animator animator;

    public void TomarDa�o(float da�o){
        vida -= da�o;
        if (vida <= 0)
        {
            Muerte();
        }
    }
        private void Muerte()
        {
            Instantiate(efectoMuerte, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    


}
