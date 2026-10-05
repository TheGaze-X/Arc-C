using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Torappu.UI
{
	// Token: 0x02003842 RID: 14402
	[Token(Token = "0x2003842")]
	public class UITouchToHover : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x06016D2E RID: 93486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D2E")]
		[Address(RVA = "0xF52CA0", Offset = "0xF518A0", VA = "0x180F52CA0", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06016D2F RID: 93487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D2F")]
		[Address(RVA = "0xF52CF0", Offset = "0xF518F0", VA = "0x180F52CF0", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06016D30 RID: 93488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D30")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UITouchToHover()
		{
		}

		// Token: 0x0401B85D RID: 112733
		[Token(Token = "0x401B85D")]
		[FieldOffset(Offset = "0x18")]
		public UITouchToHover.OnHoverEvent onHover;

		// Token: 0x02003843 RID: 14403
		[Token(Token = "0x2003843")]
		[Serializable]
		public class OnHoverEvent : UnityEvent<bool>
		{
			// Token: 0x06016D31 RID: 93489 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016D31")]
			[Address(RVA = "0xF3ABD0", Offset = "0xF397D0", VA = "0x180F3ABD0")]
			public OnHoverEvent()
			{
			}
		}
	}
}
