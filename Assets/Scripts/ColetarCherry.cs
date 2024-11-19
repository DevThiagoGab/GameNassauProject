using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetarCherry : MonoBehaviour
{
    public Text scoreTxt;
    public int score;

    // Start is called before the first frame update
    private void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cherrys") == true) 
        {
            score++;
            Destroy(collision.gameObject);
        }
    }

}
