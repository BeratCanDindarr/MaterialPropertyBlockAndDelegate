using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Color _mainColor = Color.black;

    private Renderer _renderer = null;
    private MaterialPropertyBlock _materialPropertyBlock = null;

    private void OnEnable()
    {
        ClickedManager.setColor += SetRandomColor;
    }
    // Start is called before the first frame update
    void Start()
    {
        _renderer = gameObject.GetComponent<Renderer>();
        _materialPropertyBlock = new MaterialPropertyBlock();
    }

    // Update is called once per frame
 

    void SetRandomColor()
    {
        _mainColor = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        _materialPropertyBlock.SetColor("_Color", _mainColor);
        _renderer.SetPropertyBlock(_materialPropertyBlock);
    }
}
