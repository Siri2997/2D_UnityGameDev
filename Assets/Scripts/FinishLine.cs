using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Invoke("ReloadScene", loadDelay);
            //Debug.Log("You finished");
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
