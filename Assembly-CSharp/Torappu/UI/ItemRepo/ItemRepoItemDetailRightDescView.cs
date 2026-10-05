using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E91 RID: 24209
	[Token(Token = "0x2005E91")]
	public class ItemRepoItemDetailRightDescView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023138 RID: 143672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023138")]
		[Address(RVA = "0x1D99AD0", Offset = "0x1D986D0", VA = "0x181D99AD0")]
		public void Render(UIItemViewModel itemViewModel)
		{
		}

		// Token: 0x06023139 RID: 143673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023139")]
		[Address(RVA = "0x1D99BD0", Offset = "0x1D987D0", VA = "0x181D99BD0")]
		public ItemRepoItemDetailRightDescView()
		{
		}

		// Token: 0x040304F9 RID: 197881
		[Token(Token = "0x40304F9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _description;

		// Token: 0x040304FA RID: 197882
		[Token(Token = "0x40304FA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _usage;

		// Token: 0x040304FB RID: 197883
		[Token(Token = "0x40304FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040304FC RID: 197884
		[Token(Token = "0x40304FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
