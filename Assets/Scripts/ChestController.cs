using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestController : MonoBehaviour
{
    [SerializeField] GameObject _winPanel;

   
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player") && Input.GetKey(KeyCode.E))
        {
            Time.timeScale = 0;
            _winPanel.SetActive(true);
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }

    }
}
