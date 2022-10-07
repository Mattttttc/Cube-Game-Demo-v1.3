using UnityEngine;

public class Lives : MonoBehaviour
{
    public PlayerCollision script;
    public GameObject Life3;
    public GameObject Life2;
    public GameObject Life1;

    void Update()
    {
        if (script.Lives == 2) {

            Life3.SetActive(false);
        }

        if (script.Lives == 1) {

            Life2.SetActive(false);
        }

        if (script.Lives == 0) {

            Life1.SetActive(false);
        }
    }
}
