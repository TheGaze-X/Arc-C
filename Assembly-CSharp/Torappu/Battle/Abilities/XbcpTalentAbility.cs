using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BC1 RID: 11201
	[Token(Token = "0x2002BC1")]
	[RequireComponent(typeof(Rigidbody2D))]
	public class XbcpTalentAbility : AuraAbility
	{
		// Token: 0x06012EB5 RID: 77493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EB5")]
		[Address(RVA = "0xAD91D0", Offset = "0xAD7DD0", VA = "0x180AD91D0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012EB6 RID: 77494 RVA: 0x00073F80 File Offset: 0x00072180
		[Token(Token = "0x6012EB6")]
		[Address(RVA = "0xAD9020", Offset = "0xAD7C20", VA = "0x180AD9020", Slot = "98")]
		protected override bool DealTargetTouched(Entity target, AuraAbility.TargetMeta meta)
		{
			return default(bool);
		}

		// Token: 0x06012EB7 RID: 77495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EB7")]
		[Address(RVA = "0xAD9420", Offset = "0xAD8020", VA = "0x180AD9420")]
		public XbcpTalentAbility()
		{
		}

		// Token: 0x06012EB8 RID: 77496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EB8")]
		[Address(RVA = "0xA7B950", Offset = "0xA7A550", VA = "0x180A7B950")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012EB9 RID: 77497 RVA: 0x00073F98 File Offset: 0x00072198
		[Token(Token = "0x6012EB9")]
		[Address(RVA = "0xA7B930", Offset = "0xA7A530", VA = "0x180A7B930")]
		private bool <>xLuaBaseProxy_DealTargetTouched(Entity P0, AuraAbility.TargetMeta P1)
		{
			return default(bool);
		}

		// Token: 0x04015583 RID: 87427
		[Token(Token = "0x4015583")]
		private const string CHECKPOINT_INDEX = "cp_id";

		// Token: 0x04015584 RID: 87428
		[Token(Token = "0x4015584")]
		private const string CHECKPOINT_COUNT = "cp_cnt";

		// Token: 0x04015585 RID: 87429
		[Token(Token = "0x4015585")]
		private const string ROUND_COUNT = "round_cnt";

		// Token: 0x04015586 RID: 87430
		[Token(Token = "0x4015586")]
		[FieldOffset(Offset = "0x180")]
		private int m_checkpointIndex;

		// Token: 0x04015587 RID: 87431
		[Token(Token = "0x4015587")]
		[FieldOffset(Offset = "0x184")]
		private int m_checkpointCount;

		// Token: 0x04015588 RID: 87432
		[Token(Token = "0x4015588")]
		[FieldOffset(Offset = "0x188")]
		private int m_finishRoundCount;

		// Token: 0x04015589 RID: 87433
		[Token(Token = "0x4015589")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0401558A RID: 87434
		[Token(Token = "0x401558A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DealTargetTouched;

		// Token: 0x0401558B RID: 87435
		[Token(Token = "0x401558B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
