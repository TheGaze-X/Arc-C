using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C28 RID: 11304
	[Token(Token = "0x2002C28")]
	public class SetAtkScaleAsHostBasedFixed : AbilityStandard.Behaviour
	{
		// Token: 0x0601316E RID: 78190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601316E")]
		[Address(RVA = "0xB24210", Offset = "0xB22E10", VA = "0x180B24210", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0601316F RID: 78191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601316F")]
		[Address(RVA = "0xB23FC0", Offset = "0xB22BC0", VA = "0x180B23FC0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06013170 RID: 78192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013170")]
		[Address(RVA = "0xB242D0", Offset = "0xB22ED0", VA = "0x180B242D0")]
		public SetAtkScaleAsHostBasedFixed()
		{
		}

		// Token: 0x06013171 RID: 78193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013171")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06013172 RID: 78194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013172")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x040158E1 RID: 88289
		[Token(Token = "0x40158E1")]
		[FieldOffset(Offset = "0x20")]
		private float m_atkScale;

		// Token: 0x040158E2 RID: 88290
		[Token(Token = "0x40158E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040158E3 RID: 88291
		[Token(Token = "0x40158E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040158E4 RID: 88292
		[Token(Token = "0x40158E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
