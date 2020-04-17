using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public int sceneBuildIndex;
    public GameObject Uipanel;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        Uipanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
          
    }
}
