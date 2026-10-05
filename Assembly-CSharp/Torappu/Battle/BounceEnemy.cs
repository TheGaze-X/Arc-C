using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020025A2 RID: 9634
	[Token(Token = "0x20025A2")]
	public class BounceEnemy : Enemy
	{
		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x0600F85B RID: 63579 RVA: 0x0005D090 File Offset: 0x0005B290
		[Token(Token = "0x1700209B")]
		public override bool disableUIUnitHud
		{
			[Token(Token = "0x600F85B")]
			[Address(RVA = "0x6F2EB0", Offset = "0x6F1AB0", VA = "0x1806F2EB0", Slot = "196")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F85C RID: 63580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F85C")]
		[Address(RVA = "0x6F2C50", Offset = "0x6F1850", VA = "0x1806F2C50", Slot = "30")]
		protected override void OnInit(float initHeight)
		{
		}

		// Token: 0x0600F85D RID: 63581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F85D")]
		[Address(RVA = "0x6F2D00", Offset = "0x6F1900", VA = "0x1806F2D00", Slot = "26")]
		public override void OnRecycle()
		{
		}

		// Token: 0x0600F85E RID: 63582 RVA: 0x0005D0A8 File Offset: 0x0005B2A8
		[Token(Token = "0x600F85E")]
		[Address(RVA = "0x6F2AE0", Offset = "0x6F16E0", VA = "0x1806F2AE0", Slot = "213")]
		public override bool BeginPull(BObject source, Vector2 direction, float force)
		{
			return default(bool);
		}

		// Token: 0x0600F85F RID: 63583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F85F")]
		[Address(RVA = "0x6F2BB0", Offset = "0x6F17B0", VA = "0x1806F2BB0", Slot = "214")]
		public override void EndPull(BObject source)
		{
		}

		// Token: 0x0600F860 RID: 63584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F860")]
		[Address(RVA = "0x6F2E30", Offset = "0x6F1A30", VA = "0x1806F2E30")]
		public BounceEnemy()
		{
		}

		// Token: 0x0600F861 RID: 63585 RVA: 0x0005D0C0 File Offset: 0x0005B2C0
		[Token(Token = "0x600F861")]
		[Address(RVA = "0x6F2E20", Offset = "0x6F1A20", VA = "0x1806F2E20")]
		private bool <>xLuaBaseProxy_get_disableUIUnitHud()
		{
			return default(bool);
		}

		// Token: 0x0600F862 RID: 63586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F862")]
		[Address(RVA = "0x6F2E00", Offset = "0x6F1A00", VA = "0x1806F2E00")]
		private void <>xLuaBaseProxy_OnInit(float P0)
		{
		}

		// Token: 0x0600F863 RID: 63587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F863")]
		[Address(RVA = "0x6F2E10", Offset = "0x6F1A10", VA = "0x1806F2E10")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x0600F864 RID: 63588 RVA: 0x0005D0D8 File Offset: 0x0005B2D8
		[Token(Token = "0x600F864")]
		[Address(RVA = "0x6F2DE0", Offset = "0x6F19E0", VA = "0x1806F2DE0")]
		private bool <>xLuaBaseProxy_BeginPull(BObject P0, Vector2 P1, float P2)
		{
			return default(bool);
		}

		// Token: 0x0600F865 RID: 63589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F865")]
		[Address(RVA = "0x6F2DF0", Offset = "0x6F19F0", VA = "0x1806F2DF0")]
		private void <>xLuaBaseProxy_EndPull(BObject P0)
		{
		}

		// Token: 0x04011403 RID: 70659
		[Token(Token = "0x4011403")]
		[FieldOffset(Offset = "0x528")]
		protected PhysicsMaterial2D m_physicsMaterial;

		// Token: 0x04011404 RID: 70660
		[Token(Token = "0x4011404")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_disableUIUnitHud;

		// Token: 0x04011405 RID: 70661
		[Token(Token = "0x4011405")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04011406 RID: 70662
		[Token(Token = "0x4011406")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04011407 RID: 70663
		[Token(Token = "0x4011407")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BeginPull;

		// Token: 0x04011408 RID: 70664
		[Token(Token = "0x4011408")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EndPull;

		// Token: 0x04011409 RID: 70665
		[Token(Token = "0x4011409")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
