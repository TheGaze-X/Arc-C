using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200633A RID: 25402
	[Token(Token = "0x200633A")]
	public class AutoChessShopLevelTrapGroupListViewModel : IHotfixable
	{
		// Token: 0x17005676 RID: 22134
		// (get) Token: 0x06024A3D RID: 150077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005676")]
		public List<AutoChessShopLevelTrapGroupItemViewModel> trapGroupViewList
		{
			[Token(Token = "0x6024A3D")]
			[Address(RVA = "0x1F8A5F0", Offset = "0x1F891F0", VA = "0x181F8A5F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005677 RID: 22135
		// (get) Token: 0x06024A3E RID: 150078 RVA: 0x000C5118 File Offset: 0x000C3318
		[Token(Token = "0x17005677")]
		public int enterSequenceNum
		{
			[Token(Token = "0x6024A3E")]
			[Address(RVA = "0x1F8A590", Offset = "0x1F89190", VA = "0x181F8A590")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06024A3F RID: 150079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A3F")]
		[Address(RVA = "0x1F8A1D0", Offset = "0x1F88DD0", VA = "0x181F8A1D0")]
		public void LoadData(ActAutoChessData actData, int iSequenceNum)
		{
		}

		// Token: 0x06024A40 RID: 150080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A40")]
		[Address(RVA = "0x1F8A4E0", Offset = "0x1F890E0", VA = "0x181F8A4E0")]
		public AutoChessShopLevelTrapGroupListViewModel()
		{
		}

		// Token: 0x040331F7 RID: 209399
		[Token(Token = "0x40331F7")]
		[FieldOffset(Offset = "0x10")]
		private List<AutoChessShopLevelTrapGroupItemViewModel> m_trapGroupViewList;

		// Token: 0x040331F8 RID: 209400
		[Token(Token = "0x40331F8")]
		[FieldOffset(Offset = "0x18")]
		private int m_enterSequenceNum;

		// Token: 0x040331F9 RID: 209401
		[Token(Token = "0x40331F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_trapGroupViewList;

		// Token: 0x040331FA RID: 209402
		[Token(Token = "0x40331FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enterSequenceNum;

		// Token: 0x040331FB RID: 209403
		[Token(Token = "0x40331FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040331FC RID: 209404
		[Token(Token = "0x40331FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
