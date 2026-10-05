using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main11
{
	// Token: 0x02006A2A RID: 27178
	[Token(Token = "0x2006A2A")]
	public class Main11RecordNoteContentView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005BAA RID: 23466
		// (get) Token: 0x06026D8B RID: 159115 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026D8C RID: 159116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BAA")]
		public Main11ZoneRecordController controller
		{
			[Token(Token = "0x6026D8B")]
			[Address(RVA = "0x21F2AE0", Offset = "0x21F16E0", VA = "0x1821F2AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026D8C")]
			[Address(RVA = "0x21F2B60", Offset = "0x21F1760", VA = "0x1821F2B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026D8D RID: 159117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D8D")]
		[Address(RVA = "0x21F0FB0", Offset = "0x21EFBB0", VA = "0x1821F0FB0")]
		public void Render(ZoneRecordViewModel viewModel)
		{
		}

		// Token: 0x06026D8E RID: 159118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D8E")]
		[Address(RVA = "0x21F1D70", Offset = "0x21F0970", VA = "0x1821F1D70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026D8F RID: 159119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D8F")]
		[Address(RVA = "0x21F20D0", Offset = "0x21F0CD0", VA = "0x1821F20D0")]
		private void _SetDiffImg(Image img, string picName)
		{
		}

		// Token: 0x06026D90 RID: 159120 RVA: 0x000CC810 File Offset: 0x000CAA10
		[Token(Token = "0x6026D90")]
		[Address(RVA = "0x21F1920", Offset = "0x21F0520", VA = "0x1821F1920")]
		private Main11RecordNoteContentView.DiffStatusUIStyle _ApplyUIStyleByStatus(ZoneRecordViewModel.ZoneRecordDiffStatus status)
		{
			return default(Main11RecordNoteContentView.DiffStatusUIStyle);
		}

		// Token: 0x06026D91 RID: 159121 RVA: 0x000CC828 File Offset: 0x000CAA28
		[Token(Token = "0x6026D91")]
		[Address(RVA = "0x21F27E0", Offset = "0x21F13E0", VA = "0x1821F27E0")]
		private Main11RecordNoteContentView.DiffStatusUIStyle _TryGetStyleByStatus(ZoneRecordViewModel.ZoneRecordDiffStatus status)
		{
			return default(Main11RecordNoteContentView.DiffStatusUIStyle);
		}

		// Token: 0x06026D92 RID: 159122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D92")]
		[Address(RVA = "0x21F1ED0", Offset = "0x21F0AD0", VA = "0x1821F1ED0")]
		private void _ResetEnterTween()
		{
		}

		// Token: 0x06026D93 RID: 159123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D93")]
		[Address(RVA = "0x21F21C0", Offset = "0x21F0DC0", VA = "0x1821F21C0")]
		private void _ShowContentEnterTween()
		{
		}

		// Token: 0x06026D94 RID: 159124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D94")]
		[Address(RVA = "0x21F1FE0", Offset = "0x21F0BE0", VA = "0x1821F1FE0")]
		private void _ResetTypingTxtMask()
		{
		}

		// Token: 0x06026D95 RID: 159125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D95")]
		[Address(RVA = "0x21F2740", Offset = "0x21F1340", VA = "0x1821F2740")]
		private void _ShowToughDetail(bool show)
		{
		}

		// Token: 0x06026D96 RID: 159126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D96")]
		[Address(RVA = "0x21F1870", Offset = "0x21F0470", VA = "0x1821F1870")]
		public void ResetContentViewBeforeClose()
		{
		}

		// Token: 0x06026D97 RID: 159127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D97")]
		[Address(RVA = "0x21F0EB0", Offset = "0x21EFAB0", VA = "0x1821F0EB0")]
		public void EventOnToughDetailClick()
		{
		}

		// Token: 0x06026D98 RID: 159128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D98")]
		[Address(RVA = "0x21F0F30", Offset = "0x21EFB30", VA = "0x1821F0F30")]
		public void EventOnToughDetailUnselect()
		{
		}

		// Token: 0x06026D99 RID: 159129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D99")]
		[Address(RVA = "0x21F2A10", Offset = "0x21F1610", VA = "0x1821F2A10")]
		public Main11RecordNoteContentView()
		{
		}

		// Token: 0x04036E89 RID: 224905
		[Token(Token = "0x4036E89")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Main11RecordNoteContentView.DiffStatusUIStyle> _styles;

		// Token: 0x04036E8A RID: 224906
		[Token(Token = "0x4036E8A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objUnlockTipsPart;

		// Token: 0x04036E8B RID: 224907
		[Token(Token = "0x4036E8B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _transUnlockTipsPart;

		// Token: 0x04036E8C RID: 224908
		[Token(Token = "0x4036E8C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objTitlePart;

		// Token: 0x04036E8D RID: 224909
		[Token(Token = "0x4036E8D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _transTitlePart;

		// Token: 0x04036E8E RID: 224910
		[Token(Token = "0x4036E8E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objSplitLinePart;

		// Token: 0x04036E8F RID: 224911
		[Token(Token = "0x4036E8F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objTxtPart;

		// Token: 0x04036E90 RID: 224912
		[Token(Token = "0x4036E90")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objEasyPart;

		// Token: 0x04036E91 RID: 224913
		[Token(Token = "0x4036E91")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _transEasyPart;

		// Token: 0x04036E92 RID: 224914
		[Token(Token = "0x4036E92")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objToughPart;

		// Token: 0x04036E93 RID: 224915
		[Token(Token = "0x4036E93")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _transToughPart;

		// Token: 0x04036E94 RID: 224916
		[Token(Token = "0x4036E94")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objToughSelectPart;

		// Token: 0x04036E95 RID: 224917
		[Token(Token = "0x4036E95")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _objHardPart;

		// Token: 0x04036E96 RID: 224918
		[Token(Token = "0x4036E96")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _transHardPart;

		// Token: 0x04036E97 RID: 224919
		[Token(Token = "0x4036E97")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Main11RecordNoteUnlockTipsItemView _noteUnlockTipsItemPrefab;

		// Token: 0x04036E98 RID: 224920
		[Token(Token = "0x4036E98")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _txtTitle1;

		// Token: 0x04036E99 RID: 224921
		[Token(Token = "0x4036E99")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _txtTitle2;

		// Token: 0x04036E9A RID: 224922
		[Token(Token = "0x4036E9A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _transTypingMask;

		// Token: 0x04036E9B RID: 224923
		[Token(Token = "0x4036E9B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _imgEasy;

		// Token: 0x04036E9C RID: 224924
		[Token(Token = "0x4036E9C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Image _imgTough;

		// Token: 0x04036E9D RID: 224925
		[Token(Token = "0x4036E9D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _txtTips;

		// Token: 0x04036E9E RID: 224926
		[Token(Token = "0x4036E9E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _txtContent;

		// Token: 0x04036E9F RID: 224927
		[Token(Token = "0x4036E9F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Image _imgHard;

		// Token: 0x04036EA0 RID: 224928
		[Token(Token = "0x4036EA0")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAnimationLocation _toughSelectAnim;

		// Token: 0x04036EA1 RID: 224929
		[Token(Token = "0x4036EA1")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private ScrollRect _scrollRectTxtContent;

		// Token: 0x04036EA2 RID: 224930
		[Token(Token = "0x4036EA2")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private CanvasGroup _canvasGroupTitlePart;

		// Token: 0x04036EA3 RID: 224931
		[Token(Token = "0x4036EA3")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private CanvasGroup _canvasGroupUnlockTipsPart;

		// Token: 0x04036EA4 RID: 224932
		[Token(Token = "0x4036EA4")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private CanvasGroup _canvasGroupEasyPart;

		// Token: 0x04036EA5 RID: 224933
		[Token(Token = "0x4036EA5")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private CanvasGroup _canvasGroupToughPart;

		// Token: 0x04036EA6 RID: 224934
		[Token(Token = "0x4036EA6")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private CanvasGroup _canvasGroupHardPart;

		// Token: 0x04036EA7 RID: 224935
		[Token(Token = "0x4036EA7")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private CanvasGroup _canvasGroupSplitPart;

		// Token: 0x04036EA9 RID: 224937
		[Token(Token = "0x4036EA9")]
		[FieldOffset(Offset = "0x120")]
		private bool m_hasInited;

		// Token: 0x04036EAA RID: 224938
		[Token(Token = "0x4036EAA")]
		[FieldOffset(Offset = "0x128")]
		private string m_cachedRecordId;

		// Token: 0x04036EAB RID: 224939
		[Token(Token = "0x4036EAB")]
		[FieldOffset(Offset = "0x130")]
		private Main11RecordNoteUnlockTipsItemView m_noteUnlockTipsItem;

		// Token: 0x04036EAC RID: 224940
		[Token(Token = "0x4036EAC")]
		[FieldOffset(Offset = "0x138")]
		private UISwitchTween.TweenWrapper m_enterShowTween;

		// Token: 0x04036EAD RID: 224941
		[Token(Token = "0x4036EAD")]
		[FieldOffset(Offset = "0x140")]
		private Main11RecordNoteContentView.DiffStatusUIStyle m_style;

		// Token: 0x04036EAE RID: 224942
		[Token(Token = "0x4036EAE")]
		[FieldOffset(Offset = "0x180")]
		private AnimationSwitchTween m_toughSelectSwitchTween;

		// Token: 0x04036EAF RID: 224943
		[Token(Token = "0x4036EAF")]
		private const float TITLE_SHOW_DELAY = 0.05f;

		// Token: 0x04036EB0 RID: 224944
		[Token(Token = "0x4036EB0")]
		private const float TITLE_SHOW_DUR = 0.16f;

		// Token: 0x04036EB1 RID: 224945
		[Token(Token = "0x4036EB1")]
		private const float PIC_PART_SHOW_DUR = 0.2f;

		// Token: 0x04036EB2 RID: 224946
		[Token(Token = "0x4036EB2")]
		private const float DOWN_PART_SHOW_DELAY = 0.02f;

		// Token: 0x04036EB3 RID: 224947
		[Token(Token = "0x4036EB3")]
		private const float TYPING_TXT_SHOW_DUR = 0.8f;

		// Token: 0x04036EB4 RID: 224948
		[Token(Token = "0x4036EB4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 TYPING_INIT_SIZE;

		// Token: 0x04036EB5 RID: 224949
		[Token(Token = "0x4036EB5")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 TYPING_FINAL_SIZE;

		// Token: 0x04036EB6 RID: 224950
		[Token(Token = "0x4036EB6")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Main11RecordNoteContentView.DiffStatusUIStyle DEFAULT_STYLE;

		// Token: 0x04036EB7 RID: 224951
		[Token(Token = "0x4036EB7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04036EB8 RID: 224952
		[Token(Token = "0x4036EB8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04036EB9 RID: 224953
		[Token(Token = "0x4036EB9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036EBA RID: 224954
		[Token(Token = "0x4036EBA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036EBB RID: 224955
		[Token(Token = "0x4036EBB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SetDiffImg;

		// Token: 0x04036EBC RID: 224956
		[Token(Token = "0x4036EBC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ApplyUIStyleByStatus;

		// Token: 0x04036EBD RID: 224957
		[Token(Token = "0x4036EBD")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TryGetStyleByStatus;

		// Token: 0x04036EBE RID: 224958
		[Token(Token = "0x4036EBE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ResetEnterTween;

		// Token: 0x04036EBF RID: 224959
		[Token(Token = "0x4036EBF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ShowContentEnterTween;

		// Token: 0x04036EC0 RID: 224960
		[Token(Token = "0x4036EC0")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ResetTypingTxtMask;

		// Token: 0x04036EC1 RID: 224961
		[Token(Token = "0x4036EC1")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ShowToughDetail;

		// Token: 0x04036EC2 RID: 224962
		[Token(Token = "0x4036EC2")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_ResetContentViewBeforeClose;

		// Token: 0x04036EC3 RID: 224963
		[Token(Token = "0x4036EC3")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnToughDetailClick;

		// Token: 0x04036EC4 RID: 224964
		[Token(Token = "0x4036EC4")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_EventOnToughDetailUnselect;

		// Token: 0x04036EC5 RID: 224965
		[Token(Token = "0x4036EC5")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A2B RID: 27179
		[Token(Token = "0x2006A2B")]
		[Serializable]
		public struct DiffStatusUIStyle
		{
			// Token: 0x04036EC6 RID: 224966
			[Token(Token = "0x4036EC6")]
			[FieldOffset(Offset = "0x0")]
			public ZoneRecordViewModel.ZoneRecordDiffStatus status;

			// Token: 0x04036EC7 RID: 224967
			[Token(Token = "0x4036EC7")]
			[FieldOffset(Offset = "0x4")]
			public bool showUnlockTipsPart;

			// Token: 0x04036EC8 RID: 224968
			[Token(Token = "0x4036EC8")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 posUnlockTips;

			// Token: 0x04036EC9 RID: 224969
			[Token(Token = "0x4036EC9")]
			[FieldOffset(Offset = "0x10")]
			public bool showTitlePart;

			// Token: 0x04036ECA RID: 224970
			[Token(Token = "0x4036ECA")]
			[FieldOffset(Offset = "0x14")]
			public Vector2 posTitlePart;

			// Token: 0x04036ECB RID: 224971
			[Token(Token = "0x4036ECB")]
			[FieldOffset(Offset = "0x1C")]
			public bool showSplitLine;

			// Token: 0x04036ECC RID: 224972
			[Token(Token = "0x4036ECC")]
			[FieldOffset(Offset = "0x1D")]
			public bool showEasyPart;

			// Token: 0x04036ECD RID: 224973
			[Token(Token = "0x4036ECD")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 posEasyPart;

			// Token: 0x04036ECE RID: 224974
			[Token(Token = "0x4036ECE")]
			[FieldOffset(Offset = "0x28")]
			public bool showTxtPart;

			// Token: 0x04036ECF RID: 224975
			[Token(Token = "0x4036ECF")]
			[FieldOffset(Offset = "0x29")]
			public bool showToughPart;

			// Token: 0x04036ED0 RID: 224976
			[Token(Token = "0x4036ED0")]
			[FieldOffset(Offset = "0x2C")]
			public Vector2 posToughPart;

			// Token: 0x04036ED1 RID: 224977
			[Token(Token = "0x4036ED1")]
			[FieldOffset(Offset = "0x34")]
			public bool showHardPart;

			// Token: 0x04036ED2 RID: 224978
			[Token(Token = "0x4036ED2")]
			[FieldOffset(Offset = "0x38")]
			public Vector2 posHardPart;
		}
	}
}
