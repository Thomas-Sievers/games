using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UiMenu : MonoBehaviour
{

    private Button botao;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        this.botao = root.Q<Button>("botao");
        this.botao.RegisterCallback<ClickEvent>(OnOpenButtonClicked);

    }

    private void OnOpenButtonClicked(ClickEvent evento)
    {
        SceneManager.LoadScene("SampleScene");
    }

}
