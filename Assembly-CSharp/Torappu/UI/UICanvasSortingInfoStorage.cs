using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037E9 RID: 14313
	[Token(Token = "0x20037E9")]
	public class UICanvasSortingInfoStorage : UICommonSortingInfoStorage<Canvas>
	{
		// Token: 0x06016B01 RID: 92929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016B01")]
		[Address(RVA = "0xF0E5E0", Offset = "0xF0D1E0", VA = "0x180F0E5E0", Slot = "4")]
		protected override string _GetSortingLayerName(Canvas trace)
		{
			return null;
		}

		// Token: 0x06016B02 RID: 92930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B02")]
		[Address(RVA = "0xF0E6E0", Offset = "0xF0D2E0", VA = "0x180F0E6E0", Slot = "5")]
		protected override void _SetSortingLayerName(Canvas trace, string sortingLayerName)
		{
		}

		// Token: 0x06016B03 RID: 92931 RVA: 0x00092688 File Offset: 0x00090888
		[Token(Token = "0x6016B03")]
		[Address(RVA = "0xF0E660", Offset = "0xF0D260", VA = "0x180F0E660", Slot = "6")]
		protected override int _GetSortingOrder(Canvas trace)
		{
			return 0;
		}

		// Token: 0x06016B04 RID: 92932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B04")]
		[Address(RVA = "0xF0E780", Offset = "0xF0D380", VA = "0x180F0E780", Slot = "7")]
		protected override void _SetSortingOrder(Canvas trace, int sortingOrder)
		{
		}

		// Token: 0x06016B05 RID: 92933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B05")]
		[Address(RVA = "0xF0E820", Offset = "0xF0D420", VA = "0x180F0E820")]
		public UICanvasSortingInfoStorage()
		{
		}

		// Token: 0x0401B582 RID: 112002
		[Token(Token = "0x401B582")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetSortingLayerName;

		// Token: 0x0401B583 RID: 112003
		[Token(Token = "0x401B583")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetSortingLayerName;

		// Token: 0x0401B584 RID: 112004
		[Token(Token = "0x401B584")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetSortingOrder;

		// Token: 0x0401B585 RID: 112005
		[Token(Token = "0x401B585")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetSortingOrder;

		// Token: 0x0401B586 RID: 112006
		[Token(Token = "0x401B586")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
