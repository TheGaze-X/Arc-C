using System;
using System.Collections.Generic;
using System.ComponentModel;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	[AddComponentMenu("Event/Event Trigger")]
	public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
	{
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001DB")]
		[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public List<EventTrigger.Entry> delegates
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x5B87B40", Offset = "0x5B86740", VA = "0x185B87B40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected EventTrigger()
		{
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001DC")]
		public List<EventTrigger.Entry> triggers
		{
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x5B87B50", Offset = "0x5B86750", VA = "0x185B87B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x5B878D0", Offset = "0x5B864D0", VA = "0x185B878D0")]
		private void Execute(EventTriggerType id, BaseEventData eventData)
		{
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x5B87AD0", Offset = "0x5B866D0", VA = "0x185B87AD0", Slot = "21")]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x5B87AE0", Offset = "0x5B866E0", VA = "0x185B87AE0", Slot = "22")]
		public virtual void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x5B87A60", Offset = "0x5B86660", VA = "0x185B87A60", Slot = "23")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x5B87A70", Offset = "0x5B86670", VA = "0x185B87A70", Slot = "24")]
		public virtual void OnDrop(PointerEventData eventData)
		{
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x5B87AC0", Offset = "0x5B866C0", VA = "0x185B87AC0", Slot = "25")]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x5B87AF0", Offset = "0x5B866F0", VA = "0x185B87AF0", Slot = "26")]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x5B87AB0", Offset = "0x5B866B0", VA = "0x185B87AB0", Slot = "27")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x5B87B10", Offset = "0x5B86710", VA = "0x185B87B10", Slot = "28")]
		public virtual void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x5B87A50", Offset = "0x5B86650", VA = "0x185B87A50", Slot = "29")]
		public virtual void OnDeselect(BaseEventData eventData)
		{
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x5B87B00", Offset = "0x5B86700", VA = "0x185B87B00", Slot = "30")]
		public virtual void OnScroll(PointerEventData eventData)
		{
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x5B87AA0", Offset = "0x5B866A0", VA = "0x185B87AA0", Slot = "31")]
		public virtual void OnMove(AxisEventData eventData)
		{
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x5B87B30", Offset = "0x5B86730", VA = "0x185B87B30", Slot = "32")]
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x5B87A90", Offset = "0x5B86690", VA = "0x185B87A90", Slot = "33")]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x5B87A30", Offset = "0x5B86630", VA = "0x185B87A30", Slot = "34")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x5B87A80", Offset = "0x5B86680", VA = "0x185B87A80", Slot = "35")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x5B87B20", Offset = "0x5B86720", VA = "0x185B87B20", Slot = "36")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x5B87A40", Offset = "0x5B86640", VA = "0x185B87A40", Slot = "37")]
		public virtual void OnCancel(BaseEventData eventData)
		{
		}

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("delegates")]
		private List<EventTrigger.Entry> m_Delegates;

		// Token: 0x020000C6 RID: 198
		[Token(Token = "0x20000C6")]
		[Serializable]
		public class TriggerEvent : UnityEvent<BaseEventData>
		{
			// Token: 0x060006FF RID: 1791 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x5B97D30", Offset = "0x5B96930", VA = "0x185B97D30")]
			public TriggerEvent()
			{
			}
		}

		// Token: 0x020000C7 RID: 199
		[Token(Token = "0x20000C7")]
		[Serializable]
		public class Entry
		{
			// Token: 0x06000700 RID: 1792 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x5B85080", Offset = "0x5B83C80", VA = "0x185B85080")]
			public Entry()
			{
			}

			// Token: 0x04000346 RID: 838
			[Token(Token = "0x4000346")]
			[FieldOffset(Offset = "0x10")]
			public EventTriggerType eventID;

			// Token: 0x04000347 RID: 839
			[Token(Token = "0x4000347")]
			[FieldOffset(Offset = "0x18")]
			public EventTrigger.TriggerEvent callback;
		}
	}
}
