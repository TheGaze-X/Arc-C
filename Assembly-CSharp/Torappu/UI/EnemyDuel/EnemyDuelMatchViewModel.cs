using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005036 RID: 20534
	[Token(Token = "0x2005036")]
	public class EnemyDuelMatchViewModel : IHotfixable
	{
		// Token: 0x0601E74B RID: 124747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E74B")]
		[Address(RVA = "0x1824600", Offset = "0x1823200", VA = "0x181824600")]
		public void LoadInitData(string actId, ActivityEnemyDuelModeData modeData)
		{
		}

		// Token: 0x0601E74C RID: 124748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E74C")]
		[Address(RVA = "0x1824700", Offset = "0x1823300", VA = "0x181824700")]
		public void SyncMatchStatus(EnemyDuelQueryMatchResponse resp)
		{
		}

		// Token: 0x0601E74D RID: 124749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E74D")]
		[Address(RVA = "0x1824790", Offset = "0x1823390", VA = "0x181824790")]
		public void UpdateMatchTime(float time)
		{
		}

		// Token: 0x0601E74E RID: 124750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E74E")]
		[Address(RVA = "0x1824800", Offset = "0x1823400", VA = "0x181824800")]
		public EnemyDuelMatchViewModel()
		{
		}

		// Token: 0x04028C29 RID: 166953
		[Token(Token = "0x4028C29")]
		[FieldOffset(Offset = "0x10")]
		public int curPlayer;

		// Token: 0x04028C2A RID: 166954
		[Token(Token = "0x4028C2A")]
		[FieldOffset(Offset = "0x14")]
		public int maxPlayer;

		// Token: 0x04028C2B RID: 166955
		[Token(Token = "0x4028C2B")]
		[FieldOffset(Offset = "0x18")]
		public float matchTime;

		// Token: 0x04028C2C RID: 166956
		[Token(Token = "0x4028C2C")]
		[FieldOffset(Offset = "0x1C")]
		public bool isMatchSucc;

		// Token: 0x04028C2D RID: 166957
		[Token(Token = "0x4028C2D")]
		[FieldOffset(Offset = "0x20")]
		public string actId;

		// Token: 0x04028C2E RID: 166958
		[Token(Token = "0x4028C2E")]
		[FieldOffset(Offset = "0x28")]
		public string modeId;

		// Token: 0x04028C2F RID: 166959
		[Token(Token = "0x4028C2F")]
		[FieldOffset(Offset = "0x30")]
		public ActivityEnemyDuelConstToastData constToastData;

		// Token: 0x04028C30 RID: 166960
		[Token(Token = "0x4028C30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadInitData;

		// Token: 0x04028C31 RID: 166961
		[Token(Token = "0x4028C31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SyncMatchStatus;

		// Token: 0x04028C32 RID: 166962
		[Token(Token = "0x4028C32")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateMatchTime;

		// Token: 0x04028C33 RID: 166963
		[Token(Token = "0x4028C33")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
