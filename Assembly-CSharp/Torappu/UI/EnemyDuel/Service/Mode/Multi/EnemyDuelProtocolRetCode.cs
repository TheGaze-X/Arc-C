using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel.Service.Mode.Multi
{
	// Token: 0x020050BC RID: 20668
	[Token(Token = "0x20050BC")]
	public enum EnemyDuelProtocolRetCode
	{
		// Token: 0x04028FA7 RID: 167847
		[Token(Token = "0x4028FA7")]
		OK,
		// Token: 0x04028FA8 RID: 167848
		[Token(Token = "0x4028FA8")]
		SceneNotExist = 101,
		// Token: 0x04028FA9 RID: 167849
		[Token(Token = "0x4028FA9")]
		SceneJoinFailed,
		// Token: 0x04028FAA RID: 167850
		[Token(Token = "0x4028FAA")]
		TeamNotExist = 601,
		// Token: 0x04028FAB RID: 167851
		[Token(Token = "0x4028FAB")]
		TeamJoinFailed,
		// Token: 0x04028FAC RID: 167852
		[Token(Token = "0x4028FAC")]
		TeamSceneStartFailed,
		// Token: 0x04028FAD RID: 167853
		[Token(Token = "0x4028FAD")]
		TeamFull,
		// Token: 0x04028FAE RID: 167854
		[Token(Token = "0x4028FAE")]
		TeamSceneStartFailedFull,
		// Token: 0x04028FAF RID: 167855
		[Token(Token = "0x4028FAF")]
		ClientCodeNetLost = 901
	}
}
