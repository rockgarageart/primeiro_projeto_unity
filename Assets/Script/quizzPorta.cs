using UnityEngine;
using TMPro;

public class DoorQuiz : MonoBehaviour
{
    // PORTA
    public Transform portaPivot;

    // LUZ DO AVATAR
    public Light luzAvatar;

    // TEXTO DA TV
    public TextMeshPro textoTV;

    // CONTROLE DA PORTA
    private bool aberta = false;

    void Start()
    {
        // TEXTO INICIAL
        if (textoTV != null)
        {
            textoTV.text =
                "Qual animal mia?\n" +
                "1 - Coelho\n" +
                "2 - Gato\n" +
                "3 - Cachorro";
        }

        // LUZ INICIAL
        if (luzAvatar != null)
        {
            luzAvatar.color = Color.white;
        }
    }

    void Update()
    {
        // =====================================
        // RESPOSTA CORRETA = 2
        // =====================================
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Resposta correta!");

            // TEXTO
            if (textoTV != null)
            {
                textoTV.text =
                    "CORRETO!\n\nA porta abriu!";
            }

            // LUZ AZUL
            if (luzAvatar != null)
            {
                luzAvatar.color = Color.blue;
            }

            // ABRIR PORTA
            aberta = true;

            if (portaPivot != null)
            {
                portaPivot.rotation =
                    Quaternion.Euler(0, 90, 0);
            }
        }

        // =====================================
        // RESPOSTAS ERRADAS = 1 ou 3
        // =====================================
        if (Input.GetKeyDown(KeyCode.Alpha1) ||
            Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("Resposta errada!");

            // TEXTO
            if (textoTV != null)
            {
                textoTV.text =
                    "ERRADO!\n\nTENTE NOVAMENTE";
            }

            // LUZ VERMELHA
            if (luzAvatar != null)
            {
                luzAvatar.color = Color.red;
            }

            // FECHAR PORTA
            aberta = false;

            if (portaPivot != null)
            {
                portaPivot.rotation =
                    Quaternion.Euler(0, 0, 0);
            }
        }
    }
}