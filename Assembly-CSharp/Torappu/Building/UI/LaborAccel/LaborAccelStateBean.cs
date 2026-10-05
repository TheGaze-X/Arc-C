using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.LaborAccel
{
	// Token: 0x02001DB7 RID: 7607
	[Token(Token = "0x2001DB7")]
	public class LaborAccelStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x0600BB88 RID: 48008 RVA: 0x00045F30 File Offset: 0x00044130
		// (set) Token: 0x0600BB89 RID: 48009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170016AF")]
		public int accelCount
		{
			[Token(Token = "0x600BB88")]
			[Address(RVA = "0x3397CC0", Offset = "0x33968C0", VA = "0x183397CC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600BB89")]
			[Address(RVA = "0x3398140", Offset = "0x3396D40", VA = "0x183398140")]
			set
			{
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x0600BB8A RID: 48010 RVA: 0x00045F48 File Offset: 0x00044148
		// (set) Token: 0x0600BB8B RID: 48011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170016B0")]
		public long costLabor
		{
			[Token(Token = "0x600BB8A")]
			[Address(RVA = "0x3397E40", Offset = "0x3396A40", VA = "0x183397E40")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600BB8B")]
			[Address(RVA = "0x3398240", Offset = "0x3396E40", VA = "0x183398240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x0600BB8C RID: 48012 RVA: 0x00045F60 File Offset: 0x00044160
		[Token(Token = "0x170016B1")]
		public int accelTime
		{
			[Token(Token = "0x600BB8C")]
			[Address(RVA = "0x3397DE0", Offset = "0x33969E0", VA = "0x183397DE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x0600BB8D RID: 48013 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600BB8E RID: 48014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170016B2")]
		public string accelTimeText
		{
			[Token(Token = "0x600BB8D")]
			[Address(RVA = "0x3397D80", Offset = "0x3396980", VA = "0x183397D80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600BB8E")]
			[Address(RVA = "0x33981C0", Offset = "0x3396DC0", VA = "0x1833981C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x0600BB8F RID: 48015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016B3")]
		public string descTitle
		{
			[Token(Token = "0x600BB8F")]
			[Address(RVA = "0x3397F00", Offset = "0x3396B00", VA = "0x183397F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x0600BB90 RID: 48016 RVA: 0x00045F78 File Offset: 0x00044178
		// (set) Token: 0x0600BB91 RID: 48017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170016B4")]
		public bool isMaxReached
		{
			[Token(Token = "0x600BB90")]
			[Address(RVA = "0x3397F60", Offset = "0x3396B60", VA = "0x183397F60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600BB91")]
			[Address(RVA = "0x33982B0", Offset = "0x3396EB0", VA = "0x1833982B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x0600BB92 RID: 48018 RVA: 0x00045F90 File Offset: 0x00044190
		// (set) Token: 0x0600BB93 RID: 48019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170016B5")]
		public bool isMinReached
		{
			[Token(Token = "0x600BB92")]
			[Address(RVA = "0x3397FC0", Offset = "0x3396BC0", VA = "0x183397FC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600BB93")]
			[Address(RVA = "0x3398320", Offset = "0x3396F20", VA = "0x183398320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x0600BB94 RID: 48020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016B6")]
		public StringProperty remainTimeProp
		{
			[Token(Token = "0x600BB94")]
			[Address(RVA = "0x3398020", Offset = "0x3396C20", VA = "0x183398020")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x0600BB95 RID: 48021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016B7")]
		public StringProperty curLaborProp
		{
			[Token(Token = "0x600BB95")]
			[Address(RVA = "0x3397EA0", Offset = "0x3396AA0", VA = "0x183397EA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x0600BB96 RID: 48022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016B8")]
		public StringProperty wasteTimeProp
		{
			[Token(Token = "0x600BB96")]
			[Address(RVA = "0x33980E0", Offset = "0x3396CE0", VA = "0x1833980E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x0600BB97 RID: 48023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016B9")]
		public BuildingLaborAccelState.AccelResultProperty accelResultProp
		{
			[Token(Token = "0x600BB97")]
			[Address(RVA = "0x3397D20", Offset = "0x3396920", VA = "0x183397D20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600BB98 RID: 48024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB98")]
		[Address(RVA = "0x3396C00", Offset = "0x3395800", VA = "0x183396C00")]
		public void Tick()
		{
		}

		// Token: 0x0600BB99 RID: 48025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB99")]
		[Address(RVA = "0x33969C0", Offset = "0x33955C0", VA = "0x1833969C0")]
		public void SetInput(LaborAccelStateBean.Input input)
		{
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x0600BB9A RID: 48026 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600BB9B RID: 48027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170016BA")]
		public BuildingLaborAccelState.IPlugin statePlugin
		{
			[Token(Token = "0x600BB9A")]
			[Address(RVA = "0x3398080", Offset = "0x3396C80", VA = "0x183398080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600BB9B")]
			[Address(RVA = "0x3398390", Offset = "0x3396F90", VA = "0x183398390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600BB9C RID: 48028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB9C")]
		[Address(RVA = "0x3396940", Offset = "0x3395540", VA = "0x183396940")]
		public void ClearInput()
		{
		}

		// Token: 0x0600BB9D RID: 48029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB9D")]
		[Address(RVA = "0x3396C80", Offset = "0x3395880", VA = "0x183396C80")]
		public void UpdateData()
		{
		}

		// Token: 0x0600BB9E RID: 48030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB9E")]
		[Address(RVA = "0x33976F0", Offset = "0x33962F0", VA = "0x1833976F0")]
		private void _OnCurLaborChanged(BuildingLaborViewModel laborModel)
		{
		}

		// Token: 0x0600BB9F RID: 48031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB9F")]
		[Address(RVA = "0x33977E0", Offset = "0x33963E0", VA = "0x1833977E0")]
		private void _OnRemainTimeChanged(CountDownTask.TickValue tick)
		{
		}

		// Token: 0x0600BBA0 RID: 48032 RVA: 0x00045FA8 File Offset: 0x000441A8
		[Token(Token = "0x600BBA0")]
		[Address(RVA = "0x3397420", Offset = "0x3396020", VA = "0x183397420")]
		private LaborAccelStateBean.RemainTimeContext _CalcRemainTime()
		{
			return default(LaborAccelStateBean.RemainTimeContext);
		}

		// Token: 0x0600BBA1 RID: 48033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBA1")]
		[Address(RVA = "0x3397AB0", Offset = "0x33966B0", VA = "0x183397AB0")]
		public LaborAccelStateBean()
		{
		}

		// Token: 0x0400BB47 RID: 47943
		[Token(Token = "0x400BB47")]
		private const string TIME_FORMAT = "{0:d2}:{1:d2}:{2:d2}";

		// Token: 0x0400BB48 RID: 47944
		[Token(Token = "0x400BB48")]
		[FieldOffset(Offset = "0x10")]
		private LaborAccelStateBean.Input m_input;

		// Token: 0x0400BB49 RID: 47945
		[Token(Token = "0x400BB49")]
		[FieldOffset(Offset = "0x48")]
		private CountDownTask m_remainTimeCountDown;

		// Token: 0x0400BB4A RID: 47946
		[Token(Token = "0x400BB4A")]
		[FieldOffset(Offset = "0x50")]
		private BuildingLaborViewModel m_laborModel;

		// Token: 0x0400BB4B RID: 47947
		[Token(Token = "0x400BB4B")]
		[FieldOffset(Offset = "0x58")]
		private StringProperty m_remainTimeProp;

		// Token: 0x0400BB4C RID: 47948
		[Token(Token = "0x400BB4C")]
		[FieldOffset(Offset = "0x60")]
		private StringProperty m_curLaborProp;

		// Token: 0x0400BB4D RID: 47949
		[Token(Token = "0x400BB4D")]
		[FieldOffset(Offset = "0x68")]
		private StringProperty m_wasteTimeAlert;

		// Token: 0x0400BB4E RID: 47950
		[Token(Token = "0x400BB4E")]
		[FieldOffset(Offset = "0x70")]
		private BuildingLaborAccelState.AccelResultProperty m_accelResultProp;

		// Token: 0x0400BB4F RID: 47951
		[Token(Token = "0x400BB4F")]
		[FieldOffset(Offset = "0x78")]
		private int m_accelCount;

		// Token: 0x0400BB50 RID: 47952
		[Token(Token = "0x400BB50")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_isShowingWasteTimeAlert;

		// Token: 0x0400BB51 RID: 47953
		[Token(Token = "0x400BB51")]
		[FieldOffset(Offset = "0x80")]
		public Action eventOnCountInvalid;

		// Token: 0x0400BB57 RID: 47959
		[Token(Token = "0x400BB57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_accelCount;

		// Token: 0x0400BB58 RID: 47960
		[Token(Token = "0x400BB58")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_accelCount;

		// Token: 0x0400BB59 RID: 47961
		[Token(Token = "0x400BB59")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_costLabor;

		// Token: 0x0400BB5A RID: 47962
		[Token(Token = "0x400BB5A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_costLabor;

		// Token: 0x0400BB5B RID: 47963
		[Token(Token = "0x400BB5B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_accelTime;

		// Token: 0x0400BB5C RID: 47964
		[Token(Token = "0x400BB5C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_accelTimeText;

		// Token: 0x0400BB5D RID: 47965
		[Token(Token = "0x400BB5D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_accelTimeText;

		// Token: 0x0400BB5E RID: 47966
		[Token(Token = "0x400BB5E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_descTitle;

		// Token: 0x0400BB5F RID: 47967
		[Token(Token = "0x400BB5F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isMaxReached;

		// Token: 0x0400BB60 RID: 47968
		[Token(Token = "0x400BB60")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isMaxReached;

		// Token: 0x0400BB61 RID: 47969
		[Token(Token = "0x400BB61")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isMinReached;

		// Token: 0x0400BB62 RID: 47970
		[Token(Token = "0x400BB62")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_isMinReached;

		// Token: 0x0400BB63 RID: 47971
		[Token(Token = "0x400BB63")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_remainTimeProp;

		// Token: 0x0400BB64 RID: 47972
		[Token(Token = "0x400BB64")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_curLaborProp;

		// Token: 0x0400BB65 RID: 47973
		[Token(Token = "0x400BB65")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_wasteTimeProp;

		// Token: 0x0400BB66 RID: 47974
		[Token(Token = "0x400BB66")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_accelResultProp;

		// Token: 0x0400BB67 RID: 47975
		[Token(Token = "0x400BB67")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x0400BB68 RID: 47976
		[Token(Token = "0x400BB68")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SetInput;

		// Token: 0x0400BB69 RID: 47977
		[Token(Token = "0x400BB69")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_statePlugin;

		// Token: 0x0400BB6A RID: 47978
		[Token(Token = "0x400BB6A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_statePlugin;

		// Token: 0x0400BB6B RID: 47979
		[Token(Token = "0x400BB6B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ClearInput;

		// Token: 0x0400BB6C RID: 47980
		[Token(Token = "0x400BB6C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0400BB6D RID: 47981
		[Token(Token = "0x400BB6D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnCurLaborChanged;

		// Token: 0x0400BB6E RID: 47982
		[Token(Token = "0x400BB6E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnRemainTimeChanged;

		// Token: 0x0400BB6F RID: 47983
		[Token(Token = "0x400BB6F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CalcRemainTime;

		// Token: 0x0400BB70 RID: 47984
		[Token(Token = "0x400BB70")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001DB8 RID: 7608
		[Token(Token = "0x2001DB8")]
		public struct Input
		{
			// Token: 0x170016BB RID: 5819
			// (get) Token: 0x0600BBA2 RID: 48034 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600BBA3 RID: 48035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170016BB")]
			public Type pluginType
			{
				[Token(Token = "0x600BBA2")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x600BBA3")]
				[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170016BC RID: 5820
			// (get) Token: 0x0600BBA4 RID: 48036 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600BBA5 RID: 48037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170016BC")]
			public object pluginContext
			{
				[Token(Token = "0x600BBA4")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x600BBA5")]
				[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600BBA6 RID: 48038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BBA6")]
			public void SetPlugin<TPlugin, TContext>(TContext context) where TPlugin : BuildingLaborAccelState.IPlugin, new()
			{
			}

			// Token: 0x0400BB71 RID: 47985
			[Token(Token = "0x400BB71")]
			[FieldOffset(Offset = "0x0")]
			public string descTitle;

			// Token: 0x0400BB72 RID: 47986
			[Token(Token = "0x400BB72")]
			[FieldOffset(Offset = "0x8")]
			public int accelTimeUnit;

			// Token: 0x0400BB73 RID: 47987
			[Token(Token = "0x400BB73")]
			[FieldOffset(Offset = "0xC")]
			public int laborCostUnit;

			// Token: 0x0400BB74 RID: 47988
			[Token(Token = "0x400BB74")]
			[FieldOffset(Offset = "0x10")]
			public double remainPoint;

			// Token: 0x0400BB75 RID: 47989
			[Token(Token = "0x400BB75")]
			[FieldOffset(Offset = "0x18")]
			public DateTime lastUpdateTime;

			// Token: 0x0400BB76 RID: 47990
			[Token(Token = "0x400BB76")]
			[FieldOffset(Offset = "0x20")]
			public double speed;
		}

		// Token: 0x02001DB9 RID: 7609
		[Token(Token = "0x2001DB9")]
		private struct RemainTimeContext
		{
			// Token: 0x0400BB79 RID: 47993
			[Token(Token = "0x400BB79")]
			[FieldOffset(Offset = "0x0")]
			public double curRemainPoint;

			// Token: 0x0400BB7A RID: 47994
			[Token(Token = "0x400BB7A")]
			[FieldOffset(Offset = "0x8")]
			public int maxAccelCount;
		}
	}
}
