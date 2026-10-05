using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010FD RID: 4349
	[Token(Token = "0x20010FD")]
	public class BattleLoadingDisplayMetaItem : IMetaDisplayItem
	{
		// Token: 0x06006EB5 RID: 28341 RVA: 0x000322B0 File Offset: 0x000304B0
		[Token(Token = "0x6006EB5")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "4")]
		public MetaUIDisplayType GetDisplayType()
		{
			return MetaUIDisplayType.TIPS;
		}

		// Token: 0x06006EB6 RID: 28342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EB6")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "5")]
		public CommonAvailCheck GetAvailCheckNullable()
		{
			return null;
		}

		// Token: 0x06006EB7 RID: 28343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EB7")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "6")]
		public string GetRelatedActId()
		{
			return null;
		}

		// Token: 0x06006EB8 RID: 28344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB8")]
		[Address(RVA = "0x20FF010", Offset = "0x20FDC10", VA = "0x1820FF010")]
		public BattleLoadingDisplayMetaItem()
		{
		}

		// Token: 0x04005D31 RID: 23857
		[Token(Token = "0x4005D31")]
		[FieldOffset(Offset = "0x10")]
		public bool isAllStageActive;

		// Token: 0x04005D32 RID: 23858
		[Token(Token = "0x4005D32")]
		[FieldOffset(Offset = "0x18")]
		public List<string> stageIdList;

		// Token: 0x04005D33 RID: 23859
		[Token(Token = "0x4005D33")]
		[FieldOffset(Offset = "0x20")]
		public string battleLoadingPicId;

		// Token: 0x04005D34 RID: 23860
		[Token(Token = "0x4005D34")]
		[FieldOffset(Offset = "0x28")]
		public string relateActId;

		// Token: 0x04005D35 RID: 23861
		[Token(Token = "0x4005D35")]
		[FieldOffset(Offset = "0x30")]
		public CommonAvailCheck availCheck;
	}
}
