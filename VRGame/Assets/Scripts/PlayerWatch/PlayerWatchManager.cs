using UnityEngine;

public class PlayerWatchManager : MonoBehaviour
{
    [SerializeField] GameObject scannerPoint;
    [SerializeField] float rayRange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ScannerCheck()
    {
        RaycastHit hit;
        
        if(Physics.Raycast(scannerPoint.transform.position, scannerPoint.transform.forward, out hit, rayRange))
        {
            Debug.Log(hit.collider);
        }
    }
}
