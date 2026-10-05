using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CD6 RID: 3286
	[Token(Token = "0x2000CD6")]
	public class Act21SideData
	{
		// Token: 0x060069B4 RID: 27060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B4")]
		[Address(RVA = "0x1FF4160", Offset = "0x1FF2D60", VA = "0x181FF4160")]
		public Act21SideData()
		{
		}

		// Token: 0x0400432D RID: 17197
		[Token(Token = "0x400432D")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act21SideData.ZoneAddtionData> zoneAdditionDataMap;

		// Token: 0x0400432E RID: 17198
		[Token(Token = "0x400432E")]
		[FieldOffset(Offset = "0x18")]
		public Act21SideData.ConstData constData;

		// Token: 0x02000CD7 RID: 3287
		[Token(Token = "0x2000CD7")]
		public class ZoneAddtionData
		{
			// Token: 0x060069B5 RID: 27061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069B5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ZoneAddtionData()
			{
			}

			// Token: 0x0400432F RID: 17199
			[Token(Token = "0x400432F")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04004330 RID: 17200
			[Token(Token = "0x4004330")]
			[FieldOffset(Offset = "0x18")]
			public string unlockText;

			// Token: 0x04004331 RID: 17201
			[Token(Token = "0x4004331")]
			[FieldOffset(Offset = "0x20")]
			public string stageUnlockText;

			// Token: 0x04004332 RID: 17202
			[Token(Token = "0x4004332")]
			[FieldOffset(Offset = "0x28")]
			public string entryId;
		}

		// Token: 0x02000CD8 RID: 3288
		[Token(Token = "0x2000CD8")]
		public class ConstData
		{
			// Token: 0x060069B6 RID: 27062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069B6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConstData()
			{
			}

			// Token: 0x04004333 RID: 17203
			[Token(Token = "0x4004333")]
			[FieldOffset(Offset = "0x10")]
			public string lineConnectZone;
		}
	}
}
