using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006337 RID: 25399
	[Token(Token = "0x2006337")]
	public class AutoChessShopLevelTrapGroupItemViewModel : IHotfixable
	{
		// Token: 0x1700566F RID: 22127
		// (get) Token: 0x06024A25 RID: 150053 RVA: 0x000C5058 File Offset: 0x000C3258
		// (set) Token: 0x06024A26 RID: 150054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700566F")]
		public int groupLevel
		{
			[Token(Token = "0x6024A25")]
			[Address(RVA = "0x1F89FC0", Offset = "0x1F88BC0", VA = "0x181F89FC0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6024A26")]
			[Address(RVA = "0x1F8A0E0", Offset = "0x1F88CE0", VA = "0x181F8A0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005670 RID: 22128
		// (get) Token: 0x06024A27 RID: 150055 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024A28 RID: 150056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005670")]
		public AutoChessShopLevelTagViewModel levelTagViewModel
		{
			[Token(Token = "0x6024A27")]
			[Address(RVA = "0x1F8A020", Offset = "0x1F88C20", VA = "0x181F8A020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024A28")]
			[Address(RVA = "0x1F8A150", Offset = "0x1F88D50", VA = "0x181F8A150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005671 RID: 22129
		// (get) Token: 0x06024A29 RID: 150057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005671")]
		public List<AutoChessShopTrapCardViewModel> levelTrapItemCardViewModelList
		{
			[Token(Token = "0x6024A29")]
			[Address(RVA = "0x1F8A080", Offset = "0x1F88C80", VA = "0x181F8A080")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024A2A RID: 150058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A2A")]
		[Address(RVA = "0x1F89BC0", Offset = "0x1F887C0", VA = "0x181F89BC0")]
		public void LoadData(ActAutoChessData.ActAutoChessShopLevelDisplayData displayData, ActAutoChessData actData)
		{
		}

		// Token: 0x06024A2B RID: 150059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A2B")]
		[Address(RVA = "0x1F89F10", Offset = "0x1F88B10", VA = "0x181F89F10")]
		public AutoChessShopLevelTrapGroupItemViewModel()
		{
		}

		// Token: 0x040331D9 RID: 209369
		[Token(Token = "0x40331D9")]
		[FieldOffset(Offset = "0x10")]
		private List<AutoChessShopTrapCardViewModel> m_levelTrapItemCardViewModelList;

		// Token: 0x040331DC RID: 209372
		[Token(Token = "0x40331DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupLevel;

		// Token: 0x040331DD RID: 209373
		[Token(Token = "0x40331DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_groupLevel;

		// Token: 0x040331DE RID: 209374
		[Token(Token = "0x40331DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_levelTagViewModel;

		// Token: 0x040331DF RID: 209375
		[Token(Token = "0x40331DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_levelTagViewModel;

		// Token: 0x040331E0 RID: 209376
		[Token(Token = "0x40331E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_levelTrapItemCardViewModelList;

		// Token: 0x040331E1 RID: 209377
		[Token(Token = "0x40331E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040331E2 RID: 209378
		[Token(Token = "0x40331E2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
