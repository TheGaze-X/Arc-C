using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x020049EF RID: 18927
	[Token(Token = "0x20049EF")]
	public class InformantMilestonePointDigitItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C7FC RID: 116732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7FC")]
		[Address(RVA = "0x15FF080", Offset = "0x15FDC80", VA = "0x1815FF080")]
		public void SetNumber(int number)
		{
		}

		// Token: 0x0601C7FD RID: 116733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7FD")]
		[Address(RVA = "0x15FF150", Offset = "0x15FDD50", VA = "0x1815FF150")]
		public InformantMilestonePointDigitItemView()
		{
		}

		// Token: 0x0402555A RID: 152922
		[Token(Token = "0x402555A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtDigit;

		// Token: 0x0402555B RID: 152923
		[Token(Token = "0x402555B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Font _textFont;

		// Token: 0x0402555C RID: 152924
		[Token(Token = "0x402555C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetNumber;

		// Token: 0x0402555D RID: 152925
		[Token(Token = "0x402555D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
