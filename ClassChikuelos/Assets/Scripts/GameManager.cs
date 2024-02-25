using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Button btn_Boton1 = null;
    public Button btn_Boton2 = null;
    public Button btn_Boton3 = null;
    public Button btn_Boton4 = null;
    public Button btn_Boton5 = null;
    public Button btn_Boton6 = null;
    public Button btn_Boton7 = null;
    public Button btn_Boton8 = null;
    public Button btn_Boton9 = null;

    public TMP_Text btn_Feedback = null;

    private bool checker = false;
    private bool gameEnded = false;

    public void ganar()
    {
        // Verificar si hay un ganador o empate
        if (
            //Ganar si la primera fila tiene X
            btn_Boton1.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton2.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton3.GetComponentInChildren<TMP_Text>().text == "X" ||
            //Ganar si la segunda fila tiene X
            btn_Boton4.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton5.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton6.GetComponentInChildren<TMP_Text>().text == "X" ||
            //Ganar si la tercera fila tiene X
            btn_Boton7.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton8.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton9.GetComponentInChildren<TMP_Text>().text == "X" ||
            //Ganar si la primera diagonal tiene X
            btn_Boton1.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton5.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton9.GetComponentInChildren<TMP_Text>().text == "X" ||
            //Ganar si la segunda diagonal tiene X
            btn_Boton3.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton5.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton7.GetComponentInChildren<TMP_Text>().text == "X" ||
            //Ganar si la primera columna tiene X
            btn_Boton1.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton4.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton7.GetComponentInChildren<TMP_Text>().text == "X" ||
            //Ganar si la segunda columna tiene X
            btn_Boton2.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton5.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton8.GetComponentInChildren<TMP_Text>().text == "X" ||
            //Ganar si la tercera columna tiene X
            btn_Boton3.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton6.GetComponentInChildren<TMP_Text>().text == "X" && btn_Boton9.GetComponentInChildren<TMP_Text>().text == "X")
        {
            btn_Feedback.text = "El jugador X ha ganado el juego";
            gameEnded = true;
            DesactivarBotones();
        }
        else if (
                 //Ganar si la primera fila tiene X
                 btn_Boton1.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton2.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton3.GetComponentInChildren<TMP_Text>().text == "O" ||
                 //Ganar si la segunda fila tiene X
                 btn_Boton4.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton5.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton6.GetComponentInChildren<TMP_Text>().text == "O" ||
                 //Ganar si la tercera fila tiene X
                 btn_Boton7.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton8.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton9.GetComponentInChildren<TMP_Text>().text == "O" ||
                 //Ganar si la primera diagonal tiene X
                 btn_Boton1.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton5.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton9.GetComponentInChildren<TMP_Text>().text == "O" ||
                 //Ganar si la segunda diagonal tiene X
                 btn_Boton3.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton5.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton7.GetComponentInChildren<TMP_Text>().text == "O" ||
                 //Ganar si la primera columna tiene X
                 btn_Boton1.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton4.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton7.GetComponentInChildren<TMP_Text>().text == "O" ||
                 //Ganar si la segunda columna tiene X
                 btn_Boton2.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton5.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton8.GetComponentInChildren<TMP_Text>().text == "O" ||
                 //Ganar si la tercera columna tiene X
                 btn_Boton3.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton6.GetComponentInChildren<TMP_Text>().text == "O" && btn_Boton9.GetComponentInChildren<TMP_Text>().text == "O")
        {
            btn_Feedback.text = "El jugador O ha ganado el juego";
            gameEnded = true;
            DesactivarBotones();
        }
        //Condicion de empate
        else if (btn_Boton1.GetComponentInChildren<TMP_Text>().text != "" && btn_Boton2.GetComponentInChildren<TMP_Text>().text != "" && btn_Boton3.GetComponentInChildren<TMP_Text>().text != "" &&
                 btn_Boton4.GetComponentInChildren<TMP_Text>().text != "" && btn_Boton5.GetComponentInChildren<TMP_Text>().text != "" && btn_Boton6.GetComponentInChildren<TMP_Text>().text != "" &&
                 btn_Boton7.GetComponentInChildren<TMP_Text>().text != "" && btn_Boton8.GetComponentInChildren<TMP_Text>().text != "" && btn_Boton9.GetComponentInChildren<TMP_Text>().text != "")
        {
            btn_Feedback.text = "Empate";
            gameEnded = true;
        }
    }

    //Checker del boton 1
    public void PresionarBoton1()
    {
        // Verificar si el botón está vacío y el juego no ha terminado
        if (!gameEnded && btn_Boton1.GetComponentInChildren<TMP_Text>().text == "") 
        {
            if (checker == false)
            {
                btn_Boton1.GetComponentInChildren<TMP_Text>().text = "X";
                checker = true;
            }
            else
            {
                btn_Boton1.GetComponentInChildren<TMP_Text>().text = "O";
                checker = false;
            }
            ganar();
        }
    }

    //Checker del boton 2
    public void PresionarBoton2()
    {
        // Verificar si el botón está vacío y el juego no ha terminado
        if (!gameEnded && btn_Boton2.GetComponentInChildren<TMP_Text>().text == "") 
        {
            if (checker == false)
            {
                btn_Boton2.GetComponentInChildren<TMP_Text>().text = "X";
                checker = true;
            }
            else
            {
                btn_Boton2.GetComponentInChildren<TMP_Text>().text = "O";
                checker = false;
            }
            ganar();
        }
    }

    //Checker del boton 3
    public void PresionarBoton3()
    {
        // Verificar si el botón está vacío y el juego no ha terminado
        if (!gameEnded && btn_Boton3.GetComponentInChildren<TMP_Text>().text == "")
        { 
            if (checker == false)
            {
                btn_Boton3.GetComponentInChildren<TMP_Text>().text = "X";


                checker = true;
            }
            else
            {
                btn_Boton3.GetComponentInChildren<TMP_Text>().text = "O";
                checker = false;
            }
            ganar();
        }
    }

    //Checker del boton 4
    public void PresionarBoton4()
    {
        // Verificar si el botón está vacío y el juego no ha terminado
        if (!gameEnded && btn_Boton4.GetComponentInChildren<TMP_Text>().text == "") 
        {
            if (checker == false)
            {
                btn_Boton4.GetComponentInChildren<TMP_Text>().text = "X";
                checker = true;
            }
            else
            {
                btn_Boton4.GetComponentInChildren<TMP_Text>().text = "O";
                checker = false;
            }
            ganar();
        }
    }

    //Checker del boton 5
    public void PresionarBoton5()
    {
        // Verificar si el botón está vacío y el juego no ha terminado
        if (!gameEnded && btn_Boton5.GetComponentInChildren<TMP_Text>().text == "") 
        {
            if (checker == false)
            {
                btn_Boton5.GetComponentInChildren<TMP_Text>().text = "X";
                checker = true;
            }
            else
            {
                btn_Boton5.GetComponentInChildren<TMP_Text>().text = "O";
                checker = false;
            }
            ganar();
        }
    }

    //Checker del boton 6
    public void PresionarBoton6()
    {
        // Verificar si el botón está vacío y el juego no ha terminado
        if (!gameEnded && btn_Boton6.GetComponentInChildren<TMP_Text>().text == "") 
        {
            if (checker == false)
            {
                btn_Boton6.GetComponentInChildren<TMP_Text>().text = "X";
                checker = true;
            }
            else
            {
                btn_Boton6.GetComponentInChildren<TMP_Text>().text = "O";
                checker = false;
            }
            ganar();
        }
    }

    //Checker del boton 7
    public void PresionarBoton7()
    {
        // Verificar si el botón está vacío y el juego no ha terminado
        if (!gameEnded && btn_Boton7.GetComponentInChildren<TMP_Text>().text == "") 
        {
            if (checker == false)
            {
                btn_Boton7.GetComponentInChildren<TMP_Text>().text = "X";
                checker = true;
            }
            else
            {
                btn_Boton7.GetComponentInChildren<TMP_Text>().text = "O";
                checker = false;
            }
            ganar();
        }
    }

    //Checker del boton 8
    public void PresionarBoton8()
    {
        // Verificar si el botón está vacío y el juego no ha terminado
        if (!gameEnded && btn_Boton8.GetComponentInChildren<TMP_Text>().text == "") 
        {
            if (checker == false)
            {
                btn_Boton8.GetComponentInChildren<TMP_Text>().text = "X";
                checker = true;
            }
            else
            {
                btn_Boton8.GetComponentInChildren<TMP_Text>().text = "O";
                checker = false;
            }
            ganar();
        }
    }

    //Checker del boton 9
    public void PresionarBoton9()
    {
        // Verificar si el botón está vacío y el juego no ha terminado
        if (!gameEnded && btn_Boton9.GetComponentInChildren<TMP_Text>().text == "") 
        {
            if (checker == false)
            {
                btn_Boton9.GetComponentInChildren<TMP_Text>().text = "X";
                checker = true;
            }
            else
            {
                btn_Boton9.GetComponentInChildren<TMP_Text>().text = "O";
                checker = false;
            }
            ganar();
        }
    }

    public void RestartGame()
    {
        // Reiniciar el texto de los botones
        btn_Boton1.GetComponentInChildren<TMP_Text>().text = "";
        btn_Boton2.GetComponentInChildren<TMP_Text>().text = "";
        btn_Boton3.GetComponentInChildren<TMP_Text>().text = "";
        btn_Boton4.GetComponentInChildren<TMP_Text>().text = "";
        btn_Boton5.GetComponentInChildren<TMP_Text>().text = "";
        btn_Boton6.GetComponentInChildren<TMP_Text>().text = "";
        btn_Boton7.GetComponentInChildren<TMP_Text>().text = "";
        btn_Boton8.GetComponentInChildren<TMP_Text>().text = "";
        btn_Boton9.GetComponentInChildren<TMP_Text>().text = "";

        // Reiniciar el mensaje de feedback
        btn_Feedback.text = "";

        // Reiniciar el checker
        checker = false;

        // Reiniciar el juego
        gameEnded = false;

        // Activar los botones
        ActivarBotones();
    }

    private void DesactivarBotones()
    {
        btn_Boton1.interactable = false;
        btn_Boton2.interactable = false;
        btn_Boton3.interactable = false;
        btn_Boton4.interactable = false;
        btn_Boton5.interactable = false;
        btn_Boton6.interactable = false;
        btn_Boton7.interactable = false;
        btn_Boton8.interactable = false;
        btn_Boton9.interactable = false;
    }

    private void ActivarBotones()
    {
        btn_Boton1.interactable = true;
        btn_Boton2.interactable = true;
        btn_Boton3.interactable = true;
        btn_Boton4.interactable = true;
        btn_Boton5.interactable = true;
        btn_Boton6.interactable = true;
        btn_Boton7.interactable = true;
        btn_Boton8.interactable = true;
        btn_Boton9.interactable = true;
    }
}