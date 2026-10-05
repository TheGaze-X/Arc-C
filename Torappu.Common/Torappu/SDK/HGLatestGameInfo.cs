using System;
using Il2CppDummyDll;

namespace Torappu.SDK
{
	// Token: 0x0200019F RID: 415
	[Token(Token = "0x200019F")]
	public class HGLatestGameInfo
	{
		// Token: 0x060009E1 RID: 2529 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HGLatestGameInfo()
		{
		}

		// Token: 0x04000933 RID: 2355
		[Token(Token = "0x4000933")]
		[FieldOffset(Offset = "0x10")]
		public int code;

		// Token: 0x04000934 RID: 2356
		[Token(Token = "0x4000934")]
		[FieldOffset(Offset = "0x18")]
		public string version;

		// Token: 0x04000935 RID: 2357
		[Token(Token = "0x4000935")]
		[FieldOffset(Offset = "0x20")]
		public int action;

		// Token: 0x04000936 RID: 2358
		[Token(Token = "0x4000936")]
		[FieldOffset(Offset = "0x24")]
		public int updateType;

		// Token: 0x04000937 RID: 2359
		[Token(Token = "0x4000937")]
		[FieldOffset(Offset = "0x28")]
		public string updateInfo;

		// Token: 0x04000938 RID: 2360
		[Token(Token = "0x4000938")]
		[FieldOffset(Offset = "0x30")]
		public int state;
	}
}
