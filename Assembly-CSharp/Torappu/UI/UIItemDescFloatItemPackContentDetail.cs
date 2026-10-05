using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003737 RID: 14135
	[Token(Token = "0x2003737")]
	public class UIItemDescFloatItemPackContentDetail : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601674C RID: 91980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601674C")]
		[Address(RVA = "0xEE65D0", Offset = "0xEE51D0", VA = "0x180EE65D0")]
		public void Render(string itemName, int itemQuantity)
		{
		}

		// Token: 0x0601674D RID: 91981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601674D")]
		[Address(RVA = "0xEE6720", Offset = "0xEE5320", VA = "0x180EE6720")]
		public UIItemDescFloatItemPackContentDetail()
		{
		}

		// Token: 0x0401B08A RID: 110730
		[Token(Token = "0x401B08A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _itemNameText;

		// Token: 0x0401B08B RID: 110731
		[Token(Token = "0x401B08B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemQuantityText;

		// Token: 0x0401B08C RID: 110732
		[Token(Token = "0x401B08C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401B08D RID: 110733
		[Token(Token = "0x401B08D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
