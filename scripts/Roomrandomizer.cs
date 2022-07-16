using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Roomrandomizer : MonoBehaviour
{
    [SerializeField] bool returnDoor;
    public string[] nextRoom;
    string randomizedRoom;
    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0, nextRoom.Length);
        string randomRoom = nextRoom[randomIndex];
        randomizedRoom = randomRoom;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (returnDoor == true)
        {
            //GetComponent<sceneReturn>();
        }
        else
        {
            SceneManager.LoadScene(randomizedRoom, LoadSceneMode.Single);
        }
    }
}
