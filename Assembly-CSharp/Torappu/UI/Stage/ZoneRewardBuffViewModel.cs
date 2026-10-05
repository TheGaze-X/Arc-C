using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069EB RID: 27115
	[Token(Token = "0x20069EB")]
	public class ZoneRewardBuffViewModel : IHotfixable
	{
		// Token: 0x06026C74 RID: 158836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C74")]
		[Address(RVA = "0x21E6F30", Offset = "0x21E5B30", VA = "0x1821E6F30")]
		public void LoadData(string zoneId)
		{
		}

		// Token: 0x06026C75 RID: 158837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C75")]
		[Address(RVA = "0x21E7430", Offset = "0x21E6030", VA = "0x1821E7430")]
		public void RefreshData()
		{
		}

		// Token: 0x06026C76 RID: 158838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C76")]
		[Address(RVA = "0x21E7580", Offset = "0x21E6180", VA = "0x1821E7580")]
		public ZoneRewardBuffViewModel()
		{
		}

		// Token: 0x04036C81 RID: 224385
		[Token(Token = "0x4036C81")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04036C82 RID: 224386
		[Token(Token = "0x4036C82")]
		[FieldOffset(Offset = "0x18")]
		public string itemName;

		// Token: 0x04036C83 RID: 224387
		[Token(Token = "0x4036C83")]
		[FieldOffset(Offset = "0x20")]
		public string itemNameEng;

		// Token: 0x04036C84 RID: 224388
		[Token(Token = "0x4036C84")]
		[FieldOffset(Offset = "0x28")]
		public long startTs;

		// Token: 0x04036C85 RID: 224389
		[Token(Token = "0x4036C85")]
		[FieldOffset(Offset = "0x30")]
		public long endTs;

		// Token: 0x04036C86 RID: 224390
		[Token(Token = "0x4036C86")]
		[FieldOffset(Offset = "0x38")]
		public string zoneRange;

		// Token: 0x04036C87 RID: 224391
		[Token(Token = "0x4036C87")]
		[FieldOffset(Offset = "0x40")]
		public string itemDesc;

		// Token: 0x04036C88 RID: 224392
		[Token(Token = "0x4036C88")]
		[FieldOffset(Offset = "0x48")]
		public string itemHowUse;

		// Token: 0x04036C89 RID: 224393
		[Token(Token = "0x4036C89")]
		[FieldOffset(Offset = "0x50")]
		public string itemHowGain;

		// Token: 0x04036C8A RID: 224394
		[Token(Token = "0x4036C8A")]
		[FieldOffset(Offset = "0x58")]
		public bool isValid;

		// Token: 0x04036C8B RID: 224395
		[Token(Token = "0x4036C8B")]
		[FieldOffset(Offset = "0x5C")]
		public int useTime;

		// Token: 0x04036C8C RID: 224396
		[Token(Token = "0x4036C8C")]
		[FieldOffset(Offset = "0x60")]
		public int itemNum;

		// Token: 0x04036C8D RID: 224397
		[Token(Token = "0x4036C8D")]
		[FieldOffset(Offset = "0x68")]
		public string itemIconId;

		// Token: 0x04036C8E RID: 224398
		[Token(Token = "0x4036C8E")]
		[FieldOffset(Offset = "0x70")]
		public ItemType itemType;

		// Token: 0x04036C8F RID: 224399
		[Token(Token = "0x4036C8F")]
		[FieldOffset(Offset = "0x74")]
		private int m_dayCanUseTotalTime;

		// Token: 0x04036C90 RID: 224400
		[Token(Token = "0x4036C90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04036C91 RID: 224401
		[Token(Token = "0x4036C91")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04036C92 RID: 224402
		[Token(Token = "0x4036C92")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
