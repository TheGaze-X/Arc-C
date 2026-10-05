using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070E9 RID: 28905
	[Token(Token = "0x20070E9")]
	public class ActAutoChessDailyMissionViewModel : IHotfixable
	{
		// Token: 0x0602916F RID: 168303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602916F")]
		[Address(RVA = "0x247DAD0", Offset = "0x247C6D0", VA = "0x18247DAD0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06029170 RID: 168304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029170")]
		[Address(RVA = "0x247DCD0", Offset = "0x247C8D0", VA = "0x18247DCD0")]
		public ActAutoChessDailyMissionViewModel()
		{
		}

		// Token: 0x0403AA3B RID: 240187
		[Token(Token = "0x403AA3B")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		// Token: 0x0403AA3C RID: 240188
		[Token(Token = "0x403AA3C")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x0403AA3D RID: 240189
		[Token(Token = "0x403AA3D")]
		[FieldOffset(Offset = "0x20")]
		public int value;

		// Token: 0x0403AA3E RID: 240190
		[Token(Token = "0x403AA3E")]
		[FieldOffset(Offset = "0x24")]
		public int target;

		// Token: 0x0403AA3F RID: 240191
		[Token(Token = "0x403AA3F")]
		[FieldOffset(Offset = "0x28")]
		public float progress;

		// Token: 0x0403AA40 RID: 240192
		[Token(Token = "0x403AA40")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403AA41 RID: 240193
		[Token(Token = "0x403AA41")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
