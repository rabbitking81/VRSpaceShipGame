using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CollisionEnter");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("CollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("CollisionExit");
    }
    */
}
