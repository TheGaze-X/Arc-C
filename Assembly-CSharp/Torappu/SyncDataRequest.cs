using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008C6 RID: 2246
	[Token(Token = "0x20008C6")]
	public class SyncDataRequest
	{
		// Token: 0x06006578 RID: 25976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006578")]
		[Address(RVA = "0x1F02560", Offset = "0x1F01160", VA = "0x181F02560")]
		public SyncDataRequest()
		{
		}

		// Token: 0x06006579 RID: 25977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006579")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		public SyncDataRequest(PlatformKey platform)
		{
		}

		// Token: 0x040032B9 RID: 12985
		[Token(Token = "0x40032B9")]
		[FieldOffset(Offset = "0x10")]
		public PlatformKey platform;
	}
}
