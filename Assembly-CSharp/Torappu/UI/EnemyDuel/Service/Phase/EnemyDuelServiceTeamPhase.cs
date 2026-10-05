using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel.Service.Phase
{
	// Token: 0x0200509B RID: 20635
	[Token(Token = "0x200509B")]
	public class EnemyDuelServiceTeamPhase : EnemyDuelServicePhase
	{
		// Token: 0x0601E8C8 RID: 125128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8C8")]
		[Address(RVA = "0x1848300", Offset = "0x1846F00", VA = "0x181848300", Slot = "4")]
		public override void Enter(IEnemyDuelServiceCore core)
		{
		}

		// Token: 0x0601E8C9 RID: 125129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8C9")]
		[Address(RVA = "0x1848360", Offset = "0x1846F60", VA = "0x181848360", Slot = "5")]
		public override void Leave()
		{
		}

		// Token: 0x0601E8CA RID: 125130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8CA")]
		[Address(RVA = "0x18483C0", Offset = "0x1846FC0", VA = "0x1818483C0")]
		public EnemyDuelServiceTeamPhase()
		{
		}

		// Token: 0x04028EEE RID: 167662
		[Token(Token = "0x4028EEE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Enter;

		// Token: 0x04028EEF RID: 167663
		[Token(Token = "0x4028EEF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Leave;

		// Token: 0x04028EF0 RID: 167664
		[Token(Token = "0x4028EF0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
