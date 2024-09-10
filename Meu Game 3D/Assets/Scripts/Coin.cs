using UnityEngine;

public class Coin : MonoBehaviour 
{
    // Valor da moeda
    public int coinValue = 1;

    // Método que é chamado quando o jogador colide com a moeda
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) // Verifica se o jogador colidiu com a moeda
        {
                // Destroi a moeda
                 Destroy (gameObject);
        }
    }
}