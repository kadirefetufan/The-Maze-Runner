using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelup : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            // SceneManager.LoadScene(+1);
        }

        //player.transform.position = respawnPoint.transform.position;
        // Physics.SyncTransforms();
    }
}
