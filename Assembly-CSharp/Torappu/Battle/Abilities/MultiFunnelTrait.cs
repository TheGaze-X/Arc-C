using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BA8 RID: 11176
	[Token(Token = "0x2002BA8")]
	public class MultiFunnelTrait : PassiveBuffAbility
	{
		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x06012D8F RID: 77199 RVA: 0x00073680 File Offset: 0x00071880
		[Token(Token = "0x17002996")]
		private float maxAtkScale
		{
			[Token(Token = "0x6012D8F")]
			[Address(RVA = "0xAC7AE0", Offset = "0xAC66E0", VA = "0x180AC7AE0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06012D90 RID: 77200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D90")]
		[Address(RVA = "0xAC6190", Offset = "0xAC4D90", VA = "0x180AC6190", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012D91 RID: 77201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D91")]
		[Address(RVA = "0xAC6E90", Offset = "0xAC5A90", VA = "0x180AC6E90")]
		public void SetFunnelActive(Ability atkAbility)
		{
		}

		// Token: 0x06012D92 RID: 77202 RVA: 0x00073698 File Offset: 0x00071898
		[Token(Token = "0x6012D92")]
		[Address(RVA = "0xAC63F0", Offset = "0xAC4FF0", VA = "0x180AC63F0")]
		public bool IsFunnelActive(Ability ability, bool ignoreRestoring = false)
		{
			return default(bool);
		}

		// Token: 0x06012D93 RID: 77203 RVA: 0x000736B0 File Offset: 0x000718B0
		[Token(Token = "0x6012D93")]
		[Address(RVA = "0xAC7520", Offset = "0xAC6120", VA = "0x180AC7520")]
		public float SetNormalAtkScale(Entity target, Ability ability)
		{
			return 0f;
		}

		// Token: 0x06012D94 RID: 77204 RVA: 0x000736C8 File Offset: 0x000718C8
		[Token(Token = "0x6012D94")]
		[Address(RVA = "0xAC6F40", Offset = "0xAC5B40", VA = "0x180AC6F40")]
		public float SetFunnelAtkScale(Entity target, Projectile projectile)
		{
			return 0f;
		}

		// Token: 0x06012D95 RID: 77205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D95")]
		[Address(RVA = "0xAC68E0", Offset = "0xAC54E0", VA = "0x180AC68E0")]
		public void OnProjectileStop(Projectile projectile)
		{
		}

		// Token: 0x06012D96 RID: 77206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D96")]
		[Address(RVA = "0xAC6AD0", Offset = "0xAC56D0", VA = "0x180AC6AD0")]
		public void OnProjectileStop(Projectile projectile, float delayToRestore)
		{
		}

		// Token: 0x06012D97 RID: 77207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D97")]
		[Address(RVA = "0xAC77B0", Offset = "0xAC63B0", VA = "0x180AC77B0")]
		public void UpdateMaxAtkScaleMultiplier(float finalScale = 1f)
		{
		}

		// Token: 0x06012D98 RID: 77208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D98")]
		[Address(RVA = "0xAC6080", Offset = "0xAC4C80", VA = "0x180AC6080")]
		private IEnumerator DelayToRestore(Ability ability, float delayToRestore)
		{
			return null;
		}

		// Token: 0x06012D99 RID: 77209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D99")]
		[Address(RVA = "0xAC6D50", Offset = "0xAC5950", VA = "0x180AC6D50", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012D9A RID: 77210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D9A")]
		[Address(RVA = "0xAC7980", Offset = "0xAC6580", VA = "0x180AC7980")]
		public MultiFunnelTrait()
		{
		}

		// Token: 0x06012D9C RID: 77212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D9C")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012D9D RID: 77213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D9D")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x04015443 RID: 87107
		[Token(Token = "0x4015443")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float _initAtkScale;

		// Token: 0x04015444 RID: 87108
		[Token(Token = "0x4015444")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private float _deltaAtkScale;

		// Token: 0x04015445 RID: 87109
		[Token(Token = "0x4015445")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float _maxAtkScale;

		// Token: 0x04015446 RID: 87110
		[Token(Token = "0x4015446")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private int _maxStackCnt;

		// Token: 0x04015447 RID: 87111
		[Token(Token = "0x4015447")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private bool _normalAttackMultiFunnelsButSingleAbility;

		// Token: 0x04015448 RID: 87112
		[Token(Token = "0x4015448")]
		[FieldOffset(Offset = "0x12C")]
		private float m_initAtkScale;

		// Token: 0x04015449 RID: 87113
		[Token(Token = "0x4015449")]
		[FieldOffset(Offset = "0x130")]
		private float m_deltaAtkScale;

		// Token: 0x0401544A RID: 87114
		[Token(Token = "0x401544A")]
		[FieldOffset(Offset = "0x134")]
		private float m_maxAtkScale;

		// Token: 0x0401544B RID: 87115
		[Token(Token = "0x401544B")]
		[FieldOffset(Offset = "0x138")]
		private int m_maxStackCnt;

		// Token: 0x0401544C RID: 87116
		[Token(Token = "0x401544C")]
		[FieldOffset(Offset = "0x13C")]
		private float m_maxAtkScaleMultiplier;

		// Token: 0x0401544D RID: 87117
		[Token(Token = "0x401544D")]
		[FieldOffset(Offset = "0x140")]
		private Ability m_mainFunnel;

		// Token: 0x0401544E RID: 87118
		[Token(Token = "0x401544E")]
		[FieldOffset(Offset = "0x148")]
		private MultiFunnelTrait.AttackData m_mainFunnelData;

		// Token: 0x0401544F RID: 87119
		[Token(Token = "0x401544F")]
		[FieldOffset(Offset = "0x168")]
		private Ability m_normalFirstFunnel;

		// Token: 0x04015450 RID: 87120
		[Token(Token = "0x4015450")]
		[FieldOffset(Offset = "0x170")]
		private Ability m_modeFirstFunnel;

		// Token: 0x04015451 RID: 87121
		[Token(Token = "0x4015451")]
		[FieldOffset(Offset = "0x178")]
		private readonly HashSet<Ability> m_activeFunnels;

		// Token: 0x04015452 RID: 87122
		[Token(Token = "0x4015452")]
		[FieldOffset(Offset = "0x180")]
		private readonly HashSet<Ability> m_toRemoveFromActiveFunnels;

		// Token: 0x04015453 RID: 87123
		[Token(Token = "0x4015453")]
		[FieldOffset(Offset = "0x188")]
		private readonly Dictionary<Ability, MultiFunnelTrait.AttackData> m_funnels;

		// Token: 0x04015454 RID: 87124
		[Token(Token = "0x4015454")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<Ability> s_activeFunnelsToRemove;

		// Token: 0x04015455 RID: 87125
		[Token(Token = "0x4015455")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_maxAtkScale;

		// Token: 0x04015456 RID: 87126
		[Token(Token = "0x4015456")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04015457 RID: 87127
		[Token(Token = "0x4015457")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetFunnelActive;

		// Token: 0x04015458 RID: 87128
		[Token(Token = "0x4015458")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsFunnelActive;

		// Token: 0x04015459 RID: 87129
		[Token(Token = "0x4015459")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetNormalAtkScale;

		// Token: 0x0401545A RID: 87130
		[Token(Token = "0x401545A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetFunnelAtkScale;

		// Token: 0x0401545B RID: 87131
		[Token(Token = "0x401545B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x0401545C RID: 87132
		[Token(Token = "0x401545C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1_OnProjectileStop;

		// Token: 0x0401545D RID: 87133
		[Token(Token = "0x401545D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateMaxAtkScaleMultiplier;

		// Token: 0x0401545E RID: 87134
		[Token(Token = "0x401545E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DelayToRestore;

		// Token: 0x0401545F RID: 87135
		[Token(Token = "0x401545F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04015460 RID: 87136
		[Token(Token = "0x4015460")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BA9 RID: 11177
		[Token(Token = "0x2002BA9")]
		private struct AttackData
		{
			// Token: 0x04015461 RID: 87137
			[Token(Token = "0x4015461")]
			[FieldOffset(Offset = "0x0")]
			public int curStackCnt;

			// Token: 0x04015462 RID: 87138
			[Token(Token = "0x4015462")]
			[FieldOffset(Offset = "0x8")]
			public ObjectPtr<Entity> lastTarget;

			// Token: 0x04015463 RID: 87139
			[Token(Token = "0x4015463")]
			[FieldOffset(Offset = "0x18")]
			public float curAtkScale;
		}
	}
}
