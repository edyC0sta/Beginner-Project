using UnityEngine;

public class Diamond : MonoBehaviour
{
    public int DiamondValue = 1;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            PlayerDiamonds diamonds = other.GetComponent<PlayerDiamonds>();
            
            if (diamonds != null) {
                diamonds.AddDiamond();
            }

            Destroy(gameObject);
        }
    }
}
