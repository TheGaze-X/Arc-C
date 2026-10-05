using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x0200731B RID: 29467
	[Token(Token = "0x200731B")]
	public class Act42SideTrustorTabViewModel : IHotfixable
	{
		// Token: 0x06029ABE RID: 170686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ABE")]
		[Address(RVA = "0x2514C40", Offset = "0x2513840", VA = "0x182514C40")]
		public Act42SideTrustorTabViewModel()
		{
		}

		// Token: 0x0403B9D7 RID: 244183
		[Token(Token = "0x403B9D7")]
		[FieldOffset(Offset = "0x10")]
		public bool isSelected;

		// Token: 0x0403B9D8 RID: 244184
		[Token(Token = "0x403B9D8")]
		[FieldOffset(Offset = "0x18")]
		public string trustorId;

		// Token: 0x0403B9D9 RID: 244185
		[Token(Token = "0x403B9D9")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x0403B9DA RID: 244186
		[Token(Token = "0x403B9DA")]
		[FieldOffset(Offset = "0x28")]
		public string avatarId;

		// Token: 0x0403B9DB RID: 244187
		[Token(Token = "0x403B9DB")]
		[FieldOffset(Offset = "0x30")]
		public int completedTaskCnt;

		// Token: 0x0403B9DC RID: 244188
		[Token(Token = "0x403B9DC")]
		[FieldOffset(Offset = "0x34")]
		public bool hasNew;

		// Token: 0x0403B9DD RID: 244189
		[Token(Token = "0x403B9DD")]
		[FieldOffset(Offset = "0x35")]
		public bool isWorking;

		// Token: 0x0403B9DE RID: 244190
		[Token(Token = "0x403B9DE")]
		[FieldOffset(Offset = "0x36")]
		public bool hasTaskToSubmit;

		// Token: 0x0403B9DF RID: 244191
		[Token(Token = "0x403B9DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
