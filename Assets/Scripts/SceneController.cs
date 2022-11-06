using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [Header("Move To Scene")]
    [SerializeField]
    private string chapter;
    [SerializeField]
    private string subChapter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collide");
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("changeScene!");
            string nextScene = "Chapter" + chapter + "-" + subChapter;
            SceneManager.LoadScene(nextScene);
        }
    }
}
