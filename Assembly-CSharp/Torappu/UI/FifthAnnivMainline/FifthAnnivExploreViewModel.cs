using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EF5 RID: 20213
	[Token(Token = "0x2004EF5")]
	public class FifthAnnivExploreViewModel : IHotfixable
	{
		// Token: 0x0601E251 RID: 123473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E251")]
		[Address(RVA = "0x17DBDC0", Offset = "0x17DA9C0", VA = "0x1817DBDC0")]
		public void LoadData(FifthAnnivExploreViewModel.Param param, bool isInit, bool isNewGame)
		{
		}

		// Token: 0x0601E252 RID: 123474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E252")]
		[Address(RVA = "0x17DC010", Offset = "0x17DAC10", VA = "0x1817DC010")]
		public void LoadGameState()
		{
		}

		// Token: 0x0601E253 RID: 123475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E253")]
		[Address(RVA = "0x17DC0E0", Offset = "0x17DACE0", VA = "0x1817DC0E0")]
		public FifthAnnivExploreViewModel()
		{
		}

		// Token: 0x04028211 RID: 164369
		[Token(Token = "0x4028211")]
		[FieldOffset(Offset = "0x10")]
		public PlayerMainlineExplore.GameState gameState;

		// Token: 0x04028212 RID: 164370
		[Token(Token = "0x4028212")]
		[FieldOffset(Offset = "0x18")]
		public FifthAnnivExploreMapViewModel mapViewModel;

		// Token: 0x04028213 RID: 164371
		[Token(Token = "0x4028213")]
		[FieldOffset(Offset = "0x20")]
		public FifthAnnivExploreTopMenuViewModel topMenuViewModel;

		// Token: 0x04028214 RID: 164372
		[Token(Token = "0x4028214")]
		[FieldOffset(Offset = "0x28")]
		public FifthAnnivExploreSideInfoViewModel sideInfoViewModel;

		// Token: 0x04028215 RID: 164373
		[Token(Token = "0x4028215")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028216 RID: 164374
		[Token(Token = "0x4028216")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadGameState;

		// Token: 0x04028217 RID: 164375
		[Token(Token = "0x4028217")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004EF6 RID: 20214
		[Token(Token = "0x2004EF6")]
		public struct Param
		{
			// Token: 0x04028218 RID: 164376
			[Token(Token = "0x4028218")]
			[FieldOffset(Offset = "0x0")]
			public FifthAnnivExploreMapController.RouteCornerPos cornerPos;

			// Token: 0x04028219 RID: 164377
			[Token(Token = "0x4028219")]
			[FieldOffset(Offset = "0x20")]
			public float lineCornerCountFactor;

			// Token: 0x0402821A RID: 164378
			[Token(Token = "0x402821A")]
			[FieldOffset(Offset = "0x24")]
			public float lineMaxAmplitudeFactor;
		}
	}
}
