using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DC3 RID: 24003
	[Token(Token = "0x2005DC3")]
	public class ClimbTowerLayerViewModel : IHotfixable
	{
		// Token: 0x06022C89 RID: 142473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C89")]
		[Address(RVA = "0x1D55E70", Offset = "0x1D54A70", VA = "0x181D55E70")]
		public void InitDataIfNot(ClimbTowerViewModel model)
		{
		}

		// Token: 0x06022C8A RID: 142474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C8A")]
		[Address(RVA = "0x1D560D0", Offset = "0x1D54CD0", VA = "0x181D560D0")]
		public void LoadData()
		{
		}

		// Token: 0x06022C8B RID: 142475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C8B")]
		[Address(RVA = "0x1D56440", Offset = "0x1D55040", VA = "0x181D56440")]
		private void _SetSelectIndex(int index)
		{
		}

		// Token: 0x17005231 RID: 21041
		// (get) Token: 0x06022C8C RID: 142476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005231")]
		public List<ClimbTowerLevelModel> currentlevels
		{
			[Token(Token = "0x6022C8C")]
			[Address(RVA = "0x1D565A0", Offset = "0x1D551A0", VA = "0x181D565A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005232 RID: 21042
		// (get) Token: 0x06022C8D RID: 142477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005232")]
		public ClimbTowerLevelModel selectedLevelModel
		{
			[Token(Token = "0x6022C8D")]
			[Address(RVA = "0x1D56780", Offset = "0x1D55380", VA = "0x181D56780")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005233 RID: 21043
		// (get) Token: 0x06022C8E RID: 142478 RVA: 0x000BECE0 File Offset: 0x000BCEE0
		[Token(Token = "0x17005233")]
		public bool isFirstItem
		{
			[Token(Token = "0x6022C8E")]
			[Address(RVA = "0x1D56690", Offset = "0x1D55290", VA = "0x181D56690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005234 RID: 21044
		// (get) Token: 0x06022C8F RID: 142479 RVA: 0x000BECF8 File Offset: 0x000BCEF8
		[Token(Token = "0x17005234")]
		public bool isLastItem
		{
			[Token(Token = "0x6022C8F")]
			[Address(RVA = "0x1D566F0", Offset = "0x1D552F0", VA = "0x181D566F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06022C90 RID: 142480 RVA: 0x000BED10 File Offset: 0x000BCF10
		[Token(Token = "0x6022C90")]
		[Address(RVA = "0x1D56060", Offset = "0x1D54C60", VA = "0x181D56060")]
		public bool IsLevelPassed(int layerNum)
		{
			return default(bool);
		}

		// Token: 0x06022C91 RID: 142481 RVA: 0x000BED28 File Offset: 0x000BCF28
		[Token(Token = "0x6022C91")]
		[Address(RVA = "0x1D562C0", Offset = "0x1D54EC0", VA = "0x181D562C0")]
		public bool SwitchSelectedIndex(bool switchDown)
		{
			return default(bool);
		}

		// Token: 0x06022C92 RID: 142482 RVA: 0x000BED40 File Offset: 0x000BCF40
		[Token(Token = "0x6022C92")]
		[Address(RVA = "0x1D56240", Offset = "0x1D54E40", VA = "0x181D56240")]
		public bool SelectCurrIndex()
		{
			return default(bool);
		}

		// Token: 0x06022C93 RID: 142483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C93")]
		[Address(RVA = "0x1D56540", Offset = "0x1D55140", VA = "0x181D56540")]
		public ClimbTowerLayerViewModel()
		{
		}

		// Token: 0x0402FD7D RID: 195965
		[Token(Token = "0x402FD7D")]
		[FieldOffset(Offset = "0x10")]
		public ClimbTowerViewModel towerModel;

		// Token: 0x0402FD7E RID: 195966
		[Token(Token = "0x402FD7E")]
		[FieldOffset(Offset = "0x18")]
		public int selectedIndex;

		// Token: 0x0402FD7F RID: 195967
		[Token(Token = "0x402FD7F")]
		[FieldOffset(Offset = "0x1C")]
		public int currLayerNum;

		// Token: 0x0402FD80 RID: 195968
		[Token(Token = "0x402FD80")]
		[FieldOffset(Offset = "0x20")]
		public int currLayerTryCount;

		// Token: 0x0402FD81 RID: 195969
		[Token(Token = "0x402FD81")]
		[FieldOffset(Offset = "0x24")]
		public int addLowerItemCount;

		// Token: 0x0402FD82 RID: 195970
		[Token(Token = "0x402FD82")]
		[FieldOffset(Offset = "0x28")]
		public int addHigherItemCount;

		// Token: 0x0402FD83 RID: 195971
		[Token(Token = "0x402FD83")]
		[FieldOffset(Offset = "0x2C")]
		public bool isHardMode;

		// Token: 0x0402FD84 RID: 195972
		[Token(Token = "0x402FD84")]
		[FieldOffset(Offset = "0x2D")]
		public bool isSubCardSelected;

		// Token: 0x0402FD85 RID: 195973
		[Token(Token = "0x402FD85")]
		[FieldOffset(Offset = "0x30")]
		public ClimbTowerLayerViewModel.OverrideData overrideData;

		// Token: 0x0402FD86 RID: 195974
		[Token(Token = "0x402FD86")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitDataIfNot;

		// Token: 0x0402FD87 RID: 195975
		[Token(Token = "0x402FD87")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FD88 RID: 195976
		[Token(Token = "0x402FD88")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetSelectIndex;

		// Token: 0x0402FD89 RID: 195977
		[Token(Token = "0x402FD89")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_currentlevels;

		// Token: 0x0402FD8A RID: 195978
		[Token(Token = "0x402FD8A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectedLevelModel;

		// Token: 0x0402FD8B RID: 195979
		[Token(Token = "0x402FD8B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isFirstItem;

		// Token: 0x0402FD8C RID: 195980
		[Token(Token = "0x402FD8C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isLastItem;

		// Token: 0x0402FD8D RID: 195981
		[Token(Token = "0x402FD8D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsLevelPassed;

		// Token: 0x0402FD8E RID: 195982
		[Token(Token = "0x402FD8E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SwitchSelectedIndex;

		// Token: 0x0402FD8F RID: 195983
		[Token(Token = "0x402FD8F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SelectCurrIndex;

		// Token: 0x0402FD90 RID: 195984
		[Token(Token = "0x402FD90")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005DC4 RID: 24004
		[Token(Token = "0x2005DC4")]
		public class OverrideData
		{
			// Token: 0x06022C94 RID: 142484 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022C94")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OverrideData()
			{
			}

			// Token: 0x0402FD91 RID: 195985
			[Token(Token = "0x402FD91")]
			[FieldOffset(Offset = "0x10")]
			public int selectedIndex;

			// Token: 0x0402FD92 RID: 195986
			[Token(Token = "0x402FD92")]
			[FieldOffset(Offset = "0x14")]
			public int currLayerNum;

			// Token: 0x0402FD93 RID: 195987
			[Token(Token = "0x402FD93")]
			[FieldOffset(Offset = "0x18")]
			public List<int> passedLayerNum;
		}
	}
}
