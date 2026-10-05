using System;
using Il2CppDummyDll;

namespace Torappu.UI.Medal
{
	// Token: 0x0200499F RID: 18847
	[Token(Token = "0x200499F")]
	public class MedalDisplayViewModel
	{
		// Token: 0x1700433C RID: 17212
		// (get) Token: 0x0601C665 RID: 116325 RVA: 0x000A8288 File Offset: 0x000A6488
		[Token(Token = "0x1700433C")]
		public int totalCount
		{
			[Token(Token = "0x601C665")]
			[Address(RVA = "0x15EA2D0", Offset = "0x15E8ED0", VA = "0x1815EA2D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601C666 RID: 116326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C666")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MedalDisplayViewModel()
		{
		}

		// Token: 0x04025332 RID: 152370
		[Token(Token = "0x4025332")]
		[FieldOffset(Offset = "0x10")]
		public string medalGroupId;

		// Token: 0x04025333 RID: 152371
		[Token(Token = "0x4025333")]
		[FieldOffset(Offset = "0x18")]
		public MedalGroupData groupData;

		// Token: 0x04025334 RID: 152372
		[Token(Token = "0x4025334")]
		[FieldOffset(Offset = "0x20")]
		public int availCount;
	}
}
