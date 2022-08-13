using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bricks : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }

}
