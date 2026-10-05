using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005290 RID: 21136
	[Token(Token = "0x2005290")]
	public abstract class RoguelikeClassicEndingMonthStatsCharView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F2FA RID: 127738
		[Token(Token = "0x601F2FA")]
		public abstract void Init();

		// Token: 0x0601F2FB RID: 127739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2FB")]
		[Address(RVA = "0x18E1440", Offset = "0x18E0040", VA = "0x1818E1440", Slot = "5")]
		public virtual void Render(RoguelikeEndingControllerBase endingController, RoguelikeClassicEndingMonthViewModel viewModel)
		{
		}

		// Token: 0x0601F2FC RID: 127740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2FC")]
		[Address(RVA = "0x18E1590", Offset = "0x18E0190", VA = "0x1818E1590")]
		protected RoguelikeClassicEndingMonthStatsCharView()
		{
		}

		// Token: 0x04029DAF RID: 171439
		[Token(Token = "0x4029DAF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textYear;

		// Token: 0x04029DB0 RID: 171440
		[Token(Token = "0x4029DB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textMonth;

		// Token: 0x04029DB1 RID: 171441
		[Token(Token = "0x4029DB1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04029DB2 RID: 171442
		[Token(Token = "0x4029DB2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029DB3 RID: 171443
		[Token(Token = "0x4029DB3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
