using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200475A RID: 18266
	[Token(Token = "0x200475A")]
	public class RecruitGachaItemView : RecruitGachaItemViewBase
	{
		// Token: 0x170041BE RID: 16830
		// (get) Token: 0x0601BA76 RID: 113270 RVA: 0x000A5BE8 File Offset: 0x000A3DE8
		// (set) Token: 0x0601BA77 RID: 113271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041BE")]
		private bool LimitPool
		{
			[Token(Token = "0x601BA76")]
			[Address(RVA = "0x1503F30", Offset = "0x1502B30", VA = "0x181503F30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601BA77")]
			[Address(RVA = "0x1504020", Offset = "0x1502C20", VA = "0x181504020")]
			set
			{
			}
		}

		// Token: 0x170041BF RID: 16831
		// (get) Token: 0x0601BA78 RID: 113272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170041BF")]
		public override string gachaPoolId
		{
			[Token(Token = "0x601BA78")]
			[Address(RVA = "0x1503F90", Offset = "0x1502B90", VA = "0x181503F90", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601BA79 RID: 113273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA79")]
		[Address(RVA = "0x15022A0", Offset = "0x1500EA0", VA = "0x1815022A0", Slot = "5")]
		protected override void OnRefreshData()
		{
		}

		// Token: 0x0601BA7A RID: 113274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA7A")]
		[Address(RVA = "0x1503570", Offset = "0x1502170", VA = "0x181503570")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BA7B RID: 113275 RVA: 0x000A5C00 File Offset: 0x000A3E00
		[Token(Token = "0x601BA7B")]
		[Address(RVA = "0x1503410", Offset = "0x1502010", VA = "0x181503410")]
		private long _GetRemainTimeToNextDay()
		{
			return 0L;
		}

		// Token: 0x0601BA7C RID: 113276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA7C")]
		[Address(RVA = "0x1503690", Offset = "0x1502290", VA = "0x181503690")]
		private void _OnExpireTimeExceed()
		{
		}

		// Token: 0x0601BA7D RID: 113277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA7D")]
		[Address(RVA = "0x1503710", Offset = "0x1502310", VA = "0x181503710")]
		private void _OnRefreshTimeExceed()
		{
		}

		// Token: 0x0601BA7E RID: 113278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA7E")]
		[Address(RVA = "0x15037E0", Offset = "0x15023E0", VA = "0x1815037E0")]
		private void _PickActiveRefreshCountDown()
		{
		}

		// Token: 0x0601BA7F RID: 113279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA7F")]
		[Address(RVA = "0x1502120", Offset = "0x1500D20", VA = "0x181502120", Slot = "7")]
		public override void OnDirectEnter()
		{
		}

		// Token: 0x0601BA80 RID: 113280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA80")]
		[Address(RVA = "0x1501440", Offset = "0x1500040", VA = "0x181501440")]
		public void ApplyData(int index, GachaPoolClientData data)
		{
		}

		// Token: 0x0601BA81 RID: 113281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA81")]
		[Address(RVA = "0x15021C0", Offset = "0x1500DC0", VA = "0x1815021C0")]
		public void OnEPGSShop()
		{
		}

		// Token: 0x0601BA82 RID: 113282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA82")]
		[Address(RVA = "0x1503920", Offset = "0x1502520", VA = "0x181503920")]
		private void _UpdateCostAdditionStatus(RecruitGachaCostAddition.Param additionParam)
		{
		}

		// Token: 0x0601BA83 RID: 113283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BA83")]
		[Address(RVA = "0x1503290", Offset = "0x1501E90", VA = "0x181503290")]
		private Transform _GetForwardPluginContainer()
		{
			return null;
		}

		// Token: 0x0601BA84 RID: 113284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA84")]
		[Address(RVA = "0x1503E20", Offset = "0x1502A20", VA = "0x181503E20")]
		public RecruitGachaItemView()
		{
		}

		// Token: 0x0601BA85 RID: 113285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA85")]
		[Address(RVA = "0x1500640", Offset = "0x14FF240", VA = "0x181500640")]
		private void <>xLuaBaseProxy_OnDirectEnter()
		{
		}

		// Token: 0x04023E53 RID: 147027
		[Token(Token = "0x4023E53")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected Text _recruitName;

		// Token: 0x04023E54 RID: 147028
		[Token(Token = "0x4023E54")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected Text _recruitDetail;

		// Token: 0x04023E55 RID: 147029
		[Token(Token = "0x4023E55")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected Text _recruitSummary;

		// Token: 0x04023E56 RID: 147030
		[Token(Token = "0x4023E56")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected Text _singlePrice;

		// Token: 0x04023E57 RID: 147031
		[Token(Token = "0x4023E57")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected Text _multiPrice;

		// Token: 0x04023E58 RID: 147032
		[Token(Token = "0x4023E58")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected GameObject _diamondShObj;

		// Token: 0x04023E59 RID: 147033
		[Token(Token = "0x4023E59")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected GameObject _gachaObj;

		// Token: 0x04023E5A RID: 147034
		[Token(Token = "0x4023E5A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected GameObject _diamondShTenObj;

		// Token: 0x04023E5B RID: 147035
		[Token(Token = "0x4023E5B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected GameObject _gachaTenObj;

		// Token: 0x04023E5C RID: 147036
		[Token(Token = "0x4023E5C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected GameObject _protectPart;

		// Token: 0x04023E5D RID: 147037
		[Token(Token = "0x4023E5D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _singleTktObj;

		// Token: 0x04023E5E RID: 147038
		[Token(Token = "0x4023E5E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _singleTktTenObj;

		// Token: 0x04023E5F RID: 147039
		[Token(Token = "0x4023E5F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected Text _remainTimes;

		// Token: 0x04023E60 RID: 147040
		[Token(Token = "0x4023E60")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Tooltip("Nullable")]
		private Transform _forwardPlugin;

		// Token: 0x04023E61 RID: 147041
		[Token(Token = "0x4023E61")]
		[FieldOffset(Offset = "0xD0")]
		[Inspect]
		public bool isLimitPool;

		// Token: 0x04023E62 RID: 147042
		[Token(Token = "0x4023E62")]
		[FieldOffset(Offset = "0xD8")]
		[Inspect("LimitPool")]
		public GameObject _limitPoolPart;

		// Token: 0x04023E63 RID: 147043
		[Token(Token = "0x4023E63")]
		[FieldOffset(Offset = "0xE0")]
		[Inspect("LimitPool")]
		public GameObject _limitFreeGachaObj;

		// Token: 0x04023E64 RID: 147044
		[Token(Token = "0x4023E64")]
		[FieldOffset(Offset = "0xE8")]
		[Inspect("LimitPool")]
		public GameObject _limitTenGachaObj;

		// Token: 0x04023E65 RID: 147045
		[Token(Token = "0x4023E65")]
		[FieldOffset(Offset = "0xF0")]
		[Inspect("LimitPool")]
		public GameObject _limitExpirePart;

		// Token: 0x04023E66 RID: 147046
		[Token(Token = "0x4023E66")]
		[FieldOffset(Offset = "0xF8")]
		[Inspect("LimitPool")]
		public GameObject _limitFreshPart;

		// Token: 0x04023E67 RID: 147047
		[Token(Token = "0x4023E67")]
		[FieldOffset(Offset = "0x100")]
		[Inspect("LimitPool")]
		public GameObject _limitFreshPartBottom;

		// Token: 0x04023E68 RID: 147048
		[Token(Token = "0x4023E68")]
		[FieldOffset(Offset = "0x108")]
		[Inspect("LimitPool")]
		public GameObject _limitFreeIconObj;

		// Token: 0x04023E69 RID: 147049
		[Token(Token = "0x4023E69")]
		[FieldOffset(Offset = "0x110")]
		[Inspect("LimitPool")]
		public GameObject _limitFreeLightObj;

		// Token: 0x04023E6A RID: 147050
		[Token(Token = "0x4023E6A")]
		[FieldOffset(Offset = "0x118")]
		[Inspect("LimitPool")]
		public Text _limitFreeGachaCnt;

		// Token: 0x04023E6B RID: 147051
		[Token(Token = "0x4023E6B")]
		[FieldOffset(Offset = "0x120")]
		[Inspect("LimitPool")]
		public Text _limitTenGachaCnt;

		// Token: 0x04023E6C RID: 147052
		[Token(Token = "0x4023E6C")]
		[FieldOffset(Offset = "0x128")]
		[Inspect("LimitPool")]
		public Text _shardCount;

		// Token: 0x04023E6D RID: 147053
		[Token(Token = "0x4023E6D")]
		[FieldOffset(Offset = "0x130")]
		[Inspect("LimitPool")]
		public Text _limitFreeRecruitCnt;

		// Token: 0x04023E6E RID: 147054
		[Token(Token = "0x4023E6E")]
		[FieldOffset(Offset = "0x138")]
		[Inspect("LimitPool")]
		public Color _limitFreeRecruitedColor;

		// Token: 0x04023E6F RID: 147055
		[Token(Token = "0x4023E6F")]
		[FieldOffset(Offset = "0x148")]
		[Inspect("LimitPool")]
		public Color _refreshColorBottom;

		// Token: 0x04023E70 RID: 147056
		[Token(Token = "0x4023E70")]
		[FieldOffset(Offset = "0x158")]
		[Inspect("LimitPool")]
		public Image _limitCDAboveBg;

		// Token: 0x04023E71 RID: 147057
		[Token(Token = "0x4023E71")]
		[FieldOffset(Offset = "0x160")]
		[Inspect("LimitPool")]
		public Image _limitCDBottomBg;

		// Token: 0x04023E72 RID: 147058
		[Token(Token = "0x4023E72")]
		[FieldOffset(Offset = "0x168")]
		[Inspect("LimitPool")]
		public Image _limitCDLeftBg;

		// Token: 0x04023E73 RID: 147059
		[Token(Token = "0x4023E73")]
		[FieldOffset(Offset = "0x170")]
		[Inspect("LimitPool")]
		public Image _limitCDRightBg;

		// Token: 0x04023E74 RID: 147060
		[Token(Token = "0x4023E74")]
		[FieldOffset(Offset = "0x178")]
		[Inspect("LimitPool")]
		public Image _shardIcon;

		// Token: 0x04023E75 RID: 147061
		[Token(Token = "0x4023E75")]
		[FieldOffset(Offset = "0x180")]
		[Inspect("LimitPool")]
		public Image _tinyShardIcon;

		// Token: 0x04023E76 RID: 147062
		[Token(Token = "0x4023E76")]
		[FieldOffset(Offset = "0x188")]
		[Inspect("LimitPool")]
		public Image _detailArrowIcon;

		// Token: 0x04023E77 RID: 147063
		[Token(Token = "0x4023E77")]
		[FieldOffset(Offset = "0x190")]
		[Inspect("LimitPool")]
		public Image _limitFreeCountBg;

		// Token: 0x04023E78 RID: 147064
		[Token(Token = "0x4023E78")]
		[FieldOffset(Offset = "0x198")]
		[Inspect("LimitPool")]
		public Image _limitFreeCharBorderImg;

		// Token: 0x04023E79 RID: 147065
		[Token(Token = "0x4023E79")]
		[FieldOffset(Offset = "0x1A0")]
		[Inspect("LimitPool")]
		public Image _limitFreeCharImg;

		// Token: 0x04023E7A RID: 147066
		[Token(Token = "0x4023E7A")]
		[FieldOffset(Offset = "0x1A8")]
		[Inspect("LimitPool")]
		public UIItemTimeCountDown _ExpireCountDown;

		// Token: 0x04023E7B RID: 147067
		[Token(Token = "0x4023E7B")]
		[FieldOffset(Offset = "0x1B0")]
		[Inspect("LimitPool")]
		public UIItemTimeCountDown _RefreshCountDown;

		// Token: 0x04023E7C RID: 147068
		[Token(Token = "0x4023E7C")]
		[FieldOffset(Offset = "0x1B8")]
		[Inspect("LimitPool")]
		public UIItemTimeCountDown _refreshCountDownBottom;

		// Token: 0x04023E7D RID: 147069
		[Token(Token = "0x4023E7D")]
		[FieldOffset(Offset = "0x1C0")]
		[Inspect("LimitPool")]
		public ThreeStateToggle _limitFreeRecruitStateToggle;

		// Token: 0x04023E7E RID: 147070
		[Token(Token = "0x4023E7E")]
		[FieldOffset(Offset = "0x1C8")]
		[Inspect("LimitPool")]
		public Text _limitEndTimeMonthText;

		// Token: 0x04023E7F RID: 147071
		[Token(Token = "0x4023E7F")]
		[FieldOffset(Offset = "0x1D0")]
		[Inspect("LimitPool")]
		public Text _limitEndTimeDayText;

		// Token: 0x04023E80 RID: 147072
		[Token(Token = "0x4023E80")]
		[FieldOffset(Offset = "0x1D8")]
		[Inspect("LimitPool")]
		public Text _limitEndTimeHourMinText;

		// Token: 0x04023E81 RID: 147073
		[Token(Token = "0x4023E81")]
		[FieldOffset(Offset = "0x1E0")]
		[Inspect("LimitPool")]
		public UIAnimationLocation _limitEnterAnim;

		// Token: 0x04023E82 RID: 147074
		[Token(Token = "0x4023E82")]
		[FieldOffset(Offset = "0x1F0")]
		private GachaPoolClientData m_data;

		// Token: 0x04023E83 RID: 147075
		[Token(Token = "0x4023E83")]
		[FieldOffset(Offset = "0x1F8")]
		private RecruitGachaCostAddition m_costAddition;

		// Token: 0x04023E84 RID: 147076
		[Token(Token = "0x4023E84")]
		[FieldOffset(Offset = "0x200")]
		private RecruitGachaItemView.LimitPoolParam m_limitParam;

		// Token: 0x04023E85 RID: 147077
		[Token(Token = "0x4023E85")]
		[FieldOffset(Offset = "0x208")]
		private UIItemTimeCountDown m_activeCountDown;

		// Token: 0x04023E86 RID: 147078
		[Token(Token = "0x4023E86")]
		[FieldOffset(Offset = "0x210")]
		private int m_index;

		// Token: 0x04023E87 RID: 147079
		[Token(Token = "0x4023E87")]
		[FieldOffset(Offset = "0x214")]
		private bool m_isInited;

		// Token: 0x04023E88 RID: 147080
		[Token(Token = "0x4023E88")]
		[FieldOffset(Offset = "0x218")]
		private AnimationSwitchTween m_enteraAnimSwitchTween;

		// Token: 0x04023E89 RID: 147081
		[Token(Token = "0x4023E89")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_LimitPool;

		// Token: 0x04023E8A RID: 147082
		[Token(Token = "0x4023E8A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_LimitPool;

		// Token: 0x04023E8B RID: 147083
		[Token(Token = "0x4023E8B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_gachaPoolId;

		// Token: 0x04023E8C RID: 147084
		[Token(Token = "0x4023E8C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRefreshData;

		// Token: 0x04023E8D RID: 147085
		[Token(Token = "0x4023E8D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023E8E RID: 147086
		[Token(Token = "0x4023E8E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetRemainTimeToNextDay;

		// Token: 0x04023E8F RID: 147087
		[Token(Token = "0x4023E8F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnExpireTimeExceed;

		// Token: 0x04023E90 RID: 147088
		[Token(Token = "0x4023E90")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnRefreshTimeExceed;

		// Token: 0x04023E91 RID: 147089
		[Token(Token = "0x4023E91")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PickActiveRefreshCountDown;

		// Token: 0x04023E92 RID: 147090
		[Token(Token = "0x4023E92")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDirectEnter;

		// Token: 0x04023E93 RID: 147091
		[Token(Token = "0x4023E93")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04023E94 RID: 147092
		[Token(Token = "0x4023E94")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnEPGSShop;

		// Token: 0x04023E95 RID: 147093
		[Token(Token = "0x4023E95")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateCostAdditionStatus;

		// Token: 0x04023E96 RID: 147094
		[Token(Token = "0x4023E96")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetForwardPluginContainer;

		// Token: 0x04023E97 RID: 147095
		[Token(Token = "0x4023E97")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200475B RID: 18267
		[Token(Token = "0x200475B")]
		private class LimitPoolParam : IHotfixable
		{
			// Token: 0x0601BA86 RID: 113286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BA86")]
			[Address(RVA = "0x14F31E0", Offset = "0x14F1DE0", VA = "0x1814F31E0")]
			public void UpdateData(GachaPoolClientData poolClientData)
			{
			}

			// Token: 0x0601BA87 RID: 113287 RVA: 0x000A5C18 File Offset: 0x000A3E18
			[Token(Token = "0x601BA87")]
			[Address(RVA = "0x14F3180", Offset = "0x14F1D80", VA = "0x1814F3180")]
			public bool HasFreeChar()
			{
				return default(bool);
			}

			// Token: 0x0601BA88 RID: 113288 RVA: 0x000A5C30 File Offset: 0x000A3E30
			[Token(Token = "0x601BA88")]
			[Address(RVA = "0x14F3060", Offset = "0x14F1C60", VA = "0x1814F3060")]
			public int GetFreeCount()
			{
				return 0;
			}

			// Token: 0x0601BA89 RID: 113289 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BA89")]
			[Address(RVA = "0x14F30C0", Offset = "0x14F1CC0", VA = "0x1814F30C0")]
			public string GetLimitedCharId()
			{
				return null;
			}

			// Token: 0x0601BA8A RID: 113290 RVA: 0x000A5C48 File Offset: 0x000A3E48
			[Token(Token = "0x601BA8A")]
			[Address(RVA = "0x14F3120", Offset = "0x14F1D20", VA = "0x1814F3120")]
			public int GetVersion()
			{
				return 0;
			}

			// Token: 0x0601BA8B RID: 113291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BA8B")]
			[Address(RVA = "0x14F3340", Offset = "0x14F1F40", VA = "0x1814F3340")]
			public LimitPoolParam()
			{
			}

			// Token: 0x04023E98 RID: 147096
			[Token(Token = "0x4023E98")]
			public const int V1 = 0;

			// Token: 0x04023E99 RID: 147097
			[Token(Token = "0x4023E99")]
			public const int V2 = 1;

			// Token: 0x04023E9A RID: 147098
			[Token(Token = "0x4023E9A")]
			private const string BOOL_HASFREECHAR = "hasFreeChar";

			// Token: 0x04023E9B RID: 147099
			[Token(Token = "0x4023E9B")]
			private const string INT_FREECOUNT = "freeCount";

			// Token: 0x04023E9C RID: 147100
			[Token(Token = "0x4023E9C")]
			private const string STRING_LIMITEDCHARID = "limitedCharId";

			// Token: 0x04023E9D RID: 147101
			[Token(Token = "0x4023E9D")]
			private const string INT_VERSION = "version";

			// Token: 0x04023E9E RID: 147102
			[Token(Token = "0x4023E9E")]
			[FieldOffset(Offset = "0x10")]
			private bool m_hasFreeChar;

			// Token: 0x04023E9F RID: 147103
			[Token(Token = "0x4023E9F")]
			[FieldOffset(Offset = "0x14")]
			private int m_freeCount;

			// Token: 0x04023EA0 RID: 147104
			[Token(Token = "0x4023EA0")]
			[FieldOffset(Offset = "0x18")]
			private string m_limitedCharId;

			// Token: 0x04023EA1 RID: 147105
			[Token(Token = "0x4023EA1")]
			[FieldOffset(Offset = "0x20")]
			private int m_version;

			// Token: 0x04023EA2 RID: 147106
			[Token(Token = "0x4023EA2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateData;

			// Token: 0x04023EA3 RID: 147107
			[Token(Token = "0x4023EA3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_HasFreeChar;

			// Token: 0x04023EA4 RID: 147108
			[Token(Token = "0x4023EA4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetFreeCount;

			// Token: 0x04023EA5 RID: 147109
			[Token(Token = "0x4023EA5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetLimitedCharId;

			// Token: 0x04023EA6 RID: 147110
			[Token(Token = "0x4023EA6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetVersion;

			// Token: 0x04023EA7 RID: 147111
			[Token(Token = "0x4023EA7")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
