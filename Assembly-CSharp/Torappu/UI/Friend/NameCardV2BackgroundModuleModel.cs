using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D87 RID: 19847
	[Token(Token = "0x2004D87")]
	public class NameCardV2BackgroundModuleModel : NameCardV2ModuleBaseModel
	{
		// Token: 0x0601DB2E RID: 121646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB2E")]
		[Address(RVA = "0x1745DA0", Offset = "0x17449A0", VA = "0x181745DA0", Slot = "9")]
		protected override void OnLoadFriendData(FriendDataWithNameCard data)
		{
		}

		// Token: 0x0601DB2F RID: 121647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB2F")]
		[Address(RVA = "0x1745E00", Offset = "0x1744A00", VA = "0x181745E00", Slot = "7")]
		protected override void OnLoadSelfData()
		{
		}

		// Token: 0x0601DB30 RID: 121648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB30")]
		[Address(RVA = "0x1745E60", Offset = "0x1744A60", VA = "0x181745E60", Slot = "8")]
		protected override void OnRefreshSelfData()
		{
		}

		// Token: 0x0601DB31 RID: 121649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB31")]
		[Address(RVA = "0x1745EC0", Offset = "0x1744AC0", VA = "0x181745EC0")]
		public NameCardV2BackgroundModuleModel()
		{
		}

		// Token: 0x040273EA RID: 160746
		[Token(Token = "0x40273EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoadFriendData;

		// Token: 0x040273EB RID: 160747
		[Token(Token = "0x40273EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnLoadSelfData;

		// Token: 0x040273EC RID: 160748
		[Token(Token = "0x40273EC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRefreshSelfData;

		// Token: 0x040273ED RID: 160749
		[Token(Token = "0x40273ED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
