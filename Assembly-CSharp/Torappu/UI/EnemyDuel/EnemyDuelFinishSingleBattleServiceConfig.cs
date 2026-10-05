using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F7D RID: 20349
	[Token(Token = "0x2004F7D")]
	public class EnemyDuelFinishSingleBattleServiceConfig : FinishBattleServiceConfig<EnemyDuelSingleBattleFinishRequest, EnemyDuelSingleBattleFinishResponse>
	{
		// Token: 0x0601E41C RID: 123932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E41C")]
		[Address(RVA = "0x18046F0", Offset = "0x18032F0", VA = "0x1818046F0")]
		public EnemyDuelFinishSingleBattleServiceConfig(string actId)
		{
		}

		// Token: 0x0601E41D RID: 123933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E41D")]
		[Address(RVA = "0x1804510", Offset = "0x1803110", VA = "0x181804510", Slot = "9")]
		public override void OnParseRequest(EnemyDuelSingleBattleFinishRequest request)
		{
		}

		// Token: 0x040285FB RID: 165371
		[Token(Token = "0x40285FB")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;
	}
}
