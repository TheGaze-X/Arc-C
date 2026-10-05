using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005978 RID: 22904
	[Token(Token = "0x2005978")]
	public class CrisisV2MissionStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06021660 RID: 136800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021660")]
		[Address(RVA = "0x1BC9930", Offset = "0x1BC8530", VA = "0x181BC9930")]
		public CrisisV2MissionStateBean()
		{
		}

		// Token: 0x0402D8D7 RID: 186583
		[Token(Token = "0x402D8D7")]
		[FieldOffset(Offset = "0x10")]
		public CrisisV2MissionProperty property;

		// Token: 0x0402D8D8 RID: 186584
		[Token(Token = "0x402D8D8")]
		[FieldOffset(Offset = "0x18")]
		public string mapId;

		// Token: 0x0402D8D9 RID: 186585
		[Token(Token = "0x402D8D9")]
		[FieldOffset(Offset = "0x20")]
		public string previewId;

		// Token: 0x0402D8DA RID: 186586
		[Token(Token = "0x402D8DA")]
		[FieldOffset(Offset = "0x28")]
		public CrisisV2MapModel.ViewType previewViewType;

		// Token: 0x0402D8DB RID: 186587
		[Token(Token = "0x402D8DB")]
		[FieldOffset(Offset = "0x2C")]
		public CrisisV2MapModel.TargetType previewTargetType;

		// Token: 0x0402D8DC RID: 186588
		[Token(Token = "0x402D8DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
