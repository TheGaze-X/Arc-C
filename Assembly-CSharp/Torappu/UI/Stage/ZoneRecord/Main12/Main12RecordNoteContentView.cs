using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main12
{
	// Token: 0x02006A0F RID: 27151
	[Token(Token = "0x2006A0F")]
	public class Main12RecordNoteContentView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B9E RID: 23454
		// (get) Token: 0x06026D0D RID: 158989 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026D0E RID: 158990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B9E")]
		public Main12ZoneRecordController controller
		{
			[Token(Token = "0x6026D0D")]
			[Address(RVA = "0x21D5AA0", Offset = "0x21D46A0", VA = "0x1821D5AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026D0E")]
			[Address(RVA = "0x21D5B20", Offset = "0x21D4720", VA = "0x1821D5B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026D0F RID: 158991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D0F")]
		[Address(RVA = "0x21D3EB0", Offset = "0x21D2AB0", VA = "0x1821D3EB0")]
		public void Render(ZoneRecordViewModel viewModel)
		{
		}

		// Token: 0x06026D10 RID: 158992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D10")]
		[Address(RVA = "0x21D4D30", Offset = "0x21D3930", VA = "0x1821D4D30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026D11 RID: 158993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D11")]
		[Address(RVA = "0x21D5090", Offset = "0x21D3C90", VA = "0x1821D5090")]
		private void _SetDiffImg(Image img, string picName)
		{
		}

		// Token: 0x06026D12 RID: 158994 RVA: 0x000CC720 File Offset: 0x000CA920
		[Token(Token = "0x6026D12")]
		[Address(RVA = "0x21D48E0", Offset = "0x21D34E0", VA = "0x1821D48E0")]
		private Main12RecordNoteContentView.DiffStatusUIStyle _ApplyUIStyleByStatus(ZoneRecordViewModel.ZoneRecordDiffStatus status)
		{
			return default(Main12RecordNoteContentView.DiffStatusUIStyle);
		}

		// Token: 0x06026D13 RID: 158995 RVA: 0x000CC738 File Offset: 0x000CA938
		[Token(Token = "0x6026D13")]
		[Address(RVA = "0x21D57A0", Offset = "0x21D43A0", VA = "0x1821D57A0")]
		private Main12RecordNoteContentView.DiffStatusUIStyle _TryGetStyleByStatus(ZoneRecordViewModel.ZoneRecordDiffStatus status)
		{
			return default(Main12RecordNoteContentView.DiffStatusUIStyle);
		}

		// Token: 0x06026D14 RID: 158996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D14")]
		[Address(RVA = "0x21D4E90", Offset = "0x21D3A90", VA = "0x1821D4E90")]
		private void _ResetEnterTween()
		{
		}

		// Token: 0x06026D15 RID: 158997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D15")]
		[Address(RVA = "0x21D5180", Offset = "0x21D3D80", VA = "0x1821D5180")]
		private void _ShowContentEnterTween()
		{
		}

		// Token: 0x06026D16 RID: 158998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D16")]
		[Address(RVA = "0x21D4FA0", Offset = "0x21D3BA0", VA = "0x1821D4FA0")]
		private void _ResetTypingTxtMask()
		{
		}

		// Token: 0x06026D17 RID: 158999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D17")]
		[Address(RVA = "0x21D5700", Offset = "0x21D4300", VA = "0x1821D5700")]
		private void _ShowToughDetail(bool show)
		{
		}

		// Token: 0x06026D18 RID: 159000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D18")]
		[Address(RVA = "0x21D47D0", Offset = "0x21D33D0", VA = "0x1821D47D0")]
		public void ResetContentViewBeforeClose()
		{
		}

		// Token: 0x06026D19 RID: 159001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D19")]
		[Address(RVA = "0x21D3DB0", Offset = "0x21D29B0", VA = "0x1821D3DB0")]
		public void EventOnToughDetailClick()
		{
		}

		// Token: 0x06026D1A RID: 159002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D1A")]
		[Address(RVA = "0x21D3E30", Offset = "0x21D2A30", VA = "0x1821D3E30")]
		public void EventOnToughDetailUnselect()
		{
		}

		// Token: 0x06026D1B RID: 159003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D1B")]
		[Address(RVA = "0x21D59D0", Offset = "0x21D45D0", VA = "0x1821D59D0")]
		public Main12RecordNoteContentView()
		{
		}

		// Token: 0x04036D66 RID: 224614
		[Token(Token = "0x4036D66")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Main12RecordNoteContentView.DiffStatusUIStyle> _styles;

		// Token: 0x04036D67 RID: 224615
		[Token(Token = "0x4036D67")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objUnlockTipsPart;

		// Token: 0x04036D68 RID: 224616
		[Token(Token = "0x4036D68")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _transUnlockTipsPart;

		// Token: 0x04036D69 RID: 224617
		[Token(Token = "0x4036D69")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objTitlePart;

		// Token: 0x04036D6A RID: 224618
		[Token(Token = "0x4036D6A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _transTitlePart;

		// Token: 0x04036D6B RID: 224619
		[Token(Token = "0x4036D6B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objSplitLinePart;

		// Token: 0x04036D6C RID: 224620
		[Token(Token = "0x4036D6C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objTxtPart;

		// Token: 0x04036D6D RID: 224621
		[Token(Token = "0x4036D6D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objEasyPart;

		// Token: 0x04036D6E RID: 224622
		[Token(Token = "0x4036D6E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _transEasyPart;

		// Token: 0x04036D6F RID: 224623
		[Token(Token = "0x4036D6F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objToughPart;

		// Token: 0x04036D70 RID: 224624
		[Token(Token = "0x4036D70")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _transToughPart;

		// Token: 0x04036D71 RID: 224625
		[Token(Token = "0x4036D71")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objToughSelectPart;

		// Token: 0x04036D72 RID: 224626
		[Token(Token = "0x4036D72")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _objHardPart;

		// Token: 0x04036D73 RID: 224627
		[Token(Token = "0x4036D73")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _transHardPart;

		// Token: 0x04036D74 RID: 224628
		[Token(Token = "0x4036D74")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Main12RecordNoteUnlockTipsItemView _noteUnlockTipsItemPrefab;

		// Token: 0x04036D75 RID: 224629
		[Token(Token = "0x4036D75")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _txtTitle1;

		// Token: 0x04036D76 RID: 224630
		[Token(Token = "0x4036D76")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _txtTitle2;

		// Token: 0x04036D77 RID: 224631
		[Token(Token = "0x4036D77")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _transTypingMask;

		// Token: 0x04036D78 RID: 224632
		[Token(Token = "0x4036D78")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _imgEasy;

		// Token: 0x04036D79 RID: 224633
		[Token(Token = "0x4036D79")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Image _imgTough;

		// Token: 0x04036D7A RID: 224634
		[Token(Token = "0x4036D7A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _txtTips;

		// Token: 0x04036D7B RID: 224635
		[Token(Token = "0x4036D7B")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _txtContent;

		// Token: 0x04036D7C RID: 224636
		[Token(Token = "0x4036D7C")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Image _imgHard;

		// Token: 0x04036D7D RID: 224637
		[Token(Token = "0x4036D7D")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAnimationLocation _toughSelectAnim;

		// Token: 0x04036D7E RID: 224638
		[Token(Token = "0x4036D7E")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private ScrollRect _scrollRectTxtContent;

		// Token: 0x04036D7F RID: 224639
		[Token(Token = "0x4036D7F")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private CanvasGroup _canvasGroupTitlePart;

		// Token: 0x04036D80 RID: 224640
		[Token(Token = "0x4036D80")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private CanvasGroup _canvasGroupUnlockTipsPart;

		// Token: 0x04036D81 RID: 224641
		[Token(Token = "0x4036D81")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private CanvasGroup _canvasGroupEasyPart;

		// Token: 0x04036D82 RID: 224642
		[Token(Token = "0x4036D82")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private CanvasGroup _canvasGroupToughPart;

		// Token: 0x04036D83 RID: 224643
		[Token(Token = "0x4036D83")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private CanvasGroup _canvasGroupHardPart;

		// Token: 0x04036D84 RID: 224644
		[Token(Token = "0x4036D84")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private CanvasGroup _canvasGroupSplitPart;

		// Token: 0x04036D86 RID: 224646
		[Token(Token = "0x4036D86")]
		[FieldOffset(Offset = "0x120")]
		private bool m_hasInited;

		// Token: 0x04036D87 RID: 224647
		[Token(Token = "0x4036D87")]
		[FieldOffset(Offset = "0x128")]
		private string m_cachedRecordId;

		// Token: 0x04036D88 RID: 224648
		[Token(Token = "0x4036D88")]
		[FieldOffset(Offset = "0x130")]
		private Main12RecordNoteUnlockTipsItemView m_noteUnlockTipsItem;

		// Token: 0x04036D89 RID: 224649
		[Token(Token = "0x4036D89")]
		[FieldOffset(Offset = "0x138")]
		private UISwitchTween.TweenWrapper m_enterShowTween;

		// Token: 0x04036D8A RID: 224650
		[Token(Token = "0x4036D8A")]
		[FieldOffset(Offset = "0x140")]
		private Main12RecordNoteContentView.DiffStatusUIStyle m_style;

		// Token: 0x04036D8B RID: 224651
		[Token(Token = "0x4036D8B")]
		[FieldOffset(Offset = "0x180")]
		private AnimationSwitchTween m_toughSelectSwitchTween;

		// Token: 0x04036D8C RID: 224652
		[Token(Token = "0x4036D8C")]
		private const float TITLE_SHOW_DELAY = 0.05f;

		// Token: 0x04036D8D RID: 224653
		[Token(Token = "0x4036D8D")]
		private const float TITLE_SHOW_DUR = 0.16f;

		// Token: 0x04036D8E RID: 224654
		[Token(Token = "0x4036D8E")]
		private const float PIC_PART_SHOW_DUR = 0.2f;

		// Token: 0x04036D8F RID: 224655
		[Token(Token = "0x4036D8F")]
		private const float DOWN_PART_SHOW_DELAY = 0.02f;

		// Token: 0x04036D90 RID: 224656
		[Token(Token = "0x4036D90")]
		private const float TYPING_TXT_SHOW_DUR = 0.8f;

		// Token: 0x04036D91 RID: 224657
		[Token(Token = "0x4036D91")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 TYPING_INIT_SIZE;

		// Token: 0x04036D92 RID: 224658
		[Token(Token = "0x4036D92")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 TYPING_FINAL_SIZE;

		// Token: 0x04036D93 RID: 224659
		[Token(Token = "0x4036D93")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Main12RecordNoteContentView.DiffStatusUIStyle DEFAULT_STYLE;

		// Token: 0x04036D94 RID: 224660
		[Token(Token = "0x4036D94")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04036D95 RID: 224661
		[Token(Token = "0x4036D95")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04036D96 RID: 224662
		[Token(Token = "0x4036D96")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036D97 RID: 224663
		[Token(Token = "0x4036D97")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036D98 RID: 224664
		[Token(Token = "0x4036D98")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SetDiffImg;

		// Token: 0x04036D99 RID: 224665
		[Token(Token = "0x4036D99")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ApplyUIStyleByStatus;

		// Token: 0x04036D9A RID: 224666
		[Token(Token = "0x4036D9A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TryGetStyleByStatus;

		// Token: 0x04036D9B RID: 224667
		[Token(Token = "0x4036D9B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ResetEnterTween;

		// Token: 0x04036D9C RID: 224668
		[Token(Token = "0x4036D9C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ShowContentEnterTween;

		// Token: 0x04036D9D RID: 224669
		[Token(Token = "0x4036D9D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ResetTypingTxtMask;

		// Token: 0x04036D9E RID: 224670
		[Token(Token = "0x4036D9E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ShowToughDetail;

		// Token: 0x04036D9F RID: 224671
		[Token(Token = "0x4036D9F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_ResetContentViewBeforeClose;

		// Token: 0x04036DA0 RID: 224672
		[Token(Token = "0x4036DA0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnToughDetailClick;

		// Token: 0x04036DA1 RID: 224673
		[Token(Token = "0x4036DA1")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_EventOnToughDetailUnselect;

		// Token: 0x04036DA2 RID: 224674
		[Token(Token = "0x4036DA2")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A10 RID: 27152
		[Token(Token = "0x2006A10")]
		[Serializable]
		public struct DiffStatusUIStyle
		{
			// Token: 0x04036DA3 RID: 224675
			[Token(Token = "0x4036DA3")]
			[FieldOffset(Offset = "0x0")]
			public ZoneRecordViewModel.ZoneRecordDiffStatus status;

			// Token: 0x04036DA4 RID: 224676
			[Token(Token = "0x4036DA4")]
			[FieldOffset(Offset = "0x4")]
			public bool showUnlockTipsPart;

			// Token: 0x04036DA5 RID: 224677
			[Token(Token = "0x4036DA5")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 posUnlockTips;

			// Token: 0x04036DA6 RID: 224678
			[Token(Token = "0x4036DA6")]
			[FieldOffset(Offset = "0x10")]
			public bool showTitlePart;

			// Token: 0x04036DA7 RID: 224679
			[Token(Token = "0x4036DA7")]
			[FieldOffset(Offset = "0x14")]
			public Vector2 posTitlePart;

			// Token: 0x04036DA8 RID: 224680
			[Token(Token = "0x4036DA8")]
			[FieldOffset(Offset = "0x1C")]
			public bool showSplitLine;

			// Token: 0x04036DA9 RID: 224681
			[Token(Token = "0x4036DA9")]
			[FieldOffset(Offset = "0x1D")]
			public bool showEasyPart;

			// Token: 0x04036DAA RID: 224682
			[Token(Token = "0x4036DAA")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 posEasyPart;

			// Token: 0x04036DAB RID: 224683
			[Token(Token = "0x4036DAB")]
			[FieldOffset(Offset = "0x28")]
			public bool showTxtPart;

			// Token: 0x04036DAC RID: 224684
			[Token(Token = "0x4036DAC")]
			[FieldOffset(Offset = "0x29")]
			public bool showToughPart;

			// Token: 0x04036DAD RID: 224685
			[Token(Token = "0x4036DAD")]
			[FieldOffset(Offset = "0x2C")]
			public Vector2 posToughPart;

			// Token: 0x04036DAE RID: 224686
			[Token(Token = "0x4036DAE")]
			[FieldOffset(Offset = "0x34")]
			public bool showHardPart;

			// Token: 0x04036DAF RID: 224687
			[Token(Token = "0x4036DAF")]
			[FieldOffset(Offset = "0x38")]
			public Vector2 posHardPart;
		}
	}
}
