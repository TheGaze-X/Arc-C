using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C29 RID: 11305
	[Token(Token = "0x2002C29")]
	public class SetInputPointToProjectileToPointAbility : AbilityStandard.Behaviour
	{
		// Token: 0x06013173 RID: 78195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013173")]
		[Address(RVA = "0xB248E0", Offset = "0xB234E0", VA = "0x180B248E0", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06013174 RID: 78196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013174")]
		[Address(RVA = "0xB24600", Offset = "0xB23200", VA = "0x180B24600", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06013175 RID: 78197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013175")]
		[Address(RVA = "0xB249B0", Offset = "0xB235B0", VA = "0x180B249B0")]
		public SetInputPointToProjectileToPointAbility()
		{
		}

		// Token: 0x06013176 RID: 78198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013176")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06013177 RID: 78199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013177")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x040158E5 RID: 88293
		[Token(Token = "0x40158E5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _abilityName;

		// Token: 0x040158E6 RID: 88294
		[Token(Token = "0x40158E6")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 m_targetPos;

		// Token: 0x040158E7 RID: 88295
		[Token(Token = "0x40158E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040158E8 RID: 88296
		[Token(Token = "0x40158E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040158E9 RID: 88297
		[Token(Token = "0x40158E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
