using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNavigator : MonoBehaviour
{
    public GameObject levelSelector;
    public void levelSelect()
    {
        gameObject.SetActive(false);
        levelSelector.SetActive(true);
    }
        public void levelOne()
    {
        SceneManager.LoadScene("WhackAMole");
        
    }
    public void levelTwo()
    {
        SceneManager.LoadScene("WAM Level 2");
        
    }
}
