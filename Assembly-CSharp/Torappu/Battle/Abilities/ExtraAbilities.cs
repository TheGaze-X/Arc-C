using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C19 RID: 11289
	[Token(Token = "0x2002C19")]
	public class ExtraAbilities : AbilityStandard.Behaviour
	{
		// Token: 0x06013104 RID: 78084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013104")]
		[Address(RVA = "0xB1B120", Offset = "0xB19D20", VA = "0x180B1B120", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06013105 RID: 78085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013105")]
		[Address(RVA = "0xB1AFD0", Offset = "0xB19BD0", VA = "0x180B1AFD0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06013106 RID: 78086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013106")]
		[Address(RVA = "0xB1B330", Offset = "0xB19F30", VA = "0x180B1B330")]
		public ExtraAbilities()
		{
		}

		// Token: 0x06013107 RID: 78087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013107")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06013108 RID: 78088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013108")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x0401586D RID: 88173
		[Token(Token = "0x401586D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Ability[] _abilities;

		// Token: 0x0401586E RID: 88174
		[Token(Token = "0x401586E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _useExtraAbilitySignal;

		// Token: 0x0401586F RID: 88175
		[Token(Token = "0x401586F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04015870 RID: 88176
		[Token(Token = "0x4015870")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015871 RID: 88177
		[Token(Token = "0x4015871")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
