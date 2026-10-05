using System;
using Il2CppDummyDll;
using Torappu.SocketNetwork.ServerBase;

namespace Torappu.UI
{
	// Token: 0x020037C7 RID: 14279
	[Token(Token = "0x20037C7")]
	public class ServerLoadingMask : IServerLoadingMask
	{
		// Token: 0x06016A29 RID: 92713 RVA: 0x000920E8 File Offset: 0x000902E8
		[Token(Token = "0x6016A29")]
		[Address(RVA = "0xF06E20", Offset = "0xF05A20", VA = "0x180F06E20", Slot = "4")]
		public bool Show(ServerLoadingMaskType maskType)
		{
			return default(bool);
		}

		// Token: 0x06016A2A RID: 92714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A2A")]
		[Address(RVA = "0xF06D70", Offset = "0xF05970", VA = "0x180F06D70", Slot = "5")]
		public void Hide(ServerLoadingMaskType maskType, Action callback)
		{
		}

		// Token: 0x06016A2B RID: 92715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016A2B")]
		[Address(RVA = "0xF06EB0", Offset = "0xF05AB0", VA = "0x180F06EB0")]
		private static UIFloatMask _PickLoadingMask(ServerLoadingMaskType maskType)
		{
			return null;
		}

		// Token: 0x06016A2C RID: 92716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A2C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ServerLoadingMask()
		{
		}
	}
}
