using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.LocalTrack;
using Torappu.UI;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200734E RID: 29518
	[Token(Token = "0x200734E")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act42D0ResUtil
	{
		// Token: 0x06029BCC RID: 170956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BCC")]
		[Address(RVA = "0x2562670", Offset = "0x2561270", VA = "0x182562670")]
		public static Act42D0Data GetAct42D0Data(string actId)
		{
			return null;
		}

		// Token: 0x06029BCD RID: 170957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BCD")]
		[Address(RVA = "0x2562740", Offset = "0x2561340", VA = "0x182562740")]
		public static PlayerActivity.PlayerAct42D0Activity GetActPlayerData(string actId)
		{
			return null;
		}

		// Token: 0x06029BCE RID: 170958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BCE")]
		[Address(RVA = "0x2562950", Offset = "0x2561550", VA = "0x182562950")]
		public static NewestProgress GetHardestRecord(string actId)
		{
			return null;
		}

		// Token: 0x06029BCF RID: 170959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BCF")]
		[Address(RVA = "0x2562410", Offset = "0x2561010", VA = "0x182562410")]
		public static CommonTopMenu CreateCommonTopMenu(Transform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x06029BD0 RID: 170960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BD0")]
		[Address(RVA = "0x2562FE0", Offset = "0x2561BE0", VA = "0x182562FE0")]
		public static Sprite LoadRatingFlatIcon(string actId, string iconId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06029BD1 RID: 170961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BD1")]
		[Address(RVA = "0x2562EC0", Offset = "0x2561AC0", VA = "0x182562EC0")]
		public static Sprite LoadEffectIconOnlyInBattleFinish(string actId, string effectId)
		{
			return null;
		}

		// Token: 0x06029BD2 RID: 170962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BD2")]
		[Address(RVA = "0x2562F40", Offset = "0x2561B40", VA = "0x182562F40")]
		public static Sprite LoadEffectIcon(string actId, string effectId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06029BD3 RID: 170963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BD3")]
		[Address(RVA = "0x2562D40", Offset = "0x2561940", VA = "0x182562D40")]
		public static Sprite LoadDisplayIconOnlyInBattleFinish(string actId, string displayId)
		{
			return null;
		}

		// Token: 0x06029BD4 RID: 170964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BD4")]
		[Address(RVA = "0x2562DF0", Offset = "0x25619F0", VA = "0x182562DF0")]
		public static Sprite LoadDisplayIcon(string actId, string displayId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06029BD5 RID: 170965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BD5")]
		[Address(RVA = "0x25633E0", Offset = "0x2561FE0", VA = "0x1825633E0")]
		private static string _GetDisplayIconName(string displayId)
		{
			return null;
		}

		// Token: 0x06029BD6 RID: 170966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BD6")]
		[Address(RVA = "0x2563550", Offset = "0x2562150", VA = "0x182563550")]
		private static Sprite _LoadFromAutoSpriteHub(string hubPath, string spriteId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06029BD7 RID: 170967 RVA: 0x000D6530 File Offset: 0x000D4730
		[Token(Token = "0x6029BD7")]
		[Address(RVA = "0x2562860", Offset = "0x2561460", VA = "0x182562860")]
		public static SpriteRenderData GetAreaCodeRenderData(UIAtlasObject atlas, string areaCode)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x06029BD8 RID: 170968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BD8")]
		[Address(RVA = "0x2563300", Offset = "0x2561F00", VA = "0x182563300")]
		private static string _GetChallengeTrackType(string actId)
		{
			return null;
		}

		// Token: 0x06029BD9 RID: 170969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BD9")]
		[Address(RVA = "0x2563470", Offset = "0x2562070", VA = "0x182563470")]
		private static string _GetNormalTrackType(string actId)
		{
			return null;
		}

		// Token: 0x06029BDA RID: 170970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BDA")]
		[Address(RVA = "0x2563290", Offset = "0x2561E90", VA = "0x182563290")]
		private static string _GetCanUseBuffTrackType(string actId)
		{
			return null;
		}

		// Token: 0x06029BDB RID: 170971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BDB")]
		[Address(RVA = "0x2563370", Offset = "0x2561F70", VA = "0x182563370")]
		private static string _GetChallengeUnlockTrackId(string stageId)
		{
			return null;
		}

		// Token: 0x06029BDC RID: 170972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BDC")]
		[Address(RVA = "0x25634E0", Offset = "0x25620E0", VA = "0x1825634E0")]
		private static string _GetNormalUnlockTrackId(string areaId)
		{
			return null;
		}

		// Token: 0x06029BDD RID: 170973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BDD")]
		[Address(RVA = "0x2563220", Offset = "0x2561E20", VA = "0x182563220")]
		private static string _GetCanUseBuffTrackId(string areaId)
		{
			return null;
		}

		// Token: 0x06029BDE RID: 170974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BDE")]
		[Address(RVA = "0x2562570", Offset = "0x2561170", VA = "0x182562570")]
		public static TimeCondTrigger GenerateChallengeUnlockTrigger(string actId, string stageId, long startIs)
		{
			return null;
		}

		// Token: 0x06029BDF RID: 170975 RVA: 0x000D6548 File Offset: 0x000D4748
		[Token(Token = "0x6029BDF")]
		[Address(RVA = "0x2562050", Offset = "0x2560C50", VA = "0x182562050")]
		public static bool CheckChallengeUnlockTrack(string actId, string stageId)
		{
			return default(bool);
		}

		// Token: 0x06029BE0 RID: 170976 RVA: 0x000D6560 File Offset: 0x000D4760
		[Token(Token = "0x6029BE0")]
		[Address(RVA = "0x2561FB0", Offset = "0x2560BB0", VA = "0x182561FB0")]
		public static bool CheckChallengeUnlockTrackOfSameType(string actId)
		{
			return default(bool);
		}

		// Token: 0x06029BE1 RID: 170977 RVA: 0x000D6578 File Offset: 0x000D4778
		[Token(Token = "0x6029BE1")]
		[Address(RVA = "0x2562290", Offset = "0x2560E90", VA = "0x182562290")]
		public static bool ConsumeChallengeUnlockTrack(string actId, string stageId)
		{
			return default(bool);
		}

		// Token: 0x06029BE2 RID: 170978 RVA: 0x000D6590 File Offset: 0x000D4790
		[Token(Token = "0x6029BE2")]
		[Address(RVA = "0x2563160", Offset = "0x2561D60", VA = "0x182563160")]
		public static bool RecordNormalUnlockTrack(string actId, string areaId)
		{
			return default(bool);
		}

		// Token: 0x06029BE3 RID: 170979 RVA: 0x000D65A8 File Offset: 0x000D47A8
		[Token(Token = "0x6029BE3")]
		[Address(RVA = "0x2562110", Offset = "0x2560D10", VA = "0x182562110")]
		public static bool CheckNormalUnlockTrack(string actId, string areaId)
		{
			return default(bool);
		}

		// Token: 0x06029BE4 RID: 170980 RVA: 0x000D65C0 File Offset: 0x000D47C0
		[Token(Token = "0x6029BE4")]
		[Address(RVA = "0x2562350", Offset = "0x2560F50", VA = "0x182562350")]
		public static bool ConsumeNormalUnlockTrack(string actId, string areaId)
		{
			return default(bool);
		}

		// Token: 0x06029BE5 RID: 170981 RVA: 0x000D65D8 File Offset: 0x000D47D8
		[Token(Token = "0x6029BE5")]
		[Address(RVA = "0x25630A0", Offset = "0x2561CA0", VA = "0x1825630A0")]
		public static bool RecordCanUseBuffTrack(string actId, string areaId)
		{
			return default(bool);
		}

		// Token: 0x06029BE6 RID: 170982 RVA: 0x000D65F0 File Offset: 0x000D47F0
		[Token(Token = "0x6029BE6")]
		[Address(RVA = "0x2561EF0", Offset = "0x2560AF0", VA = "0x182561EF0")]
		public static bool CheckCanUseBuffTrack(string actId, string areaId)
		{
			return default(bool);
		}

		// Token: 0x06029BE7 RID: 170983 RVA: 0x000D6608 File Offset: 0x000D4808
		[Token(Token = "0x6029BE7")]
		[Address(RVA = "0x25621D0", Offset = "0x2560DD0", VA = "0x1825621D0")]
		public static bool ConsumeCanUseBuffTrack(string actId, string areaId)
		{
			return default(bool);
		}

		// Token: 0x0403BBD7 RID: 244695
		[Token(Token = "0x403BBD7")]
		private const string ACT42D0_CHALLENGE_STAGE_UNLOCK_TRACK_ID = "act42d0_unlock_challenge_stage_{0}";

		// Token: 0x0403BBD8 RID: 244696
		[Token(Token = "0x403BBD8")]
		private const string ACT42D0_NORMAL_AREA_UNLOCK_TRACK_ID = "act42d0_unlock_normal_area_{0}";

		// Token: 0x0403BBD9 RID: 244697
		[Token(Token = "0x403BBD9")]
		private const string ACT42D0_CAN_USE_BUFF_TRACK_ID = "act42d0_can_use_buff_area_{0}";

		// Token: 0x0403BBDA RID: 244698
		[Token(Token = "0x403BBDA")]
		private const string ACT42D0_RATING_FLAT_ICON_FORMAT = "{0}_flat";

		// Token: 0x0403BBDB RID: 244699
		[Token(Token = "0x403BBDB")]
		private const string ACT42D0_DISPLAY_ICON_FORMAT_STR = "display_icon_{0}";

		// Token: 0x0403BBDC RID: 244700
		[Token(Token = "0x403BBDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAct42D0Data;

		// Token: 0x0403BBDD RID: 244701
		[Token(Token = "0x403BBDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetActPlayerData;

		// Token: 0x0403BBDE RID: 244702
		[Token(Token = "0x403BBDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetHardestRecord;

		// Token: 0x0403BBDF RID: 244703
		[Token(Token = "0x403BBDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x0403BBE0 RID: 244704
		[Token(Token = "0x403BBE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadRatingFlatIcon;

		// Token: 0x0403BBE1 RID: 244705
		[Token(Token = "0x403BBE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadEffectIconOnlyInBattleFinish;

		// Token: 0x0403BBE2 RID: 244706
		[Token(Token = "0x403BBE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadEffectIcon;

		// Token: 0x0403BBE3 RID: 244707
		[Token(Token = "0x403BBE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadDisplayIconOnlyInBattleFinish;

		// Token: 0x0403BBE4 RID: 244708
		[Token(Token = "0x403BBE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadDisplayIcon;

		// Token: 0x0403BBE5 RID: 244709
		[Token(Token = "0x403BBE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetDisplayIconName;

		// Token: 0x0403BBE6 RID: 244710
		[Token(Token = "0x403BBE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadFromAutoSpriteHub;

		// Token: 0x0403BBE7 RID: 244711
		[Token(Token = "0x403BBE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetAreaCodeRenderData;

		// Token: 0x0403BBE8 RID: 244712
		[Token(Token = "0x403BBE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetChallengeTrackType;

		// Token: 0x0403BBE9 RID: 244713
		[Token(Token = "0x403BBE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetNormalTrackType;

		// Token: 0x0403BBEA RID: 244714
		[Token(Token = "0x403BBEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetCanUseBuffTrackType;

		// Token: 0x0403BBEB RID: 244715
		[Token(Token = "0x403BBEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetChallengeUnlockTrackId;

		// Token: 0x0403BBEC RID: 244716
		[Token(Token = "0x403BBEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GetNormalUnlockTrackId;

		// Token: 0x0403BBED RID: 244717
		[Token(Token = "0x403BBED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetCanUseBuffTrackId;

		// Token: 0x0403BBEE RID: 244718
		[Token(Token = "0x403BBEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GenerateChallengeUnlockTrigger;

		// Token: 0x0403BBEF RID: 244719
		[Token(Token = "0x403BBEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CheckChallengeUnlockTrack;

		// Token: 0x0403BBF0 RID: 244720
		[Token(Token = "0x403BBF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_CheckChallengeUnlockTrackOfSameType;

		// Token: 0x0403BBF1 RID: 244721
		[Token(Token = "0x403BBF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_ConsumeChallengeUnlockTrack;

		// Token: 0x0403BBF2 RID: 244722
		[Token(Token = "0x403BBF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_RecordNormalUnlockTrack;

		// Token: 0x0403BBF3 RID: 244723
		[Token(Token = "0x403BBF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CheckNormalUnlockTrack;

		// Token: 0x0403BBF4 RID: 244724
		[Token(Token = "0x403BBF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_ConsumeNormalUnlockTrack;

		// Token: 0x0403BBF5 RID: 244725
		[Token(Token = "0x403BBF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_RecordCanUseBuffTrack;

		// Token: 0x0403BBF6 RID: 244726
		[Token(Token = "0x403BBF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_CheckCanUseBuffTrack;

		// Token: 0x0403BBF7 RID: 244727
		[Token(Token = "0x403BBF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_ConsumeCanUseBuffTrack;
	}
}
