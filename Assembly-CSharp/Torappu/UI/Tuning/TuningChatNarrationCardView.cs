using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C73 RID: 15475
	[Token(Token = "0x2003C73")]
	public class TuningChatNarrationCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060182B8 RID: 99000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182B8")]
		[Address(RVA = "0x10A9550", Offset = "0x10A8150", VA = "0x1810A9550")]
		public void Render(TuningChatBagItemViewModel viewModel, bool isOpenBag)
		{
		}

		// Token: 0x060182B9 RID: 99001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182B9")]
		[Address(RVA = "0x10A9B70", Offset = "0x10A8770", VA = "0x1810A9B70")]
		private void _PlayAnim()
		{
		}

		// Token: 0x060182BA RID: 99002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182BA")]
		[Address(RVA = "0x10A98B0", Offset = "0x10A84B0", VA = "0x1810A98B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060182BB RID: 99003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182BB")]
		[Address(RVA = "0x10A9C60", Offset = "0x10A8860", VA = "0x1810A9C60")]
		public TuningChatNarrationCardView()
		{
		}

		// Token: 0x0401D66B RID: 120427
		[Token(Token = "0x401D66B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _title;

		// Token: 0x0401D66C RID: 120428
		[Token(Token = "0x401D66C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _formDesc;

		// Token: 0x0401D66D RID: 120429
		[Token(Token = "0x401D66D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _orcheDesc;

		// Token: 0x0401D66E RID: 120430
		[Token(Token = "0x401D66E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _hiddenDesc;

		// Token: 0x0401D66F RID: 120431
		[Token(Token = "0x401D66F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text[] _formDecos;

		// Token: 0x0401D670 RID: 120432
		[Token(Token = "0x401D670")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x0401D671 RID: 120433
		[Token(Token = "0x401D671")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelHidden;

		// Token: 0x0401D672 RID: 120434
		[Token(Token = "0x401D672")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _panelCard;

		// Token: 0x0401D673 RID: 120435
		[Token(Token = "0x401D673")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TuningCommonCard _cardViewPrefab;

		// Token: 0x0401D674 RID: 120436
		[Token(Token = "0x401D674")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _cardContainer;

		// Token: 0x0401D675 RID: 120437
		[Token(Token = "0x401D675")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _cardScale;

		// Token: 0x0401D676 RID: 120438
		[Token(Token = "0x401D676")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _cardAnim;

		// Token: 0x0401D677 RID: 120439
		[Token(Token = "0x401D677")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0401D678 RID: 120440
		[Token(Token = "0x401D678")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedProductId;

		// Token: 0x0401D679 RID: 120441
		[Token(Token = "0x401D679")]
		[FieldOffset(Offset = "0x90")]
		private FadeSwitchTween m_cardSwitchTween;

		// Token: 0x0401D67A RID: 120442
		[Token(Token = "0x401D67A")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_animTween;

		// Token: 0x0401D67B RID: 120443
		[Token(Token = "0x401D67B")]
		[FieldOffset(Offset = "0xA0")]
		private TuningCommonCard m_cardView;

		// Token: 0x0401D67C RID: 120444
		[Token(Token = "0x401D67C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D67D RID: 120445
		[Token(Token = "0x401D67D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0401D67E RID: 120446
		[Token(Token = "0x401D67E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D67F RID: 120447
		[Token(Token = "0x401D67F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
