using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionDectect : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
         if(collision.transform.tag == "Enimy")
        {
            Debug.Log("GameOver !");
        }
    }
}
