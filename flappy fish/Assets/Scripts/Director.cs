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
        Time.timeScale = 0;
        this.gameOver.OnGameOver();
    }

    public void ReiniciarJogo()
    {
        Time.timeScale = 1;
        this.fish.Reiniciar();
        this.pontucao.Reiniciar();
    }

    private void DestruirObstaculos()
    {
        Obsaculos[] obstaculos = GameObject.FindObjectsOfType<Obsaculos>();
        foreach (Obsaculos obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
