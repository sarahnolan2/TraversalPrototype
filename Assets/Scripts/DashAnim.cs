using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashAnim : MonoBehaviour
{
    public float rotationSpeed = 5.0f;

    List<GameObject> childrenList;

    // Start is called before the first frame update
    void Start()
    {
        childrenList = GetAllChildren(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //rotate the dash
        this.transform.Rotate(rotationSpeed + Random.value, rotationSpeed, rotationSpeed - Random.value);

        //rotate each little cube individually
        foreach (GameObject cube in childrenList)
        {
            cube.transform.Rotate(rotationSpeed * 2, rotationSpeed * 2, rotationSpeed * 2);
        }
    }

    private List<GameObject> GetAllChildren(GameObject parent)
    {
        List<GameObject> powerupsList = new List<GameObject>();

        foreach (Transform trnsfrm in parent.GetComponentInChildren<Transform>())
        {
            powerupsList.Add(trnsfrm.gameObject);
        }
        return powerupsList;
    }
}
