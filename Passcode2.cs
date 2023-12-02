using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Passcode2 : MonoBehaviour
{
    string Code2 = "070166";
    string Nr2 = null;
    int NrIndex2 = 0;
    string alpha;
    public Text UiText2 = null;

    public void CodeFunction2(string Numbers)
    {
        NrIndex2++;
        Nr2 = Nr2 + Numbers;
        UiText2.text = Nr2;

    }
    public void Enter2()
    {
        if (Nr2 == Code2)
        {
            SceneManager.LoadScene(4);
        }
    }
    public void Delete2()
    {
        NrIndex2++;
        Nr2 = null;
        UiText2.text = Nr2;
    }
        public void StartButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}