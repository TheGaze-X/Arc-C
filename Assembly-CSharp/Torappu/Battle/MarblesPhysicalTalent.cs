using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002499 RID: 9369
	[Token(Token = "0x2002499")]
	[RequireComponent(typeof(Ability))]
	public class MarblesPhysicalTalent : BasicTalent
	{
		// Token: 0x0600F0F1 RID: 61681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0F1")]
		[Address(RVA = "0x68F030", Offset = "0x68DC30", VA = "0x18068F030", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F0F2 RID: 61682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0F2")]
		[Address(RVA = "0x68F250", Offset = "0x68DE50", VA = "0x18068F250")]
		public MarblesPhysicalTalent()
		{
		}

		// Token: 0x0600F0F3 RID: 61683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0F3")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x04010A8D RID: 68237
		[Token(Token = "0x4010A8D")]
		[FieldOffset(Offset = "0x50")]
		private MarblesLikeEnemy m_host;

		// Token: 0x04010A8E RID: 68238
		[Token(Token = "0x4010A8E")]
		[FieldOffset(Offset = "0x58")]
		private float m_bounciness;

		// Token: 0x04010A8F RID: 68239
		[Token(Token = "0x4010A8F")]
		[FieldOffset(Offset = "0x5C")]
		private float m_friction;

		// Token: 0x04010A90 RID: 68240
		[Token(Token = "0x4010A90")]
		private const float DEFAULT_FRICTION_FACTOR = 0.2f;

		// Token: 0x04010A91 RID: 68241
		[Token(Token = "0x4010A91")]
		private const float DEFAULT_BOUNCINESS_FACTOR = 1f;

		// Token: 0x04010A92 RID: 68242
		[Token(Token = "0x4010A92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010A93 RID: 68243
		[Token(Token = "0x4010A93")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
