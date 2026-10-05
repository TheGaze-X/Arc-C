using System;
using System.Collections.Generic;
using System.Diagnostics;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Opera;
using UnityEngine;
using UnityEngine.Serialization;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002194 RID: 8596
	[Token(Token = "0x2002194")]
	public class BattleLauncher : SingletonMonoBehaviour<BattleLauncher>, ISingletonNotAutoCreate
	{
		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x0600D4D3 RID: 54483 RVA: 0x0004CF98 File Offset: 0x0004B198
		[Token(Token = "0x170019C6")]
		public bool isRoguelikeDevLocal
		{
			[Token(Token = "0x600D4D3")]
			[Address(RVA = "0x3587B70", Offset = "0x3586770", VA = "0x183587B70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x0600D4D4 RID: 54484 RVA: 0x0004CFB0 File Offset: 0x0004B1B0
		[Token(Token = "0x170019C7")]
		public bool isMultiplayerDevLocal
		{
			[Token(Token = "0x600D4D4")]
			[Address(RVA = "0x3587B10", Offset = "0x3586710", VA = "0x183587B10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x0600D4D5 RID: 54485 RVA: 0x0004CFC8 File Offset: 0x0004B1C8
		[Token(Token = "0x170019C8")]
		public bool IsMultiplayerDevLocalAndEnableAnother
		{
			[Token(Token = "0x600D4D5")]
			[Address(RVA = "0x3587AA0", Offset = "0x35866A0", VA = "0x183587AA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600D4D6 RID: 54486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D4D6")]
		[Address(RVA = "0x3586D50", Offset = "0x3585950", VA = "0x183586D50", Slot = "8")]
		protected virtual LevelData LoadLevelData()
		{
			return null;
		}

		// Token: 0x0600D4D7 RID: 54487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4D7")]
		[Address(RVA = "0x3587150", Offset = "0x3585D50", VA = "0x183587150")]
		private void Start()
		{
		}

		// Token: 0x0600D4D8 RID: 54488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4D8")]
		[Address(RVA = "0x3586C70", Offset = "0x3585870", VA = "0x183586C70")]
		[Conditional("TORAPPU_AIRL_HEADLESS")]
		private static void AIRL_StartGameManually()
		{
		}

		// Token: 0x0600D4D9 RID: 54489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4D9")]
		[Address(RVA = "0x3586B50", Offset = "0x3585750", VA = "0x183586B50")]
		[Conditional("TORAPPU_AIRL")]
		private static void AIRL_InitModuleAndMap(LevelData levelData)
		{
		}

		// Token: 0x0600D4DA RID: 54490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D4DA")]
		[Address(RVA = "0x3587700", Offset = "0x3586300", VA = "0x183587700")]
		private List<BattlePlayerData> _CreateBattlePlayerData()
		{
			return null;
		}

		// Token: 0x0600D4DB RID: 54491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4DB")]
		[Address(RVA = "0x3587070", Offset = "0x3585C70", VA = "0x183587070", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600D4DC RID: 54492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4DC")]
		[Address(RVA = "0x3586CF0", Offset = "0x35858F0", VA = "0x183586CF0")]
		[Conditional("TORAPPU_CE_TEST")]
		private static void CETest_InitModuleAndMap(LevelData levelData)
		{
		}

		// Token: 0x0600D4DD RID: 54493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4DD")]
		[Address(RVA = "0x35876B0", Offset = "0x35862B0", VA = "0x1835876B0")]
		[Conditional("TORAPPU_CE_TEST")]
		private static void _ChangeUI_EditorOnly()
		{
		}

		// Token: 0x0600D4DE RID: 54494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4DE")]
		[Address(RVA = "0x3587990", Offset = "0x3586590", VA = "0x183587990")]
		public BattleLauncher()
		{
		}

		// Token: 0x0400E468 RID: 58472
		[Token(Token = "0x400E468")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("_levelKey")]
		private string _levelId;

		// Token: 0x0400E469 RID: 58473
		[Token(Token = "0x400E469")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextAsset _levelJson;

		// Token: 0x0400E46A RID: 58474
		[Token(Token = "0x400E46A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextAsset _squadJson;

		// Token: 0x0400E46B RID: 58475
		[Token(Token = "0x400E46B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextAsset _runeJson;

		// Token: 0x0400E46C RID: 58476
		[Token(Token = "0x400E46C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private OperaConfig _operaConfig;

		// Token: 0x0400E46D RID: 58477
		[Token(Token = "0x400E46D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Roguelike")]
		[ReadOnly]
		private TextAsset _relicJson;

		// Token: 0x0400E46E RID: 58478
		[Token(Token = "0x400E46E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private LevelData.Difficulty _difficulty;

		// Token: 0x0400E46F RID: 58479
		[Token(Token = "0x400E46F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Obsolete]
		private List<CharacterInst> _slots;

		// Token: 0x0400E470 RID: 58480
		[Token(Token = "0x400E470")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _forceReimportOnStart;

		// Token: 0x0400E471 RID: 58481
		[Token(Token = "0x400E471")]
		[FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool _includeDefaultGraphic;

		// Token: 0x0400E472 RID: 58482
		[Token(Token = "0x400E472")]
		[FieldOffset(Offset = "0x5A")]
		[SerializeField]
		[Tooltip("If this is checked, squad will be loaded from |squadJson| instead of |slots|")]
		private bool _forceUseSquadFile;

		// Token: 0x0400E473 RID: 58483
		[Token(Token = "0x400E473")]
		[FieldOffset(Offset = "0x5B")]
		[SerializeField]
		[Group("AutoReplay")]
		private bool _autoReplay;

		// Token: 0x0400E474 RID: 58484
		[Token(Token = "0x400E474")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("AutoReplay")]
		private string _autoReplayPlugin;

		// Token: 0x0400E475 RID: 58485
		[Token(Token = "0x400E475")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("AutoReplay")]
		private TextAsset _logJson;

		// Token: 0x0400E476 RID: 58486
		[Token(Token = "0x400E476")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Roguelike")]
		[Tooltip("This has been included in online assets and couldn't be removed.")]
		private bool _roguelikeDevLocal;

		// Token: 0x0400E477 RID: 58487
		[Token(Token = "0x400E477")]
		[FieldOffset(Offset = "0x71")]
		[SerializeField]
		[Group("Multiplayer")]
		private bool _multiplayerDevLocal;

		// Token: 0x0400E478 RID: 58488
		[Token(Token = "0x400E478")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Group("Multiplayer")]
		[Inspect("isMultiplayerDevLocal")]
		private PlayerSide _playerSide;

		// Token: 0x0400E479 RID: 58489
		[Token(Token = "0x400E479")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Multiplayer")]
		[Inspect("isMultiplayerDevLocal")]
		private bool _enableAnother;

		// Token: 0x0400E47A RID: 58490
		[Token(Token = "0x400E47A")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[Group("Multiplayer")]
		[Inspect("IsMultiplayerDevLocalAndEnableAnother")]
		private PlayerSide _playerSideAnother;

		// Token: 0x0400E47B RID: 58491
		[Token(Token = "0x400E47B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Multiplayer")]
		[Inspect("IsMultiplayerDevLocalAndEnableAnother")]
		private TextAsset _squadAnotherJson;

		// Token: 0x0400E47C RID: 58492
		[Token(Token = "0x400E47C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Multiplayer")]
		[Inspect("IsMultiplayerDevLocalAndEnableAnother")]
		[Obsolete]
		private List<CharacterInst> _slotsAnother;

		// Token: 0x0400E47D RID: 58493
		[Token(Token = "0x400E47D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isRoguelikeDevLocal;

		// Token: 0x0400E47E RID: 58494
		[Token(Token = "0x400E47E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isMultiplayerDevLocal;

		// Token: 0x0400E47F RID: 58495
		[Token(Token = "0x400E47F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_IsMultiplayerDevLocalAndEnableAnother;

		// Token: 0x0400E480 RID: 58496
		[Token(Token = "0x400E480")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadLevelData;

		// Token: 0x0400E481 RID: 58497
		[Token(Token = "0x400E481")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400E482 RID: 58498
		[Token(Token = "0x400E482")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AIRL_StartGameManually;

		// Token: 0x0400E483 RID: 58499
		[Token(Token = "0x400E483")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AIRL_InitModuleAndMap;

		// Token: 0x0400E484 RID: 58500
		[Token(Token = "0x400E484")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CreateBattlePlayerData;

		// Token: 0x0400E485 RID: 58501
		[Token(Token = "0x400E485")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400E486 RID: 58502
		[Token(Token = "0x400E486")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CETest_InitModuleAndMap;

		// Token: 0x0400E487 RID: 58503
		[Token(Token = "0x400E487")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ChangeUI_EditorOnly;

		// Token: 0x0400E488 RID: 58504
		[Token(Token = "0x400E488")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
