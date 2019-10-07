using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class ToggleAR : MonoBehaviour {

    public Toggle toggle;
    public ARPlaneManager planeManager;
    public ARPointCloudManager pointCloudManager;

    bool activeState = true;

    public void OnValueChanged(bool isOn) {
        activeState = isOn;
        VisualizePlanes();
        VisualizePoints();
    }

    void VisualizePlanes() {
        planeManager.enabled = activeState;
        foreach (ARPlane plane in planeManager.trackables) {
            plane.gameObject.SetActive(activeState);
        }
    }

    void VisualizePoints() {
        pointCloudManager.enabled = activeState;
        foreach (ARPointCloud pointCLoud in pointCloudManager.trackables) {
            pointCLoud.gameObject.SetActive(activeState);
        }
    }
}
