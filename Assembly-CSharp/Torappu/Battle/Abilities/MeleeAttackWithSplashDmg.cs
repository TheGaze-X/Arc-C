using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AA0 RID: 10912
	[Token(Token = "0x2002AA0")]
	public class MeleeAttackWithSplashDmg : MeleeAttack
	{
		// Token: 0x170027CC RID: 10188
		// (get) Token: 0x060121E8 RID: 74216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170027CC")]
		protected TargetSelector splashSelector
		{
			[Token(Token = "0x60121E8")]
			[Address(RVA = "0xA25890", Offset = "0xA24490", VA = "0x180A25890")]
			get
			{
				return null;
			}
		}

		// Token: 0x170027CD RID: 10189
		// (get) Token: 0x060121E9 RID: 74217 RVA: 0x0006F090 File Offset: 0x0006D290
		[Token(Token = "0x170027CD")]
		protected override bool useDynamicAttackType
		{
			[Token(Token = "0x60121E9")]
			[Address(RVA = "0xA25910", Offset = "0xA24510", VA = "0x180A25910", Slot = "100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060121EA RID: 74218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121EA")]
		[Address(RVA = "0xA24F40", Offset = "0xA23B40", VA = "0x180A24F40", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060121EB RID: 74219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60121EB")]
		[Address(RVA = "0xA24CD0", Offset = "0xA238D0", VA = "0x180A24CD0", Slot = "102")]
		protected override Nodes.ApplyDamage CreateDamageNode(DamageType damageType, FP atkScale)
		{
			return null;
		}

		// Token: 0x060121EC RID: 74220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60121EC")]
		[Address(RVA = "0xA24D90", Offset = "0xA23990", VA = "0x180A24D90", Slot = "110")]
		protected virtual Nodes.ApplyDamage CreateDamagetNodeToSplashTarget(DamageType damageType, FP atkScale)
		{
			return null;
		}

		// Token: 0x060121ED RID: 74221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60121ED")]
		[Address(RVA = "0xA253E0", Offset = "0xA23FE0", VA = "0x180A253E0", Slot = "111")]
		protected virtual IList<BuffData> GetActiveBuffsToMainTarget()
		{
			return null;
		}

		// Token: 0x060121EE RID: 74222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60121EE")]
		[Address(RVA = "0xA25440", Offset = "0xA24040", VA = "0x180A25440", Slot = "112")]
		protected virtual IList<BuffData> GetActiveBuffsToSplashTarget()
		{
			return null;
		}

		// Token: 0x060121EF RID: 74223 RVA: 0x0006F0A8 File Offset: 0x0006D2A8
		[Token(Token = "0x60121EF")]
		[Address(RVA = "0xA24E50", Offset = "0xA23A50", VA = "0x180A24E50", Slot = "85")]
		protected override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x060121F0 RID: 74224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121F0")]
		[Address(RVA = "0xA25570", Offset = "0xA24170", VA = "0x180A25570", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x060121F1 RID: 74225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60121F1")]
		[Address(RVA = "0xA25360", Offset = "0xA23F60", VA = "0x180A25360")]
		protected IList<ActionNode> GetActionsToSplashTarget(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x060121F2 RID: 74226 RVA: 0x0006F0C0 File Offset: 0x0006D2C0
		[Token(Token = "0x60121F2")]
		[Address(RVA = "0xA254A0", Offset = "0xA240A0", VA = "0x180A254A0", Slot = "113")]
		protected virtual bool IsMainTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x060121F3 RID: 74227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121F3")]
		[Address(RVA = "0xA25750", Offset = "0xA24350", VA = "0x180A25750")]
		public MeleeAttackWithSplashDmg()
		{
		}

		// Token: 0x060121F4 RID: 74228 RVA: 0x0006F0D8 File Offset: 0x0006D2D8
		[Token(Token = "0x60121F4")]
		[Address(RVA = "0xA1E890", Offset = "0xA1D490", VA = "0x180A1E890")]
		private bool <>xLuaBaseProxy_get_useDynamicAttackType()
		{
			return default(bool);
		}

		// Token: 0x060121F5 RID: 74229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121F5")]
		[Address(RVA = "0xA1FD10", Offset = "0xA1E910", VA = "0x180A1FD10")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060121F6 RID: 74230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60121F6")]
		[Address(RVA = "0xA25720", Offset = "0xA24320", VA = "0x180A25720")]
		private Nodes.ApplyDamage <>xLuaBaseProxy_CreateDamageNode(DamageType P0, FP P1)
		{
			return null;
		}

		// Token: 0x060121F7 RID: 74231 RVA: 0x0006F0F0 File Offset: 0x0006D2F0
		[Token(Token = "0x60121F7")]
		[Address(RVA = "0xA25730", Offset = "0xA24330", VA = "0x180A25730")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x060121F8 RID: 74232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121F8")]
		[Address(RVA = "0xA25740", Offset = "0xA24340", VA = "0x180A25740")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x0401480D RID: 83981
		[Token(Token = "0x401480D")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		private float _splashAtkScale;

		// Token: 0x0401480E RID: 83982
		[Token(Token = "0x401480E")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		private string _splashAtkScaleKey;

		// Token: 0x0401480F RID: 83983
		[Token(Token = "0x401480F")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		private bool _interruptSpellIfInputTargetDead;

		// Token: 0x04014810 RID: 83984
		[Token(Token = "0x4014810")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		private BuffData[] _activeBuffsToMainTarget;

		// Token: 0x04014811 RID: 83985
		[Token(Token = "0x4014811")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		private BuffData[] _activeBuffsToSplashTarget;

		// Token: 0x04014812 RID: 83986
		[Token(Token = "0x4014812")]
		[FieldOffset(Offset = "0x240")]
		protected FP m_atkScaleSplash;

		// Token: 0x04014813 RID: 83987
		[Token(Token = "0x4014813")]
		[FieldOffset(Offset = "0x248")]
		protected List<ActionNode> m_actionsToSplashTargets;

		// Token: 0x04014814 RID: 83988
		[Token(Token = "0x4014814")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_splashSelector;

		// Token: 0x04014815 RID: 83989
		[Token(Token = "0x4014815")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_useDynamicAttackType;

		// Token: 0x04014816 RID: 83990
		[Token(Token = "0x4014816")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014817 RID: 83991
		[Token(Token = "0x4014817")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateDamageNode;

		// Token: 0x04014818 RID: 83992
		[Token(Token = "0x4014818")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateDamagetNodeToSplashTarget;

		// Token: 0x04014819 RID: 83993
		[Token(Token = "0x4014819")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetActiveBuffsToMainTarget;

		// Token: 0x0401481A RID: 83994
		[Token(Token = "0x401481A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetActiveBuffsToSplashTarget;

		// Token: 0x0401481B RID: 83995
		[Token(Token = "0x401481B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x0401481C RID: 83996
		[Token(Token = "0x401481C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x0401481D RID: 83997
		[Token(Token = "0x401481D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetActionsToSplashTarget;

		// Token: 0x0401481E RID: 83998
		[Token(Token = "0x401481E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_IsMainTarget;

		// Token: 0x0401481F RID: 83999
		[Token(Token = "0x401481F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
