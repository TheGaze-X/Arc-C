using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002458 RID: 9304
	[Token(Token = "0x2002458")]
	public class MultiAppearSkill : AppearSkill
	{
		// Token: 0x0600EF28 RID: 61224 RVA: 0x00057FF0 File Offset: 0x000561F0
		[Token(Token = "0x600EF28")]
		[Address(RVA = "0x675A60", Offset = "0x674660", VA = "0x180675A60", Slot = "19")]
		public override bool IsAvailable(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EF29 RID: 61225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF29")]
		[Address(RVA = "0x675B60", Offset = "0x674760", VA = "0x180675B60", Slot = "74")]
		protected override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600EF2A RID: 61226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF2A")]
		[Address(RVA = "0x675D50", Offset = "0x674950", VA = "0x180675D50")]
		public void SetPendingToCast()
		{
		}

		// Token: 0x0600EF2B RID: 61227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF2B")]
		[Address(RVA = "0x675AF0", Offset = "0x6746F0", VA = "0x180675AF0", Slot = "58")]
		public override void OnBorn()
		{
		}

		// Token: 0x0600EF2C RID: 61228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF2C")]
		[Address(RVA = "0x675DD0", Offset = "0x6749D0", VA = "0x180675DD0")]
		private void _StopSkill()
		{
		}

		// Token: 0x0600EF2D RID: 61229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF2D")]
		[Address(RVA = "0x675E90", Offset = "0x674A90", VA = "0x180675E90")]
		public MultiAppearSkill()
		{
		}

		// Token: 0x0600EF2E RID: 61230 RVA: 0x00058008 File Offset: 0x00056208
		[Token(Token = "0x600EF2E")]
		[Address(RVA = "0x675DB0", Offset = "0x6749B0", VA = "0x180675DB0")]
		private bool <>xLuaBaseProxy_IsAvailable(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600EF2F RID: 61231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF2F")]
		[Address(RVA = "0x635F00", Offset = "0x634B00", VA = "0x180635F00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600EF30 RID: 61232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF30")]
		[Address(RVA = "0x675DC0", Offset = "0x6749C0", VA = "0x180675DC0")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x04010882 RID: 67714
		[Token(Token = "0x4010882")]
		[FieldOffset(Offset = "0x128")]
		private bool m_pendingToCast;

		// Token: 0x04010883 RID: 67715
		[Token(Token = "0x4010883")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsAvailable;

		// Token: 0x04010884 RID: 67716
		[Token(Token = "0x4010884")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04010885 RID: 67717
		[Token(Token = "0x4010885")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetPendingToCast;

		// Token: 0x04010886 RID: 67718
		[Token(Token = "0x4010886")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x04010887 RID: 67719
		[Token(Token = "0x4010887")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__StopSkill;

		// Token: 0x04010888 RID: 67720
		[Token(Token = "0x4010888")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
