using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D88 RID: 19848
	[Token(Token = "0x2004D88")]
	public class NameCardV2IllustModuleModel : NameCardV2ModuleBaseModel
	{
		// Token: 0x0601DB32 RID: 121650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB32")]
		[Address(RVA = "0x1748A60", Offset = "0x1747660", VA = "0x181748A60", Slot = "9")]
		protected override void OnLoadFriendData(FriendDataWithNameCard data)
		{
		}

		// Token: 0x0601DB33 RID: 121651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB33")]
		[Address(RVA = "0x1748B30", Offset = "0x1747730", VA = "0x181748B30", Slot = "7")]
		protected override void OnLoadSelfData()
		{
		}

		// Token: 0x0601DB34 RID: 121652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB34")]
		[Address(RVA = "0x1748B90", Offset = "0x1747790", VA = "0x181748B90", Slot = "8")]
		protected override void OnRefreshSelfData()
		{
		}

		// Token: 0x0601DB35 RID: 121653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB35")]
		[Address(RVA = "0x1748C30", Offset = "0x1747830", VA = "0x181748C30")]
		public NameCardV2IllustModuleModel()
		{
		}

		// Token: 0x040273EE RID: 160750
		[Token(Token = "0x40273EE")]
		[FieldOffset(Offset = "0x38")]
		public CharUISkinStruct homeIllustChar;

		// Token: 0x040273EF RID: 160751
		[Token(Token = "0x40273EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoadFriendData;

		// Token: 0x040273F0 RID: 160752
		[Token(Token = "0x40273F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnLoadSelfData;

		// Token: 0x040273F1 RID: 160753
		[Token(Token = "0x40273F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRefreshSelfData;

		// Token: 0x040273F2 RID: 160754
		[Token(Token = "0x40273F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
