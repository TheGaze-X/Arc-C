using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066BA RID: 26298
	[Token(Token = "0x20066BA")]
	public class HandBookInfoStageTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700597A RID: 22906
		// (get) Token: 0x06025C4B RID: 154699 RVA: 0x000C8FA0 File Offset: 0x000C71A0
		[Token(Token = "0x1700597A")]
		public bool isShow
		{
			[Token(Token = "0x6025C4B")]
			[Address(RVA = "0x20BD100", Offset = "0x20BBD00", VA = "0x1820BD100", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025C4C RID: 154700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C4C")]
		[Address(RVA = "0x20BCF90", Offset = "0x20BBB90", VA = "0x1820BCF90", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06025C4D RID: 154701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C4D")]
		[Address(RVA = "0x20BD0A0", Offset = "0x20BBCA0", VA = "0x1820BD0A0")]
		public HandBookInfoStageTrackPointModel()
		{
		}

		// Token: 0x0403518B RID: 217483
		[Token(Token = "0x403518B")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403518C RID: 217484
		[Token(Token = "0x403518C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403518D RID: 217485
		[Token(Token = "0x403518D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403518E RID: 217486
		[Token(Token = "0x403518E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
