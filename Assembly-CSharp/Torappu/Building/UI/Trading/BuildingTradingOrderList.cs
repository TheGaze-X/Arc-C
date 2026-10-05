using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C39 RID: 7225
	[Token(Token = "0x2001C39")]
	public class BuildingTradingOrderList : DataBinder<TOrderSlotGroupViewProperty>, IHotfixable
	{
		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x0600B3CA RID: 46026 RVA: 0x00044430 File Offset: 0x00042630
		// (set) Token: 0x0600B3CB RID: 46027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001590")]
		public BuildingTradingOrderList.Options options
		{
			[Token(Token = "0x600B3CA")]
			[Address(RVA = "0x32DB500", Offset = "0x32DA100", VA = "0x1832DB500")]
			[CompilerGenerated]
			private get
			{
				return default(BuildingTradingOrderList.Options);
			}
			[Token(Token = "0x600B3CB")]
			[Address(RVA = "0x32DB590", Offset = "0x32DA190", VA = "0x1832DB590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600B3CC RID: 46028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3CC")]
		[Address(RVA = "0x32D9510", Offset = "0x32D8110", VA = "0x1832D9510")]
		private void _OnOrderDeleteClicked(long orderId)
		{
		}

		// Token: 0x0600B3CD RID: 46029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3CD")]
		[Address(RVA = "0x32D9650", Offset = "0x32D8250", VA = "0x1832D9650")]
		private void _OnOrderFinishClicked(long orderId)
		{
		}

		// Token: 0x0600B3CE RID: 46030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3CE")]
		[Address(RVA = "0x32D93D0", Offset = "0x32D7FD0", VA = "0x1832D93D0")]
		private void _OnLaborAccelClicked()
		{
		}

		// Token: 0x0600B3CF RID: 46031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3CF")]
		[Address(RVA = "0x32D73D0", Offset = "0x32D5FD0", VA = "0x1832D73D0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600B3D0 RID: 46032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3D0")]
		[Address(RVA = "0x32D74D0", Offset = "0x32D60D0", VA = "0x1832D74D0", Slot = "7")]
		public override void OnValueChanged(TOrderSlotGroupViewProperty property)
		{
		}

		// Token: 0x0600B3D1 RID: 46033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3D1")]
		[Address(RVA = "0x32D7370", Offset = "0x32D5F70", VA = "0x1832D7370")]
		public void NotifyOrdersDeletedOrDelivered()
		{
		}

		// Token: 0x0600B3D2 RID: 46034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3D2")]
		[Address(RVA = "0x32D8AC0", Offset = "0x32D76C0", VA = "0x1832D8AC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B3D3 RID: 46035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3D3")]
		[Address(RVA = "0x32DA1A0", Offset = "0x32D8DA0", VA = "0x1832DA1A0")]
		private void _TransitWhenDataChanged(TOrderSlotGroupViewModel viewModel)
		{
		}

		// Token: 0x0600B3D4 RID: 46036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3D4")]
		[Address(RVA = "0x32D9FE0", Offset = "0x32D8BE0", VA = "0x1832D9FE0")]
		private void _RenderInfo()
		{
		}

		// Token: 0x0600B3D5 RID: 46037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3D5")]
		[Address(RVA = "0x32DA9F0", Offset = "0x32D95F0", VA = "0x1832DA9F0")]
		private IEnumerator _UpdateLayoutCoroutine()
		{
			return null;
		}

		// Token: 0x0600B3D6 RID: 46038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3D6")]
		[Address(RVA = "0x32DA5A0", Offset = "0x32D91A0", VA = "0x1832DA5A0")]
		private void _TryRegisterAVGFirstOrder()
		{
		}

		// Token: 0x0600B3D7 RID: 46039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3D7")]
		[Address(RVA = "0x32DAAA0", Offset = "0x32D96A0", VA = "0x1832DAAA0")]
		private void _UpdateViaDeformation()
		{
		}

		// Token: 0x0600B3D8 RID: 46040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3D8")]
		[Address(RVA = "0x32DAF40", Offset = "0x32D9B40", VA = "0x1832DAF40")]
		private void _UpdateViaDeltaWithActionList()
		{
		}

		// Token: 0x0600B3D9 RID: 46041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3D9")]
		[Address(RVA = "0x32D9790", Offset = "0x32D8390", VA = "0x1832D9790")]
		private void _ParseActionList()
		{
		}

		// Token: 0x0600B3DA RID: 46042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3DA")]
		[Address(RVA = "0x32D77F0", Offset = "0x32D63F0", VA = "0x1832D77F0")]
		private void _ApplyActionsToViews()
		{
		}

		// Token: 0x0600B3DB RID: 46043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3DB")]
		[Address(RVA = "0x32D9D80", Offset = "0x32D8980", VA = "0x1832D9D80")]
		private void _RemoveRedunentViews()
		{
		}

		// Token: 0x0600B3DC RID: 46044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3DC")]
		[Address(RVA = "0x32DAFF0", Offset = "0x32D9BF0", VA = "0x1832DAFF0")]
		private void _ValidateOrderViews(List<TOrderSlotStruct> orderStatusList)
		{
		}

		// Token: 0x0600B3DD RID: 46045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3DD")]
		[Address(RVA = "0x32D8610", Offset = "0x32D7210", VA = "0x1832D8610")]
		private void _FocusCompleteIfNeeded()
		{
		}

		// Token: 0x0600B3DE RID: 46046 RVA: 0x00044448 File Offset: 0x00042648
		[Token(Token = "0x600B3DE")]
		[Address(RVA = "0x32D8400", Offset = "0x32D7000", VA = "0x1832D8400")]
		private bool _CheckIfViewVisibleInScroll(BuildingTradingOrderView orderView)
		{
			return default(bool);
		}

		// Token: 0x0600B3DF RID: 46047 RVA: 0x00044460 File Offset: 0x00042660
		[Token(Token = "0x600B3DF")]
		[Address(RVA = "0x32D8210", Offset = "0x32D6E10", VA = "0x1832D8210")]
		private float _CalcScrollProgressOfOrder(BuildingTradingOrderView orderView)
		{
			return 0f;
		}

		// Token: 0x0600B3E0 RID: 46048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3E0")]
		[Address(RVA = "0x32D8A40", Offset = "0x32D7640", VA = "0x1832D8A40")]
		private void _FocusToStart()
		{
		}

		// Token: 0x0600B3E1 RID: 46049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3E1")]
		[Address(RVA = "0x32DA6D0", Offset = "0x32D92D0", VA = "0x1832DA6D0")]
		private void _TweenScroll(float progress, float duration = 0.23f, float delay = 0f)
		{
		}

		// Token: 0x0600B3E2 RID: 46050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3E2")]
		[Address(RVA = "0x32DB2B0", Offset = "0x32D9EB0", VA = "0x1832DB2B0")]
		private IEnumerator _WaitTrainsitionCoroutine()
		{
			return null;
		}

		// Token: 0x0600B3E3 RID: 46051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3E3")]
		[Address(RVA = "0x32D8F90", Offset = "0x32D7B90", VA = "0x1832D8F90")]
		private void _OnDataChangedFinish()
		{
		}

		// Token: 0x0600B3E4 RID: 46052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3E4")]
		[Address(RVA = "0x32D8B40", Offset = "0x32D7740", VA = "0x1832D8B40")]
		private void _LogErrorWhenUpdateActionList(string info)
		{
		}

		// Token: 0x0600B3E5 RID: 46053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3E5")]
		[Address(RVA = "0x32D7630", Offset = "0x32D6230", VA = "0x1832D7630")]
		private BuildingTradingOrderView _AllocOrderView()
		{
			return null;
		}

		// Token: 0x0600B3E6 RID: 46054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3E6")]
		[Address(RVA = "0x32D9CC0", Offset = "0x32D88C0", VA = "0x1832D9CC0")]
		private void _RecycleOrderView(BuildingTradingOrderView orderView)
		{
		}

		// Token: 0x0600B3E7 RID: 46055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3E7")]
		[Address(RVA = "0x32DB360", Offset = "0x32D9F60", VA = "0x1832DB360")]
		public BuildingTradingOrderList()
		{
		}

		// Token: 0x0400AF4D RID: 44877
		[Token(Token = "0x400AF4D")]
		private const float SCROLL_TWEEN_DUR = 0.23f;

		// Token: 0x0400AF4E RID: 44878
		[Token(Token = "0x400AF4E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _orderContainer;

		// Token: 0x0400AF4F RID: 44879
		[Token(Token = "0x400AF4F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingTradingOrderView _orderPrefab;

		// Token: 0x0400AF50 RID: 44880
		[Token(Token = "0x400AF50")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollRect _orderScroll;

		// Token: 0x0400AF51 RID: 44881
		[Token(Token = "0x400AF51")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textOrderNum;

		// Token: 0x0400AF52 RID: 44882
		[Token(Token = "0x400AF52")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textOrderLimit;

		// Token: 0x0400AF53 RID: 44883
		[Token(Token = "0x400AF53")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _orderNumLine;

		// Token: 0x0400AF54 RID: 44884
		[Token(Token = "0x400AF54")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ScrollRectSoftMask _scrollMask;

		// Token: 0x0400AF55 RID: 44885
		[Token(Token = "0x400AF55")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isTransiting;

		// Token: 0x0400AF56 RID: 44886
		[Token(Token = "0x400AF56")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_scrollTween;

		// Token: 0x0400AF57 RID: 44887
		[Token(Token = "0x400AF57")]
		[FieldOffset(Offset = "0x68")]
		private TOrderSlotGroupViewModel m_pendingChanges;

		// Token: 0x0400AF58 RID: 44888
		[Token(Token = "0x400AF58")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x0400AF59 RID: 44889
		[Token(Token = "0x400AF59")]
		[FieldOffset(Offset = "0x78")]
		private string m_roomIdCache;

		// Token: 0x0400AF5A RID: 44890
		[Token(Token = "0x400AF5A")]
		[FieldOffset(Offset = "0x80")]
		private BuildingTradingOrderList.ViewModelCache m_curModelCache;

		// Token: 0x0400AF5B RID: 44891
		[Token(Token = "0x400AF5B")]
		[FieldOffset(Offset = "0x88")]
		private List<BuildingTradingOrderView> m_orderViews;

		// Token: 0x0400AF5C RID: 44892
		[Token(Token = "0x400AF5C")]
		[FieldOffset(Offset = "0x90")]
		private bool m_focusCompleteOrderFlag;

		// Token: 0x0400AF5D RID: 44893
		[Token(Token = "0x400AF5D")]
		[FieldOffset(Offset = "0x98")]
		private List<BuildingTradingOrderList.OrderActionStruct> m_actionList;

		// Token: 0x0400AF5E RID: 44894
		[Token(Token = "0x400AF5E")]
		[FieldOffset(Offset = "0xA0")]
		private List<BuildingTradingOrderView> m_sharedList;

		// Token: 0x0400AF60 RID: 44896
		[Token(Token = "0x400AF60")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_options;

		// Token: 0x0400AF61 RID: 44897
		[Token(Token = "0x400AF61")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_options;

		// Token: 0x0400AF62 RID: 44898
		[Token(Token = "0x400AF62")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnOrderDeleteClicked;

		// Token: 0x0400AF63 RID: 44899
		[Token(Token = "0x400AF63")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnOrderFinishClicked;

		// Token: 0x0400AF64 RID: 44900
		[Token(Token = "0x400AF64")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnLaborAccelClicked;

		// Token: 0x0400AF65 RID: 44901
		[Token(Token = "0x400AF65")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400AF66 RID: 44902
		[Token(Token = "0x400AF66")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400AF67 RID: 44903
		[Token(Token = "0x400AF67")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_NotifyOrdersDeletedOrDelivered;

		// Token: 0x0400AF68 RID: 44904
		[Token(Token = "0x400AF68")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400AF69 RID: 44905
		[Token(Token = "0x400AF69")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TransitWhenDataChanged;

		// Token: 0x0400AF6A RID: 44906
		[Token(Token = "0x400AF6A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderInfo;

		// Token: 0x0400AF6B RID: 44907
		[Token(Token = "0x400AF6B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateLayoutCoroutine;

		// Token: 0x0400AF6C RID: 44908
		[Token(Token = "0x400AF6C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TryRegisterAVGFirstOrder;

		// Token: 0x0400AF6D RID: 44909
		[Token(Token = "0x400AF6D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateViaDeformation;

		// Token: 0x0400AF6E RID: 44910
		[Token(Token = "0x400AF6E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateViaDeltaWithActionList;

		// Token: 0x0400AF6F RID: 44911
		[Token(Token = "0x400AF6F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ParseActionList;

		// Token: 0x0400AF70 RID: 44912
		[Token(Token = "0x400AF70")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ApplyActionsToViews;

		// Token: 0x0400AF71 RID: 44913
		[Token(Token = "0x400AF71")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RemoveRedunentViews;

		// Token: 0x0400AF72 RID: 44914
		[Token(Token = "0x400AF72")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ValidateOrderViews;

		// Token: 0x0400AF73 RID: 44915
		[Token(Token = "0x400AF73")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__FocusCompleteIfNeeded;

		// Token: 0x0400AF74 RID: 44916
		[Token(Token = "0x400AF74")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CheckIfViewVisibleInScroll;

		// Token: 0x0400AF75 RID: 44917
		[Token(Token = "0x400AF75")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CalcScrollProgressOfOrder;

		// Token: 0x0400AF76 RID: 44918
		[Token(Token = "0x400AF76")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__FocusToStart;

		// Token: 0x0400AF77 RID: 44919
		[Token(Token = "0x400AF77")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__TweenScroll;

		// Token: 0x0400AF78 RID: 44920
		[Token(Token = "0x400AF78")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__WaitTrainsitionCoroutine;

		// Token: 0x0400AF79 RID: 44921
		[Token(Token = "0x400AF79")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnDataChangedFinish;

		// Token: 0x0400AF7A RID: 44922
		[Token(Token = "0x400AF7A")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__LogErrorWhenUpdateActionList;

		// Token: 0x0400AF7B RID: 44923
		[Token(Token = "0x400AF7B")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__AllocOrderView;

		// Token: 0x0400AF7C RID: 44924
		[Token(Token = "0x400AF7C")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__RecycleOrderView;

		// Token: 0x0400AF7D RID: 44925
		[Token(Token = "0x400AF7D")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001C3A RID: 7226
		[Token(Token = "0x2001C3A")]
		public struct Options
		{
			// Token: 0x0400AF7E RID: 44926
			[Token(Token = "0x400AF7E")]
			[FieldOffset(Offset = "0x0")]
			public Action<long> onDeleteClicked;

			// Token: 0x0400AF7F RID: 44927
			[Token(Token = "0x400AF7F")]
			[FieldOffset(Offset = "0x8")]
			public Action<long> onFinishClicked;

			// Token: 0x0400AF80 RID: 44928
			[Token(Token = "0x400AF80")]
			[FieldOffset(Offset = "0x10")]
			public Action onLaborAccelClicked;
		}

		// Token: 0x02001C3B RID: 7227
		[Token(Token = "0x2001C3B")]
		private struct OrderActionStruct
		{
			// Token: 0x0600B3EB RID: 46059 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3EB")]
			[Address(RVA = "0x32FA8C0", Offset = "0x32F94C0", VA = "0x1832FA8C0")]
			public OrderActionStruct(OrderViewAction action, int index, BuildingTradingOrderView view)
			{
			}

			// Token: 0x0400AF81 RID: 44929
			[Token(Token = "0x400AF81")]
			[FieldOffset(Offset = "0x0")]
			public OrderViewAction action;

			// Token: 0x0400AF82 RID: 44930
			[Token(Token = "0x400AF82")]
			[FieldOffset(Offset = "0x8")]
			public BuildingTradingOrderView view;

			// Token: 0x0400AF83 RID: 44931
			[Token(Token = "0x400AF83")]
			[FieldOffset(Offset = "0x10")]
			public int dataIndex;
		}

		// Token: 0x02001C3C RID: 7228
		[Token(Token = "0x2001C3C")]
		private class ViewModelCache
		{
			// Token: 0x0600B3EC RID: 46060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3EC")]
			[Address(RVA = "0x33032E0", Offset = "0x3301EE0", VA = "0x1833032E0")]
			public void LoadData(TOrderSlotGroupViewModel groupModel)
			{
			}

			// Token: 0x0600B3ED RID: 46061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3ED")]
			[Address(RVA = "0x3303410", Offset = "0x3302010", VA = "0x183303410")]
			public ViewModelCache()
			{
			}

			// Token: 0x0400AF84 RID: 44932
			[Token(Token = "0x400AF84")]
			[FieldOffset(Offset = "0x10")]
			public int nonEmptySlotCount;

			// Token: 0x0400AF85 RID: 44933
			[Token(Token = "0x400AF85")]
			[FieldOffset(Offset = "0x14")]
			public bool hasGainingSlot;

			// Token: 0x0400AF86 RID: 44934
			[Token(Token = "0x400AF86")]
			[FieldOffset(Offset = "0x18")]
			public List<TOrderSlotStruct> slots;

			// Token: 0x0400AF87 RID: 44935
			[Token(Token = "0x400AF87")]
			[FieldOffset(Offset = "0x20")]
			public TradingInfoViewStruct info;
		}
	}
}
