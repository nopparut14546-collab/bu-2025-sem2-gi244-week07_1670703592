using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 5f;
    private PlayerController playerController;

    void Start()
    {
        GameObject player = GameObject.Find("Player");
        playerController = player.GetComponent<PlayerController>();
    }
    void Update()
    {
        if (playerController.isGameOver)
        {
            speed = 0;
            return;
        }
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}