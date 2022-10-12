using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimation : MonoBehaviour
{
    [SerializeField] private Sprite[] idle;

    private void Start()
    {
        Debug.Log("anzahl der elemente" + idle.Length);
    }
}
