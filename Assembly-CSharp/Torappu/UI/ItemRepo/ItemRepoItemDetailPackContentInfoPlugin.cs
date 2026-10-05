using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E90 RID: 24208
	[Token(Token = "0x2005E90")]
	public class ItemRepoItemDetailPackContentInfoPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023136 RID: 143670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023136")]
		[Address(RVA = "0x1D999C0", Offset = "0x1D985C0", VA = "0x181D999C0")]
		public void RenderPlugin(UIItemViewModel itemModel)
		{
		}

		// Token: 0x06023137 RID: 143671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023137")]
		[Address(RVA = "0x1D99A70", Offset = "0x1D98670", VA = "0x181D99A70")]
		public ItemRepoItemDetailPackContentInfoPlugin()
		{
		}

		// Token: 0x040304F5 RID: 197877
		[Token(Token = "0x40304F5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _packInfoContainer;

		// Token: 0x040304F6 RID: 197878
		[Token(Token = "0x40304F6")]
		[FieldOffset(Offset = "0x20")]
		private ItemRepoItemPackContentView m_itemPackContent;

		// Token: 0x040304F7 RID: 197879
		[Token(Token = "0x40304F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderPlugin;

		// Token: 0x040304F8 RID: 197880
		[Token(Token = "0x40304F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
