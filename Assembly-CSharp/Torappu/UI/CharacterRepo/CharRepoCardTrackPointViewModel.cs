using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterRepo
{
	// Token: 0x02005E31 RID: 24113
	[Token(Token = "0x2005E31")]
	public class CharRepoCardTrackPointViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170052D4 RID: 21204
		// (get) Token: 0x06022F1D RID: 143133 RVA: 0x000BF8F8 File Offset: 0x000BDAF8
		[Token(Token = "0x170052D4")]
		public bool isShow
		{
			[Token(Token = "0x6022F1D")]
			[Address(RVA = "0x1D771B0", Offset = "0x1D75DB0", VA = "0x181D771B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06022F1E RID: 143134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F1E")]
		[Address(RVA = "0x1D77060", Offset = "0x1D75C60", VA = "0x181D77060", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06022F1F RID: 143135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F1F")]
		[Address(RVA = "0x1D77150", Offset = "0x1D75D50", VA = "0x181D77150")]
		public CharRepoCardTrackPointViewModel()
		{
		}

		// Token: 0x0403022B RID: 197163
		[Token(Token = "0x403022B")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasTrackPoint;

		// Token: 0x0403022C RID: 197164
		[Token(Token = "0x403022C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403022D RID: 197165
		[Token(Token = "0x403022D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403022E RID: 197166
		[Token(Token = "0x403022E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
