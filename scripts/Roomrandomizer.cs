using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Roomrandomizer : MonoBehaviour
{
    public sceneReturn nextRoom;
    [SerializeField] bool returndoor;
    // Start is called before the first frame update
    void Start()
    {
       
        GameObject Return = GameObject.FindGameObjectWithTag("returnDoor");
        nextRoom = Return.GetComponent<sceneReturn>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (returndoor == true)
        {
            nextRoom.PreviousScene();
        }
        else
        {
            nextRoom.LoadScene();
        }
    }
}
