using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C13 RID: 19475
	[Token(Token = "0x2004C13")]
	public class HomeRecruitTrackPoint : HomeTrackPointItem, IHotfixable
	{
		// Token: 0x0601D421 RID: 119841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D421")]
		[Address(RVA = "0x16D5B40", Offset = "0x16D4740", VA = "0x1816D5B40", Slot = "4")]
		public override void Render(ITrackPointModel value)
		{
		}

		// Token: 0x0601D422 RID: 119842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D422")]
		[Address(RVA = "0x16D5C90", Offset = "0x16D4890", VA = "0x1816D5C90")]
		public HomeRecruitTrackPoint()
		{
		}

		// Token: 0x0402675D RID: 157533
		[Token(Token = "0x402675D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textNum;

		// Token: 0x0402675E RID: 157534
		[Token(Token = "0x402675E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402675F RID: 157535
		[Token(Token = "0x402675F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
