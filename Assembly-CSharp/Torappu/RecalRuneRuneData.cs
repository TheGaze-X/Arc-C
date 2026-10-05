using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001131 RID: 4401
	[Token(Token = "0x2001131")]
	public class RecalRuneRuneData
	{
		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06006F05 RID: 28421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D33")]
		public string runeDescription
		{
			[Token(Token = "0x6006F05")]
			[Address(RVA = "0x210F390", Offset = "0x210DF90", VA = "0x18210F390")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006F06 RID: 28422 RVA: 0x000324A8 File Offset: 0x000306A8
		[Token(Token = "0x6006F06")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		public bool ShouldSerializeruneDescription()
		{
			return default(bool);
		}

		// Token: 0x06006F07 RID: 28423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F07")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RecalRuneRuneData()
		{
		}

		// Token: 0x04005E56 RID: 24150
		[Token(Token = "0x4005E56")]
		[FieldOffset(Offset = "0x10")]
		public string runeId;

		// Token: 0x04005E57 RID: 24151
		[Token(Token = "0x4005E57")]
		[FieldOffset(Offset = "0x18")]
		public int score;

		// Token: 0x04005E58 RID: 24152
		[Token(Token = "0x4005E58")]
		[FieldOffset(Offset = "0x1C")]
		public int sortId;

		// Token: 0x04005E59 RID: 24153
		[Token(Token = "0x4005E59")]
		[FieldOffset(Offset = "0x20")]
		public bool essential;

		// Token: 0x04005E5A RID: 24154
		[Token(Token = "0x4005E5A")]
		[FieldOffset(Offset = "0x28")]
		public string exclusiveGroupId;

		// Token: 0x04005E5B RID: 24155
		[Token(Token = "0x4005E5B")]
		[FieldOffset(Offset = "0x30")]
		public string runeIcon;

		// Token: 0x04005E5C RID: 24156
		[Token(Token = "0x4005E5C")]
		[FieldOffset(Offset = "0x38")]
		public RuneTable.PackedRuneData packedRune;
	}
}
