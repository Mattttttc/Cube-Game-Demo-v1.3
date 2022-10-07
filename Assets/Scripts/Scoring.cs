using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Transform player;
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = (player.position.z/6).ToString("0");
    }
}
