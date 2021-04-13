using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : Interactable
{
    public Material InactiveMaterial;
    public Material GazedAtMaterial;

    public bool gazedAt = false;
    public float gazeInteractTime = 2f;
    public float gazeTimer = 0f;

    private Renderer _myRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _myRenderer = GetComponent<Renderer>();
        SetMaterial(false);
    }

    // Update is called once per frame
    public override void Update()
    {
        // base.Update();
        if (gazedAt) {
            if((gazeTimer += Time.deltaTime) >= gazeInteractTime) {
                Interact();
                gazedAt = false;
                gazeTimer = 0f;
            }
        }
    }

    public void OnPointerEnter()
    {
        SetMaterial(true);
        this.gazedAt = true;
    }

    public void OnPointerExit()
    {
        SetMaterial(false);
        this.gazedAt = false;
        this.gazeTimer = 0f;
    }

    public void OnPointerClick()
    {
        Interact();
    }

    public override void Interact() {
        Debug.Log("Te comiste un hongo.");
        Destroy(this.gameObject);
    }

    private void SetMaterial(bool gazedAt) {
        if (InactiveMaterial != null && GazedAtMaterial != null)
        {
            _myRenderer.material = gazedAt ? GazedAtMaterial : InactiveMaterial;
        }
    }
}
