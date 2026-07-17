using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenChange : MonoBehaviour
{
    public void ChangeSceen(string name)
    {
        GameManager.Instance.ChangeScences(name);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
