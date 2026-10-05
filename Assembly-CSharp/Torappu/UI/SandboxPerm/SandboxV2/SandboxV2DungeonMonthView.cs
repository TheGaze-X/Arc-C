using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041CC RID: 16844
	[Token(Token = "0x20041CC")]
	public class SandboxV2DungeonMonthView : DataBinder<SandboxV2DungeonMonthModelProperty>, IHotfixable
	{
		// Token: 0x17003DDA RID: 15834
		// (get) Token: 0x06019F6D RID: 106349 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019F6C RID: 106348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DDA")]
		public Action onOpenMap
		{
			[Token(Token = "0x6019F6D")]
			[Address(RVA = "0x12DE890", Offset = "0x12DD490", VA = "0x1812DE890")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019F6C")]
			[Address(RVA = "0x12DE9D0", Offset = "0x12DD5D0", VA = "0x1812DE9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003DDB RID: 15835
		// (get) Token: 0x06019F6F RID: 106351 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019F6E RID: 106350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DDB")]
		public Action onOpenEenemy
		{
			[Token(Token = "0x6019F6F")]
			[Address(RVA = "0x12DE830", Offset = "0x12DD430", VA = "0x1812DE830")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019F6E")]
			[Address(RVA = "0x12DE950", Offset = "0x12DD550", VA = "0x1812DE950")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003DDC RID: 15836
		// (get) Token: 0x06019F71 RID: 106353 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019F70 RID: 106352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DDC")]
		public Action onStart
		{
			[Token(Token = "0x6019F71")]
			[Address(RVA = "0x12DE8F0", Offset = "0x12DD4F0", VA = "0x1812DE8F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019F70")]
			[Address(RVA = "0x12DEA50", Offset = "0x12DD650", VA = "0x1812DEA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019F72 RID: 106354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F72")]
		[Address(RVA = "0x12DD8C0", Offset = "0x12DC4C0", VA = "0x1812DD8C0", Slot = "7")]
		public override void OnValueChanged(SandboxV2DungeonMonthModelProperty property)
		{
		}

		// Token: 0x06019F73 RID: 106355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F73")]
		[Address(RVA = "0x12DE110", Offset = "0x12DCD10", VA = "0x1812DE110")]
		private void _Render(SandboxV2DungeonMonthModel model)
		{
		}

		// Token: 0x06019F74 RID: 106356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F74")]
		[Address(RVA = "0x12DDF10", Offset = "0x12DCB10", VA = "0x1812DDF10")]
		private void _RenderPortable(SandboxV2DungeonMonthModel model)
		{
		}

		// Token: 0x06019F75 RID: 106357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F75")]
		[Address(RVA = "0x12DDCC0", Offset = "0x12DC8C0", VA = "0x1812DDCC0")]
		private void _RenderDot(SandboxV2DungeonMonthModel model)
		{
		}

		// Token: 0x06019F76 RID: 106358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F76")]
		[Address(RVA = "0x12DDB10", Offset = "0x12DC710", VA = "0x1812DDB10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019F77 RID: 106359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F77")]
		[Address(RVA = "0x12DD750", Offset = "0x12DC350", VA = "0x1812DD750")]
		public void EventShowTip()
		{
		}

		// Token: 0x06019F78 RID: 106360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F78")]
		[Address(RVA = "0x12DD310", Offset = "0x12DBF10", VA = "0x1812DD310")]
		public void EventNext()
		{
		}

		// Token: 0x06019F79 RID: 106361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F79")]
		[Address(RVA = "0x12DD640", Offset = "0x12DC240", VA = "0x1812DD640")]
		public void EventPrev()
		{
		}

		// Token: 0x06019F7A RID: 106362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F7A")]
		[Address(RVA = "0x12DD420", Offset = "0x12DC020", VA = "0x1812DD420")]
		public void EventOpenEnemy()
		{
		}

		// Token: 0x06019F7B RID: 106363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F7B")]
		[Address(RVA = "0x12DD530", Offset = "0x12DC130", VA = "0x1812DD530")]
		public void EventOpenMap()
		{
		}

		// Token: 0x06019F7C RID: 106364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F7C")]
		[Address(RVA = "0x12DD7B0", Offset = "0x12DC3B0", VA = "0x1812DD7B0")]
		public void EventStart()
		{
		}

		// Token: 0x06019F7D RID: 106365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F7D")]
		[Address(RVA = "0x12DE7C0", Offset = "0x12DD3C0", VA = "0x1812DE7C0")]
		public SandboxV2DungeonMonthView()
		{
		}

		// Token: 0x04020B3F RID: 133951
		[Token(Token = "0x4020B3F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Left")]
		private Text _rushName;

		// Token: 0x04020B40 RID: 133952
		[Token(Token = "0x4020B40")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Left")]
		private Text _updateTime;

		// Token: 0x04020B41 RID: 133953
		[Token(Token = "0x4020B41")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Left")]
		private GameObject _updateTimeNode;

		// Token: 0x04020B42 RID: 133954
		[Token(Token = "0x4020B42")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Left")]
		private Text _rushIdxLabel;

		// Token: 0x04020B43 RID: 133955
		[Token(Token = "0x4020B43")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Left")]
		private GameObject _completeTipNode;

		// Token: 0x04020B44 RID: 133956
		[Token(Token = "0x4020B44")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Left")]
		private Text _rushDesc;

		// Token: 0x04020B45 RID: 133957
		[Token(Token = "0x4020B45")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Left")]
		private EasyInstancePool _dotPool;

		// Token: 0x04020B46 RID: 133958
		[Token(Token = "0x4020B46")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Left")]
		private GameObject _pager;

		// Token: 0x04020B47 RID: 133959
		[Token(Token = "0x4020B47")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Base")]
		private Text _baseHpRatio;

		// Token: 0x04020B48 RID: 133960
		[Token(Token = "0x4020B48")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Base")]
		private Scrollbar _baseHpPrg;

		// Token: 0x04020B49 RID: 133961
		[Token(Token = "0x4020B49")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04020B4A RID: 133962
		[Token(Token = "0x4020B4A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _mechanismInfo;

		// Token: 0x04020B4B RID: 133963
		[Token(Token = "0x4020B4B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Reward")]
		private SimpleLayoutContent _rewardList;

		// Token: 0x04020B4C RID: 133964
		[Token(Token = "0x4020B4C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Reward")]
		private GameObject _gotRewardNode;

		// Token: 0x04020B4D RID: 133965
		[Token(Token = "0x4020B4D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Weather")]
		private Transform _weatherContainer;

		// Token: 0x04020B4E RID: 133966
		[Token(Token = "0x4020B4E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Weather")]
		private SandboxV2NodePreviewWeatherView _weatherViewPrefab;

		// Token: 0x04020B4F RID: 133967
		[Token(Token = "0x4020B4F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("StartButton")]
		private TwoStateToggle _startBtnValidToggle;

		// Token: 0x04020B50 RID: 133968
		[Token(Token = "0x4020B50")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("StartButton")]
		private TwoStateToggle _startBtnHighlightToggle;

		// Token: 0x04020B51 RID: 133969
		[Token(Token = "0x4020B51")]
		[FieldOffset(Offset = "0xB0")]
		private SandboxV2DungeonMonthModelProperty m_cachedProp;

		// Token: 0x04020B52 RID: 133970
		[Token(Token = "0x4020B52")]
		[FieldOffset(Offset = "0xB8")]
		private SandboxV2NodePreviewWeatherView m_weatherView;

		// Token: 0x04020B53 RID: 133971
		[Token(Token = "0x4020B53")]
		[FieldOffset(Offset = "0xC0")]
		private SandboxV2DungeonMonthView.Adapter m_rewardAdapter;

		// Token: 0x04020B57 RID: 133975
		[Token(Token = "0x4020B57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onOpenMap;

		// Token: 0x04020B58 RID: 133976
		[Token(Token = "0x4020B58")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onOpenMap;

		// Token: 0x04020B59 RID: 133977
		[Token(Token = "0x4020B59")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onOpenEenemy;

		// Token: 0x04020B5A RID: 133978
		[Token(Token = "0x4020B5A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onOpenEenemy;

		// Token: 0x04020B5B RID: 133979
		[Token(Token = "0x4020B5B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_onStart;

		// Token: 0x04020B5C RID: 133980
		[Token(Token = "0x4020B5C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_onStart;

		// Token: 0x04020B5D RID: 133981
		[Token(Token = "0x4020B5D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04020B5E RID: 133982
		[Token(Token = "0x4020B5E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04020B5F RID: 133983
		[Token(Token = "0x4020B5F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderPortable;

		// Token: 0x04020B60 RID: 133984
		[Token(Token = "0x4020B60")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderDot;

		// Token: 0x04020B61 RID: 133985
		[Token(Token = "0x4020B61")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020B62 RID: 133986
		[Token(Token = "0x4020B62")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventShowTip;

		// Token: 0x04020B63 RID: 133987
		[Token(Token = "0x4020B63")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventNext;

		// Token: 0x04020B64 RID: 133988
		[Token(Token = "0x4020B64")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventPrev;

		// Token: 0x04020B65 RID: 133989
		[Token(Token = "0x4020B65")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOpenEnemy;

		// Token: 0x04020B66 RID: 133990
		[Token(Token = "0x4020B66")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOpenMap;

		// Token: 0x04020B67 RID: 133991
		[Token(Token = "0x4020B67")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventStart;

		// Token: 0x04020B68 RID: 133992
		[Token(Token = "0x4020B68")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020041CD RID: 16845
		[Token(Token = "0x20041CD")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003DDD RID: 15837
			// (get) Token: 0x06019F7E RID: 106366 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06019F7F RID: 106367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003DDD")]
			public List<UIItemViewModel> rewardList
			{
				[Token(Token = "0x6019F7E")]
				[Address(RVA = "0x12CBA40", Offset = "0x12CA640", VA = "0x1812CBA40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6019F7F")]
				[Address(RVA = "0x12CBB70", Offset = "0x12CA770", VA = "0x1812CBB70")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003DDE RID: 15838
			// (get) Token: 0x06019F80 RID: 106368 RVA: 0x0009FDB0 File Offset: 0x0009DFB0
			// (set) Token: 0x06019F81 RID: 106369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003DDE")]
			public bool needShowCoinTime
			{
				[Token(Token = "0x6019F80")]
				[Address(RVA = "0x12CB9E0", Offset = "0x12CA5E0", VA = "0x1812CB9E0")]
				[CompilerGenerated]
				private get
				{
					return default(bool);
				}
				[Token(Token = "0x6019F81")]
				[Address(RVA = "0x12CBB00", Offset = "0x12CA700", VA = "0x1812CBB00")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003DDF RID: 15839
			// (get) Token: 0x06019F82 RID: 106370 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06019F83 RID: 106371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003DDF")]
			public string timeStr
			{
				[Token(Token = "0x6019F82")]
				[Address(RVA = "0x12CBAA0", Offset = "0x12CA6A0", VA = "0x1812CBAA0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6019F83")]
				[Address(RVA = "0x12CBBF0", Offset = "0x12CA7F0", VA = "0x1812CBBF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003DE0 RID: 15840
			// (get) Token: 0x06019F84 RID: 106372 RVA: 0x0009FDC8 File Offset: 0x0009DFC8
			[Token(Token = "0x17003DE0")]
			public override int count
			{
				[Token(Token = "0x6019F84")]
				[Address(RVA = "0x12CB920", Offset = "0x12CA520", VA = "0x1812CB920", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019F85 RID: 106373 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019F85")]
			[Address(RVA = "0x12CB5F0", Offset = "0x12CA1F0", VA = "0x1812CB5F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06019F86 RID: 106374 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019F86")]
			[Address(RVA = "0x12CB8C0", Offset = "0x12CA4C0", VA = "0x1812CB8C0")]
			public Adapter()
			{
			}

			// Token: 0x04020B6C RID: 133996
			[Token(Token = "0x4020B6C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_rewardList;

			// Token: 0x04020B6D RID: 133997
			[Token(Token = "0x4020B6D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_rewardList;

			// Token: 0x04020B6E RID: 133998
			[Token(Token = "0x4020B6E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_needShowCoinTime;

			// Token: 0x04020B6F RID: 133999
			[Token(Token = "0x4020B6F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_needShowCoinTime;

			// Token: 0x04020B70 RID: 134000
			[Token(Token = "0x4020B70")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_timeStr;

			// Token: 0x04020B71 RID: 134001
			[Token(Token = "0x4020B71")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_timeStr;

			// Token: 0x04020B72 RID: 134002
			[Token(Token = "0x4020B72")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020B73 RID: 134003
			[Token(Token = "0x4020B73")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04020B74 RID: 134004
			[Token(Token = "0x4020B74")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
