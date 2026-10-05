using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020025F3 RID: 9715
	[Token(Token = "0x20025F3")]
	public class FollowerEnemy : Enemy
	{
		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x0600FCFE RID: 64766 RVA: 0x0005FA60 File Offset: 0x0005DC60
		[Token(Token = "0x17002207")]
		public override bool disableUIUnitHud
		{
			[Token(Token = "0x600FCFE")]
			[Address(RVA = "0x7466A0", Offset = "0x7452A0", VA = "0x1807466A0", Slot = "196")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600FCFF RID: 64767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCFF")]
		[Address(RVA = "0x746160", Offset = "0x744D60", VA = "0x180746160", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600FD00 RID: 64768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD00")]
		[Address(RVA = "0x746100", Offset = "0x744D00", VA = "0x180746100", Slot = "32")]
		protected override void OnBorn()
		{
		}

		// Token: 0x0600FD01 RID: 64769 RVA: 0x0005FA78 File Offset: 0x0005DC78
		[Token(Token = "0x600FD01")]
		[Address(RVA = "0x7461F0", Offset = "0x744DF0", VA = "0x1807461F0", Slot = "217")]
		protected override Vector2 _MoveByRoute(float deltaTime, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600FD02 RID: 64770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD02")]
		[Address(RVA = "0x746620", Offset = "0x745220", VA = "0x180746620")]
		public FollowerEnemy()
		{
		}

		// Token: 0x0600FD03 RID: 64771 RVA: 0x0005FA90 File Offset: 0x0005DC90
		[Token(Token = "0x600FD03")]
		[Address(RVA = "0x6F2E20", Offset = "0x6F1A20", VA = "0x1806F2E20")]
		private bool <>xLuaBaseProxy_get_disableUIUnitHud()
		{
			return default(bool);
		}

		// Token: 0x0600FD04 RID: 64772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD04")]
		[Address(RVA = "0x6099C0", Offset = "0x6085C0", VA = "0x1806099C0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600FD05 RID: 64773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD05")]
		[Address(RVA = "0x6099B0", Offset = "0x6085B0", VA = "0x1806099B0")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600FD06 RID: 64774 RVA: 0x0005FAA8 File Offset: 0x0005DCA8
		[Token(Token = "0x600FD06")]
		[Address(RVA = "0x6F0050", Offset = "0x6EEC50", VA = "0x1806F0050")]
		private Vector2 <>xLuaBaseProxy__MoveByRoute(float P0, out bool P1)
		{
			return default(Vector2);
		}

		// Token: 0x0401191D RID: 71965
		[Token(Token = "0x401191D")]
		[FieldOffset(Offset = "0x528")]
		private ObjectPtr<Enemy> m_hostEnemy;

		// Token: 0x0401191E RID: 71966
		[Token(Token = "0x401191E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_disableUIUnitHud;

		// Token: 0x0401191F RID: 71967
		[Token(Token = "0x401191F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x04011920 RID: 71968
		[Token(Token = "0x4011920")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x04011921 RID: 71969
		[Token(Token = "0x4011921")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__MoveByRoute;

		// Token: 0x04011922 RID: 71970
		[Token(Token = "0x4011922")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
