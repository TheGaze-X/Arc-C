using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003643 RID: 13891
	[Token(Token = "0x2003643")]
	public class UIPageVirtualCamera : IHotfixable
	{
		// Token: 0x060161C0 RID: 90560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161C0")]
		[Address(RVA = "0xEA6340", Offset = "0xEA4F40", VA = "0x180EA6340")]
		public UIPageVirtualCamera(UIPageVirtualCamType cameraType)
		{
		}

		// Token: 0x060161C1 RID: 90561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161C1")]
		[Address(RVA = "0xEA5E70", Offset = "0xEA4A70", VA = "0x180EA5E70")]
		public void AttachCamera(UIPageCameraProvider provider)
		{
		}

		// Token: 0x060161C2 RID: 90562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161C2")]
		[Address(RVA = "0xEA6140", Offset = "0xEA4D40", VA = "0x180EA6140")]
		public void DetachCamera()
		{
		}

		// Token: 0x060161C3 RID: 90563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161C3")]
		[Address(RVA = "0xEA5FF0", Offset = "0xEA4BF0", VA = "0x180EA5FF0")]
		public void Bind(IPageVirtualCamBinder binder)
		{
		}

		// Token: 0x0401A962 RID: 108898
		[Token(Token = "0x401A962")]
		[FieldOffset(Offset = "0x10")]
		private UIPageVirtualCamType m_cameraType;

		// Token: 0x0401A963 RID: 108899
		[Token(Token = "0x401A963")]
		[FieldOffset(Offset = "0x18")]
		private CameraWrapper m_cameraWrapper;

		// Token: 0x0401A964 RID: 108900
		[Token(Token = "0x401A964")]
		[FieldOffset(Offset = "0x20")]
		private List<IPageVirtualCamBinder> m_binders;

		// Token: 0x0401A965 RID: 108901
		[Token(Token = "0x401A965")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401A966 RID: 108902
		[Token(Token = "0x401A966")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AttachCamera;

		// Token: 0x0401A967 RID: 108903
		[Token(Token = "0x401A967")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DetachCamera;

		// Token: 0x0401A968 RID: 108904
		[Token(Token = "0x401A968")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Bind;
	}
}
