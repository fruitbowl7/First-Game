using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}