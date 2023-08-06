using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : BouncyObject
{
    protected override void BouncePlayer(GameObject player)
    {
        player.GetComponent<Rigidbody>().AddForce(transform.up * bounceForce, ForceMode.Impulse);
    }
}
