using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B2C RID: 11052
	[Token(Token = "0x2002B2C")]
	public class RandomAuraAbility : AuraAbility
	{
		// Token: 0x06012861 RID: 75873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012861")]
		[Address(RVA = "0xA90720", Offset = "0xA8F320", VA = "0x180A90720", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012862 RID: 75874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012862")]
		[Address(RVA = "0xA90790", Offset = "0xA8F390", VA = "0x180A90790", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012863 RID: 75875 RVA: 0x000718C8 File Offset: 0x0006FAC8
		[Token(Token = "0x6012863")]
		[Address(RVA = "0xA90390", Offset = "0xA8EF90", VA = "0x180A90390", Slot = "98")]
		protected override bool DealTargetTouched(Entity target, AuraAbility.TargetMeta meta)
		{
			return default(bool);
		}

		// Token: 0x06012864 RID: 75876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012864")]
		[Address(RVA = "0xA908B0", Offset = "0xA8F4B0", VA = "0x180A908B0")]
		private void _DealWithPendingTask()
		{
		}

		// Token: 0x06012865 RID: 75877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012865")]
		[Address(RVA = "0xA90CF0", Offset = "0xA8F8F0", VA = "0x180A90CF0")]
		public RandomAuraAbility()
		{
		}

		// Token: 0x06012866 RID: 75878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012866")]
		[Address(RVA = "0xA225F0", Offset = "0xA211F0", VA = "0x180A225F0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012867 RID: 75879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012867")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012868 RID: 75880 RVA: 0x000718E0 File Offset: 0x0006FAE0
		[Token(Token = "0x6012868")]
		[Address(RVA = "0xA7B930", Offset = "0xA7A530", VA = "0x180A7B930")]
		private bool <>xLuaBaseProxy_DealTargetTouched(Entity P0, AuraAbility.TargetMeta P1)
		{
			return default(bool);
		}

		// Token: 0x04014EEC RID: 85740
		[Token(Token = "0x4014EEC")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private int _maxNum;

		// Token: 0x04014EED RID: 85741
		[Token(Token = "0x4014EED")]
		[FieldOffset(Offset = "0x184")]
		private int m_affectTargetNum;

		// Token: 0x04014EEE RID: 85742
		[Token(Token = "0x4014EEE")]
		[FieldOffset(Offset = "0x188")]
		private List<KeyValuePair<ObjectPtr<Entity>, AuraAbility.TargetMeta>> m_pendingTargets;

		// Token: 0x04014EEF RID: 85743
		[Token(Token = "0x4014EEF")]
		[FieldOffset(Offset = "0x190")]
		private bool m_waitForFirstBatch;

		// Token: 0x04014EF0 RID: 85744
		[Token(Token = "0x4014EF0")]
		[FieldOffset(Offset = "0x191")]
		private bool m_isDuringFirstBatch;

		// Token: 0x04014EF1 RID: 85745
		[Token(Token = "0x4014EF1")]
		[FieldOffset(Offset = "0x198")]
		private CoroutineId m_coroutine;

		// Token: 0x04014EF2 RID: 85746
		[Token(Token = "0x4014EF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x04014EF3 RID: 85747
		[Token(Token = "0x4014EF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04014EF4 RID: 85748
		[Token(Token = "0x4014EF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DealTargetTouched;

		// Token: 0x04014EF5 RID: 85749
		[Token(Token = "0x4014EF5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DealWithPendingTask;

		// Token: 0x04014EF6 RID: 85750
		[Token(Token = "0x4014EF6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
