using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200581E RID: 22558
	[Token(Token = "0x200581E")]
	public class RL03ItemIconWithTotem : RoguelikeCustomizableItemIcon
	{
		// Token: 0x17004D5D RID: 19805
		// (get) Token: 0x06020F61 RID: 135009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D5D")]
		public override Graphic graphic
		{
			[Token(Token = "0x6020F61")]
			[Address(RVA = "0x1B48EC0", Offset = "0x1B47AC0", VA = "0x181B48EC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020F62 RID: 135010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F62")]
		[Address(RVA = "0x1B48CE0", Offset = "0x1B478E0", VA = "0x181B48CE0")]
		private RL03TotemItemView _EnsureTotemIcon()
		{
			return null;
		}

		// Token: 0x06020F63 RID: 135011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F63")]
		[Address(RVA = "0x1B489E0", Offset = "0x1B475E0", VA = "0x181B489E0", Slot = "5")]
		public override void Render(string topicId, string itemId, RoguelikeGameItemType itemType)
		{
		}

		// Token: 0x06020F64 RID: 135012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F64")]
		[Address(RVA = "0x1B48E60", Offset = "0x1B47A60", VA = "0x181B48E60")]
		public RL03ItemIconWithTotem()
		{
		}

		// Token: 0x0402CD1E RID: 183582
		[Token(Token = "0x402CD1E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _itemIconImage;

		// Token: 0x0402CD1F RID: 183583
		[Token(Token = "0x402CD1F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RL03TotemItemView _totemIconPrefab;

		// Token: 0x0402CD20 RID: 183584
		[Token(Token = "0x402CD20")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402CD21 RID: 183585
		[Token(Token = "0x402CD21")]
		[FieldOffset(Offset = "0x50")]
		private RL03TotemItemView m_totemIcon;

		// Token: 0x0402CD22 RID: 183586
		[Token(Token = "0x402CD22")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0402CD23 RID: 183587
		[Token(Token = "0x402CD23")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureTotemIcon;

		// Token: 0x0402CD24 RID: 183588
		[Token(Token = "0x402CD24")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CD25 RID: 183589
		[Token(Token = "0x402CD25")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
