using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070B8 RID: 28856
	[Token(Token = "0x20070B8")]
	public class Act1BossRushEntryRelicButtonPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x06029042 RID: 168002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029042")]
		[Address(RVA = "0x2466E20", Offset = "0x2465A20", VA = "0x182466E20", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06029043 RID: 168003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029043")]
		[Address(RVA = "0x24670A0", Offset = "0x2465CA0", VA = "0x1824670A0")]
		public void OpenRelic()
		{
		}

		// Token: 0x06029044 RID: 168004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029044")]
		[Address(RVA = "0x2467230", Offset = "0x2465E30", VA = "0x182467230")]
		public Act1BossRushEntryRelicButtonPlugin()
		{
		}

		// Token: 0x0403A8BC RID: 239804
		[Token(Token = "0x403A8BC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objRelicTips;

		// Token: 0x0403A8BD RID: 239805
		[Token(Token = "0x403A8BD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtRelicTis;

		// Token: 0x0403A8BE RID: 239806
		[Token(Token = "0x403A8BE")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0403A8BF RID: 239807
		[Token(Token = "0x403A8BF")]
		[FieldOffset(Offset = "0x40")]
		private string m_actId;

		// Token: 0x0403A8C0 RID: 239808
		[Token(Token = "0x403A8C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403A8C1 RID: 239809
		[Token(Token = "0x403A8C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenRelic;

		// Token: 0x0403A8C2 RID: 239810
		[Token(Token = "0x403A8C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
