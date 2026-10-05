using System;
using Il2CppDummyDll;
using Torappu.DataStream;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006468 RID: 25704
	[Token(Token = "0x2006468")]
	public struct AutoChessServiceMatchResult : IStreamDeserialize
	{
		// Token: 0x06024F31 RID: 151345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F31")]
		[Address(RVA = "0x1FD68B0", Offset = "0x1FD54B0", VA = "0x181FD68B0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x04033B54 RID: 211796
		[Token(Token = "0x4033B54")]
		[FieldOffset(Offset = "0x0")]
		public AutoChessServiceMatchResult.RetCode retCode;

		// Token: 0x04033B55 RID: 211797
		[Token(Token = "0x4033B55")]
		[FieldOffset(Offset = "0x8")]
		public string address;

		// Token: 0x04033B56 RID: 211798
		[Token(Token = "0x4033B56")]
		[FieldOffset(Offset = "0x10")]
		public string teamId;

		// Token: 0x04033B57 RID: 211799
		[Token(Token = "0x4033B57")]
		[FieldOffset(Offset = "0x18")]
		public string teamToken;

		// Token: 0x02006469 RID: 25705
		[Token(Token = "0x2006469")]
		public enum RetCode
		{
			// Token: 0x04033B59 RID: 211801
			[Token(Token = "0x4033B59")]
			SUC,
			// Token: 0x04033B5A RID: 211802
			[Token(Token = "0x4033B5A")]
			CANCEL,
			// Token: 0x04033B5B RID: 211803
			[Token(Token = "0x4033B5B")]
			TIMEOUT
		}
	}
}
