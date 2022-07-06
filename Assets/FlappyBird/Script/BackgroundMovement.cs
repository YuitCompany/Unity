using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    Material skyMaterial;

    public float offset;

    private void Awake()
    {
        skyMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        skyMaterial.mainTextureOffset += new Vector2(offset, 0) * Time.deltaTime;
    }
}
