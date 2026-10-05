using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007224 RID: 29220
	[Token(Token = "0x2007224")]
	public class Act5D1MissionAvailTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700621C RID: 25116
		// (get) Token: 0x060296AB RID: 169643 RVA: 0x000D5A20 File Offset: 0x000D3C20
		[Token(Token = "0x1700621C")]
		public bool isShow
		{
			[Token(Token = "0x60296AB")]
			[Address(RVA = "0x24C63B0", Offset = "0x24C4FB0", VA = "0x1824C63B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060296AC RID: 169644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296AC")]
		[Address(RVA = "0x24C5EF0", Offset = "0x24C4AF0", VA = "0x1824C5EF0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x060296AD RID: 169645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296AD")]
		[Address(RVA = "0x24C6350", Offset = "0x24C4F50", VA = "0x1824C6350")]
		public Act5D1MissionAvailTrackPointModel()
		{
		}

		// Token: 0x0403B25E RID: 242270
		[Token(Token = "0x403B25E")]
		[FieldOffset(Offset = "0x10")]
		public bool isFinish;

		// Token: 0x0403B25F RID: 242271
		[Token(Token = "0x403B25F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403B260 RID: 242272
		[Token(Token = "0x403B260")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403B261 RID: 242273
		[Token(Token = "0x403B261")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
