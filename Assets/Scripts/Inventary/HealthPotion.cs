using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    [SerializeField]
    Poison poison;

    private void OnTriggerEnter(Collider other)
    {
        poison.Drink();
        Debug.Log("Health Restored");
        Destroy(gameObject);
    }
}
