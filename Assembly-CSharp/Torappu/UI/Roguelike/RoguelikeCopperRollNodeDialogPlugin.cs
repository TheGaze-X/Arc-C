using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005248 RID: 21064
	[Token(Token = "0x2005248")]
	public class RoguelikeCopperRollNodeDialogPlugin : RoguelikeDungeonRollNodeDialogPlugin
	{
		// Token: 0x0601F13D RID: 127293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F13D")]
		[Address(RVA = "0x18C8720", Offset = "0x18C7320", VA = "0x1818C8720", Slot = "4")]
		public override void Render(RoguelikeDungeonRollNodeDialog.Options options)
		{
		}

		// Token: 0x0601F13E RID: 127294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F13E")]
		[Address(RVA = "0x18C8B00", Offset = "0x18C7700", VA = "0x1818C8B00")]
		public RoguelikeCopperRollNodeDialogPlugin()
		{
		}

		// Token: 0x04029AD2 RID: 170706
		[Token(Token = "0x4029AD2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04029AD3 RID: 170707
		[Token(Token = "0x4029AD3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtLeftTime;

		// Token: 0x04029AD4 RID: 170708
		[Token(Token = "0x4029AD4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x04029AD5 RID: 170709
		[Token(Token = "0x4029AD5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _copperItemContent;

		// Token: 0x04029AD6 RID: 170710
		[Token(Token = "0x4029AD6")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeCopperResHolder m_copperResHolder;

		// Token: 0x04029AD7 RID: 170711
		[Token(Token = "0x4029AD7")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeAbstractCopperItemCard m_copperCard;

		// Token: 0x04029AD8 RID: 170712
		[Token(Token = "0x4029AD8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029AD9 RID: 170713
		[Token(Token = "0x4029AD9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
