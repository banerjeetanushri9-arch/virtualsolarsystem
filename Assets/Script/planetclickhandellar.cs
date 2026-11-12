
using UnityEngine;

public class PlanetClickHandler : MonoBehaviour
{
    public PlanetInfoManager manager;

    public string planetName;
    [TextArea(3, 6)]
    public string planetDetails;

    void OnMouseDown()
    {
        manager.ShowPlanet(transform, planetName, planetDetails);
    }
}
