using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polvo : MonoBehaviour
{
    [SerializeField]
    private float velocidade;
    [SerializeField]
    private float variacaoPosicaoY;
    private Vector3 posicaoPassaro;
    
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoPosicaoY, variacaoPosicaoY));
    }

    // Start is called before the first frame update
    void Start()
    {
        this.posicaoPassaro = GameObject.FindObjectOfType<Fish>().transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);
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
