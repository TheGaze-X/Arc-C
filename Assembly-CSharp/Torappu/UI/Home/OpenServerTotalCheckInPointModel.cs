using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BBA RID: 19386
	[Token(Token = "0x2004BBA")]
	public class OpenServerTotalCheckInPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004491 RID: 17553
		// (get) Token: 0x0601D22B RID: 119339 RVA: 0x000AAAC0 File Offset: 0x000A8CC0
		[Token(Token = "0x17004491")]
		public bool isShow
		{
			[Token(Token = "0x601D22B")]
			[Address(RVA = "0x16AD340", Offset = "0x16ABF40", VA = "0x1816AD340", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D22C RID: 119340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D22C")]
		[Address(RVA = "0x16AD280", Offset = "0x16ABE80", VA = "0x1816AD280", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D22D RID: 119341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D22D")]
		[Address(RVA = "0x16AD2E0", Offset = "0x16ABEE0", VA = "0x1816AD2E0")]
		public OpenServerTotalCheckInPointModel()
		{
		}

		// Token: 0x040263CB RID: 156619
		[Token(Token = "0x40263CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040263CC RID: 156620
		[Token(Token = "0x40263CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040263CD RID: 156621
		[Token(Token = "0x40263CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
