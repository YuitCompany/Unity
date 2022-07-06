using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClean : MonoBehaviour
{
    float offset;
    public bool state;

    GameObject gameController;

    void Start()
    {
        offset = -10;
        gameController = GameObject.Find("Controller");
    }

    void Update()
    {
        if(transform.position.x < offset)
        {
            Destroy(gameObject);
        }
        if(gameController.GetComponent<GameController>().GameMode() == 0 && !state)
        {
            Destroy(gameObject);
        }
    }
}
