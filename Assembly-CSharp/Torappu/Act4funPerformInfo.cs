using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EA2 RID: 3746
	[Token(Token = "0x2000EA2")]
	public class Act4funPerformInfo
	{
		// Token: 0x06006B74 RID: 27508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B74")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act4funPerformInfo()
		{
		}

		// Token: 0x04004F1A RID: 20250
		[Token(Token = "0x4004F1A")]
		[FieldOffset(Offset = "0x10")]
		public string performId;

		// Token: 0x04004F1B RID: 20251
		[Token(Token = "0x4004F1B")]
		[FieldOffset(Offset = "0x18")]
		public string performFinishedPicId;

		// Token: 0x04004F1C RID: 20252
		[Token(Token = "0x4004F1C")]
		[FieldOffset(Offset = "0x20")]
		public string fixedCmpGroup;

		// Token: 0x04004F1D RID: 20253
		[Token(Token = "0x4004F1D")]
		[FieldOffset(Offset = "0x28")]
		public List<string> cmpGroups;

		// Token: 0x04004F1E RID: 20254
		[Token(Token = "0x4004F1E")]
		[FieldOffset(Offset = "0x30")]
		public List<Act4funPerformWordData> words;
	}
}
