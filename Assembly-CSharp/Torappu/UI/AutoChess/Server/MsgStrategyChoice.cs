using System;
using Il2CppDummyDll;
using Torappu.DataStream;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006467 RID: 25703
	[Token(Token = "0x2006467")]
	public class MsgStrategyChoice : IStreamDeserialize
	{
		// Token: 0x06024F2F RID: 151343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F2F")]
		[Address(RVA = "0x1FDA480", Offset = "0x1FD9080", VA = "0x181FDA480", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024F30 RID: 151344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F30")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MsgStrategyChoice()
		{
		}

		// Token: 0x04033B51 RID: 211793
		[Token(Token = "0x4033B51")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x04033B52 RID: 211794
		[Token(Token = "0x4033B52")]
		[FieldOffset(Offset = "0x18")]
		public string strategy;

		// Token: 0x04033B53 RID: 211795
		[Token(Token = "0x4033B53")]
		[FieldOffset(Offset = "0x20")]
		public int passCnt;
	}
}
