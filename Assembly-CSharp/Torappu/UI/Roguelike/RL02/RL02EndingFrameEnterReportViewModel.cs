using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005761 RID: 22369
	[Token(Token = "0x2005761")]
	public class RL02EndingFrameEnterReportViewModel : RL02EndingFrameReportViewModel
	{
		// Token: 0x17004CCD RID: 19661
		// (get) Token: 0x06020C36 RID: 134198 RVA: 0x000B7138 File Offset: 0x000B5338
		[Token(Token = "0x17004CCD")]
		public override RL02ReportController.ReportViewType viewType
		{
			[Token(Token = "0x6020C36")]
			[Address(RVA = "0x1B1ECB0", Offset = "0x1B1D8B0", VA = "0x181B1ECB0", Slot = "4")]
			get
			{
				return RL02ReportController.ReportViewType.NONE;
			}
		}

		// Token: 0x06020C37 RID: 134199 RVA: 0x000B7150 File Offset: 0x000B5350
		[Token(Token = "0x6020C37")]
		[Address(RVA = "0x1B1E980", Offset = "0x1B1D580", VA = "0x181B1E980", Slot = "5")]
		protected override bool LoadData(string topicId, RL02EndingFrameViewModel dataSource)
		{
			return default(bool);
		}

		// Token: 0x06020C38 RID: 134200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C38")]
		[Address(RVA = "0x1B1EC10", Offset = "0x1B1D810", VA = "0x181B1EC10")]
		public RL02EndingFrameEnterReportViewModel()
		{
		}

		// Token: 0x0402C7CD RID: 182221
		[Token(Token = "0x402C7CD")]
		[FieldOffset(Offset = "0x18")]
		public string nickName;

		// Token: 0x0402C7CE RID: 182222
		[Token(Token = "0x402C7CE")]
		[FieldOffset(Offset = "0x20")]
		public string endingId;

		// Token: 0x0402C7CF RID: 182223
		[Token(Token = "0x402C7CF")]
		[FieldOffset(Offset = "0x28")]
		public string endingName;

		// Token: 0x0402C7D0 RID: 182224
		[Token(Token = "0x402C7D0")]
		[FieldOffset(Offset = "0x30")]
		public bool isSuccess;

		// Token: 0x0402C7D1 RID: 182225
		[Token(Token = "0x402C7D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0402C7D2 RID: 182226
		[Token(Token = "0x402C7D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C7D3 RID: 182227
		[Token(Token = "0x402C7D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
