using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066A1 RID: 26273
	[Token(Token = "0x20066A1")]
	public class HandBookScrollView : DataBinder<HandBookScrollViewProperty>
	{
		// Token: 0x06025BD3 RID: 154579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BD3")]
		[Address(RVA = "0x20B0370", Offset = "0x20AEF70", VA = "0x1820B0370")]
		public void CleanEffect()
		{
		}

		// Token: 0x06025BD4 RID: 154580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BD4")]
		[Address(RVA = "0x20B0540", Offset = "0x20AF140", VA = "0x1820B0540")]
		public void HideEffect()
		{
		}

		// Token: 0x06025BD5 RID: 154581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BD5")]
		[Address(RVA = "0x20B1520", Offset = "0x20B0120", VA = "0x1820B1520")]
		public void ReloadCard(HandBookCardViewModel cardViewModel)
		{
		}

		// Token: 0x06025BD6 RID: 154582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BD6")]
		[Address(RVA = "0x20B16C0", Offset = "0x20B02C0", VA = "0x1820B16C0")]
		private void _ChangePos(HandBookCardView view, bool lastSelected)
		{
		}

		// Token: 0x06025BD7 RID: 154583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025BD7")]
		[Address(RVA = "0x20AEAE0", Offset = "0x20AD6E0", VA = "0x1820AEAE0")]
		private IEnumerator AnimatorController(HandBookScrollViewProperty property, bool lastSelected)
		{
			return null;
		}

		// Token: 0x06025BD8 RID: 154584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BD8")]
		[Address(RVA = "0x20B1960", Offset = "0x20B0560", VA = "0x1820B1960")]
		private void _MoveContentAfterSecond(Vector3 secondPos, float time)
		{
		}

		// Token: 0x06025BD9 RID: 154585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BD9")]
		[Address(RVA = "0x20B08D0", Offset = "0x20AF4D0", VA = "0x1820B08D0")]
		public void OnChildFocus(string charID)
		{
		}

		// Token: 0x06025BDA RID: 154586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BDA")]
		[Address(RVA = "0x20B06E0", Offset = "0x20AF2E0", VA = "0x1820B06E0")]
		public void OnChildClick(string charID, HandBookCardView child)
		{
		}

		// Token: 0x06025BDB RID: 154587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BDB")]
		[Address(RVA = "0x20B0290", Offset = "0x20AEE90", VA = "0x1820B0290")]
		public void CancelClick()
		{
		}

		// Token: 0x06025BDC RID: 154588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BDC")]
		[Address(RVA = "0x20AEBD0", Offset = "0x20AD7D0", VA = "0x1820AEBD0")]
		public void ApplyData()
		{
		}

		// Token: 0x06025BDD RID: 154589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BDD")]
		[Address(RVA = "0x20B0B40", Offset = "0x20AF740", VA = "0x1820B0B40", Slot = "7")]
		public override void OnValueChanged(HandBookScrollViewProperty property)
		{
		}

		// Token: 0x06025BDE RID: 154590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BDE")]
		[Address(RVA = "0x20B1A10", Offset = "0x20B0610", VA = "0x1820B1A10")]
		public HandBookScrollView()
		{
		}

		// Token: 0x040350A0 RID: 217248
		[Token(Token = "0x40350A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIWrappedScrollRect _scrollView;

		// Token: 0x040350A1 RID: 217249
		[Token(Token = "0x40350A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _contentPanel;

		// Token: 0x040350A2 RID: 217250
		[Token(Token = "0x40350A2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected HandBookCommonLineRender[] _linePrefab;

		// Token: 0x040350A3 RID: 217251
		[Token(Token = "0x40350A3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Transform _lineContainer;

		// Token: 0x040350A4 RID: 217252
		[Token(Token = "0x40350A4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Transform _cardContainer;

		// Token: 0x040350A5 RID: 217253
		[Token(Token = "0x40350A5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _sixLineContainer;

		// Token: 0x040350A6 RID: 217254
		[Token(Token = "0x40350A6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _teamContainer;

		// Token: 0x040350A7 RID: 217255
		[Token(Token = "0x40350A7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private HandBookCommonStateBean _stateBean;

		// Token: 0x040350A8 RID: 217256
		[Token(Token = "0x40350A8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected HandBookCardView _handbookCommonCard;

		// Token: 0x040350A9 RID: 217257
		[Token(Token = "0x40350A9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _contentRect;

		// Token: 0x040350AA RID: 217258
		[Token(Token = "0x40350AA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _openButton;

		// Token: 0x040350AB RID: 217259
		[Token(Token = "0x40350AB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _backButton;

		// Token: 0x040350AC RID: 217260
		[Token(Token = "0x40350AC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected HandbookSixLineView _sixLine;

		// Token: 0x040350AD RID: 217261
		[Token(Token = "0x40350AD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _teamImage;

		// Token: 0x040350AE RID: 217262
		[Token(Token = "0x40350AE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UnityEvent _onCheck;

		// Token: 0x040350AF RID: 217263
		[Token(Token = "0x40350AF")]
		[FieldOffset(Offset = "0x98")]
		private List<HandBookTeamView> m_teamViews;

		// Token: 0x040350B0 RID: 217264
		[Token(Token = "0x40350B0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected HandBookTeamView _teamView;

		// Token: 0x040350B1 RID: 217265
		[Token(Token = "0x40350B1")]
		[FieldOffset(Offset = "0xA8")]
		private List<HandBookCardView> m_handbookCards;

		// Token: 0x040350B2 RID: 217266
		[Token(Token = "0x40350B2")]
		[FieldOffset(Offset = "0xB0")]
		private List<HandbookSixLineView> m_sixLineViews;

		// Token: 0x040350B3 RID: 217267
		[Token(Token = "0x40350B3")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<X_Y, string> m_handbookSixLists;

		// Token: 0x040350B4 RID: 217268
		[Token(Token = "0x40350B4")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 m_initPos;

		// Token: 0x040350B5 RID: 217269
		[Token(Token = "0x40350B5")]
		[FieldOffset(Offset = "0xCC")]
		private Vector2 m_initSize;

		// Token: 0x040350B6 RID: 217270
		[Token(Token = "0x40350B6")]
		[FieldOffset(Offset = "0xD8")]
		private Dictionary<int, HandBookCommonLineRender> m_lines;

		// Token: 0x040350B7 RID: 217271
		[Token(Token = "0x40350B7")]
		[FieldOffset(Offset = "0xE0")]
		private float m_cacheScale;

		// Token: 0x040350B8 RID: 217272
		[Token(Token = "0x40350B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CleanEffect;

		// Token: 0x040350B9 RID: 217273
		[Token(Token = "0x40350B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x040350BA RID: 217274
		[Token(Token = "0x40350BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ReloadCard;

		// Token: 0x040350BB RID: 217275
		[Token(Token = "0x40350BB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ChangePos;

		// Token: 0x040350BC RID: 217276
		[Token(Token = "0x40350BC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AnimatorController;

		// Token: 0x040350BD RID: 217277
		[Token(Token = "0x40350BD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__MoveContentAfterSecond;

		// Token: 0x040350BE RID: 217278
		[Token(Token = "0x40350BE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnChildFocus;

		// Token: 0x040350BF RID: 217279
		[Token(Token = "0x40350BF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnChildClick;

		// Token: 0x040350C0 RID: 217280
		[Token(Token = "0x40350C0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CancelClick;

		// Token: 0x040350C1 RID: 217281
		[Token(Token = "0x40350C1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x040350C2 RID: 217282
		[Token(Token = "0x40350C2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040350C3 RID: 217283
		[Token(Token = "0x40350C3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
