using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C79 RID: 27769
	[Token(Token = "0x2006C79")]
	public class TemplateActivityEntryCoinPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x06027A20 RID: 162336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A20")]
		[Address(RVA = "0x22CB9D0", Offset = "0x22CA5D0", VA = "0x1822CB9D0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027A21 RID: 162337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A21")]
		[Address(RVA = "0x22CBBB0", Offset = "0x22CA7B0", VA = "0x1822CBBB0")]
		public TemplateActivityEntryCoinPlugin()
		{
		}

		// Token: 0x04038353 RID: 230227
		[Token(Token = "0x4038353")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _uiCoinCount;

		// Token: 0x04038354 RID: 230228
		[Token(Token = "0x4038354")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Token Name")]
		private string _coinItemId;

		// Token: 0x04038355 RID: 230229
		[Token(Token = "0x4038355")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Token Name")]
		private Text _textCoinName;

		// Token: 0x04038356 RID: 230230
		[Token(Token = "0x4038356")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x04038357 RID: 230231
		[Token(Token = "0x4038357")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
