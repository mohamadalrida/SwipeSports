using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneField : MonoBehaviour
{

    [SerializeField]
    private Object m_SceneAsset;
    [SerializeField]
    private string m_SceneName = "";
    public string SceneName
    {
         get { return m_SceneName; }
    }

    // makes it work with the existing Unity methods (LoadLevel/LoadScene)
    public static implicit operator string(SceneField sceneField)
    {
        return sceneField.SceneName;
    }

    //public void ScreenSwitcher()
    //{
    //    SceneManager.LoadScene(m_SceneName);
    //}

    private void OnTriggerEnter2D(Collider2D Ball)
    {
        SceneManager.LoadScene(m_SceneName);
    }

}
