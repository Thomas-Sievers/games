using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    [SerializeField]
    private float variacaoPosicaoY;

    private Vector3 posicaoPassaro;

    private bool pontuei;

    private UIController uicontroller;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoPosicaoY, variacaoPosicaoY));
    }

    private void Start()
    {
        this.posicaoPassaro = GameObject.FindObjectOfType<Bird>().transform.position;
        this.uicontroller = GameObject.FindObjectOfType<UIController>();
    }

    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);
        if(!this.pontuei && this.transform.position.x < this.posicaoPassaro.x){
            this.uicontroller.adicionarPontos();
            this.pontuei = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }

    private void Destruir()
    {
        Destroy(this.gameObject);
    }
}
