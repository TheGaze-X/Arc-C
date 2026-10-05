using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class KeyBoardVirtualButtonConfig
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x54E4160", Offset = "0x54E2D60", VA = "0x1854E4160", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x6000050")]
		[Address(RVA = "0xEFBC40", Offset = "0xEFA840", VA = "0x180EFBC40")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x54E4240", Offset = "0x54E2E40", VA = "0x1854E4240", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public KeyBoardVirtualButtonConfig(string groupId, string funcId)
		{
		}

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x18")]
		public string funcId;
	}
}
