using UnityEngine;
using TMPro;

public class TourManager : MonoBehaviour
{
    [Header("Section Spheres")]
    public GameObject entranceSphere;
    public GameObject readingSphere1;
    public GameObject readingSphere2;
    public GameObject bookSphere1;
    public GameObject bookSphere2;
    public GameObject computerSphere;

    [Header("UI")]
    public TMP_Text sceneLabel;

    void Start()
    {
        ShowEntrance();
    }

    public void ShowEntrance()
    {
        ShowOnly(entranceSphere);
        UpdateSceneLabel("ENTRANCE");
    }

    public void ShowReading1()
    {
        ShowOnly(readingSphere1);
        UpdateSceneLabel("READING 1");
    }

    public void ShowReading2()
    {
        ShowOnly(readingSphere2);
        UpdateSceneLabel("READING 2");
    }

    public void ShowBooks1()
    {
        ShowOnly(bookSphere1);
        UpdateSceneLabel("BOOKS 1");
    }

    public void ShowBooks2()
    {
        ShowOnly(bookSphere2);
        UpdateSceneLabel("BOOKS 2");
    }

    public void ShowComputer()
    {
        ShowOnly(computerSphere);
        UpdateSceneLabel("COMPUTER");
    }

    private void ShowOnly(GameObject selectedSphere)
    {
        entranceSphere.SetActive(false);
        readingSphere1.SetActive(false);
        readingSphere2.SetActive(false);
        bookSphere1.SetActive(false);
        bookSphere2.SetActive(false);
        computerSphere.SetActive(false);

        selectedSphere.SetActive(true);
    }

    private void UpdateSceneLabel(string labelName)
    {
        if (sceneLabel != null)
        {
            sceneLabel.text = labelName;
            Debug.Log("Scene Label changed to: " + labelName);
        }
        else
        {
            Debug.LogError("SceneLabel is NOT assigned in TourManager!");
        }
    }
}