using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071B2 RID: 29106
	[Token(Token = "0x20071B2")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act6FunUtils
	{
		// Token: 0x060294D2 RID: 169170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60294D2")]
		[Address(RVA = "0x24AEAD0", Offset = "0x24AD6D0", VA = "0x1824AEAD0")]
		public static ActivityCustomZoneMapViewModel GetAct6FunZoneMapModel(string actId, string zoneId, string selectingStageId)
		{
			return null;
		}

		// Token: 0x060294D3 RID: 169171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294D3")]
		[Address(RVA = "0x24AF100", Offset = "0x24ADD00", VA = "0x1824AF100")]
		public static void OpenAct6FunZoneMapPage(string actId, string zoneId, ActivityCustomZoneMapPage.InitState initState, [Optional] string defaultSelectStageId)
		{
		}

		// Token: 0x060294D4 RID: 169172 RVA: 0x000D53F0 File Offset: 0x000D35F0
		[Token(Token = "0x60294D4")]
		[Address(RVA = "0x24AE710", Offset = "0x24AD310", VA = "0x1824AE710")]
		public static bool CheckHaveRewardToClaim()
		{
			return default(bool);
		}

		// Token: 0x060294D5 RID: 169173 RVA: 0x000D5408 File Offset: 0x000D3608
		[Token(Token = "0x60294D5")]
		[Address(RVA = "0x24AF000", Offset = "0x24ADC00", VA = "0x1824AF000")]
		public static int GetStageAchievementCount(string stageId)
		{
			return 0;
		}

		// Token: 0x060294D6 RID: 169174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60294D6")]
		[Address(RVA = "0x24AEE90", Offset = "0x24ADA90", VA = "0x1824AEE90")]
		public static Sprite GetCharSmallPreviewPicSprite(string picId, ILoadAsset iLoadAsset)
		{
			return null;
		}

		// Token: 0x060294D7 RID: 169175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60294D7")]
		[Address(RVA = "0x24AF5D0", Offset = "0x24AE1D0", VA = "0x1824AF5D0")]
		private static Sprite _GetSpriteByAutoPackSpriteHub(string spriteId, AutoPackSpriteHub hub, ILoadAsset iLoadAsset)
		{
			return null;
		}

		// Token: 0x060294D8 RID: 169176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60294D8")]
		[Address(RVA = "0x24AF270", Offset = "0x24ADE70", VA = "0x1824AF270")]
		private static Dictionary<string, StageData> _CollectStageDatas(Dictionary<string, Act6FunStageAdditionData> stageAdditionDatas, Dictionary<string, AprilFoolStageData> stages)
		{
			return null;
		}

		// Token: 0x060294D9 RID: 169177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60294D9")]
		[Address(RVA = "0x24AF7E0", Offset = "0x24AE3E0", VA = "0x1824AF7E0")]
		private static ListDict<string, StageViewModel> _LoadStageViewModelDict(IEnumerator<KeyValuePair<string, StageData>> stageDataIter)
		{
			return null;
		}

		// Token: 0x060294DA RID: 169178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60294DA")]
		[Address(RVA = "0x24AFA70", Offset = "0x24AE670", VA = "0x1824AFA70")]
		private static StageViewModel _LoadStageViewModel(StageData stageData)
		{
			return null;
		}

		// Token: 0x060294DB RID: 169179 RVA: 0x000D5420 File Offset: 0x000D3620
		[Token(Token = "0x60294DB")]
		[Address(RVA = "0x24AFD20", Offset = "0x24AE920", VA = "0x1824AFD20")]
		private static bool _TryGetAct6FunAvailStage(string stageId, out PlayerActFun6Stage playerStageInfo)
		{
			return default(bool);
		}

		// Token: 0x0403AFA2 RID: 241570
		[Token(Token = "0x403AFA2")]
		private const string ACT6FUN_ZONE_MAP_HOLDER_PATH = "UI/Activity/ActFun/Actfun6/zoneMap/act6fun_zone_map_holder";

		// Token: 0x0403AFA3 RID: 241571
		[Token(Token = "0x403AFA3")]
		private const string ACT6FUN_ZONE_MAP_PATH = "UI/Activity/ActFun/Actfun6/zoneMap/act6fun_zone_map";

		// Token: 0x0403AFA4 RID: 241572
		[Token(Token = "0x403AFA4")]
		private const string ACT6FUN_STAGE_PREVIEW_HOLDER_PATH = "UI/Activity/ActFun/Actfun6/zoneMap/act6fun_stage_preview_holder";

		// Token: 0x0403AFA5 RID: 241573
		[Token(Token = "0x403AFA5")]
		private const string ACT6FUN_STAGE_PREVIEW_PATH = "UI/Activity/ActFun/Actfun6/zoneMap/act6fun_stage_preview";

		// Token: 0x0403AFA6 RID: 241574
		[Token(Token = "0x403AFA6")]
		public const string ACT6FUN_CUSTOM_PAGE_TOP_MENU_PATH = "UI/Activity/ActFun/Actfun6/act6fun_topmenu";

		// Token: 0x0403AFA7 RID: 241575
		[Token(Token = "0x403AFA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAct6FunZoneMapModel;

		// Token: 0x0403AFA8 RID: 241576
		[Token(Token = "0x403AFA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenAct6FunZoneMapPage;

		// Token: 0x0403AFA9 RID: 241577
		[Token(Token = "0x403AFA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckHaveRewardToClaim;

		// Token: 0x0403AFAA RID: 241578
		[Token(Token = "0x403AFAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetStageAchievementCount;

		// Token: 0x0403AFAB RID: 241579
		[Token(Token = "0x403AFAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCharSmallPreviewPicSprite;

		// Token: 0x0403AFAC RID: 241580
		[Token(Token = "0x403AFAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetSpriteByAutoPackSpriteHub;

		// Token: 0x0403AFAD RID: 241581
		[Token(Token = "0x403AFAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CollectStageDatas;

		// Token: 0x0403AFAE RID: 241582
		[Token(Token = "0x403AFAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadStageViewModelDict;

		// Token: 0x0403AFAF RID: 241583
		[Token(Token = "0x403AFAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadStageViewModel;

		// Token: 0x0403AFB0 RID: 241584
		[Token(Token = "0x403AFB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryGetAct6FunAvailStage;
	}
}
