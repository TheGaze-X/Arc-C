using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BA3 RID: 11171
	[Token(Token = "0x2002BA3")]
	public class LegionModeBuffAbility : LegionModeAbility
	{
		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x06012D54 RID: 77140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002994")]
		private List<LegionModeAbility.BuffPair> passiveBuffPairs
		{
			[Token(Token = "0x6012D54")]
			[Address(RVA = "0xABF620", Offset = "0xABE220", VA = "0x180ABF620")]
			get
			{
				return null;
			}
		}

		// Token: 0x06012D55 RID: 77141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D55")]
		[Address(RVA = "0xABE660", Offset = "0xABD260", VA = "0x180ABE660", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012D56 RID: 77142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D56")]
		[Address(RVA = "0xABE7B0", Offset = "0xABD3B0", VA = "0x180ABE7B0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012D57 RID: 77143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D57")]
		[Address(RVA = "0xABF400", Offset = "0xABE000", VA = "0x180ABF400")]
		private void _OnRallyPointReborn(object arg)
		{
		}

		// Token: 0x06012D58 RID: 77144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D58")]
		[Address(RVA = "0xABEEE0", Offset = "0xABDAE0", VA = "0x180ABEEE0", Slot = "96")]
		protected override void UpdateBlackboard()
		{
		}

		// Token: 0x06012D59 RID: 77145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D59")]
		[Address(RVA = "0xABEB30", Offset = "0xABD730", VA = "0x180ABEB30", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012D5A RID: 77146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D5A")]
		[Address(RVA = "0xABE8C0", Offset = "0xABD4C0", VA = "0x180ABE8C0", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012D5B RID: 77147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D5B")]
		[Address(RVA = "0xABF540", Offset = "0xABE140", VA = "0x180ABF540")]
		public LegionModeBuffAbility()
		{
		}

		// Token: 0x06012D5C RID: 77148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D5C")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012D5D RID: 77149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D5D")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x06012D5E RID: 77150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D5E")]
		[Address(RVA = "0xABEED0", Offset = "0xABDAD0", VA = "0x180ABEED0")]
		private void <>xLuaBaseProxy_UpdateBlackboard()
		{
		}

		// Token: 0x06012D5F RID: 77151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D5F")]
		[Address(RVA = "0xABEEC0", Offset = "0xABDAC0", VA = "0x180ABEEC0")]
		private IList<BuffData> <>xLuaBaseProxy_GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012D60 RID: 77152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D60")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0401540D RID: 87053
		[Token(Token = "0x401540D")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private List<LegionModeAbility.BuffPair> _passiveBuffPairs;

		// Token: 0x0401540E RID: 87054
		[Token(Token = "0x401540E")]
		[FieldOffset(Offset = "0x140")]
		private List<LegionModeAbility.BuffPair> m_usedPassiveBuffPairs;

		// Token: 0x0401540F RID: 87055
		[Token(Token = "0x401540F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_passiveBuffPairs;

		// Token: 0x04015410 RID: 87056
		[Token(Token = "0x4015410")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04015411 RID: 87057
		[Token(Token = "0x4015411")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04015412 RID: 87058
		[Token(Token = "0x4015412")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnRallyPointReborn;

		// Token: 0x04015413 RID: 87059
		[Token(Token = "0x4015413")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateBlackboard;

		// Token: 0x04015414 RID: 87060
		[Token(Token = "0x4015414")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04015415 RID: 87061
		[Token(Token = "0x4015415")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04015416 RID: 87062
		[Token(Token = "0x4015416")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
