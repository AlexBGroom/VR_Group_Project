using UnityEngine;
using System.Collections; 

///Summary
/// Calcualtes the player wrist rotation to check for the input to chnage the watch screen
/// Summary

public class PlayerWatchMotionController : MonoBehaviour
{
    [SerializeField] PlayerWatchManager playerWatchManager;
    [SerializeField] float requieredRotationChange;
    [SerializeField] float motionTimeFrame;

    private Quaternion previousRotation;
    private Quaternion currentRotation;

    private Vector3 totalRotationChange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        previousRotation = transform.rotation;
        totalRotationChange = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        currentRotation = transform.rotation;
        StartCoroutine(CheckWatchMovement());
    }

    private IEnumerator CheckWatchMovement()
    {
        yield return new WaitForSeconds(motionTimeFrame);
        float rotationChange = previousRotation.z - currentRotation.z;

        if (rotationChange >= requieredRotationChange)
        {
            Debug.Log("Screen change triggered");
            //playerWatchManager.ChangeWatchScreen();
        }

        previousRotation = currentRotation;
    }

}
