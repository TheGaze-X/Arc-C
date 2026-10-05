using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005585 RID: 21893
	[Token(Token = "0x2005585")]
	public class RL05ItemIconWithCopper : RoguelikeCustomizableItemIcon
	{
		// Token: 0x17004B76 RID: 19318
		// (get) Token: 0x060202A2 RID: 131746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B76")]
		public override Graphic graphic
		{
			[Token(Token = "0x60202A2")]
			[Address(RVA = "0x1A55D90", Offset = "0x1A54990", VA = "0x181A55D90", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060202A3 RID: 131747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60202A3")]
		[Address(RVA = "0x1A55BD0", Offset = "0x1A547D0", VA = "0x181A55BD0")]
		private RL05CopperItemView _EnsureCopperItem()
		{
			return null;
		}

		// Token: 0x060202A4 RID: 131748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202A4")]
		[Address(RVA = "0x1A558E0", Offset = "0x1A544E0", VA = "0x181A558E0", Slot = "5")]
		public override void Render(string topicId, string itemId, RoguelikeGameItemType itemType)
		{
		}

		// Token: 0x060202A5 RID: 131749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202A5")]
		[Address(RVA = "0x1A55D30", Offset = "0x1A54930", VA = "0x181A55D30")]
		public RL05ItemIconWithCopper()
		{
		}

		// Token: 0x0402B745 RID: 177989
		[Token(Token = "0x402B745")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _itemIconImage;

		// Token: 0x0402B746 RID: 177990
		[Token(Token = "0x402B746")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RL05CopperItemView _copperItemPrefab;

		// Token: 0x0402B747 RID: 177991
		[Token(Token = "0x402B747")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402B748 RID: 177992
		[Token(Token = "0x402B748")]
		[FieldOffset(Offset = "0x50")]
		private RL05CopperItemView m_copperItem;

		// Token: 0x0402B749 RID: 177993
		[Token(Token = "0x402B749")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0402B74A RID: 177994
		[Token(Token = "0x402B74A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureCopperItem;

		// Token: 0x0402B74B RID: 177995
		[Token(Token = "0x402B74B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B74C RID: 177996
		[Token(Token = "0x402B74C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
