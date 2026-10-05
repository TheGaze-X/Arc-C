using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Torappu.AVG
{
	// Token: 0x02001F8E RID: 8078
	[Token(Token = "0x2001F8E")]
	public class HandleDragListener : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		// Token: 0x0600C8C3 RID: 51395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8C3")]
		[Address(RVA = "0x5134D0", Offset = "0x5120D0", VA = "0x1805134D0", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600C8C4 RID: 51396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8C4")]
		[Address(RVA = "0x3498690", Offset = "0x3497290", VA = "0x183498690", Slot = "6")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600C8C5 RID: 51397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8C5")]
		[Address(RVA = "0x5134F0", Offset = "0x5120F0", VA = "0x1805134F0", Slot = "5")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600C8C6 RID: 51398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8C6")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandleDragListener()
		{
		}

		// Token: 0x0400CF59 RID: 53081
		[Token(Token = "0x400CF59")]
		[FieldOffset(Offset = "0x18")]
		public Action onBeginDrag;

		// Token: 0x0400CF5A RID: 53082
		[Token(Token = "0x400CF5A")]
		[FieldOffset(Offset = "0x20")]
		public Action onEndDrag;
	}
}
