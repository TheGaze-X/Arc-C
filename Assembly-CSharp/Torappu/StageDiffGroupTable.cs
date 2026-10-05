using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001362 RID: 4962
	[Token(Token = "0x2001362")]
	[Serializable]
	public class StageDiffGroupTable
	{
		// Token: 0x0600732B RID: 29483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600732B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StageDiffGroupTable()
		{
		}

		// Token: 0x04006E1E RID: 28190
		[Token(Token = "0x4006E1E")]
		[FieldOffset(Offset = "0x10")]
		public string normalId;

		// Token: 0x04006E1F RID: 28191
		[Token(Token = "0x4006E1F")]
		[FieldOffset(Offset = "0x18")]
		public string toughId;

		// Token: 0x04006E20 RID: 28192
		[Token(Token = "0x4006E20")]
		[FieldOffset(Offset = "0x20")]
		public string easyId;
	}
}
