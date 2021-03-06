using UnityEngine;

public class CameraContoller : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position- player.transform.position;
    }
    
    void Update()
    {
        if(player!=null)
            transform.position = player.transform.position+offset;
    }
}
