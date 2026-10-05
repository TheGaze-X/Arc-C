using System;
using Il2CppDummyDll;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004707 RID: 18183
	[Token(Token = "0x2004707")]
	public class BuildConfigTagViewModel
	{
		// Token: 0x0601B91C RID: 112924 RVA: 0x000A5840 File Offset: 0x000A3A40
		[Token(Token = "0x601B91C")]
		[Address(RVA = "0x14DA0B0", Offset = "0x14D8CB0", VA = "0x1814DA0B0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601B91D RID: 112925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B91D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildConfigTagViewModel()
		{
		}

		// Token: 0x04023B48 RID: 146248
		[Token(Token = "0x4023B48")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x04023B49 RID: 146249
		[Token(Token = "0x4023B49")]
		[FieldOffset(Offset = "0x14")]
		public bool isActive;

		// Token: 0x04023B4A RID: 146250
		[Token(Token = "0x4023B4A")]
		[FieldOffset(Offset = "0x15")]
		public bool isSpecialTag;

		// Token: 0x04023B4B RID: 146251
		[Token(Token = "0x4023B4B")]
		[FieldOffset(Offset = "0x18")]
		public int tagId;

		// Token: 0x04023B4C RID: 146252
		[Token(Token = "0x4023B4C")]
		[FieldOffset(Offset = "0x20")]
		public string content;

		// Token: 0x04023B4D RID: 146253
		[Token(Token = "0x4023B4D")]
		[FieldOffset(Offset = "0x28")]
		public bool isSelected;
	}
}
