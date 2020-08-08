using UnityEngine;
using UnityEngine.EventSystems;

namespace Sweet_And_Salty_Studios
{
    public abstract class Interactable : MonoBehaviour,
        IBeginDragHandler,
        ICancelHandler,
        IDeselectHandler,
        IDragHandler,
        IDropHandler,
        IEndDragHandler,
        IEventSystemHandler,
        IInitializePotentialDragHandler,
        IMoveHandler,
        IPointerClickHandler,
        IPointerDownHandler,
        IPointerEnterHandler,
        IPointerExitHandler,
        IPointerUpHandler,
        IScrollHandler,
        ISelectHandler,
        ISubmitHandler,
        IUpdateSelectedHandler
    {
        #region VARIABLES

        #endregion VARIABLES

        #region PROPERTIES

        #endregion PROPERTIES

        #region UNITY_FUNCTIONS

        #endregion UNITY_FUNCTIONS

        #region CUSTOM_FUNCTIONS

        public virtual void OnBeginDrag(PointerEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnBeginDrag");
        }

        public virtual void OnCancel(BaseEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnCancel");
        }

        public virtual void OnDeselect(BaseEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnDeselect");
        }

        public virtual void OnDrag(PointerEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnDrag");
        }

        public virtual void OnDrop(PointerEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnDrop");
        }

        public virtual void OnEndDrag(PointerEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnEndDrag");
        }

        public virtual void OnInitializePotentialDrag(PointerEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnInitializePotentialDrag");
        }

        public virtual void OnMove(AxisEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnMove");
        }

        public virtual void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnPointerClick");
        }

        public virtual void OnPointerDown(PointerEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnPointerDown");
        }

        public virtual void OnPointerEnter(PointerEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnPointerEnter");
        }

        public virtual void OnPointerExit(PointerEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnPointerExit");
        }

        public virtual void OnPointerUp(PointerEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnPointerUp");
        }

        public virtual void OnScroll(PointerEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnScroll");
        }

        public virtual void OnSelect(BaseEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnSelect");
        }

        public virtual void OnSubmit(BaseEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnSubmit");
        }

        public virtual void OnUpdateSelected(BaseEventData eventData)
        {
            Debug.Log($"{gameObject.name} OnUpdateSelected");
        }

        #endregion CUSTOM_FUNCTIONS
    }
}
