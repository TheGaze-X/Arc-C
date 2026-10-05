using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AD4 RID: 10964
	[Token(Token = "0x2002AD4")]
	public class ContinuouslyRangedHeal : RangedHeal
	{
		// Token: 0x06012454 RID: 74836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012454")]
		[Address(RVA = "0xA53EB0", Offset = "0xA52AB0", VA = "0x180A53EB0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012455 RID: 74837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012455")]
		[Address(RVA = "0xA54580", Offset = "0xA53180", VA = "0x180A54580")]
		private void _UpdateLastTarget(Entity target)
		{
		}

		// Token: 0x06012456 RID: 74838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012456")]
		[Address(RVA = "0xA54140", Offset = "0xA52D40", VA = "0x180A54140", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x06012457 RID: 74839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012457")]
		[Address(RVA = "0xA540A0", Offset = "0xA52CA0", VA = "0x180A540A0", Slot = "110")]
		protected override string GetProjectileKey()
		{
			return null;
		}

		// Token: 0x06012458 RID: 74840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012458")]
		[Address(RVA = "0xA53FE0", Offset = "0xA52BE0", VA = "0x180A53FE0", Slot = "47")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x06012459 RID: 74841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012459")]
		[Address(RVA = "0xA54440", Offset = "0xA53040", VA = "0x180A54440", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x0601245A RID: 74842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601245A")]
		[Address(RVA = "0xA546A0", Offset = "0xA532A0", VA = "0x180A546A0")]
		public ContinuouslyRangedHeal()
		{
		}

		// Token: 0x0601245B RID: 74843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601245B")]
		[Address(RVA = "0xA544E0", Offset = "0xA530E0", VA = "0x180A544E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x0601245C RID: 74844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601245C")]
		[Address(RVA = "0xA1E530", Offset = "0xA1D130", VA = "0x180A1E530")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x0601245D RID: 74845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601245D")]
		[Address(RVA = "0xA54520", Offset = "0xA53120", VA = "0x180A54520")]
		private string <>xLuaBaseProxy_GetProjectileKey()
		{
			return null;
		}

		// Token: 0x0601245E RID: 74846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601245E")]
		[Address(RVA = "0xA54510", Offset = "0xA53110", VA = "0x180A54510")]
		private void <>xLuaBaseProxy_GatherProjectiles(List<string> P0)
		{
		}

		// Token: 0x0601245F RID: 74847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601245F")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x04014A8E RID: 84622
		[Token(Token = "0x4014A8E")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		private float _continuousHealScale;

		// Token: 0x04014A8F RID: 84623
		[Token(Token = "0x4014A8F")]
		[FieldOffset(Offset = "0x20C")]
		[SerializeField]
		private bool _applyScaleForEPHeal;

		// Token: 0x04014A90 RID: 84624
		[Token(Token = "0x4014A90")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		private string _secondProjectileKey;

		// Token: 0x04014A91 RID: 84625
		[Token(Token = "0x4014A91")]
		[FieldOffset(Offset = "0x218")]
		private bool m_isLastTarget;

		// Token: 0x04014A92 RID: 84626
		[Token(Token = "0x4014A92")]
		[FieldOffset(Offset = "0x21C")]
		private float m_continuousHealScale;

		// Token: 0x04014A93 RID: 84627
		[Token(Token = "0x4014A93")]
		[FieldOffset(Offset = "0x220")]
		private ObjectPtr<Entity> m_lastTarget;

		// Token: 0x04014A94 RID: 84628
		[Token(Token = "0x4014A94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014A95 RID: 84629
		[Token(Token = "0x4014A95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateLastTarget;

		// Token: 0x04014A96 RID: 84630
		[Token(Token = "0x4014A96")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04014A97 RID: 84631
		[Token(Token = "0x4014A97")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetProjectileKey;

		// Token: 0x04014A98 RID: 84632
		[Token(Token = "0x4014A98")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x04014A99 RID: 84633
		[Token(Token = "0x4014A99")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014A9A RID: 84634
		[Token(Token = "0x4014A9A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
