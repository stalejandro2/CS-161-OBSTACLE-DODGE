using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Color.saddleBrown;
        //Debug.Log("You hit an object!");
    }
}