using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200569B RID: 22171
	[Token(Token = "0x200569B")]
	public class RL04ItemIconWithFragment : RoguelikeCustomizableItemIcon
	{
		// Token: 0x17004C34 RID: 19508
		// (get) Token: 0x06020858 RID: 133208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C34")]
		public override Graphic graphic
		{
			[Token(Token = "0x6020858")]
			[Address(RVA = "0x1AB25B0", Offset = "0x1AB11B0", VA = "0x181AB25B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020859 RID: 133209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020859")]
		[Address(RVA = "0x1AB22F0", Offset = "0x1AB0EF0", VA = "0x181AB22F0")]
		private RL04FragmentItemCard _EnsureFragmentItem()
		{
			return null;
		}

		// Token: 0x0602085A RID: 133210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602085A")]
		[Address(RVA = "0x1AB1F70", Offset = "0x1AB0B70", VA = "0x181AB1F70", Slot = "5")]
		public override void Render(string topicId, string itemId, RoguelikeGameItemType itemType)
		{
		}

		// Token: 0x0602085B RID: 133211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602085B")]
		[Address(RVA = "0x1AB2540", Offset = "0x1AB1140", VA = "0x181AB2540")]
		public RL04ItemIconWithFragment()
		{
		}

		// Token: 0x0402C11E RID: 180510
		[Token(Token = "0x402C11E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _itemIconImage;

		// Token: 0x0402C11F RID: 180511
		[Token(Token = "0x402C11F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RL04FragmentItemCard _fragmentItemPrefab;

		// Token: 0x0402C120 RID: 180512
		[Token(Token = "0x402C120")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402C121 RID: 180513
		[Token(Token = "0x402C121")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _fragmentItemScale;

		// Token: 0x0402C122 RID: 180514
		[Token(Token = "0x402C122")]
		[FieldOffset(Offset = "0x58")]
		private RL04FragmentItemCard m_fragmentItem;

		// Token: 0x0402C123 RID: 180515
		[Token(Token = "0x402C123")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0402C124 RID: 180516
		[Token(Token = "0x402C124")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureFragmentItem;

		// Token: 0x0402C125 RID: 180517
		[Token(Token = "0x402C125")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C126 RID: 180518
		[Token(Token = "0x402C126")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
