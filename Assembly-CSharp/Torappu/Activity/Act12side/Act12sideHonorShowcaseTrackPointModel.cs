using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act12side
{
	// Token: 0x02007A5E RID: 31326
	[Token(Token = "0x2007A5E")]
	public class Act12sideHonorShowcaseTrackPointModel : IHotfixable, ITrackPointModel
	{
		// Token: 0x170066D9 RID: 26329
		// (get) Token: 0x0602BE16 RID: 179734 RVA: 0x000DD850 File Offset: 0x000DBA50
		[Token(Token = "0x170066D9")]
		public bool isShow
		{
			[Token(Token = "0x602BE16")]
			[Address(RVA = "0x27C2200", Offset = "0x27C0E00", VA = "0x1827C2200", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BE17 RID: 179735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE17")]
		[Address(RVA = "0x27C20E0", Offset = "0x27C0CE0", VA = "0x1827C20E0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602BE18 RID: 179736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE18")]
		[Address(RVA = "0x27C21A0", Offset = "0x27C0DA0", VA = "0x1827C21A0")]
		public Act12sideHonorShowcaseTrackPointModel()
		{
		}

		// Token: 0x0403F8C5 RID: 260293
		[Token(Token = "0x403F8C5")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403F8C6 RID: 260294
		[Token(Token = "0x403F8C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403F8C7 RID: 260295
		[Token(Token = "0x403F8C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403F8C8 RID: 260296
		[Token(Token = "0x403F8C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
