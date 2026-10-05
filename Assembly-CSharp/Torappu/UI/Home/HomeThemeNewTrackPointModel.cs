using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C23 RID: 19491
	[Token(Token = "0x2004C23")]
	public class HomeThemeNewTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170044D4 RID: 17620
		// (get) Token: 0x0601D46B RID: 119915 RVA: 0x000AB180 File Offset: 0x000A9380
		[Token(Token = "0x170044D4")]
		public bool isShow
		{
			[Token(Token = "0x601D46B")]
			[Address(RVA = "0x16DB030", Offset = "0x16D9C30", VA = "0x1816DB030", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D46C RID: 119916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D46C")]
		[Address(RVA = "0x16DAEF0", Offset = "0x16D9AF0", VA = "0x1816DAEF0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D46D RID: 119917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D46D")]
		[Address(RVA = "0x16DAFD0", Offset = "0x16D9BD0", VA = "0x1816DAFD0")]
		public HomeThemeNewTrackPointModel()
		{
		}

		// Token: 0x04026818 RID: 157720
		[Token(Token = "0x4026818")]
		[FieldOffset(Offset = "0x10")]
		private bool m_newThemeAchieved;

		// Token: 0x04026819 RID: 157721
		[Token(Token = "0x4026819")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0402681A RID: 157722
		[Token(Token = "0x402681A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0402681B RID: 157723
		[Token(Token = "0x402681B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
