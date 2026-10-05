using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B87 RID: 11143
	[Token(Token = "0x2002B87")]
	public class BoomberangTrait : PassiveBuffAbility
	{
		// Token: 0x1700294F RID: 10575
		// (get) Token: 0x06012BDF RID: 76767 RVA: 0x00072CF0 File Offset: 0x00070EF0
		// (set) Token: 0x06012BDE RID: 76766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700294F")]
		public int maxProjectileCnt
		{
			[Token(Token = "0x6012BDF")]
			[Address(RVA = "0xAB0D10", Offset = "0xAAF910", VA = "0x180AB0D10")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6012BDE")]
			[Address(RVA = "0xAB0D70", Offset = "0xAAF970", VA = "0x180AB0D70")]
			set
			{
			}
		}

		// Token: 0x17002950 RID: 10576
		// (get) Token: 0x06012BE0 RID: 76768 RVA: 0x00072D08 File Offset: 0x00070F08
		[Token(Token = "0x17002950")]
		public bool hasValidProjectile
		{
			[Token(Token = "0x6012BE0")]
			[Address(RVA = "0xAB0CB0", Offset = "0xAAF8B0", VA = "0x180AB0CB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012BE1 RID: 76769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BE1")]
		[Address(RVA = "0xAB0150", Offset = "0xAAED50", VA = "0x180AB0150", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012BE2 RID: 76770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BE2")]
		[Address(RVA = "0xAAFE50", Offset = "0xAAEA50", VA = "0x180AAFE50", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012BE3 RID: 76771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BE3")]
		[Address(RVA = "0xAAFFD0", Offset = "0xAAEBD0", VA = "0x180AAFFD0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012BE4 RID: 76772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BE4")]
		[Address(RVA = "0xAB0370", Offset = "0xAAEF70", VA = "0x180AB0370", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012BE5 RID: 76773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BE5")]
		[Address(RVA = "0xAB0440", Offset = "0xAAF040", VA = "0x180AB0440")]
		public void OnAttackCastStart()
		{
		}

		// Token: 0x06012BE6 RID: 76774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BE6")]
		[Address(RVA = "0xAB05A0", Offset = "0xAAF1A0", VA = "0x180AB05A0")]
		public void OnCreateProjectile(object args)
		{
		}

		// Token: 0x06012BE7 RID: 76775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BE7")]
		[Address(RVA = "0xAB0790", Offset = "0xAAF390", VA = "0x180AB0790")]
		public void OnProjectileReached(object args)
		{
		}

		// Token: 0x06012BE8 RID: 76776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BE8")]
		[Address(RVA = "0xAB0920", Offset = "0xAAF520", VA = "0x180AB0920")]
		private void _OnProjectileComeBack(Projectile projectile)
		{
		}

		// Token: 0x06012BE9 RID: 76777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BE9")]
		[Address(RVA = "0xAB08C0", Offset = "0xAAF4C0", VA = "0x180AB08C0")]
		public void ResetMaxProjectileCnt()
		{
		}

		// Token: 0x06012BEA RID: 76778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BEA")]
		[Address(RVA = "0xAB0BB0", Offset = "0xAAF7B0", VA = "0x180AB0BB0")]
		public BoomberangTrait()
		{
		}

		// Token: 0x06012BEB RID: 76779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BEB")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012BEC RID: 76780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BEC")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012BED RID: 76781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BED")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x06012BEE RID: 76782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BEE")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x040152D1 RID: 86737
		[Token(Token = "0x40152D1")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		public string _skinKey;

		// Token: 0x040152D2 RID: 86738
		[Token(Token = "0x40152D2")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private BuffData[] _activeBuffsWhenProjectileComeback;

		// Token: 0x040152D3 RID: 86739
		[Token(Token = "0x40152D3")]
		[FieldOffset(Offset = "0x128")]
		private int m_maxProjectileCnt;

		// Token: 0x040152D4 RID: 86740
		[Token(Token = "0x40152D4")]
		[FieldOffset(Offset = "0x12C")]
		private int m_defaultMaxProjectileCnt;

		// Token: 0x040152D5 RID: 86741
		[Token(Token = "0x40152D5")]
		[FieldOffset(Offset = "0x130")]
		private int m_currentProjectileCnt;

		// Token: 0x040152D6 RID: 86742
		[Token(Token = "0x40152D6")]
		[FieldOffset(Offset = "0x134")]
		private int m_emitedProjectileCnt;

		// Token: 0x040152D7 RID: 86743
		[Token(Token = "0x40152D7")]
		[FieldOffset(Offset = "0x138")]
		private int m_cacheMaxProjectileCnt;

		// Token: 0x040152D8 RID: 86744
		[Token(Token = "0x40152D8")]
		private const string DEFAULT_SKIN_KEY = "Default";

		// Token: 0x040152D9 RID: 86745
		[Token(Token = "0x40152D9")]
		[FieldOffset(Offset = "0x140")]
		private HashSet<Projectile> m_cacheProjectiles;

		// Token: 0x040152DA RID: 86746
		[Token(Token = "0x40152DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_maxProjectileCnt;

		// Token: 0x040152DB RID: 86747
		[Token(Token = "0x40152DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_maxProjectileCnt;

		// Token: 0x040152DC RID: 86748
		[Token(Token = "0x40152DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasValidProjectile;

		// Token: 0x040152DD RID: 86749
		[Token(Token = "0x40152DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040152DE RID: 86750
		[Token(Token = "0x40152DE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x040152DF RID: 86751
		[Token(Token = "0x40152DF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x040152E0 RID: 86752
		[Token(Token = "0x40152E0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x040152E1 RID: 86753
		[Token(Token = "0x40152E1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnAttackCastStart;

		// Token: 0x040152E2 RID: 86754
		[Token(Token = "0x40152E2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCreateProjectile;

		// Token: 0x040152E3 RID: 86755
		[Token(Token = "0x40152E3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x040152E4 RID: 86756
		[Token(Token = "0x40152E4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnProjectileComeBack;

		// Token: 0x040152E5 RID: 86757
		[Token(Token = "0x40152E5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ResetMaxProjectileCnt;

		// Token: 0x040152E6 RID: 86758
		[Token(Token = "0x40152E6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
