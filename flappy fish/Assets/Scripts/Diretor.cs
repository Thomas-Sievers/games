using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Diretor : MonoBehaviour
{

    [SerializeField]
    private GameObject imagemGameOver;
    private Fish fish;
    private UiControler uicontroler;

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        this.imagemGameOver.SetActive(true);
    }

    private void Start()
    {
        this.fish = GameObject.FindObjectsByType<Fish>();
        this.uicontroler = GameObject.FindAnyObjectByType<UiControler>()
    }

    private void ReiniciarJogo()
    {
        this.imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        this.aviao.Reiniciar();
        this.DestruirObstaculos();
        this.uicontroler.Reiniciar();
    }


}
