using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A16 RID: 23062
	[Token(Token = "0x2005A16")]
	public class CrisisShopLeftProgressView : MonoBehaviour
	{
		// Token: 0x0602198A RID: 137610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602198A")]
		[Address(RVA = "0x1C08DC0", Offset = "0x1C079C0", VA = "0x181C08DC0")]
		public void Render(PlayerGoodProgressData progressInfo, List<CrisisProgressShopItemViewModel> progressViewModelList, CrisisShopVer shopVer)
		{
		}

		// Token: 0x0602198B RID: 137611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602198B")]
		[Address(RVA = "0x1C08FE0", Offset = "0x1C07BE0", VA = "0x181C08FE0")]
		public CrisisShopLeftProgressView()
		{
		}

		// Token: 0x0402DED5 RID: 188117
		[Token(Token = "0x402DED5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CrisisShopLeftProgressItem _activeItem;

		// Token: 0x0402DED6 RID: 188118
		[Token(Token = "0x402DED6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrisisShopLeftProgressItem _unactiveItem;

		// Token: 0x0402DED7 RID: 188119
		[Token(Token = "0x402DED7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0402DED8 RID: 188120
		[Token(Token = "0x402DED8")]
		[FieldOffset(Offset = "0x30")]
		private List<CrisisShopLeftProgressItem> m_viewList;
	}
}
