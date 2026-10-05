using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Network
{
	// Token: 0x0200151E RID: 5406
	[Token(Token = "0x200151E")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ServiceCode
	{
		// Token: 0x04007AB0 RID: 31408
		[Token(Token = "0x4007AB0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<string> ANTI_DATA_SERVICES;

		// Token: 0x04007AB1 RID: 31409
		[Token(Token = "0x4007AB1")]
		public const string SDK_LOGIN_BY_PWD = "/user/login";

		// Token: 0x04007AB2 RID: 31410
		[Token(Token = "0x4007AB2")]
		public const string SDK_AUTH = "/user/auth";

		// Token: 0x04007AB3 RID: 31411
		[Token(Token = "0x4007AB3")]
		public const string SDK_PAY_CREATE_ORDER_APPSTORE = "/pay/createOrderAppstore";

		// Token: 0x04007AB4 RID: 31412
		[Token(Token = "0x4007AB4")]
		public const string SDK_LEGACY_PAY_CONFIRM_ORDER_APPSTORE = "/pay/confirmOrderAppstore";

		// Token: 0x04007AB5 RID: 31413
		[Token(Token = "0x4007AB5")]
		public const string SDK_PAY_CONFIRM_ORDER_APPSTORE = "/pay/confirmOrderAppstoreNew";

		// Token: 0x04007AB6 RID: 31414
		[Token(Token = "0x4007AB6")]
		public const string SDK_SEND_SMS_CODE = "/user/sendSmsCode";

		// Token: 0x04007AB7 RID: 31415
		[Token(Token = "0x4007AB7")]
		public const string SDK_USER_REGISTER = "/user/register";

		// Token: 0x04007AB8 RID: 31416
		[Token(Token = "0x4007AB8")]
		public const string SDK_USER_IDENTITY_AUTH = "/user/authenticateUserIdentity";

		// Token: 0x04007AB9 RID: 31417
		[Token(Token = "0x4007AB9")]
		public const string SDK_USER_CHECK_ID_CARD = "/user/checkIdCard";

		// Token: 0x04007ABA RID: 31418
		[Token(Token = "0x4007ABA")]
		public const string SDK_GUEST_CAPTCHA = "/captcha/v1/register";

		// Token: 0x04007ABB RID: 31419
		[Token(Token = "0x4007ABB")]
		public const string SDK_GUEST_LOGIN = "/user/v1/guestLogin";

		// Token: 0x04007ABC RID: 31420
		[Token(Token = "0x4007ABC")]
		public const string SDK_LOGIN_BY_SMS = "/user/loginBySmsCode";

		// Token: 0x04007ABD RID: 31421
		[Token(Token = "0x4007ABD")]
		public const string SDK_PING = "/online/v1/ping";

		// Token: 0x04007ABE RID: 31422
		[Token(Token = "0x4007ABE")]
		public const string SDK_LOGINOUT = "/online/v1/loginout";

		// Token: 0x04007ABF RID: 31423
		[Token(Token = "0x4007ABF")]
		public const string SDK_UPDATE_AGREEMENT = "/user/updateAgreement";

		// Token: 0x04007AC0 RID: 31424
		[Token(Token = "0x4007AC0")]
		public const string SDK_CHANGE_PWD = "/user/changePassword";

		// Token: 0x04007AC1 RID: 31425
		[Token(Token = "0x4007AC1")]
		public const string SDK_CHANGE_PHONE_CHECK = "/user/changePhoneCheck";

		// Token: 0x04007AC2 RID: 31426
		[Token(Token = "0x4007AC2")]
		public const string SDK_CHANGE_PHONE = "/user/changePhone";

		// Token: 0x04007AC3 RID: 31427
		[Token(Token = "0x4007AC3")]
		public const string LOGIN = "/account/login";

		// Token: 0x04007AC4 RID: 31428
		[Token(Token = "0x4007AC4")]
		public const string SYNC_DATA = "/account/syncData";

		// Token: 0x04007AC5 RID: 31429
		[Token(Token = "0x4007AC5")]
		public const string SYNC_STATUS = "/account/syncStatus";

		// Token: 0x04007AC6 RID: 31430
		[Token(Token = "0x4007AC6")]
		public const string SYNC_PUSH_MSG = "/account/syncPushMessage";

		// Token: 0x04007AC7 RID: 31431
		[Token(Token = "0x4007AC7")]
		public const string CHEAT = "/admin/cheat";

		// Token: 0x04007AC8 RID: 31432
		[Token(Token = "0x4007AC8")]
		public const string VERSION = "/admin/getVersion";

		// Token: 0x04007AC9 RID: 31433
		[Token(Token = "0x4007AC9")]
		public const string SQUAD_FORMATION = "/quest/squadFormation";

		// Token: 0x04007ACA RID: 31434
		[Token(Token = "0x4007ACA")]
		public const string SQUAD_RENAME = "/quest/changeSquadName";

		// Token: 0x04007ACB RID: 31435
		[Token(Token = "0x4007ACB")]
		public const string SQUAD_GET_ASSIST_LIST = "/quest/getAssistList";

		// Token: 0x04007ACC RID: 31436
		[Token(Token = "0x4007ACC")]
		public const string DEFAULT_BATTLE_START = "/quest/battleStart";

		// Token: 0x04007ACD RID: 31437
		[Token(Token = "0x4007ACD")]
		public const string DEFAULT_BATTLE_FINISH = "/quest/battleFinish";

		// Token: 0x04007ACE RID: 31438
		[Token(Token = "0x4007ACE")]
		public const string SAVE_BATTLE_REPLAY = "/quest/saveBattleReplay";

		// Token: 0x04007ACF RID: 31439
		[Token(Token = "0x4007ACF")]
		public const string LOAD_BATTLE_REPLAY = "/quest/getBattleReplay";

		// Token: 0x04007AD0 RID: 31440
		[Token(Token = "0x4007AD0")]
		public const string FINISH_STORY_STAGE = "/quest/finishStoryStage";

		// Token: 0x04007AD1 RID: 31441
		[Token(Token = "0x4007AD1")]
		public const string UNLOCK_STAGE_FOG = "/quest/unlockStageFog";

		// Token: 0x04007AD2 RID: 31442
		[Token(Token = "0x4007AD2")]
		public const string UNLOCK_HIDDEN_STAGE = "/quest/unlockHideStage";

		// Token: 0x04007AD3 RID: 31443
		[Token(Token = "0x4007AD3")]
		public const string GET_SPECIAL_STAGE_REWARD = "/quest/getCowLevelReward";

		// Token: 0x04007AD4 RID: 31444
		[Token(Token = "0x4007AD4")]
		public const string GET_ZONE_RECORD_REWARD = "/quest/getMainlineRecordRewards";

		// Token: 0x04007AD5 RID: 31445
		[Token(Token = "0x4007AD5")]
		public const string GET_MAINLINE_CACHE = "/quest/getMainlineCache";

		// Token: 0x04007AD6 RID: 31446
		[Token(Token = "0x4007AD6")]
		public const string CAMP_CONFIRM_BREAK_REWARD = "/campaignV2/getBreakReward";

		// Token: 0x04007AD7 RID: 31447
		[Token(Token = "0x4007AD7")]
		public const string CAMP_GET_COMMON_MISSION_REWARD = "/campaignV2/getExMissionReward";

		// Token: 0x04007AD8 RID: 31448
		[Token(Token = "0x4007AD8")]
		public const string CAMP_BATTLE_START = "/campaignV2/battleStart";

		// Token: 0x04007AD9 RID: 31449
		[Token(Token = "0x4007AD9")]
		public const string CAMP_BATTLE_FINISH = "/campaignV2/battleFinish";

		// Token: 0x04007ADA RID: 31450
		[Token(Token = "0x4007ADA")]
		public const string CAMP_BATTLE_SWEEP = "/campaignV2/battleSweep";

		// Token: 0x04007ADB RID: 31451
		[Token(Token = "0x4007ADB")]
		public const string RETRO_UNLOCK = "/retro/unlockRetroBlock";

		// Token: 0x04007ADC RID: 31452
		[Token(Token = "0x4007ADC")]
		public const string RETRO_TRAIL_REWARDGET = "/retro/getRetroTrailReward";

		// Token: 0x04007ADD RID: 31453
		[Token(Token = "0x4007ADD")]
		public const string RETRO_PASS_REWARD = "/retro/getRetroPassReward";

		// Token: 0x04007ADE RID: 31454
		[Token(Token = "0x4007ADE")]
		public const string RUNE_BATTLE_START = "/rune/battleStart";

		// Token: 0x04007ADF RID: 31455
		[Token(Token = "0x4007ADF")]
		public const string RUNE_BATTLE_FINISH = "/rune/battleFinish";

		// Token: 0x04007AE0 RID: 31456
		[Token(Token = "0x4007AE0")]
		public const string SET_DEFAULT_SKILL = "/charBuild/setDefaultSkill";

		// Token: 0x04007AE1 RID: 31457
		[Token(Token = "0x4007AE1")]
		public const string UPGRADE_CHAR = "/charBuild/upgradeChar";

		// Token: 0x04007AE2 RID: 31458
		[Token(Token = "0x4007AE2")]
		public const string EVOLVE_CHAR = "/charBuild/evolveChar";

		// Token: 0x04007AE3 RID: 31459
		[Token(Token = "0x4007AE3")]
		public const string LOCK_CHAR = "/charBuild/lockChar";

		// Token: 0x04007AE4 RID: 31460
		[Token(Token = "0x4007AE4")]
		public const string SELL_CHAR = "/charBuild/sellChar";

		// Token: 0x04007AE5 RID: 31461
		[Token(Token = "0x4007AE5")]
		public const string BOOST_POTENTIAL = "/charBuild/boostPotential";

		// Token: 0x04007AE6 RID: 31462
		[Token(Token = "0x4007AE6")]
		public const string UPGRADE_SKILL = "charBuild/upgradeSkill";

		// Token: 0x04007AE7 RID: 31463
		[Token(Token = "0x4007AE7")]
		public const string UPGRADE_SPECIALIZATION = "charBuild/upgradeSpecialization";

		// Token: 0x04007AE8 RID: 31464
		[Token(Token = "0x4007AE8")]
		public const string CONFIRM_SPECIALIZATION = "charBuild/completeUpgradeSpecialization";

		// Token: 0x04007AE9 RID: 31465
		[Token(Token = "0x4007AE9")]
		public const string CHANGE_SKIN_SELECT = "charBuild/changeCharSkin";

		// Token: 0x04007AEA RID: 31466
		[Token(Token = "0x4007AEA")]
		public const string CHANGE_SKIN_SP_STATE = "/charBuild/changeSkinSpState";

		// Token: 0x04007AEB RID: 31467
		[Token(Token = "0x4007AEB")]
		public const string CHANGE_TEMPLATE_SELECT = "charBuild/changeCharTemplate";

		// Token: 0x04007AEC RID: 31468
		[Token(Token = "0x4007AEC")]
		public const string GET_SP_CHAR_MISSION_REWARD = "charBuild/getSpCharMissionReward";

		// Token: 0x04007AED RID: 31469
		[Token(Token = "0x4007AED")]
		public const string EVOLVE_CHAR_USE_ITEM = "/charBuild/evolveCharUseItem";

		// Token: 0x04007AEE RID: 31470
		[Token(Token = "0x4007AEE")]
		public const string SETUNIEQUIPMENT = "/charBuild/setEquipment";

		// Token: 0x04007AEF RID: 31471
		[Token(Token = "0x4007AEF")]
		public const string CHANGE_STAR_MARK_CHAR = "/char/changeMarkStar";

		// Token: 0x04007AF0 RID: 31472
		[Token(Token = "0x4007AF0")]
		public const string UPGRADE_CHAR_LEVEL_MAX = "/charBuild/upgradeCharLevelMaxUseItem";

		// Token: 0x04007AF1 RID: 31473
		[Token(Token = "0x4007AF1")]
		public const string UPGRADE_SPEC_SKILL_USING_ITEM = "/charBuild/upgradeSpecializedSkillUseItem";

		// Token: 0x04007AF2 RID: 31474
		[Token(Token = "0x4007AF2")]
		public const string FINISH_STORY = "/story/finishStory";

		// Token: 0x04007AF3 RID: 31475
		[Token(Token = "0x4007AF3")]
		public const string REFRESH_PERFORMANCE_STORY_BEFORE_START = "/performanceStory/startStory";

		// Token: 0x04007AF4 RID: 31476
		[Token(Token = "0x4007AF4")]
		public const string CANCEL_NORMAL_GACHA = "/gacha/cancelNormalGacha";

		// Token: 0x04007AF5 RID: 31477
		[Token(Token = "0x4007AF5")]
		public const string REFRESH_TAG_GACHA = "/gacha/refreshTags";

		// Token: 0x04007AF6 RID: 31478
		[Token(Token = "0x4007AF6")]
		public const string SYNC_NORMAL_GACHA = "/gacha/syncNormalGacha";

		// Token: 0x04007AF7 RID: 31479
		[Token(Token = "0x4007AF7")]
		public const string BUY_RECRUIT_SLOT = "/gacha/buyRecruitSlot";

		// Token: 0x04007AF8 RID: 31480
		[Token(Token = "0x4007AF8")]
		public const string FINISH_NORMAL_GACHA = "/gacha/finishNormalGacha";

		// Token: 0x04007AF9 RID: 31481
		[Token(Token = "0x4007AF9")]
		public const string NORMAL_GACHA = "/gacha/normalGacha";

		// Token: 0x04007AFA RID: 31482
		[Token(Token = "0x4007AFA")]
		public const string BOOST_NORMAL_GACHA = "/gacha/boostNormalGacha";

		// Token: 0x04007AFB RID: 31483
		[Token(Token = "0x4007AFB")]
		public const string GET_POOL_DETAIL = "/gacha/getPoolDetail";

		// Token: 0x04007AFC RID: 31484
		[Token(Token = "0x4007AFC")]
		public const string ADVANCED_GACHA = "/gacha/advancedGacha";

		// Token: 0x04007AFD RID: 31485
		[Token(Token = "0x4007AFD")]
		public const string TEN_ADVANCED_GACHA = "/gacha/tenAdvancedGacha";

		// Token: 0x04007AFE RID: 31486
		[Token(Token = "0x4007AFE")]
		public const string CHOOSE_POOL_UP = "/gacha/choosePoolUp";

		// Token: 0x04007AFF RID: 31487
		[Token(Token = "0x4007AFF")]
		public const string GET_FREE_CHAR = "/gacha/getFreeChar";

		// Token: 0x04007B00 RID: 31488
		[Token(Token = "0x4007B00")]
		public const string LIST_MAIL_BOX = "/mail/listMailBox";

		// Token: 0x04007B01 RID: 31489
		[Token(Token = "0x4007B01")]
		public const string RECEIVE_MAIL = "/mail/receiveMail";

		// Token: 0x04007B02 RID: 31490
		[Token(Token = "0x4007B02")]
		public const string MAIL_GET_METAINFO_LIST = "/mail/getMetaInfoList";

		// Token: 0x04007B03 RID: 31491
		[Token(Token = "0x4007B03")]
		public const string RECEIVE_ALL_MAIL = "mail/receiveAllMail";

		// Token: 0x04007B04 RID: 31492
		[Token(Token = "0x4007B04")]
		public const string REMOVE_ALL_RECEIVED_MAIL = "mail/removeAllReceivedMail";

		// Token: 0x04007B05 RID: 31493
		[Token(Token = "0x4007B05")]
		public const string SURVEY_START = "/survey/startSurvey";

		// Token: 0x04007B06 RID: 31494
		[Token(Token = "0x4007B06")]
		public const string MAIL_ARCHIVE_GET_LIST = "/mailCollection/getList";

		// Token: 0x04007B07 RID: 31495
		[Token(Token = "0x4007B07")]
		public const string BIND_NICKNAME = "/user/bindNickName";

		// Token: 0x04007B08 RID: 31496
		[Token(Token = "0x4007B08")]
		public const string BUY_AP = "/user/buyAp";

		// Token: 0x04007B09 RID: 31497
		[Token(Token = "0x4007B09")]
		public const string DIAMOND_EXCHANGE = "/user/exchangeDiamondShard";

		// Token: 0x04007B0A RID: 31498
		[Token(Token = "0x4007B0A")]
		public const string CHANGE_RESUME = "user/changeResume";

		// Token: 0x04007B0B RID: 31499
		[Token(Token = "0x4007B0B")]
		public const string USE_ITEM = "/user/useItem";

		// Token: 0x04007B0C RID: 31500
		[Token(Token = "0x4007B0C")]
		public const string USE_ITEMS = "/user/useItems";

		// Token: 0x04007B0D RID: 31501
		[Token(Token = "0x4007B0D")]
		public const string USE_RENAME_CARD = "/user/useRenameCard";

		// Token: 0x04007B0E RID: 31502
		[Token(Token = "0x4007B0E")]
		public const string GET_VOUCHER_DETAIL = "/depot/getVoucherDetail";

		// Token: 0x04007B0F RID: 31503
		[Token(Token = "0x4007B0F")]
		public const string VOUCHER_GACHA = "/depot/voucherGacha";

		// Token: 0x04007B10 RID: 31504
		[Token(Token = "0x4007B10")]
		public const string CHAR_GACHA_VOUCHER_DETAIL = "/depot/getCharGachaVoucherDetail";

		// Token: 0x04007B11 RID: 31505
		[Token(Token = "0x4007B11")]
		public const string ITEM_GACHA_VOUCHER_DETAIL = "/depot/getMaterialVoucherDetail";

		// Token: 0x04007B12 RID: 31506
		[Token(Token = "0x4007B12")]
		public const string CHAR_GACHA_VOUCHER = "/depot/useCharGachaVoucher";

		// Token: 0x04007B13 RID: 31507
		[Token(Token = "0x4007B13")]
		public const string ITEM_GACHA_VOUCHER = "/depot/useMaterialVoucher";

		// Token: 0x04007B14 RID: 31508
		[Token(Token = "0x4007B14")]
		public const string USE_FULL_POTENTIAL_ITEM = "/depot/useFullPotentialItem";

		// Token: 0x04007B15 RID: 31509
		[Token(Token = "0x4007B15")]
		public const string USE_OPTION_VOUCHER = "/depot/useOptionVoucher";

		// Token: 0x04007B16 RID: 31510
		[Token(Token = "0x4007B16")]
		public const string ACTIVITY_CHAIN = "/activity/getChainLogInReward";

		// Token: 0x04007B17 RID: 31511
		[Token(Token = "0x4007B17")]
		public const string ACTIVITY_CHECKIN = "/activity/getOpenServerCheckInReward";

		// Token: 0x04007B18 RID: 31512
		[Token(Token = "0x4007B18")]
		public const string ACTIVITY_CHAINFINAL = "/activity/getChainLogInFinalRewards";

		// Token: 0x04007B19 RID: 31513
		[Token(Token = "0x4007B19")]
		public const string SOCIAL_FRIEND_DELETE = "/social/deleteFriend";

		// Token: 0x04007B1A RID: 31514
		[Token(Token = "0x4007B1A")]
		public const string SOCIAL_FRIEND_SEND_REQUEST = "/social/sendFriendRequest";

		// Token: 0x04007B1B RID: 31515
		[Token(Token = "0x4007B1B")]
		public const string SOCIAL_FRIEND_DEAL_REQUEST = "/social/processFriendRequest";

		// Token: 0x04007B1C RID: 31516
		[Token(Token = "0x4007B1C")]
		public const string SOCIAL_FRIEND_SEARCH_FRIEND = "/social/searchPlayer";

		// Token: 0x04007B1D RID: 31517
		[Token(Token = "0x4007B1D")]
		public const string SOCIAL_GET_SORT_FRIEND_INFO = "/social/getSortListInfo";

		// Token: 0x04007B1E RID: 31518
		[Token(Token = "0x4007B1E")]
		public const string SOCIAL_FRIEND_GET_FRIEND_LIST = "/social/getFriendList";

		// Token: 0x04007B1F RID: 31519
		[Token(Token = "0x4007B1F")]
		public const string SOCIAL_SET_STAR_FRIEND_LIST = "/social/setStarFriendList";

		// Token: 0x04007B20 RID: 31520
		[Token(Token = "0x4007B20")]
		public const string SOCIAL_FRIEND_GET_FRIEND_REQUEST_LIST = "/social/getFriendRequestList";

		// Token: 0x04007B21 RID: 31521
		[Token(Token = "0x4007B21")]
		public const string SOCIAL_FRIEND_SET_ASSIST_CHAR = "/social/setAssistCharList";

		// Token: 0x04007B22 RID: 31522
		[Token(Token = "0x4007B22")]
		public const string SOCIAL_FRIEND_SET_FRIEND_ALIAS = "/social/setFriendAlias";

		// Token: 0x04007B23 RID: 31523
		[Token(Token = "0x4007B23")]
		public const string SOCIAL_RECIEVE_SOCIRAL_POINT = "/social/receiveSocialPoint";

		// Token: 0x04007B24 RID: 31524
		[Token(Token = "0x4007B24")]
		public const string SET_CARD_SHOW_MEDAL_REQUEST = "/social/setCardShowMedal";

		// Token: 0x04007B25 RID: 31525
		[Token(Token = "0x4007B25")]
		public const string SOCIAL_GET_FRIEND_AND_REQUEST_SEND_LIST = "/social/getFriendAndRequestSendList";

		// Token: 0x04007B26 RID: 31526
		[Token(Token = "0x4007B26")]
		public const string GET_OTHER_PLAYER_NAME_CARD = "/businessCard/getOtherPlayerNameCard";

		// Token: 0x04007B27 RID: 31527
		[Token(Token = "0x4007B27")]
		public const string EDIT_NAME_CARD = "/businessCard/editNameCard";

		// Token: 0x04007B28 RID: 31528
		[Token(Token = "0x4007B28")]
		public const string MEDAL_REWARD_REQUEST = "/medal/rewardMedal";

		// Token: 0x04007B29 RID: 31529
		[Token(Token = "0x4007B29")]
		public const string MEDAL_SET_CUSTOM_DATA = "/medal/setCustomData";

		// Token: 0x04007B2A RID: 31530
		[Token(Token = "0x4007B2A")]
		public const string CHECKIN_HOME = "/user/checkIn";

		// Token: 0x04007B2B RID: 31531
		[Token(Token = "0x4007B2B")]
		public const string CHANGE_SECRETARY = "/user/changeSecretary";

		// Token: 0x04007B2C RID: 31532
		[Token(Token = "0x4007B2C")]
		public const string RECEIVE_TEAMCOLLECTION_REWARD = "/user/receiveTeamCollectionReward";

		// Token: 0x04007B2D RID: 31533
		[Token(Token = "0x4007B2D")]
		public const string UNLOCK_CHAR_WORD_STORY = "/charBuild/addonStory/unlock";

		// Token: 0x04007B2E RID: 31534
		[Token(Token = "0x4007B2E")]
		public const string BATTLE_START_ADDON = "charBuild/addonStage/battleStart";

		// Token: 0x04007B2F RID: 31535
		[Token(Token = "0x4007B2F")]
		public const string BATTLE_FINISH_ADDON = "charBuild/addonStage/battleFinish";

		// Token: 0x04007B30 RID: 31536
		[Token(Token = "0x4007B30")]
		public const string MISSION_EXCHANGEMISSIONREWARDS = "/mission/exchangeMissionRewards";

		// Token: 0x04007B31 RID: 31537
		[Token(Token = "0x4007B31")]
		public const string MISSION_CONFIRMMISSION = "mission/confirmMission";

		// Token: 0x04007B32 RID: 31538
		[Token(Token = "0x4007B32")]
		public const string MISSION_CONFIRMMISSION_LIST = "mission/confirmMissionList ";

		// Token: 0x04007B33 RID: 31539
		[Token(Token = "0x4007B33")]
		public const string MISSION_CONFIRMMISSIONGROUP = "mission/confirmMissionGroup";

		// Token: 0x04007B34 RID: 31540
		[Token(Token = "0x4007B34")]
		public const string MISSION_CONFIRM_MULTI_GROUP_MISSION_LIST = "/mission/confirmMultiGroupMissionList";

		// Token: 0x04007B35 RID: 31541
		[Token(Token = "0x4007B35")]
		public const string MISSION_AUTOCONFIRMMISSIONS = "mission/autoConfirmMissions";

		// Token: 0x04007B36 RID: 31542
		[Token(Token = "0x4007B36")]
		public const string CHECK_FORBIDDEN = "/shop/checkForbidden";

		// Token: 0x04007B37 RID: 31543
		[Token(Token = "0x4007B37")]
		public const string SHOP_GET_FURNITURESHOP_LIST = "shop/getFurniGoodList";

		// Token: 0x04007B38 RID: 31544
		[Token(Token = "0x4007B38")]
		public const string SHOP_BUY_FURNITURE_ITEM = "shop/buyFurniGood";

		// Token: 0x04007B39 RID: 31545
		[Token(Token = "0x4007B39")]
		public const string SHOP_SKIN_LIST = "shop/getSkinGoodList";

		// Token: 0x04007B3A RID: 31546
		[Token(Token = "0x4007B3A")]
		public const string SHOP_CASH_LIST = "shop/getCashGoodList";

		// Token: 0x04007B3B RID: 31547
		[Token(Token = "0x4007B3B")]
		public const string SHOP_HIGH_QC_LIST = "shop/getHighGoodList";

		// Token: 0x04007B3C RID: 31548
		[Token(Token = "0x4007B3C")]
		public const string SHOP_LOW_QC_LIST = "shop/getLowGoodList";

		// Token: 0x04007B3D RID: 31549
		[Token(Token = "0x4007B3D")]
		public const string SHOP_CLASSIC_QC_LIST = "shop/getClassicGoodList";

		// Token: 0x04007B3E RID: 31550
		[Token(Token = "0x4007B3E")]
		public const string SHOP_EXTRA_QC_LIST = "shop/getExtraGoodList";

		// Token: 0x04007B3F RID: 31551
		[Token(Token = "0x4007B3F")]
		public const string SHOP_LMTGS_LIST = "shop/getLMTGSGoodList";

		// Token: 0x04007B40 RID: 31552
		[Token(Token = "0x4007B40")]
		public const string SHOP_EPGS_LIST = "shop/getEPGSGoodList";

		// Token: 0x04007B41 RID: 31553
		[Token(Token = "0x4007B41")]
		public const string SHOP_REP_LIST = "shop/getRepGoodList";

		// Token: 0x04007B42 RID: 31554
		[Token(Token = "0x4007B42")]
		public const string SHOP_GP_LIST = "shop/getGPGoodList";

		// Token: 0x04007B43 RID: 31555
		[Token(Token = "0x4007B43")]
		public const string SHOP_SOCIAL_LIST = "shop/getSocialGoodList";

		// Token: 0x04007B44 RID: 31556
		[Token(Token = "0x4007B44")]
		public const string SHOP_PURCHASE_STATE = "shop/getGoodPurchaseState";

		// Token: 0x04007B45 RID: 31557
		[Token(Token = "0x4007B45")]
		public const string SHOP_DECOMPOSE_POTENTIAL = "shop/decomposePotentialItem";

		// Token: 0x04007B46 RID: 31558
		[Token(Token = "0x4007B46")]
		public const string SHOP_DECOMPOSE_CLASSIC_POTENTIAL = "shop/decomposeClassicPotentialItem";

		// Token: 0x04007B47 RID: 31559
		[Token(Token = "0x4007B47")]
		public const string SHOP_BUY_HIGH_GOOD = "shop/buyHighGood";

		// Token: 0x04007B48 RID: 31560
		[Token(Token = "0x4007B48")]
		public const string SHOP_BUY_EXTRA_GOOD = "shop/buyExtraGood";

		// Token: 0x04007B49 RID: 31561
		[Token(Token = "0x4007B49")]
		public const string SHOP_BUY_LOW_GOOD = "shop/buyLowGood";

		// Token: 0x04007B4A RID: 31562
		[Token(Token = "0x4007B4A")]
		public const string SHOP_BUY_CLASSIC_GOOD = "shop/buyClassicGood";

		// Token: 0x04007B4B RID: 31563
		[Token(Token = "0x4007B4B")]
		public const string SHOP_BUY_GP_GOOD = "shop/buyGPGood";

		// Token: 0x04007B4C RID: 31564
		[Token(Token = "0x4007B4C")]
		public const string SHOP_BUY_GP_GOOD_WITH_TICKET = "/shop/buyGPGoodWithTicket";

		// Token: 0x04007B4D RID: 31565
		[Token(Token = "0x4007B4D")]
		public const string SHOP_BUY_SKIN_GOOD = "shop/buySkinGood";

		// Token: 0x04007B4E RID: 31566
		[Token(Token = "0x4007B4E")]
		public const string SHOP_BUY_BLINDBOX_GOOD = "shop/buyGachaSkinGood";

		// Token: 0x04007B4F RID: 31567
		[Token(Token = "0x4007B4F")]
		public const string SHOP_FURN_GROUP_GOOD = "/shop/buyFurniGroup";

		// Token: 0x04007B50 RID: 31568
		[Token(Token = "0x4007B50")]
		public const string SHOP_BUY_CASH_GOOD = "shop/buyCashGood";

		// Token: 0x04007B51 RID: 31569
		[Token(Token = "0x4007B51")]
		public const string SHOP_BUY_SOCIAL_GOOD = "shop/buySocialGood";

		// Token: 0x04007B52 RID: 31570
		[Token(Token = "0x4007B52")]
		public const string SHOP_GET_CASH_PURCHASE_RESULT = "shop/getCashGoodPurchaseResult";

		// Token: 0x04007B53 RID: 31571
		[Token(Token = "0x4007B53")]
		public const string SHOP_BUY_LMTGS_GOOD = "shop/buyLMTGSGood";

		// Token: 0x04007B54 RID: 31572
		[Token(Token = "0x4007B54")]
		public const string SHOP_BUY_EPGS_GOOD = "shop/buyEPGSGood";

		// Token: 0x04007B55 RID: 31573
		[Token(Token = "0x4007B55")]
		public const string SHOP_BUY_REP_GOOD = "shop/buyRepGood";

		// Token: 0x04007B56 RID: 31574
		[Token(Token = "0x4007B56")]
		public const string SHOP_GET_VOUCHER_SKIN_GOOD_LIST = "shop/getVoucherSkinGoodList";

		// Token: 0x04007B57 RID: 31575
		[Token(Token = "0x4007B57")]
		public const string SHOP_USE_VOUCHER_SKIN = "shop/useVoucherSkin";

		// Token: 0x04007B58 RID: 31576
		[Token(Token = "0x4007B58")]
		public const string TEMPLATE_SHOP_GET_GOOD_LIST = "templateShop/getGoodList";

		// Token: 0x04007B59 RID: 31577
		[Token(Token = "0x4007B59")]
		public const string TEMPLATE_SHOP_BUY_GOOD = "templateShop/buyGood";

		// Token: 0x04007B5A RID: 31578
		[Token(Token = "0x4007B5A")]
		public const string TEMPLATE_TRAP_SET_SQUAD_LIST = "/templateTrap/setTrapSquad";

		// Token: 0x04007B5B RID: 31579
		[Token(Token = "0x4007B5B")]
		public const string CHANGE_AVATAR = "/user/changeAvatar";

		// Token: 0x04007B5C RID: 31580
		[Token(Token = "0x4007B5C")]
		public const string UNLOCK_EQUIPMENT = "/charBuild/unlockEquipment";

		// Token: 0x04007B5D RID: 31581
		[Token(Token = "0x4007B5D")]
		public const string UPGRADE_EQUIPMENT = "/charBuild/upgradeEquipment";

		// Token: 0x04007B5E RID: 31582
		[Token(Token = "0x4007B5E")]
		public const string SET_CHAR_VOICE_LAN = "/charBuild/setCharVoiceLan";

		// Token: 0x04007B5F RID: 31583
		[Token(Token = "0x4007B5F")]
		public const string BATCH_SET_CHAR_VOICE_LAN = "/charBuild/batchSetCharVoiceLan";

		// Token: 0x04007B60 RID: 31584
		[Token(Token = "0x4007B60")]
		public const string CHANGE_NPC_VOICE_LAN = "/npcAudio/changeLan";

		// Token: 0x04007B61 RID: 31585
		[Token(Token = "0x4007B61")]
		public const string SET_BACK_GROUND = "/background/setBackground";

		// Token: 0x04007B62 RID: 31586
		[Token(Token = "0x4007B62")]
		public const string SET_THEME = "/homeTheme/change";

		// Token: 0x04007B63 RID: 31587
		[Token(Token = "0x4007B63")]
		public const string SET_LOW_POWER = "/setting/perf/setLowPower";

		// Token: 0x04007B64 RID: 31588
		[Token(Token = "0x4007B64")]
		public const string CRISIS_BATTLE_START = "crisis/battleStart";

		// Token: 0x04007B65 RID: 31589
		[Token(Token = "0x4007B65")]
		public const string CRISIS_BATTLE_FINISH = "crisis/battleFinish";

		// Token: 0x04007B66 RID: 31590
		[Token(Token = "0x4007B66")]
		public const string CRISIS_GET_INFO = "crisis/getInfo";

		// Token: 0x04007B67 RID: 31591
		[Token(Token = "0x4007B67")]
		public const string CRISIS_GET_SHOP_INFO = "crisis/getGoodList";

		// Token: 0x04007B68 RID: 31592
		[Token(Token = "0x4007B68")]
		public const string CRISIS_BUY_GOODS = "crisis/buyGoods";

		// Token: 0x04007B69 RID: 31593
		[Token(Token = "0x4007B69")]
		public const string CRISIS_CHALLENGE_REWARD_TSK = "crisis/challengeRewardTask";

		// Token: 0x04007B6A RID: 31594
		[Token(Token = "0x4007B6A")]
		public const string CRISIS_CHALLENGE_REWARD_LEVEL = "crisis/challengeRewardPoint";

		// Token: 0x04007B6B RID: 31595
		[Token(Token = "0x4007B6B")]
		public const string CRISIS_CHALLENGE_REWARD_ALL = "crisis/challengeRewardAll";

		// Token: 0x04007B6C RID: 31596
		[Token(Token = "0x4007B6C")]
		public const string CRISIS_UNLOCK_MAP_REWARD_ALL = "crisis/unlockMapRank";

		// Token: 0x04007B6D RID: 31597
		[Token(Token = "0x4007B6D")]
		public const string CRISIS_UNLOCK_RUNE = "crisis/unlockRune";

		// Token: 0x04007B6E RID: 31598
		[Token(Token = "0x4007B6E")]
		public const string CRISIS_GET_ALL_ITEMS = "crisis/getAllItems";

		// Token: 0x04007B6F RID: 31599
		[Token(Token = "0x4007B6F")]
		public const string CRISIS_V2_GET_INFO = "crisisV2/getInfo";

		// Token: 0x04007B70 RID: 31600
		[Token(Token = "0x4007B70")]
		public const string CRISIS_V2_GET_SNAPSHOT = "crisisV2/getSnapshot";

		// Token: 0x04007B71 RID: 31601
		[Token(Token = "0x4007B71")]
		public const string CRISIS_V2_GET_SHOP_INFO = "crisisV2/getGoodList";

		// Token: 0x04007B72 RID: 31602
		[Token(Token = "0x4007B72")]
		public const string CRISIS_V2_GET_MISSION_REWARDS = "crisisV2/confirmMissions";

		// Token: 0x04007B73 RID: 31603
		[Token(Token = "0x4007B73")]
		public const string CRISIS_V2_BATTLE_START = "crisisV2/battleStart";

		// Token: 0x04007B74 RID: 31604
		[Token(Token = "0x4007B74")]
		public const string CRISIS_V2_BATTLE_FINISH = "crisisV2/battleFinish";

		// Token: 0x04007B75 RID: 31605
		[Token(Token = "0x4007B75")]
		public const string CRISIS_V2_BUY_GOODS = "crisisV2/buyGood";

		// Token: 0x04007B76 RID: 31606
		[Token(Token = "0x4007B76")]
		public const string RECAL_RUNE_BATTLE_START = "recalRune/battleStart";

		// Token: 0x04007B77 RID: 31607
		[Token(Token = "0x4007B77")]
		public const string RECAL_RUNE_BATTLE_FINISH = "recalRune/battleFinish";

		// Token: 0x04007B78 RID: 31608
		[Token(Token = "0x4007B78")]
		public const string RECAL_RUNE_SEASON_REWARD = "recalRune/gainSeasonReward";

		// Token: 0x04007B79 RID: 31609
		[Token(Token = "0x4007B79")]
		public const string CHAR_BUILD_INC_INTIMACY = "building/gainIntimacy";

		// Token: 0x04007B7A RID: 31610
		[Token(Token = "0x4007B7A")]
		public const string CHAR_BUILD_INC_ASSIST_INTIMACY = "building/gainAssistIntimacy";

		// Token: 0x04007B7B RID: 31611
		[Token(Token = "0x4007B7B")]
		public const string CHAR_BUILD_ALL_INTIMACY = "building/gainAllIntimacy";

		// Token: 0x04007B7C RID: 31612
		[Token(Token = "0x4007B7C")]
		public const string SOCIAL_VISIT_BUILDING = "building/visitBuilding";

		// Token: 0x04007B7D RID: 31613
		[Token(Token = "0x4007B7D")]
		public const string BUILDING_UPGRADE_ROOM = "building/upgradeRoom";

		// Token: 0x04007B7E RID: 31614
		[Token(Token = "0x4007B7E")]
		public const string BUILDING_UPGRADE_COMPLETE_ROOM = "building/completeUpgradeRoom";

		// Token: 0x04007B7F RID: 31615
		[Token(Token = "0x4007B7F")]
		public const string BUILDING_SETTLE_MANUFACT = "building/settleManufacture";

		// Token: 0x04007B80 RID: 31616
		[Token(Token = "0x4007B80")]
		public const string BUILDING_SYNC = "building/sync";

		// Token: 0x04007B81 RID: 31617
		[Token(Token = "0x4007B81")]
		public const string BUILDING_BUILD_ROOM = "building/buildRoom";

		// Token: 0x04007B82 RID: 31618
		[Token(Token = "0x4007B82")]
		public const string BUILDING_CLEAN_ROOM_SLOT = "building/cleanRoomSlot";

		// Token: 0x04007B83 RID: 31619
		[Token(Token = "0x4007B83")]
		public const string BUILDING_VISIT_BUILDING = "building/visitBuilding";

		// Token: 0x04007B84 RID: 31620
		[Token(Token = "0x4007B84")]
		public const string BUILDING_CHANGE_MANUF_FORMULA = "building/changeManufactureSolution";

		// Token: 0x04007B85 RID: 31621
		[Token(Token = "0x4007B85")]
		public const string BUILDING_CHANGE_SHOP_FORUMULA = "building/changeSaleSolution";

		// Token: 0x04007B86 RID: 31622
		[Token(Token = "0x4007B86")]
		public const string BUILDING_ASSIGN_CHAR = "building/assignChar";

		// Token: 0x04007B87 RID: 31623
		[Token(Token = "0x4007B87")]
		public const string BUILDING_SETTLE_SALE = "building/settleSale";

		// Token: 0x04007B88 RID: 31624
		[Token(Token = "0x4007B88")]
		public const string BUILDING_DEGRADE_ROOM = "building/degradeRoom";

		// Token: 0x04007B89 RID: 31625
		[Token(Token = "0x4007B89")]
		public const string BUILDING_DEGRADE_DIY_ROOM = "building/upgradeDiyLevel";

		// Token: 0x04007B8A RID: 31626
		[Token(Token = "0x4007B8A")]
		public const string BUILDING_CHANGE_DIY_SOLUTION = "building/changeDiySolution";

		// Token: 0x04007B8B RID: 31627
		[Token(Token = "0x4007B8B")]
		public const string BUILDING_SAVE_DIY_PRESET_SOLUTION = "building/saveDiyPresetSolution";

		// Token: 0x04007B8C RID: 31628
		[Token(Token = "0x4007B8C")]
		public const string BUILDING_RENAME_DIY_PRESET_SOLUTION = "building/changePresetName";

		// Token: 0x04007B8D RID: 31629
		[Token(Token = "0x4007B8D")]
		public const string BUILDING_GET_DIY_PRESET_THUMBNAIL_URL = "building/getThumbnailUrl";

		// Token: 0x04007B8E RID: 31630
		[Token(Token = "0x4007B8E")]
		public const string BUILDING_UPDATE_SKILL = "building/upgradeSpecialization";

		// Token: 0x04007B8F RID: 31631
		[Token(Token = "0x4007B8F")]
		public const string BUILDING_FINISH_UPDATE_SKILL = "building/completeUpgradeSpecialization";

		// Token: 0x04007B90 RID: 31632
		[Token(Token = "0x4007B90")]
		public const string BUILDING_WORKSHOP_SYNTHESIS = "building/workshopSynthesis";

		// Token: 0x04007B91 RID: 31633
		[Token(Token = "0x4007B91")]
		public const string BUILDING_WORKSHOP_FURN_DECOMPOSITE = "building/workshopDecomposition";

		// Token: 0x04007B92 RID: 31634
		[Token(Token = "0x4007B92")]
		public const string BUILDING_FRIEND_GET_SORT_LIST = "/building/getClueFriendList";

		// Token: 0x04007B93 RID: 31635
		[Token(Token = "0x4007B93")]
		public const string BUILDING_DELIVERY_ORDER = "building/deliveryOrder";

		// Token: 0x04007B94 RID: 31636
		[Token(Token = "0x4007B94")]
		public const string BUILDING_CHANGE_STRATEGY = "building/changeStrategy";

		// Token: 0x04007B95 RID: 31637
		[Token(Token = "0x4007B95")]
		public const string BUILDING_DELETE_ORDER = "building/deleteOrder";

		// Token: 0x04007B96 RID: 31638
		[Token(Token = "0x4007B96")]
		public const string BUILDING_ACCELERATE_ORDER = "building/accelerateOrder";

		// Token: 0x04007B97 RID: 31639
		[Token(Token = "0x4007B97")]
		public const string BUILDING_ACCELERATE_SOLUTION = "building/accelerateSolution";

		// Token: 0x04007B98 RID: 31640
		[Token(Token = "0x4007B98")]
		public const string BUILDING_BUY_LABOR = "building/buyLabor";

		// Token: 0x04007B99 RID: 31641
		[Token(Token = "0x4007B99")]
		public const string BUILDING_GET_ASSIST_REPORT = "building/getAssistReport";

		// Token: 0x04007B9A RID: 31642
		[Token(Token = "0x4007B9A")]
		public const string BUILDING_SET_ASSIST = "building/setBuildingAssist";

		// Token: 0x04007B9B RID: 31643
		[Token(Token = "0x4007B9B")]
		public const string BUILDING_DELETE_OWN_CLUE = "building/deleteOwnClue";

		// Token: 0x04007B9C RID: 31644
		[Token(Token = "0x4007B9C")]
		public const string BUILDING_DELETE_RECEIVE_CLUE = "building/deleteReceiveClue";

		// Token: 0x04007B9D RID: 31645
		[Token(Token = "0x4007B9D")]
		public const string BUILDING_PUT_CLUE_TO_THE_BOARD = "building/putClueToTheBoard";

		// Token: 0x04007B9E RID: 31646
		[Token(Token = "0x4007B9E")]
		public const string BUILDING_AUTO_EQUIP_CLUES = "building/putClueToTheBoardAuto";

		// Token: 0x04007B9F RID: 31647
		[Token(Token = "0x4007B9F")]
		public const string BUILDING_AUTO_SEND_CLUES = "building/sendClueAuto";

		// Token: 0x04007BA0 RID: 31648
		[Token(Token = "0x4007BA0")]
		public const string BUILDING_SEND_CLUE = "building/sendClue";

		// Token: 0x04007BA1 RID: 31649
		[Token(Token = "0x4007BA1")]
		public const string BUILDING_GET_MEETING_ROOM_REWARD = "building/getMeetingroomReward";

		// Token: 0x04007BA2 RID: 31650
		[Token(Token = "0x4007BA2")]
		public const string BUILDING_GET_CLUE_BOX = "building/getClueBox";

		// Token: 0x04007BA3 RID: 31651
		[Token(Token = "0x4007BA3")]
		public const string BUILDING_RECEIVE_CLUE_TO_STOCK = "building/receiveClueToStock";

		// Token: 0x04007BA4 RID: 31652
		[Token(Token = "0x4007BA4")]
		public const string BUILDING_START_INFO_SHARE = "building/startInfoShare";

		// Token: 0x04007BA5 RID: 31653
		[Token(Token = "0x4007BA5")]
		public const string BUILDING_TAKE_CLUE_FROM_BOARD = "building/takeClueFromBoard";

		// Token: 0x04007BA6 RID: 31654
		[Token(Token = "0x4007BA6")]
		public const string BUILDING_GET_INFO_SHARE_VISITOR_NUM = "building/getInfoShareVisitorsNum";

		// Token: 0x04007BA7 RID: 31655
		[Token(Token = "0x4007BA7")]
		public const string BUILDING_RECEIVE_INFO_SHARE_REWARD = "building/getInfoShareReward";

		// Token: 0x04007BA8 RID: 31656
		[Token(Token = "0x4007BA8")]
		public const string BUILDING_GET_RECENT_VISITOR = "building/getRecentVisitors";

		// Token: 0x04007BA9 RID: 31657
		[Token(Token = "0x4007BA9")]
		public const string BUILDING_GET_DAILY_CLUE = "building/getDailyClue";

		// Token: 0x04007BAA RID: 31658
		[Token(Token = "0x4007BAA")]
		public const string BUILDING_BATCH_DELIVERY = "building/deliveryBatchOrder";

		// Token: 0x04007BAB RID: 31659
		[Token(Token = "0x4007BAB")]
		public const string BUILDING_GET_MESSAGE_BOARD_CONTENT = "building/getMessageBoardContent";

		// Token: 0x04007BAC RID: 31660
		[Token(Token = "0x4007BAC")]
		public const string BUILDING_GET_OTHER_MESSAGE_BOARD_CONTENT = "building/getOthersMessageBoardContent";

		// Token: 0x04007BAD RID: 31661
		[Token(Token = "0x4007BAD")]
		public const string BUILDING_CONFIRM_MESSAGE_BOARD_REWARD = "building/confirmMessageBoardReward";

		// Token: 0x04007BAE RID: 31662
		[Token(Token = "0x4007BAE")]
		public const string BUILDING_SET_PRIVATE_DORM_OWNER = "building/setPrivateDormOwner";

		// Token: 0x04007BAF RID: 31663
		[Token(Token = "0x4007BAF")]
		public const string BUILDING_CONFIRM_PRIVATE_DORM_INTIMACY = "building/confirmPrivateDormIntimacy";

		// Token: 0x04007BB0 RID: 31664
		[Token(Token = "0x4007BB0")]
		public const string BUILDING_SEND_EMOJI = "building/sendEmoji";

		// Token: 0x04007BB1 RID: 31665
		[Token(Token = "0x4007BB1")]
		public const string BUILDING_BATCH_WORK = "building/batchChangeWorkChar";

		// Token: 0x04007BB2 RID: 31666
		[Token(Token = "0x4007BB2")]
		public const string BUILDING_BATCH_REST = "building/batchRestChar";

		// Token: 0x04007BB3 RID: 31667
		[Token(Token = "0x4007BB3")]
		public const string BUILDING_ADD_PRESET_QUEUE = "/building/addPresetQueue";

		// Token: 0x04007BB4 RID: 31668
		[Token(Token = "0x4007BB4")]
		public const string BUILDING_DELETE_PRESET_QUEUE = "/building/deletePresetQueue";

		// Token: 0x04007BB5 RID: 31669
		[Token(Token = "0x4007BB5")]
		public const string BUILDING_EDIT_PRESET_QUEUE = "/building/editPresetQueue";

		// Token: 0x04007BB6 RID: 31670
		[Token(Token = "0x4007BB6")]
		public const string BUILDING_USE_PRESET_QUEUE = "/building/useOnePresetQueue";

		// Token: 0x04007BB7 RID: 31671
		[Token(Token = "0x4007BB7")]
		public const string BUILDING_SET_BGM = "/building/changeBGM";

		// Token: 0x04007BB8 RID: 31672
		[Token(Token = "0x4007BB8")]
		public const string BUILDING_DORM_LOCK = "/building/editLockQueue";

		// Token: 0x04007BB9 RID: 31673
		[Token(Token = "0x4007BB9")]
		public const string STORY_REVIEW_UNLOCK = "storyreview/unlockStoryByCoin";

		// Token: 0x04007BBA RID: 31674
		[Token(Token = "0x4007BBA")]
		public const string STORY_REVIEW_READ = "storyreview/readStory";

		// Token: 0x04007BBB RID: 31675
		[Token(Token = "0x4007BBB")]
		public const string STORY_REVIEW_GET_REWARDS = "storyreview/rewardGroup";

		// Token: 0x04007BBC RID: 31676
		[Token(Token = "0x4007BBC")]
		public const string MARK_STORY_ACCE_KNOWN = "storyreview/markStoryAcceKnown";

		// Token: 0x04007BBD RID: 31677
		[Token(Token = "0x4007BBD")]
		public const string STORY_REVIEW_GET_TRIAL_REWARD = "storyreview/trailReward";

		// Token: 0x04007BBE RID: 31678
		[Token(Token = "0x4007BBE")]
		public const string BATTLE_START_TRAINING_CAMP = "/trainingGround/battleStart";

		// Token: 0x04007BBF RID: 31679
		[Token(Token = "0x4007BBF")]
		public const string BATTLE_FINISH_TRAINING_CAMP = "/trainingGround/battleFinish";

		// Token: 0x04007BC0 RID: 31680
		[Token(Token = "0x4007BC0")]
		public const string ROGUELIKE_SELECT_INITIAL_RELIC = "/rlv2/chooseInitialRelic";

		// Token: 0x04007BC1 RID: 31681
		[Token(Token = "0x4007BC1")]
		public const string ROGUELIKE_SELECT_INITIAL_CHOICE = "roguelike/chooseInitialScene";

		// Token: 0x04007BC2 RID: 31682
		[Token(Token = "0x4007BC2")]
		public const string ROGUELIKE_SELECT_INITIAL_RECRUIT_SET = "/rlv2/chooseInitialRecruitSet";

		// Token: 0x04007BC3 RID: 31683
		[Token(Token = "0x4007BC3")]
		public const string ROGUELIKE_MOVE_TO = "rlv2/moveTo";

		// Token: 0x04007BC4 RID: 31684
		[Token(Token = "0x4007BC4")]
		public const string ROGUELIKE_FINISH_REWARD = "/rlv2/finishBattleReward";

		// Token: 0x04007BC5 RID: 31685
		[Token(Token = "0x4007BC5")]
		public const string ROGUELIKE_SHOP_ACTION = "rlv2/shopAction";

		// Token: 0x04007BC6 RID: 31686
		[Token(Token = "0x4007BC6")]
		public const string ROGUELIKE_BANK_INVEST = "/rlv2/bankPut";

		// Token: 0x04007BC7 RID: 31687
		[Token(Token = "0x4007BC7")]
		public const string ROGUELIKE_BANK_WITHDRAW = "/rlv2/bankWithdraw";

		// Token: 0x04007BC8 RID: 31688
		[Token(Token = "0x4007BC8")]
		public const string ROGUELIKE_SELECT_REWARD = "/rlv2/chooseBattleReward";

		// Token: 0x04007BC9 RID: 31689
		[Token(Token = "0x4007BC9")]
		public const string ROGUELIKE_SELECT_CHOICE = "rlv2/selectChoice";

		// Token: 0x04007BCA RID: 31690
		[Token(Token = "0x4007BCA")]
		public const string ROGUELIKE_CONFIRM_NODE_MISSION = "rlv2/nodeMission/confirm";

		// Token: 0x04007BCB RID: 31691
		[Token(Token = "0x4007BCB")]
		public const string ROGUELIKE_GIVE_UP_NODE_MISSION = "rlv2/nodeMission/giveUp";

		// Token: 0x04007BCC RID: 31692
		[Token(Token = "0x4007BCC")]
		public const string ROGUELIKE_READ_MISSION_TIP = "rlv2/nodeMission/closeTip";

		// Token: 0x04007BCD RID: 31693
		[Token(Token = "0x4007BCD")]
		public const string ROGUELIKE_ACTIVATE_TICKET = "/rlv2/activeRecruitTicket";

		// Token: 0x04007BCE RID: 31694
		[Token(Token = "0x4007BCE")]
		public const string ROGUELIKE_CLOSE_TICKET = "/rlv2/closeRecruitTicket";

		// Token: 0x04007BCF RID: 31695
		[Token(Token = "0x4007BCF")]
		public const string ROGUELIKE_RECRUIT_CHAR = "/rlv2/recruitChar";

		// Token: 0x04007BD0 RID: 31696
		[Token(Token = "0x4007BD0")]
		public const string ROGUELIKE_ENDING_CHANGE_READ = "/rlv2/readEndingChange";

		// Token: 0x04007BD1 RID: 31697
		[Token(Token = "0x4007BD1")]
		public const string ROGUELIKE_ROLL_NODE = "/rlv2/rerollNode";

		// Token: 0x04007BD2 RID: 31698
		[Token(Token = "0x4007BD2")]
		public const string ROGUELIKE_UPGRADE_NODE = "/rlv2/upgradeNode";

		// Token: 0x04007BD3 RID: 31699
		[Token(Token = "0x4007BD3")]
		public const string ROGUELIKE_GET_TICKET_ASSIST_LIST = "/rlv2/getTicketAssistList";

		// Token: 0x04007BD4 RID: 31700
		[Token(Token = "0x4007BD4")]
		public const string ROGUELIKE_RECRUIT_ASSIST_CHAR = "/rlv2/recruitAssistChar";

		// Token: 0x04007BD5 RID: 31701
		[Token(Token = "0x4007BD5")]
		public const string ROGUELIKE_UPGRADE_CHAR = "roguelike/upgradeChar";

		// Token: 0x04007BD6 RID: 31702
		[Token(Token = "0x4007BD6")]
		public const string ROGUELIKE_BATTLE_START = "/rlv2/moveAndBattleStart";

		// Token: 0x04007BD7 RID: 31703
		[Token(Token = "0x4007BD7")]
		public const string ROGUELIKE_BATTLE_FINISH = "/rlv2/battleFinish";

		// Token: 0x04007BD8 RID: 31704
		[Token(Token = "0x4007BD8")]
		public const string ROGUELIKE_FINISH_EVENT = "/rlv2/finishEvent";

		// Token: 0x04007BD9 RID: 31705
		[Token(Token = "0x4007BD9")]
		public const string ROGUELIKE_DICE_CHOICE = "/rlv2/diceChoice";

		// Token: 0x04007BDA RID: 31706
		[Token(Token = "0x4007BDA")]
		public const string ROGUELIKE_SACRIFICE_CHOICE = "/rlv2/sacrificeChoice";

		// Token: 0x04007BDB RID: 31707
		[Token(Token = "0x4007BDB")]
		public const string ROGUELIKE_GILD_CHOICE = "/rlv2/copper/gild";

		// Token: 0x04007BDC RID: 31708
		[Token(Token = "0x4007BDC")]
		public const string ROGUELIKE_EXPEDITION_CHOICE = "/rlv2/expeditionChoice";

		// Token: 0x04007BDD RID: 31709
		[Token(Token = "0x4007BDD")]
		public const string ROGUELIKE_EXPEDITION_RETURN_CHOICE = "/rlv2/game/confirmExpeditonReturn";

		// Token: 0x04007BDE RID: 31710
		[Token(Token = "0x4007BDE")]
		public const string ROGUELIKE_SHOP_BATTLE_START = "/rlv2/shopBattleStart";

		// Token: 0x04007BDF RID: 31711
		[Token(Token = "0x4007BDF")]
		public const string ROGUELIKE_SHOP_REFRESH = "/rlv2/refreshShop";

		// Token: 0x04007BE0 RID: 31712
		[Token(Token = "0x4007BE0")]
		public const string ROGUELIKE_TOPIC_PIN = "/rlv2/setPinned";

		// Token: 0x04007BE1 RID: 31713
		[Token(Token = "0x4007BE1")]
		public const string ROGUELIKE_ZONE_REWARD = "/rlv2/confirmZoneReward";

		// Token: 0x04007BE2 RID: 31714
		[Token(Token = "0x4007BE2")]
		public const string ROGUELIKE_TRADER_RETURN = "/rlv2/confirmTraderReturn";

		// Token: 0x04007BE3 RID: 31715
		[Token(Token = "0x4007BE3")]
		public const string ROGUELIKE_USE_STASHED_TICKET = "/rlv2/useStashedTicket";

		// Token: 0x04007BE4 RID: 31716
		[Token(Token = "0x4007BE4")]
		public const string ROGUELIKE_STASH_TICKET = "/rlv2/stashRecruitTicket";

		// Token: 0x04007BE5 RID: 31717
		[Token(Token = "0x4007BE5")]
		public const string ROGUELIKE_SPECIAL_ZONE_LEAVE = "/rlv2/specialZone/leave";

		// Token: 0x04007BE6 RID: 31718
		[Token(Token = "0x4007BE6")]
		public const string ROGUELIKE_CHOOSE_INITIAL_EXPLORE_TOOL = "/rlv2/chooseInitialExploreTool";

		// Token: 0x04007BE7 RID: 31719
		[Token(Token = "0x4007BE7")]
		public const string CLIMB_TOWER_LAYER_FIRST_PASS_REWARD = "/tower/layerReward";

		// Token: 0x04007BE8 RID: 31720
		[Token(Token = "0x4007BE8")]
		public const string CLIMB_TOWER_CREATE_GAME = "/tower/createGame";

		// Token: 0x04007BE9 RID: 31721
		[Token(Token = "0x4007BE9")]
		public const string CLIMB_TOWER_SETTLE_GAME = "/tower/settleGame";

		// Token: 0x04007BEA RID: 31722
		[Token(Token = "0x4007BEA")]
		public const string CLIMB_TOWER_INIT_GOD_CARD = "/tower/initGodCard";

		// Token: 0x04007BEB RID: 31723
		[Token(Token = "0x4007BEB")]
		public const string CLIMB_TOWER_INIT_GAME = "/tower/initGame";

		// Token: 0x04007BEC RID: 31724
		[Token(Token = "0x4007BEC")]
		public const string CLIMB_TOWER_INIT_SQUAD = "/tower/initCard";

		// Token: 0x04007BED RID: 31725
		[Token(Token = "0x4007BED")]
		public const string CLIMB_TOWER_BATTLE_START = "/tower/battleStart";

		// Token: 0x04007BEE RID: 31726
		[Token(Token = "0x4007BEE")]
		public const string CLIMB_TOWER_BATTLE_FINISH = "/tower/battleFinish";

		// Token: 0x04007BEF RID: 31727
		[Token(Token = "0x4007BEF")]
		public const string CLIMB_TOWER_HALF_TIME_RECRUIT = "/tower/recruit";

		// Token: 0x04007BF0 RID: 31728
		[Token(Token = "0x4007BF0")]
		public const string CLIMB_TOWER_RECRUIT_SUB_GOD_CARD = "/tower/chooseSubGodCard";

		// Token: 0x04007BF1 RID: 31729
		[Token(Token = "0x4007BF1")]
		public const string CLIMB_TOWER_SEASON_MISSION_AWARD = "/tower/seasonMissonsAward";

		// Token: 0x04007BF2 RID: 31730
		[Token(Token = "0x4007BF2")]
		public const string CLIMB_TOWER_SWEEP = "/tower/sweepGame";

		// Token: 0x04007BF3 RID: 31731
		[Token(Token = "0x4007BF3")]
		public const string PAY_CREATE_ORDER = "/pay/createOrder";

		// Token: 0x04007BF4 RID: 31732
		[Token(Token = "0x4007BF4")]
		public const string PAY_CONFIRM_ORDER = "/pay/confirmOrder";

		// Token: 0x04007BF5 RID: 31733
		[Token(Token = "0x4007BF5")]
		public const string PAY_GET_UNCONFIRMED_ORDER_LIST = "/pay/getUnconfirmedOrderIdList";

		// Token: 0x04007BF6 RID: 31734
		[Token(Token = "0x4007BF6")]
		public const string VEC_BREAK_V2_OFFENSE_BATTLE_START = "/activity/vecBreakV2/battleStart";

		// Token: 0x04007BF7 RID: 31735
		[Token(Token = "0x4007BF7")]
		public const string VEC_BREAK_V2_OFFENSE_BATTLE_FINISH = "/activity/vecBreakV2/battleFinish";

		// Token: 0x04007BF8 RID: 31736
		[Token(Token = "0x4007BF8")]
		public const string VEC_BREAK_V2_DEFENSE_BATTLE_START = "/activity/vecBreakV2/defendBattleStart";

		// Token: 0x04007BF9 RID: 31737
		[Token(Token = "0x4007BF9")]
		public const string VEC_BREAK_V2_DEFENSE_BATTLE_FINISH = "/activity/vecBreakV2/defendBattleFinish";

		// Token: 0x04007BFA RID: 31738
		[Token(Token = "0x4007BFA")]
		public const string VEC_BREAK_V2_GET_SEASON_RECORD = "/vecBreakV2/getSeasonRecord";

		// Token: 0x04007BFB RID: 31739
		[Token(Token = "0x4007BFB")]
		public const string VEC_BREAK_V2_CHANGE_BUFF_LIST = "/activity/vecBreakV2/changeBuffList";

		// Token: 0x04007BFC RID: 31740
		[Token(Token = "0x4007BFC")]
		public const string VEC_BREAK_V2_SET_DEFEND = "/activity/vecBreakV2/setDefend";

		// Token: 0x04007BFD RID: 31741
		[Token(Token = "0x4007BFD")]
		public const string ARCADE_BATTLE_START = "/activity/arcade/battleStart";

		// Token: 0x04007BFE RID: 31742
		[Token(Token = "0x4007BFE")]
		public const string ARCADE_BATTLE_FINISH = "/activity/arcade/battleFinish";

		// Token: 0x04007BFF RID: 31743
		[Token(Token = "0x4007BFF")]
		public const string CHAR_ROTATION_SET_CURRENT = "/charRotation/setCurrent";

		// Token: 0x04007C00 RID: 31744
		[Token(Token = "0x4007C00")]
		public const string CHAR_ROTATION_CREATE_PRESET = "/charRotation/createPreset";

		// Token: 0x04007C01 RID: 31745
		[Token(Token = "0x4007C01")]
		public const string CHAR_ROTATION_UPDATE_PRESET = "/charRotation/updatePreset";

		// Token: 0x04007C02 RID: 31746
		[Token(Token = "0x4007C02")]
		public const string CHAR_ROTATION_DELETE_PRESET = "/charRotation/deletePreset";

		// Token: 0x04007C03 RID: 31747
		[Token(Token = "0x4007C03")]
		public const string INVITE_SEND_INVITE = "/invite/sendInvite";

		// Token: 0x04007C04 RID: 31748
		[Token(Token = "0x4007C04")]
		public const string INVITE_REFRESH_INVITE_LIST = "/invite/refreshInviteList";

		// Token: 0x04007C05 RID: 31749
		[Token(Token = "0x4007C05")]
		public const string INVITE_PROCESS_INVITE = "/invite/processInvite";

		// Token: 0x04007C06 RID: 31750
		[Token(Token = "0x4007C06")]
		public const string INVITE_SWITCH_INVITE_INVITE = "/invite/switchInviteAccept";
	}
}
