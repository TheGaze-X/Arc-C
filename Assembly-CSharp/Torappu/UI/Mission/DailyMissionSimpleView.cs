using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using UnityEngine;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004886 RID: 18566
	[Token(Token = "0x2004886")]
	public class DailyMissionSimpleView : MissionSinglePage, ITimeWatcher
	{
		// Token: 0x0601C078 RID: 114808 RVA: 0x000A6FB0 File Offset: 0x000A51B0
		[Token(Token = "0x601C078")]
		[Address(RVA = "0x1563820", Offset = "0x1562420", VA = "0x181563820", Slot = "4")]
		public override bool IsToBeShown(MissionModel stateBean)
		{
			return default(bool);
		}

		// Token: 0x0601C079 RID: 114809 RVA: 0x000A6FC8 File Offset: 0x000A51C8
		[Token(Token = "0x601C079")]
		[Address(RVA = "0x15648F0", Offset = "0x15634F0", VA = "0x1815648F0")]
		private static int _RewardTaskSortingFunc(DailyMissionRewardTask.Data lhs, DailyMissionRewardTask.Data rhs)
		{
			return 0;
		}

		// Token: 0x0601C07A RID: 114810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C07A")]
		[Address(RVA = "0x1563910", Offset = "0x1562510", VA = "0x181563910")]
		private void OnEnable()
		{
		}

		// Token: 0x0601C07B RID: 114811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C07B")]
		[Address(RVA = "0x15638B0", Offset = "0x15624B0", VA = "0x1815638B0")]
		private void OnDisable()
		{
		}

		// Token: 0x0601C07C RID: 114812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C07C")]
		[Address(RVA = "0x15642E0", Offset = "0x1562EE0", VA = "0x1815642E0", Slot = "6")]
		public void UpdateTime(float delta)
		{
		}

		// Token: 0x0601C07D RID: 114813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C07D")]
		[Address(RVA = "0x1563970", Offset = "0x1562570", VA = "0x181563970", Slot = "5")]
		protected override void RefreshView()
		{
		}

		// Token: 0x0601C07E RID: 114814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C07E")]
		[Address(RVA = "0x1564360", Offset = "0x1562F60", VA = "0x181564360")]
		private IList<DailyMissionRewardTask.Data> _ParseRewardListData(out bool allClear)
		{
			return null;
		}

		// Token: 0x0601C07F RID: 114815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C07F")]
		[Address(RVA = "0x1564A00", Offset = "0x1563600", VA = "0x181564A00")]
		public DailyMissionSimpleView()
		{
		}

		// Token: 0x0601C080 RID: 114816 RVA: 0x000A6FE0 File Offset: 0x000A51E0
		[Token(Token = "0x601C080")]
		[Address(RVA = "0x1564210", Offset = "0x1562E10", VA = "0x181564210")]
		private bool <>xLuaBaseProxy_IsToBeShown(MissionModel P0)
		{
			return default(bool);
		}

		// Token: 0x0601C081 RID: 114817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C081")]
		[Address(RVA = "0x1564280", Offset = "0x1562E80", VA = "0x181564280")]
		private void <>xLuaBaseProxy_RefreshView()
		{
		}

		// Token: 0x0402492C RID: 149804
		[Token(Token = "0x402492C")]
		private const int REWARD_PER_FRAME = 1;

		// Token: 0x0402492D RID: 149805
		[Token(Token = "0x402492D")]
		private const int TASK_PER_FRAME = 1;

		// Token: 0x0402492E RID: 149806
		[Token(Token = "0x402492E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DailyMissionRewardTask _reward;

		// Token: 0x0402492F RID: 149807
		[Token(Token = "0x402492F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _rewardContainer;

		// Token: 0x04024930 RID: 149808
		[Token(Token = "0x4024930")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Confirm All")]
		private Transform _rightPanel;

		// Token: 0x04024931 RID: 149809
		[Token(Token = "0x4024931")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Confirm All")]
		private DailyMissionConfirmAllTask _confirmAll;

		// Token: 0x04024932 RID: 149810
		[Token(Token = "0x4024932")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Confirm All")]
		private RectTransform _scrollView;

		// Token: 0x04024933 RID: 149811
		[Token(Token = "0x4024933")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip(" Top position of Scroll View when player can confirm all.")]
		[Group("Confirm All")]
		private float _topPosition;

		// Token: 0x04024934 RID: 149812
		[Token(Token = "0x4024934")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private DailyMissionTask _task;

		// Token: 0x04024935 RID: 149813
		[Token(Token = "0x4024935")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _taskContainer;

		// Token: 0x04024936 RID: 149814
		[Token(Token = "0x4024936")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private DailyMissionSimpleView.DailyOrWeekly _dataType;

		// Token: 0x04024937 RID: 149815
		[Token(Token = "0x4024937")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private DailyMissionSimpleView.MissionAllClear _missionAllClear;

		// Token: 0x04024938 RID: 149816
		[Token(Token = "0x4024938")]
		[FieldOffset(Offset = "0x80")]
		private DailyMissionConfirmAllTask m_missionConfirmAll;

		// Token: 0x04024939 RID: 149817
		[Token(Token = "0x4024939")]
		[FieldOffset(Offset = "0x88")]
		private DailyMissionSimpleView.RewardListAdapter m_rewardAdapter;

		// Token: 0x0402493A RID: 149818
		[Token(Token = "0x402493A")]
		[FieldOffset(Offset = "0x90")]
		private DailyMissionSimpleView.TaskListAdapter m_taskAdapter;

		// Token: 0x0402493B RID: 149819
		[Token(Token = "0x402493B")]
		[FieldOffset(Offset = "0x98")]
		private AsyncGameObjectLoader m_objLoader;

		// Token: 0x0402493C RID: 149820
		[Token(Token = "0x402493C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsToBeShown;

		// Token: 0x0402493D RID: 149821
		[Token(Token = "0x402493D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RewardTaskSortingFunc;

		// Token: 0x0402493E RID: 149822
		[Token(Token = "0x402493E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0402493F RID: 149823
		[Token(Token = "0x402493F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04024940 RID: 149824
		[Token(Token = "0x4024940")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x04024941 RID: 149825
		[Token(Token = "0x4024941")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshView;

		// Token: 0x04024942 RID: 149826
		[Token(Token = "0x4024942")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ParseRewardListData;

		// Token: 0x04024943 RID: 149827
		[Token(Token = "0x4024943")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004887 RID: 18567
		[Token(Token = "0x2004887")]
		public enum DailyOrWeekly
		{
			// Token: 0x04024945 RID: 149829
			[Token(Token = "0x4024945")]
			DAILY,
			// Token: 0x04024946 RID: 149830
			[Token(Token = "0x4024946")]
			WEEKLY
		}

		// Token: 0x02004888 RID: 18568
		[Token(Token = "0x2004888")]
		[Serializable]
		public class MissionAllClear
		{
			// Token: 0x0601C082 RID: 114818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C082")]
			[Address(RVA = "0x15690A0", Offset = "0x1567CA0", VA = "0x1815690A0")]
			public void Setup(bool allClear)
			{
			}

			// Token: 0x0601C083 RID: 114819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C083")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MissionAllClear()
			{
			}

			// Token: 0x04024947 RID: 149831
			[Token(Token = "0x4024947")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private CanvasGroup _canvasGroup;

			// Token: 0x04024948 RID: 149832
			[Token(Token = "0x4024948")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _panel;

			// Token: 0x04024949 RID: 149833
			[Token(Token = "0x4024949")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float _transAlpha;
		}

		// Token: 0x02004889 RID: 18569
		[Token(Token = "0x2004889")]
		private class RewardListAdapter : AsyncDataViewListAdapter<DailyMissionRewardTask, DailyMissionRewardTask.Data>
		{
			// Token: 0x0601C084 RID: 114820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C084")]
			[Address(RVA = "0x15709B0", Offset = "0x156F5B0", VA = "0x1815709B0")]
			public RewardListAdapter(DailyMissionSimpleView closure)
			{
			}

			// Token: 0x0601C085 RID: 114821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C085")]
			[Address(RVA = "0x1570930", Offset = "0x156F530", VA = "0x181570930")]
			public void SetParams(IList<DailyMissionRewardTask.Data> dataList)
			{
			}

			// Token: 0x0601C086 RID: 114822 RVA: 0x000A6FF8 File Offset: 0x000A51F8
			[Token(Token = "0x601C086")]
			[Address(RVA = "0x1570720", Offset = "0x156F320", VA = "0x181570720", Slot = "4")]
			protected override int GetCount()
			{
				return 0;
			}

			// Token: 0x0601C087 RID: 114823 RVA: 0x000A7010 File Offset: 0x000A5210
			[Token(Token = "0x601C087")]
			[Address(RVA = "0x1570790", Offset = "0x156F390", VA = "0x181570790", Slot = "5")]
			protected override DailyMissionRewardTask.Data GetData(int index)
			{
				return default(DailyMissionRewardTask.Data);
			}

			// Token: 0x0601C088 RID: 114824 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C088")]
			[Address(RVA = "0x1570850", Offset = "0x156F450", VA = "0x181570850", Slot = "7")]
			protected override Transform GetListContainer()
			{
				return null;
			}

			// Token: 0x0601C089 RID: 114825 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C089")]
			[Address(RVA = "0x15708C0", Offset = "0x156F4C0", VA = "0x1815708C0", Slot = "6")]
			protected override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601C08A RID: 114826 RVA: 0x000A7028 File Offset: 0x000A5228
			[Token(Token = "0x601C08A")]
			[Address(RVA = "0x15706C0", Offset = "0x156F2C0", VA = "0x1815706C0", Slot = "8")]
			protected override uint CostPerItem()
			{
				return 0U;
			}

			// Token: 0x0402494A RID: 149834
			[Token(Token = "0x402494A")]
			[FieldOffset(Offset = "0x18")]
			private DailyMissionSimpleView m_closure;

			// Token: 0x0402494B RID: 149835
			[Token(Token = "0x402494B")]
			[FieldOffset(Offset = "0x20")]
			private IList<DailyMissionRewardTask.Data> m_dataList;

			// Token: 0x0402494C RID: 149836
			[Token(Token = "0x402494C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402494D RID: 149837
			[Token(Token = "0x402494D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetParams;

			// Token: 0x0402494E RID: 149838
			[Token(Token = "0x402494E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetCount;

			// Token: 0x0402494F RID: 149839
			[Token(Token = "0x402494F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetData;

			// Token: 0x04024950 RID: 149840
			[Token(Token = "0x4024950")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetListContainer;

			// Token: 0x04024951 RID: 149841
			[Token(Token = "0x4024951")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04024952 RID: 149842
			[Token(Token = "0x4024952")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CostPerItem;
		}

		// Token: 0x0200488A RID: 18570
		[Token(Token = "0x200488A")]
		private class TaskListAdapter : AsyncDataViewListAdapter<DailyMissionTask, MissionViewModel>
		{
			// Token: 0x0601C08B RID: 114827 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C08B")]
			[Address(RVA = "0x1575940", Offset = "0x1574540", VA = "0x181575940")]
			public TaskListAdapter(DailyMissionSimpleView closure)
			{
			}

			// Token: 0x0601C08C RID: 114828 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C08C")]
			[Address(RVA = "0x15758C0", Offset = "0x15744C0", VA = "0x1815758C0")]
			public void SetParams(IList<MissionViewModel> dataList)
			{
			}

			// Token: 0x0601C08D RID: 114829 RVA: 0x000A7040 File Offset: 0x000A5240
			[Token(Token = "0x601C08D")]
			[Address(RVA = "0x1575650", Offset = "0x1574250", VA = "0x181575650", Slot = "4")]
			protected override int GetCount()
			{
				return 0;
			}

			// Token: 0x0601C08E RID: 114830 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C08E")]
			[Address(RVA = "0x15756C0", Offset = "0x15742C0", VA = "0x1815756C0", Slot = "5")]
			protected override MissionViewModel GetData(int index)
			{
				return null;
			}

			// Token: 0x0601C08F RID: 114831 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C08F")]
			[Address(RVA = "0x15757E0", Offset = "0x15743E0", VA = "0x1815757E0", Slot = "7")]
			protected override Transform GetListContainer()
			{
				return null;
			}

			// Token: 0x0601C090 RID: 114832 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C090")]
			[Address(RVA = "0x1575850", Offset = "0x1574450", VA = "0x181575850", Slot = "6")]
			protected override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601C091 RID: 114833 RVA: 0x000A7058 File Offset: 0x000A5258
			[Token(Token = "0x601C091")]
			[Address(RVA = "0x15755F0", Offset = "0x15741F0", VA = "0x1815755F0", Slot = "8")]
			protected override uint CostPerItem()
			{
				return 0U;
			}

			// Token: 0x04024953 RID: 149843
			[Token(Token = "0x4024953")]
			[FieldOffset(Offset = "0x18")]
			private DailyMissionSimpleView m_closure;

			// Token: 0x04024954 RID: 149844
			[Token(Token = "0x4024954")]
			[FieldOffset(Offset = "0x20")]
			private IList<MissionViewModel> m_dataList;

			// Token: 0x04024955 RID: 149845
			[Token(Token = "0x4024955")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04024956 RID: 149846
			[Token(Token = "0x4024956")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetParams;

			// Token: 0x04024957 RID: 149847
			[Token(Token = "0x4024957")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetCount;

			// Token: 0x04024958 RID: 149848
			[Token(Token = "0x4024958")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetData;

			// Token: 0x04024959 RID: 149849
			[Token(Token = "0x4024959")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetListContainer;

			// Token: 0x0402495A RID: 149850
			[Token(Token = "0x402495A")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402495B RID: 149851
			[Token(Token = "0x402495B")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CostPerItem;
		}
	}
}
