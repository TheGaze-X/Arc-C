using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007516 RID: 29974
	[Token(Token = "0x2007516")]
	public class Act25sideResearchAreaView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A3DE RID: 173022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3DE")]
		[Address(RVA = "0x25E1560", Offset = "0x25E0160", VA = "0x1825E1560")]
		public void Init(UIPage page)
		{
		}

		// Token: 0x0602A3DF RID: 173023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3DF")]
		[Address(RVA = "0x25E1D40", Offset = "0x25E0940", VA = "0x1825E1D40")]
		public void Render(Act25sideAreaViewModel viewModel, bool isInit = false)
		{
		}

		// Token: 0x0602A3E0 RID: 173024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A3E0")]
		[Address(RVA = "0x25E3180", Offset = "0x25E1D80", VA = "0x1825E3180")]
		private IEnumerator _SwitchAnimCoroutine()
		{
			return null;
		}

		// Token: 0x0602A3E1 RID: 173025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3E1")]
		[Address(RVA = "0x25E2450", Offset = "0x25E1050", VA = "0x1825E2450")]
		private void _LoadArea()
		{
		}

		// Token: 0x0602A3E2 RID: 173026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3E2")]
		[Address(RVA = "0x25E21D0", Offset = "0x25E0DD0", VA = "0x1825E21D0")]
		private void _LoadAreaImpl()
		{
		}

		// Token: 0x0602A3E3 RID: 173027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3E3")]
		[Address(RVA = "0x25E2700", Offset = "0x25E1300", VA = "0x1825E2700")]
		public void _RenderArea()
		{
		}

		// Token: 0x0602A3E4 RID: 173028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3E4")]
		[Address(RVA = "0x25E1FB0", Offset = "0x25E0BB0", VA = "0x1825E1FB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A3E5 RID: 173029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A3E5")]
		[Address(RVA = "0x25E2670", Offset = "0x25E1270", VA = "0x1825E2670")]
		private Sprite _LoadProgressIcon(string iconId)
		{
			return null;
		}

		// Token: 0x0602A3E6 RID: 173030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3E6")]
		[Address(RVA = "0x25E19A0", Offset = "0x25E05A0", VA = "0x1825E19A0")]
		public void OnRouteToStage()
		{
		}

		// Token: 0x0602A3E7 RID: 173031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3E7")]
		[Address(RVA = "0x25E1650", Offset = "0x25E0250", VA = "0x1825E1650")]
		public void OnAcceptMission()
		{
		}

		// Token: 0x0602A3E8 RID: 173032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3E8")]
		[Address(RVA = "0x25E1750", Offset = "0x25E0350", VA = "0x1825E1750")]
		public void OnCompleteMission()
		{
		}

		// Token: 0x0602A3E9 RID: 173033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3E9")]
		[Address(RVA = "0x25E18A0", Offset = "0x25E04A0", VA = "0x1825E18A0")]
		public void OnOpenArchive()
		{
		}

		// Token: 0x0602A3EA RID: 173034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3EA")]
		[Address(RVA = "0x25E1C40", Offset = "0x25E0840", VA = "0x1825E1C40")]
		public void OnShowReward()
		{
		}

		// Token: 0x0602A3EB RID: 173035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3EB")]
		[Address(RVA = "0x25E3230", Offset = "0x25E1E30", VA = "0x1825E3230")]
		public Act25sideResearchAreaView()
		{
		}

		// Token: 0x0403CB70 RID: 248688
		[Token(Token = "0x403CB70")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _areaName;

		// Token: 0x0403CB71 RID: 248689
		[Token(Token = "0x403CB71")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _areaProgress;

		// Token: 0x0403CB72 RID: 248690
		[Token(Token = "0x403CB72")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _progressIcon;

		// Token: 0x0403CB73 RID: 248691
		[Token(Token = "0x403CB73")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelAreaDesc;

		// Token: 0x0403CB74 RID: 248692
		[Token(Token = "0x403CB74")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelMission;

		// Token: 0x0403CB75 RID: 248693
		[Token(Token = "0x403CB75")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelAreaEnd;

		// Token: 0x0403CB76 RID: 248694
		[Token(Token = "0x403CB76")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelBattleEnd;

		// Token: 0x0403CB77 RID: 248695
		[Token(Token = "0x403CB77")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelMissionUncomplete;

		// Token: 0x0403CB78 RID: 248696
		[Token(Token = "0x403CB78")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelMissionComplete;

		// Token: 0x0403CB79 RID: 248697
		[Token(Token = "0x403CB79")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelAreaComplete;

		// Token: 0x0403CB7A RID: 248698
		[Token(Token = "0x403CB7A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SimpleLayoutContent _rewardContent;

		// Token: 0x0403CB7B RID: 248699
		[Token(Token = "0x403CB7B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0403CB7C RID: 248700
		[Token(Token = "0x403CB7C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textAreaDesc;

		// Token: 0x0403CB7D RID: 248701
		[Token(Token = "0x403CB7D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textCostCount;

		// Token: 0x0403CB7E RID: 248702
		[Token(Token = "0x403CB7E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textMissionDesc;

		// Token: 0x0403CB7F RID: 248703
		[Token(Token = "0x403CB7F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textAreaEnd;

		// Token: 0x0403CB80 RID: 248704
		[Token(Token = "0x403CB80")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _maskSwitchAnim;

		// Token: 0x0403CB81 RID: 248705
		[Token(Token = "0x403CB81")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Transform _areaContainer;

		// Token: 0x0403CB82 RID: 248706
		[Token(Token = "0x403CB82")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UICommonPageEffectHolder _pageEffectHolder;

		// Token: 0x0403CB83 RID: 248707
		[Token(Token = "0x403CB83")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _panelArchiveButton;

		// Token: 0x0403CB84 RID: 248708
		[Token(Token = "0x403CB84")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CanvasGroup _areaBtnCanvasGroup;

		// Token: 0x0403CB85 RID: 248709
		[Token(Token = "0x403CB85")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float _areaEmptyAlpha;

		// Token: 0x0403CB86 RID: 248710
		[Token(Token = "0x403CB86")]
		[FieldOffset(Offset = "0xCC")]
		private bool m_isInited;

		// Token: 0x0403CB87 RID: 248711
		[Token(Token = "0x403CB87")]
		[FieldOffset(Offset = "0xCD")]
		private bool m_isSwitching;

		// Token: 0x0403CB88 RID: 248712
		[Token(Token = "0x403CB88")]
		[FieldOffset(Offset = "0xD0")]
		private AnimationSwitchTween m_maskSwitchAnim;

		// Token: 0x0403CB89 RID: 248713
		[Token(Token = "0x403CB89")]
		[FieldOffset(Offset = "0xD8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403CB8A RID: 248714
		[Token(Token = "0x403CB8A")]
		[FieldOffset(Offset = "0xE8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403CB8B RID: 248715
		[Token(Token = "0x403CB8B")]
		[FieldOffset(Offset = "0xF8")]
		private Act25sideAreaViewModel m_cachedViewModel;

		// Token: 0x0403CB8C RID: 248716
		[Token(Token = "0x403CB8C")]
		[FieldOffset(Offset = "0x100")]
		private Act25sideResearchAreaView.RewardAdapter m_adapter;

		// Token: 0x0403CB8D RID: 248717
		[Token(Token = "0x403CB8D")]
		[FieldOffset(Offset = "0x108")]
		private Act25sideResearchAreaBackView m_currentAreaView;

		// Token: 0x0403CB8E RID: 248718
		[Token(Token = "0x403CB8E")]
		[FieldOffset(Offset = "0x110")]
		private GameObject m_areaPrefab;

		// Token: 0x0403CB8F RID: 248719
		[Token(Token = "0x403CB8F")]
		[FieldOffset(Offset = "0x118")]
		private Coroutine m_switchCoroutine;

		// Token: 0x0403CB90 RID: 248720
		[Token(Token = "0x403CB90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403CB91 RID: 248721
		[Token(Token = "0x403CB91")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CB92 RID: 248722
		[Token(Token = "0x403CB92")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SwitchAnimCoroutine;

		// Token: 0x0403CB93 RID: 248723
		[Token(Token = "0x403CB93")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadArea;

		// Token: 0x0403CB94 RID: 248724
		[Token(Token = "0x403CB94")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadAreaImpl;

		// Token: 0x0403CB95 RID: 248725
		[Token(Token = "0x403CB95")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderArea;

		// Token: 0x0403CB96 RID: 248726
		[Token(Token = "0x403CB96")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CB97 RID: 248727
		[Token(Token = "0x403CB97")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadProgressIcon;

		// Token: 0x0403CB98 RID: 248728
		[Token(Token = "0x403CB98")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnRouteToStage;

		// Token: 0x0403CB99 RID: 248729
		[Token(Token = "0x403CB99")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnAcceptMission;

		// Token: 0x0403CB9A RID: 248730
		[Token(Token = "0x403CB9A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnCompleteMission;

		// Token: 0x0403CB9B RID: 248731
		[Token(Token = "0x403CB9B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnOpenArchive;

		// Token: 0x0403CB9C RID: 248732
		[Token(Token = "0x403CB9C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnShowReward;

		// Token: 0x0403CB9D RID: 248733
		[Token(Token = "0x403CB9D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007517 RID: 29975
		[Token(Token = "0x2007517")]
		public class RouteStageParam : IHotfixable
		{
			// Token: 0x0602A3EC RID: 173036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A3EC")]
			[Address(RVA = "0x25F0030", Offset = "0x25EEC30", VA = "0x1825F0030")]
			public RouteStageParam()
			{
			}

			// Token: 0x0403CB9E RID: 248734
			[Token(Token = "0x403CB9E")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x0403CB9F RID: 248735
			[Token(Token = "0x403CB9F")]
			[FieldOffset(Offset = "0x18")]
			public bool isZone;

			// Token: 0x0403CBA0 RID: 248736
			[Token(Token = "0x403CBA0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02007518 RID: 29976
		[Token(Token = "0x2007518")]
		private class RewardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A3ED RID: 173037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A3ED")]
			[Address(RVA = "0x25ED940", Offset = "0x25EC540", VA = "0x1825ED940")]
			public RewardAdapter(Act25sideResearchAreaView closure)
			{
			}

			// Token: 0x17006364 RID: 25444
			// (get) Token: 0x0602A3EE RID: 173038 RVA: 0x000D7BC8 File Offset: 0x000D5DC8
			[Token(Token = "0x17006364")]
			public override int count
			{
				[Token(Token = "0x602A3EE")]
				[Address(RVA = "0x25EDA60", Offset = "0x25EC660", VA = "0x1825EDA60", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A3EF RID: 173039 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A3EF")]
			[Address(RVA = "0x25ED440", Offset = "0x25EC040", VA = "0x1825ED440", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403CBA1 RID: 248737
			[Token(Token = "0x403CBA1")]
			[FieldOffset(Offset = "0x20")]
			private Act25sideResearchAreaView m_closure;

			// Token: 0x0403CBA2 RID: 248738
			[Token(Token = "0x403CBA2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403CBA3 RID: 248739
			[Token(Token = "0x403CBA3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403CBA4 RID: 248740
			[Token(Token = "0x403CBA4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
