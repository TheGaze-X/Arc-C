using System;
using Il2CppDummyDll;
using Torappu;
using UnityEngine;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001DD RID: 477
	[Token(Token = "0x20001DD")]
	public class SDKPopupTitleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06000850 RID: 2128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x2536A20", Offset = "0x2535620", VA = "0x182536A20")]
		public void SetOptions(SDKPopupTitleView.Options options)
		{
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x25369B0", Offset = "0x25355B0", VA = "0x1825369B0")]
		public void EventOnCloseClicked()
		{
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x2536940", Offset = "0x2535540", VA = "0x182536940")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x2536AD0", Offset = "0x25356D0", VA = "0x182536AD0")]
		public SDKPopupTitleView()
		{
		}

		// Token: 0x04000A97 RID: 2711
		[Token(Token = "0x4000A97")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _btnBack;

		// Token: 0x04000A98 RID: 2712
		[Token(Token = "0x4000A98")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _btnClose;

		// Token: 0x04000A99 RID: 2713
		[Token(Token = "0x4000A99")]
		[FieldOffset(Offset = "0x28")]
		private SDKPopupTitleView.Options m_options;

		// Token: 0x04000A9A RID: 2714
		[Token(Token = "0x4000A9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetOptions;

		// Token: 0x04000A9B RID: 2715
		[Token(Token = "0x4000A9B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnCloseClicked;

		// Token: 0x04000A9C RID: 2716
		[Token(Token = "0x4000A9C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x04000A9D RID: 2717
		[Token(Token = "0x4000A9D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020001DE RID: 478
		[Token(Token = "0x20001DE")]
		public struct Options
		{
			// Token: 0x04000A9E RID: 2718
			[Token(Token = "0x4000A9E")]
			[FieldOffset(Offset = "0x0")]
			public Action onBackClicked;

			// Token: 0x04000A9F RID: 2719
			[Token(Token = "0x4000A9F")]
			[FieldOffset(Offset = "0x8")]
			public Action onCloseClicked;
		}
	}
}
