using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer
{
	// Token: 0x0200152F RID: 5423
	[Token(Token = "0x200152F")]
	public class TeamInst
	{
		// Token: 0x06007C83 RID: 31875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C83")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TeamInst()
		{
		}

		// Token: 0x04007C70 RID: 31856
		[Token(Token = "0x4007C70")]
		[FieldOffset(Offset = "0x10")]
		public string teamId;

		// Token: 0x04007C71 RID: 31857
		[Token(Token = "0x4007C71")]
		[FieldOffset(Offset = "0x18")]
		public string mentorUid;

		// Token: 0x04007C72 RID: 31858
		[Token(Token = "0x4007C72")]
		[FieldOffset(Offset = "0x20")]
		public string serverAddress;

		// Token: 0x04007C73 RID: 31859
		[Token(Token = "0x4007C73")]
		[FieldOffset(Offset = "0x28")]
		public string serverToken;
	}
}
