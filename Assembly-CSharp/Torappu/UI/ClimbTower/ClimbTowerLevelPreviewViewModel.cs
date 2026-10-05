using System;
using Il2CppDummyDll;
using Torappu.UI.EnemyHandBook;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DC6 RID: 24006
	[Token(Token = "0x2005DC6")]
	public class ClimbTowerLevelPreviewViewModel : IHotfixable
	{
		// Token: 0x06022C96 RID: 142486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C96")]
		[Address(RVA = "0x1D570B0", Offset = "0x1D55CB0", VA = "0x181D570B0")]
		public void InitDataIfNot(ClimbTowerViewModel model)
		{
		}

		// Token: 0x17005235 RID: 21045
		// (get) Token: 0x06022C97 RID: 142487 RVA: 0x000BED58 File Offset: 0x000BCF58
		[Token(Token = "0x17005235")]
		public int selectedIndex
		{
			[Token(Token = "0x6022C97")]
			[Address(RVA = "0x1D57670", Offset = "0x1D56270", VA = "0x181D57670")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005236 RID: 21046
		// (get) Token: 0x06022C98 RID: 142488 RVA: 0x000BED70 File Offset: 0x000BCF70
		[Token(Token = "0x17005236")]
		public bool isShowingBoss
		{
			[Token(Token = "0x6022C98")]
			[Address(RVA = "0x1D575F0", Offset = "0x1D561F0", VA = "0x181D575F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005237 RID: 21047
		// (get) Token: 0x06022C99 RID: 142489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005237")]
		public ClimbTowerLevelModel selectedLevelModel
		{
			[Token(Token = "0x6022C99")]
			[Address(RVA = "0x1D576F0", Offset = "0x1D562F0", VA = "0x181D576F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005238 RID: 21048
		// (get) Token: 0x06022C9A RID: 142490 RVA: 0x000BED88 File Offset: 0x000BCF88
		[Token(Token = "0x17005238")]
		public bool isFirstItem
		{
			[Token(Token = "0x6022C9A")]
			[Address(RVA = "0x1D57500", Offset = "0x1D56100", VA = "0x181D57500")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005239 RID: 21049
		// (get) Token: 0x06022C9B RID: 142491 RVA: 0x000BEDA0 File Offset: 0x000BCFA0
		[Token(Token = "0x17005239")]
		public bool isLastItem
		{
			[Token(Token = "0x6022C9B")]
			[Address(RVA = "0x1D57560", Offset = "0x1D56160", VA = "0x181D57560")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06022C9C RID: 142492 RVA: 0x000BEDB8 File Offset: 0x000BCFB8
		[Token(Token = "0x6022C9C")]
		[Address(RVA = "0x1D57350", Offset = "0x1D55F50", VA = "0x181D57350")]
		public bool SwitchSelectedIndex(bool switchDown)
		{
			return default(bool);
		}

		// Token: 0x06022C9D RID: 142493 RVA: 0x000BEDD0 File Offset: 0x000BCFD0
		[Token(Token = "0x6022C9D")]
		[Address(RVA = "0x1D572C0", Offset = "0x1D55EC0", VA = "0x181D572C0")]
		public bool SelectLastIndex()
		{
			return default(bool);
		}

		// Token: 0x06022C9E RID: 142494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C9E")]
		[Address(RVA = "0x1D574A0", Offset = "0x1D560A0", VA = "0x181D574A0")]
		public ClimbTowerLevelPreviewViewModel()
		{
		}

		// Token: 0x0402FD94 RID: 195988
		[Token(Token = "0x402FD94")]
		[FieldOffset(Offset = "0x10")]
		public ClimbTowerViewModel towerModel;

		// Token: 0x0402FD95 RID: 195989
		[Token(Token = "0x402FD95")]
		[FieldOffset(Offset = "0x18")]
		public ClimbTowerLevelPreviewViewModel.SelectedParam[] selectedParams;

		// Token: 0x0402FD96 RID: 195990
		[Token(Token = "0x402FD96")]
		[FieldOffset(Offset = "0x20")]
		public EnemyHandBookEverViewModel bossInfoModel;

		// Token: 0x0402FD97 RID: 195991
		[Token(Token = "0x402FD97")]
		[FieldOffset(Offset = "0x28")]
		public int selectedParamsIndex;

		// Token: 0x0402FD98 RID: 195992
		[Token(Token = "0x402FD98")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitDataIfNot;

		// Token: 0x0402FD99 RID: 195993
		[Token(Token = "0x402FD99")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedIndex;

		// Token: 0x0402FD9A RID: 195994
		[Token(Token = "0x402FD9A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isShowingBoss;

		// Token: 0x0402FD9B RID: 195995
		[Token(Token = "0x402FD9B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectedLevelModel;

		// Token: 0x0402FD9C RID: 195996
		[Token(Token = "0x402FD9C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isFirstItem;

		// Token: 0x0402FD9D RID: 195997
		[Token(Token = "0x402FD9D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isLastItem;

		// Token: 0x0402FD9E RID: 195998
		[Token(Token = "0x402FD9E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SwitchSelectedIndex;

		// Token: 0x0402FD9F RID: 195999
		[Token(Token = "0x402FD9F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SelectLastIndex;

		// Token: 0x0402FDA0 RID: 196000
		[Token(Token = "0x402FDA0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005DC7 RID: 24007
		[Token(Token = "0x2005DC7")]
		public struct SelectedParam
		{
			// Token: 0x0402FDA1 RID: 196001
			[Token(Token = "0x402FDA1")]
			[FieldOffset(Offset = "0x0")]
			public int selectedIndex;

			// Token: 0x0402FDA2 RID: 196002
			[Token(Token = "0x402FDA2")]
			[FieldOffset(Offset = "0x4")]
			public bool isShowingBoss;
		}
	}
}
