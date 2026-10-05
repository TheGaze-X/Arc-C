using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x0200731D RID: 29469
	[Token(Token = "0x200731D")]
	public class Act42SideTaskBtnViewModel : IHotfixable
	{
		// Token: 0x06029AC0 RID: 170688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AC0")]
		[Address(RVA = "0x2514BE0", Offset = "0x25137E0", VA = "0x182514BE0")]
		public Act42SideTaskBtnViewModel()
		{
		}

		// Token: 0x0403B9E9 RID: 244201
		[Token(Token = "0x403B9E9")]
		[FieldOffset(Offset = "0x10")]
		public bool isSelected;

		// Token: 0x0403B9EA RID: 244202
		[Token(Token = "0x403B9EA")]
		[FieldOffset(Offset = "0x14")]
		public int index;

		// Token: 0x0403B9EB RID: 244203
		[Token(Token = "0x403B9EB")]
		[FieldOffset(Offset = "0x18")]
		public string taskId;

		// Token: 0x0403B9EC RID: 244204
		[Token(Token = "0x403B9EC")]
		[FieldOffset(Offset = "0x20")]
		public string whiteIconId;

		// Token: 0x0403B9ED RID: 244205
		[Token(Token = "0x403B9ED")]
		[FieldOffset(Offset = "0x28")]
		public string colorIconId;

		// Token: 0x0403B9EE RID: 244206
		[Token(Token = "0x403B9EE")]
		[FieldOffset(Offset = "0x30")]
		public PlayerActivity.PlayerAct42SideActivity.TaskState taskState;

		// Token: 0x0403B9EF RID: 244207
		[Token(Token = "0x403B9EF")]
		[FieldOffset(Offset = "0x34")]
		public bool isNew;

		// Token: 0x0403B9F0 RID: 244208
		[Token(Token = "0x403B9F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
