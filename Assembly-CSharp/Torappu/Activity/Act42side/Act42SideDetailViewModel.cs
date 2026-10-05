using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x0200731E RID: 29470
	[Token(Token = "0x200731E")]
	public class Act42SideDetailViewModel : IHotfixable
	{
		// Token: 0x06029AC1 RID: 170689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AC1")]
		[Address(RVA = "0x250A660", Offset = "0x2509260", VA = "0x18250A660")]
		public Act42SideDetailViewModel()
		{
		}

		// Token: 0x0403B9F1 RID: 244209
		[Token(Token = "0x403B9F1")]
		[FieldOffset(Offset = "0x10")]
		public bool isGun;

		// Token: 0x0403B9F2 RID: 244210
		[Token(Token = "0x403B9F2")]
		[FieldOffset(Offset = "0x18")]
		public string id;

		// Token: 0x0403B9F3 RID: 244211
		[Token(Token = "0x403B9F3")]
		[FieldOffset(Offset = "0x20")]
		public string trustorName;

		// Token: 0x0403B9F4 RID: 244212
		[Token(Token = "0x403B9F4")]
		[FieldOffset(Offset = "0x28")]
		public string title;

		// Token: 0x0403B9F5 RID: 244213
		[Token(Token = "0x403B9F5")]
		[FieldOffset(Offset = "0x30")]
		public string whiteIconId;

		// Token: 0x0403B9F6 RID: 244214
		[Token(Token = "0x403B9F6")]
		[FieldOffset(Offset = "0x38")]
		public string colorIconId;

		// Token: 0x0403B9F7 RID: 244215
		[Token(Token = "0x403B9F7")]
		[FieldOffset(Offset = "0x40")]
		public string content;

		// Token: 0x0403B9F8 RID: 244216
		[Token(Token = "0x403B9F8")]
		[FieldOffset(Offset = "0x48")]
		public string contentComplete;

		// Token: 0x0403B9F9 RID: 244217
		[Token(Token = "0x403B9F9")]
		[FieldOffset(Offset = "0x50")]
		public string taskDesc;

		// Token: 0x0403B9FA RID: 244218
		[Token(Token = "0x403B9FA")]
		[FieldOffset(Offset = "0x58")]
		public string stageId;

		// Token: 0x0403B9FB RID: 244219
		[Token(Token = "0x403B9FB")]
		[FieldOffset(Offset = "0x60")]
		public List<UIItemViewModel> rewards;

		// Token: 0x0403B9FC RID: 244220
		[Token(Token = "0x403B9FC")]
		[FieldOffset(Offset = "0x68")]
		public PlayerActivity.PlayerAct42SideActivity.TaskState taskState;

		// Token: 0x0403B9FD RID: 244221
		[Token(Token = "0x403B9FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
