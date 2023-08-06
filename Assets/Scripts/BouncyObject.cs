using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BouncyObject : MonoBehaviour
{
    [SerializeField] protected float bounceForce = 10;

    protected void OnCollisionEnter(Collision collision)
    {
        if (collision != null && collision.gameObject.CompareTag("Player")) 
        {
            BouncePlayer(collision.gameObject);
        }
    }

    protected abstract void BouncePlayer(GameObject player);

}
