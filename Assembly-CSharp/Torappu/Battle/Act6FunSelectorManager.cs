using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002306 RID: 8966
	[Token(Token = "0x2002306")]
	public class Act6FunSelectorManager : EnvSelectorManager
	{
		// Token: 0x0600E273 RID: 57971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E273")]
		[Address(RVA = "0x55D2B0", Offset = "0x55BEB0", VA = "0x18055D2B0", Slot = "9")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600E274 RID: 57972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E274")]
		[Address(RVA = "0x55D370", Offset = "0x55BF70", VA = "0x18055D370", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600E275 RID: 57973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E275")]
		[Address(RVA = "0x55D590", Offset = "0x55C190", VA = "0x18055D590", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E276 RID: 57974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E276")]
		[Address(RVA = "0x55D7F0", Offset = "0x55C3F0", VA = "0x18055D7F0", Slot = "16")]
		protected override void SelectTargets(List<Entity> candidates)
		{
		}

		// Token: 0x0600E277 RID: 57975 RVA: 0x000522A8 File Offset: 0x000504A8
		[Token(Token = "0x600E277")]
		[Address(RVA = "0x55DAD0", Offset = "0x55C6D0", VA = "0x18055DAD0", Slot = "17")]
		protected override bool VerifyTarget(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x0600E278 RID: 57976 RVA: 0x000522C0 File Offset: 0x000504C0
		[Token(Token = "0x600E278")]
		[Address(RVA = "0x55DFE0", Offset = "0x55CBE0", VA = "0x18055DFE0")]
		private bool _VerifyTargetPosition(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x0600E279 RID: 57977 RVA: 0x000522D8 File Offset: 0x000504D8
		[Token(Token = "0x600E279")]
		[Address(RVA = "0x55DF20", Offset = "0x55CB20", VA = "0x18055DF20")]
		private bool _VerifyTargetContainsBuff(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x0600E27A RID: 57978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E27A")]
		[Address(RVA = "0x55DD20", Offset = "0x55C920", VA = "0x18055DD20")]
		private void _UpdatePivotEffectPosition(FP deltaTime)
		{
		}

		// Token: 0x0600E27B RID: 57979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E27B")]
		[Address(RVA = "0x55E150", Offset = "0x55CD50", VA = "0x18055E150")]
		public Act6FunSelectorManager()
		{
		}

		// Token: 0x0600E27C RID: 57980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E27C")]
		[Address(RVA = "0x550BD0", Offset = "0x54F7D0", VA = "0x180550BD0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0600E27D RID: 57981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E27D")]
		[Address(RVA = "0x55DA90", Offset = "0x55C690", VA = "0x18055DA90")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E27E RID: 57982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E27E")]
		[Address(RVA = "0x55DAA0", Offset = "0x55C6A0", VA = "0x18055DAA0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E27F RID: 57983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E27F")]
		[Address(RVA = "0x55DAB0", Offset = "0x55C6B0", VA = "0x18055DAB0")]
		private void <>xLuaBaseProxy_SelectTargets(List<Entity> P0)
		{
		}

		// Token: 0x0600E280 RID: 57984 RVA: 0x000522F0 File Offset: 0x000504F0
		[Token(Token = "0x600E280")]
		[Address(RVA = "0x55DAC0", Offset = "0x55C6C0", VA = "0x18055DAC0")]
		private bool <>xLuaBaseProxy_VerifyTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0400F838 RID: 63544
		[Token(Token = "0x400F838")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Act6Fun", Priority = 0)]
		private string _pivotEffect;

		// Token: 0x0400F839 RID: 63545
		[Token(Token = "0x400F839")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Act6Fun", Priority = 0)]
		private float _pivotMoveSpeed;

		// Token: 0x0400F83A RID: 63546
		[Token(Token = "0x400F83A")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[Group("Act6Fun", Priority = 0)]
		private float _pivotEffectOffset;

		// Token: 0x0400F83B RID: 63547
		[Token(Token = "0x400F83B")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Act6Fun", Priority = 0)]
		private float _startOffsetX;

		// Token: 0x0400F83C RID: 63548
		[Token(Token = "0x400F83C")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[Group("Act6Fun", Priority = 0)]
		private float _preDelay;

		// Token: 0x0400F83D RID: 63549
		[Token(Token = "0x400F83D")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Act6Fun", Priority = 0)]
		private string[] _additionalTargetsWithBuffKeys;

		// Token: 0x0400F83E RID: 63550
		[Token(Token = "0x400F83E")]
		[FieldOffset(Offset = "0xE8")]
		private Effect m_pivotEffect;

		// Token: 0x0400F83F RID: 63551
		[Token(Token = "0x400F83F")]
		[FieldOffset(Offset = "0xF0")]
		private float m_preDelay;

		// Token: 0x0400F840 RID: 63552
		[Token(Token = "0x400F840")]
		[FieldOffset(Offset = "0xF4")]
		private Vector3 m_originPivotPos;

		// Token: 0x0400F841 RID: 63553
		[Token(Token = "0x400F841")]
		[FieldOffset(Offset = "0x100")]
		private Vector3 m_targetPivotPos;

		// Token: 0x0400F842 RID: 63554
		[Token(Token = "0x400F842")]
		[FieldOffset(Offset = "0x10C")]
		private float m_pivotMoveSpeed;

		// Token: 0x0400F843 RID: 63555
		[Token(Token = "0x400F843")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400F844 RID: 63556
		[Token(Token = "0x400F844")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F845 RID: 63557
		[Token(Token = "0x400F845")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F846 RID: 63558
		[Token(Token = "0x400F846")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SelectTargets;

		// Token: 0x0400F847 RID: 63559
		[Token(Token = "0x400F847")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_VerifyTarget;

		// Token: 0x0400F848 RID: 63560
		[Token(Token = "0x400F848")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__VerifyTargetPosition;

		// Token: 0x0400F849 RID: 63561
		[Token(Token = "0x400F849")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__VerifyTargetContainsBuff;

		// Token: 0x0400F84A RID: 63562
		[Token(Token = "0x400F84A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdatePivotEffectPosition;

		// Token: 0x0400F84B RID: 63563
		[Token(Token = "0x400F84B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
