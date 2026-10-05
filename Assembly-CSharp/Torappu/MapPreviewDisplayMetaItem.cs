using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010FB RID: 4347
	[Token(Token = "0x20010FB")]
	public class MapPreviewDisplayMetaItem : IMetaDisplayItem
	{
		// Token: 0x06006EAD RID: 28333 RVA: 0x00032280 File Offset: 0x00030480
		[Token(Token = "0x6006EAD")]
		[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "4")]
		public MetaUIDisplayType GetDisplayType()
		{
			return MetaUIDisplayType.TIPS;
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EAE")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
		public CommonAvailCheck GetAvailCheckNullable()
		{
			return null;
		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EAF")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "6")]
		public string GetRelatedActId()
		{
			return null;
		}

		// Token: 0x06006EB0 RID: 28336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB0")]
		[Address(RVA = "0x21077E0", Offset = "0x21063E0", VA = "0x1821077E0")]
		public MapPreviewDisplayMetaItem()
		{
		}

		// Token: 0x04005D24 RID: 23844
		[Token(Token = "0x4005D24")]
		[FieldOffset(Offset = "0x10")]
		public string mapPreviewPicId;

		// Token: 0x04005D25 RID: 23845
		[Token(Token = "0x4005D25")]
		[FieldOffset(Offset = "0x18")]
		public CommonAvailCheck availCheck;

		// Token: 0x04005D26 RID: 23846
		[Token(Token = "0x4005D26")]
		[FieldOffset(Offset = "0x20")]
		public string relateActId;

		// Token: 0x04005D27 RID: 23847
		[Token(Token = "0x4005D27")]
		[FieldOffset(Offset = "0x28")]
		public bool isAllStageActive;

		// Token: 0x04005D28 RID: 23848
		[Token(Token = "0x4005D28")]
		[FieldOffset(Offset = "0x30")]
		public List<string> stageIdList;
	}
}
