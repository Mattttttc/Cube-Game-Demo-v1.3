using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public int Lives = 3;
    public float FramesSinceLastHit = 0;
    public GameManager gameManager;

    void Update () {
        FramesSinceLastHit = (FramesSinceLastHit + 1f);
    }

    void OnCollisionEnter (Collision collisionInfo) {

        if(collisionInfo.collider.tag == "CubeObject") {

            if (FramesSinceLastHit > 30) {

                FramesSinceLastHit = 0f;
                Lives = Lives - 1;
                if (Lives == 0) {
                movement.enabled = false;
                gameManager.EndGame();
                }
            }
        }
    }
}
