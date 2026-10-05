using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A84 RID: 23172
	[Token(Token = "0x2005A84")]
	public class DetailProgressGPViewModel : DetailCommonViewModel, IHotfixable
	{
		// Token: 0x06021B58 RID: 138072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B58")]
		[Address(RVA = "0x1C188B0", Offset = "0x1C174B0", VA = "0x181C188B0")]
		public void LoadData(ShopGPCondTrigItemViewModel itemModel)
		{
		}

		// Token: 0x06021B59 RID: 138073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B59")]
		[Address(RVA = "0x1C19110", Offset = "0x1C17D10", VA = "0x181C19110")]
		private void _LoadReturnProgressReward()
		{
		}

		// Token: 0x06021B5A RID: 138074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B5A")]
		[Address(RVA = "0x1C18BE0", Offset = "0x1C177E0", VA = "0x181C18BE0")]
		private void _LoadNewProgressReward()
		{
		}

		// Token: 0x06021B5B RID: 138075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B5B")]
		[Address(RVA = "0x1C18A90", Offset = "0x1C17690", VA = "0x181C18A90")]
		private void _LoadCommonData(ShopGPCondTrigItemViewModel itemModel)
		{
		}

		// Token: 0x06021B5C RID: 138076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B5C")]
		[Address(RVA = "0x1C19620", Offset = "0x1C18220", VA = "0x181C19620")]
		public DetailProgressGPViewModel()
		{
		}

		// Token: 0x0402E182 RID: 188802
		[Token(Token = "0x402E182")]
		[FieldOffset(Offset = "0x70")]
		public int currentCheckInDay;

		// Token: 0x0402E183 RID: 188803
		[Token(Token = "0x402E183")]
		[FieldOffset(Offset = "0x74")]
		public int totalCheckInDay;

		// Token: 0x0402E184 RID: 188804
		[Token(Token = "0x402E184")]
		[FieldOffset(Offset = "0x78")]
		public List<DetailProgressGPViewModel.CheckInRewardModel> rewardList;

		// Token: 0x0402E185 RID: 188805
		[Token(Token = "0x402E185")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402E186 RID: 188806
		[Token(Token = "0x402E186")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadReturnProgressReward;

		// Token: 0x0402E187 RID: 188807
		[Token(Token = "0x402E187")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadNewProgressReward;

		// Token: 0x0402E188 RID: 188808
		[Token(Token = "0x402E188")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadCommonData;

		// Token: 0x0402E189 RID: 188809
		[Token(Token = "0x402E189")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A85 RID: 23173
		[Token(Token = "0x2005A85")]
		public class CheckInRewardModel
		{
			// Token: 0x06021B5D RID: 138077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021B5D")]
			[Address(RVA = "0x1C17AA0", Offset = "0x1C166A0", VA = "0x181C17AA0")]
			public CheckInRewardModel()
			{
			}

			// Token: 0x0402E18A RID: 188810
			[Token(Token = "0x402E18A")]
			[FieldOffset(Offset = "0x10")]
			public int checkInDay;

			// Token: 0x0402E18B RID: 188811
			[Token(Token = "0x402E18B")]
			[FieldOffset(Offset = "0x18")]
			public List<ItemBundle> itemBundles;
		}
	}
}
