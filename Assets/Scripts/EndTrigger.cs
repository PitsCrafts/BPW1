using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameObject Collider;
    private void OnTriggerEnter(Collider pCube9)
    {
        if (pCube9.CompareTag("Player"))
        {
            Debug.Log("entered");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    
    }
}
