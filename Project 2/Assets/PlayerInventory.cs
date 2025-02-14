using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private HashSet<string> collectedKeys = new HashSet<string>();

    public void CollectKey(string keyID)
    {
        collectedKeys.Add(keyID);
        Debug.Log("Collected key: " + keyID);
    }

    public bool HasKey(string keyID)
    {
        return collectedKeys.Contains(keyID);
    }
}
