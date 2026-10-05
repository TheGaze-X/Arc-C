using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C12 RID: 19474
	[Token(Token = "0x2004C12")]
	public class HomeMissionTrackPoint : HomeTrackPointItem
	{
		// Token: 0x0601D41F RID: 119839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D41F")]
		[Address(RVA = "0x16D5990", Offset = "0x16D4590", VA = "0x1816D5990", Slot = "4")]
		public override void Render(ITrackPointModel value)
		{
		}

		// Token: 0x0601D420 RID: 119840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D420")]
		[Address(RVA = "0x16D5AE0", Offset = "0x16D46E0", VA = "0x1816D5AE0")]
		public HomeMissionTrackPoint()
		{
		}

		// Token: 0x0402675A RID: 157530
		[Token(Token = "0x402675A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0402675B RID: 157531
		[Token(Token = "0x402675B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402675C RID: 157532
		[Token(Token = "0x402675C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
