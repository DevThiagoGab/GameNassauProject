using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Dano : MonoBehaviour
{

    public CoracaoSystem coracao;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            coracao.vida--;
        }

    }

}
