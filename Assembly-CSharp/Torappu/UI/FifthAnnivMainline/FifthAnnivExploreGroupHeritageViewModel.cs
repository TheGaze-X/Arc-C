using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F24 RID: 20260
	[Token(Token = "0x2004F24")]
	public class FifthAnnivExploreGroupHeritageViewModel : IHotfixable
	{
		// Token: 0x170046C4 RID: 18116
		// (get) Token: 0x0601E2FB RID: 123643 RVA: 0x000ADBF8 File Offset: 0x000ABDF8
		[Token(Token = "0x170046C4")]
		public bool hasHeritageData
		{
			[Token(Token = "0x601E2FB")]
			[Address(RVA = "0x17F0B10", Offset = "0x17EF710", VA = "0x1817F0B10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170046C5 RID: 18117
		// (get) Token: 0x0601E2FC RID: 123644 RVA: 0x000ADC10 File Offset: 0x000ABE10
		// (set) Token: 0x0601E2FD RID: 123645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046C5")]
		public bool hasSelectHeritage
		{
			[Token(Token = "0x601E2FC")]
			[Address(RVA = "0x17F0B70", Offset = "0x17EF770", VA = "0x1817F0B70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601E2FD")]
			[Address(RVA = "0x17F0BD0", Offset = "0x17EF7D0", VA = "0x1817F0BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601E2FE RID: 123646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2FE")]
		[Address(RVA = "0x17F0940", Offset = "0x17EF540", VA = "0x1817F0940")]
		public void LoadData(bool isInit)
		{
		}

		// Token: 0x0601E2FF RID: 123647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2FF")]
		[Address(RVA = "0x17F0A30", Offset = "0x17EF630", VA = "0x1817F0A30")]
		public void SetSelectHeritage(bool value)
		{
		}

		// Token: 0x0601E300 RID: 123648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E300")]
		[Address(RVA = "0x17F0AB0", Offset = "0x17EF6B0", VA = "0x1817F0AB0")]
		public FifthAnnivExploreGroupHeritageViewModel()
		{
		}

		// Token: 0x04028359 RID: 164697
		[Token(Token = "0x4028359")]
		[FieldOffset(Offset = "0x10")]
		public PlayerMainlineExplore.PlayerExploreGameResult lastResult;

		// Token: 0x0402835B RID: 164699
		[Token(Token = "0x402835B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasHeritageData;

		// Token: 0x0402835C RID: 164700
		[Token(Token = "0x402835C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hasSelectHeritage;

		// Token: 0x0402835D RID: 164701
		[Token(Token = "0x402835D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_hasSelectHeritage;

		// Token: 0x0402835E RID: 164702
		[Token(Token = "0x402835E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402835F RID: 164703
		[Token(Token = "0x402835F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetSelectHeritage;

		// Token: 0x04028360 RID: 164704
		[Token(Token = "0x4028360")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
