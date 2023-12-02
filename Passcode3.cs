using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Passcode3 : MonoBehaviour
{
    string Code3 = "310719";
    string Nr3 = null;
    int NrIndex3 = 0;
    string alpha;
    public Text UiText3 = null;

    public void CodeFunction3(string Numbers)
    {
        NrIndex3++;
        Nr3 = Nr3 + Numbers;
        UiText3.text = Nr3;

    }
    public void Enter3()
    {
        if (Nr3 == Code3)
        {
            SceneManager.LoadScene(7);
        }
    }
    public void Delete3()
    {
        NrIndex3++;
        Nr3 = null;
        UiText3.text = Nr3;
    }
    public void StartButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}