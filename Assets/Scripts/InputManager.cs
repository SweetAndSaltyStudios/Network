using UnityEngine;

namespace Sweet_And_Salty_Studios
{
    public class InputManager : MonoBehaviour
    {
        #region VARIABLES

        private Camera mainCamera;
        private Transform currentInteractable;

        #endregion VARIABLES

        #region PROPERTIES

        #endregion PROPERTIES

        #region UNITY_FUNCTIONS

        private void Awake()
        {
            mainCamera = Camera.main;
        }

        private void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                DoRaycast();
            }

            if(Input.GetMouseButton(0))
            {
                if(currentInteractable == null)
                {
                    return;
                }

                currentInteractable.position = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            }

            if(Input.GetMouseButtonUp(0))
            {
                currentInteractable = null;
            }
        }

        #endregion UNITY_FUNCTIONS

        #region CUSTOM_FUNCTIONS

        private void DoRaycast()
        {
            var mouseRay = mainCamera.ScreenPointToRay(Input.mousePosition);

            var hitResult = Physics2D.Raycast(mouseRay.origin, mouseRay.direction);

            if(hitResult.collider == null)
            {
                return;
            }

            switch(hitResult.collider.gameObject.layer)
            {
                case 8:
                    currentInteractable = hitResult.collider.transform;
                    break;

                default:

                    break;
            }
        }

        #endregion CUSTOM_FUNCTIONS
    }
}
