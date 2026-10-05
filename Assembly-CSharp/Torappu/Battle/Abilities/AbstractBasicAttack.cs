using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002A9A RID: 10906
	[Token(Token = "0x2002A9A")]
	public abstract class AbstractBasicAttack : AbstractAnimatedAbility
	{
		// Token: 0x170027BD RID: 10173
		// (get) Token: 0x060121A8 RID: 74152 RVA: 0x0006EDA8 File Offset: 0x0006CFA8
		[Token(Token = "0x170027BD")]
		public bool hasEpDamage
		{
			[Token(Token = "0x60121A8")]
			[Address(RVA = "0xA1E830", Offset = "0xA1D430", VA = "0x180A1E830")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027BE RID: 10174
		// (get) Token: 0x060121A9 RID: 74153 RVA: 0x0006EDC0 File Offset: 0x0006CFC0
		[Token(Token = "0x170027BE")]
		public FP atkScale
		{
			[Token(Token = "0x60121A9")]
			[Address(RVA = "0xA1E6A0", Offset = "0xA1D2A0", VA = "0x180A1E6A0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170027BF RID: 10175
		// (get) Token: 0x060121AA RID: 74154 RVA: 0x0006EDD8 File Offset: 0x0006CFD8
		[Token(Token = "0x170027BF")]
		public FP damageNodeAtkScale
		{
			[Token(Token = "0x60121AA")]
			[Address(RVA = "0xA1E760", Offset = "0xA1D360", VA = "0x180A1E760")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170027C0 RID: 10176
		// (get) Token: 0x060121AB RID: 74155 RVA: 0x0006EDF0 File Offset: 0x0006CFF0
		[Token(Token = "0x170027C0")]
		public ElementType elementDamageType
		{
			[Token(Token = "0x60121AB")]
			[Address(RVA = "0xA1E7D0", Offset = "0xA1D3D0", VA = "0x180A1E7D0")]
			get
			{
				return ElementType.NONE;
			}
		}

		// Token: 0x170027C1 RID: 10177
		// (get) Token: 0x060121AC RID: 74156 RVA: 0x0006EE08 File Offset: 0x0006D008
		[Token(Token = "0x170027C1")]
		protected override Modifier.SourceAttackType attackType
		{
			[Token(Token = "0x60121AC")]
			[Address(RVA = "0xA1E700", Offset = "0xA1D300", VA = "0x180A1E700", Slot = "99")]
			get
			{
				return Modifier.SourceAttackType.NONE;
			}
		}

		// Token: 0x170027C2 RID: 10178
		// (get) Token: 0x060121AD RID: 74157 RVA: 0x0006EE20 File Offset: 0x0006D020
		[Token(Token = "0x170027C2")]
		protected override bool useDynamicAttackType
		{
			[Token(Token = "0x60121AD")]
			[Address(RVA = "0xA1E890", Offset = "0xA1D490", VA = "0x180A1E890", Slot = "100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027C3 RID: 10179
		// (get) Token: 0x060121AE RID: 74158
		[Token(Token = "0x170027C3")]
		protected abstract DamageType damageType { [Token(Token = "0x60121AE")] get; }

		// Token: 0x170027C4 RID: 10180
		// (get) Token: 0x060121AF RID: 74159
		[Token(Token = "0x170027C4")]
		protected abstract DamageType extraDamageType { [Token(Token = "0x60121AF")] get; }

		// Token: 0x060121B0 RID: 74160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121B0")]
		[Address(RVA = "0xA1D600", Offset = "0xA1C200", VA = "0x180A1D600")]
		public void ApplyAtkScale(FP atkScale, bool overwrite = false, bool createNewNode = false)
		{
		}

		// Token: 0x060121B1 RID: 74161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121B1")]
		[Address(RVA = "0xA1E410", Offset = "0xA1D010", VA = "0x180A1E410")]
		public void ReplaceDamageNode(DamageType damageType)
		{
		}

		// Token: 0x060121B2 RID: 74162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121B2")]
		[Address(RVA = "0xA1D750", Offset = "0xA1C350", VA = "0x180A1D750")]
		public void ApplyElementDamageScale(FP epDamageScale, bool createNewNode = false)
		{
		}

		// Token: 0x060121B3 RID: 74163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121B3")]
		[Address(RVA = "0xA1D940", Offset = "0xA1C540", VA = "0x180A1D940")]
		public void CreateAndReplaceDamageNode(float atkScale, IList<ActionNode> actionNodes)
		{
		}

		// Token: 0x060121B4 RID: 74164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121B4")]
		[Address(RVA = "0xA1DC90", Offset = "0xA1C890", VA = "0x180A1DC90", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060121B5 RID: 74165 RVA: 0x0006EE38 File Offset: 0x0006D038
		[Token(Token = "0x60121B5")]
		[Address(RVA = "0xA1D8E0", Offset = "0xA1C4E0", VA = "0x180A1D8E0", Slot = "89")]
		protected override bool CheckIsDamageOrHealSource()
		{
			return default(bool);
		}

		// Token: 0x060121B6 RID: 74166 RVA: 0x0006EE50 File Offset: 0x0006D050
		[Token(Token = "0x60121B6")]
		[Address(RVA = "0xA1E120", Offset = "0xA1CD20", VA = "0x180A1E120", Slot = "90")]
		protected override ActionPurposeMask GeneratePurposeMask()
		{
			return ActionPurposeMask.NONE;
		}

		// Token: 0x060121B7 RID: 74167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121B7")]
		[Address(RVA = "0xA1E200", Offset = "0xA1CE00", VA = "0x180A1E200", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x060121B8 RID: 74168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121B8")]
		[Address(RVA = "0xA1E180", Offset = "0xA1CD80", VA = "0x180A1E180", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x060121B9 RID: 74169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121B9")]
		[Address(RVA = "0xA1E560", Offset = "0xA1D160", VA = "0x180A1E560")]
		protected AbstractBasicAttack()
		{
		}

		// Token: 0x060121BA RID: 74170 RVA: 0x0006EE68 File Offset: 0x0006D068
		[Token(Token = "0x60121BA")]
		[Address(RVA = "0xA1E540", Offset = "0xA1D140", VA = "0x180A1E540")]
		private Modifier.SourceAttackType <>xLuaBaseProxy_get_attackType()
		{
			return Modifier.SourceAttackType.NONE;
		}

		// Token: 0x060121BB RID: 74171 RVA: 0x0006EE80 File Offset: 0x0006D080
		[Token(Token = "0x60121BB")]
		[Address(RVA = "0xA1E550", Offset = "0xA1D150", VA = "0x180A1E550")]
		private bool <>xLuaBaseProxy_get_useDynamicAttackType()
		{
			return default(bool);
		}

		// Token: 0x060121BC RID: 74172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121BC")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060121BD RID: 74173 RVA: 0x0006EE98 File Offset: 0x0006D098
		[Token(Token = "0x60121BD")]
		[Address(RVA = "0xA1E4D0", Offset = "0xA1D0D0", VA = "0x180A1E4D0")]
		private bool <>xLuaBaseProxy_CheckIsDamageOrHealSource()
		{
			return default(bool);
		}

		// Token: 0x060121BE RID: 74174 RVA: 0x0006EEB0 File Offset: 0x0006D0B0
		[Token(Token = "0x60121BE")]
		[Address(RVA = "0xA1E510", Offset = "0xA1D110", VA = "0x180A1E510")]
		private ActionPurposeMask <>xLuaBaseProxy_GeneratePurposeMask()
		{
			return ActionPurposeMask.NONE;
		}

		// Token: 0x060121BF RID: 74175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121BF")]
		[Address(RVA = "0xA1E530", Offset = "0xA1D130", VA = "0x180A1E530")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x060121C0 RID: 74176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121C0")]
		[Address(RVA = "0xA1E520", Offset = "0xA1D120", VA = "0x180A1E520")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x040147CD RID: 83917
		[Token(Token = "0x40147CD")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private float _atkScale;

		// Token: 0x040147CE RID: 83918
		[Token(Token = "0x40147CE")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private string _atkScaleKey;

		// Token: 0x040147CF RID: 83919
		[Token(Token = "0x40147CF")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private Modifier.SourceAttackType _attackType;

		// Token: 0x040147D0 RID: 83920
		[Token(Token = "0x40147D0")]
		[FieldOffset(Offset = "0x1DC")]
		[SerializeField]
		private ElementType _elementDamageType;

		// Token: 0x040147D1 RID: 83921
		[Token(Token = "0x40147D1")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		[Inspect("hasEpDamage")]
		private float _epDamageRatio;

		// Token: 0x040147D2 RID: 83922
		[Token(Token = "0x40147D2")]
		[FieldOffset(Offset = "0x1E4")]
		[SerializeField]
		private bool _useDynamicAttackType;

		// Token: 0x040147D3 RID: 83923
		[Token(Token = "0x40147D3")]
		[FieldOffset(Offset = "0x1E5")]
		[SerializeField]
		private bool _deliveryParaWhenReplaceActionNode;

		// Token: 0x040147D4 RID: 83924
		[Token(Token = "0x40147D4")]
		[FieldOffset(Offset = "0x1E8")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		protected FP m_atkScale;

		// Token: 0x040147D5 RID: 83925
		[Token(Token = "0x40147D5")]
		[FieldOffset(Offset = "0x1F0")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		protected FP m_epDamageRatio;

		// Token: 0x040147D6 RID: 83926
		[Token(Token = "0x40147D6")]
		[FieldOffset(Offset = "0x1F8")]
		protected List<ActionNode> m_actions;

		// Token: 0x040147D7 RID: 83927
		[Token(Token = "0x40147D7")]
		[FieldOffset(Offset = "0x200")]
		protected ElementType m_elementDamageType;

		// Token: 0x040147D8 RID: 83928
		[Token(Token = "0x40147D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasEpDamage;

		// Token: 0x040147D9 RID: 83929
		[Token(Token = "0x40147D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_atkScale;

		// Token: 0x040147DA RID: 83930
		[Token(Token = "0x40147DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_damageNodeAtkScale;

		// Token: 0x040147DB RID: 83931
		[Token(Token = "0x40147DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_elementDamageType;

		// Token: 0x040147DC RID: 83932
		[Token(Token = "0x40147DC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_attackType;

		// Token: 0x040147DD RID: 83933
		[Token(Token = "0x40147DD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_useDynamicAttackType;

		// Token: 0x040147DE RID: 83934
		[Token(Token = "0x40147DE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ApplyAtkScale;

		// Token: 0x040147DF RID: 83935
		[Token(Token = "0x40147DF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ReplaceDamageNode;

		// Token: 0x040147E0 RID: 83936
		[Token(Token = "0x40147E0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ApplyElementDamageScale;

		// Token: 0x040147E1 RID: 83937
		[Token(Token = "0x40147E1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CreateAndReplaceDamageNode;

		// Token: 0x040147E2 RID: 83938
		[Token(Token = "0x40147E2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040147E3 RID: 83939
		[Token(Token = "0x40147E3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckIsDamageOrHealSource;

		// Token: 0x040147E4 RID: 83940
		[Token(Token = "0x40147E4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GeneratePurposeMask;

		// Token: 0x040147E5 RID: 83941
		[Token(Token = "0x40147E5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x040147E6 RID: 83942
		[Token(Token = "0x40147E6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x040147E7 RID: 83943
		[Token(Token = "0x40147E7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
