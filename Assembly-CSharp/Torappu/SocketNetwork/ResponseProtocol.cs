using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.SocketNetwork
{
	// Token: 0x0200149E RID: 5278
	[Token(Token = "0x200149E")]
	public class ResponseProtocol<BodyType> : Protocol where BodyType : struct, IStreamDeserialize
	{
		// Token: 0x060079F4 RID: 31220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079F4")]
		public ResponseProtocol(uint pid)
		{
		}

		// Token: 0x060079F5 RID: 31221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079F5")]
		protected sealed override void OnRead(IStreamReader from)
		{
		}

		// Token: 0x040077FF RID: 30719
		[Token(Token = "0x40077FF")]
		[FieldOffset(Offset = "0x0")]
		public BodyType body;

		// Token: 0x04007800 RID: 30720
		[Token(Token = "0x4007800")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007801 RID: 30721
		[Token(Token = "0x4007801")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRead;
	}
}
