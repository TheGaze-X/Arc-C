using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006137 RID: 24887
	[Token(Token = "0x2006137")]
	public class CampaignZoneMapJumpStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06023EE6 RID: 147174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EE6")]
		[Address(RVA = "0x1E93A70", Offset = "0x1E92670", VA = "0x181E93A70")]
		public void InitInfo()
		{
		}

		// Token: 0x06023EE7 RID: 147175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EE7")]
		[Address(RVA = "0x1E93E30", Offset = "0x1E92A30", VA = "0x181E93E30")]
		public CampaignZoneMapJumpStateBean()
		{
		}

		// Token: 0x04031E14 RID: 204308
		[Token(Token = "0x4031E14")]
		[FieldOffset(Offset = "0x10")]
		public List<CampaignZoneJumpViewModel> jumpBtnList;

		// Token: 0x04031E15 RID: 204309
		[Token(Token = "0x4031E15")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitInfo;

		// Token: 0x04031E16 RID: 204310
		[Token(Token = "0x4031E16")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
