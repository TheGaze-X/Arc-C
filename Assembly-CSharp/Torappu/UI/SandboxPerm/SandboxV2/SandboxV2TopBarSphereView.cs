using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200420F RID: 16911
	[Token(Token = "0x200420F")]
	public class SandboxV2TopBarSphereView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A16E RID: 106862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A16E")]
		[Address(RVA = "0x12F8DD0", Offset = "0x12F79D0", VA = "0x1812F8DD0")]
		public void Render(SandboxV2DungeonViewModel viewModel)
		{
		}

		// Token: 0x0601A16F RID: 106863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A16F")]
		[Address(RVA = "0x12F9AD0", Offset = "0x12F86D0", VA = "0x1812F9AD0")]
		private void _RenderRing(SandboxV2TopBarSphereView.Mode renderMode, float daySeasonAngle)
		{
		}

		// Token: 0x0601A170 RID: 106864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A170")]
		[Address(RVA = "0x12F9CA0", Offset = "0x12F88A0", VA = "0x1812F9CA0")]
		private void _RenderTip(SandboxV2TopBarSphereView.Mode renderMode, bool isRiftReservated, bool isRiftMainFail, bool isRiftMainFinish)
		{
		}

		// Token: 0x0601A171 RID: 106865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A171")]
		[Address(RVA = "0x12F98B0", Offset = "0x12F84B0", VA = "0x1812F98B0")]
		private void _RenderCrossDay(SandboxV2TopBarSphereView.Mode renderMode, bool isSettleDay, bool isCrossDay, bool isRiftReservated, bool isFastMode, bool isEmergency)
		{
		}

		// Token: 0x0601A172 RID: 106866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A172")]
		[Address(RVA = "0x12F9630", Offset = "0x12F8230", VA = "0x1812F9630")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A173 RID: 106867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A173")]
		[Address(RVA = "0x12F8CC0", Offset = "0x12F78C0", VA = "0x1812F8CC0")]
		public void OnBtnGameflowPanelClicked()
		{
		}

		// Token: 0x0601A174 RID: 106868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A174")]
		[Address(RVA = "0x12F8D60", Offset = "0x12F7960", VA = "0x1812F8D60")]
		public void OnSphereContentClick()
		{
		}

		// Token: 0x0601A175 RID: 106869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A175")]
		[Address(RVA = "0x12F9550", Offset = "0x12F8150", VA = "0x1812F9550")]
		public GameObject TutorialOnly_GetCrossDayBtnGo()
		{
			return null;
		}

		// Token: 0x0601A176 RID: 106870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A176")]
		[Address(RVA = "0x12F95C0", Offset = "0x12F81C0", VA = "0x1812F95C0")]
		public GameObject TutorialOnly_GetSphereBtnGo()
		{
			return null;
		}

		// Token: 0x0601A177 RID: 106871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A177")]
		[Address(RVA = "0x12F9E10", Offset = "0x12F8A10", VA = "0x1812F9E10")]
		public SandboxV2TopBarSphereView()
		{
		}

		// Token: 0x04020E39 RID: 134713
		[Token(Token = "0x4020E39")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _ringNormal;

		// Token: 0x04020E3A RID: 134714
		[Token(Token = "0x4020E3A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _ringRift;

		// Token: 0x04020E3B RID: 134715
		[Token(Token = "0x4020E3B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _ringChallenge;

		// Token: 0x04020E3C RID: 134716
		[Token(Token = "0x4020E3C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x04020E3D RID: 134717
		[Token(Token = "0x4020E3D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelRift;

		// Token: 0x04020E3E RID: 134718
		[Token(Token = "0x4020E3E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelChallenge;

		// Token: 0x04020E3F RID: 134719
		[Token(Token = "0x4020E3F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _dayAngle;

		// Token: 0x04020E40 RID: 134720
		[Token(Token = "0x4020E40")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelSettleDay;

		// Token: 0x04020E41 RID: 134721
		[Token(Token = "0x4020E41")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelNormalDay;

		// Token: 0x04020E42 RID: 134722
		[Token(Token = "0x4020E42")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _panelCrossDay;

		// Token: 0x04020E43 RID: 134723
		[Token(Token = "0x4020E43")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _panelDownContent;

		// Token: 0x04020E44 RID: 134724
		[Token(Token = "0x4020E44")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _normalCrossDay;

		// Token: 0x04020E45 RID: 134725
		[Token(Token = "0x4020E45")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _normalRiftCrossDay;

		// Token: 0x04020E46 RID: 134726
		[Token(Token = "0x4020E46")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _riftSettleCrossDay;

		// Token: 0x04020E47 RID: 134727
		[Token(Token = "0x4020E47")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelRiftReserved;

		// Token: 0x04020E48 RID: 134728
		[Token(Token = "0x4020E48")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelRiftQuestSucc;

		// Token: 0x04020E49 RID: 134729
		[Token(Token = "0x4020E49")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _panelRiftQuestFail;

		// Token: 0x04020E4A RID: 134730
		[Token(Token = "0x4020E4A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _day;

		// Token: 0x04020E4B RID: 134731
		[Token(Token = "0x4020E4B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _maxDay;

		// Token: 0x04020E4C RID: 134732
		[Token(Token = "0x4020E4C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private SimpleLayoutContent _decisionContent;

		// Token: 0x04020E4D RID: 134733
		[Token(Token = "0x4020E4D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIBlendRTImage _bkgBlur;

		// Token: 0x04020E4E RID: 134734
		[Token(Token = "0x4020E4E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x04020E4F RID: 134735
		[Token(Token = "0x4020E4F")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _panelNormalBkg;

		// Token: 0x04020E50 RID: 134736
		[Token(Token = "0x4020E50")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _panelEmergencyBkg;

		// Token: 0x04020E51 RID: 134737
		[Token(Token = "0x4020E51")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Color _normalTextIconColor;

		// Token: 0x04020E52 RID: 134738
		[Token(Token = "0x4020E52")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Color _emergencyTextIconColor;

		// Token: 0x04020E53 RID: 134739
		[Token(Token = "0x4020E53")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Graphic[] _emergencyColorGraphics;

		// Token: 0x04020E54 RID: 134740
		[Token(Token = "0x4020E54")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Button _buttonSphereCrossDay;

		// Token: 0x04020E55 RID: 134741
		[Token(Token = "0x4020E55")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Button _buttonSphereNormal;

		// Token: 0x04020E56 RID: 134742
		[Token(Token = "0x4020E56")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Text _textDaySurvive;

		// Token: 0x04020E57 RID: 134743
		[Token(Token = "0x4020E57")]
		[FieldOffset(Offset = "0x120")]
		private bool m_isInited;

		// Token: 0x04020E58 RID: 134744
		[Token(Token = "0x4020E58")]
		[FieldOffset(Offset = "0x128")]
		private SandboxV2TopBarSphereView.Adapter m_adapter;

		// Token: 0x04020E59 RID: 134745
		[Token(Token = "0x4020E59")]
		[FieldOffset(Offset = "0x130")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020E5A RID: 134746
		[Token(Token = "0x4020E5A")]
		[FieldOffset(Offset = "0x140")]
		private SandboxV2TopBarSphereView.FadeTween m_crossDayTween;

		// Token: 0x04020E5B RID: 134747
		[Token(Token = "0x4020E5B")]
		[FieldOffset(Offset = "0x148")]
		private SandboxV2DungeonViewModel m_cachedViewModel;

		// Token: 0x04020E5C RID: 134748
		[Token(Token = "0x4020E5C")]
		[FieldOffset(Offset = "0x150")]
		[NonSerialized]
		public Action onContentClick;

		// Token: 0x04020E5D RID: 134749
		[Token(Token = "0x4020E5D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020E5E RID: 134750
		[Token(Token = "0x4020E5E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderRing;

		// Token: 0x04020E5F RID: 134751
		[Token(Token = "0x4020E5F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderTip;

		// Token: 0x04020E60 RID: 134752
		[Token(Token = "0x4020E60")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderCrossDay;

		// Token: 0x04020E61 RID: 134753
		[Token(Token = "0x4020E61")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020E62 RID: 134754
		[Token(Token = "0x4020E62")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBtnGameflowPanelClicked;

		// Token: 0x04020E63 RID: 134755
		[Token(Token = "0x4020E63")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnSphereContentClick;

		// Token: 0x04020E64 RID: 134756
		[Token(Token = "0x4020E64")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetCrossDayBtnGo;

		// Token: 0x04020E65 RID: 134757
		[Token(Token = "0x4020E65")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetSphereBtnGo;

		// Token: 0x04020E66 RID: 134758
		[Token(Token = "0x4020E66")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004210 RID: 16912
		[Token(Token = "0x2004210")]
		private enum Mode
		{
			// Token: 0x04020E68 RID: 134760
			[Token(Token = "0x4020E68")]
			NORMAL,
			// Token: 0x04020E69 RID: 134761
			[Token(Token = "0x4020E69")]
			RIFT,
			// Token: 0x04020E6A RID: 134762
			[Token(Token = "0x4020E6A")]
			GUIDE,
			// Token: 0x04020E6B RID: 134763
			[Token(Token = "0x4020E6B")]
			CHALLENGE
		}

		// Token: 0x02004211 RID: 16913
		[Token(Token = "0x2004211")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A178 RID: 106872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A178")]
			[Address(RVA = "0x12E6700", Offset = "0x12E5300", VA = "0x1812E6700")]
			public Adapter(SandboxV2TopBarSphereView closure)
			{
			}

			// Token: 0x17003E17 RID: 15895
			// (get) Token: 0x0601A179 RID: 106873 RVA: 0x000A03F8 File Offset: 0x0009E5F8
			[Token(Token = "0x17003E17")]
			public override int count
			{
				[Token(Token = "0x601A179")]
				[Address(RVA = "0x12E69B0", Offset = "0x12E55B0", VA = "0x1812E69B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A17A RID: 106874 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A17A")]
			[Address(RVA = "0x12E5C60", Offset = "0x12E4860", VA = "0x1812E5C60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04020E6C RID: 134764
			[Token(Token = "0x4020E6C")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2TopBarSphereView m_closure;

			// Token: 0x04020E6D RID: 134765
			[Token(Token = "0x4020E6D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020E6E RID: 134766
			[Token(Token = "0x4020E6E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020E6F RID: 134767
			[Token(Token = "0x4020E6F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02004212 RID: 16914
		[Token(Token = "0x2004212")]
		private class FadeTween : UISwitchTween
		{
			// Token: 0x0601A17B RID: 106875 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A17B")]
			[Address(RVA = "0x12E72F0", Offset = "0x12E5EF0", VA = "0x1812E72F0")]
			public FadeTween(SandboxV2TopBarSphereView closure)
			{
			}

			// Token: 0x0601A17C RID: 106876 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A17C")]
			[Address(RVA = "0x12E6FE0", Offset = "0x12E5BE0", VA = "0x1812E6FE0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601A17D RID: 106877 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A17D")]
			[Address(RVA = "0x12E6DE0", Offset = "0x12E59E0", VA = "0x1812E6DE0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601A17E RID: 106878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A17E")]
			[Address(RVA = "0x12E6D40", Offset = "0x12E5940", VA = "0x1812E6D40", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601A17F RID: 106879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A17F")]
			[Address(RVA = "0x12E6C00", Offset = "0x12E5800", VA = "0x1812E6C00", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0601A180 RID: 106880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A180")]
			[Address(RVA = "0x12E6CA0", Offset = "0x12E58A0", VA = "0x1812E6CA0", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0601A181 RID: 106881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A181")]
			[Address(RVA = "0x12E6B60", Offset = "0x12E5760", VA = "0x1812E6B60", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601A182 RID: 106882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A182")]
			[Address(RVA = "0x12E71D0", Offset = "0x12E5DD0", VA = "0x1812E71D0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601A183 RID: 106883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A183")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601A184 RID: 106884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A184")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0601A185 RID: 106885 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A185")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0601A186 RID: 106886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A186")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601A187 RID: 106887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A187")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04020E70 RID: 134768
			[Token(Token = "0x4020E70")]
			[FieldOffset(Offset = "0x48")]
			private SandboxV2TopBarSphereView m_closure;

			// Token: 0x04020E71 RID: 134769
			[Token(Token = "0x4020E71")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020E72 RID: 134770
			[Token(Token = "0x4020E72")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04020E73 RID: 134771
			[Token(Token = "0x4020E73")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04020E74 RID: 134772
			[Token(Token = "0x4020E74")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04020E75 RID: 134773
			[Token(Token = "0x4020E75")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x04020E76 RID: 134774
			[Token(Token = "0x4020E76")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x04020E77 RID: 134775
			[Token(Token = "0x4020E77")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04020E78 RID: 134776
			[Token(Token = "0x4020E78")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
