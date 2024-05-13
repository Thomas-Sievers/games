using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculo : MonoBehaviour
{
    [SerializeField]
    private float tempoParaCriar = 3;

    private float cronometro;

    [SerializeField]
    private GameObject modeloObstaculo;

    private void Awake()
    {
        this.cronometro = this.tempoParaCriar;
    }
    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.modeloObstaculo, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaCriar;
        }
    }
}
