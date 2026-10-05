using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200584F RID: 22607
	[Token(Token = "0x200584F")]
	public class RL03GoodsObjTotemIconView : RoguelikeGoodsObjIconView
	{
		// Token: 0x06021060 RID: 135264 RVA: 0x000B8350 File Offset: 0x000B6550
		[Token(Token = "0x6021060")]
		[Address(RVA = "0x1B5CBC0", Offset = "0x1B5B7C0", VA = "0x181B5CBC0", Slot = "5")]
		public override bool NeedShowPlugin(RoguelikeGoodsViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06021061 RID: 135265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021061")]
		[Address(RVA = "0x1B5CC50", Offset = "0x1B5B850", VA = "0x181B5CC50", Slot = "6")]
		public override void Render(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x06021062 RID: 135266 RVA: 0x000B8368 File Offset: 0x000B6568
		[Token(Token = "0x6021062")]
		[Address(RVA = "0x1B5D030", Offset = "0x1B5BC30", VA = "0x181B5D030")]
		private bool _IsTotem(RoguelikeGameItemType type)
		{
			return default(bool);
		}

		// Token: 0x06021063 RID: 135267 RVA: 0x000B8380 File Offset: 0x000B6580
		[Token(Token = "0x6021063")]
		[Address(RVA = "0x1B5CF50", Offset = "0x1B5BB50", VA = "0x181B5CF50")]
		private bool _IsItemChange(string topicId, string itemId)
		{
			return default(bool);
		}

		// Token: 0x06021064 RID: 135268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021064")]
		[Address(RVA = "0x1B5D0A0", Offset = "0x1B5BCA0", VA = "0x181B5D0A0")]
		public RL03GoodsObjTotemIconView()
		{
		}

		// Token: 0x0402CEA8 RID: 183976
		[Token(Token = "0x402CEA8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _rectTotemItemContainer;

		// Token: 0x0402CEA9 RID: 183977
		[Token(Token = "0x402CEA9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL03TotemItemView _totemItemPrefab;

		// Token: 0x0402CEAA RID: 183978
		[Token(Token = "0x402CEAA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0402CEAB RID: 183979
		[Token(Token = "0x402CEAB")]
		[FieldOffset(Offset = "0x30")]
		private RL03TotemItemView m_totemItem;

		// Token: 0x0402CEAC RID: 183980
		[Token(Token = "0x402CEAC")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_finder;

		// Token: 0x0402CEAD RID: 183981
		[Token(Token = "0x402CEAD")]
		[FieldOffset(Offset = "0x48")]
		private string m_topicId;

		// Token: 0x0402CEAE RID: 183982
		[Token(Token = "0x402CEAE")]
		[FieldOffset(Offset = "0x50")]
		private string m_itemId;

		// Token: 0x0402CEAF RID: 183983
		[Token(Token = "0x402CEAF")]
		[FieldOffset(Offset = "0x58")]
		private RL03TotemViewModel m_totemViewModel;

		// Token: 0x0402CEB0 RID: 183984
		[Token(Token = "0x402CEB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NeedShowPlugin;

		// Token: 0x0402CEB1 RID: 183985
		[Token(Token = "0x402CEB1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CEB2 RID: 183986
		[Token(Token = "0x402CEB2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__IsTotem;

		// Token: 0x0402CEB3 RID: 183987
		[Token(Token = "0x402CEB3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__IsItemChange;

		// Token: 0x0402CEB4 RID: 183988
		[Token(Token = "0x402CEB4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
