using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    private GameOverController gameOver;
    private UiControler pontucao;
    private Fish fish;

    private void Start()
    {
        this.gameOver = GameObject.FindObjectOfType<GameOverController>();
        this.fish = GameObject.FindObjectOfType<Fish>();
        this.pontucao = GameObject.FindObjectOfType<UiControler>();

    }
    public void FinalizarJogo()
    {
        Debug.Log("Finalizou");
        Time.timeScale = 0;
        this.gameOver.OnGameOver();
    }

    public void ReiniciarJogo()
    {
        Time.timeScale = 1;
        this.fish.Reiniciar();
        this.pontucao.Reiniciar();
        this.DestruirObstaculos();
        this.DestruirPolvo();
    }

    private void DestruirObstaculos()
    {
        Obsaculos[] obstaculos = GameObject.FindObjectsOfType<Obsaculos>();
        foreach (Obsaculos obstaculo in obstaculos)
        {
            Debug.Log("destruiu");
            obstaculo.Destruir();
        }
    }

    private void DestruirPolvo()
    {
        Polvo[] polvos = GameObject.FindObjectsOfType<Polvo>();
        foreach (Polvo polvo in polvos)
        {
            Debug.Log("destruiu");
            polvo.Destruir();
        }
    }
}
