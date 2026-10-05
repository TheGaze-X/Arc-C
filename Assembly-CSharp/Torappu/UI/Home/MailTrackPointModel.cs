using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B85 RID: 19333
	[Token(Token = "0x2004B85")]
	public class MailTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004469 RID: 17513
		// (get) Token: 0x0601D186 RID: 119174 RVA: 0x000AA658 File Offset: 0x000A8858
		[Token(Token = "0x17004469")]
		public bool isShow
		{
			[Token(Token = "0x601D186")]
			[Address(RVA = "0x16AB740", Offset = "0x16AA340", VA = "0x1816AB740", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D187 RID: 119175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D187")]
		[Address(RVA = "0x16AB680", Offset = "0x16AA280", VA = "0x1816AB680", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D188 RID: 119176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D188")]
		[Address(RVA = "0x16AB6E0", Offset = "0x16AA2E0", VA = "0x1816AB6E0")]
		public MailTrackPointModel()
		{
		}

		// Token: 0x040262F6 RID: 156406
		[Token(Token = "0x40262F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040262F7 RID: 156407
		[Token(Token = "0x40262F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040262F8 RID: 156408
		[Token(Token = "0x40262F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
