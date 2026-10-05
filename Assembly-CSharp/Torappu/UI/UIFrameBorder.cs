using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Torappu.UI
{
	// Token: 0x020037FE RID: 14334
	[Token(Token = "0x20037FE")]
	public class UIFrameBorder : UIBehaviour
	{
		// Token: 0x06016B4C RID: 93004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B4C")]
		[Address(RVA = "0xF14450", Offset = "0xF13050", VA = "0x180F14450", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06016B4D RID: 93005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B4D")]
		[Address(RVA = "0xF14450", Offset = "0xF13050", VA = "0x180F14450", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06016B4E RID: 93006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B4E")]
		[Address(RVA = "0xF14450", Offset = "0xF13050", VA = "0x180F14450", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x06016B4F RID: 93007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B4F")]
		[Address(RVA = "0xF14470", Offset = "0xF13070", VA = "0x180F14470")]
		[Inspect]
		public void UpdateBorders()
		{
		}

		// Token: 0x06016B50 RID: 93008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B50")]
		[Address(RVA = "0xF14480", Offset = "0xF13080", VA = "0x180F14480")]
		private void _UpdateBordersInternal()
		{
		}

		// Token: 0x06016B51 RID: 93009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B51")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public UIFrameBorder()
		{
		}

		// Token: 0x0401B5CD RID: 112077
		[Token(Token = "0x401B5CD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Same Parent Border")]
		private RectTransform _left;

		// Token: 0x0401B5CE RID: 112078
		[Token(Token = "0x401B5CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Same Parent Border")]
		private RectTransform _top;

		// Token: 0x0401B5CF RID: 112079
		[Token(Token = "0x401B5CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Same Parent Border")]
		private RectTransform _right;

		// Token: 0x0401B5D0 RID: 112080
		[Token(Token = "0x401B5D0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Same Parent Border")]
		private RectTransform _bottom;

		// Token: 0x0401B5D1 RID: 112081
		[Token(Token = "0x401B5D1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _center;
	}
}
