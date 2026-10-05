using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200259A RID: 9626
	[Token(Token = "0x200259A")]
	public class BattleUIPageSimpleCameraHandler : ISimpleCameraHandler, IHotfixable
	{
		// Token: 0x0600F822 RID: 63522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F822")]
		[Address(RVA = "0x6F1B90", Offset = "0x6F0790", VA = "0x1806F1B90")]
		public BattleUIPageSimpleCameraHandler(Camera camera)
		{
		}

		// Token: 0x0600F823 RID: 63523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F823")]
		[Address(RVA = "0x6F19E0", Offset = "0x6F05E0", VA = "0x1806F19E0", Slot = "4")]
		public Camera GetSimpleCamera()
		{
			return null;
		}

		// Token: 0x0600F824 RID: 63524 RVA: 0x0005CE98 File Offset: 0x0005B098
		[Token(Token = "0x600F824")]
		[Address(RVA = "0x6F1A40", Offset = "0x6F0640", VA = "0x1806F1A40", Slot = "5")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0600F825 RID: 63525 RVA: 0x0005CEB0 File Offset: 0x0005B0B0
		[Token(Token = "0x600F825")]
		[Address(RVA = "0x6F1940", Offset = "0x6F0540", VA = "0x1806F1940", Slot = "6")]
		public SortingInfo GetInitSortingInfo()
		{
			return default(SortingInfo);
		}

		// Token: 0x0600F826 RID: 63526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F826")]
		[Address(RVA = "0x6F1B30", Offset = "0x6F0730", VA = "0x1806F1B30", Slot = "7")]
		public void RequestSimpleCamera()
		{
		}

		// Token: 0x0600F827 RID: 63527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F827")]
		[Address(RVA = "0x6F1AD0", Offset = "0x6F06D0", VA = "0x1806F1AD0", Slot = "8")]
		public void ReleaseSimpleCamera()
		{
		}

		// Token: 0x0600F828 RID: 63528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F828")]
		[Address(RVA = "0x6F18C0", Offset = "0x6F04C0", VA = "0x1806F18C0", Slot = "9")]
		public void BindInitCanvasOnSimplePage(Canvas canvas)
		{
		}

		// Token: 0x0600F829 RID: 63529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F829")]
		[Address(RVA = "0x6F16B0", Offset = "0x6F02B0", VA = "0x1806F16B0", Slot = "10")]
		public void AdjustSimpleCamToHighest()
		{
		}

		// Token: 0x0600F82A RID: 63530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F82A")]
		[Address(RVA = "0x6F1710", Offset = "0x6F0310", VA = "0x1806F1710", Slot = "11")]
		public void AdjustSimpleCamToLowest()
		{
		}

		// Token: 0x0600F82B RID: 63531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F82B")]
		[Address(RVA = "0x6F1770", Offset = "0x6F0370", VA = "0x1806F1770", Slot = "12")]
		public void AdjustSimplePageOrder(UIPage lower, UIPage upper)
		{
		}

		// Token: 0x040113BB RID: 70587
		[Token(Token = "0x40113BB")]
		private const int BATTLE_UI_SIMPLE_PAGE_SORTING_ORDER_LOWER_BASE = 6700;

		// Token: 0x040113BC RID: 70588
		[Token(Token = "0x40113BC")]
		private const int BATTLE_UI_SIMPLE_PAGE_SORTING_ORDER_BASE = 6750;

		// Token: 0x040113BD RID: 70589
		[Token(Token = "0x40113BD")]
		[FieldOffset(Offset = "0x10")]
		private Camera m_simpleCamera;

		// Token: 0x040113BE RID: 70590
		[Token(Token = "0x40113BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040113BF RID: 70591
		[Token(Token = "0x40113BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSimpleCamera;

		// Token: 0x040113C0 RID: 70592
		[Token(Token = "0x40113C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x040113C1 RID: 70593
		[Token(Token = "0x40113C1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetInitSortingInfo;

		// Token: 0x040113C2 RID: 70594
		[Token(Token = "0x40113C2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RequestSimpleCamera;

		// Token: 0x040113C3 RID: 70595
		[Token(Token = "0x40113C3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ReleaseSimpleCamera;

		// Token: 0x040113C4 RID: 70596
		[Token(Token = "0x40113C4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_BindInitCanvasOnSimplePage;

		// Token: 0x040113C5 RID: 70597
		[Token(Token = "0x40113C5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_AdjustSimpleCamToHighest;

		// Token: 0x040113C6 RID: 70598
		[Token(Token = "0x40113C6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_AdjustSimpleCamToLowest;

		// Token: 0x040113C7 RID: 70599
		[Token(Token = "0x40113C7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_AdjustSimplePageOrder;
	}
}
