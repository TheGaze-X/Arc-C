using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C2D RID: 3117
	[Token(Token = "0x2000C2D")]
	public class ActArchiveCopperData
	{
		// Token: 0x0600690B RID: 26891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600690B")]
		[Address(RVA = "0x1FF8740", Offset = "0x1FF7340", VA = "0x181FF8740")]
		public ActArchiveCopperData()
		{
		}

		// Token: 0x04003FC4 RID: 16324
		[Token(Token = "0x4003FC4")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveCopperItemData> coppers;

		// Token: 0x04003FC5 RID: 16325
		[Token(Token = "0x4003FC5")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ActArchiveCopperTypeData> copperTypes;

		// Token: 0x04003FC6 RID: 16326
		[Token(Token = "0x4003FC6")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, ActArchiveCopperGildData> gilds;

		// Token: 0x04003FC7 RID: 16327
		[Token(Token = "0x4003FC7")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, ActArchiveCopperLuckyLevelData> luckyLevels;
	}
}
