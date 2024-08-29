using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    //https://github.com/casterfile/UnityTest01
    [SerializeField]
    TMP_InputField tMP_InputField;
    [SerializeField]
    TMP_Text output;
    public static string m_PlayerName;
    public static int m_highscore;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        
        if(PlayerPrefs.GetInt("m_highscore") > 0)
        {
            m_PlayerName = PlayerPrefs.GetString("m_PlayerName");
            output.text = "Best Score: " + m_PlayerName + " " + PlayerPrefs.GetInt("m_highscore") + "";
        }
        else
        {
            output.text = "Best Score ";
        }
        
    }

    // Update is called once per frame
    public void SaveName()
    {
        if(tMP_InputField.text.Length > 0)
        {
            //PlayerPrefs.SetString("m_PlayerName", tMP_InputField.text);

            m_PlayerName = tMP_InputField.text;
            Debug.Log(tMP_InputField.text);
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
    }
}
