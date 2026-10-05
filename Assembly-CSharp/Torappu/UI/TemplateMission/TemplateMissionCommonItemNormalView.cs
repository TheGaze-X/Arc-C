using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D89 RID: 15753
	[Token(Token = "0x2003D89")]
	public class TemplateMissionCommonItemNormalView : AbstractTemplateMissionItemNormalView
	{
		// Token: 0x0601881D RID: 100381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601881D")]
		[Address(RVA = "0x110CE00", Offset = "0x110BA00", VA = "0x18110CE00")]
		public void Render(TemplateMissionCommonItemNormalView.TemplateMissionNormalItemVirtualViewStruct viewStruct)
		{
		}

		// Token: 0x0601881E RID: 100382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601881E")]
		[Address(RVA = "0x110D2F0", Offset = "0x110BEF0", VA = "0x18110D2F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601881F RID: 100383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601881F")]
		[Address(RVA = "0x110DD70", Offset = "0x110C970", VA = "0x18110DD70")]
		private void _SetPartsActiveByState()
		{
		}

		// Token: 0x06018820 RID: 100384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018820")]
		[Address(RVA = "0x110D650", Offset = "0x110C250", VA = "0x18110D650")]
		private void _RenderMissionProgressInfo()
		{
		}

		// Token: 0x06018821 RID: 100385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018821")]
		[Address(RVA = "0x110DB20", Offset = "0x110C720", VA = "0x18110DB20")]
		private void _RenderMissionThemePart()
		{
		}

		// Token: 0x06018822 RID: 100386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018822")]
		[Address(RVA = "0x110DCC0", Offset = "0x110C8C0", VA = "0x18110DCC0")]
		private void _RenderRewardPart()
		{
		}

		// Token: 0x06018823 RID: 100387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018823")]
		[Address(RVA = "0x110D420", Offset = "0x110C020", VA = "0x18110D420")]
		private void _RenderMissionDescriptionPart()
		{
		}

		// Token: 0x06018824 RID: 100388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018824")]
		[Address(RVA = "0x110D910", Offset = "0x110C510", VA = "0x18110D910")]
		private void _RenderMissionRemainPart()
		{
		}

		// Token: 0x06018825 RID: 100389 RVA: 0x0009AA10 File Offset: 0x00098C10
		[Token(Token = "0x6018825")]
		[Address(RVA = "0x110DF90", Offset = "0x110CB90", VA = "0x18110DF90")]
		private bool _ShowProgressDetailColor()
		{
			return default(bool);
		}

		// Token: 0x06018826 RID: 100390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018826")]
		[Address(RVA = "0x110CC50", Offset = "0x110B850", VA = "0x18110CC50")]
		public void OnMissionItemClick()
		{
		}

		// Token: 0x06018827 RID: 100391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018827")]
		[Address(RVA = "0x110DFF0", Offset = "0x110CBF0", VA = "0x18110DFF0")]
		public TemplateMissionCommonItemNormalView()
		{
		}

		// Token: 0x0401E07D RID: 123005
		[Token(Token = "0x401E07D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _preferSize;

		// Token: 0x0401E07E RID: 123006
		[Token(Token = "0x401E07E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401E07F RID: 123007
		[Token(Token = "0x401E07F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _rewardItemScalerFactor;

		// Token: 0x0401E080 RID: 123008
		[Token(Token = "0x401E080")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _canClaimPart;

		// Token: 0x0401E081 RID: 123009
		[Token(Token = "0x401E081")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _cannotGetPart;

		// Token: 0x0401E082 RID: 123010
		[Token(Token = "0x401E082")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _claimedPart;

		// Token: 0x0401E083 RID: 123011
		[Token(Token = "0x401E083")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _missionDetail;

		// Token: 0x0401E084 RID: 123012
		[Token(Token = "0x401E084")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colMissionDetailCanClaim;

		// Token: 0x0401E085 RID: 123013
		[Token(Token = "0x401E085")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colMissionDetailNormal;

		// Token: 0x0401E086 RID: 123014
		[Token(Token = "0x401E086")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Slider _progressSlider;

		// Token: 0x0401E087 RID: 123015
		[Token(Token = "0x401E087")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _progressDetail;

		// Token: 0x0401E088 RID: 123016
		[Token(Token = "0x401E088")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _useDiffColorForProgressDetail;

		// Token: 0x0401E089 RID: 123017
		[Token(Token = "0x401E089")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		[Inspect("_ShowProgressDetailColor")]
		private Color _colProgressDetailCanClaim;

		// Token: 0x0401E08A RID: 123018
		[Token(Token = "0x401E08A")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		[Inspect("_ShowProgressDetailColor")]
		private Color _colProgressDetailNormal;

		// Token: 0x0401E08B RID: 123019
		[Token(Token = "0x401E08B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAtlasImage _imgCanClaimThemeBg;

		// Token: 0x0401E08C RID: 123020
		[Token(Token = "0x401E08C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Remain Time")]
		private GameObject _panelCountRemain;

		// Token: 0x0401E08D RID: 123021
		[Token(Token = "0x401E08D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Remain Time")]
		private Text _textCountRemain;

		// Token: 0x0401E08E RID: 123022
		[Token(Token = "0x401E08E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Remain Time")]
		private GameObject _panelEndRemain;

		// Token: 0x0401E08F RID: 123023
		[Token(Token = "0x401E08F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Remain Time")]
		private Text _textEndRemain;

		// Token: 0x0401E090 RID: 123024
		[Token(Token = "0x401E090")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isInited;

		// Token: 0x0401E091 RID: 123025
		[Token(Token = "0x401E091")]
		[FieldOffset(Offset = "0xD8")]
		private TemplateMissionCommonItemNormalView.RewardAdapter m_adapter;

		// Token: 0x0401E092 RID: 123026
		[Token(Token = "0x401E092")]
		[FieldOffset(Offset = "0xE0")]
		private TemplateMissionListNormalItemViewModel m_cachedViewModel;

		// Token: 0x0401E093 RID: 123027
		[Token(Token = "0x401E093")]
		[FieldOffset(Offset = "0xE8")]
		private AbstractTemplateMissionRewardItemView m_rewardItemViewPrefab;

		// Token: 0x0401E094 RID: 123028
		[Token(Token = "0x401E094")]
		[FieldOffset(Offset = "0xF0")]
		private List<AbstractTemplateMissionRewardItemViewModel> m_itemViewModelList;

		// Token: 0x0401E095 RID: 123029
		[Token(Token = "0x401E095")]
		[FieldOffset(Offset = "0xF8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401E096 RID: 123030
		[Token(Token = "0x401E096")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E097 RID: 123031
		[Token(Token = "0x401E097")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E098 RID: 123032
		[Token(Token = "0x401E098")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetPartsActiveByState;

		// Token: 0x0401E099 RID: 123033
		[Token(Token = "0x401E099")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderMissionProgressInfo;

		// Token: 0x0401E09A RID: 123034
		[Token(Token = "0x401E09A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderMissionThemePart;

		// Token: 0x0401E09B RID: 123035
		[Token(Token = "0x401E09B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderRewardPart;

		// Token: 0x0401E09C RID: 123036
		[Token(Token = "0x401E09C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderMissionDescriptionPart;

		// Token: 0x0401E09D RID: 123037
		[Token(Token = "0x401E09D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderMissionRemainPart;

		// Token: 0x0401E09E RID: 123038
		[Token(Token = "0x401E09E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowProgressDetailColor;

		// Token: 0x0401E09F RID: 123039
		[Token(Token = "0x401E09F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnMissionItemClick;

		// Token: 0x0401E0A0 RID: 123040
		[Token(Token = "0x401E0A0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003D8A RID: 15754
		[Token(Token = "0x2003D8A")]
		public struct TemplateMissionNormalItemVirtualViewStruct
		{
			// Token: 0x0401E0A1 RID: 123041
			[Token(Token = "0x401E0A1")]
			[FieldOffset(Offset = "0x0")]
			public TemplateMissionCommonItemNormalView prefab;

			// Token: 0x0401E0A2 RID: 123042
			[Token(Token = "0x401E0A2")]
			[FieldOffset(Offset = "0x8")]
			public AbstractTemplateMissionRewardItemView rewardPrefab;

			// Token: 0x0401E0A3 RID: 123043
			[Token(Token = "0x401E0A3")]
			[FieldOffset(Offset = "0x10")]
			public TemplateMissionListNormalItemViewModel viewModel;
		}

		// Token: 0x02003D8B RID: 15755
		[Token(Token = "0x2003D8B")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<TemplateMissionCommonItemNormalView>
		{
			// Token: 0x06018828 RID: 100392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018828")]
			[Address(RVA = "0x111B010", Offset = "0x1119C10", VA = "0x18111B010")]
			public VirtualView(TemplateMissionCommonItemNormalView.TemplateMissionNormalItemVirtualViewStruct viewStruct)
			{
			}

			// Token: 0x06018829 RID: 100393 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018829")]
			[Address(RVA = "0x111ACD0", Offset = "0x11198D0", VA = "0x18111ACD0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601882A RID: 100394 RVA: 0x0009AA28 File Offset: 0x00098C28
			[Token(Token = "0x601882A")]
			[Address(RVA = "0x111AD40", Offset = "0x1119940", VA = "0x18111AD40", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0601882B RID: 100395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601882B")]
			[Address(RVA = "0x111AFB0", Offset = "0x1119BB0", VA = "0x18111AFB0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0601882C RID: 100396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601882C")]
			[Address(RVA = "0x111AE20", Offset = "0x1119A20", VA = "0x18111AE20", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0401E0A4 RID: 123044
			[Token(Token = "0x401E0A4")]
			[FieldOffset(Offset = "0x20")]
			private TemplateMissionCommonItemNormalView.TemplateMissionNormalItemVirtualViewStruct m_viewStruct;

			// Token: 0x0401E0A5 RID: 123045
			[Token(Token = "0x401E0A5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E0A6 RID: 123046
			[Token(Token = "0x401E0A6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401E0A7 RID: 123047
			[Token(Token = "0x401E0A7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0401E0A8 RID: 123048
			[Token(Token = "0x401E0A8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0401E0A9 RID: 123049
			[Token(Token = "0x401E0A9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewAttached;
		}

		// Token: 0x02003D8C RID: 15756
		[Token(Token = "0x2003D8C")]
		public class RewardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601882D RID: 100397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601882D")]
			[Address(RVA = "0x11055E0", Offset = "0x11041E0", VA = "0x1811055E0")]
			public RewardAdapter(TemplateMissionCommonItemNormalView closure)
			{
			}

			// Token: 0x17003A7C RID: 14972
			// (get) Token: 0x0601882E RID: 100398 RVA: 0x0009AA40 File Offset: 0x00098C40
			[Token(Token = "0x17003A7C")]
			public override int count
			{
				[Token(Token = "0x601882E")]
				[Address(RVA = "0x1105660", Offset = "0x1104260", VA = "0x181105660", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601882F RID: 100399 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601882F")]
			[Address(RVA = "0x1105380", Offset = "0x1103F80", VA = "0x181105380", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401E0AA RID: 123050
			[Token(Token = "0x401E0AA")]
			[FieldOffset(Offset = "0x20")]
			private TemplateMissionCommonItemNormalView m_closure;

			// Token: 0x0401E0AB RID: 123051
			[Token(Token = "0x401E0AB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E0AC RID: 123052
			[Token(Token = "0x401E0AC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401E0AD RID: 123053
			[Token(Token = "0x401E0AD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
