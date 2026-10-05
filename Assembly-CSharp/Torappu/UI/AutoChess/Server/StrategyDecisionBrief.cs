using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006466 RID: 25702
	[Token(Token = "0x2006466")]
	public struct StrategyDecisionBrief : IStreamDeserialize
	{
		// Token: 0x06024F2E RID: 151342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F2E")]
		[Address(RVA = "0x1FDC3B0", Offset = "0x1FDAFB0", VA = "0x181FDC3B0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x04033B4D RID: 211789
		[Token(Token = "0x4033B4D")]
		[FieldOffset(Offset = "0x0")]
		public long roundFinTs;

		// Token: 0x04033B4E RID: 211790
		[Token(Token = "0x4033B4E")]
		[FieldOffset(Offset = "0x8")]
		public bool canSkip;

		// Token: 0x04033B4F RID: 211791
		[Token(Token = "0x4033B4F")]
		[FieldOffset(Offset = "0x10")]
		public string currUID;

		// Token: 0x04033B50 RID: 211792
		[Token(Token = "0x4033B50")]
		[FieldOffset(Offset = "0x18")]
		public List<MsgStrategyChoice> choices;
	}
}
