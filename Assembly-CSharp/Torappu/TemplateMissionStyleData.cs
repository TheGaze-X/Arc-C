using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001119 RID: 4377
	[Token(Token = "0x2001119")]
	public class TemplateMissionStyleData
	{
		// Token: 0x06006ED9 RID: 28377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TemplateMissionStyleData()
		{
		}

		// Token: 0x04005DC4 RID: 24004
		[Token(Token = "0x4005DC4")]
		[FieldOffset(Offset = "0x10")]
		public TemplateMissionBigRewardType bigRewardType;

		// Token: 0x04005DC5 RID: 24005
		[Token(Token = "0x4005DC5")]
		[FieldOffset(Offset = "0x18")]
		public List<string> bigRewardParamList;

		// Token: 0x04005DC6 RID: 24006
		[Token(Token = "0x4005DC6")]
		[FieldOffset(Offset = "0x20")]
		public bool isMissionListCommonType;

		// Token: 0x04005DC7 RID: 24007
		[Token(Token = "0x4005DC7")]
		[FieldOffset(Offset = "0x21")]
		public bool isMissionItemCommonType;

		// Token: 0x04005DC8 RID: 24008
		[Token(Token = "0x4005DC8")]
		[FieldOffset(Offset = "0x28")]
		public string missionItemMainColor;

		// Token: 0x04005DC9 RID: 24009
		[Token(Token = "0x4005DC9")]
		[FieldOffset(Offset = "0x30")]
		public bool isMissionItemCompleteUseMainColor;

		// Token: 0x04005DCA RID: 24010
		[Token(Token = "0x4005DCA")]
		[FieldOffset(Offset = "0x38")]
		public string missionItemCompleteColor;

		// Token: 0x04005DCB RID: 24011
		[Token(Token = "0x4005DCB")]
		[FieldOffset(Offset = "0x40")]
		public bool isMissionRewardItemCommonType;

		// Token: 0x04005DCC RID: 24012
		[Token(Token = "0x4005DCC")]
		[FieldOffset(Offset = "0x41")]
		public bool isClaimAllBtnCommonType;

		// Token: 0x04005DCD RID: 24013
		[Token(Token = "0x4005DCD")]
		[FieldOffset(Offset = "0x48")]
		public string claimAllBtnMainColor;

		// Token: 0x04005DCE RID: 24014
		[Token(Token = "0x4005DCE")]
		[FieldOffset(Offset = "0x50")]
		public string claimAllBtnTips;

		// Token: 0x04005DCF RID: 24015
		[Token(Token = "0x4005DCF")]
		[FieldOffset(Offset = "0x58")]
		public TemplateMissionTitleType titleType;

		// Token: 0x04005DD0 RID: 24016
		[Token(Token = "0x4005DD0")]
		[FieldOffset(Offset = "0x5C")]
		public TemplateMissionCoinInfoType coinType;

		// Token: 0x04005DD1 RID: 24017
		[Token(Token = "0x4005DD1")]
		[FieldOffset(Offset = "0x60")]
		public string coinBackColor;
	}
}
