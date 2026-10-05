using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AA4 RID: 10916
	[Token(Token = "0x2002AA4")]
	public class MultiMeleeAttackWithSplashDmg : MultiMeleeAttack
	{
		// Token: 0x170027D6 RID: 10198
		// (get) Token: 0x06012224 RID: 74276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170027D6")]
		public TargetSelector splashSelector
		{
			[Token(Token = "0x6012224")]
			[Address(RVA = "0xA428F0", Offset = "0xA414F0", VA = "0x180A428F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170027D7 RID: 10199
		// (get) Token: 0x06012225 RID: 74277 RVA: 0x0006F210 File Offset: 0x0006D410
		[Token(Token = "0x170027D7")]
		public FP atkScaleSplash
		{
			[Token(Token = "0x6012225")]
			[Address(RVA = "0xA42890", Offset = "0xA41490", VA = "0x180A42890")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170027D8 RID: 10200
		// (get) Token: 0x06012226 RID: 74278 RVA: 0x0006F228 File Offset: 0x0006D428
		[Token(Token = "0x170027D8")]
		protected override bool useDynamicAttackType
		{
			[Token(Token = "0x6012226")]
			[Address(RVA = "0xA42970", Offset = "0xA41570", VA = "0x180A42970", Slot = "100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012227 RID: 74279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012227")]
		[Address(RVA = "0xA41B80", Offset = "0xA40780", VA = "0x180A41B80", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012228 RID: 74280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012228")]
		[Address(RVA = "0xA41A00", Offset = "0xA40600", VA = "0x180A41A00", Slot = "102")]
		protected override Nodes.ApplyDamage CreateDamageNode(DamageType damageType, FP atkScale)
		{
			return null;
		}

		// Token: 0x06012229 RID: 74281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012229")]
		[Address(RVA = "0xA41AC0", Offset = "0xA406C0", VA = "0x180A41AC0", Slot = "110")]
		protected virtual Nodes.ApplyDamage CreateDamagetNodeToSplashTarget(DamageType damageType, FP atkScale)
		{
			return null;
		}

		// Token: 0x0601222A RID: 74282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601222A")]
		[Address(RVA = "0xA42090", Offset = "0xA40C90", VA = "0x180A42090", Slot = "111")]
		protected virtual IList<BuffData> GetActiveBuffsToMainTarget()
		{
			return null;
		}

		// Token: 0x0601222B RID: 74283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601222B")]
		[Address(RVA = "0xA420F0", Offset = "0xA40CF0", VA = "0x180A420F0", Slot = "112")]
		protected virtual IList<BuffData> GetActiveBuffsToSplashTarget()
		{
			return null;
		}

		// Token: 0x0601222C RID: 74284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601222C")]
		[Address(RVA = "0xA42290", Offset = "0xA40E90", VA = "0x180A42290", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x0601222D RID: 74285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601222D")]
		[Address(RVA = "0xA42010", Offset = "0xA40C10", VA = "0x180A42010")]
		protected IList<ActionNode> GetActionsToSplashTarget(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x0601222E RID: 74286 RVA: 0x0006F240 File Offset: 0x0006D440
		[Token(Token = "0x601222E")]
		[Address(RVA = "0xA42150", Offset = "0xA40D50", VA = "0x180A42150", Slot = "113")]
		protected virtual bool IsMainTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0601222F RID: 74287 RVA: 0x0006F258 File Offset: 0x0006D458
		[Token(Token = "0x601222F")]
		[Address(RVA = "0xA41660", Offset = "0xA40260", VA = "0x180A41660", Slot = "87")]
		protected override bool CheckAnotherSpell(int spellCnt)
		{
			return default(bool);
		}

		// Token: 0x06012230 RID: 74288 RVA: 0x0006F270 File Offset: 0x0006D470
		[Token(Token = "0x6012230")]
		[Address(RVA = "0xA424A0", Offset = "0xA410A0", VA = "0x180A424A0", Slot = "86")]
		protected override bool UpdateTargets(bool updateInputPos = false)
		{
			return default(bool);
		}

		// Token: 0x06012231 RID: 74289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012231")]
		[Address(RVA = "0xA42750", Offset = "0xA41350", VA = "0x180A42750")]
		public MultiMeleeAttackWithSplashDmg()
		{
		}

		// Token: 0x06012232 RID: 74290 RVA: 0x0006F288 File Offset: 0x0006D488
		[Token(Token = "0x6012232")]
		[Address(RVA = "0xA42490", Offset = "0xA41090", VA = "0x180A42490")]
		private bool <>xLuaBaseProxy_get_useDynamicAttackType()
		{
			return default(bool);
		}

		// Token: 0x06012233 RID: 74291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012233")]
		[Address(RVA = "0xA42450", Offset = "0xA41050", VA = "0x180A42450")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012234 RID: 74292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012234")]
		[Address(RVA = "0xA25720", Offset = "0xA24320", VA = "0x180A25720")]
		private Nodes.ApplyDamage <>xLuaBaseProxy_CreateDamageNode(DamageType P0, FP P1)
		{
			return null;
		}

		// Token: 0x06012235 RID: 74293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012235")]
		[Address(RVA = "0xA25740", Offset = "0xA24340", VA = "0x180A25740")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x06012236 RID: 74294 RVA: 0x0006F2A0 File Offset: 0x0006D4A0
		[Token(Token = "0x6012236")]
		[Address(RVA = "0xA42440", Offset = "0xA41040", VA = "0x180A42440")]
		private bool <>xLuaBaseProxy_CheckAnotherSpell(int P0)
		{
			return default(bool);
		}

		// Token: 0x06012237 RID: 74295 RVA: 0x0006F2B8 File Offset: 0x0006D4B8
		[Token(Token = "0x6012237")]
		[Address(RVA = "0xA42480", Offset = "0xA41080", VA = "0x180A42480")]
		private bool <>xLuaBaseProxy_UpdateTargets(bool P0)
		{
			return default(bool);
		}

		// Token: 0x0401484A RID: 84042
		[Token(Token = "0x401484A")]
		[FieldOffset(Offset = "0x258")]
		[SerializeField]
		private float _splashAtkScale;

		// Token: 0x0401484B RID: 84043
		[Token(Token = "0x401484B")]
		[FieldOffset(Offset = "0x260")]
		[SerializeField]
		private string _splashAtkScaleKey;

		// Token: 0x0401484C RID: 84044
		[Token(Token = "0x401484C")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		private BuffData[] _activeBuffsToMainTarget;

		// Token: 0x0401484D RID: 84045
		[Token(Token = "0x401484D")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		private BuffData[] _activeBuffsToSplashTarget;

		// Token: 0x0401484E RID: 84046
		[Token(Token = "0x401484E")]
		[FieldOffset(Offset = "0x278")]
		protected FP m_atkScaleSplash;

		// Token: 0x0401484F RID: 84047
		[Token(Token = "0x401484F")]
		[FieldOffset(Offset = "0x280")]
		protected List<ActionNode> m_actionsToSplashTargets;

		// Token: 0x04014850 RID: 84048
		[Token(Token = "0x4014850")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_splashSelector;

		// Token: 0x04014851 RID: 84049
		[Token(Token = "0x4014851")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_atkScaleSplash;

		// Token: 0x04014852 RID: 84050
		[Token(Token = "0x4014852")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_useDynamicAttackType;

		// Token: 0x04014853 RID: 84051
		[Token(Token = "0x4014853")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014854 RID: 84052
		[Token(Token = "0x4014854")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateDamageNode;

		// Token: 0x04014855 RID: 84053
		[Token(Token = "0x4014855")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CreateDamagetNodeToSplashTarget;

		// Token: 0x04014856 RID: 84054
		[Token(Token = "0x4014856")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetActiveBuffsToMainTarget;

		// Token: 0x04014857 RID: 84055
		[Token(Token = "0x4014857")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetActiveBuffsToSplashTarget;

		// Token: 0x04014858 RID: 84056
		[Token(Token = "0x4014858")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04014859 RID: 84057
		[Token(Token = "0x4014859")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetActionsToSplashTarget;

		// Token: 0x0401485A RID: 84058
		[Token(Token = "0x401485A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_IsMainTarget;

		// Token: 0x0401485B RID: 84059
		[Token(Token = "0x401485B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckAnotherSpell;

		// Token: 0x0401485C RID: 84060
		[Token(Token = "0x401485C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateTargets;

		// Token: 0x0401485D RID: 84061
		[Token(Token = "0x401485D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
