using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007448 RID: 29768
	[Token(Token = "0x2007448")]
	public class Act36sideEntryTimePlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602A023 RID: 172067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A023")]
		[Address(RVA = "0x259ACF0", Offset = "0x25998F0", VA = "0x18259ACF0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602A024 RID: 172068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A024")]
		[Address(RVA = "0x259AF50", Offset = "0x2599B50", VA = "0x18259AF50")]
		public Act36sideEntryTimePlugin()
		{
		}

		// Token: 0x0403C3E6 RID: 246758
		[Token(Token = "0x403C3E6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelBattleEnd;

		// Token: 0x0403C3E7 RID: 246759
		[Token(Token = "0x403C3E7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelReward;

		// Token: 0x0403C3E8 RID: 246760
		[Token(Token = "0x403C3E8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _battleEndTime;

		// Token: 0x0403C3E9 RID: 246761
		[Token(Token = "0x403C3E9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _rewardEndTime;

		// Token: 0x0403C3EA RID: 246762
		[Token(Token = "0x403C3EA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _battleEndTimeUnit;

		// Token: 0x0403C3EB RID: 246763
		[Token(Token = "0x403C3EB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _rewardEndTimeUnit;

		// Token: 0x0403C3EC RID: 246764
		[Token(Token = "0x403C3EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403C3ED RID: 246765
		[Token(Token = "0x403C3ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
