using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side.UI
{
	// Token: 0x02007A4A RID: 31306
	[Token(Token = "0x2007A4A")]
	public class Act13sideCoinView : MonoBehaviour, IBaseActViewBinder, IHotfixable
	{
		// Token: 0x0602BDC0 RID: 179648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDC0")]
		[Address(RVA = "0x27CA530", Offset = "0x27C9130", VA = "0x1827CA530", Slot = "4")]
		public void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602BDC1 RID: 179649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDC1")]
		[Address(RVA = "0x27CA650", Offset = "0x27C9250", VA = "0x1827CA650")]
		public Act13sideCoinView()
		{
		}

		// Token: 0x0403F832 RID: 260146
		[Token(Token = "0x403F832")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCoin;

		// Token: 0x0403F833 RID: 260147
		[Token(Token = "0x403F833")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403F834 RID: 260148
		[Token(Token = "0x403F834")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
