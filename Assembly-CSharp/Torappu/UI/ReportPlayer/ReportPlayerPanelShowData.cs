using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ReportPlayer
{
	// Token: 0x020046E6 RID: 18150
	[Token(Token = "0x20046E6")]
	public struct ReportPlayerPanelShowData
	{
		// Token: 0x04023A3B RID: 145979
		[Token(Token = "0x4023A3B")]
		[FieldOffset(Offset = "0x0")]
		public string actId;

		// Token: 0x04023A3C RID: 145980
		[Token(Token = "0x4023A3C")]
		[FieldOffset(Offset = "0x8")]
		public string serviceCode;

		// Token: 0x04023A3D RID: 145981
		[Token(Token = "0x4023A3D")]
		[FieldOffset(Offset = "0x10")]
		public int maxReportNum;

		// Token: 0x04023A3E RID: 145982
		[Token(Token = "0x4023A3E")]
		[FieldOffset(Offset = "0x18")]
		public ReportPlayerInfo targetPlayerInfo;

		// Token: 0x04023A3F RID: 145983
		[Token(Token = "0x4023A3F")]
		[FieldOffset(Offset = "0x48")]
		public List<CommonReportPlayerData> reportDataList;

		// Token: 0x04023A40 RID: 145984
		[Token(Token = "0x4023A40")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ReportPlayerPanelShowData EMPTY;
	}
}
