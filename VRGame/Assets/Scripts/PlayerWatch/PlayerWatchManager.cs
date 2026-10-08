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
        ScannerCheck();
    }

    private void ScannerCheck()
    {
        RaycastHit hit;
        
        if(Physics.Raycast(scannerPoint.transform.position, scannerPoint.transform.forward, out hit, rayRange))
        {
            Debug.Log(hit.collider);
            if (hit.collider.TryGetComponent<IScannable>(out IScannable scannable))
            {
                //scannable.Scan();
                Debug.Log("Scanner found");
            }
            else
            {
                Debug.Log("Scanner not found");
            }
        }
    }

    private void EnableScanner()
    {
        
    }

    private void ObjectScan()
    {
        
    }
}
