using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B9E RID: 19358
	[Token(Token = "0x2004B9E")]
	public class CommonLimitObtainModel : IHotfixable
	{
		// Token: 0x17004489 RID: 17545
		// (get) Token: 0x0601D1EB RID: 119275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004489")]
		public List<LimitObtainUnlockProgressModel> unlockProgress
		{
			[Token(Token = "0x601D1EB")]
			[Address(RVA = "0x169A1F0", Offset = "0x1698DF0", VA = "0x18169A1F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700448A RID: 17546
		// (get) Token: 0x0601D1EC RID: 119276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700448A")]
		public List<ICommonLimitInfoModel> limitInfoModels
		{
			[Token(Token = "0x601D1EC")]
			[Address(RVA = "0x169A190", Offset = "0x1698D90", VA = "0x18169A190")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D1ED RID: 119277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D1ED")]
		[Address(RVA = "0x1699EE0", Offset = "0x1698AE0", VA = "0x181699EE0")]
		public ICommonLimitInfoModel GetCurLimitInfoModel(long curTs)
		{
			return null;
		}

		// Token: 0x0601D1EE RID: 119278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1EE")]
		[Address(RVA = "0x169A090", Offset = "0x1698C90", VA = "0x18169A090")]
		public CommonLimitObtainModel()
		{
		}

		// Token: 0x0402635E RID: 156510
		[Token(Token = "0x402635E")]
		[FieldOffset(Offset = "0x10")]
		private List<LimitObtainUnlockProgressModel> m_unlockProgress;

		// Token: 0x0402635F RID: 156511
		[Token(Token = "0x402635F")]
		[FieldOffset(Offset = "0x18")]
		private List<ICommonLimitInfoModel> tempLimitInfoModels;

		// Token: 0x04026360 RID: 156512
		[Token(Token = "0x4026360")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_unlockProgress;

		// Token: 0x04026361 RID: 156513
		[Token(Token = "0x4026361")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_limitInfoModels;

		// Token: 0x04026362 RID: 156514
		[Token(Token = "0x4026362")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCurLimitInfoModel;

		// Token: 0x04026363 RID: 156515
		[Token(Token = "0x4026363")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004B9F RID: 19359
		[Token(Token = "0x2004B9F")]
		[Hotfix(HotfixFlag.Stateless)]
		public static class PlayerAvatarLimitObtainPatchBuilder
		{
			// Token: 0x0601D1EF RID: 119279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D1EF")]
			[Address(RVA = "0x16ADD20", Offset = "0x16AC920", VA = "0x1816ADD20")]
			public static void ParseFromAvatarData(PlayerAvatarPerData avatarData, CommonLimitObtainModel buildTarget)
			{
			}

			// Token: 0x0601D1F0 RID: 119280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D1F0")]
			[Address(RVA = "0x16ADE20", Offset = "0x16ACA20", VA = "0x1816ADE20")]
			private static void _LoadLimitData(PlayerAvatarPerData avatarData, CommonLimitObtainModel buildTarget)
			{
			}

			// Token: 0x04026364 RID: 156516
			[Token(Token = "0x4026364")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ParseFromAvatarData;

			// Token: 0x04026365 RID: 156517
			[Token(Token = "0x4026365")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__LoadLimitData;
		}

		// Token: 0x02004BA0 RID: 19360
		[Token(Token = "0x2004BA0")]
		[Hotfix(HotfixFlag.Stateless)]
		private static class PlayerHomeLimitObtainUnlockProgressPatchBuilder
		{
			// Token: 0x0601D1F1 RID: 119281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D1F1")]
			[Address(RVA = "0x16AE1D0", Offset = "0x16ACDD0", VA = "0x1816AE1D0")]
			public static void ParseFromLimitData(string itemId, Dictionary<string, PlayerHomeUnlockStatus> unlockStatusDict, List<string> unlockDesList, CommonLimitObtainModel buildTarget)
			{
			}

			// Token: 0x04026366 RID: 156518
			[Token(Token = "0x4026366")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ParseFromLimitData;
		}

		// Token: 0x02004BA1 RID: 19361
		[Token(Token = "0x2004BA1")]
		[Hotfix(HotfixFlag.Stateless)]
		public static class HomeThemeLimitObtainPatchBuilder
		{
			// Token: 0x0601D1F2 RID: 119282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D1F2")]
			[Address(RVA = "0x16A9FC0", Offset = "0x16A8BC0", VA = "0x1816A9FC0")]
			public static void ParseFromHomeThemeData(HomeThemeDisplayData homeThemeData, CommonLimitObtainModel buildTarget)
			{
			}

			// Token: 0x0601D1F3 RID: 119283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D1F3")]
			[Address(RVA = "0x16AA1A0", Offset = "0x16A8DA0", VA = "0x1816AA1A0")]
			private static void _LoadLimitData(List<HomeThemeLimitInfoData> limitInfos, CommonLimitObtainModel buildTarget)
			{
			}

			// Token: 0x04026367 RID: 156519
			[Token(Token = "0x4026367")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ParseFromHomeThemeData;

			// Token: 0x04026368 RID: 156520
			[Token(Token = "0x4026368")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__LoadLimitData;
		}

		// Token: 0x02004BA2 RID: 19362
		[Token(Token = "0x2004BA2")]
		[Hotfix(HotfixFlag.Stateless)]
		public static class HomeBackgroundLimitObtainPatchBuilder
		{
			// Token: 0x0601D1F4 RID: 119284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D1F4")]
			[Address(RVA = "0x169AE90", Offset = "0x1699A90", VA = "0x18169AE90")]
			public static void ParseFromHomeBackgroundData(HomeBackgroundSingleData homeBackgroundSingleData, CommonLimitObtainModel buildTarget)
			{
			}

			// Token: 0x0601D1F5 RID: 119285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D1F5")]
			[Address(RVA = "0x169B070", Offset = "0x1699C70", VA = "0x18169B070")]
			private static void _LoadLimitData(List<HomeBackgroundLimitInfoData> limitInfos, CommonLimitObtainModel buildTarget)
			{
			}

			// Token: 0x04026369 RID: 156521
			[Token(Token = "0x4026369")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ParseFromHomeBackgroundData;

			// Token: 0x0402636A RID: 156522
			[Token(Token = "0x402636A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__LoadLimitData;
		}

		// Token: 0x02004BA3 RID: 19363
		[Token(Token = "0x2004BA3")]
		[Hotfix(HotfixFlag.Stateless)]
		public static class NameCardSkinLimitObtainPatchBuilder
		{
			// Token: 0x0601D1F6 RID: 119286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D1F6")]
			[Address(RVA = "0x16AC490", Offset = "0x16AB090", VA = "0x1816AC490")]
			public static void ParseFromNameCardSkinData(NameCardV2SkinData nameCardSkinData, CommonLimitObtainModel buildTarget)
			{
			}

			// Token: 0x0601D1F7 RID: 119287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D1F7")]
			[Address(RVA = "0x16ACA30", Offset = "0x16AB630", VA = "0x1816ACA30")]
			private static void _LoadProgressData(string skinId, List<string> unlockDescList, CommonLimitObtainModel buildTarget)
			{
			}

			// Token: 0x0601D1F8 RID: 119288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D1F8")]
			[Address(RVA = "0x16AC5B0", Offset = "0x16AB1B0", VA = "0x1816AC5B0")]
			private static void _LoadLimitData(NameCardV2SkinData nameCardSkinData, CommonLimitObtainModel buildTarget)
			{
			}

			// Token: 0x0402636B RID: 156523
			[Token(Token = "0x402636B")]
			private const int CURRENT_PROGRESS_IDX = 0;

			// Token: 0x0402636C RID: 156524
			[Token(Token = "0x402636C")]
			private const int MAX_PROGRESS_IDX = 1;

			// Token: 0x0402636D RID: 156525
			[Token(Token = "0x402636D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ParseFromNameCardSkinData;

			// Token: 0x0402636E RID: 156526
			[Token(Token = "0x402636E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__LoadProgressData;

			// Token: 0x0402636F RID: 156527
			[Token(Token = "0x402636F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__LoadLimitData;
		}
	}
}
