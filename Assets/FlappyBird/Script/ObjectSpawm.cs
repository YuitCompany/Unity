using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawm : MonoBehaviour
{
    float spawmPoint, spawmRange;

    public GameObject wall;
    public GameObject could;

    GameObject gameController;

    void Start()
    {
        gameController = GameObject.Find("Controller");
        
        spawmRange = 4;
        spawmPoint = 11;
        transform.Translate(12, 0, 0);
    }

    void Update()
    {
        if (transform.position.x + Random.Range(-1, 200) < 0)
        {
            GameObject newCould = Instantiate(could) as GameObject;
            newCould.transform.position = new Vector3(spawmPoint, Random.RandomRange(20, 40) / 10, 0);
        }

        if (transform.position.x < 0 && gameController.GetComponent<GameController>().GameMode() == 1)
        {
            GameObject newWall = Instantiate(wall) as GameObject;
            newWall.transform.position = new Vector3(spawmPoint, Random.RandomRange(-10, 15) / 10, 0);
        }

        if (transform.position.x < 0) transform.Translate(new Vector3(spawmRange, 0, 0));
    }
}
