using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Effects;
using Torappu.CharWord;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023ED RID: 9197
	[Token(Token = "0x20023ED")]
	public class BattleAudioLoader : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600EAE0 RID: 60128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE0")]
		[Address(RVA = "0x603D70", Offset = "0x602970", VA = "0x180603D70")]
		public void PreloadOthers(LevelData levelData)
		{
		}

		// Token: 0x0600EAE1 RID: 60129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE1")]
		[Address(RVA = "0x6035E0", Offset = "0x6021E0", VA = "0x1806035E0")]
		public void PreloadCustomTrigger(string subSignal)
		{
		}

		// Token: 0x0600EAE2 RID: 60130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE2")]
		[Address(RVA = "0x6041E0", Offset = "0x602DE0", VA = "0x1806041E0")]
		public void PreloadProjectile(string projectileId)
		{
		}

		// Token: 0x0600EAE3 RID: 60131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE3")]
		[Address(RVA = "0x602E30", Offset = "0x601A30", VA = "0x180602E30")]
		public void PreloadAbility(string abilityId)
		{
		}

		// Token: 0x0600EAE4 RID: 60132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE4")]
		[Address(RVA = "0x603480", Offset = "0x602080", VA = "0x180603480")]
		public void PreloadCharacter(VoiceQuery voiceQuery, Character character)
		{
		}

		// Token: 0x0600EAE5 RID: 60133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE5")]
		[Address(RVA = "0x604BD0", Offset = "0x6037D0", VA = "0x180604BD0")]
		public void PreloadUnit(string unitId, string tmplId, Unit unit)
		{
		}

		// Token: 0x0600EAE6 RID: 60134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE6")]
		[Address(RVA = "0x6038B0", Offset = "0x6024B0", VA = "0x1806038B0")]
		public void PreloadEnemy(string enemyId, Enemy enemy, bool isBoss)
		{
		}

		// Token: 0x0600EAE7 RID: 60135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE7")]
		[Address(RVA = "0x604310", Offset = "0x602F10", VA = "0x180604310")]
		public void PreloadSkill(string skillId, BasicSkill skill)
		{
		}

		// Token: 0x0600EAE8 RID: 60136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE8")]
		[Address(RVA = "0x6031F0", Offset = "0x601DF0", VA = "0x1806031F0")]
		public void PreloadBuffs(IList<BuffData> buffs)
		{
		}

		// Token: 0x0600EAE9 RID: 60137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE9")]
		[Address(RVA = "0x602F60", Offset = "0x601B60", VA = "0x180602F60")]
		public void PreloadActionNodes(IList<ActionNode> actionNodes)
		{
		}

		// Token: 0x0600EAEA RID: 60138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAEA")]
		[Address(RVA = "0x603680", Offset = "0x602280", VA = "0x180603680")]
		public void PreloadEffect(Effect effect)
		{
		}

		// Token: 0x0600EAEB RID: 60139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAEB")]
		[Address(RVA = "0x603A60", Offset = "0x602660", VA = "0x180603A60")]
		public void PreloadEnvSystem(GlobalEnvSystem envSystem)
		{
		}

		// Token: 0x0600EAEC RID: 60140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAEC")]
		[Address(RVA = "0x6046E0", Offset = "0x6032E0", VA = "0x1806046E0")]
		public void PreloadSkin(UnitAnimator animator)
		{
		}

		// Token: 0x0600EAED RID: 60141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAED")]
		[Address(RVA = "0x603C80", Offset = "0x602880", VA = "0x180603C80")]
		public void PreloadOperaRes(List<string> audioList)
		{
		}

		// Token: 0x0600EAEE RID: 60142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAEE")]
		[Address(RVA = "0x604F20", Offset = "0x603B20", VA = "0x180604F20")]
		public void UnloadPreloadedAssets()
		{
		}

		// Token: 0x0600EAEF RID: 60143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EAEF")]
		[Address(RVA = "0x604E70", Offset = "0x603A70", VA = "0x180604E70")]
		public IEnumerator UnloadOtherPersistTags()
		{
			return null;
		}

		// Token: 0x0600EAF0 RID: 60144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAF0")]
		[Address(RVA = "0x605130", Offset = "0x603D30", VA = "0x180605130")]
		private void _PreloadSignal(string signal, string subSignal)
		{
		}

		// Token: 0x0600EAF1 RID: 60145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAF1")]
		[Address(RVA = "0x605000", Offset = "0x603C00", VA = "0x180605000")]
		private void _PreloadBuffSource(IBuffSource buffSource)
		{
		}

		// Token: 0x0600EAF2 RID: 60146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAF2")]
		[Address(RVA = "0x605210", Offset = "0x603E10", VA = "0x180605210")]
		private void _PreloadSpineEventSignal(string signal, string id, Unit unit)
		{
		}

		// Token: 0x0600EAF3 RID: 60147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAF3")]
		[Address(RVA = "0x602D00", Offset = "0x601900", VA = "0x180602D00")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600EAF4 RID: 60148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAF4")]
		[Address(RVA = "0x605860", Offset = "0x604460", VA = "0x180605860")]
		public BattleAudioLoader()
		{
		}

		// Token: 0x0401035F RID: 66399
		[Token(Token = "0x401035F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CharWordShowType[] BATTLE_CHARWORD_TYPES;

		// Token: 0x04010360 RID: 66400
		[Token(Token = "0x4010360")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string[] _extraUISignals;

		// Token: 0x04010361 RID: 66401
		[Token(Token = "0x4010361")]
		[FieldOffset(Offset = "0x20")]
		private List<string> m_sharedList;

		// Token: 0x04010362 RID: 66402
		[Token(Token = "0x4010362")]
		[FieldOffset(Offset = "0x28")]
		private List<Ability> m_sharedAbilityList;

		// Token: 0x04010363 RID: 66403
		[Token(Token = "0x4010363")]
		[FieldOffset(Offset = "0x30")]
		private List<BuffData> m_sharedBuffList;

		// Token: 0x04010364 RID: 66404
		[Token(Token = "0x4010364")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreloadOthers;

		// Token: 0x04010365 RID: 66405
		[Token(Token = "0x4010365")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreloadCustomTrigger;

		// Token: 0x04010366 RID: 66406
		[Token(Token = "0x4010366")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreloadProjectile;

		// Token: 0x04010367 RID: 66407
		[Token(Token = "0x4010367")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreloadAbility;

		// Token: 0x04010368 RID: 66408
		[Token(Token = "0x4010368")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PreloadCharacter;

		// Token: 0x04010369 RID: 66409
		[Token(Token = "0x4010369")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PreloadUnit;

		// Token: 0x0401036A RID: 66410
		[Token(Token = "0x401036A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PreloadEnemy;

		// Token: 0x0401036B RID: 66411
		[Token(Token = "0x401036B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_PreloadSkill;

		// Token: 0x0401036C RID: 66412
		[Token(Token = "0x401036C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_PreloadBuffs;

		// Token: 0x0401036D RID: 66413
		[Token(Token = "0x401036D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_PreloadActionNodes;

		// Token: 0x0401036E RID: 66414
		[Token(Token = "0x401036E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_PreloadEffect;

		// Token: 0x0401036F RID: 66415
		[Token(Token = "0x401036F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_PreloadEnvSystem;

		// Token: 0x04010370 RID: 66416
		[Token(Token = "0x4010370")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_PreloadSkin;

		// Token: 0x04010371 RID: 66417
		[Token(Token = "0x4010371")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_PreloadOperaRes;

		// Token: 0x04010372 RID: 66418
		[Token(Token = "0x4010372")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_UnloadPreloadedAssets;

		// Token: 0x04010373 RID: 66419
		[Token(Token = "0x4010373")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UnloadOtherPersistTags;

		// Token: 0x04010374 RID: 66420
		[Token(Token = "0x4010374")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__PreloadSignal;

		// Token: 0x04010375 RID: 66421
		[Token(Token = "0x4010375")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__PreloadBuffSource;

		// Token: 0x04010376 RID: 66422
		[Token(Token = "0x4010376")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__PreloadSpineEventSignal;

		// Token: 0x04010377 RID: 66423
		[Token(Token = "0x4010377")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04010378 RID: 66424
		[Token(Token = "0x4010378")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
