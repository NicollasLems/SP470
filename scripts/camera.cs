using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour

{
    public float sensibilidade = 2.0f;   //Deixei a váriavel "sensibilidade" publica, para que o jogador possa alterar a sensibilidade do mouse

    float mouseX = 0.0f, mouseY = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;   //Para o cursor não ser exibido na tela
        Cursor.lockState = CursorLockMode.Locked;   //Para o cursor ficar fixo no meio da tela
    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * sensibilidade;   //Para rotacionar a camera no eixo x
        mouseY -= Input.GetAxis("Mouse Y") * sensibilidade;   //Para rotacionar a camera no eixo y

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
}
