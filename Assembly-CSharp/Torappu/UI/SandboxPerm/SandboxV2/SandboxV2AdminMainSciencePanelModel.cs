using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040D1 RID: 16593
	[Token(Token = "0x20040D1")]
	public class SandboxV2AdminMainSciencePanelModel : IHotfixable
	{
		// Token: 0x17003D38 RID: 15672
		// (get) Token: 0x06019A9E RID: 105118 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019A9F RID: 105119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D38")]
		public string topicId
		{
			[Token(Token = "0x6019A9E")]
			[Address(RVA = "0x127F0A0", Offset = "0x127DCA0", VA = "0x18127F0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019A9F")]
			[Address(RVA = "0x127F340", Offset = "0x127DF40", VA = "0x18127F340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D39 RID: 15673
		// (get) Token: 0x06019AA0 RID: 105120 RVA: 0x0009EF28 File Offset: 0x0009D128
		// (set) Token: 0x06019AA1 RID: 105121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D39")]
		public SandboxV2AdminMainScienceType curScienceType
		{
			[Token(Token = "0x6019AA0")]
			[Address(RVA = "0x127EDB0", Offset = "0x127D9B0", VA = "0x18127EDB0")]
			[CompilerGenerated]
			get
			{
				return SandboxV2AdminMainScienceType.NONE;
			}
			[Token(Token = "0x6019AA1")]
			[Address(RVA = "0x127F110", Offset = "0x127DD10", VA = "0x18127F110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D3A RID: 15674
		// (get) Token: 0x06019AA2 RID: 105122 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019AA3 RID: 105123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D3A")]
		public string selectedNodeId
		{
			[Token(Token = "0x6019AA2")]
			[Address(RVA = "0x127F030", Offset = "0x127DC30", VA = "0x18127F030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019AA3")]
			[Address(RVA = "0x127F2B0", Offset = "0x127DEB0", VA = "0x18127F2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D3B RID: 15675
		// (get) Token: 0x06019AA4 RID: 105124 RVA: 0x0009EF40 File Offset: 0x0009D140
		// (set) Token: 0x06019AA5 RID: 105125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D3B")]
		public bool initShow
		{
			[Token(Token = "0x6019AA4")]
			[Address(RVA = "0x127EEE0", Offset = "0x127DAE0", VA = "0x18127EEE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6019AA5")]
			[Address(RVA = "0x127F190", Offset = "0x127DD90", VA = "0x18127F190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D3C RID: 15676
		// (get) Token: 0x06019AA6 RID: 105126 RVA: 0x0009EF58 File Offset: 0x0009D158
		// (set) Token: 0x06019AA7 RID: 105127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D3C")]
		public bool needRefreshNode
		{
			[Token(Token = "0x6019AA6")]
			[Address(RVA = "0x127EF50", Offset = "0x127DB50", VA = "0x18127EF50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6019AA7")]
			[Address(RVA = "0x127F220", Offset = "0x127DE20", VA = "0x18127F220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D3D RID: 15677
		// (get) Token: 0x06019AA8 RID: 105128 RVA: 0x0009EF70 File Offset: 0x0009D170
		[Token(Token = "0x17003D3D")]
		public int pointsRemain
		{
			[Token(Token = "0x6019AA8")]
			[Address(RVA = "0x127EFC0", Offset = "0x127DBC0", VA = "0x18127EFC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003D3E RID: 15678
		// (get) Token: 0x06019AA9 RID: 105129 RVA: 0x0009EF88 File Offset: 0x0009D188
		[Token(Token = "0x17003D3E")]
		public float currentNodeMaxWidth
		{
			[Token(Token = "0x6019AA9")]
			[Address(RVA = "0x127EE20", Offset = "0x127DA20", VA = "0x18127EE20")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06019AAA RID: 105130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AAA")]
		[Address(RVA = "0x127BDC0", Offset = "0x127A9C0", VA = "0x18127BDC0")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x06019AAB RID: 105131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AAB")]
		[Address(RVA = "0x127D180", Offset = "0x127BD80", VA = "0x18127D180")]
		private void _LoadDevelopmentBaseDatas(Dictionary<string, SandboxV2DevelopmentData> developmentDatas)
		{
		}

		// Token: 0x06019AAC RID: 105132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AAC")]
		[Address(RVA = "0x127E840", Offset = "0x127D440", VA = "0x18127E840")]
		private void _UpdateContentWidthByNode(SandboxV2DevelopmentData nodeData)
		{
		}

		// Token: 0x06019AAD RID: 105133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AAD")]
		[Address(RVA = "0x127D5B0", Offset = "0x127C1B0", VA = "0x18127D5B0")]
		private void _LoadDevelopmentDatas(Dictionary<string, SandboxV2DevelopmentData> developmentDatas)
		{
		}

		// Token: 0x06019AAE RID: 105134 RVA: 0x0009EFA0 File Offset: 0x0009D1A0
		[Token(Token = "0x6019AAE")]
		[Address(RVA = "0x127CF50", Offset = "0x127BB50", VA = "0x18127CF50")]
		private SandboxV2AdminMainScienceType _GetScienceTypeByTechType(SandboxV2DevelopmentType techType)
		{
			return SandboxV2AdminMainScienceType.NONE;
		}

		// Token: 0x06019AAF RID: 105135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AAF")]
		[Address(RVA = "0x127DAD0", Offset = "0x127C6D0", VA = "0x18127DAD0")]
		private void _LoadLineSegmentDatas(List<SandboxV2DevelopmentLineSegmentData> lineDatas)
		{
		}

		// Token: 0x06019AB0 RID: 105136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AB0")]
		[Address(RVA = "0x127C160", Offset = "0x127AD60", VA = "0x18127C160")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06019AB1 RID: 105137 RVA: 0x0009EFB8 File Offset: 0x0009D1B8
		[Token(Token = "0x6019AB1")]
		[Address(RVA = "0x127BCB0", Offset = "0x127A8B0", VA = "0x18127BCB0")]
		public bool IfNodeCanDevelop(string developId)
		{
			return default(bool);
		}

		// Token: 0x06019AB2 RID: 105138 RVA: 0x0009EFD0 File Offset: 0x0009D1D0
		[Token(Token = "0x6019AB2")]
		[Address(RVA = "0x127B6A0", Offset = "0x127A2A0", VA = "0x18127B6A0")]
		public bool CleanSelected()
		{
			return default(bool);
		}

		// Token: 0x06019AB3 RID: 105139 RVA: 0x0009EFE8 File Offset: 0x0009D1E8
		[Token(Token = "0x6019AB3")]
		[Address(RVA = "0x127BBB0", Offset = "0x127A7B0", VA = "0x18127BBB0")]
		public float GetScienceProgressByType(SandboxV2AdminMainScienceType techType)
		{
			return 0f;
		}

		// Token: 0x06019AB4 RID: 105140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AB4")]
		[Address(RVA = "0x127E6B0", Offset = "0x127D2B0", VA = "0x18127E6B0")]
		private void _RefreshDevelopTotalUsedDots(PlayerSandboxV2.Tech tech)
		{
		}

		// Token: 0x06019AB5 RID: 105141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AB5")]
		[Address(RVA = "0x127DFE0", Offset = "0x127CBE0", VA = "0x18127DFE0")]
		private void _RefreshDevelopNodesStatus(PlayerSandboxV2.Tech tech, int baseLevel)
		{
		}

		// Token: 0x06019AB6 RID: 105142 RVA: 0x0009F000 File Offset: 0x0009D200
		[Token(Token = "0x6019AB6")]
		[Address(RVA = "0x127C7C0", Offset = "0x127B3C0", VA = "0x18127C7C0")]
		private bool _CheckIfPreNodeLighted(string preNodeId, PlayerSandboxV2.Tech tech)
		{
			return default(bool);
		}

		// Token: 0x06019AB7 RID: 105143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AB7")]
		[Address(RVA = "0x127DE90", Offset = "0x127CA90", VA = "0x18127DE90")]
		private void _RefreshDevelopLineSegmentsState(int playerBaseLevel)
		{
		}

		// Token: 0x06019AB8 RID: 105144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AB8")]
		[Address(RVA = "0x127E290", Offset = "0x127CE90", VA = "0x18127E290")]
		private void _RefreshDevelopProgress(PlayerSandboxV2.Tech tech)
		{
		}

		// Token: 0x06019AB9 RID: 105145 RVA: 0x0009F018 File Offset: 0x0009D218
		[Token(Token = "0x6019AB9")]
		[Address(RVA = "0x127C8E0", Offset = "0x127B4E0", VA = "0x18127C8E0")]
		private bool _CheckIfSegmentUnlock(SandboxV2DevelopmentLineSegmentData segmentData)
		{
			return default(bool);
		}

		// Token: 0x06019ABA RID: 105146 RVA: 0x0009F030 File Offset: 0x0009D230
		[Token(Token = "0x6019ABA")]
		[Address(RVA = "0x127D040", Offset = "0x127BC40", VA = "0x18127D040")]
		private bool _IsNodeLighted(string techId)
		{
			return default(bool);
		}

		// Token: 0x06019ABB RID: 105147 RVA: 0x0009F048 File Offset: 0x0009D248
		[Token(Token = "0x6019ABB")]
		[Address(RVA = "0x127CB00", Offset = "0x127B700", VA = "0x18127CB00")]
		private SandboxV2AdminMainScienceType _GetNodeType(string techId)
		{
			return SandboxV2AdminMainScienceType.NONE;
		}

		// Token: 0x06019ABC RID: 105148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019ABC")]
		[Address(RVA = "0x127CC50", Offset = "0x127B850", VA = "0x18127CC50")]
		private SandboxV2AdminMainScienceItemViewModel _GetNodeViewModel(string techId)
		{
			return null;
		}

		// Token: 0x06019ABD RID: 105149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019ABD")]
		[Address(RVA = "0x127CE50", Offset = "0x127BA50", VA = "0x18127CE50")]
		private ListDict<string, SandboxV2AdminMainScienceItemViewModel> _GetScienceListByType(SandboxV2AdminMainScienceType techType)
		{
			return null;
		}

		// Token: 0x06019ABE RID: 105150 RVA: 0x0009F060 File Offset: 0x0009D260
		[Token(Token = "0x6019ABE")]
		[Address(RVA = "0x127CA10", Offset = "0x127B610", VA = "0x18127CA10")]
		private SANDBOX_DEVELOP_NODE_LIGHT_STATE _GetDevelopNodeLightState(bool lighted, bool levelLimited, bool frontLighted, int tokenCost)
		{
			return SANDBOX_DEVELOP_NODE_LIGHT_STATE.CANT_LIGHT_UP;
		}

		// Token: 0x06019ABF RID: 105151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019ABF")]
		[Address(RVA = "0x127CD80", Offset = "0x127B980", VA = "0x18127CD80")]
		private SandboxV2AdminMainScienceItemViewModel _GetScienceItemViewModelById(string techId)
		{
			return null;
		}

		// Token: 0x06019AC0 RID: 105152 RVA: 0x0009F078 File Offset: 0x0009D278
		[Token(Token = "0x6019AC0")]
		[Address(RVA = "0x127C620", Offset = "0x127B220", VA = "0x18127C620")]
		public bool SetSelectType(SandboxV2AdminMainScienceType scienceType, bool isInit = false)
		{
			return default(bool);
		}

		// Token: 0x17003D3F RID: 15679
		// (get) Token: 0x06019AC1 RID: 105153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003D3F")]
		public SandboxV2AdminMainScienceItemViewModel curNodeItem
		{
			[Token(Token = "0x6019AC1")]
			[Address(RVA = "0x127ED20", Offset = "0x127D920", VA = "0x18127ED20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019AC2 RID: 105154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019AC2")]
		[Address(RVA = "0x127B8E0", Offset = "0x127A4E0", VA = "0x18127B8E0")]
		public ListDict<string, SandboxV2AdminMainScienceItemViewModel> GetCurrentScienceList()
		{
			return null;
		}

		// Token: 0x06019AC3 RID: 105155 RVA: 0x0009F090 File Offset: 0x0009D290
		[Token(Token = "0x6019AC3")]
		[Address(RVA = "0x127BB00", Offset = "0x127A700", VA = "0x18127BB00")]
		public int GetCurrentScienceTypeTotalPoints()
		{
			return 0;
		}

		// Token: 0x06019AC4 RID: 105156 RVA: 0x0009F0A8 File Offset: 0x0009D2A8
		[Token(Token = "0x6019AC4")]
		[Address(RVA = "0x127BA50", Offset = "0x127A650", VA = "0x18127BA50")]
		public int GetCurrentScienceTypePointsUsed()
		{
			return 0;
		}

		// Token: 0x06019AC5 RID: 105157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019AC5")]
		[Address(RVA = "0x127B7E0", Offset = "0x127A3E0", VA = "0x18127B7E0")]
		public List<SandboxV2ScienceLineSegmentModel> GetCurrentLineList()
		{
			return null;
		}

		// Token: 0x06019AC6 RID: 105158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AC6")]
		[Address(RVA = "0x127EA50", Offset = "0x127D650", VA = "0x18127EA50")]
		public SandboxV2AdminMainSciencePanelModel()
		{
		}

		// Token: 0x04020156 RID: 131414
		[Token(Token = "0x4020156")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float X_START_OFFSET;

		// Token: 0x04020157 RID: 131415
		[Token(Token = "0x4020157")]
		[FieldOffset(Offset = "0x4")]
		private static readonly float X_END_OFFSET;

		// Token: 0x04020158 RID: 131416
		[Token(Token = "0x4020158")]
		[FieldOffset(Offset = "0x8")]
		private static readonly float X_AXIS_UNIT_SIZE;

		// Token: 0x04020159 RID: 131417
		[Token(Token = "0x4020159")]
		[FieldOffset(Offset = "0xC")]
		private static readonly float Y_AXIS_UNIT_SIZE;

		// Token: 0x0402015A RID: 131418
		[Token(Token = "0x402015A")]
		[FieldOffset(Offset = "0x10")]
		private static readonly float Y_NODE_AXIS_TOP_OFFSET;

		// Token: 0x0402015B RID: 131419
		[Token(Token = "0x402015B")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isInDungeon;

		// Token: 0x0402015C RID: 131420
		[Token(Token = "0x402015C")]
		[FieldOffset(Offset = "0x14")]
		private int m_developPointsHasCount;

		// Token: 0x0402015D RID: 131421
		[Token(Token = "0x402015D")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isAllDevelopFinish;

		// Token: 0x0402015E RID: 131422
		[Token(Token = "0x402015E")]
		[FieldOffset(Offset = "0x1C")]
		private float m_developNodeMaxYAxis;

		// Token: 0x0402015F RID: 131423
		[Token(Token = "0x402015F")]
		[FieldOffset(Offset = "0x20")]
		private float m_developNodeYPosOffset;

		// Token: 0x04020160 RID: 131424
		[Token(Token = "0x4020160")]
		[FieldOffset(Offset = "0x24")]
		private int m_firstNotLightUpRow;

		// Token: 0x04020166 RID: 131430
		[Token(Token = "0x4020166")]
		[FieldOffset(Offset = "0x48")]
		public ListDict<string, SandboxV2AdminMainScienceItemViewModel> itemViewModelDatas;

		// Token: 0x04020167 RID: 131431
		[Token(Token = "0x4020167")]
		[FieldOffset(Offset = "0x50")]
		public List<SandboxV2ScienceLineSegmentModel> lineSegmentModels;

		// Token: 0x04020168 RID: 131432
		[Token(Token = "0x4020168")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, ListDict<string, SandboxV2AdminMainScienceItemViewModel>> itemViewModelsDict;

		// Token: 0x04020169 RID: 131433
		[Token(Token = "0x4020169")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, List<SandboxV2ScienceLineSegmentModel>> lineSegDict;

		// Token: 0x0402016A RID: 131434
		[Token(Token = "0x402016A")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, float> scienceProgressDict;

		// Token: 0x0402016B RID: 131435
		[Token(Token = "0x402016B")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, int> sciencePointsUsedDict;

		// Token: 0x0402016C RID: 131436
		[Token(Token = "0x402016C")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, int> sciencePointsTotalDict;

		// Token: 0x0402016D RID: 131437
		[Token(Token = "0x402016D")]
		[FieldOffset(Offset = "0x80")]
		public Dictionary<string, float> scienceContentSizeDict;

		// Token: 0x0402016E RID: 131438
		[Token(Token = "0x402016E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402016F RID: 131439
		[Token(Token = "0x402016F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x04020170 RID: 131440
		[Token(Token = "0x4020170")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_curScienceType;

		// Token: 0x04020171 RID: 131441
		[Token(Token = "0x4020171")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_curScienceType;

		// Token: 0x04020172 RID: 131442
		[Token(Token = "0x4020172")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_selectedNodeId;

		// Token: 0x04020173 RID: 131443
		[Token(Token = "0x4020173")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_selectedNodeId;

		// Token: 0x04020174 RID: 131444
		[Token(Token = "0x4020174")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_initShow;

		// Token: 0x04020175 RID: 131445
		[Token(Token = "0x4020175")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_initShow;

		// Token: 0x04020176 RID: 131446
		[Token(Token = "0x4020176")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_needRefreshNode;

		// Token: 0x04020177 RID: 131447
		[Token(Token = "0x4020177")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_needRefreshNode;

		// Token: 0x04020178 RID: 131448
		[Token(Token = "0x4020178")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_pointsRemain;

		// Token: 0x04020179 RID: 131449
		[Token(Token = "0x4020179")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_currentNodeMaxWidth;

		// Token: 0x0402017A RID: 131450
		[Token(Token = "0x402017A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402017B RID: 131451
		[Token(Token = "0x402017B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__LoadDevelopmentBaseDatas;

		// Token: 0x0402017C RID: 131452
		[Token(Token = "0x402017C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateContentWidthByNode;

		// Token: 0x0402017D RID: 131453
		[Token(Token = "0x402017D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__LoadDevelopmentDatas;

		// Token: 0x0402017E RID: 131454
		[Token(Token = "0x402017E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetScienceTypeByTechType;

		// Token: 0x0402017F RID: 131455
		[Token(Token = "0x402017F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__LoadLineSegmentDatas;

		// Token: 0x04020180 RID: 131456
		[Token(Token = "0x4020180")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x04020181 RID: 131457
		[Token(Token = "0x4020181")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_IfNodeCanDevelop;

		// Token: 0x04020182 RID: 131458
		[Token(Token = "0x4020182")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CleanSelected;

		// Token: 0x04020183 RID: 131459
		[Token(Token = "0x4020183")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetScienceProgressByType;

		// Token: 0x04020184 RID: 131460
		[Token(Token = "0x4020184")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__RefreshDevelopTotalUsedDots;

		// Token: 0x04020185 RID: 131461
		[Token(Token = "0x4020185")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__RefreshDevelopNodesStatus;

		// Token: 0x04020186 RID: 131462
		[Token(Token = "0x4020186")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__CheckIfPreNodeLighted;

		// Token: 0x04020187 RID: 131463
		[Token(Token = "0x4020187")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__RefreshDevelopLineSegmentsState;

		// Token: 0x04020188 RID: 131464
		[Token(Token = "0x4020188")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__RefreshDevelopProgress;

		// Token: 0x04020189 RID: 131465
		[Token(Token = "0x4020189")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__CheckIfSegmentUnlock;

		// Token: 0x0402018A RID: 131466
		[Token(Token = "0x402018A")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__IsNodeLighted;

		// Token: 0x0402018B RID: 131467
		[Token(Token = "0x402018B")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__GetNodeType;

		// Token: 0x0402018C RID: 131468
		[Token(Token = "0x402018C")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__GetNodeViewModel;

		// Token: 0x0402018D RID: 131469
		[Token(Token = "0x402018D")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__GetScienceListByType;

		// Token: 0x0402018E RID: 131470
		[Token(Token = "0x402018E")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__GetDevelopNodeLightState;

		// Token: 0x0402018F RID: 131471
		[Token(Token = "0x402018F")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__GetScienceItemViewModelById;

		// Token: 0x04020190 RID: 131472
		[Token(Token = "0x4020190")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_SetSelectType;

		// Token: 0x04020191 RID: 131473
		[Token(Token = "0x4020191")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_curNodeItem;

		// Token: 0x04020192 RID: 131474
		[Token(Token = "0x4020192")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GetCurrentScienceList;

		// Token: 0x04020193 RID: 131475
		[Token(Token = "0x4020193")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GetCurrentScienceTypeTotalPoints;

		// Token: 0x04020194 RID: 131476
		[Token(Token = "0x4020194")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_GetCurrentScienceTypePointsUsed;

		// Token: 0x04020195 RID: 131477
		[Token(Token = "0x4020195")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_GetCurrentLineList;

		// Token: 0x04020196 RID: 131478
		[Token(Token = "0x4020196")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
