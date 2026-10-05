using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006120 RID: 24864
	[Token(Token = "0x2006120")]
	public class CampaignFastBattleStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06023E9A RID: 147098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E9A")]
		[Address(RVA = "0x1E870C0", Offset = "0x1E85CC0", VA = "0x181E870C0")]
		public void LoadData(string stageId, CampaignStageType stageType)
		{
		}

		// Token: 0x06023E9B RID: 147099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E9B")]
		[Address(RVA = "0x1E87170", Offset = "0x1E85D70", VA = "0x181E87170")]
		public void RefreshData()
		{
		}

		// Token: 0x06023E9C RID: 147100 RVA: 0x000C2580 File Offset: 0x000C0780
		[Token(Token = "0x6023E9C")]
		[Address(RVA = "0x1E86FA0", Offset = "0x1E85BA0", VA = "0x181E86FA0")]
		public ItemUtil.ConsumableInfo GetItemToCost()
		{
			return default(ItemUtil.ConsumableInfo);
		}

		// Token: 0x06023E9D RID: 147101 RVA: 0x000C2598 File Offset: 0x000C0798
		[Token(Token = "0x6023E9D")]
		[Address(RVA = "0x1E86EB0", Offset = "0x1E85AB0", VA = "0x181E86EB0")]
		public bool CheckIfCanStartBattle(out string alert)
		{
			return default(bool);
		}

		// Token: 0x06023E9E RID: 147102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E9E")]
		[Address(RVA = "0x1E871E0", Offset = "0x1E85DE0", VA = "0x181E871E0")]
		public CampaignFastBattleStateBean()
		{
		}

		// Token: 0x04031D7C RID: 204156
		[Token(Token = "0x4031D7C")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04031D7D RID: 204157
		[Token(Token = "0x4031D7D")]
		[FieldOffset(Offset = "0x18")]
		public CampaignStageType stageType;

		// Token: 0x04031D7E RID: 204158
		[Token(Token = "0x4031D7E")]
		[FieldOffset(Offset = "0x20")]
		public FastCampaignConfirmViewModel confirmModel;

		// Token: 0x04031D7F RID: 204159
		[Token(Token = "0x4031D7F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031D80 RID: 204160
		[Token(Token = "0x4031D80")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04031D81 RID: 204161
		[Token(Token = "0x4031D81")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetItemToCost;

		// Token: 0x04031D82 RID: 204162
		[Token(Token = "0x4031D82")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfCanStartBattle;

		// Token: 0x04031D83 RID: 204163
		[Token(Token = "0x4031D83")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
