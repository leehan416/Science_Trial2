using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Name : MonoBehaviour {
    public void Home() {
        SceneManager.LoadScene("Main");
    }

    public void Moveveve(string M) {
        SceneManager.LoadScene(M);
    }
}
