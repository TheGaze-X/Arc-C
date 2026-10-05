using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000C0B RID: 3083
	[Token(Token = "0x2000C0B")]
	public class PlayerDataModel
	{
		// Token: 0x060068A1 RID: 26785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068A1")]
		[Address(RVA = "0x1EF54B0", Offset = "0x1EF40B0", VA = "0x181EF54B0")]
		public string Serialize()
		{
			return null;
		}

		// Token: 0x060068A2 RID: 26786 RVA: 0x00030990 File Offset: 0x0002EB90
		[Token(Token = "0x60068A2")]
		[Address(RVA = "0x1EF53D0", Offset = "0x1EF3FD0", VA = "0x181EF53D0")]
		public bool HasFlag(string flag)
		{
			return default(bool);
		}

		// Token: 0x060068A3 RID: 26787 RVA: 0x000309A8 File Offset: 0x0002EBA8
		[Token(Token = "0x60068A3")]
		[Address(RVA = "0x1EF5440", Offset = "0x1EF4040", VA = "0x181EF5440")]
		public bool HasVariantStoryUnlocked(string storyId)
		{
			return default(bool);
		}

		// Token: 0x060068A4 RID: 26788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068A4")]
		[Address(RVA = "0x1EF5540", Offset = "0x1EF4140", VA = "0x181EF5540")]
		public PlayerDataModel ShallowClone()
		{
			return null;
		}

		// Token: 0x060068A5 RID: 26789 RVA: 0x000309C0 File Offset: 0x0002EBC0
		[Token(Token = "0x60068A5")]
		[Address(RVA = "0x1EF55F0", Offset = "0x1EF41F0", VA = "0x181EF55F0")]
		public bool TryGetStageStateForAVGTrigger(string stageId, out PlayerStageState state)
		{
			return default(bool);
		}

		// Token: 0x060068A6 RID: 26790 RVA: 0x000309D8 File Offset: 0x0002EBD8
		[Token(Token = "0x60068A6")]
		[Address(RVA = "0x1EF56F0", Offset = "0x1EF42F0", VA = "0x181EF56F0")]
		private bool _TryGetActFunStageStateForAVGTrigger(string stageId, out PlayerStageState state)
		{
			return default(bool);
		}

		// Token: 0x060068A7 RID: 26791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A7")]
		[Address(RVA = "0x1EF57A0", Offset = "0x1EF43A0", VA = "0x181EF57A0")]
		public PlayerDataModel()
		{
		}

		// Token: 0x04003EDC RID: 16092
		[Token(Token = "0x4003EDC")]
		public const string ACTIVITY_FIELD = "activity";

		// Token: 0x04003EDD RID: 16093
		[Token(Token = "0x4003EDD")]
		public const string SANDBOX_PERM_FIELD = "sandboxPerm";

		// Token: 0x04003EDE RID: 16094
		[Token(Token = "0x4003EDE")]
		public const string SANDBOX_PERM_TEMPLATE_FIELD = "template";

		// Token: 0x04003EDF RID: 16095
		[Token(Token = "0x4003EDF")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "event")]
		public PlayerEvents events;

		// Token: 0x04003EE0 RID: 16096
		[Token(Token = "0x4003EE0")]
		[FieldOffset(Offset = "0x18")]
		public PlayerPushFlags pushFlags;

		// Token: 0x04003EE1 RID: 16097
		[Token(Token = "0x4003EE1")]
		[FieldOffset(Offset = "0x20")]
		public PlayerStatus status;

		// Token: 0x04003EE2 RID: 16098
		[Token(Token = "0x4003EE2")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, PlayerMonthlySubPer> monthlySub;

		// Token: 0x04003EE3 RID: 16099
		[Token(Token = "0x4003EE3")]
		[FieldOffset(Offset = "0x30")]
		public PlayerTroop troop;

		// Token: 0x04003EE4 RID: 16100
		[Token(Token = "0x4003EE4")]
		[FieldOffset(Offset = "0x38")]
		public PlayerDungeon dungeon;

		// Token: 0x04003EE5 RID: 16101
		[Token(Token = "0x4003EE5")]
		[FieldOffset(Offset = "0x40")]
		public PlayerCheckIn checkIn;

		// Token: 0x04003EE6 RID: 16102
		[Token(Token = "0x4003EE6")]
		[FieldOffset(Offset = "0x48")]
		public PlayerOpenServer openServer;

		// Token: 0x04003EE7 RID: 16103
		[Token(Token = "0x4003EE7")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty(PropertyName = "activity")]
		public PlayerActivity activity;

		// Token: 0x04003EE8 RID: 16104
		[Token(Token = "0x4003EE8")]
		[FieldOffset(Offset = "0x58")]
		public PlayerTemplateTrap templateTrap;

		// Token: 0x04003EE9 RID: 16105
		[Token(Token = "0x4003EE9")]
		[FieldOffset(Offset = "0x60")]
		public PlayerRetro retro;

		// Token: 0x04003EEA RID: 16106
		[Token(Token = "0x4003EEA")]
		[FieldOffset(Offset = "0x68")]
		public PlayerDexNav dexNav;

		// Token: 0x04003EEB RID: 16107
		[Token(Token = "0x4003EEB")]
		[FieldOffset(Offset = "0x70")]
		public PlayerSkins skin;

		// Token: 0x04003EEC RID: 16108
		[Token(Token = "0x4003EEC")]
		[FieldOffset(Offset = "0x78")]
		public PlayerMedal medal;

		// Token: 0x04003EED RID: 16109
		[Token(Token = "0x4003EED")]
		[FieldOffset(Offset = "0x80")]
		[JsonProperty(PropertyName = "avatar")]
		public PlayerAvatar PlayerAvatar;

		// Token: 0x04003EEE RID: 16110
		[Token(Token = "0x4003EEE")]
		[FieldOffset(Offset = "0x88")]
		public PlayerCollection collectionReward;

		// Token: 0x04003EEF RID: 16111
		[Token(Token = "0x4003EEF")]
		[FieldOffset(Offset = "0x90")]
		public PlayerEquipment equipment;

		// Token: 0x04003EF0 RID: 16112
		[Token(Token = "0x4003EF0")]
		[FieldOffset(Offset = "0x98")]
		public Dictionary<string, int> inventory;

		// Token: 0x04003EF1 RID: 16113
		[Token(Token = "0x4003EF1")]
		[FieldOffset(Offset = "0xA0")]
		public Dictionary<string, ListDict<int, PlayerConsumableItem>> consumable;

		// Token: 0x04003EF2 RID: 16114
		[Token(Token = "0x4003EF2")]
		[FieldOffset(Offset = "0xA8")]
		public Dictionary<string, PlayerTicketItem> ticket;

		// Token: 0x04003EF3 RID: 16115
		[Token(Token = "0x4003EF3")]
		[FieldOffset(Offset = "0xB0")]
		public PlayerShop shop;

		// Token: 0x04003EF4 RID: 16116
		[Token(Token = "0x4003EF4")]
		[FieldOffset(Offset = "0xB8")]
		public Dictionary<string, Dictionary<string, PlayerInviteData>> invite;

		// Token: 0x04003EF5 RID: 16117
		[Token(Token = "0x4003EF5")]
		[FieldOffset(Offset = "0xC0")]
		public Dictionary<string, PlayerTemplateShop> tshop;

		// Token: 0x04003EF6 RID: 16118
		[Token(Token = "0x4003EF6")]
		[FieldOffset(Offset = "0xC8")]
		public PlayerRecruit recruit;

		// Token: 0x04003EF7 RID: 16119
		[Token(Token = "0x4003EF7")]
		[FieldOffset(Offset = "0xD0")]
		public PlayerCarousel carousel;

		// Token: 0x04003EF8 RID: 16120
		[Token(Token = "0x4003EF8")]
		[FieldOffset(Offset = "0xD8")]
		public PlayerGacha gacha;

		// Token: 0x04003EF9 RID: 16121
		[Token(Token = "0x4003EF9")]
		[FieldOffset(Offset = "0xE0")]
		public PlayerSocial social;

		// Token: 0x04003EFA RID: 16122
		[Token(Token = "0x4003EFA")]
		[FieldOffset(Offset = "0xE8")]
		public MissionPlayerData mission;

		// Token: 0x04003EFB RID: 16123
		[Token(Token = "0x4003EFB")]
		[FieldOffset(Offset = "0xF0")]
		public PlayerBuilding building;

		// Token: 0x04003EFC RID: 16124
		[Token(Token = "0x4003EFC")]
		[FieldOffset(Offset = "0xF8")]
		public PlayerCrisis crisis;

		// Token: 0x04003EFD RID: 16125
		[Token(Token = "0x4003EFD")]
		[FieldOffset(Offset = "0x100")]
		public PlayerCrisisV2 crisisV2;

		// Token: 0x04003EFE RID: 16126
		[Token(Token = "0x4003EFE")]
		[FieldOffset(Offset = "0x108")]
		public PlayerRecalRune recalRune;

		// Token: 0x04003EFF RID: 16127
		[Token(Token = "0x4003EFF")]
		[FieldOffset(Offset = "0x110")]
		public PlayerStoryReview storyreview;

		// Token: 0x04003F00 RID: 16128
		[Token(Token = "0x4003F00")]
		[FieldOffset(Offset = "0x118")]
		public PlayerRoguelike roguelike;

		// Token: 0x04003F01 RID: 16129
		[Token(Token = "0x4003F01")]
		[FieldOffset(Offset = "0x120")]
		public PlayerRoguelikeV2 rlv2;

		// Token: 0x04003F02 RID: 16130
		[Token(Token = "0x4003F02")]
		[FieldOffset(Offset = "0x128")]
		public PlayerReturnData backflow;

		// Token: 0x04003F03 RID: 16131
		[Token(Token = "0x4003F03")]
		[FieldOffset(Offset = "0x130")]
		[JsonProperty("campaignsV2")]
		public PlayerCampaign campaign;

		// Token: 0x04003F04 RID: 16132
		[Token(Token = "0x4003F04")]
		[FieldOffset(Offset = "0x138")]
		[JsonProperty("autochessSeason")]
		public PlayerAutoChessPerm autoChessPerm;

		// Token: 0x04003F05 RID: 16133
		[Token(Token = "0x4003F05")]
		[FieldOffset(Offset = "0x140")]
		public CharmStatus charm;

		// Token: 0x04003F06 RID: 16134
		[Token(Token = "0x4003F06")]
		[FieldOffset(Offset = "0x148")]
		public PlayerDeepSea deepSea;

		// Token: 0x04003F07 RID: 16135
		[Token(Token = "0x4003F07")]
		[FieldOffset(Offset = "0x150")]
		public PlayerCartInfo car;

		// Token: 0x04003F08 RID: 16136
		[Token(Token = "0x4003F08")]
		[FieldOffset(Offset = "0x158")]
		public PlayerTower tower;

		// Token: 0x04003F09 RID: 16137
		[Token(Token = "0x4003F09")]
		[FieldOffset(Offset = "0x160")]
		public PlayerSiracusaMap siracusaMap;

		// Token: 0x04003F0A RID: 16138
		[Token(Token = "0x4003F0A")]
		[FieldOffset(Offset = "0x168")]
		public PlayerFirework firework;

		// Token: 0x04003F0B RID: 16139
		[Token(Token = "0x4003F0B")]
		[FieldOffset(Offset = "0x170")]
		public PlayerSandboxPerm sandboxPerm;

		// Token: 0x04003F0C RID: 16140
		[Token(Token = "0x4003F0C")]
		[FieldOffset(Offset = "0x178")]
		public PlayerEmoticon emoticon;

		// Token: 0x04003F0D RID: 16141
		[Token(Token = "0x4003F0D")]
		[FieldOffset(Offset = "0x180")]
		public PlayerCrossAppShare share;

		// Token: 0x04003F0E RID: 16142
		[Token(Token = "0x4003F0E")]
		[FieldOffset(Offset = "0x188")]
		public PlayerTrainingCamp trainingGround;

		// Token: 0x04003F0F RID: 16143
		[Token(Token = "0x4003F0F")]
		[FieldOffset(Offset = "0x190")]
		[JsonProperty("background")]
		public PlayerHomeBackground playerHomeBackground;

		// Token: 0x04003F10 RID: 16144
		[Token(Token = "0x4003F10")]
		[FieldOffset(Offset = "0x198")]
		[JsonProperty("homeTheme")]
		public PlayerHomeTheme playerHomeTheme;

		// Token: 0x04003F11 RID: 16145
		[Token(Token = "0x4003F11")]
		[FieldOffset(Offset = "0x1A0")]
		[JsonProperty("nameCardStyle")]
		public PlayerNameCardStyle playerNameCardStyle;

		// Token: 0x04003F12 RID: 16146
		[Token(Token = "0x4003F12")]
		[FieldOffset(Offset = "0x1A8")]
		[JsonProperty("setting")]
		public PlayerSetting playerSetting;

		// Token: 0x04003F13 RID: 16147
		[Token(Token = "0x4003F13")]
		[FieldOffset(Offset = "0x1B0")]
		[JsonProperty("aprilFool")]
		public PlayerAprilFool playerAprilFool;

		// Token: 0x04003F14 RID: 16148
		[Token(Token = "0x4003F14")]
		[FieldOffset(Offset = "0x1B8")]
		public Dictionary<string, PlayerNpcWithAudio> npcAudio;

		// Token: 0x04003F15 RID: 16149
		[Token(Token = "0x4003F15")]
		[FieldOffset(Offset = "0x1C0")]
		public PlayerCharRotation charRotation;

		// Token: 0x04003F16 RID: 16150
		[Token(Token = "0x4003F16")]
		[FieldOffset(Offset = "0x1C8")]
		public PlayerGallery gallery;

		// Token: 0x04003F17 RID: 16151
		[Token(Token = "0x4003F17")]
		[FieldOffset(Offset = "0x1D0")]
		[JsonProperty("mainline")]
		public PlayerMainlineRecord playerMainlineRecord;

		// Token: 0x04003F18 RID: 16152
		[Token(Token = "0x4003F18")]
		[FieldOffset(Offset = "0x1D8")]
		public PlayerLimitedDropBuff limitedBuff;

		// Token: 0x04003F19 RID: 16153
		[Token(Token = "0x4003F19")]
		[FieldOffset(Offset = "0x1E0")]
		public PlayerPerformanceStory performanceStory;
	}
}
