using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B45 RID: 11077
	[Token(Token = "0x2002B45")]
	public class PassiveAttachmentAbility : PassiveBuffAbility
	{
		// Token: 0x170028F8 RID: 10488
		// (get) Token: 0x06012985 RID: 76165 RVA: 0x00071E20 File Offset: 0x00070020
		[Token(Token = "0x170028F8")]
		public override bool isAffecting
		{
			[Token(Token = "0x6012985")]
			[Address(RVA = "0xA8BF00", Offset = "0xA8AB00", VA = "0x180A8BF00", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012986 RID: 76166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012986")]
		[Address(RVA = "0xA8BDA0", Offset = "0xA8A9A0", VA = "0x180A8BDA0", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012987 RID: 76167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012987")]
		[Address(RVA = "0xA8BC60", Offset = "0xA8A860", VA = "0x180A8BC60", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012988 RID: 76168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012988")]
		[Address(RVA = "0xA8BA10", Offset = "0xA8A610", VA = "0x180A8BA10", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012989 RID: 76169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012989")]
		[Address(RVA = "0xA8BB80", Offset = "0xA8A780", VA = "0x180A8BB80", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0601298A RID: 76170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601298A")]
		[Address(RVA = "0xA8BE50", Offset = "0xA8AA50", VA = "0x180A8BE50")]
		public PassiveAttachmentAbility()
		{
		}

		// Token: 0x0601298B RID: 76171 RVA: 0x00071E38 File Offset: 0x00070038
		[Token(Token = "0x601298B")]
		[Address(RVA = "0xA4D200", Offset = "0xA4BE00", VA = "0x180A4D200")]
		private bool <>xLuaBaseProxy_get_isAffecting()
		{
			return default(bool);
		}

		// Token: 0x0601298C RID: 76172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601298C")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0601298D RID: 76173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601298D")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x0601298E RID: 76174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601298E")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x0601298F RID: 76175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601298F")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04015014 RID: 86036
		[Token(Token = "0x4015014")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Tooltip("These buffs would be added to the target ability as active buffs")]
		private BuffData[] _additiveActiveBuffs;

		// Token: 0x04015015 RID: 86037
		[Token(Token = "0x4015015")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Ability.FamilyGroupMask _targetFamilyMask;

		// Token: 0x04015016 RID: 86038
		[Token(Token = "0x4015016")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private TargetValidator _targetValidator;

		// Token: 0x04015017 RID: 86039
		[Token(Token = "0x4015017")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private string _probKey;

		// Token: 0x04015018 RID: 86040
		[Token(Token = "0x4015018")]
		[FieldOffset(Offset = "0x138")]
		private AbilityAttachment m_attachment;

		// Token: 0x04015019 RID: 86041
		[Token(Token = "0x4015019")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isAffecting;

		// Token: 0x0401501A RID: 86042
		[Token(Token = "0x401501A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0401501B RID: 86043
		[Token(Token = "0x401501B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0401501C RID: 86044
		[Token(Token = "0x401501C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x0401501D RID: 86045
		[Token(Token = "0x401501D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x0401501E RID: 86046
		[Token(Token = "0x401501E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
