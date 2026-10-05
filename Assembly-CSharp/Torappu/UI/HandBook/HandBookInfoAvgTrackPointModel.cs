using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066B9 RID: 26297
	[Token(Token = "0x20066B9")]
	public class HandBookInfoAvgTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17005979 RID: 22905
		// (get) Token: 0x06025C48 RID: 154696 RVA: 0x000C8F88 File Offset: 0x000C7188
		[Token(Token = "0x17005979")]
		public bool isShow
		{
			[Token(Token = "0x6025C48")]
			[Address(RVA = "0x20BCF30", Offset = "0x20BBB30", VA = "0x1820BCF30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025C49 RID: 154697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C49")]
		[Address(RVA = "0x20BCD90", Offset = "0x20BB990", VA = "0x1820BCD90", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06025C4A RID: 154698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C4A")]
		[Address(RVA = "0x20BCED0", Offset = "0x20BBAD0", VA = "0x1820BCED0")]
		public HandBookInfoAvgTrackPointModel()
		{
		}

		// Token: 0x04035187 RID: 217479
		[Token(Token = "0x4035187")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04035188 RID: 217480
		[Token(Token = "0x4035188")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04035189 RID: 217481
		[Token(Token = "0x4035189")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403518A RID: 217482
		[Token(Token = "0x403518A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
