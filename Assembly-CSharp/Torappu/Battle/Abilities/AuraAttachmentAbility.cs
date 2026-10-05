using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B22 RID: 11042
	[Token(Token = "0x2002B22")]
	public class AuraAttachmentAbility : AuraAbility
	{
		// Token: 0x060127F1 RID: 75761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127F1")]
		[Address(RVA = "0xA7B7E0", Offset = "0xA7A3E0", VA = "0x180A7B7E0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060127F2 RID: 75762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127F2")]
		[Address(RVA = "0xA7B6F0", Offset = "0xA7A2F0", VA = "0x180A7B6F0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x060127F3 RID: 75763 RVA: 0x000716D0 File Offset: 0x0006F8D0
		[Token(Token = "0x60127F3")]
		[Address(RVA = "0xA7B620", Offset = "0xA7A220", VA = "0x180A7B620", Slot = "98")]
		protected override bool DealTargetTouched(Entity target, AuraAbility.TargetMeta meta)
		{
			return default(bool);
		}

		// Token: 0x060127F4 RID: 75764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127F4")]
		[Address(RVA = "0xA7B570", Offset = "0xA7A170", VA = "0x180A7B570", Slot = "99")]
		protected override void DealTargetLeft(Entity target, AuraAbility.TargetMeta meta)
		{
		}

		// Token: 0x060127F5 RID: 75765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127F5")]
		[Address(RVA = "0xA7B980", Offset = "0xA7A580", VA = "0x180A7B980")]
		public AuraAttachmentAbility()
		{
		}

		// Token: 0x060127F6 RID: 75766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127F6")]
		[Address(RVA = "0xA7B950", Offset = "0xA7A550", VA = "0x180A7B950")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060127F7 RID: 75767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127F7")]
		[Address(RVA = "0xA7B940", Offset = "0xA7A540", VA = "0x180A7B940")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x060127F8 RID: 75768 RVA: 0x000716E8 File Offset: 0x0006F8E8
		[Token(Token = "0x60127F8")]
		[Address(RVA = "0xA7B930", Offset = "0xA7A530", VA = "0x180A7B930")]
		private bool <>xLuaBaseProxy_DealTargetTouched(Entity P0, AuraAbility.TargetMeta P1)
		{
			return default(bool);
		}

		// Token: 0x060127F9 RID: 75769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127F9")]
		[Address(RVA = "0xA7B920", Offset = "0xA7A520", VA = "0x180A7B920")]
		private void <>xLuaBaseProxy_DealTargetLeft(Entity P0, AuraAbility.TargetMeta P1)
		{
		}

		// Token: 0x04014E70 RID: 85616
		[Token(Token = "0x4014E70")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Group("Attachment")]
		[Tooltip("These buffs would be added to the target ability as active buffs")]
		private BuffData[] _additiveActiveBuffs;

		// Token: 0x04014E71 RID: 85617
		[Token(Token = "0x4014E71")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Group("Attachment")]
		private Ability.FamilyGroupMask _targetFamilyMask;

		// Token: 0x04014E72 RID: 85618
		[Token(Token = "0x4014E72")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		[Group("Attachment")]
		private TargetValidator _attachTargetValidator;

		// Token: 0x04014E73 RID: 85619
		[Token(Token = "0x4014E73")]
		[FieldOffset(Offset = "0x198")]
		private AbilityAttachment m_attachment;

		// Token: 0x04014E74 RID: 85620
		[Token(Token = "0x4014E74")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014E75 RID: 85621
		[Token(Token = "0x4014E75")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014E76 RID: 85622
		[Token(Token = "0x4014E76")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DealTargetTouched;

		// Token: 0x04014E77 RID: 85623
		[Token(Token = "0x4014E77")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DealTargetLeft;

		// Token: 0x04014E78 RID: 85624
		[Token(Token = "0x4014E78")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
