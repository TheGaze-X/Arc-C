using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020025F2 RID: 9714
	[Token(Token = "0x20025F2")]
	public abstract class FixedDirectionEnemy : Enemy
	{
		// Token: 0x0600FCF8 RID: 64760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCF8")]
		[Address(RVA = "0x745DB0", Offset = "0x7449B0", VA = "0x180745DB0", Slot = "26")]
		public override void OnRecycle()
		{
		}

		// Token: 0x0600FCF9 RID: 64761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCF9")]
		[Address(RVA = "0x745E50", Offset = "0x744A50", VA = "0x180745E50")]
		public void SetFixedMoveDirection(Vector2 dir)
		{
		}

		// Token: 0x0600FCFA RID: 64762 RVA: 0x0005FA30 File Offset: 0x0005DC30
		[Token(Token = "0x600FCFA")]
		[Address(RVA = "0x745ED0", Offset = "0x744AD0", VA = "0x180745ED0", Slot = "217")]
		protected override Vector2 _MoveByRoute(float deltaTime, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600FCFB RID: 64763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCFB")]
		[Address(RVA = "0x746080", Offset = "0x744C80", VA = "0x180746080")]
		protected FixedDirectionEnemy()
		{
		}

		// Token: 0x0600FCFC RID: 64764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCFC")]
		[Address(RVA = "0x6F2E10", Offset = "0x6F1A10", VA = "0x1806F2E10")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x0600FCFD RID: 64765 RVA: 0x0005FA48 File Offset: 0x0005DC48
		[Token(Token = "0x600FCFD")]
		[Address(RVA = "0x6F0050", Offset = "0x6EEC50", VA = "0x1806F0050")]
		private Vector2 <>xLuaBaseProxy__MoveByRoute(float P0, out bool P1)
		{
			return default(Vector2);
		}

		// Token: 0x04011918 RID: 71960
		[Token(Token = "0x4011918")]
		[FieldOffset(Offset = "0x528")]
		private Vector2 m_fixedMoveDirection;

		// Token: 0x04011919 RID: 71961
		[Token(Token = "0x4011919")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x0401191A RID: 71962
		[Token(Token = "0x401191A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetFixedMoveDirection;

		// Token: 0x0401191B RID: 71963
		[Token(Token = "0x401191B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__MoveByRoute;

		// Token: 0x0401191C RID: 71964
		[Token(Token = "0x401191C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
