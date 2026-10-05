using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.SocketNetwork
{
	// Token: 0x0200149B RID: 5275
	[Token(Token = "0x200149B")]
	public class UpProtocol<BodyType> : Protocol where BodyType : class, IStreamSerialize, new()
	{
		// Token: 0x060079EB RID: 31211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079EB")]
		public UpProtocol(uint pid)
		{
		}

		// Token: 0x060079EC RID: 31212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079EC")]
		protected override void OnWrite(IStreamWriter to)
		{
		}

		// Token: 0x040077F5 RID: 30709
		[Token(Token = "0x40077F5")]
		[FieldOffset(Offset = "0x0")]
		public BodyType body;

		// Token: 0x040077F6 RID: 30710
		[Token(Token = "0x40077F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040077F7 RID: 30711
		[Token(Token = "0x40077F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnWrite;
	}
}
