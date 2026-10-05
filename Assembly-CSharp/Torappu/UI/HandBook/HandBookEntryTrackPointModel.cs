using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066BD RID: 26301
	[Token(Token = "0x20066BD")]
	public class HandBookEntryTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700597D RID: 22909
		// (get) Token: 0x06025C54 RID: 154708 RVA: 0x000C8FE8 File Offset: 0x000C71E8
		[Token(Token = "0x1700597D")]
		public bool isShow
		{
			[Token(Token = "0x6025C54")]
			[Address(RVA = "0x20B7E80", Offset = "0x20B6A80", VA = "0x1820B7E80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025C55 RID: 154709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C55")]
		[Address(RVA = "0x20B7BD0", Offset = "0x20B67D0", VA = "0x1820B7BD0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06025C56 RID: 154710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C56")]
		[Address(RVA = "0x20B7E20", Offset = "0x20B6A20", VA = "0x1820B7E20")]
		public HandBookEntryTrackPointModel()
		{
		}

		// Token: 0x04035197 RID: 217495
		[Token(Token = "0x4035197")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04035198 RID: 217496
		[Token(Token = "0x4035198")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04035199 RID: 217497
		[Token(Token = "0x4035199")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403519A RID: 217498
		[Token(Token = "0x403519A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
