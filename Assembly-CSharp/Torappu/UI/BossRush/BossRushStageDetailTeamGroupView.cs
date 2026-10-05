using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061CE RID: 25038
	[Token(Token = "0x20061CE")]
	public class BossRushStageDetailTeamGroupView : DataBinder<BossRushStageDetailProperty>, IHotfixable
	{
		// Token: 0x1700553C RID: 21820
		// (get) Token: 0x0602420D RID: 147981 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602420E RID: 147982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700553C")]
		public Action<string> onTeamClick
		{
			[Token(Token = "0x602420D")]
			[Address(RVA = "0x1EDFF10", Offset = "0x1EDEB10", VA = "0x181EDFF10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602420E")]
			[Address(RVA = "0x1EDFFE0", Offset = "0x1EDEBE0", VA = "0x181EDFFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700553D RID: 21821
		// (get) Token: 0x0602420F RID: 147983 RVA: 0x000C32E8 File Offset: 0x000C14E8
		// (set) Token: 0x06024210 RID: 147984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700553D")]
		public bool needReset
		{
			[Token(Token = "0x602420F")]
			[Address(RVA = "0x1EDFEB0", Offset = "0x1EDEAB0", VA = "0x181EDFEB0")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x6024210")]
			[Address(RVA = "0x1EDFF70", Offset = "0x1EDEB70", VA = "0x181EDFF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024211 RID: 147985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024211")]
		[Address(RVA = "0x1EDF150", Offset = "0x1EDDD50", VA = "0x181EDF150", Slot = "7")]
		public override void OnValueChanged(BossRushStageDetailProperty property)
		{
		}

		// Token: 0x06024212 RID: 147986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024212")]
		[Address(RVA = "0x1EDF550", Offset = "0x1EDE150", VA = "0x181EDF550")]
		private void _GenerateScrollTween(int position)
		{
		}

		// Token: 0x06024213 RID: 147987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024213")]
		[Address(RVA = "0x1EDFB80", Offset = "0x1EDE780", VA = "0x181EDFB80")]
		private void _ScrollToItem(int position)
		{
		}

		// Token: 0x06024214 RID: 147988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024214")]
		[Address(RVA = "0x1EDF990", Offset = "0x1EDE590", VA = "0x181EDF990")]
		private void _RefreshBuffInfo()
		{
		}

		// Token: 0x06024215 RID: 147989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024215")]
		[Address(RVA = "0x1EDF810", Offset = "0x1EDE410", VA = "0x181EDF810")]
		private void _RefreshBuffInfoContent()
		{
		}

		// Token: 0x06024216 RID: 147990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024216")]
		[Address(RVA = "0x1EDF6E0", Offset = "0x1EDE2E0", VA = "0x181EDF6E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024217 RID: 147991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024217")]
		[Address(RVA = "0x1EDFE10", Offset = "0x1EDEA10", VA = "0x181EDFE10")]
		public BossRushStageDetailTeamGroupView()
		{
		}

		// Token: 0x0403239D RID: 205725
		[Token(Token = "0x403239D")]
		private const string INFO_HIDE_ANIM = "bossrush_team_buff_info_hide_anim";

		// Token: 0x0403239E RID: 205726
		[Token(Token = "0x403239E")]
		private const string INFO_SHOW_ANIM = "bossrush_team_buff_info_show_anim";

		// Token: 0x0403239F RID: 205727
		[Token(Token = "0x403239F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Buff Info")]
		private GameObject _panelBuffInfo;

		// Token: 0x040323A0 RID: 205728
		[Token(Token = "0x40323A0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Buff Info")]
		private TwoStateToggle _toggleBuffInfoEmpty;

		// Token: 0x040323A1 RID: 205729
		[Token(Token = "0x40323A1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Buff Info")]
		private Image _imgBuffIcon;

		// Token: 0x040323A2 RID: 205730
		[Token(Token = "0x40323A2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Buff Info")]
		private Text _textBuffName;

		// Token: 0x040323A3 RID: 205731
		[Token(Token = "0x40323A3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Buff Info")]
		private Text _textBuffDesc;

		// Token: 0x040323A4 RID: 205732
		[Token(Token = "0x40323A4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Buff Info")]
		private AnimationWrapper _infoAnimWrapper;

		// Token: 0x040323A5 RID: 205733
		[Token(Token = "0x40323A5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _teamItemContent;

		// Token: 0x040323A6 RID: 205734
		[Token(Token = "0x40323A6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ScrollRect _teamScrollRect;

		// Token: 0x040323A7 RID: 205735
		[Token(Token = "0x40323A7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private HorizontalLayoutGroup _layoutGroup;

		// Token: 0x040323A8 RID: 205736
		[Token(Token = "0x40323A8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _scrollDuration;

		// Token: 0x040323A9 RID: 205737
		[Token(Token = "0x40323A9")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedSelectTeam;

		// Token: 0x040323AA RID: 205738
		[Token(Token = "0x40323AA")]
		[FieldOffset(Offset = "0x78")]
		private List<BossRushTeamModel> m_cachedTeamList;

		// Token: 0x040323AB RID: 205739
		[Token(Token = "0x40323AB")]
		[FieldOffset(Offset = "0x80")]
		private ActivityBossRushData.BossRushStageType m_cachedStageType;

		// Token: 0x040323AC RID: 205740
		[Token(Token = "0x40323AC")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedStageGroupId;

		// Token: 0x040323AD RID: 205741
		[Token(Token = "0x40323AD")]
		[FieldOffset(Offset = "0x90")]
		private bool m_needRefreshAll;

		// Token: 0x040323AE RID: 205742
		[Token(Token = "0x40323AE")]
		[FieldOffset(Offset = "0x91")]
		private bool m_hasInited;

		// Token: 0x040323AF RID: 205743
		[Token(Token = "0x40323AF")]
		[FieldOffset(Offset = "0x98")]
		private string m_actId;

		// Token: 0x040323B0 RID: 205744
		[Token(Token = "0x40323B0")]
		[FieldOffset(Offset = "0xA0")]
		private BossRushStageDetailTeamGroupView.Adapter m_adapter;

		// Token: 0x040323B1 RID: 205745
		[Token(Token = "0x40323B1")]
		[FieldOffset(Offset = "0xA8")]
		private UISwitchTween.TweenWrapper m_buffInfoTween;

		// Token: 0x040323B2 RID: 205746
		[Token(Token = "0x40323B2")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_scrollTween;

		// Token: 0x040323B5 RID: 205749
		[Token(Token = "0x40323B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onTeamClick;

		// Token: 0x040323B6 RID: 205750
		[Token(Token = "0x40323B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onTeamClick;

		// Token: 0x040323B7 RID: 205751
		[Token(Token = "0x40323B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_needReset;

		// Token: 0x040323B8 RID: 205752
		[Token(Token = "0x40323B8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_needReset;

		// Token: 0x040323B9 RID: 205753
		[Token(Token = "0x40323B9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040323BA RID: 205754
		[Token(Token = "0x40323BA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenerateScrollTween;

		// Token: 0x040323BB RID: 205755
		[Token(Token = "0x40323BB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ScrollToItem;

		// Token: 0x040323BC RID: 205756
		[Token(Token = "0x40323BC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshBuffInfo;

		// Token: 0x040323BD RID: 205757
		[Token(Token = "0x40323BD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshBuffInfoContent;

		// Token: 0x040323BE RID: 205758
		[Token(Token = "0x40323BE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040323BF RID: 205759
		[Token(Token = "0x40323BF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020061CF RID: 25039
		[Token(Token = "0x20061CF")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602421A RID: 147994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602421A")]
			[Address(RVA = "0x1ECCF40", Offset = "0x1ECBB40", VA = "0x181ECCF40")]
			public Adapter(BossRushStageDetailTeamGroupView closure)
			{
			}

			// Token: 0x1700553E RID: 21822
			// (get) Token: 0x0602421B RID: 147995 RVA: 0x000C3318 File Offset: 0x000C1518
			[Token(Token = "0x1700553E")]
			public override int count
			{
				[Token(Token = "0x602421B")]
				[Address(RVA = "0x1ECD040", Offset = "0x1ECBC40", VA = "0x181ECD040", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602421C RID: 147996 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602421C")]
			[Address(RVA = "0x1ECC930", Offset = "0x1ECB530", VA = "0x181ECC930", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602421D RID: 147997 RVA: 0x000C3330 File Offset: 0x000C1530
			[Token(Token = "0x602421D")]
			[Address(RVA = "0x1ECC750", Offset = "0x1ECB350", VA = "0x181ECC750")]
			public float GetItemWidth(int position)
			{
				return 0f;
			}

			// Token: 0x0602421E RID: 147998 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602421E")]
			[Address(RVA = "0x1ECCE60", Offset = "0x1ECBA60", VA = "0x181ECCE60")]
			private BossRushStageDetailTeamItemView _GetItemView(int position)
			{
				return null;
			}

			// Token: 0x040323C0 RID: 205760
			[Token(Token = "0x40323C0")]
			[FieldOffset(Offset = "0x20")]
			private BossRushStageDetailTeamGroupView m_closure;

			// Token: 0x040323C1 RID: 205761
			[Token(Token = "0x40323C1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040323C2 RID: 205762
			[Token(Token = "0x40323C2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040323C3 RID: 205763
			[Token(Token = "0x40323C3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040323C4 RID: 205764
			[Token(Token = "0x40323C4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetItemWidth;

			// Token: 0x040323C5 RID: 205765
			[Token(Token = "0x40323C5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__GetItemView;
		}
	}
}
