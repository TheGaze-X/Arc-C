using System;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using XLua;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026BB RID: 9915
	[Token(Token = "0x20026BB")]
	public abstract class EnemyDuelStateDataBasic : IHotfixable
	{
		// Token: 0x060102BE RID: 66238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102BE")]
		[Address(RVA = "0x7E6C40", Offset = "0x7E5840", VA = "0x1807E6C40", Slot = "4")]
		public virtual void UpdateStatusData(EnemyDuelBattleStatus status)
		{
		}

		// Token: 0x060102BF RID: 66239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102BF")]
		[Address(RVA = "0x7E8AB0", Offset = "0x7E76B0", VA = "0x1807E8AB0")]
		protected EnemyDuelStateDataBasic()
		{
		}

		// Token: 0x0401207B RID: 73851
		[Token(Token = "0x401207B")]
		[FieldOffset(Offset = "0x10")]
		public EnemyDuelServiceGameState state;

		// Token: 0x0401207C RID: 73852
		[Token(Token = "0x401207C")]
		[FieldOffset(Offset = "0x14")]
		public int round;

		// Token: 0x0401207D RID: 73853
		[Token(Token = "0x401207D")]
		[FieldOffset(Offset = "0x18")]
		public long forceEndTs;

		// Token: 0x0401207E RID: 73854
		[Token(Token = "0x401207E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateStatusData;

		// Token: 0x0401207F RID: 73855
		[Token(Token = "0x401207F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
