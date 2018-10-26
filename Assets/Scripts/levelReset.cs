using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelReset : MonoBehaviour {

    public string NameLevel;
    public float waitTime = 2f;

    public void LevelLoad(string NameLevelString)
    {
        Invoke("Level",waitTime);
        NameLevel = NameLevelString;
        //SceneManager.LoadScene(Level);
    }
    void Level()
    {
        SceneManager.LoadScene(NameLevel);
    }
    //public void ModeSelect()
    //{
    //    StartCoroutine("Wait");

    //}

    //public IEnumerator Wait(string Level)
    //{
    //    yield return new WaitForSeconds(2);

    //    SceneManager.LoadScene(Level);
    //}
}



