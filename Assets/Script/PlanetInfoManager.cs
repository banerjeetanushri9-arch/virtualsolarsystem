
using UnityEngine;
using TMPro;

public class PlanetInfoManager : MonoBehaviour
{
    public GameObject infoPanel;
    public TMP_Text planetName;
    public TMP_Text planetDetails;

    private Camera mainCamera;
    private Vector3 originalPosition;
    private Quaternion originalRotation;

    void Start()
    {
        mainCamera = Camera.main;

        originalPosition = mainCamera.transform.position;
        originalRotation = mainCamera.transform.rotation;

        infoPanel.SetActive(false);
    }

    public void ShowPlanet(Transform planet, string name, string details)
    {
        Time.timeScale = 0f;

        infoPanel.SetActive(true);

        planetName.text = name;
        planetDetails.text = details;

        Vector3 direction =
            (mainCamera.transform.position - planet.position).normalized;

        mainCamera.transform.position = planet.position + direction * 5f;
        mainCamera.transform.LookAt(planet.position);
    }

    public void GoBack()
    {
        mainCamera.transform.position = originalPosition;
        mainCamera.transform.rotation = originalRotation;

        infoPanel.SetActive(false);

        Time.timeScale = 1f;
    }
}
