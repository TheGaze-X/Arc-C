using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C27 RID: 15399
	[Token(Token = "0x2003C27")]
	public class UniEquipLevelUpNormalInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018161 RID: 98657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018161")]
		[Address(RVA = "0x1092540", Offset = "0x1091140", VA = "0x181092540")]
		public void Render(UniEquipNormalInfoViewModel model)
		{
		}

		// Token: 0x06018162 RID: 98658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018162")]
		[Address(RVA = "0x10926D0", Offset = "0x10912D0", VA = "0x1810926D0")]
		public UniEquipLevelUpNormalInfoView()
		{
		}

		// Token: 0x0401D397 RID: 119703
		[Token(Token = "0x401D397")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtTitle;

		// Token: 0x0401D398 RID: 119704
		[Token(Token = "0x401D398")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtContent;

		// Token: 0x0401D399 RID: 119705
		[Token(Token = "0x401D399")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0401D39A RID: 119706
		[Token(Token = "0x401D39A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D39B RID: 119707
		[Token(Token = "0x401D39B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
