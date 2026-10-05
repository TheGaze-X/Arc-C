using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037EA RID: 14314
	[Token(Token = "0x20037EA")]
	public class UIRendererSortingInfoStorage : UICommonSortingInfoStorage<Renderer>
	{
		// Token: 0x06016B06 RID: 92934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016B06")]
		[Address(RVA = "0xF1D0E0", Offset = "0xF1BCE0", VA = "0x180F1D0E0", Slot = "4")]
		protected override string _GetSortingLayerName(Renderer trace)
		{
			return null;
		}

		// Token: 0x06016B07 RID: 92935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B07")]
		[Address(RVA = "0xF1D1E0", Offset = "0xF1BDE0", VA = "0x180F1D1E0", Slot = "5")]
		protected override void _SetSortingLayerName(Renderer trace, string sortingLayerName)
		{
		}

		// Token: 0x06016B08 RID: 92936 RVA: 0x000926A0 File Offset: 0x000908A0
		[Token(Token = "0x6016B08")]
		[Address(RVA = "0xF1D160", Offset = "0xF1BD60", VA = "0x180F1D160", Slot = "6")]
		protected override int _GetSortingOrder(Renderer trace)
		{
			return 0;
		}

		// Token: 0x06016B09 RID: 92937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B09")]
		[Address(RVA = "0xF1D280", Offset = "0xF1BE80", VA = "0x180F1D280", Slot = "7")]
		protected override void _SetSortingOrder(Renderer trace, int sortingOrder)
		{
		}

		// Token: 0x06016B0A RID: 92938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B0A")]
		[Address(RVA = "0xF1D320", Offset = "0xF1BF20", VA = "0x180F1D320")]
		public UIRendererSortingInfoStorage()
		{
		}

		// Token: 0x0401B587 RID: 112007
		[Token(Token = "0x401B587")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetSortingLayerName;

		// Token: 0x0401B588 RID: 112008
		[Token(Token = "0x401B588")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetSortingLayerName;

		// Token: 0x0401B589 RID: 112009
		[Token(Token = "0x401B589")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetSortingOrder;

		// Token: 0x0401B58A RID: 112010
		[Token(Token = "0x401B58A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetSortingOrder;

		// Token: 0x0401B58B RID: 112011
		[Token(Token = "0x401B58B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
