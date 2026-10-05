using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005586 RID: 21894
	[Token(Token = "0x2005586")]
	public class RL05ItemIconWithCopperLuck : RoguelikeCustomizableItemIcon
	{
		// Token: 0x17004B77 RID: 19319
		// (get) Token: 0x060202A6 RID: 131750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B77")]
		public override Graphic graphic
		{
			[Token(Token = "0x60202A6")]
			[Address(RVA = "0x1A55880", Offset = "0x1A54480", VA = "0x181A55880", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060202A7 RID: 131751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202A7")]
		[Address(RVA = "0x1A551A0", Offset = "0x1A53DA0", VA = "0x181A551A0", Slot = "5")]
		public override void Render(string topicId, string itemId, RoguelikeGameItemType itemType)
		{
		}

		// Token: 0x060202A8 RID: 131752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202A8")]
		[Address(RVA = "0x1A55780", Offset = "0x1A54380", VA = "0x181A55780")]
		private void _RenderAsNormal(string itemId)
		{
		}

		// Token: 0x060202A9 RID: 131753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202A9")]
		[Address(RVA = "0x1A554A0", Offset = "0x1A540A0", VA = "0x181A554A0")]
		private void _RenderAsCopper(string topicId, string itemId)
		{
		}

		// Token: 0x060202AA RID: 131754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202AA")]
		[Address(RVA = "0x1A552E0", Offset = "0x1A53EE0", VA = "0x181A552E0")]
		private void _EnsureCopperItemAndResHolder(string topicId)
		{
		}

		// Token: 0x060202AB RID: 131755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202AB")]
		[Address(RVA = "0x1A55820", Offset = "0x1A54420", VA = "0x181A55820")]
		public RL05ItemIconWithCopperLuck()
		{
		}

		// Token: 0x0402B74D RID: 177997
		[Token(Token = "0x402B74D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x0402B74E RID: 177998
		[Token(Token = "0x402B74E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _copperPanel;

		// Token: 0x0402B74F RID: 177999
		[Token(Token = "0x402B74F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _itemIconImage;

		// Token: 0x0402B750 RID: 178000
		[Token(Token = "0x402B750")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RL05CopperItemView _copperIconPrefab;

		// Token: 0x0402B751 RID: 178001
		[Token(Token = "0x402B751")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _copperIconHolder;

		// Token: 0x0402B752 RID: 178002
		[Token(Token = "0x402B752")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402B753 RID: 178003
		[Token(Token = "0x402B753")]
		[FieldOffset(Offset = "0x68")]
		private RL05CopperItemView m_copperIcon;

		// Token: 0x0402B754 RID: 178004
		[Token(Token = "0x402B754")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeCopperResHolder m_copperResHolder;

		// Token: 0x0402B755 RID: 178005
		[Token(Token = "0x402B755")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeGameCopperItemViewModel m_copperModel;

		// Token: 0x0402B756 RID: 178006
		[Token(Token = "0x402B756")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0402B757 RID: 178007
		[Token(Token = "0x402B757")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B758 RID: 178008
		[Token(Token = "0x402B758")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderAsNormal;

		// Token: 0x0402B759 RID: 178009
		[Token(Token = "0x402B759")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderAsCopper;

		// Token: 0x0402B75A RID: 178010
		[Token(Token = "0x402B75A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EnsureCopperItemAndResHolder;

		// Token: 0x0402B75B RID: 178011
		[Token(Token = "0x402B75B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
