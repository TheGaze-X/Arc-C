using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077A1 RID: 30625
	[Token(Token = "0x20077A1")]
	public class Act1VHalfIdleDepotBuffViewModel : IHotfixable
	{
		// Token: 0x0602AFF5 RID: 176117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFF5")]
		[Address(RVA = "0x26C9AF0", Offset = "0x26C86F0", VA = "0x1826C9AF0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602AFF6 RID: 176118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFF6")]
		[Address(RVA = "0x26C9E10", Offset = "0x26C8A10", VA = "0x1826C9E10")]
		public void RefreshData()
		{
		}

		// Token: 0x0602AFF7 RID: 176119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFF7")]
		[Address(RVA = "0x26C9F60", Offset = "0x26C8B60", VA = "0x1826C9F60")]
		public Act1VHalfIdleDepotBuffViewModel()
		{
		}

		// Token: 0x0403E10C RID: 254220
		[Token(Token = "0x403E10C")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403E10D RID: 254221
		[Token(Token = "0x403E10D")]
		[FieldOffset(Offset = "0x18")]
		public List<Act1VHalfIdleDepotBuffItemViewModel> items;

		// Token: 0x0403E10E RID: 254222
		[Token(Token = "0x403E10E")]
		[FieldOffset(Offset = "0x20")]
		public int enterSeq;

		// Token: 0x0403E10F RID: 254223
		[Token(Token = "0x403E10F")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<int, List<Act1VHalfIdleCharAvatarViewModel>> profMap;

		// Token: 0x0403E110 RID: 254224
		[Token(Token = "0x403E110")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403E111 RID: 254225
		[Token(Token = "0x403E111")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403E112 RID: 254226
		[Token(Token = "0x403E112")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
