using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055BF RID: 21951
	[Token(Token = "0x20055BF")]
	public class RL05GainCopperDialogItem : RoguelikeCustomizableItemIcon
	{
		// Token: 0x17004B8A RID: 19338
		// (get) Token: 0x0602038F RID: 131983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B8A")]
		public override Graphic graphic
		{
			[Token(Token = "0x602038F")]
			[Address(RVA = "0x1A55140", Offset = "0x1A53D40", VA = "0x181A55140", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020390 RID: 131984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020390")]
		[Address(RVA = "0x1A54EF0", Offset = "0x1A53AF0", VA = "0x181A54EF0", Slot = "5")]
		public override void Render(string topicId, string itemId, RoguelikeGameItemType itemType)
		{
		}

		// Token: 0x06020391 RID: 131985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020391")]
		[Address(RVA = "0x1A550E0", Offset = "0x1A53CE0", VA = "0x181A550E0")]
		public RL05GainCopperDialogItem()
		{
		}

		// Token: 0x0402B972 RID: 178546
		[Token(Token = "0x402B972")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402B973 RID: 178547
		[Token(Token = "0x402B973")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0402B974 RID: 178548
		[Token(Token = "0x402B974")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _gildIcon;

		// Token: 0x0402B975 RID: 178549
		[Token(Token = "0x402B975")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _luckyTypeIcon;

		// Token: 0x0402B976 RID: 178550
		[Token(Token = "0x402B976")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0402B977 RID: 178551
		[Token(Token = "0x402B977")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B978 RID: 178552
		[Token(Token = "0x402B978")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
