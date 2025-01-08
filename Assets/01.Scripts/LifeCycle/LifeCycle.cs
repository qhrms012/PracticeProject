using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeCycle : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("��ŸƮ awake" + SceneManager.GetActiveScene().name);
    }
    private void OnEnable()
    {
        Debug.Log("��ŸƮ OnEnable"+ SceneManager.GetActiveScene().name);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("��ŸƮ Start" + SceneManager.GetActiveScene().name);
    }

    private void FixedUpdate()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        
    }
    private void OnDisable()
    {
        Debug.Log("��ŸƮ OnDisalbe" + SceneManager.GetActiveScene().name);
    }
    private void OnDestroy()
    {
        Debug.Log("��ŸƮ OnDestroy" + SceneManager.GetActiveScene().name);
    }
    private void OnApplicationQuit()
    {
        
    }

    public void SceneButton2()
    {
        SceneManager.LoadScene("SampleScene2");
    }
    public void SceneButton1()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
