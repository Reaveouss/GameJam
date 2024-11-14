using UnityEngine;

public class MapChanging : MonoBehaviour
{
    public Collider2D Collider;
    [SerializeField] public Camera Camera;
    [SerializeField] public Camera Camera2;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Camera.enabled = false;
        Camera2.enabled = true;
    }
}
