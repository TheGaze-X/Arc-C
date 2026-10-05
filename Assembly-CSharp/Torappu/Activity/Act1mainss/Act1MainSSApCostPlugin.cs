using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x02007846 RID: 30790
	[Token(Token = "0x2007846")]
	public class Act1MainSSApCostPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602B2F0 RID: 176880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2F0")]
		[Address(RVA = "0x26EED00", Offset = "0x26ED900", VA = "0x1826EED00", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602B2F1 RID: 176881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2F1")]
		[Address(RVA = "0x26EEF00", Offset = "0x26EDB00", VA = "0x1826EEF00")]
		private void _OnClaimApRewardEvent()
		{
		}

		// Token: 0x0602B2F2 RID: 176882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2F2")]
		[Address(RVA = "0x26EF020", Offset = "0x26EDC20", VA = "0x1826EF020")]
		public Act1MainSSApCostPlugin()
		{
		}

		// Token: 0x0403E6C6 RID: 255686
		[Token(Token = "0x403E6C6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PrefabInstHolder _instHolder;

		// Token: 0x0403E6C7 RID: 255687
		[Token(Token = "0x403E6C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403E6C8 RID: 255688
		[Token(Token = "0x403E6C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnClaimApRewardEvent;

		// Token: 0x0403E6C9 RID: 255689
		[Token(Token = "0x403E6C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
