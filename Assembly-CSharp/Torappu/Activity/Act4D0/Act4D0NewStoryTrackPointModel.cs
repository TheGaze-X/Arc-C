using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007292 RID: 29330
	[Token(Token = "0x2007292")]
	public class Act4D0NewStoryTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17006244 RID: 25156
		// (get) Token: 0x06029886 RID: 170118 RVA: 0x000D5DE0 File Offset: 0x000D3FE0
		[Token(Token = "0x17006244")]
		public bool isShow
		{
			[Token(Token = "0x6029886")]
			[Address(RVA = "0x24DFA60", Offset = "0x24DE660", VA = "0x1824DFA60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06029887 RID: 170119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029887")]
		[Address(RVA = "0x24DF890", Offset = "0x24DE490", VA = "0x1824DF890", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06029888 RID: 170120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029888")]
		[Address(RVA = "0x24DFA00", Offset = "0x24DE600", VA = "0x1824DFA00")]
		public Act4D0NewStoryTrackPointModel()
		{
		}

		// Token: 0x0403B5A6 RID: 243110
		[Token(Token = "0x403B5A6")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasNew;

		// Token: 0x0403B5A7 RID: 243111
		[Token(Token = "0x403B5A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403B5A8 RID: 243112
		[Token(Token = "0x403B5A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403B5A9 RID: 243113
		[Token(Token = "0x403B5A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
