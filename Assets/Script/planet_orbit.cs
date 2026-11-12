
using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public float orbitSpeed = 10f;

    void Update()
    {
        transform.Rotate(Vector3.up * orbitSpeed * Time.deltaTime);
    }
}
