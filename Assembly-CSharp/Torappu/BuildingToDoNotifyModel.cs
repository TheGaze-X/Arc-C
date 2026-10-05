using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020004B8 RID: 1208
	[Token(Token = "0x20004B8")]
	public class BuildingToDoNotifyModel : IHotfixable
	{
		// Token: 0x06004D3F RID: 19775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D3F")]
		[Address(RVA = "0x1789C10", Offset = "0x1788810", VA = "0x181789C10")]
		public List<BuildingToDoNotifyItemModel> GetNotifications(BuildingToDoCategory category)
		{
			return null;
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x0002D798 File Offset: 0x0002B998
		[Token(Token = "0x6004D40")]
		[Address(RVA = "0x1789B80", Offset = "0x1788780", VA = "0x181789B80")]
		public int CountOfNotifications(BuildingToDoCategory category)
		{
			return 0;
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D41")]
		[Address(RVA = "0x17899A0", Offset = "0x17885A0", VA = "0x1817899A0")]
		public void AdjustSelections(ref BuildingToDoCategory selectedCategory, ref BuildingData.BuildingToDoType selectedType)
		{
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D42")]
		[Address(RVA = "0x1789CA0", Offset = "0x17888A0", VA = "0x181789CA0")]
		public void LoadData()
		{
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D43")]
		[Address(RVA = "0x178B820", Offset = "0x178A420", VA = "0x18178B820")]
		private void _LoadEmergency()
		{
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D44")]
		[Address(RVA = "0x178C280", Offset = "0x178AE80", VA = "0x18178C280")]
		private void _LoadNormal()
		{
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D45")]
		[Address(RVA = "0x178B200", Offset = "0x1789E00", VA = "0x18178B200")]
		private void _AddNewProductNormalNotification(ref List<BuildingToDoNotifyItemModel> normalList)
		{
		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D46")]
		[Address(RVA = "0x178AF20", Offset = "0x1789B20", VA = "0x18178AF20")]
		private void _AddNewOrderNormalNotification(ref List<BuildingToDoNotifyItemModel> normalList)
		{
		}

		// Token: 0x06004D47 RID: 19783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D47")]
		[Address(RVA = "0x178A390", Offset = "0x1788F90", VA = "0x18178A390")]
		private void _AddCharTiredNormalNotification(ref List<BuildingToDoNotifyItemModel> normalList)
		{
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D48")]
		[Address(RVA = "0x178AC30", Offset = "0x1789830", VA = "0x18178AC30")]
		private void _AddNewFavorMaxNotification(ref List<BuildingToDoNotifyItemModel> normalList)
		{
		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D49")]
		[Address(RVA = "0x178A680", Offset = "0x1789280", VA = "0x18178A680")]
		private void _AddHireRefreshCountNormalNotification(ref List<BuildingToDoNotifyItemModel> normalList)
		{
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D4A")]
		[Address(RVA = "0x1789D50", Offset = "0x1788950", VA = "0x181789D50")]
		private void _AddBatchBtnNormalNotification(ref List<BuildingToDoNotifyItemModel> normalList)
		{
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D4B")]
		[Address(RVA = "0x178A970", Offset = "0x1789570", VA = "0x18178A970")]
		private void _AddMessageBoardNotification(ref List<BuildingToDoNotifyItemModel> normalList, string meetingSlotId)
		{
		}

		// Token: 0x06004D4C RID: 19788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D4C")]
		[Address(RVA = "0x178B710", Offset = "0x178A310", VA = "0x18178B710")]
		private static BuildingToDoNotifyItemModel _CreateNotifyIfExists(Func<BuildingToDoNotifyItemModel> funcCreate, Func<BuildingToDoNotifyModel.NotifyContext> funcAddSlot, bool slotCanBeEmpty = false)
		{
			return null;
		}

		// Token: 0x06004D4D RID: 19789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D4D")]
		private static void _AddToListSecured<Type>(Type val, ref List<Type> refList)
		{
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D4E")]
		[Address(RVA = "0x178B5D0", Offset = "0x178A1D0", VA = "0x18178B5D0")]
		private static BuildingToDoNotifyItemModel _CreateNewFavorModel()
		{
			return null;
		}

		// Token: 0x06004D4F RID: 19791 RVA: 0x0002D7B0 File Offset: 0x0002B9B0
		[Token(Token = "0x6004D4F")]
		[Address(RVA = "0x178CC20", Offset = "0x178B820", VA = "0x18178CC20")]
		private static BuildingToDoNotifyModel.NotifyContext _NewFavorAddSlots()
		{
			return default(BuildingToDoNotifyModel.NotifyContext);
		}

		// Token: 0x06004D50 RID: 19792 RVA: 0x0002D7C8 File Offset: 0x0002B9C8
		[Token(Token = "0x6004D50")]
		[Address(RVA = "0x178B4E0", Offset = "0x178A0E0", VA = "0x18178B4E0")]
		private static bool _CheckIfRoomSlotBuilt(string slotId)
		{
			return default(bool);
		}

		// Token: 0x06004D51 RID: 19793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D51")]
		[Address(RVA = "0x178D590", Offset = "0x178C190", VA = "0x18178D590")]
		public BuildingToDoNotifyModel()
		{
		}

		// Token: 0x04001158 RID: 4440
		[Token(Token = "0x4001158")]
		[FieldOffset(Offset = "0x10")]
		private ListDict<BuildingToDoCategory, List<BuildingToDoNotifyItemModel>> m_notifications;

		// Token: 0x04001159 RID: 4441
		[Token(Token = "0x4001159")]
		[FieldOffset(Offset = "0x18")]
		private int m_emerCount;

		// Token: 0x0400115A RID: 4442
		[Token(Token = "0x400115A")]
		[FieldOffset(Offset = "0x1C")]
		private int m_normalCount;

		// Token: 0x0400115B RID: 4443
		[Token(Token = "0x400115B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetNotifications;

		// Token: 0x0400115C RID: 4444
		[Token(Token = "0x400115C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CountOfNotifications;

		// Token: 0x0400115D RID: 4445
		[Token(Token = "0x400115D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AdjustSelections;

		// Token: 0x0400115E RID: 4446
		[Token(Token = "0x400115E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400115F RID: 4447
		[Token(Token = "0x400115F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadEmergency;

		// Token: 0x04001160 RID: 4448
		[Token(Token = "0x4001160")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadNormal;

		// Token: 0x04001161 RID: 4449
		[Token(Token = "0x4001161")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__AddNewProductNormalNotification;

		// Token: 0x04001162 RID: 4450
		[Token(Token = "0x4001162")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AddNewOrderNormalNotification;

		// Token: 0x04001163 RID: 4451
		[Token(Token = "0x4001163")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__AddCharTiredNormalNotification;

		// Token: 0x04001164 RID: 4452
		[Token(Token = "0x4001164")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__AddNewFavorMaxNotification;

		// Token: 0x04001165 RID: 4453
		[Token(Token = "0x4001165")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__AddHireRefreshCountNormalNotification;

		// Token: 0x04001166 RID: 4454
		[Token(Token = "0x4001166")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__AddBatchBtnNormalNotification;

		// Token: 0x04001167 RID: 4455
		[Token(Token = "0x4001167")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__AddMessageBoardNotification;

		// Token: 0x04001168 RID: 4456
		[Token(Token = "0x4001168")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CreateNotifyIfExists;

		// Token: 0x04001169 RID: 4457
		[Token(Token = "0x4001169")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__AddToListSecured;

		// Token: 0x0400116A RID: 4458
		[Token(Token = "0x400116A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CreateNewFavorModel;

		// Token: 0x0400116B RID: 4459
		[Token(Token = "0x400116B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__NewFavorAddSlots;

		// Token: 0x0400116C RID: 4460
		[Token(Token = "0x400116C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckIfRoomSlotBuilt;

		// Token: 0x0400116D RID: 4461
		[Token(Token = "0x400116D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020004B9 RID: 1209
		[Token(Token = "0x20004B9")]
		private struct NotifyContext
		{
			// Token: 0x0400116E RID: 4462
			[Token(Token = "0x400116E")]
			[FieldOffset(Offset = "0x0")]
			public List<string> slots;

			// Token: 0x0400116F RID: 4463
			[Token(Token = "0x400116F")]
			[FieldOffset(Offset = "0x8")]
			public int count;
		}
	}
}
