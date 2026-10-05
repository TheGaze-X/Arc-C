using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019AD RID: 6573
	[Token(Token = "0x20019AD")]
	public abstract class DIYFurnitureVerticalListElementView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600A523 RID: 42275 RVA: 0x000400E0 File Offset: 0x0003E2E0
		[Token(Token = "0x600A523")]
		[Address(RVA = "0x31ED2D0", Offset = "0x31EBED0", VA = "0x1831ED2D0")]
		public int GetViewIndex()
		{
			return 0;
		}

		// Token: 0x0600A524 RID: 42276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A524")]
		[Address(RVA = "0x31ED330", Offset = "0x31EBF30", VA = "0x1831ED330")]
		public void SetViewIndex(int index)
		{
		}

		// Token: 0x0600A525 RID: 42277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A525")]
		[Address(RVA = "0x31ED3A0", Offset = "0x31EBFA0", VA = "0x1831ED3A0")]
		protected DIYFurnitureVerticalListElementView()
		{
		}

		// Token: 0x04009C7E RID: 40062
		[Token(Token = "0x4009C7E")]
		[FieldOffset(Offset = "0x18")]
		private int m_viewIndex;

		// Token: 0x04009C7F RID: 40063
		[Token(Token = "0x4009C7F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewIndex;

		// Token: 0x04009C80 RID: 40064
		[Token(Token = "0x4009C80")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetViewIndex;

		// Token: 0x04009C81 RID: 40065
		[Token(Token = "0x4009C81")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
