using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D3A RID: 27962
	[Token(Token = "0x2006D3A")]
	public class Act29signSpecialCheckinItemViewModel : IHotfixable
	{
		// Token: 0x06027DC5 RID: 163269 RVA: 0x000CFAE0 File Offset: 0x000CDCE0
		[Token(Token = "0x6027DC5")]
		[Address(RVA = "0x22ED1C0", Offset = "0x22EBDC0", VA = "0x1822ED1C0")]
		public static bool IsAlreadyGotItem(Act29signSpecialCheckinItemViewModel.ItemStatus itemStatus)
		{
			return default(bool);
		}

		// Token: 0x06027DC6 RID: 163270 RVA: 0x000CFAF8 File Offset: 0x000CDCF8
		[Token(Token = "0x6027DC6")]
		[Address(RVA = "0x22ED220", Offset = "0x22EBE20", VA = "0x1822ED220")]
		public static bool IsLockedItem(Act29signSpecialCheckinItemViewModel.ItemStatus itemStatus)
		{
			return default(bool);
		}

		// Token: 0x06027DC7 RID: 163271 RVA: 0x000CFB10 File Offset: 0x000CDD10
		[Token(Token = "0x6027DC7")]
		[Address(RVA = "0x22ED280", Offset = "0x22EBE80", VA = "0x1822ED280")]
		public static bool IsUnlockedItem(Act29signSpecialCheckinItemViewModel.ItemStatus itemStatus)
		{
			return default(bool);
		}

		// Token: 0x06027DC8 RID: 163272 RVA: 0x000CFB28 File Offset: 0x000CDD28
		[Token(Token = "0x6027DC8")]
		[Address(RVA = "0x22ECFC0", Offset = "0x22EBBC0", VA = "0x1822ECFC0")]
		public static bool CanReceiveItem(Act29signSpecialCheckinItemViewModel.ItemStatus itemStatus)
		{
			return default(bool);
		}

		// Token: 0x06027DC9 RID: 163273 RVA: 0x000CFB40 File Offset: 0x000CDD40
		[Token(Token = "0x6027DC9")]
		[Address(RVA = "0x22ECF60", Offset = "0x22EBB60", VA = "0x1822ECF60")]
		public static bool CanReceiveAndLastTarget(Act29signSpecialCheckinItemViewModel.ItemStatus itemStatus)
		{
			return default(bool);
		}

		// Token: 0x06027DCA RID: 163274 RVA: 0x000CFB58 File Offset: 0x000CDD58
		[Token(Token = "0x6027DCA")]
		[Address(RVA = "0x22ED030", Offset = "0x22EBC30", VA = "0x1822ED030")]
		protected static Act29signSpecialCheckinItemViewModel.ItemStatus GetItemStatus(int order, List<int> history)
		{
			return Act29signSpecialCheckinItemViewModel.ItemStatus.ALREADY_GET;
		}

		// Token: 0x06027DCB RID: 163275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DCB")]
		[Address(RVA = "0x22EDA20", Offset = "0x22EC620", VA = "0x1822EDA20")]
		public void LoadDataForNormalCheckin(ActivityCommonCheckinV2Item.ItemConfigGroup configGroup, int order, DefaultCheckInData.CheckInDailyInfo dailyInfo, List<int> history)
		{
		}

		// Token: 0x06027DCC RID: 163276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DCC")]
		[Address(RVA = "0x22ED320", Offset = "0x22EBF20", VA = "0x1822ED320")]
		public void LoadDataForAct29signSpecialItem(int order, List<int> history, List<string> dynOpt, Color numIconColor, Color progressTextColor, DefaultCheckInData.CheckInDailyInfo dailyInfo, Dictionary<string, List<ItemBundle>> dynOptionRewardItemDict, Dictionary<string, DefaultCheckInData.DynCheckInDailyInfo> dynCheckInDict, Func<string, Sprite> loadSpriteForCurrentAct)
		{
		}

		// Token: 0x06027DCD RID: 163277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DCD")]
		[Address(RVA = "0x22EDC90", Offset = "0x22EC890", VA = "0x1822EDC90")]
		public Act29signSpecialCheckinItemViewModel()
		{
		}

		// Token: 0x040387FF RID: 231423
		[Token(Token = "0x40387FF")]
		[FieldOffset(Offset = "0x10")]
		public Act29signSpecialCheckinItemViewModel.ItemType itemType;

		// Token: 0x04038800 RID: 231424
		[Token(Token = "0x4038800")]
		[FieldOffset(Offset = "0x14")]
		public int order;

		// Token: 0x04038801 RID: 231425
		[Token(Token = "0x4038801")]
		[FieldOffset(Offset = "0x18")]
		public Act29signSpecialCheckinItemViewModel.ItemStatus itemStatus;

		// Token: 0x04038802 RID: 231426
		[Token(Token = "0x4038802")]
		[FieldOffset(Offset = "0x20")]
		public ActivityCommonCheckinV2Item.ItemConfigGroup configGroup;

		// Token: 0x04038803 RID: 231427
		[Token(Token = "0x4038803")]
		[FieldOffset(Offset = "0xA8")]
		public DefaultCheckInData.CheckInDailyInfo dailyInfo;

		// Token: 0x04038804 RID: 231428
		[Token(Token = "0x4038804")]
		[FieldOffset(Offset = "0xB0")]
		public bool hasInfoFlag;

		// Token: 0x04038805 RID: 231429
		[Token(Token = "0x4038805")]
		[FieldOffset(Offset = "0xB1")]
		public bool canReceiveFlag;

		// Token: 0x04038806 RID: 231430
		[Token(Token = "0x4038806")]
		[FieldOffset(Offset = "0xB2")]
		public bool lastTargetFlag;

		// Token: 0x04038807 RID: 231431
		[Token(Token = "0x4038807")]
		[FieldOffset(Offset = "0xB8")]
		public Act29signSpecialCheckinItemViewModel.Act29signConfigGroup act29SignConfigGroup;

		// Token: 0x04038808 RID: 231432
		[Token(Token = "0x4038808")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsAlreadyGotItem;

		// Token: 0x04038809 RID: 231433
		[Token(Token = "0x4038809")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsLockedItem;

		// Token: 0x0403880A RID: 231434
		[Token(Token = "0x403880A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsUnlockedItem;

		// Token: 0x0403880B RID: 231435
		[Token(Token = "0x403880B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CanReceiveItem;

		// Token: 0x0403880C RID: 231436
		[Token(Token = "0x403880C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CanReceiveAndLastTarget;

		// Token: 0x0403880D RID: 231437
		[Token(Token = "0x403880D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetItemStatus;

		// Token: 0x0403880E RID: 231438
		[Token(Token = "0x403880E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadDataForNormalCheckin;

		// Token: 0x0403880F RID: 231439
		[Token(Token = "0x403880F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadDataForAct29signSpecialItem;

		// Token: 0x04038810 RID: 231440
		[Token(Token = "0x4038810")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006D3B RID: 27963
		[Token(Token = "0x2006D3B")]
		public enum ItemType
		{
			// Token: 0x04038812 RID: 231442
			[Token(Token = "0x4038812")]
			NORMAL,
			// Token: 0x04038813 RID: 231443
			[Token(Token = "0x4038813")]
			ACT29SIGN_SPECIAL,
			// Token: 0x04038814 RID: 231444
			[Token(Token = "0x4038814")]
			E_NUM
		}

		// Token: 0x02006D3C RID: 27964
		[Token(Token = "0x2006D3C")]
		public enum ItemStatus
		{
			// Token: 0x04038816 RID: 231446
			[Token(Token = "0x4038816")]
			ALREADY_GET,
			// Token: 0x04038817 RID: 231447
			[Token(Token = "0x4038817")]
			CAN_RECEIVE,
			// Token: 0x04038818 RID: 231448
			[Token(Token = "0x4038818")]
			CAN_RECEIVE_LAST_TARGET,
			// Token: 0x04038819 RID: 231449
			[Token(Token = "0x4038819")]
			LOCKED,
			// Token: 0x0403881A RID: 231450
			[Token(Token = "0x403881A")]
			E_NUM
		}

		// Token: 0x02006D3D RID: 27965
		[Token(Token = "0x2006D3D")]
		public struct Act29signConfigGroup
		{
			// Token: 0x0403881B RID: 231451
			[Token(Token = "0x403881B")]
			[FieldOffset(Offset = "0x0")]
			public string progressText;

			// Token: 0x0403881C RID: 231452
			[Token(Token = "0x403881C")]
			[FieldOffset(Offset = "0x8")]
			public string specialAlreadyGetText;

			// Token: 0x0403881D RID: 231453
			[Token(Token = "0x403881D")]
			[FieldOffset(Offset = "0x10")]
			public string numIconSpriteId;

			// Token: 0x0403881E RID: 231454
			[Token(Token = "0x403881E")]
			[FieldOffset(Offset = "0x18")]
			public Color numIconColor;

			// Token: 0x0403881F RID: 231455
			[Token(Token = "0x403881F")]
			[FieldOffset(Offset = "0x28")]
			public Color progressTextColor;

			// Token: 0x04038820 RID: 231456
			[Token(Token = "0x4038820")]
			[FieldOffset(Offset = "0x38")]
			public Func<string, Sprite> loadNumIconSprite;

			// Token: 0x04038821 RID: 231457
			[Token(Token = "0x4038821")]
			[FieldOffset(Offset = "0x40")]
			public bool hasCardSubItems;

			// Token: 0x04038822 RID: 231458
			[Token(Token = "0x4038822")]
			[FieldOffset(Offset = "0x48")]
			public List<ItemBundle> itemList;
		}
	}
}
