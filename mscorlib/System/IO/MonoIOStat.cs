using System;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000685 RID: 1669
	[Token(Token = "0x2000685")]
	internal struct MonoIOStat
	{
		// Token: 0x04001BD5 RID: 7125
		[Token(Token = "0x4001BD5")]
		[FieldOffset(Offset = "0x0")]
		public FileAttributes fileAttributes;

		// Token: 0x04001BD6 RID: 7126
		[Token(Token = "0x4001BD6")]
		[FieldOffset(Offset = "0x8")]
		public long Length;

		// Token: 0x04001BD7 RID: 7127
		[Token(Token = "0x4001BD7")]
		[FieldOffset(Offset = "0x10")]
		public long CreationTime;

		// Token: 0x04001BD8 RID: 7128
		[Token(Token = "0x4001BD8")]
		[FieldOffset(Offset = "0x18")]
		public long LastAccessTime;

		// Token: 0x04001BD9 RID: 7129
		[Token(Token = "0x4001BD9")]
		[FieldOffset(Offset = "0x20")]
		public long LastWriteTime;
	}
}
