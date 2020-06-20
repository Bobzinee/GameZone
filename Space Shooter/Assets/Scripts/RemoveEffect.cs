using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveEffect : MonoBehaviour
{

    void Start()
    {
        Destroy(gameObject, 3f);
    }
}
