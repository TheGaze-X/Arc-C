using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F7A RID: 20346
	[Token(Token = "0x2004F7A")]
	public class EnemyDuelFinishMultiBattleServiceConfig : FinishBattleServiceConfig<EnemyDuelMultiBattleFinishRequest, EnemyDuelMultiBattleFinishResponse>
	{
		// Token: 0x0601E418 RID: 123928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E418")]
		[Address(RVA = "0x1804480", Offset = "0x1803080", VA = "0x181804480")]
		public EnemyDuelFinishMultiBattleServiceConfig(string actId, string sceneId)
		{
		}

		// Token: 0x0601E419 RID: 123929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E419")]
		[Address(RVA = "0x18042B0", Offset = "0x1802EB0", VA = "0x1818042B0", Slot = "9")]
		public override void OnParseRequest(EnemyDuelMultiBattleFinishRequest request)
		{
		}

		// Token: 0x040285EF RID: 165359
		[Token(Token = "0x40285EF")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;

		// Token: 0x040285F0 RID: 165360
		[Token(Token = "0x40285F0")]
		[FieldOffset(Offset = "0x20")]
		private string m_sceneId;
	}
}
