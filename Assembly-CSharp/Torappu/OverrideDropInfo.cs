using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200135A RID: 4954
	[Token(Token = "0x200135A")]
	public class OverrideDropInfo
	{
		// Token: 0x06007321 RID: 29473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007321")]
		[Address(RVA = "0x2208E00", Offset = "0x2207A00", VA = "0x182208E00")]
		public OverrideDropInfo()
		{
		}

		// Token: 0x04006DF1 RID: 28145
		[Token(Token = "0x4006DF1")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04006DF2 RID: 28146
		[Token(Token = "0x4006DF2")]
		[FieldOffset(Offset = "0x18")]
		public long startTs;

		// Token: 0x04006DF3 RID: 28147
		[Token(Token = "0x4006DF3")]
		[FieldOffset(Offset = "0x20")]
		public long endTs;

		// Token: 0x04006DF4 RID: 28148
		[Token(Token = "0x4006DF4")]
		[FieldOffset(Offset = "0x28")]
		public string zoneRange;

		// Token: 0x04006DF5 RID: 28149
		[Token(Token = "0x4006DF5")]
		[FieldOffset(Offset = "0x30")]
		public int times;

		// Token: 0x04006DF6 RID: 28150
		[Token(Token = "0x4006DF6")]
		[FieldOffset(Offset = "0x38")]
		public string name;

		// Token: 0x04006DF7 RID: 28151
		[Token(Token = "0x4006DF7")]
		[FieldOffset(Offset = "0x40")]
		public string egName;

		// Token: 0x04006DF8 RID: 28152
		[Token(Token = "0x4006DF8")]
		[FieldOffset(Offset = "0x48")]
		public string desc1;

		// Token: 0x04006DF9 RID: 28153
		[Token(Token = "0x4006DF9")]
		[FieldOffset(Offset = "0x50")]
		public string desc2;

		// Token: 0x04006DFA RID: 28154
		[Token(Token = "0x4006DFA")]
		[FieldOffset(Offset = "0x58")]
		public string desc3;

		// Token: 0x04006DFB RID: 28155
		[Token(Token = "0x4006DFB")]
		[FieldOffset(Offset = "0x60")]
		public string dropTag;

		// Token: 0x04006DFC RID: 28156
		[Token(Token = "0x4006DFC")]
		[FieldOffset(Offset = "0x68")]
		public string dropTypeDesc;

		// Token: 0x04006DFD RID: 28157
		[Token(Token = "0x4006DFD")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, StageData.StageDropInfo> dropInfo;
	}
}
