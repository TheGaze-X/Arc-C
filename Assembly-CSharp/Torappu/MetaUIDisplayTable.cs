using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001100 RID: 4352
	[Token(Token = "0x2001100")]
	public class MetaUIDisplayTable
	{
		// Token: 0x06006EC1 RID: 28353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC1")]
		[Address(RVA = "0x2107D70", Offset = "0x2106970", VA = "0x182107D70")]
		public MetaUIDisplayTable()
		{
		}

		// Token: 0x04005D43 RID: 23875
		[Token(Token = "0x4005D43")]
		[FieldOffset(Offset = "0x10")]
		public List<TipsMetaDisplayItem> tipsMetaList;

		// Token: 0x04005D44 RID: 23876
		[Token(Token = "0x4005D44")]
		[FieldOffset(Offset = "0x18")]
		public List<FlashAlertAfterStageDisplayMetaItem> flashAlertAfterStageItemList;

		// Token: 0x04005D45 RID: 23877
		[Token(Token = "0x4005D45")]
		[FieldOffset(Offset = "0x20")]
		public List<MapPreviewDisplayMetaItem> mapPreviewDisplayMetaItemList;

		// Token: 0x04005D46 RID: 23878
		[Token(Token = "0x4005D46")]
		[FieldOffset(Offset = "0x28")]
		public List<BattleFinishDisplayMetaItem> battleFinishDisplayMetaItemList;

		// Token: 0x04005D47 RID: 23879
		[Token(Token = "0x4005D47")]
		[FieldOffset(Offset = "0x30")]
		public List<BattleLoadingDisplayMetaItem> battleLoadingDisplayMetaItemList;

		// Token: 0x04005D48 RID: 23880
		[Token(Token = "0x4005D48")]
		[FieldOffset(Offset = "0x38")]
		public List<BattleAutoBattleMetaItem> battleAutoBattleMetaItemList;
	}
}
