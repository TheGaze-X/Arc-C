using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A28 RID: 31272
	[Token(Token = "0x2007A28")]
	public class Act13sideDailyMissionPoolView : DataBinder<Act13sideDailyMissionPoolProperty>
	{
		// Token: 0x0602BD2C RID: 179500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD2C")]
		[Address(RVA = "0x27AEF50", Offset = "0x27ADB50", VA = "0x1827AEF50", Slot = "7")]
		public override void OnValueChanged(Act13sideDailyMissionPoolProperty property)
		{
		}

		// Token: 0x0602BD2D RID: 179501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD2D")]
		[Address(RVA = "0x27B0330", Offset = "0x27AEF30", VA = "0x1827B0330")]
		private void _RenderNormalPart(Act13sideDailyMissionPoolViewModel missionModel)
		{
		}

		// Token: 0x0602BD2E RID: 179502 RVA: 0x000DD580 File Offset: 0x000DB780
		[Token(Token = "0x602BD2E")]
		[Address(RVA = "0x27AFB10", Offset = "0x27AE710", VA = "0x1827AFB10")]
		private int _CalcBoardAgendaVal()
		{
			return 0;
		}

		// Token: 0x0602BD2F RID: 179503 RVA: 0x000DD598 File Offset: 0x000DB798
		[Token(Token = "0x602BD2F")]
		[Address(RVA = "0x27AFF50", Offset = "0x27AEB50", VA = "0x1827AFF50")]
		private int _GetMissionAgendaCount(string missionId)
		{
			return 0;
		}

		// Token: 0x0602BD30 RID: 179504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD30")]
		[Address(RVA = "0x27AFD00", Offset = "0x27AE900", VA = "0x1827AFD00")]
		private void _CleanView()
		{
		}

		// Token: 0x0602BD31 RID: 179505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD31")]
		[Address(RVA = "0x27AF9E0", Offset = "0x27AE5E0", VA = "0x1827AF9E0")]
		public void ResetLayoutElement()
		{
		}

		// Token: 0x0602BD32 RID: 179506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD32")]
		[Address(RVA = "0x27AEE80", Offset = "0x27ADA80", VA = "0x1827AEE80")]
		public void Init(string actId, Action<int> onMissonPoolItemSelected)
		{
		}

		// Token: 0x0602BD33 RID: 179507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD33")]
		[Address(RVA = "0x27B0070", Offset = "0x27AEC70", VA = "0x1827B0070")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BD34 RID: 179508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD34")]
		[Address(RVA = "0x27AF7D0", Offset = "0x27AE3D0", VA = "0x1827AF7D0")]
		public void PlayAcceptAnim(int selectedPoolIdx, TweenCallback onAnimComplete)
		{
		}

		// Token: 0x0602BD35 RID: 179509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD35")]
		[Address(RVA = "0x27B0DB0", Offset = "0x27AF9B0", VA = "0x1827B0DB0")]
		public Act13sideDailyMissionPoolView()
		{
		}

		// Token: 0x0403F69C RID: 259740
		[Token(Token = "0x403F69C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayoutElement[] _missionItemParentList;

		// Token: 0x0403F69D RID: 259741
		[Token(Token = "0x403F69D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act13sideMissionPoolItemView _missionItemTemplate;

		// Token: 0x0403F69E RID: 259742
		[Token(Token = "0x403F69E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textAgendaMax;

		// Token: 0x0403F69F RID: 259743
		[Token(Token = "0x403F69F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textAgendaOwn;

		// Token: 0x0403F6A0 RID: 259744
		[Token(Token = "0x403F6A0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textMissionBoard;

		// Token: 0x0403F6A1 RID: 259745
		[Token(Token = "0x403F6A1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textSearchCount;

		// Token: 0x0403F6A2 RID: 259746
		[Token(Token = "0x403F6A2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _btnSearch;

		// Token: 0x0403F6A3 RID: 259747
		[Token(Token = "0x403F6A3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _hintColor;

		// Token: 0x0403F6A4 RID: 259748
		[Token(Token = "0x403F6A4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _greyColor;

		// Token: 0x0403F6A5 RID: 259749
		[Token(Token = "0x403F6A5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TwoStateToggle[] _missionBoardItemList;

		// Token: 0x0403F6A6 RID: 259750
		[Token(Token = "0x403F6A6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x0403F6A7 RID: 259751
		[Token(Token = "0x403F6A7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Normal Part")]
		private GameObject _normalPartGo;

		// Token: 0x0403F6A8 RID: 259752
		[Token(Token = "0x403F6A8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Normal Part")]
		private Text _textPrincipalName;

		// Token: 0x0403F6A9 RID: 259753
		[Token(Token = "0x403F6A9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Normal Part")]
		private Text _textPrincipalEnName;

		// Token: 0x0403F6AA RID: 259754
		[Token(Token = "0x403F6AA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Normal Part")]
		private Text _textOrgEnName;

		// Token: 0x0403F6AB RID: 259755
		[Token(Token = "0x403F6AB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Normal Part")]
		private Text _textMissionName;

		// Token: 0x0403F6AC RID: 259756
		[Token(Token = "0x403F6AC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Normal Part")]
		private Text _textMissionDesc;

		// Token: 0x0403F6AD RID: 259757
		[Token(Token = "0x403F6AD")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Normal Part")]
		private Text _textPrestigeDesc;

		// Token: 0x0403F6AE RID: 259758
		[Token(Token = "0x403F6AE")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Normal Part")]
		private Text _textAgendaNeed;

		// Token: 0x0403F6AF RID: 259759
		[Token(Token = "0x403F6AF")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Normal Part")]
		private Text _textPrincipalDialog;

		// Token: 0x0403F6B0 RID: 259760
		[Token(Token = "0x403F6B0")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Normal Part")]
		private Image _imgOrgLogo;

		// Token: 0x0403F6B1 RID: 259761
		[Token(Token = "0x403F6B1")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Normal Part")]
		private GameObject _btnAccpetGo;

		// Token: 0x0403F6B2 RID: 259762
		[Token(Token = "0x403F6B2")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Normal Part")]
		private GameObject _btnReplaceGo;

		// Token: 0x0403F6B3 RID: 259763
		[Token(Token = "0x403F6B3")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Normal Part")]
		private GameObject _agendaLackHint;

		// Token: 0x0403F6B4 RID: 259764
		[Token(Token = "0x403F6B4")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Normal Part")]
		private SimpleLayoutContent _rewardList;

		// Token: 0x0403F6B5 RID: 259765
		[Token(Token = "0x403F6B5")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Normal Part")]
		private float _itemCardScale;

		// Token: 0x0403F6B6 RID: 259766
		[Token(Token = "0x403F6B6")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Normal Part")]
		private UIAVGCharacter _uiAVGCharacter;

		// Token: 0x0403F6B7 RID: 259767
		[Token(Token = "0x403F6B7")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private float _layoutAnimDelay;

		// Token: 0x0403F6B8 RID: 259768
		[Token(Token = "0x403F6B8")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private float _layoutAnimDuration;

		// Token: 0x0403F6B9 RID: 259769
		[Token(Token = "0x403F6B9")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private float _layoutElementHeight;

		// Token: 0x0403F6BA RID: 259770
		[Token(Token = "0x403F6BA")]
		[FieldOffset(Offset = "0x114")]
		private bool m_hasInited;

		// Token: 0x0403F6BB RID: 259771
		[Token(Token = "0x403F6BB")]
		[FieldOffset(Offset = "0x118")]
		private string m_actId;

		// Token: 0x0403F6BC RID: 259772
		[Token(Token = "0x403F6BC")]
		[FieldOffset(Offset = "0x120")]
		private Act13sideDailyMissionPoolViewModel m_model;

		// Token: 0x0403F6BD RID: 259773
		[Token(Token = "0x403F6BD")]
		[FieldOffset(Offset = "0x128")]
		private Act13SideData m_actData;

		// Token: 0x0403F6BE RID: 259774
		[Token(Token = "0x403F6BE")]
		[FieldOffset(Offset = "0x130")]
		private Action<int> m_onPoolItemSelected;

		// Token: 0x0403F6BF RID: 259775
		[Token(Token = "0x403F6BF")]
		[FieldOffset(Offset = "0x138")]
		private Act13sideDailyMissionPoolView.RewardListAdapter m_rewardListAdapter;

		// Token: 0x0403F6C0 RID: 259776
		[Token(Token = "0x403F6C0")]
		[FieldOffset(Offset = "0x140")]
		private string m_prevAvgCharId;

		// Token: 0x0403F6C1 RID: 259777
		[Token(Token = "0x403F6C1")]
		[FieldOffset(Offset = "0x148")]
		private List<Act13sideMissionPoolItemView> m_missionItemList;

		// Token: 0x0403F6C2 RID: 259778
		[Token(Token = "0x403F6C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403F6C3 RID: 259779
		[Token(Token = "0x403F6C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderNormalPart;

		// Token: 0x0403F6C4 RID: 259780
		[Token(Token = "0x403F6C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CalcBoardAgendaVal;

		// Token: 0x0403F6C5 RID: 259781
		[Token(Token = "0x403F6C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetMissionAgendaCount;

		// Token: 0x0403F6C6 RID: 259782
		[Token(Token = "0x403F6C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CleanView;

		// Token: 0x0403F6C7 RID: 259783
		[Token(Token = "0x403F6C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ResetLayoutElement;

		// Token: 0x0403F6C8 RID: 259784
		[Token(Token = "0x403F6C8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403F6C9 RID: 259785
		[Token(Token = "0x403F6C9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F6CA RID: 259786
		[Token(Token = "0x403F6CA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_PlayAcceptAnim;

		// Token: 0x0403F6CB RID: 259787
		[Token(Token = "0x403F6CB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A29 RID: 31273
		[Token(Token = "0x2007A29")]
		private class RewardListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602BD36 RID: 179510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BD36")]
			[Address(RVA = "0x27C0CE0", Offset = "0x27BF8E0", VA = "0x1827C0CE0")]
			public RewardListAdapter(Act13sideDailyMissionPoolView closure)
			{
			}

			// Token: 0x170066C3 RID: 26307
			// (get) Token: 0x0602BD37 RID: 179511 RVA: 0x000DD5B0 File Offset: 0x000DB7B0
			[Token(Token = "0x170066C3")]
			public override int count
			{
				[Token(Token = "0x602BD37")]
				[Address(RVA = "0x27C0D60", Offset = "0x27BF960", VA = "0x1827C0D60", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602BD38 RID: 179512 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BD38")]
			[Address(RVA = "0x27C0840", Offset = "0x27BF440", VA = "0x1827C0840", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403F6CC RID: 259788
			[Token(Token = "0x403F6CC")]
			[FieldOffset(Offset = "0x20")]
			private Act13sideDailyMissionPoolView m_closure;

			// Token: 0x0403F6CD RID: 259789
			[Token(Token = "0x403F6CD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403F6CE RID: 259790
			[Token(Token = "0x403F6CE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403F6CF RID: 259791
			[Token(Token = "0x403F6CF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
