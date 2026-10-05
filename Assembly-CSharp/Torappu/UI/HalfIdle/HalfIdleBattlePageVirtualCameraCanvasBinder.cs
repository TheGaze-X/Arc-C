using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x02006751 RID: 26449
	[Token(Token = "0x2006751")]
	public class HalfIdleBattlePageVirtualCameraCanvasBinder : MonoBehaviour, IPageCameraMarker, IPageComponentMarker, IHotfixable
	{
		// Token: 0x170059D4 RID: 22996
		// (get) Token: 0x06025F4D RID: 155469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059D4")]
		public UIPageVirtualCamCanvasBinder binder
		{
			[Token(Token = "0x6025F4D")]
			[Address(RVA = "0x20F1340", Offset = "0x20EFF40", VA = "0x1820F1340")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025F4E RID: 155470 RVA: 0x000C9900 File Offset: 0x000C7B00
		[Token(Token = "0x6025F4E")]
		[Address(RVA = "0x20F1280", Offset = "0x20EFE80", VA = "0x1820F1280", Slot = "4")]
		public bool IsCollectable()
		{
			return default(bool);
		}

		// Token: 0x06025F4F RID: 155471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F4F")]
		[Address(RVA = "0x20F12E0", Offset = "0x20EFEE0", VA = "0x1820F12E0")]
		public HalfIdleBattlePageVirtualCameraCanvasBinder()
		{
		}

		// Token: 0x0403563C RID: 218684
		[Token(Token = "0x403563C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIPageVirtualCamCanvasBinder _binder;

		// Token: 0x0403563D RID: 218685
		[Token(Token = "0x403563D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_binder;

		// Token: 0x0403563E RID: 218686
		[Token(Token = "0x403563E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsCollectable;

		// Token: 0x0403563F RID: 218687
		[Token(Token = "0x403563F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
