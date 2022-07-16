using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneReturn : MonoBehaviour
{
    private List<string> sceneHistory = new List<string>();
    public string[] nextRoom;
    string randomizedRoom;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        int randomIndex = Random.Range(0, nextRoom.Length);
        string randomRoom = nextRoom[randomIndex];
        randomizedRoom = randomRoom;
    }

    // Update is called once per frame
    private void Update()
    {
        int randomIndex = Random.Range(0, nextRoom.Length);
        string randomRoom = nextRoom[randomIndex];
        randomizedRoom = randomRoom;
    }
    public void LoadScene()
    {
        sceneHistory.Add(randomizedRoom);
        SceneManager.LoadSceneAsync(randomizedRoom, LoadSceneMode.Single);
    }
    public bool PreviousScene()
    {
        bool returnValue = false;
        if (sceneHistory.Count >= 2)
        {
            returnValue = true;
            sceneHistory.RemoveAt(sceneHistory.Count - 1);
            SceneManager.LoadSceneAsync(sceneHistory[sceneHistory.Count - 1]);
        }
        return returnValue;
    }
}
