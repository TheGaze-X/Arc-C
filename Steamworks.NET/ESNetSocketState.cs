using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	public enum ESNetSocketState
	{
		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		k_ESNetSocketStateInvalid,
		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		k_ESNetSocketStateConnected,
		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		k_ESNetSocketStateInitiated = 10,
		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		k_ESNetSocketStateLocalCandidatesFound,
		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		k_ESNetSocketStateReceivedRemoteCandidates,
		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		k_ESNetSocketStateChallengeHandshake = 15,
		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		k_ESNetSocketStateDisconnecting = 21,
		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		k_ESNetSocketStateLocalDisconnect,
		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		k_ESNetSocketStateTimeoutDuringConnect,
		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		k_ESNetSocketStateRemoteEndDisconnected,
		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		k_ESNetSocketStateConnectionBroken
	}
}
