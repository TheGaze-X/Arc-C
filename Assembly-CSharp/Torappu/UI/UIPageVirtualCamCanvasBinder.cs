using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003641 RID: 13889
	[Token(Token = "0x2003641")]
	[Serializable]
	public class UIPageVirtualCamCanvasBinder : IPageVirtualCamBinder, IHotfixable
	{
		// Token: 0x060161B9 RID: 90553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161B9")]
		[Address(RVA = "0xEA5BE0", Offset = "0xEA47E0", VA = "0x180EA5BE0", Slot = "4")]
		public void BindCamera(CameraWrapper cameraWrapper)
		{
		}

		// Token: 0x060161BA RID: 90554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161BA")]
		[Address(RVA = "0xEA5D50", Offset = "0xEA4950", VA = "0x180EA5D50", Slot = "5")]
		public void UnBindCamera()
		{
		}

		// Token: 0x060161BB RID: 90555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161BB")]
		[Address(RVA = "0xEA5E10", Offset = "0xEA4A10", VA = "0x180EA5E10")]
		public UIPageVirtualCamCanvasBinder()
		{
		}

		// Token: 0x0401A958 RID: 108888
		[Token(Token = "0x401A958")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Canvas _canvas;

		// Token: 0x0401A959 RID: 108889
		[Token(Token = "0x401A959")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BindCamera;

		// Token: 0x0401A95A RID: 108890
		[Token(Token = "0x401A95A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UnBindCamera;

		// Token: 0x0401A95B RID: 108891
		[Token(Token = "0x401A95B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
