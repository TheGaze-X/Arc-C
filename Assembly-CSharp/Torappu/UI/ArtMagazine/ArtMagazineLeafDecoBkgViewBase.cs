using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065B6 RID: 26038
	[Token(Token = "0x20065B6")]
	public abstract class ArtMagazineLeafDecoBkgViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x060256B8 RID: 153272
		[Token(Token = "0x60256B8")]
		public abstract void Render(ArtMagazineLeafViewModelBase leafViewModel);

		// Token: 0x060256B9 RID: 153273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256B9")]
		[Address(RVA = "0x2066710", Offset = "0x2065310", VA = "0x182066710")]
		protected ArtMagazineLeafDecoBkgViewBase()
		{
		}

		// Token: 0x04034845 RID: 215109
		[Token(Token = "0x4034845")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
