using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CBD RID: 27837
	[Token(Token = "0x2006CBD")]
	public class TemplateActivityCoinView : MonoBehaviour, IBaseActViewBinder, IHotfixable
	{
		// Token: 0x06027B88 RID: 162696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B88")]
		[Address(RVA = "0x22D6C60", Offset = "0x22D5860", VA = "0x1822D6C60", Slot = "4")]
		public void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027B89 RID: 162697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B89")]
		[Address(RVA = "0x22D6D80", Offset = "0x22D5980", VA = "0x1822D6D80")]
		public TemplateActivityCoinView()
		{
		}

		// Token: 0x04038517 RID: 230679
		[Token(Token = "0x4038517")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCoin;

		// Token: 0x04038518 RID: 230680
		[Token(Token = "0x4038518")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x04038519 RID: 230681
		[Token(Token = "0x4038519")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
