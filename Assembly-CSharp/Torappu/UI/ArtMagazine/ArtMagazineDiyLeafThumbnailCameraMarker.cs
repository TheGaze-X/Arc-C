using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006554 RID: 25940
	[Token(Token = "0x2006554")]
	public class ArtMagazineDiyLeafThumbnailCameraMarker : MonoBehaviour, IPageCameraMarker, IPageComponentMarker, IHotfixable
	{
		// Token: 0x060254CB RID: 152779 RVA: 0x000C7668 File Offset: 0x000C5868
		[Token(Token = "0x60254CB")]
		[Address(RVA = "0x204E190", Offset = "0x204CD90", VA = "0x18204E190", Slot = "4")]
		public bool IsCollectable()
		{
			return default(bool);
		}

		// Token: 0x060254CC RID: 152780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254CC")]
		[Address(RVA = "0x204E1F0", Offset = "0x204CDF0", VA = "0x18204E1F0")]
		public ArtMagazineDiyLeafThumbnailCameraMarker()
		{
		}

		// Token: 0x0403455A RID: 214362
		[Token(Token = "0x403455A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsCollectable;

		// Token: 0x0403455B RID: 214363
		[Token(Token = "0x403455B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
