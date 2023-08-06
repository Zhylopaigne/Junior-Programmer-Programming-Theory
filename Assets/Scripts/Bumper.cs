using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : BouncyObject
{
    protected override void BouncePlayer(GameObject player)
    {
        Vector3 bounceVector = (player.transform.position - transform.position).normalized;
        player.GetComponent<Rigidbody>().AddForce(bounceVector * bounceForce, ForceMode.Impulse);
    }
}
