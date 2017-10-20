using System.Collections;
using UnityEngine;

public class BarModel : MonoBehaviour {

    [Header("Childs")]
    public GameObject Mesh;
    public Canvas CanvasBar;

    /**************************************************/

    #region Set: Height

    public void SetHeight(float height) {
        Vector3 targetScale = transform.localScale;
        targetScale.y = height;

        Vector3 targetPosition = new Vector3(0.0f, height + 0.2f, 0.0f);
        StartCoroutine(LerpScale(1.0f, targetScale, targetPosition));
    }

    private IEnumerator LerpScale(float time, Vector3 targetScale, Vector3 targetPosition) {
        float originalTime = time;

        while (time > 0.0f) {
            time -= Time.deltaTime;
            transform.localScale = Vector3.Slerp(targetScale, transform.localScale, time / originalTime);
            CanvasBar.transform.localPosition = Vector3.Lerp(targetPosition, CanvasBar.transform.localPosition, time / originalTime);

            yield return null;
        }
    }

    #endregion

}