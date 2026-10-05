using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BFB RID: 19451
	[Token(Token = "0x2004BFB")]
	public class HomeBackgroundNewTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170044C2 RID: 17602
		// (get) Token: 0x0601D3A9 RID: 119721 RVA: 0x000AAEF8 File Offset: 0x000A90F8
		[Token(Token = "0x170044C2")]
		public bool isShow
		{
			[Token(Token = "0x601D3A9")]
			[Address(RVA = "0x16C9B50", Offset = "0x16C8750", VA = "0x1816C9B50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D3AA RID: 119722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3AA")]
		[Address(RVA = "0x16C9A10", Offset = "0x16C8610", VA = "0x1816C9A10", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D3AB RID: 119723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3AB")]
		[Address(RVA = "0x16C9AF0", Offset = "0x16C86F0", VA = "0x1816C9AF0")]
		public HomeBackgroundNewTrackPointModel()
		{
		}

		// Token: 0x04026675 RID: 157301
		[Token(Token = "0x4026675")]
		[FieldOffset(Offset = "0x10")]
		private bool m_newBgAchieved;

		// Token: 0x04026676 RID: 157302
		[Token(Token = "0x4026676")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04026677 RID: 157303
		[Token(Token = "0x4026677")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04026678 RID: 157304
		[Token(Token = "0x4026678")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
