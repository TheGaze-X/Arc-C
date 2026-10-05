using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Common
{
	// Token: 0x02005C27 RID: 23591
	[Token(Token = "0x2005C27")]
	public abstract class UICommonCarouselItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602232D RID: 140077
		[Token(Token = "0x602232D")]
		public abstract float GetWidth();

		// Token: 0x0602232E RID: 140078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602232E")]
		[Address(RVA = "0x1CB5F20", Offset = "0x1CB4B20", VA = "0x181CB5F20")]
		protected UICommonCarouselItem()
		{
		}

		// Token: 0x0402EE92 RID: 192146
		[Token(Token = "0x402EE92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
