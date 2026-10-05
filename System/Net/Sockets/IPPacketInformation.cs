using System;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003B4 RID: 948
	[Token(Token = "0x20003B4")]
	public struct IPPacketInformation
	{
		// Token: 0x060019DC RID: 6620 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		[Token(Token = "0x60019DC")]
		[Address(RVA = "0x50BC7B0", Offset = "0x50BB3B0", VA = "0x1850BC7B0", Slot = "0")]
		public override bool Equals(object comparand)
		{
			return default(bool);
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0000BA00 File Offset: 0x00009C00
		[Token(Token = "0x60019DD")]
		[Address(RVA = "0x50BC880", Offset = "0x50BB480", VA = "0x1850BC880", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		[FieldOffset(Offset = "0x0")]
		private IPAddress address;

		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		[FieldOffset(Offset = "0x8")]
		private int networkInterface;
	}
}
