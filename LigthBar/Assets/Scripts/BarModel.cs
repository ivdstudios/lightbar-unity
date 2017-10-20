using System.Collections;
using UnityEngine;

public class BarModel : MonoBehaviour {

    public GameObject Mesh;

    /**************************************************/

    #region Set: Height

    public void SetHeight(float height) {
        Vector3 targetScale = transform.localScale;
        targetScale.y = height;

        StartCoroutine(LerpScale(1.0f, targetScale));
    }

    private IEnumerator LerpScale(float time, Vector3 targetScale) {
        float originalTime = time;

        while (time > 0.0f) {
            time -= Time.deltaTime;
            transform.localScale = Vector3.Lerp(targetScale, transform.localScale, time / originalTime);

            yield return null;
        }
    }

    #endregion

}