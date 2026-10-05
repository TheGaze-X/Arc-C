using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B49 RID: 11081
	[Token(Token = "0x2002B49")]
	public class PassiveOneOfBuffAbility : PassiveBuffAbility
	{
		// Token: 0x060129A7 RID: 76199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129A7")]
		[Address(RVA = "0xAA26A0", Offset = "0xAA12A0", VA = "0x180AA26A0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060129A8 RID: 76200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60129A8")]
		[Address(RVA = "0xAA2780", Offset = "0xAA1380", VA = "0x180AA2780", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x060129A9 RID: 76201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129A9")]
		[Address(RVA = "0xAA2BC0", Offset = "0xAA17C0", VA = "0x180AA2BC0")]
		public PassiveOneOfBuffAbility()
		{
		}

		// Token: 0x060129AA RID: 76202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129AA")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060129AB RID: 76203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60129AB")]
		[Address(RVA = "0xAA2260", Offset = "0xAA0E60", VA = "0x180AA2260")]
		private IList<BuffData> <>xLuaBaseProxy_GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x0401502F RID: 86063
		[Token(Token = "0x401502F")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private PassiveOneOfBuffAbility.SelectMethod _selectMethod;

		// Token: 0x04015030 RID: 86064
		[Token(Token = "0x4015030")]
		[FieldOffset(Offset = "0x11C")]
		private int m_attachCnt;

		// Token: 0x04015031 RID: 86065
		[Token(Token = "0x4015031")]
		[FieldOffset(Offset = "0x120")]
		private string m_lastCastedBuffKey;

		// Token: 0x04015032 RID: 86066
		[Token(Token = "0x4015032")]
		[FieldOffset(Offset = "0x128")]
		private List<BuffData> m_buffGroupThisTime;

		// Token: 0x04015033 RID: 86067
		[Token(Token = "0x4015033")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04015034 RID: 86068
		[Token(Token = "0x4015034")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04015035 RID: 86069
		[Token(Token = "0x4015035")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B4A RID: 11082
		[Token(Token = "0x2002B4A")]
		public enum SelectMethod
		{
			// Token: 0x04015037 RID: 86071
			[Token(Token = "0x4015037")]
			RANDOM,
			// Token: 0x04015038 RID: 86072
			[Token(Token = "0x4015038")]
			INDEX_BY_SKILL_INDEX,
			// Token: 0x04015039 RID: 86073
			[Token(Token = "0x4015039")]
			SEQUENTIAL,
			// Token: 0x0401503A RID: 86074
			[Token(Token = "0x401503A")]
			RANDOM_BUT_NOT_LAST
		}
	}
}
