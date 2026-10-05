using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act29sign
{
	// Token: 0x0200748E RID: 29838
	[Token(Token = "0x200748E")]
	public class Act29signEntry : ActivityCommonCheckinEntry
	{
		// Token: 0x0602A13F RID: 172351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A13F")]
		[Address(RVA = "0x25BA5C0", Offset = "0x25B91C0", VA = "0x1825BA5C0", Slot = "4")]
		public override void OnEnter(string activityId)
		{
		}

		// Token: 0x0602A140 RID: 172352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A140")]
		[Address(RVA = "0x25BA650", Offset = "0x25B9250", VA = "0x1825BA650", Slot = "9")]
		protected override void RefreshInfo()
		{
		}

		// Token: 0x0602A141 RID: 172353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A141")]
		[Address(RVA = "0x25BA7E0", Offset = "0x25B93E0", VA = "0x1825BA7E0", Slot = "10")]
		protected override void _SwitchView(ActivityCheckinEntryView.CheckinViewType viewType)
		{
		}

		// Token: 0x0602A142 RID: 172354 RVA: 0x000D7640 File Offset: 0x000D5840
		[Token(Token = "0x602A142")]
		[Address(RVA = "0x25BA770", Offset = "0x25B9370", VA = "0x1825BA770", Slot = "11")]
		protected override ActivityCheckinEntryView.CheckinViewType _GetDefaultViewType()
		{
			return ActivityCheckinEntryView.CheckinViewType.NONE;
		}

		// Token: 0x0602A143 RID: 172355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A143")]
		[Address(RVA = "0x25BA870", Offset = "0x25B9470", VA = "0x1825BA870")]
		private void _UpdateEntryInfo()
		{
		}

		// Token: 0x0602A144 RID: 172356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A144")]
		[Address(RVA = "0x25BA920", Offset = "0x25B9520", VA = "0x1825BA920")]
		public Act29signEntry()
		{
		}

		// Token: 0x0602A145 RID: 172357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A145")]
		[Address(RVA = "0x25BA740", Offset = "0x25B9340", VA = "0x1825BA740")]
		private void <>xLuaBaseProxy_OnEnter(string P0)
		{
		}

		// Token: 0x0602A146 RID: 172358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A146")]
		[Address(RVA = "0x25BA760", Offset = "0x25B9360", VA = "0x1825BA760")]
		private void <>xLuaBaseProxy__SwitchView(ActivityCheckinEntryView.CheckinViewType P0)
		{
		}

		// Token: 0x0602A147 RID: 172359 RVA: 0x000D7658 File Offset: 0x000D5858
		[Token(Token = "0x602A147")]
		[Address(RVA = "0x25BA750", Offset = "0x25B9350", VA = "0x1825BA750")]
		private ActivityCheckinEntryView.CheckinViewType <>xLuaBaseProxy__GetDefaultViewType()
		{
			return ActivityCheckinEntryView.CheckinViewType.NONE;
		}

		// Token: 0x0403C665 RID: 247397
		[Token(Token = "0x403C665")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403C666 RID: 247398
		[Token(Token = "0x403C666")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshInfo;

		// Token: 0x0403C667 RID: 247399
		[Token(Token = "0x403C667")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SwitchView;

		// Token: 0x0403C668 RID: 247400
		[Token(Token = "0x403C668")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetDefaultViewType;

		// Token: 0x0403C669 RID: 247401
		[Token(Token = "0x403C669")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateEntryInfo;

		// Token: 0x0403C66A RID: 247402
		[Token(Token = "0x403C66A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
