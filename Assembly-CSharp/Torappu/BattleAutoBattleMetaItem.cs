using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010FE RID: 4350
	[Token(Token = "0x20010FE")]
	public class BattleAutoBattleMetaItem : IMetaDisplayItem
	{
		// Token: 0x06006EB9 RID: 28345 RVA: 0x000322C8 File Offset: 0x000304C8
		[Token(Token = "0x6006EB9")]
		[Address(RVA = "0x54BA20", Offset = "0x54A620", VA = "0x18054BA20", Slot = "4")]
		public MetaUIDisplayType GetDisplayType()
		{
			return MetaUIDisplayType.TIPS;
		}

		// Token: 0x06006EBA RID: 28346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EBA")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "5")]
		public CommonAvailCheck GetAvailCheckNullable()
		{
			return null;
		}

		// Token: 0x06006EBB RID: 28347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EBB")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "6")]
		public string GetRelatedActId()
		{
			return null;
		}

		// Token: 0x06006EBC RID: 28348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EBC")]
		[Address(RVA = "0x20FED50", Offset = "0x20FD950", VA = "0x1820FED50")]
		public BattleAutoBattleMetaItem()
		{
		}

		// Token: 0x04005D36 RID: 23862
		[Token(Token = "0x4005D36")]
		[FieldOffset(Offset = "0x10")]
		public string battleAutoBattleDisplayKey;

		// Token: 0x04005D37 RID: 23863
		[Token(Token = "0x4005D37")]
		[FieldOffset(Offset = "0x18")]
		public bool isAllStageActive;

		// Token: 0x04005D38 RID: 23864
		[Token(Token = "0x4005D38")]
		[FieldOffset(Offset = "0x20")]
		public string relateActId;

		// Token: 0x04005D39 RID: 23865
		[Token(Token = "0x4005D39")]
		[FieldOffset(Offset = "0x28")]
		public List<string> stageIdList;

		// Token: 0x04005D3A RID: 23866
		[Token(Token = "0x4005D3A")]
		[FieldOffset(Offset = "0x30")]
		public CommonAvailCheck availCheck;
	}
}
