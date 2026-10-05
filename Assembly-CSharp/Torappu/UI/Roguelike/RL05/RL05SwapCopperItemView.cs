using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055B6 RID: 21942
	[Token(Token = "0x20055B6")]
	public class RL05SwapCopperItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020375 RID: 131957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020375")]
		[Address(RVA = "0x1A5BDC0", Offset = "0x1A5A9C0", VA = "0x181A5BDC0")]
		public void Render(RoguelikePlayerCopperItemViewModel model, bool isSelected)
		{
		}

		// Token: 0x06020376 RID: 131958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020376")]
		[Address(RVA = "0x1A5C100", Offset = "0x1A5AD00", VA = "0x181A5C100")]
		public void SelectCopper()
		{
		}

		// Token: 0x06020377 RID: 131959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020377")]
		[Address(RVA = "0x1A5C1F0", Offset = "0x1A5ADF0", VA = "0x181A5C1F0")]
		public RL05SwapCopperItemView()
		{
		}

		// Token: 0x0402B92B RID: 178475
		[Token(Token = "0x402B92B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _itemCardContent;

		// Token: 0x0402B92C RID: 178476
		[Token(Token = "0x402B92C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _luckyLevelIcon;

		// Token: 0x0402B92D RID: 178477
		[Token(Token = "0x402B92D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402B92E RID: 178478
		[Token(Token = "0x402B92E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402B92F RID: 178479
		[Token(Token = "0x402B92F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _isDrawnObj;

		// Token: 0x0402B930 RID: 178480
		[Token(Token = "0x402B930")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _isSelectedObj;

		// Token: 0x0402B931 RID: 178481
		[Token(Token = "0x402B931")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0402B932 RID: 178482
		[Token(Token = "0x402B932")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402B933 RID: 178483
		[Token(Token = "0x402B933")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeCopperResHolder m_copperResHolder;

		// Token: 0x0402B934 RID: 178484
		[Token(Token = "0x402B934")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedCopperindex;

		// Token: 0x0402B935 RID: 178485
		[Token(Token = "0x402B935")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeAbstractCopperItemCard m_copperItemCard;

		// Token: 0x0402B936 RID: 178486
		[Token(Token = "0x402B936")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B937 RID: 178487
		[Token(Token = "0x402B937")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectCopper;

		// Token: 0x0402B938 RID: 178488
		[Token(Token = "0x402B938")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
