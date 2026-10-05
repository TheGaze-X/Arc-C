using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000374 RID: 884
	[Token(Token = "0x2000374")]
	public enum NetBiosNodeType
	{
		// Token: 0x04000EA8 RID: 3752
		[Token(Token = "0x4000EA8")]
		Unknown,
		// Token: 0x04000EA9 RID: 3753
		[Token(Token = "0x4000EA9")]
		Broadcast,
		// Token: 0x04000EAA RID: 3754
		[Token(Token = "0x4000EAA")]
		Peer2Peer,
		// Token: 0x04000EAB RID: 3755
		[Token(Token = "0x4000EAB")]
		Mixed = 4,
		// Token: 0x04000EAC RID: 3756
		[Token(Token = "0x4000EAC")]
		Hybrid = 8
	}
}
