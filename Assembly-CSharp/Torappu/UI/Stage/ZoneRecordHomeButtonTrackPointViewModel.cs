using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069E8 RID: 27112
	[Token(Token = "0x20069E8")]
	public class ZoneRecordHomeButtonTrackPointViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17005B83 RID: 23427
		// (get) Token: 0x06026C6F RID: 158831 RVA: 0x000CC540 File Offset: 0x000CA740
		[Token(Token = "0x17005B83")]
		public bool isShow
		{
			[Token(Token = "0x6026C6F")]
			[Address(RVA = "0x21DF860", Offset = "0x21DE460", VA = "0x1821DF860", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06026C70 RID: 158832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C70")]
		[Address(RVA = "0x21DF730", Offset = "0x21DE330", VA = "0x1821DF730", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06026C71 RID: 158833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C71")]
		[Address(RVA = "0x21DF800", Offset = "0x21DE400", VA = "0x1821DF800")]
		public ZoneRecordHomeButtonTrackPointViewModel()
		{
		}

		// Token: 0x04036C7C RID: 224380
		[Token(Token = "0x4036C7C")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04036C7D RID: 224381
		[Token(Token = "0x4036C7D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04036C7E RID: 224382
		[Token(Token = "0x4036C7E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04036C7F RID: 224383
		[Token(Token = "0x4036C7F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020069E9 RID: 27113
		[Token(Token = "0x20069E9")]
		public class Input
		{
			// Token: 0x06026C72 RID: 158834 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026C72")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04036C80 RID: 224384
			[Token(Token = "0x4036C80")]
			[FieldOffset(Offset = "0x10")]
			public bool haveAbleToClaimRewards;
		}
	}
}
