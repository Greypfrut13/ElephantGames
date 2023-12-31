using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    [SerializeField] private int _sceneLoadIndex;

    private Button _button;

    private void Start() 
    {
        gameObject.SetActive(false);

        _button = GetComponent<Button>();
        _button.onClick.AddListener(LoadNextScene);
    }

    public void ActivateButton()
    {
        gameObject.SetActive(true);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(_sceneLoadIndex);
    }
}
