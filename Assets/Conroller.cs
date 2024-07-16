using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Conroller : MonoBehaviour
{
   
    public GameObject GameOverScreen;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public IEnumerator timer()
    {
        yield return new WaitForSeconds(1);
        GameOverScreen.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Finish"))
        {
            StartCoroutine(timer());
            
        }
    }

    

    public void RestartGame ()
    {
        SceneManager.LoadScene(0);
    }
}
