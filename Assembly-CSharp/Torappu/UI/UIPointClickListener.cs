using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Torappu.UI
{
	// Token: 0x02003818 RID: 14360
	[Token(Token = "0x2003818")]
	public class UIPointClickListener : EventTrigger
	{
		// Token: 0x06016C6B RID: 93291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C6B")]
		[Address(RVA = "0xF46D90", Offset = "0xF45990", VA = "0x180F46D90", Slot = "25")]
		public override void OnPointerDown(PointerEventData param)
		{
		}

		// Token: 0x06016C6C RID: 93292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C6C")]
		[Address(RVA = "0xF46C60", Offset = "0xF45860", VA = "0x180F46C60", Slot = "23")]
		public override void OnDrag(PointerEventData param)
		{
		}

		// Token: 0x06016C6D RID: 93293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C6D")]
		[Address(RVA = "0xF46E20", Offset = "0xF45A20", VA = "0x180F46E20", Slot = "26")]
		public override void OnPointerUp(PointerEventData param)
		{
		}

		// Token: 0x06016C6E RID: 93294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C6E")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public UIPointClickListener()
		{
		}

		// Token: 0x0401B737 RID: 112439
		[Token(Token = "0x401B737")]
		private const float MOVE_SQR_THRESHOLD = 25f;

		// Token: 0x0401B738 RID: 112440
		[Token(Token = "0x401B738")]
		[FieldOffset(Offset = "0x20")]
		private Vector2? m_downPosition;

		// Token: 0x0401B739 RID: 112441
		[Token(Token = "0x401B739")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_isValidClick;

		// Token: 0x0401B73A RID: 112442
		[Token(Token = "0x401B73A")]
		[FieldOffset(Offset = "0x30")]
		public Action eventPointClicked;
	}
}
