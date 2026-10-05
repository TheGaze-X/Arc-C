using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022BB RID: 8891
	[Token(Token = "0x20022BB")]
	public class Act33SideManager : GlobalEnvSystem.EnvManager, IBuffSource, IHotfixable, IAudioSource
	{
		// Token: 0x0600DF96 RID: 57238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF96")]
		[Address(RVA = "0x364C090", Offset = "0x364AC90", VA = "0x18364C090", Slot = "7")]
		public override void Init(GlobalEnvSystem owner)
		{
		}

		// Token: 0x0600DF97 RID: 57239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF97")]
		[Address(RVA = "0x364BEB0", Offset = "0x364AAB0", VA = "0x18364BEB0", Slot = "10")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600DF98 RID: 57240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF98")]
		[Address(RVA = "0x364D330", Offset = "0x364BF30", VA = "0x18364D330", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DF99 RID: 57241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF99")]
		[Address(RVA = "0x364C570", Offset = "0x364B170", VA = "0x18364C570")]
		public void ModifyRopeTileDeployableValue(Tile tile, int value)
		{
		}

		// Token: 0x0600DF9A RID: 57242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF9A")]
		[Address(RVA = "0x364A360", Offset = "0x3648F60", VA = "0x18364A360")]
		public void AddManagedProjectile(Character character, Projectile projectile)
		{
		}

		// Token: 0x0600DF9B RID: 57243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF9B")]
		[Address(RVA = "0x364BA00", Offset = "0x364A600", VA = "0x18364BA00")]
		public void FinishManagedProjectile(Character character, string projectileKey)
		{
		}

		// Token: 0x0600DF9C RID: 57244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF9C")]
		[Address(RVA = "0x364ED30", Offset = "0x364D930", VA = "0x18364ED30")]
		private void _CreateProjectile(string projectileKey, Character source, Character target, bool addManaged = true)
		{
		}

		// Token: 0x0600DF9D RID: 57245 RVA: 0x000513A8 File Offset: 0x0004F5A8
		[Token(Token = "0x600DF9D")]
		[Address(RVA = "0x364E8D0", Offset = "0x364D4D0", VA = "0x18364E8D0")]
		private bool _CreateProjectileForDummy(string projectileKey, Character source, Character target)
		{
			return default(bool);
		}

		// Token: 0x0600DF9E RID: 57246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF9E")]
		[Address(RVA = "0x364EB10", Offset = "0x364D710", VA = "0x18364EB10")]
		private void _CreateProjectileUseSourceAsProjectileSource(string projectileKey, Character source, Character target)
		{
		}

		// Token: 0x0600DF9F RID: 57247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF9F")]
		[Address(RVA = "0x364F2B0", Offset = "0x364DEB0", VA = "0x18364F2B0")]
		private void _RefreshTiles(Character character, int value)
		{
		}

		// Token: 0x0600DFA0 RID: 57248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFA0")]
		[Address(RVA = "0x364EF70", Offset = "0x364DB70", VA = "0x18364EF70")]
		private void _ModifyRopeCnt(Character character, bool isminus = false)
		{
		}

		// Token: 0x0600DFA1 RID: 57249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFA1")]
		[Address(RVA = "0x364B850", Offset = "0x364A450", VA = "0x18364B850")]
		public void CutRope(Character source)
		{
		}

		// Token: 0x0600DFA2 RID: 57250 RVA: 0x000513C0 File Offset: 0x0004F5C0
		[Token(Token = "0x600DFA2")]
		[Address(RVA = "0x364BFA0", Offset = "0x364ABA0", VA = "0x18364BFA0")]
		public int GetCharaterCurrentRopeCnt(Character character)
		{
			return 0;
		}

		// Token: 0x0600DFA3 RID: 57251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFA3")]
		[Address(RVA = "0x364A9F0", Offset = "0x36495F0", VA = "0x18364A9F0")]
		public void CollectCharactersWithRope(Character target)
		{
		}

		// Token: 0x0600DFA4 RID: 57252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFA4")]
		[Address(RVA = "0x364E560", Offset = "0x364D160", VA = "0x18364E560")]
		private void _CollectCharactersWithRope(Character target)
		{
		}

		// Token: 0x0600DFA5 RID: 57253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFA5")]
		[Address(RVA = "0x364A5C0", Offset = "0x36491C0", VA = "0x18364A5C0")]
		public void ApplyDamageCharactersWithRope(FP atk, Entity source, FP atkscale, DamageType damageType)
		{
		}

		// Token: 0x0600DFA6 RID: 57254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFA6")]
		[Address(RVA = "0x364A7E0", Offset = "0x36493E0", VA = "0x18364A7E0")]
		public void ApplyElementDamageCharactersWithRope(FP fixedEpDamage, Entity source, ElementType elementDamageType)
		{
		}

		// Token: 0x0600DFA7 RID: 57255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFA7")]
		[Address(RVA = "0x364E120", Offset = "0x364CD20", VA = "0x18364E120")]
		private void _ApplyDamageModifier(FP atk, Entity source, Character target, DamageType damageType, FP atkScale)
		{
		}

		// Token: 0x0600DFA8 RID: 57256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFA8")]
		[Address(RVA = "0x364E340", Offset = "0x364CF40", VA = "0x18364E340")]
		private void _ApplyElementDamageModifier(FP fixedEpDamage, Entity source, Character target, ElementType elementDamageType)
		{
		}

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x0600DFA9 RID: 57257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C14")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600DFA9")]
			[Address(RVA = "0x364F7D0", Offset = "0x364E3D0", VA = "0x18364F7D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600DFAA RID: 57258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFAA")]
		[Address(RVA = "0x364C6C0", Offset = "0x364B2C0", VA = "0x18364C6C0")]
		public void OnDummyLocateTile(object arg)
		{
		}

		// Token: 0x0600DFAB RID: 57259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFAB")]
		[Address(RVA = "0x364D8C0", Offset = "0x364C4C0", VA = "0x18364D8C0")]
		public void RefreshRopeAndTiles(object arg)
		{
		}

		// Token: 0x0600DFAC RID: 57260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFAC")]
		[Address(RVA = "0x364AAC0", Offset = "0x36496C0", VA = "0x18364AAC0")]
		public void CreateRopeOnCharacterBorn(object arg)
		{
		}

		// Token: 0x0600DFAD RID: 57261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFAD")]
		[Address(RVA = "0x364BDF0", Offset = "0x364A9F0", VA = "0x18364BDF0", Slot = "16")]
		public void GatherAudio(List<string> results)
		{
		}

		// Token: 0x0600DFAE RID: 57262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFAE")]
		[Address(RVA = "0x364F4D0", Offset = "0x364E0D0", VA = "0x18364F4D0")]
		public Act33SideManager()
		{
		}

		// Token: 0x0600DFB0 RID: 57264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFB0")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600DFB1 RID: 57265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFB1")]
		[Address(RVA = "0x3648080", Offset = "0x3646C80", VA = "0x183648080")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0600DFB2 RID: 57266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFB2")]
		[Address(RVA = "0x36480E0", Offset = "0x3646CE0", VA = "0x1836480E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600DFB3 RID: 57267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DFB3")]
		[Address(RVA = "0x3642D70", Offset = "0x3641970", VA = "0x183642D70")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0400F309 RID: 62217
		[Token(Token = "0x400F309")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string EVENT_SYSTEM_KEY;

		// Token: 0x0400F30A RID: 62218
		[Token(Token = "0x400F30A")]
		private const string RAROPE_TILE_KEY = "tile_rarope";

		// Token: 0x0400F30B RID: 62219
		[Token(Token = "0x400F30B")]
		private const string MEROPE_TILE_KEY = "tile_merope";

		// Token: 0x0400F30C RID: 62220
		[Token(Token = "0x400F30C")]
		private const string ROPE_LINE_PROJECTILEKEY = "projectile_act33side_rope_line";

		// Token: 0x0400F30D RID: 62221
		[Token(Token = "0x400F30D")]
		private const string ROPE_HIT_LINE_PROJECTILEKEY = "projectile_act33side_rope_hit_line";

		// Token: 0x0400F30E RID: 62222
		[Token(Token = "0x400F30E")]
		private const string ROPE_DUMMY_EFFECT_PROJECTILEKEY = "projectile_act33side_rope_line_dummy";

		// Token: 0x0400F30F RID: 62223
		[Token(Token = "0x400F30F")]
		private const string ROPE_HIT_LINE_PROJECTILE_FOR_GAMECITY = "projectile_act33side_rope_hit_line_gamecity";

		// Token: 0x0400F310 RID: 62224
		[Token(Token = "0x400F310")]
		private const string ROPE_LINE_CREATE_AUDIO = "create_rope";

		// Token: 0x0400F311 RID: 62225
		[Token(Token = "0x400F311")]
		private const string MLYSS_TOKEN_KEY = "token_10030_mlyss_wtrman";

		// Token: 0x0400F312 RID: 62226
		[Token(Token = "0x400F312")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _rangeId;

		// Token: 0x0400F313 RID: 62227
		[Token(Token = "0x400F313")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected FilterUtil.FilterType _postFilter;

		// Token: 0x0400F314 RID: 62228
		[Token(Token = "0x400F314")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _ropeMaxCnt;

		// Token: 0x0400F315 RID: 62229
		[Token(Token = "0x400F315")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BuffData _breakRopebuff;

		// Token: 0x0400F316 RID: 62230
		[Token(Token = "0x400F316")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Ability _projectileAbility;

		// Token: 0x0400F317 RID: 62231
		[Token(Token = "0x400F317")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TargetOptions _targetOptions;

		// Token: 0x0400F318 RID: 62232
		[Token(Token = "0x400F318")]
		[FieldOffset(Offset = "0xA8")]
		private PeriodicTimer m_createHitLineTimer;

		// Token: 0x0400F319 RID: 62233
		[Token(Token = "0x400F319")]
		[FieldOffset(Offset = "0xB0")]
		private PeriodicTimer m_createHitLineGamecityTimer;

		// Token: 0x0400F31A RID: 62234
		[Token(Token = "0x400F31A")]
		[FieldOffset(Offset = "0xB8")]
		private float m_createHitLineInterval;

		// Token: 0x0400F31B RID: 62235
		[Token(Token = "0x400F31B")]
		[FieldOffset(Offset = "0xBC")]
		private float m_createHitLineGamecityInterval;

		// Token: 0x0400F31C RID: 62236
		[Token(Token = "0x400F31C")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<Character, List<ObjectPtr<Projectile>>> m_managedProjectiles;

		// Token: 0x0400F31D RID: 62237
		[Token(Token = "0x400F31D")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<Character, Act33SideManager.ropeRelation> m_ropeDict;

		// Token: 0x0400F31E RID: 62238
		[Token(Token = "0x400F31E")]
		[FieldOffset(Offset = "0xD0")]
		private Dictionary<Tile, int> m_ropeTiles;

		// Token: 0x0400F31F RID: 62239
		[Token(Token = "0x400F31F")]
		[FieldOffset(Offset = "0xD8")]
		private List<Character> m_burnedCharacters;

		// Token: 0x0400F320 RID: 62240
		[Token(Token = "0x400F320")]
		[FieldOffset(Offset = "0xE0")]
		private Act33SideManager.Act33SideRopeTileBuildableChecker m_tileBuildableChecker;

		// Token: 0x0400F321 RID: 62241
		[Token(Token = "0x400F321")]
		[FieldOffset(Offset = "0xE8")]
		private Tile m_currentDummyTile;

		// Token: 0x0400F322 RID: 62242
		[Token(Token = "0x400F322")]
		[FieldOffset(Offset = "0xF0")]
		private string m_rangeId;

		// Token: 0x0400F323 RID: 62243
		[Token(Token = "0x400F323")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F324 RID: 62244
		[Token(Token = "0x400F324")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400F325 RID: 62245
		[Token(Token = "0x400F325")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F326 RID: 62246
		[Token(Token = "0x400F326")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ModifyRopeTileDeployableValue;

		// Token: 0x0400F327 RID: 62247
		[Token(Token = "0x400F327")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AddManagedProjectile;

		// Token: 0x0400F328 RID: 62248
		[Token(Token = "0x400F328")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FinishManagedProjectile;

		// Token: 0x0400F329 RID: 62249
		[Token(Token = "0x400F329")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CreateProjectile;

		// Token: 0x0400F32A RID: 62250
		[Token(Token = "0x400F32A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CreateProjectileForDummy;

		// Token: 0x0400F32B RID: 62251
		[Token(Token = "0x400F32B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CreateProjectileUseSourceAsProjectileSource;

		// Token: 0x0400F32C RID: 62252
		[Token(Token = "0x400F32C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RefreshTiles;

		// Token: 0x0400F32D RID: 62253
		[Token(Token = "0x400F32D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ModifyRopeCnt;

		// Token: 0x0400F32E RID: 62254
		[Token(Token = "0x400F32E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CutRope;

		// Token: 0x0400F32F RID: 62255
		[Token(Token = "0x400F32F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetCharaterCurrentRopeCnt;

		// Token: 0x0400F330 RID: 62256
		[Token(Token = "0x400F330")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CollectCharactersWithRope;

		// Token: 0x0400F331 RID: 62257
		[Token(Token = "0x400F331")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CollectCharactersWithRope;

		// Token: 0x0400F332 RID: 62258
		[Token(Token = "0x400F332")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ApplyDamageCharactersWithRope;

		// Token: 0x0400F333 RID: 62259
		[Token(Token = "0x400F333")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ApplyElementDamageCharactersWithRope;

		// Token: 0x0400F334 RID: 62260
		[Token(Token = "0x400F334")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ApplyDamageModifier;

		// Token: 0x0400F335 RID: 62261
		[Token(Token = "0x400F335")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ApplyElementDamageModifier;

		// Token: 0x0400F336 RID: 62262
		[Token(Token = "0x400F336")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F337 RID: 62263
		[Token(Token = "0x400F337")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnDummyLocateTile;

		// Token: 0x0400F338 RID: 62264
		[Token(Token = "0x400F338")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_RefreshRopeAndTiles;

		// Token: 0x0400F339 RID: 62265
		[Token(Token = "0x400F339")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CreateRopeOnCharacterBorn;

		// Token: 0x0400F33A RID: 62266
		[Token(Token = "0x400F33A")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GatherAudio;

		// Token: 0x0400F33B RID: 62267
		[Token(Token = "0x400F33B")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020022BC RID: 8892
		[Token(Token = "0x20022BC")]
		public class ropeRelation
		{
			// Token: 0x0600DFB4 RID: 57268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DFB4")]
			[Address(RVA = "0x13D53A0", Offset = "0x13D3FA0", VA = "0x1813D53A0")]
			public ropeRelation(Character beLockedCharacter, int ropeCnt)
			{
			}

			// Token: 0x17001C15 RID: 7189
			// (get) Token: 0x0600DFB5 RID: 57269 RVA: 0x000513D8 File Offset: 0x0004F5D8
			// (set) Token: 0x0600DFB6 RID: 57270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001C15")]
			public int ropeCnt
			{
				[Token(Token = "0x600DFB5")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600DFB6")]
				[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
				set
				{
				}
			}

			// Token: 0x0400F33C RID: 62268
			[Token(Token = "0x400F33C")]
			[FieldOffset(Offset = "0x10")]
			public Character beLockedCharacter;

			// Token: 0x0400F33D RID: 62269
			[Token(Token = "0x400F33D")]
			[FieldOffset(Offset = "0x18")]
			private int m_ropeCnt;
		}

		// Token: 0x020022BD RID: 8893
		[Token(Token = "0x20022BD")]
		public class Act33SideRopeTileBuildableChecker : ITileBuildableChecker, IHotfixable
		{
			// Token: 0x0600DFB7 RID: 57271 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DFB7")]
			[Address(RVA = "0x365EAA0", Offset = "0x365D6A0", VA = "0x18365EAA0")]
			public Act33SideRopeTileBuildableChecker(Act33SideManager manager)
			{
			}

			// Token: 0x0600DFB8 RID: 57272 RVA: 0x000513F0 File Offset: 0x0004F5F0
			[Token(Token = "0x600DFB8")]
			[Address(RVA = "0x365E6B0", Offset = "0x365D2B0", VA = "0x18365E6B0", Slot = "4")]
			public bool IsCharacterBuildableOnTile(Tile tile, BattleCharacterData sourceData)
			{
				return default(bool);
			}

			// Token: 0x0600DFB9 RID: 57273 RVA: 0x00051408 File Offset: 0x0004F608
			[Token(Token = "0x600DFB9")]
			[Address(RVA = "0x365E980", Offset = "0x365D580", VA = "0x18365E980")]
			private bool _CheckMlyssToken(Character character)
			{
				return default(bool);
			}

			// Token: 0x0400F33E RID: 62270
			[Token(Token = "0x400F33E")]
			[FieldOffset(Offset = "0x10")]
			private Act33SideManager m_manager;

			// Token: 0x0400F33F RID: 62271
			[Token(Token = "0x400F33F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400F340 RID: 62272
			[Token(Token = "0x400F340")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsCharacterBuildableOnTile;

			// Token: 0x0400F341 RID: 62273
			[Token(Token = "0x400F341")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__CheckMlyssToken;
		}
	}
}
