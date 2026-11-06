using TMPro;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private int playerScore = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerScore++;
            text.text = "Player Score:" + playerScore;
        }
    }
}
