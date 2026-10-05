using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AA7 RID: 10919
	[Token(Token = "0x2002AA7")]
	public class ChargeRangedAttack : RangedAttack, IChargeableAttackAbilityReactor, IChargeableAbilityReactor, IChargeableAbility, IMultiChargeUberEffectEmitterAbility, IChargeableSource
	{
		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x06012257 RID: 74327 RVA: 0x0006F2E8 File Offset: 0x0006D4E8
		[Token(Token = "0x170027D9")]
		public override bool isReady
		{
			[Token(Token = "0x6012257")]
			[Address(RVA = "0xA38910", Offset = "0xA37510", VA = "0x180A38910", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027DA RID: 10202
		// (get) Token: 0x06012258 RID: 74328 RVA: 0x0006F300 File Offset: 0x0006D500
		[Token(Token = "0x170027DA")]
		protected bool isChargeAction
		{
			[Token(Token = "0x6012258")]
			[Address(RVA = "0xA388B0", Offset = "0xA374B0", VA = "0x180A388B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x06012259 RID: 74329 RVA: 0x0006F318 File Offset: 0x0006D518
		// (set) Token: 0x0601225A RID: 74330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170027DB")]
		[Inspect(Level = 2)]
		[Group("ChargeAttack")]
		protected virtual int chargeTimes
		{
			[Token(Token = "0x6012259")]
			[Address(RVA = "0xA38850", Offset = "0xA37450", VA = "0x180A38850", Slot = "127")]
			get
			{
				return 0;
			}
			[Token(Token = "0x601225A")]
			[Address(RVA = "0xA38A50", Offset = "0xA37650", VA = "0x180A38A50", Slot = "128")]
			set
			{
			}
		}

		// Token: 0x170027DC RID: 10204
		// (get) Token: 0x0601225B RID: 74331 RVA: 0x0006F330 File Offset: 0x0006D530
		// (set) Token: 0x0601225C RID: 74332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170027DC")]
		protected int maxChargeTimes
		{
			[Token(Token = "0x601225B")]
			[Address(RVA = "0xA38970", Offset = "0xA37570", VA = "0x180A38970")]
			get
			{
				return 0;
			}
			[Token(Token = "0x601225C")]
			[Address(RVA = "0xA38AC0", Offset = "0xA376C0", VA = "0x180A38AC0")]
			set
			{
			}
		}

		// Token: 0x0601225D RID: 74333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601225D")]
		[Address(RVA = "0xA37AE0", Offset = "0xA366E0", VA = "0x180A37AE0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0601225E RID: 74334 RVA: 0x0006F348 File Offset: 0x0006D548
		[Token(Token = "0x601225E")]
		[Address(RVA = "0xA37530", Offset = "0xA36130", VA = "0x180A37530", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x0601225F RID: 74335 RVA: 0x0006F360 File Offset: 0x0006D560
		[Token(Token = "0x601225F")]
		[Address(RVA = "0xA37420", Offset = "0xA36020", VA = "0x180A37420")]
		protected bool BaseCastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012260 RID: 74336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012260")]
		[Address(RVA = "0xA375F0", Offset = "0xA361F0", VA = "0x180A375F0", Slot = "113")]
		protected override Projectile CreateProjectile(ILocatable target, out Projectile fakeProjectile)
		{
			return null;
		}

		// Token: 0x06012261 RID: 74337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012261")]
		[Address(RVA = "0xA38170", Offset = "0xA36D70", VA = "0x180A38170", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012262 RID: 74338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012262")]
		[Address(RVA = "0xA373C0", Offset = "0xA35FC0", VA = "0x180A373C0", Slot = "129")]
		public virtual void AddChargeTimes()
		{
		}

		// Token: 0x06012263 RID: 74339 RVA: 0x0006F378 File Offset: 0x0006D578
		[Token(Token = "0x6012263")]
		[Address(RVA = "0xA374C0", Offset = "0xA360C0", VA = "0x180A374C0", Slot = "130")]
		public virtual bool CanCharge()
		{
			return default(bool);
		}

		// Token: 0x06012264 RID: 74340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012264")]
		[Address(RVA = "0xA385E0", Offset = "0xA371E0", VA = "0x180A385E0", Slot = "131")]
		public virtual void SetIsChargeAction(bool isChargeAttack)
		{
		}

		// Token: 0x06012265 RID: 74341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012265")]
		[Address(RVA = "0xA380E0", Offset = "0xA36CE0", VA = "0x180A380E0", Slot = "124")]
		public void OnChargeCastEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012266 RID: 74342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012266")]
		[Address(RVA = "0xA37C10", Offset = "0xA36810", VA = "0x180A37C10", Slot = "123")]
		public void FinishAbility(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012267 RID: 74343 RVA: 0x0006F390 File Offset: 0x0006D590
		[Token(Token = "0x6012267")]
		[Address(RVA = "0xA37CA0", Offset = "0xA368A0", VA = "0x180A37CA0", Slot = "126")]
		public int GetChargeTimes()
		{
			return 0;
		}

		// Token: 0x06012268 RID: 74344 RVA: 0x0006F3A8 File Offset: 0x0006D5A8
		[Token(Token = "0x6012268")]
		[Address(RVA = "0xA37D00", Offset = "0xA36900", VA = "0x180A37D00", Slot = "125")]
		public bool GetIsChargeAction()
		{
			return default(bool);
		}

		// Token: 0x06012269 RID: 74345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012269")]
		[Address(RVA = "0xA37D60", Offset = "0xA36960", VA = "0x180A37D60", Slot = "116")]
		public void MergeAtkScale(FP atkScale)
		{
		}

		// Token: 0x0601226A RID: 74346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601226A")]
		[Address(RVA = "0xA38200", Offset = "0xA36E00", VA = "0x180A38200", Slot = "117")]
		public void ResetAtkScale()
		{
		}

		// Token: 0x170027DD RID: 10205
		// (get) Token: 0x0601226B RID: 74347 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601226C RID: 74348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170027DD")]
		public IChargeableAbilityCounter chargeCounter
		{
			[Token(Token = "0x601226B")]
			[Address(RVA = "0xA387F0", Offset = "0xA373F0", VA = "0x180A387F0", Slot = "118")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601226C")]
			[Address(RVA = "0xA389D0", Offset = "0xA375D0", VA = "0x180A389D0", Slot = "119")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601226D RID: 74349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601226D")]
		[Address(RVA = "0xA383B0", Offset = "0xA36FB0", VA = "0x180A383B0", Slot = "120")]
		public void SetChargeCounter(IChargeableAbilityCounter counter)
		{
		}

		// Token: 0x0601226E RID: 74350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601226E")]
		[Address(RVA = "0xA38460", Offset = "0xA37060", VA = "0x180A38460", Slot = "121")]
		public void SetChargeTimes(int times)
		{
		}

		// Token: 0x0601226F RID: 74351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601226F")]
		[Address(RVA = "0xA37F30", Offset = "0xA36B30", VA = "0x180A37F30", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x06012270 RID: 74352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012270")]
		[Address(RVA = "0xA38730", Offset = "0xA37330", VA = "0x180A38730")]
		public ChargeRangedAttack()
		{
		}

		// Token: 0x06012271 RID: 74353 RVA: 0x0006F3C0 File Offset: 0x0006D5C0
		[Token(Token = "0x6012271")]
		[Address(RVA = "0xA38720", Offset = "0xA37320", VA = "0x180A38720")]
		private bool <>xLuaBaseProxy_get_isReady()
		{
			return default(bool);
		}

		// Token: 0x06012272 RID: 74354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012272")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012273 RID: 74355 RVA: 0x0006F3D8 File Offset: 0x0006D5D8
		[Token(Token = "0x6012273")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x06012274 RID: 74356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012274")]
		[Address(RVA = "0xA37170", Offset = "0xA35D70", VA = "0x180A37170")]
		private Projectile <>xLuaBaseProxy_CreateProjectile(ILocatable P0, out Projectile P1)
		{
			return null;
		}

		// Token: 0x06012275 RID: 74357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012275")]
		[Address(RVA = "0xA38660", Offset = "0xA37260", VA = "0x180A38660")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012276 RID: 74358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012276")]
		[Address(RVA = "0xA36000", Offset = "0xA34C00", VA = "0x180A36000")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x04014881 RID: 84097
		[Token(Token = "0x4014881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		[SerializeField]
		[Group("ChargeAttack")]
		private int _maxChargeTimes;

		// Token: 0x04014882 RID: 84098
		[Token(Token = "0x4014882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		[SerializeField]
		[Group("ChargeAttack")]
		private List<Entity.MountPointType> _mountPointForProjectiles;

		// Token: 0x04014883 RID: 84099
		[Token(Token = "0x4014883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private int m_chargeTimes;

		// Token: 0x04014884 RID: 84100
		[Token(Token = "0x4014884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private bool m_isChargeAction;

		// Token: 0x04014885 RID: 84101
		[Token(Token = "0x4014885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private int m_maxChargeTimes;

		// Token: 0x04014887 RID: 84103
		[Token(Token = "0x4014887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isReady;

		// Token: 0x04014888 RID: 84104
		[Token(Token = "0x4014888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isChargeAction;

		// Token: 0x04014889 RID: 84105
		[Token(Token = "0x4014889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_chargeTimes;

		// Token: 0x0401488A RID: 84106
		[Token(Token = "0x401488A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_chargeTimes;

		// Token: 0x0401488B RID: 84107
		[Token(Token = "0x401488B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_maxChargeTimes;

		// Token: 0x0401488C RID: 84108
		[Token(Token = "0x401488C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_maxChargeTimes;

		// Token: 0x0401488D RID: 84109
		[Token(Token = "0x401488D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0401488E RID: 84110
		[Token(Token = "0x401488E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x0401488F RID: 84111
		[Token(Token = "0x401488F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_BaseCastToTarget;

		// Token: 0x04014890 RID: 84112
		[Token(Token = "0x4014890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CreateProjectile;

		// Token: 0x04014891 RID: 84113
		[Token(Token = "0x4014891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014892 RID: 84114
		[Token(Token = "0x4014892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_AddChargeTimes;

		// Token: 0x04014893 RID: 84115
		[Token(Token = "0x4014893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CanCharge;

		// Token: 0x04014894 RID: 84116
		[Token(Token = "0x4014894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetIsChargeAction;

		// Token: 0x04014895 RID: 84117
		[Token(Token = "0x4014895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnChargeCastEvent;

		// Token: 0x04014896 RID: 84118
		[Token(Token = "0x4014896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_FinishAbility;

		// Token: 0x04014897 RID: 84119
		[Token(Token = "0x4014897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetChargeTimes;

		// Token: 0x04014898 RID: 84120
		[Token(Token = "0x4014898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetIsChargeAction;

		// Token: 0x04014899 RID: 84121
		[Token(Token = "0x4014899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_MergeAtkScale;

		// Token: 0x0401489A RID: 84122
		[Token(Token = "0x401489A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ResetAtkScale;

		// Token: 0x0401489B RID: 84123
		[Token(Token = "0x401489B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_chargeCounter;

		// Token: 0x0401489C RID: 84124
		[Token(Token = "0x401489C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_chargeCounter;

		// Token: 0x0401489D RID: 84125
		[Token(Token = "0x401489D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_SetChargeCounter;

		// Token: 0x0401489E RID: 84126
		[Token(Token = "0x401489E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SetChargeTimes;

		// Token: 0x0401489F RID: 84127
		[Token(Token = "0x401489F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x040148A0 RID: 84128
		[Token(Token = "0x40148A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
