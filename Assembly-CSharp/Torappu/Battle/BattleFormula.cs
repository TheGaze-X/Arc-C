using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200218E RID: 8590
	[Token(Token = "0x200218E")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class BattleFormula
	{
		// Token: 0x0600D4A9 RID: 54441 RVA: 0x0004CCF8 File Offset: 0x0004AEF8
		[Token(Token = "0x600D4A9")]
		[Address(RVA = "0x3584360", Offset = "0x3582F60", VA = "0x183584360")]
		public static FP CalculateDamage(Entity target, Entity source, bool triggerTargetEvent, bool triggerSourceEvent, ref BattleFormula.AttackInfo atkInfo)
		{
			return default(FP);
		}

		// Token: 0x0600D4AA RID: 54442 RVA: 0x0004CD10 File Offset: 0x0004AF10
		[Token(Token = "0x600D4AA")]
		[Address(RVA = "0x3583FE0", Offset = "0x3582BE0", VA = "0x183583FE0")]
		public static FP CalculateDamageNoEvent(Entity target, Entity source, BattleFormula.AttackInfo atkInfo)
		{
			return default(FP);
		}

		// Token: 0x0600D4AB RID: 54443 RVA: 0x0004CD28 File Offset: 0x0004AF28
		[Token(Token = "0x600D4AB")]
		[Address(RVA = "0x3583B30", Offset = "0x3582730", VA = "0x183583B30")]
		private static FP CalculateDamageInternal(BattleFormula.AttackInfo atkInfo, FP penetrateRatio, FP penetrateFixed, Entity target)
		{
			return default(FP);
		}

		// Token: 0x0600D4AC RID: 54444 RVA: 0x0004CD40 File Offset: 0x0004AF40
		[Token(Token = "0x600D4AC")]
		[Address(RVA = "0x3584580", Offset = "0x3583180", VA = "0x183584580")]
		public static FP CalculateDamage(FP atk, Entity target, DamageType damageType, FP atkScale, FP atkAddition)
		{
			return default(FP);
		}

		// Token: 0x0600D4AD RID: 54445 RVA: 0x0004CD58 File Offset: 0x0004AF58
		[Token(Token = "0x600D4AD")]
		[Address(RVA = "0x3584AA0", Offset = "0x35836A0", VA = "0x183584AA0")]
		public static FP CalculateElementDamage(Entity source, Entity target, FP atkScale)
		{
			return default(FP);
		}

		// Token: 0x0600D4AE RID: 54446 RVA: 0x0004CD70 File Offset: 0x0004AF70
		[Token(Token = "0x600D4AE")]
		[Address(RVA = "0x35847F0", Offset = "0x35833F0", VA = "0x1835847F0")]
		public static FP CalculateElementDamage(FP atk, Entity target, FP atkScale)
		{
			return default(FP);
		}

		// Token: 0x0600D4AF RID: 54447 RVA: 0x0004CD88 File Offset: 0x0004AF88
		[Token(Token = "0x600D4AF")]
		[Address(RVA = "0x35848E0", Offset = "0x35834E0", VA = "0x1835848E0")]
		public static FP CalculateElementDamage(FP atk, Entity target)
		{
			return default(FP);
		}

		// Token: 0x0600D4B0 RID: 54448 RVA: 0x0004CDA0 File Offset: 0x0004AFA0
		[Token(Token = "0x600D4B0")]
		[Address(RVA = "0x3584BB0", Offset = "0x35837B0", VA = "0x183584BB0")]
		public static FP CalculateHeal(Entity source, Entity target, FP healScale)
		{
			return default(FP);
		}

		// Token: 0x0600D4B1 RID: 54449 RVA: 0x0004CDB8 File Offset: 0x0004AFB8
		[Token(Token = "0x600D4B1")]
		[Address(RVA = "0x3584DE0", Offset = "0x35839E0", VA = "0x183584DE0")]
		public static FP CalculateHeal(FP atk, Entity target, FP healScale)
		{
			return default(FP);
		}

		// Token: 0x0600D4B2 RID: 54450 RVA: 0x0004CDD0 File Offset: 0x0004AFD0
		[Token(Token = "0x600D4B2")]
		[Address(RVA = "0x35839E0", Offset = "0x35825E0", VA = "0x1835839E0")]
		public static FP CalculateAttackInterval(FP baseAttackTime, FP attackSpeed)
		{
			return default(FP);
		}

		// Token: 0x0600D4B3 RID: 54451 RVA: 0x0004CDE8 File Offset: 0x0004AFE8
		[Token(Token = "0x600D4B3")]
		[Address(RVA = "0x3585110", Offset = "0x3583D10", VA = "0x183585110")]
		public static FP CalculatePenetrateRatio(Entity source, Entity target, DamageType damageType)
		{
			return default(FP);
		}

		// Token: 0x0600D4B4 RID: 54452 RVA: 0x0004CE00 File Offset: 0x0004B000
		[Token(Token = "0x600D4B4")]
		[Address(RVA = "0x3584FF0", Offset = "0x3583BF0", VA = "0x183584FF0")]
		public static FP CalculatePenetrateFixed(Entity source, Entity target, DamageType damageType)
		{
			return default(FP);
		}

		// Token: 0x0600D4B5 RID: 54453 RVA: 0x0004CE18 File Offset: 0x0004B018
		[Token(Token = "0x600D4B5")]
		[Address(RVA = "0x3585550", Offset = "0x3584150", VA = "0x183585550")]
		public static float CalculatePushForce(int pushForceLevel, int massLevel)
		{
			return 0f;
		}

		// Token: 0x0600D4B6 RID: 54454 RVA: 0x0004CE30 File Offset: 0x0004B030
		[Token(Token = "0x600D4B6")]
		[Address(RVA = "0x3585440", Offset = "0x3584040", VA = "0x183585440")]
		public static float CalculatePushForce(int pushForceLevel, int massLevel, out int pushForceIndex)
		{
			return 0f;
		}

		// Token: 0x0600D4B7 RID: 54455 RVA: 0x0004CE48 File Offset: 0x0004B048
		[Token(Token = "0x600D4B7")]
		[Address(RVA = "0x3585310", Offset = "0x3583F10", VA = "0x183585310")]
		public static float CalculatePushForce(int pushForceLevel, int massLevel, Vector2Int pushForceRange, out int pushForceIndex)
		{
			return 0f;
		}

		// Token: 0x0600D4B8 RID: 54456 RVA: 0x0004CE60 File Offset: 0x0004B060
		[Token(Token = "0x600D4B8")]
		[Address(RVA = "0x3585230", Offset = "0x3583E30", VA = "0x183585230")]
		public static float CalculatePullForce(int pullForceLevel, int massLevel)
		{
			return 0f;
		}

		// Token: 0x0600D4B9 RID: 54457 RVA: 0x0004CE78 File Offset: 0x0004B078
		[Token(Token = "0x600D4B9")]
		[Address(RVA = "0x3585630", Offset = "0x3584230", VA = "0x183585630")]
		public static int CalculateRuntimeCardCost(int costDelta, int rawCost, FP rawCostScale)
		{
			return 0;
		}

		// Token: 0x0400E429 RID: 58409
		[Token(Token = "0x400E429")]
		[FieldOffset(Offset = "0x0")]
		private static readonly FP MIN_ATK_FACTOR;

		// Token: 0x0400E42A RID: 58410
		[Token(Token = "0x400E42A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FP MAX_ATTACK_SPEED;

		// Token: 0x0400E42B RID: 58411
		[Token(Token = "0x400E42B")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FP MIN_ATTACK_SPEED;

		// Token: 0x0400E42C RID: 58412
		[Token(Token = "0x400E42C")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FP ATTACK_SPEED_DIVIDER;

		// Token: 0x0400E42D RID: 58413
		[Token(Token = "0x400E42D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CalculateDamage;

		// Token: 0x0400E42E RID: 58414
		[Token(Token = "0x400E42E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CalculateDamageNoEvent;

		// Token: 0x0400E42F RID: 58415
		[Token(Token = "0x400E42F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CalculateDamageInternal;

		// Token: 0x0400E430 RID: 58416
		[Token(Token = "0x400E430")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_CalculateDamage;

		// Token: 0x0400E431 RID: 58417
		[Token(Token = "0x400E431")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CalculateElementDamage;

		// Token: 0x0400E432 RID: 58418
		[Token(Token = "0x400E432")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1_CalculateElementDamage;

		// Token: 0x0400E433 RID: 58419
		[Token(Token = "0x400E433")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix2_CalculateElementDamage;

		// Token: 0x0400E434 RID: 58420
		[Token(Token = "0x400E434")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CalculateHeal;

		// Token: 0x0400E435 RID: 58421
		[Token(Token = "0x400E435")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix1_CalculateHeal;

		// Token: 0x0400E436 RID: 58422
		[Token(Token = "0x400E436")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CalculateAttackInterval;

		// Token: 0x0400E437 RID: 58423
		[Token(Token = "0x400E437")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CalculatePenetrateRatio;

		// Token: 0x0400E438 RID: 58424
		[Token(Token = "0x400E438")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CalculatePenetrateFixed;

		// Token: 0x0400E439 RID: 58425
		[Token(Token = "0x400E439")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CalculatePushForce;

		// Token: 0x0400E43A RID: 58426
		[Token(Token = "0x400E43A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix1_CalculatePushForce;

		// Token: 0x0400E43B RID: 58427
		[Token(Token = "0x400E43B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix2_CalculatePushForce;

		// Token: 0x0400E43C RID: 58428
		[Token(Token = "0x400E43C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CalculatePullForce;

		// Token: 0x0400E43D RID: 58429
		[Token(Token = "0x400E43D")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_CalculateRuntimeCardCost;

		// Token: 0x0200218F RID: 8591
		[Token(Token = "0x200218F")]
		public struct AttackInfo
		{
			// Token: 0x0600D4BB RID: 54459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D4BB")]
			[Address(RVA = "0x3581000", Offset = "0x357FC00", VA = "0x183581000")]
			public AttackInfo(FP atk, DamageType damageType)
			{
			}

			// Token: 0x0600D4BC RID: 54460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D4BC")]
			[Address(RVA = "0x3580F50", Offset = "0x357FB50", VA = "0x183580F50")]
			public AttackInfo(FP atk, DamageType damageType, FP atkScale)
			{
			}

			// Token: 0x0600D4BD RID: 54461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D4BD")]
			[Address(RVA = "0x3580FE0", Offset = "0x357FBE0", VA = "0x183580FE0")]
			public AttackInfo(FP atk, DamageType damageType, FP atkScale, FP atkAddition)
			{
			}

			// Token: 0x0600D4BE RID: 54462 RVA: 0x0004CE90 File Offset: 0x0004B090
			[Token(Token = "0x600D4BE")]
			[Address(RVA = "0x3580E20", Offset = "0x357FA20", VA = "0x183580E20")]
			public FP GetFinalAtk()
			{
				return default(FP);
			}

			// Token: 0x0400E43E RID: 58430
			[Token(Token = "0x400E43E")]
			[FieldOffset(Offset = "0x0")]
			public DamageType damageType;

			// Token: 0x0400E43F RID: 58431
			[Token(Token = "0x400E43F")]
			[FieldOffset(Offset = "0x8")]
			public FP originAtk;

			// Token: 0x0400E440 RID: 58432
			[Token(Token = "0x400E440")]
			[FieldOffset(Offset = "0x10")]
			public FP atk;

			// Token: 0x0400E441 RID: 58433
			[Token(Token = "0x400E441")]
			[FieldOffset(Offset = "0x18")]
			public FP atkScale;

			// Token: 0x0400E442 RID: 58434
			[Token(Token = "0x400E442")]
			[FieldOffset(Offset = "0x20")]
			public FP atkAddition;
		}
	}
}
