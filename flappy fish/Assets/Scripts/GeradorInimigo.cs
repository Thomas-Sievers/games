using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorInimigo : MonoBehaviour
{
    [SerializeField]
    private float tempoParaCriar = 3;

    private float cronometro;

    [SerializeField]
    private GameObject modeloInimigo;

    private void Awake()
    {
        this.cronometro = this.tempoParaCriar;
    }
    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.modeloInimigo, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaCriar;
        }
    }
}