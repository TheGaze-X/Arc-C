using System;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork.SvrCom
{
	// Token: 0x020014A6 RID: 5286
	[Token(Token = "0x20014A6")]
	public enum CommonProtocolRetCode
	{
		// Token: 0x0400781F RID: 30751
		[Token(Token = "0x400781F")]
		OK,
		// Token: 0x04007820 RID: 30752
		[Token(Token = "0x4007820")]
		SceneNotExist = 101,
		// Token: 0x04007821 RID: 30753
		[Token(Token = "0x4007821")]
		SceneJoinFailed,
		// Token: 0x04007822 RID: 30754
		[Token(Token = "0x4007822")]
		TeamNotExist = 601,
		// Token: 0x04007823 RID: 30755
		[Token(Token = "0x4007823")]
		TeamJoinFailed,
		// Token: 0x04007824 RID: 30756
		[Token(Token = "0x4007824")]
		TeamSceneStartFailed,
		// Token: 0x04007825 RID: 30757
		[Token(Token = "0x4007825")]
		TeamFull,
		// Token: 0x04007826 RID: 30758
		[Token(Token = "0x4007826")]
		TeamSceneStartFailedFull
	}
}
