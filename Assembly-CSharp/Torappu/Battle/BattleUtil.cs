using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002653 RID: 9811
	[Token(Token = "0x2002653")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class BattleUtil
	{
		// Token: 0x0601008A RID: 65674 RVA: 0x00061A70 File Offset: 0x0005FC70
		[Token(Token = "0x601008A")]
		[Address(RVA = "0x7BFBD0", Offset = "0x7BE7D0", VA = "0x1807BFBD0")]
		private static SideType GetOppositeSideMask(SideType sideType)
		{
			return SideType.NONE;
		}

		// Token: 0x0601008B RID: 65675 RVA: 0x00061A88 File Offset: 0x0005FC88
		[Token(Token = "0x601008B")]
		[Address(RVA = "0x7BFCB0", Offset = "0x7BE8B0", VA = "0x1807BFCB0")]
		private static SideType GetSameSideMask(SideType sideType)
		{
			return SideType.NONE;
		}

		// Token: 0x0601008C RID: 65676 RVA: 0x00061AA0 File Offset: 0x0005FCA0
		[Token(Token = "0x601008C")]
		[Address(RVA = "0x7BECC0", Offset = "0x7BD8C0", VA = "0x1807BECC0")]
		public static SideType ConvertSideType(SideType originSide, SideType convertSide)
		{
			return SideType.NONE;
		}

		// Token: 0x0601008D RID: 65677 RVA: 0x00061AB8 File Offset: 0x0005FCB8
		[Token(Token = "0x601008D")]
		[Address(RVA = "0x7BDF50", Offset = "0x7BCB50", VA = "0x1807BDF50")]
		public static bool CheckEntityUnitType(UnitTypeMask mask, Entity entity)
		{
			return default(bool);
		}

		// Token: 0x0601008E RID: 65678 RVA: 0x00061AD0 File Offset: 0x0005FCD0
		[Token(Token = "0x601008E")]
		[Address(RVA = "0x7BF920", Offset = "0x7BE520", VA = "0x1807BF920")]
		public static int GetLayerMask(SideType sideMask)
		{
			return 0;
		}

		// Token: 0x0601008F RID: 65679 RVA: 0x00061AE8 File Offset: 0x0005FCE8
		[Token(Token = "0x601008F")]
		[Address(RVA = "0x7BE1A0", Offset = "0x7BCDA0", VA = "0x1807BE1A0")]
		public static bool CheckProfessionMask(ProfessionCategory mask, ProfessionCategory category, bool passIfMaskIsNone)
		{
			return default(bool);
		}

		// Token: 0x06010090 RID: 65680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010090")]
		[Address(RVA = "0x7BEFF0", Offset = "0x7BDBF0", VA = "0x1807BEFF0")]
		public static string GetBgmEvent(LevelData levelData)
		{
			return null;
		}

		// Token: 0x06010091 RID: 65681 RVA: 0x00061B00 File Offset: 0x0005FD00
		[Token(Token = "0x6010091")]
		public static bool ValidAndAlive<TEntity>(ObjectPtr<TEntity> ptr) where TEntity : Entity
		{
			return default(bool);
		}

		// Token: 0x06010092 RID: 65682 RVA: 0x00061B18 File Offset: 0x0005FD18
		[Token(Token = "0x6010092")]
		public static bool ValidAndAliveOrDying<TEntity>(ObjectPtr<TEntity> ptr) where TEntity : Entity
		{
			return default(bool);
		}

		// Token: 0x06010093 RID: 65683 RVA: 0x00061B30 File Offset: 0x0005FD30
		[Token(Token = "0x6010093")]
		public static bool ValidAndAliveOrDying<TEntity>(PtrObjRef<TEntity> ptrRef) where TEntity : Entity
		{
			return default(bool);
		}

		// Token: 0x06010094 RID: 65684 RVA: 0x00061B48 File Offset: 0x0005FD48
		[Token(Token = "0x6010094")]
		public static bool ValidAndAlive<TEntity>(ObjectPtr<TEntity> ptr, bool ignoreOwnerDead) where TEntity : Entity
		{
			return default(bool);
		}

		// Token: 0x06010095 RID: 65685 RVA: 0x00061B60 File Offset: 0x0005FD60
		[Token(Token = "0x6010095")]
		public static bool ValidAndAlive<TEntity>(PtrObjRef<TEntity> ptrRef, bool ignoreOwnerDead) where TEntity : Entity
		{
			return default(bool);
		}

		// Token: 0x06010096 RID: 65686 RVA: 0x00061B78 File Offset: 0x0005FD78
		[Token(Token = "0x6010096")]
		public static bool InvalidOrNotAlive<TEntity>(ObjectPtr<TEntity> ptr) where TEntity : Entity
		{
			return default(bool);
		}

		// Token: 0x06010097 RID: 65687 RVA: 0x00061B90 File Offset: 0x0005FD90
		[Token(Token = "0x6010097")]
		[Address(RVA = "0x7C0F70", Offset = "0x7BFB70", VA = "0x1807C0F70")]
		public static bool VerifyTarget(Entity target, MotionMask motionMask, EntityCategory category, PlayerSideMask playerSideMask)
		{
			return default(bool);
		}

		// Token: 0x06010098 RID: 65688 RVA: 0x00061BA8 File Offset: 0x0005FDA8
		[Token(Token = "0x6010098")]
		[Address(RVA = "0x7C0E90", Offset = "0x7BFA90", VA = "0x1807C0E90")]
		public static bool VerifyTargetWithPlayerSide(Entity target, MotionMask motionMask, EntityCategory category, PlayerSideMask playerSideMask)
		{
			return default(bool);
		}

		// Token: 0x06010099 RID: 65689 RVA: 0x00061BC0 File Offset: 0x0005FDC0
		[Token(Token = "0x6010099")]
		[Address(RVA = "0x7C03C0", Offset = "0x7BEFC0", VA = "0x1807C03C0")]
		public static FP MergeScale(FP a, FP b)
		{
			return default(FP);
		}

		// Token: 0x0601009A RID: 65690 RVA: 0x00061BD8 File Offset: 0x0005FDD8
		[Token(Token = "0x601009A")]
		[Address(RVA = "0x7C0260", Offset = "0x7BEE60", VA = "0x1807C0260")]
		public static FP MergeScaleMultipleTimes(FP origin, FP scale, int times)
		{
			return default(FP);
		}

		// Token: 0x0601009B RID: 65691 RVA: 0x00061BF0 File Offset: 0x0005FDF0
		[Token(Token = "0x601009B")]
		[Address(RVA = "0x7BFD90", Offset = "0x7BE990", VA = "0x1807BFD90")]
		public static bool IsAbilityHeal(Ability ability)
		{
			return default(bool);
		}

		// Token: 0x0601009C RID: 65692 RVA: 0x00061C08 File Offset: 0x0005FE08
		[Token(Token = "0x601009C")]
		[Address(RVA = "0x7BE560", Offset = "0x7BD160", VA = "0x1807BE560")]
		public static bool CheckTokenAndHostRelationship(Character lhs, Character rhs)
		{
			return default(bool);
		}

		// Token: 0x0601009D RID: 65693 RVA: 0x00061C20 File Offset: 0x0005FE20
		[Token(Token = "0x601009D")]
		[Address(RVA = "0x7BE660", Offset = "0x7BD260", VA = "0x1807BE660")]
		public static bool CheckTokenWithSameHostRelationship(Character lhs, Character rhs)
		{
			return default(bool);
		}

		// Token: 0x0601009E RID: 65694 RVA: 0x00061C38 File Offset: 0x0005FE38
		[Token(Token = "0x601009E")]
		[Address(RVA = "0x7BE470", Offset = "0x7BD070", VA = "0x1807BE470")]
		public static bool CheckTokenAndHostRelationship(Character lhs, Enemy rhs)
		{
			return default(bool);
		}

		// Token: 0x0601009F RID: 65695 RVA: 0x00061C50 File Offset: 0x0005FE50
		[Token(Token = "0x601009F")]
		[Address(RVA = "0x7BE380", Offset = "0x7BCF80", VA = "0x1807BE380")]
		public static bool CheckTokenAndHostRelationship(Enemy lhs, Unit rhs)
		{
			return default(bool);
		}

		// Token: 0x060100A0 RID: 65696 RVA: 0x00061C68 File Offset: 0x0005FE68
		[Token(Token = "0x60100A0")]
		[Address(RVA = "0x7BDB80", Offset = "0x7BC780", VA = "0x1807BDB80")]
		public static Modifier CalculateDamageBySource(Entity source, Entity target, DamageType damageType, SourceApplyWay applyWay, FP atkScale, Modifier.SourceAttackType attackType)
		{
			return default(Modifier);
		}

		// Token: 0x060100A1 RID: 65697 RVA: 0x00061C80 File Offset: 0x0005FE80
		[Token(Token = "0x60100A1")]
		[Address(RVA = "0x7BD540", Offset = "0x7BC140", VA = "0x1807BD540")]
		public static Modifier CalculateDamageByAtkNoSource(FP atk, Entity target, DamageType damageType, SourceApplyWay applyWay, FP atkScale, Modifier.SourceAttackType attackType)
		{
			return default(Modifier);
		}

		// Token: 0x060100A2 RID: 65698 RVA: 0x00061C98 File Offset: 0x0005FE98
		[Token(Token = "0x60100A2")]
		[Address(RVA = "0x7BD290", Offset = "0x7BBE90", VA = "0x1807BD290")]
		public static Modifier CalculateCachedAtkDamageFromProjectile(FP cachedAtk, Entity source, Entity target, DamageType damageType, SourceApplyWay applyWay, FP atkScale, Modifier.SourceAttackType attackType, bool transferSource)
		{
			return default(Modifier);
		}

		// Token: 0x060100A3 RID: 65699 RVA: 0x00061CB0 File Offset: 0x0005FEB0
		[Token(Token = "0x60100A3")]
		[Address(RVA = "0x7BD740", Offset = "0x7BC340", VA = "0x1807BD740")]
		public static Modifier CalculateDamageByAtkWithSourceNoOnCalDmg(FP atk, Entity source, Entity target, DamageType damageType, SourceApplyWay applyWay, FP atkScale, Modifier.SourceAttackType attackType)
		{
			return default(Modifier);
		}

		// Token: 0x060100A4 RID: 65700 RVA: 0x00061CC8 File Offset: 0x0005FEC8
		[Token(Token = "0x60100A4")]
		[Address(RVA = "0x7BD960", Offset = "0x7BC560", VA = "0x1807BD960")]
		public static Modifier CalculateDamageByAtkWithSourceOnCalDmg(FP atk, Entity source, Entity target, DamageType damageType, SourceApplyWay applyWay, FP atkScale, Modifier.SourceAttackType attackType)
		{
			return default(Modifier);
		}

		// Token: 0x060100A5 RID: 65701 RVA: 0x00061CE0 File Offset: 0x0005FEE0
		[Token(Token = "0x60100A5")]
		[Address(RVA = "0x7BDEE0", Offset = "0x7BCAE0", VA = "0x1807BDEE0")]
		public static bool CheckElementModifierValid(Entity target)
		{
			return default(bool);
		}

		// Token: 0x060100A6 RID: 65702 RVA: 0x00061CF8 File Offset: 0x0005FEF8
		[Token(Token = "0x60100A6")]
		[Address(RVA = "0x7C01A0", Offset = "0x7BEDA0", VA = "0x1807C01A0")]
		public static int LimitMaxNumToBlockCnt(int maxNum, int blockNum, bool allowZeroBlockCntLimit)
		{
			return 0;
		}

		// Token: 0x060100A7 RID: 65703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100A7")]
		[Address(RVA = "0x7BEDD0", Offset = "0x7BD9D0", VA = "0x1807BEDD0")]
		[Obsolete("DO NOT USE THIS METHOD ANYMORE!!!")]
		public static Tween Deprecated_PlayTweenInBattle(this Tween tween)
		{
			return null;
		}

		// Token: 0x060100A8 RID: 65704 RVA: 0x00061D10 File Offset: 0x0005FF10
		[Token(Token = "0x60100A8")]
		[Address(RVA = "0x7BFEC0", Offset = "0x7BEAC0", VA = "0x1807BFEC0")]
		public static bool IsCharacter(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x060100A9 RID: 65705 RVA: 0x00061D28 File Offset: 0x0005FF28
		[Token(Token = "0x60100A9")]
		[Address(RVA = "0x7BFA10", Offset = "0x7BE610", VA = "0x1807BFA10")]
		public static MapLayer GetMapLayerFromWorldPosition(Vector3 worldPosition)
		{
			return MapLayer.LAYER_A;
		}

		// Token: 0x060100AA RID: 65706 RVA: 0x00061D40 File Offset: 0x0005FF40
		[Token(Token = "0x60100AA")]
		[Address(RVA = "0x7C06F0", Offset = "0x7BF2F0", VA = "0x1807C06F0")]
		public static bool TryParseGridPosition(string posStr, out GridPosition position)
		{
			return default(bool);
		}

		// Token: 0x060100AB RID: 65707 RVA: 0x00061D58 File Offset: 0x0005FF58
		[Token(Token = "0x60100AB")]
		[Address(RVA = "0x7C0950", Offset = "0x7BF550", VA = "0x1807C0950")]
		public static bool TryParseVector2Position(string posStr, out Vector2 position)
		{
			return default(bool);
		}

		// Token: 0x060100AC RID: 65708 RVA: 0x00061D70 File Offset: 0x0005FF70
		[Token(Token = "0x60100AC")]
		[Address(RVA = "0x7C0BC0", Offset = "0x7BF7C0", VA = "0x1807C0BC0")]
		public static bool TryParseVector3(string inputStr, out Vector3 output)
		{
			return default(bool);
		}

		// Token: 0x060100AD RID: 65709 RVA: 0x00061D88 File Offset: 0x0005FF88
		[Token(Token = "0x60100AD")]
		[Address(RVA = "0x7C05B0", Offset = "0x7BF1B0", VA = "0x1807C05B0")]
		public static bool TryHookEffect(EffectReplacePair[] replaceEffectPairs, string originEffectKey, out string newEffectKey)
		{
			return default(bool);
		}

		// Token: 0x060100AE RID: 65710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100AE")]
		[Address(RVA = "0x7BF600", Offset = "0x7BE200", VA = "0x1807BF600")]
		public static List<LevelData.EnemyDataDbReference> GetEnemyDbRefListFromTalentData(TalentData talentData)
		{
			return null;
		}

		// Token: 0x060100AF RID: 65711 RVA: 0x00061DA0 File Offset: 0x0005FFA0
		[Token(Token = "0x60100AF")]
		[Address(RVA = "0x7BF260", Offset = "0x7BDE60", VA = "0x1807BF260")]
		public static Vector2 GetDirectionByProgress(Vector2 startDir, Vector2 endDir, float progress)
		{
			return default(Vector2);
		}

		// Token: 0x060100B0 RID: 65712 RVA: 0x00061DB8 File Offset: 0x0005FFB8
		[Token(Token = "0x60100B0")]
		[Address(RVA = "0x7C04A0", Offset = "0x7BF0A0", VA = "0x1807C04A0")]
		public static Vector2 NormalizeSafe(Vector2 dir)
		{
			return default(Vector2);
		}

		// Token: 0x060100B1 RID: 65713 RVA: 0x00061DD0 File Offset: 0x0005FFD0
		[Token(Token = "0x60100B1")]
		[Address(RVA = "0x7BEFA0", Offset = "0x7BDBA0", VA = "0x1807BEFA0")]
		public static int GenRandomSeed()
		{
			return 0;
		}

		// Token: 0x060100B2 RID: 65714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100B2")]
		public static string CompressToBase64<T>(T obj)
		{
			return null;
		}

		// Token: 0x060100B3 RID: 65715 RVA: 0x00061DE8 File Offset: 0x0005FFE8
		[Token(Token = "0x60100B3")]
		public static bool DecompressBase64<T>(string data, out T obj)
		{
			return default(bool);
		}

		// Token: 0x060100B4 RID: 65716 RVA: 0x00061E00 File Offset: 0x00060000
		[Token(Token = "0x60100B4")]
		[Address(RVA = "0x7BE250", Offset = "0x7BCE50", VA = "0x1807BE250")]
		public static bool CheckTargetWithinBlockRange(Entity target, Character sourceChr, bool isRangeShrink = true)
		{
			return default(bool);
		}

		// Token: 0x060100B5 RID: 65717 RVA: 0x00061E18 File Offset: 0x00060018
		[Token(Token = "0x60100B5")]
		[Address(RVA = "0x7BDE20", Offset = "0x7BCA20", VA = "0x1807BDE20")]
		public static float CalculatePullAttenuationFactor(Vector2 offset, float totalDistance)
		{
			return 0f;
		}

		// Token: 0x060100B6 RID: 65718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100B6")]
		[Address(RVA = "0x7BEE60", Offset = "0x7BDA60", VA = "0x1807BEE60")]
		public static string EncryptFinishBattleSignature(string battleId)
		{
			return null;
		}

		// Token: 0x060100B7 RID: 65719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100B7")]
		[Address(RVA = "0x7BE760", Offset = "0x7BD360", VA = "0x1807BE760")]
		public static string ComposeBattleRoundFinishData(bool isGiveUp, PlayerBattleRank battleRank, CommonFinishBattleRequest.BattleData battleData)
		{
			return null;
		}

		// Token: 0x060100B8 RID: 65720 RVA: 0x00061E30 File Offset: 0x00060030
		[Token(Token = "0x60100B8")]
		[Address(RVA = "0x7C0050", Offset = "0x7BEC50", VA = "0x1807C0050")]
		public static bool IsRoguelikeGameType()
		{
			return default(bool);
		}

		// Token: 0x04011D5A RID: 73050
		[Token(Token = "0x4011D5A")]
		private const float BLOCK_RANGE_RADIUS_SHRINK = 0.05f;

		// Token: 0x04011D5B RID: 73051
		[Token(Token = "0x4011D5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetOppositeSideMask;

		// Token: 0x04011D5C RID: 73052
		[Token(Token = "0x4011D5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSameSideMask;

		// Token: 0x04011D5D RID: 73053
		[Token(Token = "0x4011D5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ConvertSideType;

		// Token: 0x04011D5E RID: 73054
		[Token(Token = "0x4011D5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckEntityUnitType;

		// Token: 0x04011D5F RID: 73055
		[Token(Token = "0x4011D5F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetLayerMask;

		// Token: 0x04011D60 RID: 73056
		[Token(Token = "0x4011D60")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckProfessionMask;

		// Token: 0x04011D61 RID: 73057
		[Token(Token = "0x4011D61")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetBgmEvent;

		// Token: 0x04011D62 RID: 73058
		[Token(Token = "0x4011D62")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ValidAndAlive;

		// Token: 0x04011D63 RID: 73059
		[Token(Token = "0x4011D63")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ValidAndAliveOrDying;

		// Token: 0x04011D64 RID: 73060
		[Token(Token = "0x4011D64")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1_ValidAndAliveOrDying;

		// Token: 0x04011D65 RID: 73061
		[Token(Token = "0x4011D65")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix1_ValidAndAlive;

		// Token: 0x04011D66 RID: 73062
		[Token(Token = "0x4011D66")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix2_ValidAndAlive;

		// Token: 0x04011D67 RID: 73063
		[Token(Token = "0x4011D67")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_InvalidOrNotAlive;

		// Token: 0x04011D68 RID: 73064
		[Token(Token = "0x4011D68")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_VerifyTarget;

		// Token: 0x04011D69 RID: 73065
		[Token(Token = "0x4011D69")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_VerifyTargetWithPlayerSide;

		// Token: 0x04011D6A RID: 73066
		[Token(Token = "0x4011D6A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_MergeScale;

		// Token: 0x04011D6B RID: 73067
		[Token(Token = "0x4011D6B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_MergeScaleMultipleTimes;

		// Token: 0x04011D6C RID: 73068
		[Token(Token = "0x4011D6C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_IsAbilityHeal;

		// Token: 0x04011D6D RID: 73069
		[Token(Token = "0x4011D6D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CheckTokenAndHostRelationship;

		// Token: 0x04011D6E RID: 73070
		[Token(Token = "0x4011D6E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CheckTokenWithSameHostRelationship;

		// Token: 0x04011D6F RID: 73071
		[Token(Token = "0x4011D6F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix1_CheckTokenAndHostRelationship;

		// Token: 0x04011D70 RID: 73072
		[Token(Token = "0x4011D70")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix2_CheckTokenAndHostRelationship;

		// Token: 0x04011D71 RID: 73073
		[Token(Token = "0x4011D71")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CalculateDamageBySource;

		// Token: 0x04011D72 RID: 73074
		[Token(Token = "0x4011D72")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CalculateDamageByAtkNoSource;

		// Token: 0x04011D73 RID: 73075
		[Token(Token = "0x4011D73")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_CalculateCachedAtkDamageFromProjectile;

		// Token: 0x04011D74 RID: 73076
		[Token(Token = "0x4011D74")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_CalculateDamageByAtkWithSourceNoOnCalDmg;

		// Token: 0x04011D75 RID: 73077
		[Token(Token = "0x4011D75")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_CalculateDamageByAtkWithSourceOnCalDmg;

		// Token: 0x04011D76 RID: 73078
		[Token(Token = "0x4011D76")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_CheckElementModifierValid;

		// Token: 0x04011D77 RID: 73079
		[Token(Token = "0x4011D77")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_LimitMaxNumToBlockCnt;

		// Token: 0x04011D78 RID: 73080
		[Token(Token = "0x4011D78")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_Deprecated_PlayTweenInBattle;

		// Token: 0x04011D79 RID: 73081
		[Token(Token = "0x4011D79")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_IsCharacter;

		// Token: 0x04011D7A RID: 73082
		[Token(Token = "0x4011D7A")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetMapLayerFromWorldPosition;

		// Token: 0x04011D7B RID: 73083
		[Token(Token = "0x4011D7B")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_TryParseGridPosition;

		// Token: 0x04011D7C RID: 73084
		[Token(Token = "0x4011D7C")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_TryParseVector2Position;

		// Token: 0x04011D7D RID: 73085
		[Token(Token = "0x4011D7D")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_TryParseVector3;

		// Token: 0x04011D7E RID: 73086
		[Token(Token = "0x4011D7E")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_TryHookEffect;

		// Token: 0x04011D7F RID: 73087
		[Token(Token = "0x4011D7F")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GetEnemyDbRefListFromTalentData;

		// Token: 0x04011D80 RID: 73088
		[Token(Token = "0x4011D80")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_GetDirectionByProgress;

		// Token: 0x04011D81 RID: 73089
		[Token(Token = "0x4011D81")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_NormalizeSafe;

		// Token: 0x04011D82 RID: 73090
		[Token(Token = "0x4011D82")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GenRandomSeed;

		// Token: 0x04011D83 RID: 73091
		[Token(Token = "0x4011D83")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_CompressToBase64;

		// Token: 0x04011D84 RID: 73092
		[Token(Token = "0x4011D84")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_DecompressBase64;

		// Token: 0x04011D85 RID: 73093
		[Token(Token = "0x4011D85")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_CheckTargetWithinBlockRange;

		// Token: 0x04011D86 RID: 73094
		[Token(Token = "0x4011D86")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_CalculatePullAttenuationFactor;

		// Token: 0x04011D87 RID: 73095
		[Token(Token = "0x4011D87")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_EncryptFinishBattleSignature;

		// Token: 0x04011D88 RID: 73096
		[Token(Token = "0x4011D88")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_ComposeBattleRoundFinishData;

		// Token: 0x04011D89 RID: 73097
		[Token(Token = "0x4011D89")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_IsRoguelikeGameType;
	}
}
