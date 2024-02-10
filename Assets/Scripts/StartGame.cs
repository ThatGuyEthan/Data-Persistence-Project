using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public TMP_InputField inputField;

    public void ToMain()
    {
        if (inputField.text != "")
        {
            DataSaver.Instance.playerName = inputField.text;
        }
        SceneManager.LoadScene(1);
    }
}
