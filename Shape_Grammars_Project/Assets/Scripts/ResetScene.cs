using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    public void reLoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
