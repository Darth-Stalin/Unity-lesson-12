using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Conroller : MonoBehaviour
{

    public GameObject GameOverScreen;
    public 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Finish"))
        {
            GameOverScreen.SetActive(true);
        }
    }

    public void RestartGame ()
    {
        SceneManager.LoadScene(0);
    }
}
