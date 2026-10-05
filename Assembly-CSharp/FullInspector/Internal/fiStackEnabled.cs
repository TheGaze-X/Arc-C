using System;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007CA9 RID: 31913
	[Token(Token = "0x2007CA9")]
	public class fiStackEnabled
	{
		// Token: 0x0602C934 RID: 182580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C934")]
		[Address(RVA = "0x2873F20", Offset = "0x2872B20", VA = "0x182873F20")]
		public void Push()
		{
		}

		// Token: 0x0602C935 RID: 182581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C935")]
		[Address(RVA = "0x2873F00", Offset = "0x2872B00", VA = "0x182873F00")]
		public void Pop()
		{
		}

		// Token: 0x17006851 RID: 26705
		// (get) Token: 0x0602C936 RID: 182582 RVA: 0x000E0EB0 File Offset: 0x000DF0B0
		[Token(Token = "0x17006851")]
		public bool Enabled
		{
			[Token(Token = "0x602C936")]
			[Address(RVA = "0x2873F30", Offset = "0x2872B30", VA = "0x182873F30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C937 RID: 182583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C937")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fiStackEnabled()
		{
		}

		// Token: 0x040403D0 RID: 263120
		[Token(Token = "0x40403D0")]
		[FieldOffset(Offset = "0x10")]
		private int _count;
	}
}
