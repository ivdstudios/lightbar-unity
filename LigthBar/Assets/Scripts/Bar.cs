using System.Collections;
using UnityEngine;

public class Bar : MonoBehaviour {

    [Header("3D")]
    public BarModel Model;

    [Space(10)]
    [Header("Values")]
    public int MinValue = 0;
    public int MaxValue = 100;
    
    [Space(10)]
    [Header("Height")]
    public float MinHeight = 0.001f;
    public float MaxHeight = 1f;


    private int _value;
    public int Value {
        get {
            return _value;
        }
    }

    private float _initialHeight;
    private float _height;


    /**************************************************/

    #region Awake

    private void Awake() {
        Init();
    }

    #endregion

    #region Init

    private void Init() {
        _initialHeight = Model.Mesh.transform.localScale.y;
        SetValue(0);
    }

    #endregion


    #region Set: Value

    public void SetValue(int newValue) {
        _value = newValue;

        #region Set: Height

        if (newValue <= MinValue) {
            _height = MinHeight;

        } else if (newValue >= MaxValue) {
            _height = MaxHeight;

        } else {
            int percent = MathHelper.GetPercentByMaxAndMin(_value, MinValue, MaxValue);
            _height = MinHeight + ((percent * _initialHeight) / 100);
        }

        Model.SetHeight(_height);

        #endregion

    }

    #endregion


    #region Test

    public void Increase10() {
        SetValue(_value + 10);
    }

    public void Decrease10() {
        SetValue(_value - 10);
    }

    #endregion

}