using UnityEngine;

public class ChangerInAllDirections : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;

    private void Update()
    {
        transform.localScale += Vector3.one * _growthSpeed * Time.deltaTime;
    }
}
