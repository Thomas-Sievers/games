using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;
    private Pontuacao pontuacao;
    private Aviao aviao;

    private void Start()
    {
        this.aviao = GameObject.FindObjectByType<Aviao>();
        this.pontuacao = GameObject.FindObjectByType<Pontuacao>();
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        this.imagemGameOver.SetActive(true);
    }
    private void ReiniciarJogo()
    {
        this.imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        this.aviao.Reiniciar();
        this.DestruirObstaculos();
        this.pontuacao.Reiniciar();
    }

    private void DestruirObstaculos()
    {
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach (Obstaculo osbtaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
