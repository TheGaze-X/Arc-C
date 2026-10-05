using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BB4 RID: 11188
	[Token(Token = "0x2002BB4")]
	public class StealAttributeAbility : EmptyAbility
	{
		// Token: 0x170029A7 RID: 10663
		// (get) Token: 0x06012E0E RID: 77326 RVA: 0x00073A70 File Offset: 0x00071C70
		[Token(Token = "0x170029A7")]
		public float stealedTotalValue
		{
			[Token(Token = "0x6012E0E")]
			[Address(RVA = "0xACEE00", Offset = "0xACDA00", VA = "0x180ACEE00")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170029A8 RID: 10664
		// (get) Token: 0x06012E0F RID: 77327 RVA: 0x00073A88 File Offset: 0x00071C88
		[Token(Token = "0x170029A8")]
		public float stealMaxValue
		{
			[Token(Token = "0x6012E0F")]
			[Address(RVA = "0xACEDA0", Offset = "0xACD9A0", VA = "0x180ACEDA0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170029A9 RID: 10665
		// (get) Token: 0x06012E10 RID: 77328 RVA: 0x00073AA0 File Offset: 0x00071CA0
		[Token(Token = "0x170029A9")]
		public AttributeType attributeType
		{
			[Token(Token = "0x6012E10")]
			[Address(RVA = "0xACEC00", Offset = "0xACD800", VA = "0x180ACEC00")]
			get
			{
				return AttributeType.MAX_HP;
			}
		}

		// Token: 0x170029AA RID: 10666
		// (get) Token: 0x06012E11 RID: 77329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170029AA")]
		private Buff ownerStealBuff
		{
			[Token(Token = "0x6012E11")]
			[Address(RVA = "0xACEC60", Offset = "0xACD860", VA = "0x180ACEC60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06012E12 RID: 77330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E12")]
		[Address(RVA = "0xACDD00", Offset = "0xACC900", VA = "0x180ACDD00", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012E13 RID: 77331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E13")]
		[Address(RVA = "0xACDAC0", Offset = "0xACC6C0", VA = "0x180ACDAC0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012E14 RID: 77332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E14")]
		[Address(RVA = "0xACE010", Offset = "0xACCC10", VA = "0x180ACE010", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012E15 RID: 77333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E15")]
		[Address(RVA = "0xACE3F0", Offset = "0xACCFF0", VA = "0x180ACE3F0")]
		private void _ResetParamKeys()
		{
		}

		// Token: 0x06012E16 RID: 77334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E16")]
		[Address(RVA = "0xACE630", Offset = "0xACD230", VA = "0x180ACE630")]
		private string _SetStealTargetBuffStr(string attr, StealAttributeAbility.AttrTargetType type)
		{
			return null;
		}

		// Token: 0x06012E17 RID: 77335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E17")]
		[Address(RVA = "0xACDD60", Offset = "0xACC960", VA = "0x180ACDD60", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012E18 RID: 77336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E18")]
		[Address(RVA = "0xACDE50", Offset = "0xACCA50", VA = "0x180ACDE50", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012E19 RID: 77337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E19")]
		[Address(RVA = "0xACE0A0", Offset = "0xACCCA0", VA = "0x180ACE0A0")]
		public void TriggerByTarget(Entity target, Buff targetBuff)
		{
		}

		// Token: 0x06012E1A RID: 77338 RVA: 0x00073AB8 File Offset: 0x00071CB8
		[Token(Token = "0x6012E1A")]
		[Address(RVA = "0xACD570", Offset = "0xACC170", VA = "0x180ACD570", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012E1B RID: 77339 RVA: 0x00073AD0 File Offset: 0x00071CD0
		[Token(Token = "0x6012E1B")]
		[Address(RVA = "0xACD470", Offset = "0xACC070", VA = "0x180ACD470", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012E1C RID: 77340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E1C")]
		[Address(RVA = "0xACDF90", Offset = "0xACCB90", VA = "0x180ACDF90", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012E1D RID: 77341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E1D")]
		[Address(RVA = "0xACE7A0", Offset = "0xACD3A0", VA = "0x180ACE7A0")]
		private void _VerifyCachedStatus()
		{
		}

		// Token: 0x06012E1E RID: 77342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E1E")]
		[Address(RVA = "0xACE2E0", Offset = "0xACCEE0", VA = "0x180ACE2E0")]
		private void _RefreshOwnerStatus()
		{
		}

		// Token: 0x06012E1F RID: 77343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E1F")]
		[Address(RVA = "0xACEA20", Offset = "0xACD620", VA = "0x180ACEA20")]
		public StealAttributeAbility()
		{
		}

		// Token: 0x06012E20 RID: 77344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E20")]
		[Address(RVA = "0xABEEC0", Offset = "0xABDAC0", VA = "0x180ABEEC0")]
		private IList<BuffData> <>xLuaBaseProxy_GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012E21 RID: 77345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E21")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012E22 RID: 77346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E22")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012E23 RID: 77347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E23")]
		[Address(RVA = "0xA225F0", Offset = "0xA211F0", VA = "0x180A225F0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012E24 RID: 77348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E24")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012E25 RID: 77349 RVA: 0x00073AE8 File Offset: 0x00071CE8
		[Token(Token = "0x6012E25")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x06012E26 RID: 77350 RVA: 0x00073B00 File Offset: 0x00071D00
		[Token(Token = "0x6012E26")]
		[Address(RVA = "0xA225E0", Offset = "0xA211E0", VA = "0x180A225E0")]
		private bool <>xLuaBaseProxy_CastDirectly(Ability.FinishCallbackDelegate P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x06012E27 RID: 77351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E27")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040154D6 RID: 87254
		[Token(Token = "0x40154D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private AttributeType _attributeType;

		// Token: 0x040154D7 RID: 87255
		[Token(Token = "0x40154D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[SerializeField]
		private AttributeModifierData.AttributeModifier.FormulaItemType _formulaType;

		// Token: 0x040154D8 RID: 87256
		[Token(Token = "0x40154D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private string _stealOnceBBKey;

		// Token: 0x040154D9 RID: 87257
		[Token(Token = "0x40154D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private string _stealMaxBBKey;

		// Token: 0x040154DA RID: 87258
		[Token(Token = "0x40154DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private bool _finishTargetBuffWhenInvalid;

		// Token: 0x040154DB RID: 87259
		[Token(Token = "0x40154DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		[SerializeField]
		private bool _finishOwnerBuffWhenTargetInvalid;

		// Token: 0x040154DC RID: 87260
		[Token(Token = "0x40154DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected BuffData[] _passiveBuffs;

		// Token: 0x040154DD RID: 87261
		[Token(Token = "0x40154DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float m_stealOnceValue;

		// Token: 0x040154DE RID: 87262
		[Token(Token = "0x40154DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private float m_stealMaxValue;

		// Token: 0x040154DF RID: 87263
		[Token(Token = "0x40154DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private float m_stealedTotalValue;

		// Token: 0x040154E0 RID: 87264
		[Token(Token = "0x40154E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private string m_stealTargetBuffKey;

		// Token: 0x040154E1 RID: 87265
		[Token(Token = "0x40154E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private string m_stealSelfBuffKey;

		// Token: 0x040154E2 RID: 87266
		[Token(Token = "0x40154E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private string m_stealTargetBBKey;

		// Token: 0x040154E3 RID: 87267
		[Token(Token = "0x40154E3")]
		private const string STEAL_ONCE_BB_KEY = "steal";

		// Token: 0x040154E4 RID: 87268
		[Token(Token = "0x40154E4")]
		private const string STEAL_MAX_BB_KEY = "steal_max";

		// Token: 0x040154E5 RID: 87269
		[Token(Token = "0x40154E5")]
		private const string STEAL_ATTR_TARGET = "steal_attr_target";

		// Token: 0x040154E6 RID: 87270
		[Token(Token = "0x40154E6")]
		private const string STEAL_ATTR_SELF = "steal_attr_self";

		// Token: 0x040154E7 RID: 87271
		[Token(Token = "0x40154E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Dictionary<uint, StealAttributeAbility.StealAttributeBuff> m_stealStatus;

		// Token: 0x040154E8 RID: 87272
		[Token(Token = "0x40154E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private List<KeyValuePair<ObjectPtr<Entity>, Buff>> m_stealCacheStatus;

		// Token: 0x040154E9 RID: 87273
		[Token(Token = "0x40154E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private ObjectPtr<Buff> m_ownerStealBuff;

		// Token: 0x040154EA RID: 87274
		[Token(Token = "0x40154EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stealedTotalValue;

		// Token: 0x040154EB RID: 87275
		[Token(Token = "0x40154EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_stealMaxValue;

		// Token: 0x040154EC RID: 87276
		[Token(Token = "0x40154EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_attributeType;

		// Token: 0x040154ED RID: 87277
		[Token(Token = "0x40154ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_ownerStealBuff;

		// Token: 0x040154EE RID: 87278
		[Token(Token = "0x40154EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x040154EF RID: 87279
		[Token(Token = "0x40154EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040154F0 RID: 87280
		[Token(Token = "0x40154F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040154F1 RID: 87281
		[Token(Token = "0x40154F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ResetParamKeys;

		// Token: 0x040154F2 RID: 87282
		[Token(Token = "0x40154F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetStealTargetBuffStr;

		// Token: 0x040154F3 RID: 87283
		[Token(Token = "0x40154F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x040154F4 RID: 87284
		[Token(Token = "0x40154F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x040154F5 RID: 87285
		[Token(Token = "0x40154F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TriggerByTarget;

		// Token: 0x040154F6 RID: 87286
		[Token(Token = "0x40154F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x040154F7 RID: 87287
		[Token(Token = "0x40154F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x040154F8 RID: 87288
		[Token(Token = "0x40154F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040154F9 RID: 87289
		[Token(Token = "0x40154F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__VerifyCachedStatus;

		// Token: 0x040154FA RID: 87290
		[Token(Token = "0x40154FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RefreshOwnerStatus;

		// Token: 0x040154FB RID: 87291
		[Token(Token = "0x40154FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BB5 RID: 11189
		[Token(Token = "0x2002BB5")]
		private enum AttrTargetType
		{
			// Token: 0x040154FD RID: 87293
			[Token(Token = "0x40154FD")]
			TARGET,
			// Token: 0x040154FE RID: 87294
			[Token(Token = "0x40154FE")]
			SELF
		}

		// Token: 0x02002BB6 RID: 11190
		[Token(Token = "0x2002BB6")]
		private struct StealAttributeBuff
		{
			// Token: 0x040154FF RID: 87295
			[Token(Token = "0x40154FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ObjectPtr<Buff> buff;

			// Token: 0x04015500 RID: 87296
			[Token(Token = "0x4015500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float value;
		}
	}
}
