using System;
using Il2CppDummyDll;
using Torappu.SocketNetwork.Connections;
using XLua;

namespace Torappu.UI.EnemyDuel.Service.Phase
{
	// Token: 0x0200509A RID: 20634
	[Token(Token = "0x200509A")]
	public abstract class EnemyDuelServicePhase : IHotfixable
	{
		// Token: 0x0601E8C2 RID: 125122
		[Token(Token = "0x601E8C2")]
		public abstract void Enter(IEnemyDuelServiceCore core);

		// Token: 0x0601E8C3 RID: 125123
		[Token(Token = "0x601E8C3")]
		public abstract void Leave();

		// Token: 0x0601E8C4 RID: 125124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8C4")]
		[Address(RVA = "0x1841A40", Offset = "0x1840640", VA = "0x181841A40", Slot = "6")]
		public virtual void FixedUpdate()
		{
		}

		// Token: 0x0601E8C5 RID: 125125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8C5")]
		[Address(RVA = "0x1844DF0", Offset = "0x18439F0", VA = "0x181844DF0", Slot = "7")]
		public virtual void OnGUI()
		{
		}

		// Token: 0x0601E8C6 RID: 125126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8C6")]
		[Address(RVA = "0x1841AA0", Offset = "0x18406A0", VA = "0x181841AA0", Slot = "8")]
		public virtual void OnNetStateChanged(ConnectionState state)
		{
		}

		// Token: 0x0601E8C7 RID: 125127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8C7")]
		[Address(RVA = "0x1844E50", Offset = "0x1843A50", VA = "0x181844E50")]
		protected EnemyDuelServicePhase()
		{
		}

		// Token: 0x04028EEA RID: 167658
		[Token(Token = "0x4028EEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x04028EEB RID: 167659
		[Token(Token = "0x4028EEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGUI;

		// Token: 0x04028EEC RID: 167660
		[Token(Token = "0x4028EEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnNetStateChanged;

		// Token: 0x04028EED RID: 167661
		[Token(Token = "0x4028EED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
