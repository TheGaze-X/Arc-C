using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200408D RID: 16525
	[Token(Token = "0x200408D")]
	public class SandboxV2CookFoodListItemView : SandboxV2AdminMainListItemViewBase
	{
		// Token: 0x06019905 RID: 104709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019905")]
		[Address(RVA = "0x1254DD0", Offset = "0x12539D0", VA = "0x181254DD0")]
		public void Render(int position, SandboxV2CookFoodListItemModel model)
		{
		}

		// Token: 0x06019906 RID: 104710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019906")]
		[Address(RVA = "0x1254F30", Offset = "0x1253B30", VA = "0x181254F30")]
		public SandboxV2CookFoodListItemView()
		{
		}

		// Token: 0x0401FE6A RID: 130666
		[Token(Token = "0x401FE6A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _attributeIconImage;

		// Token: 0x0401FE6B RID: 130667
		[Token(Token = "0x401FE6B")]
		[FieldOffset(Offset = "0x98")]
		private UIStateFinder m_finder;

		// Token: 0x0401FE6C RID: 130668
		[Token(Token = "0x401FE6C")]
		[FieldOffset(Offset = "0xA8")]
		private SandboxV2FoodAttribute m_cachedAttribute;

		// Token: 0x0401FE6D RID: 130669
		[Token(Token = "0x401FE6D")]
		[FieldOffset(Offset = "0xAC")]
		private bool m_hasRenderedBefore;

		// Token: 0x0401FE6E RID: 130670
		[Token(Token = "0x401FE6E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401FE6F RID: 130671
		[Token(Token = "0x401FE6F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
