using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CB7 RID: 3255
	[Token(Token = "0x2000CB7")]
	public class CartData
	{
		// Token: 0x06006998 RID: 27032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006998")]
		[Address(RVA = "0x20080C0", Offset = "0x2006CC0", VA = "0x1820080C0")]
		public CartData()
		{
		}

		// Token: 0x04004274 RID: 17012
		[Token(Token = "0x4004274")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, CartComponents> carDict;

		// Token: 0x04004275 RID: 17013
		[Token(Token = "0x4004275")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, RuneTable.PackedRuneData> runeDataDict;

		// Token: 0x04004276 RID: 17014
		[Token(Token = "0x4004276")]
		[FieldOffset(Offset = "0x20")]
		public HashSet<string> cartStages;

		// Token: 0x04004277 RID: 17015
		[Token(Token = "0x4004277")]
		[FieldOffset(Offset = "0x28")]
		public CartData.CartConstData constData;

		// Token: 0x02000CB8 RID: 3256
		[Token(Token = "0x2000CB8")]
		public class CartConstData
		{
			// Token: 0x06006999 RID: 27033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006999")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CartConstData()
			{
			}

			// Token: 0x04004278 RID: 17016
			[Token(Token = "0x4004278")]
			[FieldOffset(Offset = "0x10")]
			public string carItemUnlockStageId;

			// Token: 0x04004279 RID: 17017
			[Token(Token = "0x4004279")]
			[FieldOffset(Offset = "0x18")]
			public string carItemUnlockDesc;

			// Token: 0x0400427A RID: 17018
			[Token(Token = "0x400427A")]
			[FieldOffset(Offset = "0x20")]
			public int spLevelUnlockItemCnt;

			// Token: 0x0400427B RID: 17019
			[Token(Token = "0x400427B")]
			[FieldOffset(Offset = "0x24")]
			public int mileStoneBaseInterval;

			// Token: 0x0400427C RID: 17020
			[Token(Token = "0x400427C")]
			[FieldOffset(Offset = "0x28")]
			public List<string> spStageIds;

			// Token: 0x0400427D RID: 17021
			[Token(Token = "0x400427D")]
			[FieldOffset(Offset = "0x30")]
			public string carFrameDefaultColor;
		}
	}
}
