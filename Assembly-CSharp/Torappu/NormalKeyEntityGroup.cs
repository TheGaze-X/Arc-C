using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200052D RID: 1325
	[Token(Token = "0x200052D")]
	public class NormalKeyEntityGroup : KeyEntityGroupBase
	{
		// Token: 0x06004FAA RID: 20394 RVA: 0x0002E6E0 File Offset: 0x0002C8E0
		[Token(Token = "0x6004FAA")]
		[Address(RVA = "0x1AF6290", Offset = "0x1AF4E90", VA = "0x181AF6290", Slot = "4")]
		protected override bool CheckIfUseGroup()
		{
			return default(bool);
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FAB")]
		[Address(RVA = "0x1AF62F0", Offset = "0x1AF4EF0", VA = "0x181AF62F0", Slot = "5")]
		protected override void LoadGroupData(KeySettingGroupData groupData)
		{
		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FAC")]
		[Address(RVA = "0x1AF6350", Offset = "0x1AF4F50", VA = "0x181AF6350")]
		public NormalKeyEntityGroup()
		{
		}

		// Token: 0x04001434 RID: 5172
		[Token(Token = "0x4001434")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfUseGroup;

		// Token: 0x04001435 RID: 5173
		[Token(Token = "0x4001435")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadGroupData;

		// Token: 0x04001436 RID: 5174
		[Token(Token = "0x4001436")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
