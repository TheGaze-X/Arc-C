using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CA4 RID: 3236
	[Token(Token = "0x2000CA4")]
	public class Act1VHalfIdleEquipData
	{
		// Token: 0x0600697E RID: 27006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600697E")]
		[Address(RVA = "0x1FF38D0", Offset = "0x1FF24D0", VA = "0x181FF38D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600697F")]
		[Address(RVA = "0x1FF3800", Offset = "0x1FF2400", VA = "0x181FF3800")]
		public Act1VHalfIdleEquipData Duplicate()
		{
			return null;
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006980")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleEquipData()
		{
		}

		// Token: 0x0400421C RID: 16924
		[Token(Token = "0x400421C")]
		[FieldOffset(Offset = "0x10")]
		public string equipId;

		// Token: 0x0400421D RID: 16925
		[Token(Token = "0x400421D")]
		[FieldOffset(Offset = "0x18")]
		public string alias;

		// Token: 0x0400421E RID: 16926
		[Token(Token = "0x400421E")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x0400421F RID: 16927
		[Token(Token = "0x400421F")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x04004220 RID: 16928
		[Token(Token = "0x4004220")]
		[FieldOffset(Offset = "0x30")]
		public int level;

		// Token: 0x04004221 RID: 16929
		[Token(Token = "0x4004221")]
		[FieldOffset(Offset = "0x34")]
		public Act1VHalfIdleEquipType equipType;

		// Token: 0x04004222 RID: 16930
		[Token(Token = "0x4004222")]
		[FieldOffset(Offset = "0x38")]
		public RuneTable.PackedRuneData runeData;
	}
}
