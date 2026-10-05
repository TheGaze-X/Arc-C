using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071FE RID: 29182
	[Token(Token = "0x20071FE")]
	public class Act5D0MissionViewModel : IComparable<Act5D0MissionViewModel>, IHotfixable
	{
		// Token: 0x06029632 RID: 169522 RVA: 0x000D5858 File Offset: 0x000D3A58
		[Token(Token = "0x6029632")]
		[Address(RVA = "0x24C35C0", Offset = "0x24C21C0", VA = "0x1824C35C0", Slot = "4")]
		public int CompareTo(Act5D0MissionViewModel other)
		{
			return 0;
		}

		// Token: 0x06029633 RID: 169523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029633")]
		[Address(RVA = "0x24C3660", Offset = "0x24C2260", VA = "0x1824C3660")]
		public Act5D0MissionViewModel()
		{
		}

		// Token: 0x0403B1D4 RID: 242132
		[Token(Token = "0x403B1D4")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0403B1D5 RID: 242133
		[Token(Token = "0x403B1D5")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x0403B1D6 RID: 242134
		[Token(Token = "0x403B1D6")]
		[FieldOffset(Offset = "0x1C")]
		public Act5D0MissionViewModel.State state;

		// Token: 0x0403B1D7 RID: 242135
		[Token(Token = "0x403B1D7")]
		[FieldOffset(Offset = "0x20")]
		public Act5D0MissionViewModel.DifficultyLevel level;

		// Token: 0x0403B1D8 RID: 242136
		[Token(Token = "0x403B1D8")]
		[FieldOffset(Offset = "0x28")]
		public string title;

		// Token: 0x0403B1D9 RID: 242137
		[Token(Token = "0x403B1D9")]
		[FieldOffset(Offset = "0x30")]
		public string desc;

		// Token: 0x0403B1DA RID: 242138
		[Token(Token = "0x403B1DA")]
		[FieldOffset(Offset = "0x38")]
		public ItemBundle rewardItem;

		// Token: 0x0403B1DB RID: 242139
		[Token(Token = "0x403B1DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403B1DC RID: 242140
		[Token(Token = "0x403B1DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020071FF RID: 29183
		[Token(Token = "0x20071FF")]
		public enum State
		{
			// Token: 0x0403B1DE RID: 242142
			[Token(Token = "0x403B1DE")]
			FINISH,
			// Token: 0x0403B1DF RID: 242143
			[Token(Token = "0x403B1DF")]
			NOTAVAIL
		}

		// Token: 0x02007200 RID: 29184
		[Token(Token = "0x2007200")]
		public enum DifficultyLevel
		{
			// Token: 0x0403B1E1 RID: 242145
			[Token(Token = "0x403B1E1")]
			C,
			// Token: 0x0403B1E2 RID: 242146
			[Token(Token = "0x403B1E2")]
			B,
			// Token: 0x0403B1E3 RID: 242147
			[Token(Token = "0x403B1E3")]
			A,
			// Token: 0x0403B1E4 RID: 242148
			[Token(Token = "0x403B1E4")]
			S
		}
	}
}
