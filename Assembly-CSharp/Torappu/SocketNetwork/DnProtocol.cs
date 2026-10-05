using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.SocketNetwork
{
	// Token: 0x0200149C RID: 5276
	[Token(Token = "0x200149C")]
	public class DnProtocol<BodyType> : Protocol where BodyType : class, IStreamDeserialize, new()
	{
		// Token: 0x060079ED RID: 31213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079ED")]
		public DnProtocol(uint pid)
		{
		}

		// Token: 0x060079EE RID: 31214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079EE")]
		protected override void OnRead(IStreamReader from)
		{
		}

		// Token: 0x040077F8 RID: 30712
		[Token(Token = "0x40077F8")]
		[FieldOffset(Offset = "0x0")]
		public BodyType body;

		// Token: 0x040077F9 RID: 30713
		[Token(Token = "0x40077F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040077FA RID: 30714
		[Token(Token = "0x40077FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRead;
	}
}
