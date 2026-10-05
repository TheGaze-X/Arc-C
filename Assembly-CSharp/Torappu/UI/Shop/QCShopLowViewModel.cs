using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B19 RID: 23321
	[Token(Token = "0x2005B19")]
	public class QCShopLowViewModel : IHotfixable
	{
		// Token: 0x06021DF2 RID: 138738 RVA: 0x000BB7B8 File Offset: 0x000B99B8
		[Token(Token = "0x6021DF2")]
		[Address(RVA = "0x1C5D100", Offset = "0x1C5BD00", VA = "0x181C5D100")]
		public bool IsLocked(int groupIndex)
		{
			return default(bool);
		}

		// Token: 0x06021DF3 RID: 138739 RVA: 0x000BB7D0 File Offset: 0x000B99D0
		[Token(Token = "0x6021DF3")]
		[Address(RVA = "0x1C5CF80", Offset = "0x1C5BB80", VA = "0x181C5CF80")]
		public int GetNextLockedGroupIndex()
		{
			return 0;
		}

		// Token: 0x06021DF4 RID: 138740 RVA: 0x000BB7E8 File Offset: 0x000B99E8
		[Token(Token = "0x6021DF4")]
		[Address(RVA = "0x1C5D060", Offset = "0x1C5BC60", VA = "0x181C5D060")]
		public int GetRemainingCostToUnlockNextGroup()
		{
			return 0;
		}

		// Token: 0x06021DF5 RID: 138741 RVA: 0x000BB800 File Offset: 0x000B9A00
		[Token(Token = "0x6021DF5")]
		[Address(RVA = "0x1C5CE70", Offset = "0x1C5BA70", VA = "0x181C5CE70")]
		public int GetCurrentGroupIndex()
		{
			return 0;
		}

		// Token: 0x06021DF6 RID: 138742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DF6")]
		[Address(RVA = "0x1C5C150", Offset = "0x1C5AD50", VA = "0x181C5C150")]
		public void ApplyData(GetLowGoodListResponse response)
		{
		}

		// Token: 0x06021DF7 RID: 138743 RVA: 0x000BB818 File Offset: 0x000B9A18
		[Token(Token = "0x6021DF7")]
		[Address(RVA = "0x1C5D1A0", Offset = "0x1C5BDA0", VA = "0x181C5D1A0")]
		private static int LowQCCommonObjComparison(QCCommonObj a, QCCommonObj b)
		{
			return 0;
		}

		// Token: 0x06021DF8 RID: 138744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DF8")]
		[Address(RVA = "0x1C5D300", Offset = "0x1C5BF00", VA = "0x181C5D300")]
		public QCShopLowViewModel()
		{
		}

		// Token: 0x0402E682 RID: 190082
		[Token(Token = "0x402E682")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public List<QCShopLowGroupViewModel> lowGroupViewModelList;

		// Token: 0x0402E683 RID: 190083
		[Token(Token = "0x402E683")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public string currentGroup;

		// Token: 0x0402E684 RID: 190084
		[Token(Token = "0x402E684")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public int lowShopType;

		// Token: 0x0402E685 RID: 190085
		[Token(Token = "0x402E685")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsLocked;

		// Token: 0x0402E686 RID: 190086
		[Token(Token = "0x402E686")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetNextLockedGroupIndex;

		// Token: 0x0402E687 RID: 190087
		[Token(Token = "0x402E687")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetRemainingCostToUnlockNextGroup;

		// Token: 0x0402E688 RID: 190088
		[Token(Token = "0x402E688")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCurrentGroupIndex;

		// Token: 0x0402E689 RID: 190089
		[Token(Token = "0x402E689")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E68A RID: 190090
		[Token(Token = "0x402E68A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LowQCCommonObjComparison;

		// Token: 0x0402E68B RID: 190091
		[Token(Token = "0x402E68B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
