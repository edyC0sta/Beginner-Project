using UnityEngine;
using TMPro;

public class PlayerDiamonds : MonoBehaviour
{
    public int Diamonds = 0;
    public TextMeshProUGUI scoreText;

    public void AddDiamond() {
        Diamonds++;

        Debug.Log("Diamond added");

        if (scoreText != null) {
            scoreText.text = Diamonds.ToString();
        }
    }
}
