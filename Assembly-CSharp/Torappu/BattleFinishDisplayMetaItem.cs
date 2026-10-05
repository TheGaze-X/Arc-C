using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010FF RID: 4351
	[Token(Token = "0x20010FF")]
	public class BattleFinishDisplayMetaItem : IMetaDisplayItem
	{
		// Token: 0x06006EBD RID: 28349 RVA: 0x000322E0 File Offset: 0x000304E0
		[Token(Token = "0x6006EBD")]
		[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "4")]
		public MetaUIDisplayType GetDisplayType()
		{
			return MetaUIDisplayType.TIPS;
		}

		// Token: 0x06006EBE RID: 28350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EBE")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "5")]
		public CommonAvailCheck GetAvailCheckNullable()
		{
			return null;
		}

		// Token: 0x06006EBF RID: 28351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EBF")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "6")]
		public string GetRelatedActId()
		{
			return null;
		}

		// Token: 0x06006EC0 RID: 28352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC0")]
		[Address(RVA = "0x20FEF80", Offset = "0x20FDB80", VA = "0x1820FEF80")]
		public BattleFinishDisplayMetaItem()
		{
		}

		// Token: 0x04005D3B RID: 23867
		[Token(Token = "0x4005D3B")]
		[FieldOffset(Offset = "0x10")]
		public string battleFinishDisplayKey;

		// Token: 0x04005D3C RID: 23868
		[Token(Token = "0x4005D3C")]
		[FieldOffset(Offset = "0x18")]
		public bool isAllStageActive;

		// Token: 0x04005D3D RID: 23869
		[Token(Token = "0x4005D3D")]
		[FieldOffset(Offset = "0x20")]
		public List<string> stageIdList;

		// Token: 0x04005D3E RID: 23870
		[Token(Token = "0x4005D3E")]
		[FieldOffset(Offset = "0x28")]
		public CommonAvailCheck availCheck;

		// Token: 0x04005D3F RID: 23871
		[Token(Token = "0x4005D3F")]
		[FieldOffset(Offset = "0x30")]
		public string relateActId;

		// Token: 0x04005D40 RID: 23872
		[Token(Token = "0x4005D40")]
		[FieldOffset(Offset = "0x38")]
		public string overrideStageName;

		// Token: 0x04005D41 RID: 23873
		[Token(Token = "0x4005D41")]
		[FieldOffset(Offset = "0x40")]
		public string signal;

		// Token: 0x04005D42 RID: 23874
		[Token(Token = "0x4005D42")]
		[FieldOffset(Offset = "0x48")]
		public string overrideCharWord;
	}
}
