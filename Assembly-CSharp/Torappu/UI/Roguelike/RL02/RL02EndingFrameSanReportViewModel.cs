using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005762 RID: 22370
	[Token(Token = "0x2005762")]
	public class RL02EndingFrameSanReportViewModel : RL02EndingFrameReportViewModel
	{
		// Token: 0x17004CCE RID: 19662
		// (get) Token: 0x06020C39 RID: 134201 RVA: 0x000B7168 File Offset: 0x000B5368
		[Token(Token = "0x17004CCE")]
		public override RL02ReportController.ReportViewType viewType
		{
			[Token(Token = "0x6020C39")]
			[Address(RVA = "0x1B20570", Offset = "0x1B1F170", VA = "0x181B20570", Slot = "4")]
			get
			{
				return RL02ReportController.ReportViewType.NONE;
			}
		}

		// Token: 0x06020C3A RID: 134202 RVA: 0x000B7180 File Offset: 0x000B5380
		[Token(Token = "0x6020C3A")]
		[Address(RVA = "0x1B1FDC0", Offset = "0x1B1E9C0", VA = "0x181B1FDC0", Slot = "5")]
		protected override bool LoadData(string topicId, RL02EndingFrameViewModel dataSource)
		{
			return default(bool);
		}

		// Token: 0x06020C3B RID: 134203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C3B")]
		[Address(RVA = "0x1B200F0", Offset = "0x1B1ECF0", VA = "0x181B200F0")]
		private void _FillZoneSanInfos(List<RL02EndingFrameSanReportViewModel.ZoneSanInfo> zoneSanInfos)
		{
		}

		// Token: 0x06020C3C RID: 134204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C3C")]
		[Address(RVA = "0x1B204D0", Offset = "0x1B1F0D0", VA = "0x181B204D0")]
		public RL02EndingFrameSanReportViewModel()
		{
		}

		// Token: 0x0402C7D4 RID: 182228
		[Token(Token = "0x402C7D4")]
		private const int MAX_ZONE_INFOS_SIZE = 7;

		// Token: 0x0402C7D5 RID: 182229
		[Token(Token = "0x402C7D5")]
		[FieldOffset(Offset = "0x18")]
		public List<RL02EndingFrameSanReportViewModel.ZoneSanInfo> zoneSanInfos;

		// Token: 0x0402C7D6 RID: 182230
		[Token(Token = "0x402C7D6")]
		[FieldOffset(Offset = "0x20")]
		public int endSanValue;

		// Token: 0x0402C7D7 RID: 182231
		[Token(Token = "0x402C7D7")]
		[FieldOffset(Offset = "0x28")]
		public string endSanDesc;

		// Token: 0x0402C7D8 RID: 182232
		[Token(Token = "0x402C7D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0402C7D9 RID: 182233
		[Token(Token = "0x402C7D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C7DA RID: 182234
		[Token(Token = "0x402C7DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__FillZoneSanInfos;

		// Token: 0x0402C7DB RID: 182235
		[Token(Token = "0x402C7DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005763 RID: 22371
		[Token(Token = "0x2005763")]
		public struct ZoneSanInfo
		{
			// Token: 0x06020C3D RID: 134205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C3D")]
			[Address(RVA = "0x1B2D900", Offset = "0x1B2C500", VA = "0x181B2D900")]
			public void LoadData(string topicId, RL02EndingFrameViewModel.Zone zone)
			{
			}

			// Token: 0x0402C7DC RID: 182236
			[Token(Token = "0x402C7DC")]
			[FieldOffset(Offset = "0x0")]
			public string zoneId;

			// Token: 0x0402C7DD RID: 182237
			[Token(Token = "0x402C7DD")]
			[FieldOffset(Offset = "0x8")]
			public string zoneName;

			// Token: 0x0402C7DE RID: 182238
			[Token(Token = "0x402C7DE")]
			[FieldOffset(Offset = "0x10")]
			public int zoneSanValue;
		}
	}
}
