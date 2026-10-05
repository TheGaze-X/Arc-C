using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D85 RID: 19845
	[Token(Token = "0x2004D85")]
	public abstract class NameCardV2ModuleBaseModel : IHotfixable
	{
		// Token: 0x0601DB1D RID: 121629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB1D")]
		[Address(RVA = "0x174A7A0", Offset = "0x17493A0", VA = "0x18174A7A0")]
		public void SetNameCardShowType(NameCardV2ViewModel.ShowType type)
		{
		}

		// Token: 0x0601DB1E RID: 121630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB1E")]
		[Address(RVA = "0x174A720", Offset = "0x1749320", VA = "0x18174A720")]
		public void SetNameCardMisc(NameCardMiscModel misc)
		{
		}

		// Token: 0x0601DB1F RID: 121631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB1F")]
		[Address(RVA = "0x174A560", Offset = "0x1749160", VA = "0x18174A560", Slot = "4")]
		public virtual void LoadSelfData(string nameCardSkinId, int nameCardSkinTmpl, NameCardV2ModuleData data)
		{
		}

		// Token: 0x0601DB20 RID: 121632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB20")]
		[Address(RVA = "0x174A650", Offset = "0x1749250", VA = "0x18174A650", Slot = "5")]
		public virtual void RefreshSelfData(string nameCardSkinId, int nameCardSkinTmpl)
		{
		}

		// Token: 0x0601DB21 RID: 121633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB21")]
		[Address(RVA = "0x174A3F0", Offset = "0x1748FF0", VA = "0x18174A3F0", Slot = "6")]
		public virtual void LoadFriendData(FriendDataWithNameCard friendData, NameCardV2ModuleData data)
		{
		}

		// Token: 0x0601DB22 RID: 121634
		[Token(Token = "0x601DB22")]
		protected abstract void OnLoadSelfData();

		// Token: 0x0601DB23 RID: 121635
		[Token(Token = "0x601DB23")]
		protected abstract void OnRefreshSelfData();

		// Token: 0x0601DB24 RID: 121636
		[Token(Token = "0x601DB24")]
		protected abstract void OnLoadFriendData(FriendDataWithNameCard data);

		// Token: 0x0601DB25 RID: 121637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DB25")]
		[Address(RVA = "0x1749D80", Offset = "0x1748980", VA = "0x181749D80")]
		public static NameCardV2ModuleBaseModel CreateModel(NameCardV2ModuleType type, NameCardV2ModuleSubType subType = NameCardV2ModuleSubType.NONE)
		{
			return null;
		}

		// Token: 0x0601DB26 RID: 121638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB26")]
		[Address(RVA = "0x174A810", Offset = "0x1749410", VA = "0x18174A810")]
		protected NameCardV2ModuleBaseModel()
		{
		}

		// Token: 0x040273D6 RID: 160726
		[Token(Token = "0x40273D6")]
		[FieldOffset(Offset = "0x10")]
		public string moduleId;

		// Token: 0x040273D7 RID: 160727
		[Token(Token = "0x40273D7")]
		[FieldOffset(Offset = "0x18")]
		public NameCardV2ModuleType moduleType;

		// Token: 0x040273D8 RID: 160728
		[Token(Token = "0x40273D8")]
		[FieldOffset(Offset = "0x20")]
		public string nameCardSkinId;

		// Token: 0x040273D9 RID: 160729
		[Token(Token = "0x40273D9")]
		[FieldOffset(Offset = "0x28")]
		public int nameCardSkinTmpl;

		// Token: 0x040273DA RID: 160730
		[Token(Token = "0x40273DA")]
		[FieldOffset(Offset = "0x2C")]
		public NameCardV2ViewModel.ShowType showType;

		// Token: 0x040273DB RID: 160731
		[Token(Token = "0x40273DB")]
		[FieldOffset(Offset = "0x30")]
		public NameCardMiscModel miscModel;

		// Token: 0x040273DC RID: 160732
		[Token(Token = "0x40273DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetNameCardShowType;

		// Token: 0x040273DD RID: 160733
		[Token(Token = "0x40273DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetNameCardMisc;

		// Token: 0x040273DE RID: 160734
		[Token(Token = "0x40273DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadSelfData;

		// Token: 0x040273DF RID: 160735
		[Token(Token = "0x40273DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshSelfData;

		// Token: 0x040273E0 RID: 160736
		[Token(Token = "0x40273E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadFriendData;

		// Token: 0x040273E1 RID: 160737
		[Token(Token = "0x40273E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CreateModel;

		// Token: 0x040273E2 RID: 160738
		[Token(Token = "0x40273E2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
