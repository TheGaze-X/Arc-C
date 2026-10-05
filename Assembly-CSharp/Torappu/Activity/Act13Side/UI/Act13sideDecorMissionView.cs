using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act13Side.UI
{
	// Token: 0x02007A4C RID: 31308
	[Token(Token = "0x2007A4C")]
	public class Act13sideDecorMissionView : DataBinder<Act13sideZoneDescGroupViewProperty>
	{
		// Token: 0x0602BDC4 RID: 179652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDC4")]
		[Address(RVA = "0x27CAA20", Offset = "0x27C9620", VA = "0x1827CAA20")]
		public void Init()
		{
		}

		// Token: 0x0602BDC5 RID: 179653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDC5")]
		[Address(RVA = "0x27CAC70", Offset = "0x27C9870", VA = "0x1827CAC70", Slot = "7")]
		public override void OnValueChanged(Act13sideZoneDescGroupViewProperty property)
		{
		}

		// Token: 0x0602BDC6 RID: 179654 RVA: 0x000DD6E8 File Offset: 0x000DB8E8
		[Token(Token = "0x602BDC6")]
		[Address(RVA = "0x27CAEE0", Offset = "0x27C9AE0", VA = "0x1827CAEE0")]
		private bool _TryRenderMission()
		{
			return default(bool);
		}

		// Token: 0x0602BDC7 RID: 179655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BDC7")]
		[Address(RVA = "0x27CAD40", Offset = "0x27C9940", VA = "0x1827CAD40")]
		private Act13SideData.DailyMissionData _TryGetDailyMissionData(string missionId)
		{
			return null;
		}

		// Token: 0x0602BDC8 RID: 179656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDC8")]
		[Address(RVA = "0x27CAE50", Offset = "0x27C9A50", VA = "0x1827CAE50")]
		private void _TryLoadMissionDBData(string actId)
		{
		}

		// Token: 0x0602BDC9 RID: 179657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDC9")]
		[Address(RVA = "0x27CA9A0", Offset = "0x27C95A0", VA = "0x1827CA9A0")]
		public void EventOnShowMissionBtnClicked()
		{
		}

		// Token: 0x0602BDCA RID: 179658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDCA")]
		[Address(RVA = "0x27CA930", Offset = "0x27C9530", VA = "0x1827CA930")]
		public void EventOnHideMissionBtnClicked()
		{
		}

		// Token: 0x0602BDCB RID: 179659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDCB")]
		[Address(RVA = "0x27CB0F0", Offset = "0x27C9CF0", VA = "0x1827CB0F0")]
		public Act13sideDecorMissionView()
		{
		}

		// Token: 0x0403F83C RID: 260156
		[Token(Token = "0x403F83C")]
		private const int MAX_MISSION_ITEM_NUM = 3;

		// Token: 0x0403F83D RID: 260157
		[Token(Token = "0x403F83D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelBtnFullScreen;

		// Token: 0x0403F83E RID: 260158
		[Token(Token = "0x403F83E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _panelMissionBtn;

		// Token: 0x0403F83F RID: 260159
		[Token(Token = "0x403F83F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x0403F840 RID: 260160
		[Token(Token = "0x403F840")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _panelRectMask;

		// Token: 0x0403F841 RID: 260161
		[Token(Token = "0x403F841")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _missionListCanvasGroup;

		// Token: 0x0403F842 RID: 260162
		[Token(Token = "0x403F842")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _panelMissionList;

		// Token: 0x0403F843 RID: 260163
		[Token(Token = "0x403F843")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Mission Anchored Position")]
		private Vector2 _defaultPos;

		// Token: 0x0403F844 RID: 260164
		[Token(Token = "0x403F844")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Mission Anchored Position")]
		private Vector2 _showPos;

		// Token: 0x0403F845 RID: 260165
		[Token(Token = "0x403F845")]
		[FieldOffset(Offset = "0x60")]
		private List<Act13SideData.DailyMissionData> m_dailyMissionDataList;

		// Token: 0x0403F846 RID: 260166
		[Token(Token = "0x403F846")]
		[FieldOffset(Offset = "0x68")]
		private Act13sideDecorMissionView.MissionSwitchTween m_missionSwitchTween;

		// Token: 0x0403F847 RID: 260167
		[Token(Token = "0x403F847")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInit;

		// Token: 0x0403F848 RID: 260168
		[Token(Token = "0x403F848")]
		[FieldOffset(Offset = "0x78")]
		private Act13sideDecorMissionView.Adapter m_missionListAdapter;

		// Token: 0x0403F849 RID: 260169
		[Token(Token = "0x403F849")]
		[FieldOffset(Offset = "0x80")]
		private string m_actId;

		// Token: 0x0403F84A RID: 260170
		[Token(Token = "0x403F84A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403F84B RID: 260171
		[Token(Token = "0x403F84B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403F84C RID: 260172
		[Token(Token = "0x403F84C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryRenderMission;

		// Token: 0x0403F84D RID: 260173
		[Token(Token = "0x403F84D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryGetDailyMissionData;

		// Token: 0x0403F84E RID: 260174
		[Token(Token = "0x403F84E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryLoadMissionDBData;

		// Token: 0x0403F84F RID: 260175
		[Token(Token = "0x403F84F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnShowMissionBtnClicked;

		// Token: 0x0403F850 RID: 260176
		[Token(Token = "0x403F850")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnHideMissionBtnClicked;

		// Token: 0x0403F851 RID: 260177
		[Token(Token = "0x403F851")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A4D RID: 31309
		[Token(Token = "0x2007A4D")]
		private class MissionSwitchTween : UISwitchTween
		{
			// Token: 0x0602BDCC RID: 179660 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BDCC")]
			[Address(RVA = "0x27D5280", Offset = "0x27D3E80", VA = "0x1827D5280")]
			public MissionSwitchTween(Act13sideDecorMissionView closure)
			{
			}

			// Token: 0x0602BDCD RID: 179661 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BDCD")]
			[Address(RVA = "0x27D4D80", Offset = "0x27D3980", VA = "0x1827D4D80", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602BDCE RID: 179662 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BDCE")]
			[Address(RVA = "0x27D4EF0", Offset = "0x27D3AF0", VA = "0x1827D4EF0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602BDCF RID: 179663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BDCF")]
			[Address(RVA = "0x27D4D00", Offset = "0x27D3900", VA = "0x1827D4D00", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0602BDD0 RID: 179664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BDD0")]
			[Address(RVA = "0x27D4C80", Offset = "0x27D3880", VA = "0x1827D4C80", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0602BDD1 RID: 179665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BDD1")]
			[Address(RVA = "0x27D4BE0", Offset = "0x27D37E0", VA = "0x1827D4BE0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0602BDD2 RID: 179666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BDD2")]
			[Address(RVA = "0x27D50E0", Offset = "0x27D3CE0", VA = "0x1827D50E0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602BDD3 RID: 179667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BDD3")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0602BDD4 RID: 179668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BDD4")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0602BDD5 RID: 179669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BDD5")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0602BDD6 RID: 179670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BDD6")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403F852 RID: 260178
			[Token(Token = "0x403F852")]
			[FieldOffset(Offset = "0x48")]
			private Act13sideDecorMissionView m_closure;

			// Token: 0x0403F853 RID: 260179
			[Token(Token = "0x403F853")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403F854 RID: 260180
			[Token(Token = "0x403F854")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403F855 RID: 260181
			[Token(Token = "0x403F855")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403F856 RID: 260182
			[Token(Token = "0x403F856")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0403F857 RID: 260183
			[Token(Token = "0x403F857")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0403F858 RID: 260184
			[Token(Token = "0x403F858")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0403F859 RID: 260185
			[Token(Token = "0x403F859")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02007A4E RID: 31310
		[Token(Token = "0x2007A4E")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170066D3 RID: 26323
			// (get) Token: 0x0602BDD7 RID: 179671 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602BDD8 RID: 179672 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170066D3")]
			public List<PlayerActivity.PlayerAct13sideActivity.DailyMissionWithProgressData> data
			{
				[Token(Token = "0x602BDD7")]
				[Address(RVA = "0x27D1960", Offset = "0x27D0560", VA = "0x1827D1960")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x602BDD8")]
				[Address(RVA = "0x27D19C0", Offset = "0x27D05C0", VA = "0x1827D19C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170066D4 RID: 26324
			// (get) Token: 0x0602BDD9 RID: 179673 RVA: 0x000DD700 File Offset: 0x000DB900
			[Token(Token = "0x170066D4")]
			public override int count
			{
				[Token(Token = "0x602BDD9")]
				[Address(RVA = "0x27D1830", Offset = "0x27D0430", VA = "0x1827D1830", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602BDDA RID: 179674 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BDDA")]
			[Address(RVA = "0x27D17B0", Offset = "0x27D03B0", VA = "0x1827D17B0")]
			public Adapter(Act13sideDecorMissionView closure)
			{
			}

			// Token: 0x0602BDDB RID: 179675 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BDDB")]
			[Address(RVA = "0x27D10C0", Offset = "0x27CFCC0", VA = "0x1827D10C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403F85A RID: 260186
			[Token(Token = "0x403F85A")]
			[FieldOffset(Offset = "0x20")]
			private Act13sideDecorMissionView m_closure;

			// Token: 0x0403F85C RID: 260188
			[Token(Token = "0x403F85C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_data;

			// Token: 0x0403F85D RID: 260189
			[Token(Token = "0x403F85D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_data;

			// Token: 0x0403F85E RID: 260190
			[Token(Token = "0x403F85E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403F85F RID: 260191
			[Token(Token = "0x403F85F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403F860 RID: 260192
			[Token(Token = "0x403F860")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
