using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005EB4 RID: 24244
	[Token(Token = "0x2005EB4")]
	public class ItemRepoSelectCharView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060231B6 RID: 143798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231B6")]
		[Address(RVA = "0x1DA0010", Offset = "0x1D9EC10", VA = "0x181DA0010")]
		public void InitData(List<ItemBundle> itemList, bool clickable = true)
		{
		}

		// Token: 0x060231B7 RID: 143799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231B7")]
		[Address(RVA = "0x1DA0220", Offset = "0x1D9EE20", VA = "0x181DA0220")]
		public ItemRepoSelectCharView()
		{
		}

		// Token: 0x04030638 RID: 198200
		[Token(Token = "0x4030638")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _backAdapter;

		// Token: 0x04030639 RID: 198201
		[Token(Token = "0x4030639")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _forwardAdapter;

		// Token: 0x0403063A RID: 198202
		[Token(Token = "0x403063A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStringEvent _itemEvent;

		// Token: 0x0403063B RID: 198203
		[Token(Token = "0x403063B")]
		[FieldOffset(Offset = "0x30")]
		private ItemRepoSelectCharBackAdapter m_backAdapter;

		// Token: 0x0403063C RID: 198204
		[Token(Token = "0x403063C")]
		[FieldOffset(Offset = "0x38")]
		private ItemRepoSelectCharBackAdapter m_forwardAdapter;

		// Token: 0x0403063D RID: 198205
		[Token(Token = "0x403063D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403063E RID: 198206
		[Token(Token = "0x403063E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
