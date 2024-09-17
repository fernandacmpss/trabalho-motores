using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI hud, MsgVitoria;

    public int restantes;

    public AudioClip ClipMoeda, ClipVitoria;

    private AudioSource Source;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out Source);
        restantes = FindObjectsOfType<Moeda>().Length;

        hud.text = $"Moedas restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)

    {
        restantes -= valor;
        hud.text = $"Moedas restantes: {restantes}";
        Source.PlayOneShot(ClipMoeda);
        
        if (restantes <= 0)
        {
            // ganhou o jogo 
            MsgVitoria.text = "Você é um verdadeiro viking!";
            Source.Stop();
            Source.PlayOneShot(ClipVitoria);
        }
            
            
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
