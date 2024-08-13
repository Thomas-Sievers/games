using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    Rigidbody2D fisica;
    private Diretor Diretor;
    private Vector3 posicaoInicial;

    private void Awake()
    {
        this.fisica = GetComponent<Rigidbody2D>();
        this.Diretor = FindObjectOfType<Diretor>();
    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            this.Impulsionar();
        }
    }

    [SerializeField]
    private float velocidade = 3;

    void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * this.velocidade, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.fisica.simulated = false;
        this.Diretor.FinalizarJogo();
    }

    public void Reiniciar()
    {
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }
}
