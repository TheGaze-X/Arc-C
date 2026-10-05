using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C34 RID: 11316
	[Token(Token = "0x2002C34")]
	public class UpdateAttackTimeByHost : AbilityStandard.Behaviour
	{
		// Token: 0x060131B2 RID: 78258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131B2")]
		[Address(RVA = "0xB2A470", Offset = "0xB29070", VA = "0x180B2A470", Slot = "8")]
		public override void OnAttackTimeChanged(FP newValue)
		{
		}

		// Token: 0x060131B3 RID: 78259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131B3")]
		[Address(RVA = "0xB2A500", Offset = "0xB29100", VA = "0x180B2A500", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x060131B4 RID: 78260 RVA: 0x00074988 File Offset: 0x00072B88
		[Token(Token = "0x60131B4")]
		[Address(RVA = "0xB2A590", Offset = "0xB29190", VA = "0x180B2A590")]
		private bool _TryGetHost()
		{
			return default(bool);
		}

		// Token: 0x060131B5 RID: 78261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131B5")]
		[Address(RVA = "0xB2A7F0", Offset = "0xB293F0", VA = "0x180B2A7F0")]
		private void _UpdateAtkInternal()
		{
		}

		// Token: 0x060131B6 RID: 78262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131B6")]
		[Address(RVA = "0xB2A9B0", Offset = "0xB295B0", VA = "0x180B2A9B0")]
		public UpdateAttackTimeByHost()
		{
		}

		// Token: 0x060131B7 RID: 78263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131B7")]
		[Address(RVA = "0xB2A580", Offset = "0xB29180", VA = "0x180B2A580")]
		private void <>xLuaBaseProxy_OnAttackTimeChanged(FP P0)
		{
		}

		// Token: 0x060131B8 RID: 78264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131B8")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x04015940 RID: 88384
		[Token(Token = "0x4015940")]
		[FieldOffset(Offset = "0x20")]
		private Character m_host;

		// Token: 0x04015941 RID: 88385
		[Token(Token = "0x4015941")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnAttackTimeChanged;

		// Token: 0x04015942 RID: 88386
		[Token(Token = "0x4015942")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04015943 RID: 88387
		[Token(Token = "0x4015943")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryGetHost;

		// Token: 0x04015944 RID: 88388
		[Token(Token = "0x4015944")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateAtkInternal;

		// Token: 0x04015945 RID: 88389
		[Token(Token = "0x4015945")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
