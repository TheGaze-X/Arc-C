using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003642 RID: 13890
	[Token(Token = "0x2003642")]
	public class UIPageVirtualCamBlurCompBinder : IPageVirtualCamBinder, IHotfixable
	{
		// Token: 0x060161BC RID: 90556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161BC")]
		[Address(RVA = "0xEA5B10", Offset = "0xEA4710", VA = "0x180EA5B10")]
		public UIPageVirtualCamBlurCompBinder(RectTransform dialogContainer)
		{
		}

		// Token: 0x060161BD RID: 90557 RVA: 0x0008F718 File Offset: 0x0008D918
		[Token(Token = "0x60161BD")]
		[Address(RVA = "0xEA59D0", Offset = "0xEA45D0", VA = "0x180EA59D0")]
		public UICompDialogMgr.MgrBuilder GetCompDlgMgrBuilder()
		{
			return default(UICompDialogMgr.MgrBuilder);
		}

		// Token: 0x060161BE RID: 90558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161BE")]
		[Address(RVA = "0xEA5950", Offset = "0xEA4550", VA = "0x180EA5950", Slot = "4")]
		public void BindCamera(CameraWrapper camera)
		{
		}

		// Token: 0x060161BF RID: 90559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161BF")]
		[Address(RVA = "0xEA5A70", Offset = "0xEA4670", VA = "0x180EA5A70", Slot = "5")]
		public void UnBindCamera()
		{
		}

		// Token: 0x0401A95C RID: 108892
		[Token(Token = "0x401A95C")]
		[FieldOffset(Offset = "0x10")]
		private RectTransform m_container;

		// Token: 0x0401A95D RID: 108893
		[Token(Token = "0x401A95D")]
		[FieldOffset(Offset = "0x18")]
		private List<Camera> m_blurOnlyCameras;

		// Token: 0x0401A95E RID: 108894
		[Token(Token = "0x401A95E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401A95F RID: 108895
		[Token(Token = "0x401A95F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCompDlgMgrBuilder;

		// Token: 0x0401A960 RID: 108896
		[Token(Token = "0x401A960")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BindCamera;

		// Token: 0x0401A961 RID: 108897
		[Token(Token = "0x401A961")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UnBindCamera;
	}
}
