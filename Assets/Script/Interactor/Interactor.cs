using UnityEngine;

public class Interactor : MonoBehaviour
{
    [SerializeField] private float _distance;

    private Transform _cameraTransform;
    private IInteractableObject _current;

    private void Awake()
    {
        _cameraTransform = Camera.main.transform;
    }

    private void Update()
    {
        Ray ray = new Ray(
              _cameraTransform.position,
              _cameraTransform.forward);


        if (Physics.Raycast(ray, out RaycastHit hit, _distance))
        {
            if (hit.collider.TryGetComponent(out IInteractableObject interactable))
            {
                Debug.Log(hit.collider.name);
                interactable.Interact();

                if (_current == interactable)
                    return;

                _current?.HideHint();
                _current = interactable;
                _current.ShowHint();

                return;
            }
        }

        _current?.HideHint();
        _current = null;
    }
}
