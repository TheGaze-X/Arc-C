using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055AC RID: 21932
	[Token(Token = "0x20055AC")]
	public class RL05CopperPackageMainView : DataBinder<RL05CopperPackageProperty>
	{
		// Token: 0x17004B82 RID: 19330
		// (get) Token: 0x06020345 RID: 131909 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020344 RID: 131908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B82")]
		public Action<string> onClickCopper
		{
			[Token(Token = "0x6020345")]
			[Address(RVA = "0x1A4E4C0", Offset = "0x1A4D0C0", VA = "0x181A4E4C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6020344")]
			[Address(RVA = "0x1A4E580", Offset = "0x1A4D180", VA = "0x181A4E580")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004B83 RID: 19331
		// (get) Token: 0x06020347 RID: 131911 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020346 RID: 131910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B83")]
		public Action onRefreshCopper
		{
			[Token(Token = "0x6020347")]
			[Address(RVA = "0x1A4E520", Offset = "0x1A4D120", VA = "0x181A4E520")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6020346")]
			[Address(RVA = "0x1A4E600", Offset = "0x1A4D200", VA = "0x181A4E600")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06020348 RID: 131912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020348")]
		[Address(RVA = "0x1A4D7A0", Offset = "0x1A4C3A0", VA = "0x181A4D7A0", Slot = "7")]
		public override void OnValueChanged(RL05CopperPackageProperty property)
		{
		}

		// Token: 0x06020349 RID: 131913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020349")]
		[Address(RVA = "0x1A4E290", Offset = "0x1A4CE90", VA = "0x181A4E290")]
		private void _SetTexts(IList<Text> texts, string content)
		{
		}

		// Token: 0x0602034A RID: 131914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602034A")]
		[Address(RVA = "0x1A4E080", Offset = "0x1A4CC80", VA = "0x181A4E080")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602034B RID: 131915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602034B")]
		[Address(RVA = "0x1A4E020", Offset = "0x1A4CC20", VA = "0x181A4E020")]
		private ILoadAsset _GetAssetLoader()
		{
			return null;
		}

		// Token: 0x0602034C RID: 131916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602034C")]
		[Address(RVA = "0x1A4D6F0", Offset = "0x1A4C2F0", VA = "0x181A4D6F0")]
		public void EventOnRefresh()
		{
		}

		// Token: 0x0602034D RID: 131917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602034D")]
		[Address(RVA = "0x1A4E450", Offset = "0x1A4D050", VA = "0x181A4E450")]
		public RL05CopperPackageMainView()
		{
		}

		// Token: 0x0402B8CB RID: 178379
		[Token(Token = "0x402B8CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0402B8CC RID: 178380
		[Token(Token = "0x402B8CC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIRecycleLayoutGroup _patternContent;

		// Token: 0x0402B8CD RID: 178381
		[Token(Token = "0x402B8CD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIRecycleLayoutGroup _listContent;

		// Token: 0x0402B8CE RID: 178382
		[Token(Token = "0x402B8CE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RL05CopperPackageListPatternView _patternPrefab;

		// Token: 0x0402B8CF RID: 178383
		[Token(Token = "0x402B8CF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RL05CopperPackageListGrpView _listGrpPrefab;

		// Token: 0x0402B8D0 RID: 178384
		[Token(Token = "0x402B8D0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("RefreshButton")]
		private GameObject _refreshBtn;

		// Token: 0x0402B8D1 RID: 178385
		[Token(Token = "0x402B8D1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("RefreshButton")]
		private GameObject _refreshBtnOnlyView;

		// Token: 0x0402B8D2 RID: 178386
		[Token(Token = "0x402B8D2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("RefreshButton")]
		private GameObject _refreshBtnFree;

		// Token: 0x0402B8D3 RID: 178387
		[Token(Token = "0x402B8D3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("RefreshButton")]
		private GameObject _refreshBtnValid;

		// Token: 0x0402B8D4 RID: 178388
		[Token(Token = "0x402B8D4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("RefreshButton")]
		private GameObject _refreshBtnInvalid;

		// Token: 0x0402B8D5 RID: 178389
		[Token(Token = "0x402B8D5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("RefreshButton")]
		private Text[] _costNums;

		// Token: 0x0402B8D6 RID: 178390
		[Token(Token = "0x402B8D6")]
		[FieldOffset(Offset = "0x80")]
		private RL05CopperPackageMainView.CopperListPatternAdapter m_patternAdapter;

		// Token: 0x0402B8D7 RID: 178391
		[Token(Token = "0x402B8D7")]
		[FieldOffset(Offset = "0x88")]
		private RL05CopperPackageMainView.CoperGrpListAdapter m_listAdapter;

		// Token: 0x0402B8D8 RID: 178392
		[Token(Token = "0x402B8D8")]
		[FieldOffset(Offset = "0x90")]
		private UICompDialogFinder m_dlgFinder;

		// Token: 0x0402B8DB RID: 178395
		[Token(Token = "0x402B8DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onClickCopper;

		// Token: 0x0402B8DC RID: 178396
		[Token(Token = "0x402B8DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onClickCopper;

		// Token: 0x0402B8DD RID: 178397
		[Token(Token = "0x402B8DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onRefreshCopper;

		// Token: 0x0402B8DE RID: 178398
		[Token(Token = "0x402B8DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onRefreshCopper;

		// Token: 0x0402B8DF RID: 178399
		[Token(Token = "0x402B8DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402B8E0 RID: 178400
		[Token(Token = "0x402B8E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetTexts;

		// Token: 0x0402B8E1 RID: 178401
		[Token(Token = "0x402B8E1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B8E2 RID: 178402
		[Token(Token = "0x402B8E2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetAssetLoader;

		// Token: 0x0402B8E3 RID: 178403
		[Token(Token = "0x402B8E3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnRefresh;

		// Token: 0x0402B8E4 RID: 178404
		[Token(Token = "0x402B8E4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055AD RID: 21933
		[Token(Token = "0x20055AD")]
		private class CopperListPatternAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0602034E RID: 131918 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602034E")]
			[Address(RVA = "0x1A49120", Offset = "0x1A47D20", VA = "0x181A49120")]
			public void NotifyRebuild()
			{
			}

			// Token: 0x0602034F RID: 131919 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602034F")]
			[Address(RVA = "0x1A48F70", Offset = "0x1A47B70", VA = "0x181A48F70", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x06020350 RID: 131920 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020350")]
			[Address(RVA = "0x1A491B0", Offset = "0x1A47DB0", VA = "0x181A491B0")]
			private RL05CopperPackageMainView.CopperListPatternAdapter.CopperListPattenVirtualView _NewVirtualView(RL05CopperPackageListPatternView.PatternType ptype)
			{
				return null;
			}

			// Token: 0x06020351 RID: 131921 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020351")]
			[Address(RVA = "0x1A49340", Offset = "0x1A47F40", VA = "0x181A49340")]
			public CopperListPatternAdapter()
			{
			}

			// Token: 0x0402B8E5 RID: 178405
			[Token(Token = "0x402B8E5")]
			[FieldOffset(Offset = "0x18")]
			public RL05CopperPackageMainView closure;

			// Token: 0x0402B8E6 RID: 178406
			[Token(Token = "0x402B8E6")]
			[FieldOffset(Offset = "0x20")]
			public List<RoguelikePlayerCopperItemViewModel> list;

			// Token: 0x0402B8E7 RID: 178407
			[Token(Token = "0x402B8E7")]
			[FieldOffset(Offset = "0x28")]
			private List<UIRecycleLayoutAdapter.IVirtualView> m_views;

			// Token: 0x0402B8E8 RID: 178408
			[Token(Token = "0x402B8E8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_NotifyRebuild;

			// Token: 0x0402B8E9 RID: 178409
			[Token(Token = "0x402B8E9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0402B8EA RID: 178410
			[Token(Token = "0x402B8EA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__NewVirtualView;

			// Token: 0x0402B8EB RID: 178411
			[Token(Token = "0x402B8EB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020055AE RID: 21934
			[Token(Token = "0x20055AE")]
			public class CopperListPattenVirtualView : UIRecycleLayoutAdapter.VirtualView<RL05CopperPackageListPatternView>
			{
				// Token: 0x06020352 RID: 131922 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6020352")]
				[Address(RVA = "0x1A48C50", Offset = "0x1A47850", VA = "0x181A48C50", Slot = "12")]
				public override GameObject GetPrefab()
				{
					return null;
				}

				// Token: 0x06020353 RID: 131923 RVA: 0x000B4E88 File Offset: 0x000B3088
				[Token(Token = "0x6020353")]
				[Address(RVA = "0x1A48CC0", Offset = "0x1A478C0", VA = "0x181A48CC0", Slot = "13")]
				public override float GetPreferSize()
				{
					return 0f;
				}

				// Token: 0x06020354 RID: 131924 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6020354")]
				[Address(RVA = "0x1A48DB0", Offset = "0x1A479B0", VA = "0x181A48DB0", Slot = "10")]
				protected override void OnViewAttached()
				{
				}

				// Token: 0x06020355 RID: 131925 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6020355")]
				[Address(RVA = "0x1A48E90", Offset = "0x1A47A90", VA = "0x181A48E90", Slot = "11")]
				protected override void OnViewDetached()
				{
				}

				// Token: 0x06020356 RID: 131926 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6020356")]
				[Address(RVA = "0x1A48EF0", Offset = "0x1A47AF0", VA = "0x181A48EF0")]
				public CopperListPattenVirtualView()
				{
				}

				// Token: 0x0402B8EC RID: 178412
				[Token(Token = "0x402B8EC")]
				[FieldOffset(Offset = "0x20")]
				public RL05CopperPackageListPatternView.PatternType ptype;

				// Token: 0x0402B8ED RID: 178413
				[Token(Token = "0x402B8ED")]
				[FieldOffset(Offset = "0x28")]
				public RL05CopperPackageListPatternView viewPrefab;

				// Token: 0x0402B8EE RID: 178414
				[Token(Token = "0x402B8EE")]
				[FieldOffset(Offset = "0x30")]
				private float m_preferSize;

				// Token: 0x0402B8EF RID: 178415
				[Token(Token = "0x402B8EF")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_GetPrefab;

				// Token: 0x0402B8F0 RID: 178416
				[Token(Token = "0x402B8F0")]
				[FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_GetPreferSize;

				// Token: 0x0402B8F1 RID: 178417
				[Token(Token = "0x402B8F1")]
				[FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnViewAttached;

				// Token: 0x0402B8F2 RID: 178418
				[Token(Token = "0x402B8F2")]
				[FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_OnViewDetached;

				// Token: 0x0402B8F3 RID: 178419
				[Token(Token = "0x402B8F3")]
				[FieldOffset(Offset = "0x20")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}

		// Token: 0x020055AF RID: 21935
		[Token(Token = "0x20055AF")]
		private class CoperGrpListAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x06020357 RID: 131927 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020357")]
			[Address(RVA = "0x1A47C80", Offset = "0x1A46880", VA = "0x181A47C80")]
			public void NotifyRebuild()
			{
			}

			// Token: 0x06020358 RID: 131928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020358")]
			[Address(RVA = "0x1A47D10", Offset = "0x1A46910", VA = "0x181A47D10")]
			public void NotifySelectChanged(string selId)
			{
			}

			// Token: 0x06020359 RID: 131929 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020359")]
			[Address(RVA = "0x1A47AD0", Offset = "0x1A466D0", VA = "0x181A47AD0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0602035A RID: 131930 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602035A")]
			[Address(RVA = "0x1A47E80", Offset = "0x1A46A80", VA = "0x181A47E80")]
			private RL05CopperPackageMainView.CoperGrpListAdapter.CopperListGrpVirtualView _NewGrpView(int begin, bool isFirst)
			{
				return null;
			}

			// Token: 0x0602035B RID: 131931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602035B")]
			[Address(RVA = "0x1A48130", Offset = "0x1A46D30", VA = "0x181A48130")]
			public CoperGrpListAdapter()
			{
			}

			// Token: 0x0402B8F4 RID: 178420
			[Token(Token = "0x402B8F4")]
			[FieldOffset(Offset = "0x18")]
			public RL05CopperPackageMainView closure;

			// Token: 0x0402B8F5 RID: 178421
			[Token(Token = "0x402B8F5")]
			[FieldOffset(Offset = "0x20")]
			public List<RoguelikePlayerCopperItemViewModel> list;

			// Token: 0x0402B8F6 RID: 178422
			[Token(Token = "0x402B8F6")]
			[FieldOffset(Offset = "0x28")]
			public string selectInstId;

			// Token: 0x0402B8F7 RID: 178423
			[Token(Token = "0x402B8F7")]
			[FieldOffset(Offset = "0x30")]
			public List<UIRecycleLayoutAdapter.IVirtualView> m_views;

			// Token: 0x0402B8F8 RID: 178424
			[Token(Token = "0x402B8F8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_NotifyRebuild;

			// Token: 0x0402B8F9 RID: 178425
			[Token(Token = "0x402B8F9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_NotifySelectChanged;

			// Token: 0x0402B8FA RID: 178426
			[Token(Token = "0x402B8FA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0402B8FB RID: 178427
			[Token(Token = "0x402B8FB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__NewGrpView;

			// Token: 0x0402B8FC RID: 178428
			[Token(Token = "0x402B8FC")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020055B0 RID: 21936
			[Token(Token = "0x20055B0")]
			public class CopperListGrpVirtualView : UIRecycleLayoutAdapter.VirtualView<RL05CopperPackageListGrpView>
			{
				// Token: 0x0602035C RID: 131932 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x602035C")]
				[Address(RVA = "0x1A486E0", Offset = "0x1A472E0", VA = "0x181A486E0", Slot = "12")]
				public override GameObject GetPrefab()
				{
					return null;
				}

				// Token: 0x0602035D RID: 131933 RVA: 0x000B4EA0 File Offset: 0x000B30A0
				[Token(Token = "0x602035D")]
				[Address(RVA = "0x1A48750", Offset = "0x1A47350", VA = "0x181A48750", Slot = "13")]
				public override float GetPreferSize()
				{
					return 0f;
				}

				// Token: 0x0602035E RID: 131934 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602035E")]
				[Address(RVA = "0x1A48840", Offset = "0x1A47440", VA = "0x181A48840")]
				public void NotifySelectChanged(string selId)
				{
				}

				// Token: 0x0602035F RID: 131935 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602035F")]
				[Address(RVA = "0x1A48A40", Offset = "0x1A47640", VA = "0x181A48A40", Slot = "10")]
				protected override void OnViewAttached()
				{
				}

				// Token: 0x06020360 RID: 131936 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6020360")]
				[Address(RVA = "0x1A48B70", Offset = "0x1A47770", VA = "0x181A48B70", Slot = "11")]
				protected override void OnViewDetached()
				{
				}

				// Token: 0x06020361 RID: 131937 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6020361")]
				[Address(RVA = "0x1A48BD0", Offset = "0x1A477D0", VA = "0x181A48BD0")]
				public CopperListGrpVirtualView()
				{
				}

				// Token: 0x0402B8FD RID: 178429
				[Token(Token = "0x402B8FD")]
				[FieldOffset(Offset = "0x20")]
				public ILoadAsset assetLoader;

				// Token: 0x0402B8FE RID: 178430
				[Token(Token = "0x402B8FE")]
				[FieldOffset(Offset = "0x28")]
				public RL05CopperPackageListGrpView viewPrefab;

				// Token: 0x0402B8FF RID: 178431
				[Token(Token = "0x402B8FF")]
				[FieldOffset(Offset = "0x30")]
				public List<RoguelikePlayerCopperItemViewModel> list;

				// Token: 0x0402B900 RID: 178432
				[Token(Token = "0x402B900")]
				[FieldOffset(Offset = "0x38")]
				public int begin;

				// Token: 0x0402B901 RID: 178433
				[Token(Token = "0x402B901")]
				[FieldOffset(Offset = "0x3C")]
				public bool isFirst;

				// Token: 0x0402B902 RID: 178434
				[Token(Token = "0x402B902")]
				[FieldOffset(Offset = "0x40")]
				public string selectInstId;

				// Token: 0x0402B903 RID: 178435
				[Token(Token = "0x402B903")]
				[FieldOffset(Offset = "0x48")]
				public Action<string> onItemClick;

				// Token: 0x0402B904 RID: 178436
				[Token(Token = "0x402B904")]
				[FieldOffset(Offset = "0x50")]
				private float m_preferSize;

				// Token: 0x0402B905 RID: 178437
				[Token(Token = "0x402B905")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_GetPrefab;

				// Token: 0x0402B906 RID: 178438
				[Token(Token = "0x402B906")]
				[FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_GetPreferSize;

				// Token: 0x0402B907 RID: 178439
				[Token(Token = "0x402B907")]
				[FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_NotifySelectChanged;

				// Token: 0x0402B908 RID: 178440
				[Token(Token = "0x402B908")]
				[FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_OnViewAttached;

				// Token: 0x0402B909 RID: 178441
				[Token(Token = "0x402B909")]
				[FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_OnViewDetached;

				// Token: 0x0402B90A RID: 178442
				[Token(Token = "0x402B90A")]
				[FieldOffset(Offset = "0x28")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}
	}
}
