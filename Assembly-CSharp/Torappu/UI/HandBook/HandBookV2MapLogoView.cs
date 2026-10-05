using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200670A RID: 26378
	[Token(Token = "0x200670A")]
	public class HandBookV2MapLogoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025DB4 RID: 155060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DB4")]
		[Address(RVA = "0x20E21C0", Offset = "0x20E0DC0", VA = "0x1820E21C0")]
		public void Render(HandBookV2ForceViewModel viewModel)
		{
		}

		// Token: 0x06025DB5 RID: 155061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DB5")]
		[Address(RVA = "0x20E23C0", Offset = "0x20E0FC0", VA = "0x1820E23C0")]
		public HandBookV2MapLogoView()
		{
		}

		// Token: 0x040353B3 RID: 218035
		[Token(Token = "0x40353B3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgLogo;

		// Token: 0x040353B4 RID: 218036
		[Token(Token = "0x40353B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040353B5 RID: 218037
		[Token(Token = "0x40353B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
