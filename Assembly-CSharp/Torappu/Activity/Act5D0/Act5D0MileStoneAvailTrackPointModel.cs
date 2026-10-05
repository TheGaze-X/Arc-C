using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071F8 RID: 29176
	[Token(Token = "0x20071F8")]
	public class Act5D0MileStoneAvailTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17006205 RID: 25093
		// (get) Token: 0x06029619 RID: 169497 RVA: 0x000D5810 File Offset: 0x000D3A10
		[Token(Token = "0x17006205")]
		public bool isShow
		{
			[Token(Token = "0x6029619")]
			[Address(RVA = "0x24C0CB0", Offset = "0x24BF8B0", VA = "0x1824C0CB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602961A RID: 169498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602961A")]
		[Address(RVA = "0x24C0A60", Offset = "0x24BF660", VA = "0x1824C0A60", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602961B RID: 169499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602961B")]
		[Address(RVA = "0x24C0C50", Offset = "0x24BF850", VA = "0x1824C0C50")]
		public Act5D0MileStoneAvailTrackPointModel()
		{
		}

		// Token: 0x0403B1B4 RID: 242100
		[Token(Token = "0x403B1B4")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasNew;

		// Token: 0x0403B1B5 RID: 242101
		[Token(Token = "0x403B1B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403B1B6 RID: 242102
		[Token(Token = "0x403B1B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403B1B7 RID: 242103
		[Token(Token = "0x403B1B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
