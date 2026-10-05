using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006121 RID: 24865
	[Token(Token = "0x2006121")]
	public class FastCampaignConfirmViewModel : IHotfixable
	{
		// Token: 0x06023E9F RID: 147103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E9F")]
		[Address(RVA = "0x1E9AD40", Offset = "0x1E99940", VA = "0x181E9AD40")]
		public void LoadData(string stageId, CampaignStageType stageType)
		{
		}

		// Token: 0x06023EA0 RID: 147104 RVA: 0x000C25B0 File Offset: 0x000C07B0
		[Token(Token = "0x6023EA0")]
		[Address(RVA = "0x1E9AC70", Offset = "0x1E99870", VA = "0x181E9AC70")]
		public ItemUtil.ConsumableInfo GetNextTicketToCost()
		{
			return default(ItemUtil.ConsumableInfo);
		}

		// Token: 0x06023EA1 RID: 147105 RVA: 0x000C25C8 File Offset: 0x000C07C8
		[Token(Token = "0x6023EA1")]
		[Address(RVA = "0x1E9AF40", Offset = "0x1E99B40", VA = "0x181E9AF40")]
		private static int _SortSweepTicket(ItemUtil.ConsumableInfo lhs, ItemUtil.ConsumableInfo rhs)
		{
			return 0;
		}

		// Token: 0x06023EA2 RID: 147106 RVA: 0x000C25E0 File Offset: 0x000C07E0
		[Token(Token = "0x6023EA2")]
		[Address(RVA = "0x1E9AB10", Offset = "0x1E99710", VA = "0x181E9AB10")]
		public float GetCurShardProgress()
		{
			return 0f;
		}

		// Token: 0x06023EA3 RID: 147107 RVA: 0x000C25F8 File Offset: 0x000C07F8
		[Token(Token = "0x6023EA3")]
		[Address(RVA = "0x1E9AB90", Offset = "0x1E99790", VA = "0x181E9AB90")]
		public float GetGainShardProgress()
		{
			return 0f;
		}

		// Token: 0x06023EA4 RID: 147108 RVA: 0x000C2610 File Offset: 0x000C0810
		[Token(Token = "0x6023EA4")]
		[Address(RVA = "0x1E9AC10", Offset = "0x1E99810", VA = "0x181E9AC10")]
		public int GetGainTargetShard()
		{
			return 0;
		}

		// Token: 0x06023EA5 RID: 147109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EA5")]
		[Address(RVA = "0x1E9AFF0", Offset = "0x1E99BF0", VA = "0x181E9AFF0")]
		public FastCampaignConfirmViewModel()
		{
		}

		// Token: 0x04031D84 RID: 204164
		[Token(Token = "0x4031D84")]
		[FieldOffset(Offset = "0x10")]
		public int sweepCount;

		// Token: 0x04031D85 RID: 204165
		[Token(Token = "0x4031D85")]
		[FieldOffset(Offset = "0x14")]
		public int curShard;

		// Token: 0x04031D86 RID: 204166
		[Token(Token = "0x4031D86")]
		[FieldOffset(Offset = "0x18")]
		public int shardLimit;

		// Token: 0x04031D87 RID: 204167
		[Token(Token = "0x4031D87")]
		[FieldOffset(Offset = "0x1C")]
		public int gainShard;

		// Token: 0x04031D88 RID: 204168
		[Token(Token = "0x4031D88")]
		[FieldOffset(Offset = "0x20")]
		public bool mayUseLowerGainLadder;

		// Token: 0x04031D89 RID: 204169
		[Token(Token = "0x4031D89")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemUtil.ConsumableInfo> tktList;

		// Token: 0x04031D8A RID: 204170
		[Token(Token = "0x4031D8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031D8B RID: 204171
		[Token(Token = "0x4031D8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetNextTicketToCost;

		// Token: 0x04031D8C RID: 204172
		[Token(Token = "0x4031D8C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SortSweepTicket;

		// Token: 0x04031D8D RID: 204173
		[Token(Token = "0x4031D8D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCurShardProgress;

		// Token: 0x04031D8E RID: 204174
		[Token(Token = "0x4031D8E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetGainShardProgress;

		// Token: 0x04031D8F RID: 204175
		[Token(Token = "0x4031D8F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetGainTargetShard;

		// Token: 0x04031D90 RID: 204176
		[Token(Token = "0x4031D90")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
