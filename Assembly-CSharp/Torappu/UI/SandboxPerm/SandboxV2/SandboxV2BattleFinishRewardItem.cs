using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004111 RID: 16657
	[Token(Token = "0x2004111")]
	public class SandboxV2BattleFinishRewardItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019BFA RID: 105466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BFA")]
		[Address(RVA = "0x12961D0", Offset = "0x1294DD0", VA = "0x1812961D0")]
		public void Render(int index, UIItemViewModel itemViewModel)
		{
		}

		// Token: 0x06019BFB RID: 105467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BFB")]
		[Address(RVA = "0x1296410", Offset = "0x1295010", VA = "0x181296410")]
		private void _EventOnItemClick(int itemIndex)
		{
		}

		// Token: 0x06019BFC RID: 105468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BFC")]
		[Address(RVA = "0x12964F0", Offset = "0x12950F0", VA = "0x1812964F0")]
		public SandboxV2BattleFinishRewardItem()
		{
		}

		// Token: 0x0402042A RID: 132138
		[Token(Token = "0x402042A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2ItemCard _itemCard;

		// Token: 0x0402042B RID: 132139
		[Token(Token = "0x402042B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x0402042C RID: 132140
		[Token(Token = "0x402042C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0402042D RID: 132141
		[Token(Token = "0x402042D")]
		[FieldOffset(Offset = "0x30")]
		private SandboxV2ItemCard m_itemCard;

		// Token: 0x0402042E RID: 132142
		[Token(Token = "0x402042E")]
		[FieldOffset(Offset = "0x38")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x0402042F RID: 132143
		[Token(Token = "0x402042F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020430 RID: 132144
		[Token(Token = "0x4020430")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EventOnItemClick;

		// Token: 0x04020431 RID: 132145
		[Token(Token = "0x4020431")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
