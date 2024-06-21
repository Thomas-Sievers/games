using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField]
    private float velocidade;
    private Vector3 posicaoInicial;
    private float tamanhoImagemCena;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoDaImagemOriginal = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoImagemCena = tamanhoDaImagemOriginal * escala;
    }
    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoImagemCena);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;

    }
}
