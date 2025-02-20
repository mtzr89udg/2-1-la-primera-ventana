using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Called when the object starts colliding with another object
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
    }

    // Called when an object enters a trigger collider
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger detected with: " + other.gameObject.name);
    }
}

