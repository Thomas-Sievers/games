using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsaculos : MonoBehaviour
{
    [SerializeField]
    private float velocidade;

    [SerializeField]
    private float variacaoPosicaoY;
    private Vector3 posicaoPassaro;
    private UiControler uicontroler;
    private bool pontuei;


    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoPosicaoY, variacaoPosicaoY));
    }

    private void Start()
    {
        this.posicaoPassaro = GameObject.FindObjectOfType<Fish>().transform.position;
        this.uicontroler = GameObject.FindObjectOfType<UiControler>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);
        if (!this.pontuei && this.transform.position.x < this.posicaoPassaro.x)
        {
            this.uicontroler.adicionarPontos();
            this.pontuei = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }

    public void Destruir()
    {
        Destroy(this.gameObject);
    }


}
