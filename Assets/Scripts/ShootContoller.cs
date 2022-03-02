using UnityEngine;

public class ShootContoller : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _spawnPoint; 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_bullet,_spawnPoint.transform.position,_spawnPoint.transform.rotation);
        }
    }
}
