using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B2C RID: 23340
	[Token(Token = "0x2005B2C")]
	public abstract class ShopRecommendTemplateViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004F40 RID: 20288
		// (get) Token: 0x06021E3C RID: 138812
		[Token(Token = "0x17004F40")]
		public abstract Type templateType { [Token(Token = "0x6021E3C")] get; }

		// Token: 0x06021E3D RID: 138813
		[Token(Token = "0x6021E3D")]
		public abstract void DoRender(ShopRecommendTemplateViewModelBase model);

		// Token: 0x06021E3E RID: 138814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E3E")]
		[Address(RVA = "0x1C6C620", Offset = "0x1C6B220", VA = "0x181C6C620")]
		protected ShopRecommendTemplateViewBase()
		{
		}

		// Token: 0x0402E6F5 RID: 190197
		[Token(Token = "0x402E6F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
