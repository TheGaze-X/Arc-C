using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044A3 RID: 17571
	[Token(Token = "0x20044A3")]
	public class RoguelikeTopicBattlePassView : DataBinder<RoguelikeTopicBattlePassProperty>
	{
		// Token: 0x17003FB4 RID: 16308
		// (get) Token: 0x0601AD6B RID: 109931 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AD6C RID: 109932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FB4")]
		public Action<List<string>> getRewardAction
		{
			[Token(Token = "0x601AD6B")]
			[Address(RVA = "0x13FD8D0", Offset = "0x13FC4D0", VA = "0x1813FD8D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AD6C")]
			[Address(RVA = "0x13FD9B0", Offset = "0x13FC5B0", VA = "0x1813FD9B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003FB5 RID: 16309
		// (get) Token: 0x0601AD6D RID: 109933 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AD6E RID: 109934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FB5")]
		private RoguelikeTopicBattlePassState bindState
		{
			[Token(Token = "0x601AD6D")]
			[Address(RVA = "0x13FD870", Offset = "0x13FC470", VA = "0x1813FD870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601AD6E")]
			[Address(RVA = "0x13FD930", Offset = "0x13FC530", VA = "0x1813FD930")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AD6F RID: 109935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD6F")]
		[Address(RVA = "0x13FC5E0", Offset = "0x13FB1E0", VA = "0x1813FC5E0")]
		public void Init(RoguelikeTopicBattlePassState state)
		{
		}

		// Token: 0x0601AD70 RID: 109936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD70")]
		[Address(RVA = "0x13FCBF0", Offset = "0x13FB7F0", VA = "0x1813FCBF0", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicBattlePassProperty property)
		{
		}

		// Token: 0x0601AD71 RID: 109937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD71")]
		[Address(RVA = "0x13FD510", Offset = "0x13FC110", VA = "0x1813FD510")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AD72 RID: 109938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD72")]
		[Address(RVA = "0x13FD5F0", Offset = "0x13FC1F0", VA = "0x1813FD5F0")]
		private void _OnGrandPrizeClick(int level)
		{
		}

		// Token: 0x0601AD73 RID: 109939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD73")]
		[Address(RVA = "0x13FD680", Offset = "0x13FC280", VA = "0x1813FD680")]
		private void _OnRewardItemClick(string bpId)
		{
		}

		// Token: 0x0601AD74 RID: 109940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD74")]
		[Address(RVA = "0x13FC960", Offset = "0x13FB560", VA = "0x1813FC960")]
		public void OnGotAllBtnClick()
		{
		}

		// Token: 0x0601AD75 RID: 109941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD75")]
		[Address(RVA = "0x13FCA50", Offset = "0x13FB650", VA = "0x1813FCA50")]
		public void OnGuideBtnClick()
		{
		}

		// Token: 0x0601AD76 RID: 109942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD76")]
		[Address(RVA = "0x13FC690", Offset = "0x13FB290", VA = "0x1813FC690")]
		public void OnBpPurchaseClick()
		{
		}

		// Token: 0x0601AD77 RID: 109943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD77")]
		[Address(RVA = "0x13FC540", Offset = "0x13FB140", VA = "0x1813FC540")]
		public void FocusCurrentLv()
		{
		}

		// Token: 0x0601AD78 RID: 109944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD78")]
		[Address(RVA = "0x13FD0A0", Offset = "0x13FBCA0", VA = "0x1813FD0A0")]
		private void _FocusOnIdx(int focusIdx)
		{
		}

		// Token: 0x0601AD79 RID: 109945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD79")]
		[Address(RVA = "0x13FD800", Offset = "0x13FC400", VA = "0x1813FD800")]
		public RoguelikeTopicBattlePassView()
		{
		}

		// Token: 0x040225C1 RID: 140737
		[Token(Token = "0x40225C1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeTopicBattlePassAdapter _bpItemAdapter;

		// Token: 0x040225C2 RID: 140738
		[Token(Token = "0x40225C2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeTopicBattlePassTopView _topView;

		// Token: 0x040225C3 RID: 140739
		[Token(Token = "0x40225C3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeTopicBPGreatRewardView _middleView;

		// Token: 0x040225C4 RID: 140740
		[Token(Token = "0x40225C4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LoopHorizontalScrollRect _buttonScrollRect;

		// Token: 0x040225C5 RID: 140741
		[Token(Token = "0x40225C5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GridLayoutGroup _bpGridLayout;

		// Token: 0x040225C6 RID: 140742
		[Token(Token = "0x40225C6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelGetAllBtn;

		// Token: 0x040225C7 RID: 140743
		[Token(Token = "0x40225C7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _imgGotAllBtn;

		// Token: 0x040225C8 RID: 140744
		[Token(Token = "0x40225C8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _gotAllBtnText;

		// Token: 0x040225C9 RID: 140745
		[Token(Token = "0x40225C9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _imgBkg;

		// Token: 0x040225CA RID: 140746
		[Token(Token = "0x40225CA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _imgDetailBtn;

		// Token: 0x040225CB RID: 140747
		[Token(Token = "0x40225CB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _imgPurchaseBtn;

		// Token: 0x040225CD RID: 140749
		[Token(Token = "0x40225CD")]
		private const int SLIDE_MAX_LENGTH = 10;

		// Token: 0x040225CE RID: 140750
		[Token(Token = "0x40225CE")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x040225CF RID: 140751
		[Token(Token = "0x40225CF")]
		[FieldOffset(Offset = "0x88")]
		private List<string> m_cachedObtainableList;

		// Token: 0x040225D0 RID: 140752
		[Token(Token = "0x40225D0")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeTopicBattlePassViewModel m_cachedViewModel;

		// Token: 0x040225D1 RID: 140753
		[Token(Token = "0x40225D1")]
		[FieldOffset(Offset = "0x98")]
		private Tweener m_focusTween;

		// Token: 0x040225D3 RID: 140755
		[Token(Token = "0x40225D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_getRewardAction;

		// Token: 0x040225D4 RID: 140756
		[Token(Token = "0x40225D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_getRewardAction;

		// Token: 0x040225D5 RID: 140757
		[Token(Token = "0x40225D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_bindState;

		// Token: 0x040225D6 RID: 140758
		[Token(Token = "0x40225D6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_bindState;

		// Token: 0x040225D7 RID: 140759
		[Token(Token = "0x40225D7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040225D8 RID: 140760
		[Token(Token = "0x40225D8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040225D9 RID: 140761
		[Token(Token = "0x40225D9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040225DA RID: 140762
		[Token(Token = "0x40225DA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnGrandPrizeClick;

		// Token: 0x040225DB RID: 140763
		[Token(Token = "0x40225DB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnRewardItemClick;

		// Token: 0x040225DC RID: 140764
		[Token(Token = "0x40225DC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnGotAllBtnClick;

		// Token: 0x040225DD RID: 140765
		[Token(Token = "0x40225DD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnGuideBtnClick;

		// Token: 0x040225DE RID: 140766
		[Token(Token = "0x40225DE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBpPurchaseClick;

		// Token: 0x040225DF RID: 140767
		[Token(Token = "0x40225DF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_FocusCurrentLv;

		// Token: 0x040225E0 RID: 140768
		[Token(Token = "0x40225E0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__FocusOnIdx;

		// Token: 0x040225E1 RID: 140769
		[Token(Token = "0x40225E1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
