using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Resource;
using Torappu.UI;
using Torappu.UI.Atlas;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200214D RID: 8525
	[Token(Token = "0x200214D")]
	public class ArtCollection : SingletonMonoBehaviour<ArtCollection>, ILoadAsset
	{
		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x0600D1BA RID: 53690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700191D")]
		public BaseAssetLoader.Assets assetLoader
		{
			[Token(Token = "0x600D1BA")]
			[Address(RVA = "0x3527A10", Offset = "0x3526610", VA = "0x183527A10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x0600D1BB RID: 53691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700191E")]
		public ILoadAsset sharedAssetLoader
		{
			[Token(Token = "0x600D1BB")]
			[Address(RVA = "0x3527AA0", Offset = "0x35266A0", VA = "0x183527AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D1BC RID: 53692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1BC")]
		[Address(RVA = "0x3525620", Offset = "0x3524220", VA = "0x183525620")]
		public Sprite GetAvatar(BattleCharacterData data)
		{
			return null;
		}

		// Token: 0x0600D1BD RID: 53693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1BD")]
		[Address(RVA = "0x35257A0", Offset = "0x35243A0", VA = "0x1835257A0")]
		public Sprite GetAvatar(string avatarId)
		{
			return null;
		}

		// Token: 0x0600D1BE RID: 53694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1BE")]
		[Address(RVA = "0x35261E0", Offset = "0x3524DE0", VA = "0x1835261E0")]
		public Sprite GetSubProfessionlIcon(string subProfessionId, out bool isDefaultIcon)
		{
			return null;
		}

		// Token: 0x0600D1BF RID: 53695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1BF")]
		[Address(RVA = "0x3525F90", Offset = "0x3524B90", VA = "0x183525F90")]
		public Sprite GetSkillIcon(ISkillData skillData)
		{
			return null;
		}

		// Token: 0x0600D1C0 RID: 53696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1C0")]
		[Address(RVA = "0x3525DC0", Offset = "0x35249C0", VA = "0x183525DC0")]
		public Sprite GetEnemyIcon(string enemyId)
		{
			return null;
		}

		// Token: 0x0600D1C1 RID: 53697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1C1")]
		[Address(RVA = "0x3525CA0", Offset = "0x35248A0", VA = "0x183525CA0")]
		public Sprite GetEnemyBossHpIcon(string enemyId)
		{
			return null;
		}

		// Token: 0x0600D1C2 RID: 53698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1C2")]
		[Address(RVA = "0x3525EF0", Offset = "0x3524AF0", VA = "0x183525EF0")]
		public Image GetIllust(BattleCharacterData data)
		{
			return null;
		}

		// Token: 0x0600D1C3 RID: 53699 RVA: 0x0004B918 File Offset: 0x00049B18
		[Token(Token = "0x600D1C3")]
		[Address(RVA = "0x35270F0", Offset = "0x3525CF0", VA = "0x1835270F0")]
		public bool TryGetEquipDirectionSprite(UniEquipData data, out Sprite sprite)
		{
			return default(bool);
		}

		// Token: 0x0600D1C4 RID: 53700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1C4")]
		[Address(RVA = "0x35268C0", Offset = "0x35254C0", VA = "0x1835268C0")]
		public Sprite LoadEtIcon(string iconId)
		{
			return null;
		}

		// Token: 0x0600D1C5 RID: 53701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1C5")]
		[Address(RVA = "0x3527870", Offset = "0x3526470", VA = "0x183527870")]
		private static Sprite _TryLoadSpriteFromAutoPackHub(string hubPath, string spriteId, BaseAssetLoader.Assets loader)
		{
			return null;
		}

		// Token: 0x0600D1C6 RID: 53702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1C6")]
		[Address(RVA = "0x3526D10", Offset = "0x3525910", VA = "0x183526D10")]
		public void PreloadIllustrations(BattlePlayerData playerData, LevelData levelData, LevelData.Difficulty difficulty)
		{
		}

		// Token: 0x0600D1C7 RID: 53703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1C7")]
		[Address(RVA = "0x35263C0", Offset = "0x3524FC0", VA = "0x1835263C0")]
		public GameObject LoadActivityGameObject(string assetId)
		{
			return null;
		}

		// Token: 0x0600D1C8 RID: 53704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1C8")]
		[Address(RVA = "0x3526B90", Offset = "0x3525790", VA = "0x183526B90")]
		public GameObject LoadUIBattlePlugin(string assetId)
		{
			return null;
		}

		// Token: 0x0600D1C9 RID: 53705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1C9")]
		[Address(RVA = "0x3526A30", Offset = "0x3525630", VA = "0x183526A30")]
		public GameObject LoadUIBattleHudPlugin(string assetId)
		{
			return null;
		}

		// Token: 0x0600D1CA RID: 53706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1CA")]
		[Address(RVA = "0x35265E0", Offset = "0x35251E0", VA = "0x1835265E0")]
		public GameObject LoadBattleMetaUIPlugin(string assetId)
		{
			return null;
		}

		// Token: 0x0600D1CB RID: 53707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1CB")]
		[Address(RVA = "0x3526310", Offset = "0x3524F10", VA = "0x183526310")]
		public GameObject LoadActivityDependentUIBattlePlugin(string activityId)
		{
			return null;
		}

		// Token: 0x0600D1CC RID: 53708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1CC")]
		[Address(RVA = "0x3526AE0", Offset = "0x35256E0", VA = "0x183526AE0")]
		public GameObject LoadUIBattlePluginByPath(string path)
		{
			return null;
		}

		// Token: 0x0600D1CD RID: 53709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1CD")]
		[Address(RVA = "0x3526690", Offset = "0x3525290", VA = "0x183526690")]
		public RectTransform LoadCardEffectPlugin(string assetId)
		{
			return null;
		}

		// Token: 0x0600D1CE RID: 53710 RVA: 0x0004B930 File Offset: 0x00049B30
		[Token(Token = "0x600D1CE")]
		[Address(RVA = "0x35267E0", Offset = "0x35253E0", VA = "0x1835267E0")]
		public SpriteRenderData LoadCharPortrait(string portraitId)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0600D1CF RID: 53711 RVA: 0x0004B948 File Offset: 0x00049B48
		[Token(Token = "0x600D1CF")]
		[Address(RVA = "0x3527580", Offset = "0x3526180", VA = "0x183527580")]
		private bool _TryLoadIllust(CharQuery charQuery, EvolvePhase evolvePhase, out Image illust)
		{
			return default(bool);
		}

		// Token: 0x0600D1D0 RID: 53712 RVA: 0x0004B960 File Offset: 0x00049B60
		[Token(Token = "0x600D1D0")]
		[Address(RVA = "0x35276B0", Offset = "0x35262B0", VA = "0x1835276B0")]
		private bool _TryLoadIllust(BattleCharacterData charData, out Image illust)
		{
			return default(bool);
		}

		// Token: 0x0600D1D1 RID: 53713 RVA: 0x0004B978 File Offset: 0x00049B78
		[Token(Token = "0x600D1D1")]
		[Address(RVA = "0x35272B0", Offset = "0x3525EB0", VA = "0x1835272B0")]
		private bool _TryLoadIllust(CharQuery charQuery, CharUISkinStruct skin, out Image illust)
		{
			return default(bool);
		}

		// Token: 0x0600D1D2 RID: 53714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1D2")]
		[Address(RVA = "0x3525A20", Offset = "0x3524620", VA = "0x183525A20")]
		public Sprite GetContentPictureFunLiveModeOnly(string picId)
		{
			return null;
		}

		// Token: 0x0600D1D3 RID: 53715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1D3")]
		[Address(RVA = "0x35258B0", Offset = "0x35244B0", VA = "0x1835258B0")]
		public Sprite GetCardAdditionIcon(string cardIcon)
		{
			return null;
		}

		// Token: 0x0600D1D4 RID: 53716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1D4")]
		[Address(RVA = "0x3525B60", Offset = "0x3524760", VA = "0x183525B60")]
		public Sprite GetEmojiPictureFunLiveModeOnly(string emojiId)
		{
			return null;
		}

		// Token: 0x0600D1D5 RID: 53717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1D5")]
		[Address(RVA = "0x35254E0", Offset = "0x35240E0", VA = "0x1835254E0")]
		public Sprite GetAct5FunNpcIconAct5FunModeOnly(string npcId)
		{
			return null;
		}

		// Token: 0x0600D1D6 RID: 53718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1D6")]
		[Address(RVA = "0x3526150", Offset = "0x3524D50", VA = "0x183526150")]
		public Sprite GetSquadSpecialEffectIconCoopModeOnly(string iconId)
		{
			return null;
		}

		// Token: 0x0600D1D7 RID: 53719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1D7")]
		[Address(RVA = "0x3526F10", Offset = "0x3525B10", VA = "0x183526F10")]
		private void Start()
		{
		}

		// Token: 0x0600D1D8 RID: 53720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1D8")]
		[Address(RVA = "0x3526C40", Offset = "0x3525840", VA = "0x183526C40", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600D1D9 RID: 53721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1D9")]
		public T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600D1DA RID: 53722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1DA")]
		[Address(RVA = "0x3526540", Offset = "0x3525140", VA = "0x183526540", Slot = "9")]
		public UnityEngine.Object LoadAsset(string path)
		{
			return null;
		}

		// Token: 0x0600D1DB RID: 53723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1DB")]
		[Address(RVA = "0x3527220", Offset = "0x3525E20", VA = "0x183527220", Slot = "10")]
		public void UnloadAsset(UnityEngine.Object asset)
		{
		}

		// Token: 0x0600D1DC RID: 53724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1DC")]
		[Address(RVA = "0x35279A0", Offset = "0x35265A0", VA = "0x1835279A0")]
		public ArtCollection()
		{
		}

		// Token: 0x0400E049 RID: 57417
		[Token(Token = "0x400E049")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Defaults")]
		[FormerlySerializedAs("_defaultAvatar")]
		private Sprite _defaultIcon;

		// Token: 0x0400E04A RID: 57418
		[Token(Token = "0x400E04A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Defaults")]
		private Image _defaultIllust;

		// Token: 0x0400E04B RID: 57419
		[Token(Token = "0x400E04B")]
		[FieldOffset(Offset = "0x28")]
		private BaseAssetLoader.Assets m_assetLoader;

		// Token: 0x0400E04C RID: 57420
		[Token(Token = "0x400E04C")]
		[FieldOffset(Offset = "0x30")]
		private AutoPackSpriteHub m_avatarHub;

		// Token: 0x0400E04D RID: 57421
		[Token(Token = "0x400E04D")]
		[FieldOffset(Offset = "0x38")]
		private AutoPackSpriteHub m_skillIconHub;

		// Token: 0x0400E04E RID: 57422
		[Token(Token = "0x400E04E")]
		[FieldOffset(Offset = "0x40")]
		private AutoPackSpriteHub m_enemyIconHub;

		// Token: 0x0400E04F RID: 57423
		[Token(Token = "0x400E04F")]
		[FieldOffset(Offset = "0x48")]
		private AutoPackSpriteHub m_enemyBossHpIconHub;

		// Token: 0x0400E050 RID: 57424
		[Token(Token = "0x400E050")]
		[FieldOffset(Offset = "0x50")]
		private SpriteHub m_cardAdditionIconHub;

		// Token: 0x0400E051 RID: 57425
		[Token(Token = "0x400E051")]
		[FieldOffset(Offset = "0x58")]
		private AutoPackSpriteHub m_subPrefessionIconHub;

		// Token: 0x0400E052 RID: 57426
		[Token(Token = "0x400E052")]
		[FieldOffset(Offset = "0x60")]
		private AutoPackSpriteHub m_equipDirectionSpriteHub;

		// Token: 0x0400E053 RID: 57427
		[Token(Token = "0x400E053")]
		[FieldOffset(Offset = "0x68")]
		private UIAssetLoader.Assets m_sharedAssetLoader;

		// Token: 0x0400E054 RID: 57428
		[Token(Token = "0x400E054")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x0400E055 RID: 57429
		[Token(Token = "0x400E055")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sharedAssetLoader;

		// Token: 0x0400E056 RID: 57430
		[Token(Token = "0x400E056")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetAvatar;

		// Token: 0x0400E057 RID: 57431
		[Token(Token = "0x400E057")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_GetAvatar;

		// Token: 0x0400E058 RID: 57432
		[Token(Token = "0x400E058")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSubProfessionlIcon;

		// Token: 0x0400E059 RID: 57433
		[Token(Token = "0x400E059")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSkillIcon;

		// Token: 0x0400E05A RID: 57434
		[Token(Token = "0x400E05A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetEnemyIcon;

		// Token: 0x0400E05B RID: 57435
		[Token(Token = "0x400E05B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetEnemyBossHpIcon;

		// Token: 0x0400E05C RID: 57436
		[Token(Token = "0x400E05C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetIllust;

		// Token: 0x0400E05D RID: 57437
		[Token(Token = "0x400E05D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryGetEquipDirectionSprite;

		// Token: 0x0400E05E RID: 57438
		[Token(Token = "0x400E05E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadEtIcon;

		// Token: 0x0400E05F RID: 57439
		[Token(Token = "0x400E05F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryLoadSpriteFromAutoPackHub;

		// Token: 0x0400E060 RID: 57440
		[Token(Token = "0x400E060")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_PreloadIllustrations;

		// Token: 0x0400E061 RID: 57441
		[Token(Token = "0x400E061")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadActivityGameObject;

		// Token: 0x0400E062 RID: 57442
		[Token(Token = "0x400E062")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadUIBattlePlugin;

		// Token: 0x0400E063 RID: 57443
		[Token(Token = "0x400E063")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_LoadUIBattleHudPlugin;

		// Token: 0x0400E064 RID: 57444
		[Token(Token = "0x400E064")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LoadBattleMetaUIPlugin;

		// Token: 0x0400E065 RID: 57445
		[Token(Token = "0x400E065")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadActivityDependentUIBattlePlugin;

		// Token: 0x0400E066 RID: 57446
		[Token(Token = "0x400E066")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadUIBattlePluginByPath;

		// Token: 0x0400E067 RID: 57447
		[Token(Token = "0x400E067")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_LoadCardEffectPlugin;

		// Token: 0x0400E068 RID: 57448
		[Token(Token = "0x400E068")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadCharPortrait;

		// Token: 0x0400E069 RID: 57449
		[Token(Token = "0x400E069")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__TryLoadIllust;

		// Token: 0x0400E06A RID: 57450
		[Token(Token = "0x400E06A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix1__TryLoadIllust;

		// Token: 0x0400E06B RID: 57451
		[Token(Token = "0x400E06B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix2__TryLoadIllust;

		// Token: 0x0400E06C RID: 57452
		[Token(Token = "0x400E06C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetContentPictureFunLiveModeOnly;

		// Token: 0x0400E06D RID: 57453
		[Token(Token = "0x400E06D")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetCardAdditionIcon;

		// Token: 0x0400E06E RID: 57454
		[Token(Token = "0x400E06E")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetEmojiPictureFunLiveModeOnly;

		// Token: 0x0400E06F RID: 57455
		[Token(Token = "0x400E06F")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetAct5FunNpcIconAct5FunModeOnly;

		// Token: 0x0400E070 RID: 57456
		[Token(Token = "0x400E070")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetSquadSpecialEffectIconCoopModeOnly;

		// Token: 0x0400E071 RID: 57457
		[Token(Token = "0x400E071")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400E072 RID: 57458
		[Token(Token = "0x400E072")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400E073 RID: 57459
		[Token(Token = "0x400E073")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x0400E074 RID: 57460
		[Token(Token = "0x400E074")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix1_LoadAsset;

		// Token: 0x0400E075 RID: 57461
		[Token(Token = "0x400E075")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_UnloadAsset;

		// Token: 0x0400E076 RID: 57462
		[Token(Token = "0x400E076")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
