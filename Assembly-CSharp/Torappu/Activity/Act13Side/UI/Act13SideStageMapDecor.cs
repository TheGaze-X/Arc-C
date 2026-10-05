using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act13Side.UI
{
	// Token: 0x02007A46 RID: 31302
	[Token(Token = "0x2007A46")]
	public class Act13SideStageMapDecor : ActivityStageSingleComponent
	{
		// Token: 0x0602BDAB RID: 179627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDAB")]
		[Address(RVA = "0x27CA320", Offset = "0x27C8F20", VA = "0x1827CA320", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x0602BDAC RID: 179628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDAC")]
		[Address(RVA = "0x27CA1F0", Offset = "0x27C8DF0", VA = "0x1827CA1F0")]
		public void EventOnZoneBtnClicked(string zoneId)
		{
		}

		// Token: 0x0602BDAD RID: 179629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDAD")]
		[Address(RVA = "0x27C9FD0", Offset = "0x27C8BD0", VA = "0x1827C9FD0")]
		public void EventOnShopBtnClicked()
		{
		}

		// Token: 0x0602BDAE RID: 179630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDAE")]
		[Address(RVA = "0x27CA4D0", Offset = "0x27C90D0", VA = "0x1827CA4D0")]
		public Act13SideStageMapDecor()
		{
		}

		// Token: 0x0602BDAF RID: 179631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDAF")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0403F809 RID: 260105
		[Token(Token = "0x403F809")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act13sideMapZoneGroupView _zoneGroupView;

		// Token: 0x0403F80A RID: 260106
		[Token(Token = "0x403F80A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act13sideCoinView _coinView;

		// Token: 0x0403F80B RID: 260107
		[Token(Token = "0x403F80B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act13sideDecorMissionView _missionView;

		// Token: 0x0403F80C RID: 260108
		[Token(Token = "0x403F80C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403F80D RID: 260109
		[Token(Token = "0x403F80D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnZoneBtnClicked;

		// Token: 0x0403F80E RID: 260110
		[Token(Token = "0x403F80E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnShopBtnClicked;

		// Token: 0x0403F80F RID: 260111
		[Token(Token = "0x403F80F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
