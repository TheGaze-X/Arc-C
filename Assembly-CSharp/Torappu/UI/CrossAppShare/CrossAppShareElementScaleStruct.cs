using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058D5 RID: 22741
	[Token(Token = "0x20058D5")]
	public struct CrossAppShareElementScaleStruct : IHotfixable
	{
		// Token: 0x060212A5 RID: 135845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212A5")]
		[Address(RVA = "0x1B73DC0", Offset = "0x1B729C0", VA = "0x181B73DC0")]
		public void InitScale(Transform target)
		{
		}

		// Token: 0x060212A6 RID: 135846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212A6")]
		[Address(RVA = "0x1B73C60", Offset = "0x1B72860", VA = "0x181B73C60")]
		public void ApplyScale(Transform target)
		{
		}

		// Token: 0x0402D2D0 RID: 185040
		[Token(Token = "0x402D2D0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CrossAppShareElementScaleStruct Empty;

		// Token: 0x0402D2D1 RID: 185041
		[Token(Token = "0x402D2D1")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isUIScaler;

		// Token: 0x0402D2D2 RID: 185042
		[Token(Token = "0x402D2D2")]
		[FieldOffset(Offset = "0x4")]
		private float m_uiScale;

		// Token: 0x0402D2D3 RID: 185043
		[Token(Token = "0x402D2D3")]
		[FieldOffset(Offset = "0x8")]
		private Vector2 m_localScale;

		// Token: 0x0402D2D4 RID: 185044
		[Token(Token = "0x402D2D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitScale;

		// Token: 0x0402D2D5 RID: 185045
		[Token(Token = "0x402D2D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyScale;
	}
}
