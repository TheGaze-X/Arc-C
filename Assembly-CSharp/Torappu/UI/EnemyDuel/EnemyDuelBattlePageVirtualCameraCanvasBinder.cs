using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FFA RID: 20474
	[Token(Token = "0x2004FFA")]
	public class EnemyDuelBattlePageVirtualCameraCanvasBinder : MonoBehaviour, IPageCameraMarker, IPageComponentMarker, IHotfixable
	{
		// Token: 0x17004705 RID: 18181
		// (get) Token: 0x0601E63F RID: 124479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004705")]
		public UIPageVirtualCamCanvasBinder binder
		{
			[Token(Token = "0x601E63F")]
			[Address(RVA = "0x1811690", Offset = "0x1810290", VA = "0x181811690")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E640 RID: 124480 RVA: 0x000AE588 File Offset: 0x000AC788
		[Token(Token = "0x601E640")]
		[Address(RVA = "0x18115D0", Offset = "0x18101D0", VA = "0x1818115D0", Slot = "4")]
		public bool IsCollectable()
		{
			return default(bool);
		}

		// Token: 0x0601E641 RID: 124481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E641")]
		[Address(RVA = "0x1811630", Offset = "0x1810230", VA = "0x181811630")]
		public EnemyDuelBattlePageVirtualCameraCanvasBinder()
		{
		}

		// Token: 0x04028A12 RID: 166418
		[Token(Token = "0x4028A12")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIPageVirtualCamCanvasBinder _binder;

		// Token: 0x04028A13 RID: 166419
		[Token(Token = "0x4028A13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_binder;

		// Token: 0x04028A14 RID: 166420
		[Token(Token = "0x4028A14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsCollectable;

		// Token: 0x04028A15 RID: 166421
		[Token(Token = "0x4028A15")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
