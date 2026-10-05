using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D86 RID: 19846
	[Token(Token = "0x2004D86")]
	public abstract class NameCardV2RemovableModuleBaseModel : NameCardV2ModuleBaseModel
	{
		// Token: 0x170045A0 RID: 17824
		// (get) Token: 0x0601DB27 RID: 121639
		[Token(Token = "0x170045A0")]
		public abstract NameCardV2ModuleSubType moduleSubType { [Token(Token = "0x601DB27")] get; }

		// Token: 0x0601DB28 RID: 121640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB28")]
		[Address(RVA = "0x174AB00", Offset = "0x1749700", VA = "0x18174AB00")]
		public void SetSelected(bool isSelected)
		{
		}

		// Token: 0x0601DB29 RID: 121641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB29")]
		[Address(RVA = "0x174A9E0", Offset = "0x17495E0", VA = "0x18174A9E0", Slot = "4")]
		public override void LoadSelfData(string nameCardSkinId, int nameCardSkinTmpl, NameCardV2ModuleData data)
		{
		}

		// Token: 0x0601DB2A RID: 121642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB2A")]
		[Address(RVA = "0x174A8D0", Offset = "0x17494D0", VA = "0x18174A8D0", Slot = "6")]
		public override void LoadFriendData(FriendDataWithNameCard friendData, NameCardV2ModuleData data)
		{
		}

		// Token: 0x0601DB2B RID: 121643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB2B")]
		[Address(RVA = "0x174AB90", Offset = "0x1749790", VA = "0x18174AB90")]
		protected NameCardV2RemovableModuleBaseModel()
		{
		}

		// Token: 0x0601DB2C RID: 121644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB2C")]
		[Address(RVA = "0x174AB80", Offset = "0x1749780", VA = "0x18174AB80")]
		private void <>xLuaBaseProxy_LoadSelfData(string P0, int P1, NameCardV2ModuleData P2)
		{
		}

		// Token: 0x0601DB2D RID: 121645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB2D")]
		[Address(RVA = "0x174AB70", Offset = "0x1749770", VA = "0x18174AB70")]
		private void <>xLuaBaseProxy_LoadFriendData(FriendDataWithNameCard P0, NameCardV2ModuleData P1)
		{
		}

		// Token: 0x040273E3 RID: 160739
		[Token(Token = "0x40273E3")]
		[FieldOffset(Offset = "0x38")]
		public int sortId;

		// Token: 0x040273E4 RID: 160740
		[Token(Token = "0x40273E4")]
		[FieldOffset(Offset = "0x40")]
		public string moduleName;

		// Token: 0x040273E5 RID: 160741
		[Token(Token = "0x40273E5")]
		[FieldOffset(Offset = "0x48")]
		public bool isSelected;

		// Token: 0x040273E6 RID: 160742
		[Token(Token = "0x40273E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetSelected;

		// Token: 0x040273E7 RID: 160743
		[Token(Token = "0x40273E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadSelfData;

		// Token: 0x040273E8 RID: 160744
		[Token(Token = "0x40273E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadFriendData;

		// Token: 0x040273E9 RID: 160745
		[Token(Token = "0x40273E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
