using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006103 RID: 24835
	[Token(Token = "0x2006103")]
	public class CampaignWorldZoneViewModel : IHotfixable
	{
		// Token: 0x06023E4D RID: 147021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E4D")]
		[Address(RVA = "0x1E92190", Offset = "0x1E90D90", VA = "0x181E92190")]
		public void LoadData(string zoneId, CampaignWorldViewModel context)
		{
		}

		// Token: 0x06023E4E RID: 147022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E4E")]
		[Address(RVA = "0x1E92440", Offset = "0x1E91040", VA = "0x181E92440")]
		public CampaignWorldZoneViewModel()
		{
		}

		// Token: 0x04031CD5 RID: 203989
		[Token(Token = "0x4031CD5")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04031CD6 RID: 203990
		[Token(Token = "0x4031CD6")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04031CD7 RID: 203991
		[Token(Token = "0x4031CD7")]
		[FieldOffset(Offset = "0x20")]
		public bool isActive;

		// Token: 0x04031CD8 RID: 203992
		[Token(Token = "0x4031CD8")]
		[FieldOffset(Offset = "0x21")]
		public bool isUnlocked;

		// Token: 0x04031CD9 RID: 203993
		[Token(Token = "0x4031CD9")]
		[FieldOffset(Offset = "0x22")]
		public bool hasStage;

		// Token: 0x04031CDA RID: 203994
		[Token(Token = "0x4031CDA")]
		[FieldOffset(Offset = "0x23")]
		public bool hasUnconfirmedReward;

		// Token: 0x04031CDB RID: 203995
		[Token(Token = "0x4031CDB")]
		[FieldOffset(Offset = "0x24")]
		public bool isRotate;

		// Token: 0x04031CDC RID: 203996
		[Token(Token = "0x4031CDC")]
		[FieldOffset(Offset = "0x28")]
		public long rotateEndTs;

		// Token: 0x04031CDD RID: 203997
		[Token(Token = "0x4031CDD")]
		[FieldOffset(Offset = "0x30")]
		public List<CampaignWorldStageViewModel> stageModels;

		// Token: 0x04031CDE RID: 203998
		[Token(Token = "0x4031CDE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031CDF RID: 203999
		[Token(Token = "0x4031CDF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
