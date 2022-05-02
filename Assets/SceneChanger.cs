using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update

    public void ChangeSceneByName_asdf(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }



}
