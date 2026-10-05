using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B23 RID: 6947
	[Token(Token = "0x2001B23")]
	public class BuildingUIFloatStationView : AbstractBuildingUIFloatStationView
	{
		// Token: 0x0600AEEB RID: 44779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEEB")]
		[Address(RVA = "0x3295700", Offset = "0x3294300", VA = "0x183295700", Slot = "7")]
		public override void OnValueChanged(FloatStationViewProperty property)
		{
		}

		// Token: 0x0600AEEC RID: 44780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEEC")]
		[Address(RVA = "0x3295670", Offset = "0x3294270", VA = "0x183295670")]
		public void EventOnClearStationClicked()
		{
		}

		// Token: 0x0600AEED RID: 44781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEED")]
		[Address(RVA = "0x3295D30", Offset = "0x3294930", VA = "0x183295D30")]
		private void _OnStationSlotClicked(BuildingCharModel charModel, int index)
		{
		}

		// Token: 0x0600AEEE RID: 44782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEEE")]
		[Address(RVA = "0x3295BA0", Offset = "0x32947A0", VA = "0x183295BA0")]
		private void _OnRemoveCharClicked(BuildingCharModel charModel, int index)
		{
		}

		// Token: 0x0600AEEF RID: 44783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEEF")]
		[Address(RVA = "0x3295990", Offset = "0x3294590", VA = "0x183295990")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600AEF0 RID: 44784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEF0")]
		[Address(RVA = "0x32960F0", Offset = "0x3294CF0", VA = "0x1832960F0")]
		private void _UpdateShowEffect()
		{
		}

		// Token: 0x0600AEF1 RID: 44785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEF1")]
		[Address(RVA = "0x3295EF0", Offset = "0x3294AF0", VA = "0x183295EF0")]
		private void _UpdateContent()
		{
		}

		// Token: 0x0600AEF2 RID: 44786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AEF2")]
		[Address(RVA = "0x3295E40", Offset = "0x3294A40", VA = "0x183295E40")]
		private IEnumerator _UpdateAutoLayoutCoroutine(RectTransform layout)
		{
			return null;
		}

		// Token: 0x0600AEF3 RID: 44787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEF3")]
		[Address(RVA = "0x32964F0", Offset = "0x32950F0", VA = "0x1832964F0")]
		public BuildingUIFloatStationView()
		{
		}

		// Token: 0x0400A82D RID: 43053
		[Token(Token = "0x400A82D")]
		private const string ICON_NAME = "char_icon";

		// Token: 0x0400A82E RID: 43054
		[Token(Token = "0x400A82E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _charContent;

		// Token: 0x0400A82F RID: 43055
		[Token(Token = "0x400A82F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _iconContent;

		// Token: 0x0400A830 RID: 43056
		[Token(Token = "0x400A830")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textStationNum;

		// Token: 0x0400A831 RID: 43057
		[Token(Token = "0x400A831")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textMaxStationNum;

		// Token: 0x0400A832 RID: 43058
		[Token(Token = "0x400A832")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _lineStationedNum;

		// Token: 0x0400A833 RID: 43059
		[Token(Token = "0x400A833")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Sprite _stationIcon;

		// Token: 0x0400A834 RID: 43060
		[Token(Token = "0x400A834")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x0400A835 RID: 43061
		[Token(Token = "0x400A835")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _panelBlank;

		// Token: 0x0400A836 RID: 43062
		[Token(Token = "0x400A836")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ScrollRect _stationScroll;

		// Token: 0x0400A837 RID: 43063
		[Token(Token = "0x400A837")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ScrollRectSoftMask _stationScrollMask;

		// Token: 0x0400A838 RID: 43064
		[Token(Token = "0x400A838")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0400A839 RID: 43065
		[Token(Token = "0x400A839")]
		[FieldOffset(Offset = "0x81")]
		private bool m_isShowing;

		// Token: 0x0400A83A RID: 43066
		[Token(Token = "0x400A83A")]
		[FieldOffset(Offset = "0x84")]
		private int m_stationedCharNum;

		// Token: 0x0400A83B RID: 43067
		[Token(Token = "0x400A83B")]
		[FieldOffset(Offset = "0x88")]
		private FloatStationViewModel m_viewModel;

		// Token: 0x0400A83C RID: 43068
		[Token(Token = "0x400A83C")]
		[FieldOffset(Offset = "0x90")]
		private BuildingUIFloatStationView.StationAdapter m_stationAdapter;

		// Token: 0x0400A83D RID: 43069
		[Token(Token = "0x400A83D")]
		[FieldOffset(Offset = "0x98")]
		private BuildingUIFloatStationView.IconAdapter m_iconAdapter;

		// Token: 0x0400A83E RID: 43070
		[Token(Token = "0x400A83E")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_tweenCache;

		// Token: 0x0400A83F RID: 43071
		[Token(Token = "0x400A83F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400A840 RID: 43072
		[Token(Token = "0x400A840")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClearStationClicked;

		// Token: 0x0400A841 RID: 43073
		[Token(Token = "0x400A841")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnStationSlotClicked;

		// Token: 0x0400A842 RID: 43074
		[Token(Token = "0x400A842")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnRemoveCharClicked;

		// Token: 0x0400A843 RID: 43075
		[Token(Token = "0x400A843")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400A844 RID: 43076
		[Token(Token = "0x400A844")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateShowEffect;

		// Token: 0x0400A845 RID: 43077
		[Token(Token = "0x400A845")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateContent;

		// Token: 0x0400A846 RID: 43078
		[Token(Token = "0x400A846")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateAutoLayoutCoroutine;

		// Token: 0x0400A847 RID: 43079
		[Token(Token = "0x400A847")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B24 RID: 6948
		[Token(Token = "0x2001B24")]
		private class StationAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600AEF4 RID: 44788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEF4")]
			[Address(RVA = "0x329D980", Offset = "0x329C580", VA = "0x18329D980")]
			public StationAdapter(BuildingUIFloatStationView closure)
			{
			}

			// Token: 0x170014B8 RID: 5304
			// (get) Token: 0x0600AEF5 RID: 44789 RVA: 0x00043368 File Offset: 0x00041568
			[Token(Token = "0x170014B8")]
			public override int count
			{
				[Token(Token = "0x600AEF5")]
				[Address(RVA = "0x329DA00", Offset = "0x329C600", VA = "0x18329DA00", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600AEF6 RID: 44790 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AEF6")]
			[Address(RVA = "0x329D580", Offset = "0x329C180", VA = "0x18329D580", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400A848 RID: 43080
			[Token(Token = "0x400A848")]
			[FieldOffset(Offset = "0x20")]
			private BuildingUIFloatStationView m_closure;

			// Token: 0x0400A849 RID: 43081
			[Token(Token = "0x400A849")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400A84A RID: 43082
			[Token(Token = "0x400A84A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400A84B RID: 43083
			[Token(Token = "0x400A84B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02001B25 RID: 6949
		[Token(Token = "0x2001B25")]
		private class IconAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600AEF7 RID: 44791 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEF7")]
			[Address(RVA = "0x329CFD0", Offset = "0x329BBD0", VA = "0x18329CFD0")]
			public IconAdapter(BuildingUIFloatStationView closure)
			{
			}

			// Token: 0x170014B9 RID: 5305
			// (get) Token: 0x0600AEF8 RID: 44792 RVA: 0x00043380 File Offset: 0x00041580
			[Token(Token = "0x170014B9")]
			public override int count
			{
				[Token(Token = "0x600AEF8")]
				[Address(RVA = "0x329D050", Offset = "0x329BC50", VA = "0x18329D050", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600AEF9 RID: 44793 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AEF9")]
			[Address(RVA = "0x329CE60", Offset = "0x329BA60", VA = "0x18329CE60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400A84C RID: 43084
			[Token(Token = "0x400A84C")]
			[FieldOffset(Offset = "0x20")]
			private BuildingUIFloatStationView m_closure;

			// Token: 0x0400A84D RID: 43085
			[Token(Token = "0x400A84D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400A84E RID: 43086
			[Token(Token = "0x400A84E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400A84F RID: 43087
			[Token(Token = "0x400A84F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
