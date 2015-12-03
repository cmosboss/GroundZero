using UnityEngine;
using System.Collections;

public class MoveHealth : MonoBehaviour {
    public float scale = 0f;
    public RectTransform rectTransform;
	// Use this for initialization
	void Update () {
        rectTransform.localScale = new Vector3( rectTransform.localScale.x, scale, rectTransform.localScale.z);
	}

    public void AdjustScale(float adj) {
        if (adj < 0) {
            adj = 0;
        } else if (adj > 1) {
            adj = 1;
        }
        scale = adj;
    }
}
