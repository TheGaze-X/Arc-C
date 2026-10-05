using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CC9 RID: 15561
	[Token(Token = "0x2003CC9")]
	public class TuningPlayMenuView : DataBinder<TuningPlayProperty>
	{
		// Token: 0x06018426 RID: 99366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018426")]
		[Address(RVA = "0x10C3A20", Offset = "0x10C2620", VA = "0x1810C3A20", Slot = "7")]
		public override void OnValueChanged(TuningPlayProperty property)
		{
		}

		// Token: 0x06018427 RID: 99367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018427")]
		[Address(RVA = "0x10C3BE0", Offset = "0x10C27E0", VA = "0x1810C3BE0")]
		private void _RenderCard(TuningPlayViewModel model)
		{
		}

		// Token: 0x06018428 RID: 99368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018428")]
		[Address(RVA = "0x10C3910", Offset = "0x10C2510", VA = "0x1810C3910")]
		public void OnClickOpenOrche()
		{
		}

		// Token: 0x06018429 RID: 99369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018429")]
		[Address(RVA = "0x10C3880", Offset = "0x10C2480", VA = "0x1810C3880")]
		public void OnClickCloseOrche()
		{
		}

		// Token: 0x0601842A RID: 99370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601842A")]
		[Address(RVA = "0x10C39A0", Offset = "0x10C25A0", VA = "0x1810C39A0")]
		public void OnClickTransToMusicHandbookState()
		{
		}

		// Token: 0x0601842B RID: 99371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601842B")]
		[Address(RVA = "0x10C4060", Offset = "0x10C2C60", VA = "0x1810C4060")]
		public TuningPlayMenuView()
		{
		}

		// Token: 0x0401D978 RID: 121208
		[Token(Token = "0x401D978")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TuningProductSlotGroupItemView _openOrcheBtnGroupItemView;

		// Token: 0x0401D979 RID: 121209
		[Token(Token = "0x401D979")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TuningProductSlotGroupItemView _closeOrcheBtnGroupItemView;

		// Token: 0x0401D97A RID: 121210
		[Token(Token = "0x401D97A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _hasNewProductTypeObj;

		// Token: 0x0401D97B RID: 121211
		[Token(Token = "0x401D97B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _productTypeText;

		// Token: 0x0401D97C RID: 121212
		[Token(Token = "0x401D97C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Card")]
		private Transform _cardHolder;

		// Token: 0x0401D97D RID: 121213
		[Token(Token = "0x401D97D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Card")]
		private TuningCommonCard _commonCardPrefab;

		// Token: 0x0401D97E RID: 121214
		[Token(Token = "0x401D97E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Card")]
		private float _cardScaler;

		// Token: 0x0401D97F RID: 121215
		[Token(Token = "0x401D97F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Card")]
		private CanvasGroup _cardGroup;

		// Token: 0x0401D980 RID: 121216
		[Token(Token = "0x401D980")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Card")]
		private float _showAlpha;

		// Token: 0x0401D981 RID: 121217
		[Token(Token = "0x401D981")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		[Group("Card")]
		private float _hideAlpha;

		// Token: 0x0401D982 RID: 121218
		[Token(Token = "0x401D982")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Card")]
		private float _cardTweenDuration;

		// Token: 0x0401D983 RID: 121219
		[Token(Token = "0x401D983")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D984 RID: 121220
		[Token(Token = "0x401D984")]
		[FieldOffset(Offset = "0x80")]
		private TuningCommonCard m_commonCard;

		// Token: 0x0401D985 RID: 121221
		[Token(Token = "0x401D985")]
		[FieldOffset(Offset = "0x88")]
		private Sequence m_cardSequence;

		// Token: 0x0401D986 RID: 121222
		[Token(Token = "0x401D986")]
		[FieldOffset(Offset = "0x90")]
		private int m_cachedCardChangeSequenceNum;

		// Token: 0x0401D987 RID: 121223
		[Token(Token = "0x401D987")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D988 RID: 121224
		[Token(Token = "0x401D988")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderCard;

		// Token: 0x0401D989 RID: 121225
		[Token(Token = "0x401D989")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickOpenOrche;

		// Token: 0x0401D98A RID: 121226
		[Token(Token = "0x401D98A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickCloseOrche;

		// Token: 0x0401D98B RID: 121227
		[Token(Token = "0x401D98B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickTransToMusicHandbookState;

		// Token: 0x0401D98C RID: 121228
		[Token(Token = "0x401D98C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
