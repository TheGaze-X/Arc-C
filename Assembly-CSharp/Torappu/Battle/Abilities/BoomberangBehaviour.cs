using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C13 RID: 11283
	[Token(Token = "0x2002C13")]
	public class BoomberangBehaviour : AbilityStandard.Behaviour
	{
		// Token: 0x060130DE RID: 78046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130DE")]
		[Address(RVA = "0xB14880", Offset = "0xB13480", VA = "0x180B14880", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x060130DF RID: 78047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130DF")]
		[Address(RVA = "0xB147C0", Offset = "0xB133C0", VA = "0x180B147C0", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x060130E0 RID: 78048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130E0")]
		[Address(RVA = "0xB14AA0", Offset = "0xB136A0", VA = "0x180B14AA0")]
		public BoomberangBehaviour()
		{
		}

		// Token: 0x060130E1 RID: 78049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130E1")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x060130E2 RID: 78050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130E2")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x04015846 RID: 88134
		[Token(Token = "0x4015846")]
		[FieldOffset(Offset = "0x20")]
		private BoomberangTrait m_trait;

		// Token: 0x04015847 RID: 88135
		[Token(Token = "0x4015847")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04015848 RID: 88136
		[Token(Token = "0x4015848")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04015849 RID: 88137
		[Token(Token = "0x4015849")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
