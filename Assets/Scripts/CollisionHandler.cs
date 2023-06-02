using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem crashVFX;
    void OnTriggerEnter(Collider other)
    {
        StartCrashScene();
    }

    void StartCrashScene()
    {
        crashVFX.Play();
        GetComponent<PlayerControls>().enabled= false;
        Invoke("ReloadLevel", loadDelay);
        foreach (MeshRenderer meshInChild in GetComponentsInChildren<MeshRenderer>())
            meshInChild.enabled = false;

        foreach (Collider colliderInChild in GetComponentsInChildren<Collider>())
            colliderInChild.enabled = false;
    }
    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
