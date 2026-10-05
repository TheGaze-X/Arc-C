using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Gacha;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x0200380C RID: 14348
	[Token(Token = "0x200380C")]
	public static class UIMisc
	{
		// Token: 0x06016C1F RID: 93215 RVA: 0x00092D48 File Offset: 0x00090F48
		[Token(Token = "0x6016C1F")]
		[Address(RVA = "0xF435E0", Offset = "0xF421E0", VA = "0x180F435E0")]
		public static bool CheckIfUseFastEnterAndMarkWatched(string targetKey)
		{
			return default(bool);
		}

		// Token: 0x06016C20 RID: 93216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C20")]
		[Address(RVA = "0xF44A60", Offset = "0xF43660", VA = "0x180F44A60")]
		private static void _MarkFastEnterWatched(string targetKey)
		{
		}

		// Token: 0x06016C21 RID: 93217 RVA: 0x00092D60 File Offset: 0x00090F60
		[Token(Token = "0x6016C21")]
		[Address(RVA = "0xF44780", Offset = "0xF43380", VA = "0x180F44780")]
		private static bool _CheckIfFastEnterWatched(string targetKey)
		{
			return default(bool);
		}

		// Token: 0x06016C22 RID: 93218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016C22")]
		[Address(RVA = "0xF44830", Offset = "0xF43430", VA = "0x180F44830")]
		private static string _GetLoginFastEnterKey(string targetKey)
		{
			return null;
		}

		// Token: 0x06016C23 RID: 93219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C23")]
		[Address(RVA = "0xF444D0", Offset = "0xF430D0", VA = "0x180F444D0")]
		public static void StartGacha(GameObject overrideDisableTarget, GachaController.PlayMode playMode, GachaController.Input input, Action<GachaController.Output> callback)
		{
		}

		// Token: 0x06016C24 RID: 93220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C24")]
		[Address(RVA = "0xF445B0", Offset = "0xF431B0", VA = "0x180F445B0")]
		public static void StartMultipleGacha(GameObject overrideDisableTarget, GachaController.PlayMode playMode, GachaController.Input[] input, Action<GachaController.Output> callback)
		{
		}

		// Token: 0x06016C25 RID: 93221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C25")]
		[Address(RVA = "0xF43AE0", Offset = "0xF426E0", VA = "0x180F43AE0")]
		public static void DisplayGetSkin(GameObject disableTarget, string charId, string skinId, Action callback)
		{
		}

		// Token: 0x06016C26 RID: 93222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C26")]
		[Address(RVA = "0xF43780", Offset = "0xF42380", VA = "0x180F43780")]
		public static void DisplayGetSkin(GameObject disableTarget, string charId, string skinId, bool showSpDynIllust, Action callback)
		{
		}

		// Token: 0x06016C27 RID: 93223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C27")]
		public static void ShowGainedItems<ItemModelType>(IList<ItemModelType> items, UIGainItemFloatPanel.Style style = UIGainItemFloatPanel.Style.DEFAULT, [Optional] Action onConfirm) where ItemModelType : ISharedItemModel
		{
		}

		// Token: 0x06016C28 RID: 93224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C28")]
		[Address(RVA = "0xF443D0", Offset = "0xF42FD0", VA = "0x180F443D0")]
		public static void ShowGainedItems(List<UIItemViewModel> itemModels, UIGainItemFloatPanel.Style style = UIGainItemFloatPanel.Style.DEFAULT, [Optional] Action onConfirm)
		{
		}

		// Token: 0x06016C29 RID: 93225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C29")]
		public static void ShowGainedItemWithPossibleGachaAhead<ItemModelType>(ItemModelType itemGet, GameObject disableTarget, GachaController.PlayMode gachaPlayMode, bool isSkippable, Action onBeforeItemShow, Action onAfterItemShow, UIGainItemFloatPanel.Style showItemStyle = UIGainItemFloatPanel.Style.DEFAULT) where ItemModelType : ISharedItemModel, IGachaResultHolder
		{
		}

		// Token: 0x06016C2A RID: 93226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016C2A")]
		public static IEnumerator ShowGainedItemsWithPossibleGachasAhead<ItemModelType>(IList<ItemModelType> itemGets, GameObject disableTarget, GachaController.PlayMode gachaPlayMode, bool isSkippable, Action onBeforeItemShow, [Optional] Action onAfterItemShow, UIGainItemFloatPanel.Style showItemStyle = UIGainItemFloatPanel.Style.DEFAULT, bool shouldMergeItems = true) where ItemModelType : ISharedItemModel, IGachaResultHolder
		{
			return null;
		}

		// Token: 0x06016C2B RID: 93227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016C2B")]
		[Address(RVA = "0xF44F70", Offset = "0xF43B70", VA = "0x180F44F70")]
		private static IEnumerator _ShowGainedItemsRelatedChar(GachaResult charGet, GameObject disableTarget, GachaController.PlayMode gachaPlayMode)
		{
			return null;
		}

		// Token: 0x06016C2C RID: 93228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C2C")]
		[Address(RVA = "0xF44B00", Offset = "0xF43700", VA = "0x180F44B00")]
		private static void _ShowGainedItemsRelatedCharActivityPotential(GachaResult charGet)
		{
		}

		// Token: 0x06016C2D RID: 93229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016C2D")]
		[Address(RVA = "0xF44EE0", Offset = "0xF43AE0", VA = "0x180F44EE0")]
		private static IEnumerator _ShowGainedItemsRelatedCharSkin(UIItemViewModel itemModel, GameObject disableTarget)
		{
			return null;
		}

		// Token: 0x06016C2E RID: 93230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C2E")]
		[Address(RVA = "0xF44CF0", Offset = "0xF438F0", VA = "0x180F44CF0")]
		private static void _ShowGainedItemsRelatedCharFavorAddItem(GachaResult charGet)
		{
		}

		// Token: 0x06016C2F RID: 93231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C2F")]
		[Address(RVA = "0xF448C0", Offset = "0xF434C0", VA = "0x180F448C0")]
		private static void _InsertOrMergeCharRelatedItems(List<UIItemViewModel> itemViewModels, bool isNew, UIItemViewModel itemModel, ItemBundle[] charItemGet, bool shouldMergeItems)
		{
		}

		// Token: 0x06016C30 RID: 93232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C30")]
		[Address(RVA = "0xF449A0", Offset = "0xF435A0", VA = "0x180F449A0")]
		private static void _InsertOrMergeItems(List<UIItemViewModel> itemViewModels, UIItemViewModel itemModel, bool shouldMergeItems)
		{
		}

		// Token: 0x06016C31 RID: 93233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C31")]
		public static void ShowGainedItemsWithPossibleGachasAheadAsync<ItemModelType>(IList<ItemModelType> itemGets, GameObject disableTarget, GachaController.PlayMode gachaPlayMode, bool isSkippable, Action onBeforeItemShow) where ItemModelType : ISharedItemModel, IGachaResultHolder
		{
		}

		// Token: 0x06016C32 RID: 93234 RVA: 0x00092D78 File Offset: 0x00090F78
		[Token(Token = "0x6016C32")]
		[Address(RVA = "0xF44220", Offset = "0xF42E20", VA = "0x180F44220")]
		public static bool SetupVerticalTextGeneraion(Text text, out TextGenerationSettings settings)
		{
			return default(bool);
		}

		// Token: 0x06016C33 RID: 93235 RVA: 0x00092D90 File Offset: 0x00090F90
		[Token(Token = "0x6016C33")]
		[Address(RVA = "0xF44080", Offset = "0xF42C80", VA = "0x180F44080")]
		public static bool SetupHorizontalTextGeneraion(Text text, out TextGenerationSettings settings)
		{
			return default(bool);
		}

		// Token: 0x06016C34 RID: 93236 RVA: 0x00092DA8 File Offset: 0x00090FA8
		[Token(Token = "0x6016C34")]
		[Address(RVA = "0xF43E60", Offset = "0xF42A60", VA = "0x180F43E60")]
		public static bool IsUICoreCompStable(IStateEngine stateEngine, [Optional] Type expectedState, [Optional] string expectedPageName)
		{
			return default(bool);
		}

		// Token: 0x06016C35 RID: 93237 RVA: 0x00092DC0 File Offset: 0x00090FC0
		[Token(Token = "0x6016C35")]
		[Address(RVA = "0xF44690", Offset = "0xF43290", VA = "0x180F44690")]
		public static bool TryExtractInviteCode(string inputStr, out string code)
		{
			return default(bool);
		}

		// Token: 0x06016C36 RID: 93238 RVA: 0x00092DD8 File Offset: 0x00090FD8
		[Token(Token = "0x6016C36")]
		[Address(RVA = "0xF43530", Offset = "0xF42130", VA = "0x180F43530")]
		public static bool CheckIfInviteCodeValid(string code)
		{
			return default(bool);
		}

		// Token: 0x06016C37 RID: 93239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C37")]
		[Address(RVA = "0xF43B70", Offset = "0xF42770", VA = "0x180F43B70")]
		public static void FocusScrollRectOnIdx(LoopScrollRect scrollRect, LoopScrollAdapter adapter, int targetIndex, UIMisc.FocusScrollTweenParam tweenParam, ref Tween tween)
		{
		}

		// Token: 0x0401B705 RID: 112389
		[Token(Token = "0x401B705")]
		private const char INVITE_CODE_FORMAT_PREFIX = '[';

		// Token: 0x0401B706 RID: 112390
		[Token(Token = "0x401B706")]
		private const char INVITE_CODE_FORMAT_SUFFIX = ']';

		// Token: 0x0401B707 RID: 112391
		[Token(Token = "0x401B707")]
		private const int INVITE_CODE_DIGITS_LENGTH = 14;

		// Token: 0x0401B708 RID: 112392
		[Token(Token = "0x401B708")]
		private const char INVITE_CODE_NUMBER_FROM = '0';

		// Token: 0x0401B709 RID: 112393
		[Token(Token = "0x401B709")]
		private const char INVITE_CODE_NUMBER_TO = '9';

		// Token: 0x0401B70A RID: 112394
		[Token(Token = "0x401B70A")]
		private const char INVITE_CODE_ALPHA_FROM = 'a';

		// Token: 0x0401B70B RID: 112395
		[Token(Token = "0x401B70B")]
		private const char INVITE_CODE_ALPHA_TO = 'n';

		// Token: 0x0401B70C RID: 112396
		[Token(Token = "0x401B70C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HashSet<string> s_watchedFastEnterSet;

		// Token: 0x0200380D RID: 14349
		[Token(Token = "0x200380D")]
		public struct FocusScrollTweenParam
		{
			// Token: 0x0401B70D RID: 112397
			[Token(Token = "0x401B70D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int slideMaxLength;

			// Token: 0x0401B70E RID: 112398
			[Token(Token = "0x401B70E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float duration;

			// Token: 0x0401B70F RID: 112399
			[Token(Token = "0x401B70F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float delay;

			// Token: 0x0401B710 RID: 112400
			[Token(Token = "0x401B710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Ease ease;
		}
	}
}
