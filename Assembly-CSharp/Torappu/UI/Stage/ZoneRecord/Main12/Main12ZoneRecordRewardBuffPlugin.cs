using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main12
{
	// Token: 0x02006A20 RID: 27168
	[Token(Token = "0x2006A20")]
	public class Main12ZoneRecordRewardBuffPlugin : ZoneRecordRewardBuffPlugin
	{
		// Token: 0x06026D6B RID: 159083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D6B")]
		[Address(RVA = "0x21FB0D0", Offset = "0x21F9CD0", VA = "0x1821FB0D0", Slot = "4")]
		public override void OnRender(ZoneRewardBuffViewModel viewModel)
		{
		}

		// Token: 0x06026D6C RID: 159084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D6C")]
		[Address(RVA = "0x21FB3B0", Offset = "0x21F9FB0", VA = "0x1821FB3B0")]
		private void _OnTimeOut()
		{
		}

		// Token: 0x06026D6D RID: 159085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D6D")]
		[Address(RVA = "0x21FB430", Offset = "0x21FA030", VA = "0x1821FB430")]
		public Main12ZoneRecordRewardBuffPlugin()
		{
		}

		// Token: 0x06026D6E RID: 159086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D6E")]
		[Address(RVA = "0x21FB3A0", Offset = "0x21F9FA0", VA = "0x1821FB3A0")]
		private void <>xLuaBaseProxy_OnRender(ZoneRewardBuffViewModel P0)
		{
		}

		// Token: 0x04036E4D RID: 224845
		[Token(Token = "0x4036E4D")]
		[FieldOffset(Offset = "0x28")]
		private GameObject m_itemTimeObj;

		// Token: 0x04036E4E RID: 224846
		[Token(Token = "0x4036E4E")]
		[FieldOffset(Offset = "0x30")]
		private Main12RecordRewardBuffBtnView m_view;

		// Token: 0x04036E4F RID: 224847
		[Token(Token = "0x4036E4F")]
		[FieldOffset(Offset = "0x38")]
		private long m_rewardBuffTimeEndTs;

		// Token: 0x04036E50 RID: 224848
		[Token(Token = "0x4036E50")]
		[FieldOffset(Offset = "0x40")]
		private long m_rewardBuffTimeStartTs;

		// Token: 0x04036E51 RID: 224849
		[Token(Token = "0x4036E51")]
		[FieldOffset(Offset = "0x48")]
		private string m_itemId;

		// Token: 0x04036E52 RID: 224850
		[Token(Token = "0x4036E52")]
		[FieldOffset(Offset = "0x50")]
		public bool isOnStage;

		// Token: 0x04036E53 RID: 224851
		[Token(Token = "0x4036E53")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04036E54 RID: 224852
		[Token(Token = "0x4036E54")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnTimeOut;

		// Token: 0x04036E55 RID: 224853
		[Token(Token = "0x4036E55")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
