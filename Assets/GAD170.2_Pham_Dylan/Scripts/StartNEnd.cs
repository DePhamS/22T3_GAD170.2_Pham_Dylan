using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DylanPham
{
    public class StartNEnd : MonoBehaviour
    {
        public void StartButton()
        {
            SceneManager.LoadScene(1);
        }

        public void QuitButton()
        {
            Application.Quit();
            print("Damn bro... ok");
        }

        public void ReturnButton()
        {
            SceneManager.LoadScene(0);
        }
    }
}

