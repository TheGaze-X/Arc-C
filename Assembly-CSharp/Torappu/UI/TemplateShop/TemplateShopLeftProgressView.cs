using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D5C RID: 15708
	[Token(Token = "0x2003D5C")]
	public class TemplateShopLeftProgressView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018770 RID: 100208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018770")]
		[Address(RVA = "0x10F5670", Offset = "0x10F4270", VA = "0x1810F5670")]
		public void Render(PlayerGoodProgressData progressInfo, List<TemplateShopData.ProgessGoodItem> progressViewModelList)
		{
		}

		// Token: 0x06018771 RID: 100209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018771")]
		[Address(RVA = "0x10F58E0", Offset = "0x10F44E0", VA = "0x1810F58E0")]
		public TemplateShopLeftProgressView()
		{
		}

		// Token: 0x0401DF5E RID: 122718
		[Token(Token = "0x401DF5E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TemplateShopLeftProgressItem _activeItem;

		// Token: 0x0401DF5F RID: 122719
		[Token(Token = "0x401DF5F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TemplateShopLeftProgressItem _unactiveItem;

		// Token: 0x0401DF60 RID: 122720
		[Token(Token = "0x401DF60")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0401DF61 RID: 122721
		[Token(Token = "0x401DF61")]
		[FieldOffset(Offset = "0x30")]
		private List<TemplateShopLeftProgressItem> m_viewList;

		// Token: 0x0401DF62 RID: 122722
		[Token(Token = "0x401DF62")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DF63 RID: 122723
		[Token(Token = "0x401DF63")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
