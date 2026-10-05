using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068F9 RID: 26873
	[Token(Token = "0x20068F9")]
	public class StageUseApItemObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x060267F7 RID: 157687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267F7")]
		[Address(RVA = "0x21A20F0", Offset = "0x21A0CF0", VA = "0x1821A20F0")]
		private void _InitItem()
		{
		}

		// Token: 0x060267F8 RID: 157688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267F8")]
		[Address(RVA = "0x21A1F50", Offset = "0x21A0B50", VA = "0x1821A1F50")]
		public void RenderItem(UIItemViewModel itemInfo, bool selected, Action<int> clickEvent, int position)
		{
		}

		// Token: 0x060267F9 RID: 157689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267F9")]
		[Address(RVA = "0x21A22D0", Offset = "0x21A0ED0", VA = "0x1821A22D0")]
		public StageUseApItemObj()
		{
		}

		// Token: 0x040363E1 RID: 222177
		[Token(Token = "0x40363E1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIItemCard _itemCard;

		// Token: 0x040363E2 RID: 222178
		[Token(Token = "0x40363E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040363E3 RID: 222179
		[Token(Token = "0x40363E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _chosenIcon;

		// Token: 0x040363E4 RID: 222180
		[Token(Token = "0x40363E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _scaleFactor;

		// Token: 0x040363E5 RID: 222181
		[Token(Token = "0x40363E5")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action<int> refreshTime;

		// Token: 0x040363E6 RID: 222182
		[Token(Token = "0x40363E6")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x040363E7 RID: 222183
		[Token(Token = "0x40363E7")]
		[FieldOffset(Offset = "0x48")]
		private UIItemCard m_itemCard;

		// Token: 0x040363E8 RID: 222184
		[Token(Token = "0x40363E8")]
		[FieldOffset(Offset = "0x0")]
		private static Color ADDITIVE_COLOR;

		// Token: 0x040363E9 RID: 222185
		[Token(Token = "0x40363E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitItem;

		// Token: 0x040363EA RID: 222186
		[Token(Token = "0x40363EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderItem;

		// Token: 0x040363EB RID: 222187
		[Token(Token = "0x40363EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
