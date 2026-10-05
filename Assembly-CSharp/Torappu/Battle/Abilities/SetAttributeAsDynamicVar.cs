using System;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BD8 RID: 11224
	[Token(Token = "0x2002BD8")]
	public class SetAttributeAsDynamicVar : AbilityStandard.Behaviour
	{
		// Token: 0x06012F3B RID: 77627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F3B")]
		[Address(RVA = "0xAEB5A0", Offset = "0xAEA1A0", VA = "0x180AEB5A0", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06012F3C RID: 77628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F3C")]
		[Address(RVA = "0xAEB600", Offset = "0xAEA200", VA = "0x180AEB600", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012F3D RID: 77629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F3D")]
		[Address(RVA = "0xAEB680", Offset = "0xAEA280", VA = "0x180AEB680")]
		private void _UpdateDynamicVar()
		{
		}

		// Token: 0x06012F3E RID: 77630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F3E")]
		[Address(RVA = "0xAEB960", Offset = "0xAEA560", VA = "0x180AEB960")]
		public SetAttributeAsDynamicVar()
		{
		}

		// Token: 0x06012F3F RID: 77631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F3F")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012F40 RID: 77632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F40")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015645 RID: 87621
		[Token(Token = "0x4015645")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AttributeType _attributeType;

		// Token: 0x04015646 RID: 87622
		[Token(Token = "0x4015646")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _scaleVar;

		// Token: 0x04015647 RID: 87623
		[Token(Token = "0x4015647")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _durationKey;

		// Token: 0x04015648 RID: 87624
		[Token(Token = "0x4015648")]
		[FieldOffset(Offset = "0x38")]
		private float m_nextEscapeTime;

		// Token: 0x04015649 RID: 87625
		[Token(Token = "0x4015649")]
		[FieldOffset(Offset = "0x40")]
		private ObjectPtr<Effect> m_effectHolder;

		// Token: 0x0401564A RID: 87626
		[Token(Token = "0x401564A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x0401564B RID: 87627
		[Token(Token = "0x401564B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0401564C RID: 87628
		[Token(Token = "0x401564C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateDynamicVar;

		// Token: 0x0401564D RID: 87629
		[Token(Token = "0x401564D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
