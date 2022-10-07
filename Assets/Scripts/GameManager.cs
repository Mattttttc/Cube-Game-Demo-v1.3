using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;

    public void CompleteLevel () {

        completeLevelUI.SetActive(true);
    }
    
    public void EndGame () {

        Invoke("Restart", 2f);
    }

    void Restart () {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
