using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Torappu
{
	// Token: 0x0200054B RID: 1355
	[Token(Token = "0x200054B")]
	public class DragCancellableClickHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IDragHandler
	{
		// Token: 0x06005A9C RID: 23196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9C")]
		[Address(RVA = "0x1AED820", Offset = "0x1AEC420", VA = "0x181AED820", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06005A9D RID: 23197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9D")]
		[Address(RVA = "0x1AED880", Offset = "0x1AEC480", VA = "0x181AED880", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06005A9E RID: 23198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9E")]
		[Address(RVA = "0x1AED810", Offset = "0x1AEC410", VA = "0x181AED810", Slot = "6")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06005A9F RID: 23199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9F")]
		[Address(RVA = "0x1AED890", Offset = "0x1AEC490", VA = "0x181AED890")]
		public DragCancellableClickHandler()
		{
		}

		// Token: 0x0400205B RID: 8283
		[Token(Token = "0x400205B")]
		[FieldOffset(Offset = "0x18")]
		public DragCancellableClickHandler.ClickEvent onClicked;

		// Token: 0x0400205C RID: 8284
		[Token(Token = "0x400205C")]
		[FieldOffset(Offset = "0x20")]
		private bool m_hasDragDetacted;

		// Token: 0x0200054C RID: 1356
		[Token(Token = "0x200054C")]
		[Serializable]
		public class ClickEvent : UnityEvent<PointerEventData>
		{
			// Token: 0x06005AA0 RID: 23200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AA0")]
			[Address(RVA = "0x1AEA750", Offset = "0x1AE9350", VA = "0x181AEA750")]
			public ClickEvent()
			{
			}
		}
	}
}
