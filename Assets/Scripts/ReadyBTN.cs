using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ReadyBTN : MonoBehaviour
{
    public void Ready()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
