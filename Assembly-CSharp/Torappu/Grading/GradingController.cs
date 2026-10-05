using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Setting;
using XLua;

namespace Torappu.Grading
{
	// Token: 0x0200163B RID: 5691
	[Token(Token = "0x200163B")]
	public class GradingController : Singleton<GradingController>, ILuaCallCSharp, IHotfixable
	{
		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x0600811F RID: 33055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F4E")]
		public static string GRADING_EXPIRE_FUNC_VERSION
		{
			[Token(Token = "0x600811F")]
			[Address(RVA = "0x2B06300", Offset = "0x2B04F00", VA = "0x182B06300")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06008120 RID: 33056 RVA: 0x000385E0 File Offset: 0x000367E0
		// (set) Token: 0x06008121 RID: 33057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000F4F")]
		public GradingController.SimulatorStatus simulatorStatus
		{
			[Token(Token = "0x6008120")]
			[Address(RVA = "0x2B06410", Offset = "0x2B05010", VA = "0x182B06410")]
			[CompilerGenerated]
			get
			{
				return GradingController.SimulatorStatus.NODEFINE;
			}
			[Token(Token = "0x6008121")]
			[Address(RVA = "0x2B06470", Offset = "0x2B05070", VA = "0x182B06470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06008122 RID: 33058 RVA: 0x000385F8 File Offset: 0x000367F8
		[Token(Token = "0x17000F50")]
		public bool isSimulator
		{
			[Token(Token = "0x6008122")]
			[Address(RVA = "0x2B06360", Offset = "0x2B04F60", VA = "0x182B06360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06008123 RID: 33059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008123")]
		[Address(RVA = "0x2B06110", Offset = "0x2B04D10", VA = "0x182B06110")]
		protected GradingController()
		{
		}

		// Token: 0x06008124 RID: 33060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008124")]
		[Address(RVA = "0x2B05B80", Offset = "0x2B04780", VA = "0x182B05B80")]
		private void _Init()
		{
		}

		// Token: 0x06008125 RID: 33061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008125")]
		[Address(RVA = "0x2B05B20", Offset = "0x2B04720", VA = "0x182B05B20")]
		private void _InitQualityLevel()
		{
		}

		// Token: 0x06008126 RID: 33062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008126")]
		[Address(RVA = "0x2B05D20", Offset = "0x2B04920", VA = "0x182B05D20")]
		private void _OnSettingChange(SettingConstVars.SettingType type)
		{
		}

		// Token: 0x06008127 RID: 33063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008127")]
		[Address(RVA = "0x2B04CD0", Offset = "0x2B038D0", VA = "0x182B04CD0")]
		public void InitGradingSetting()
		{
		}

		// Token: 0x06008128 RID: 33064 RVA: 0x00038610 File Offset: 0x00036810
		[Token(Token = "0x6008128")]
		[Address(RVA = "0x2B05220", Offset = "0x2B03E20", VA = "0x182B05220")]
		private GradingController.GradingResultExpireState _CheckGradingResultExpired()
		{
			return GradingController.GradingResultExpireState.NOT_EXIST;
		}

		// Token: 0x06008129 RID: 33065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008129")]
		[Address(RVA = "0x2B05DA0", Offset = "0x2B049A0", VA = "0x182B05DA0")]
		private void _ResetSettingsAfterAutoGrading(GradingController.GradingResultExpireState expireState)
		{
		}

		// Token: 0x0600812A RID: 33066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600812A")]
		[Address(RVA = "0x2B053F0", Offset = "0x2B03FF0", VA = "0x182B053F0")]
		private void _DoGradingStepFinish(HGGradingDetector.GradingResult result)
		{
		}

		// Token: 0x0600812B RID: 33067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600812B")]
		[Address(RVA = "0x2B04DE0", Offset = "0x2B039E0", VA = "0x182B04DE0")]
		public void UpdatePPGradingSetting()
		{
		}

		// Token: 0x0600812C RID: 33068 RVA: 0x00038628 File Offset: 0x00036828
		[Token(Token = "0x600812C")]
		[Address(RVA = "0x2B04A00", Offset = "0x2B03600", VA = "0x182B04A00")]
		public bool GetGradingSetting(GradingController.GradingSetting setting)
		{
			return default(bool);
		}

		// Token: 0x0600812D RID: 33069 RVA: 0x00038640 File Offset: 0x00036840
		[Token(Token = "0x600812D")]
		[Address(RVA = "0x2B046A0", Offset = "0x2B032A0", VA = "0x182B046A0")]
		public bool GetGradingSetting(GradingController.GradingSetting setting, GradingController.GradingLevel level)
		{
			return default(bool);
		}

		// Token: 0x0600812E RID: 33070 RVA: 0x00038658 File Offset: 0x00036858
		[Token(Token = "0x600812E")]
		[Address(RVA = "0x2B05860", Offset = "0x2B04460", VA = "0x182B05860")]
		private bool _Get_PP_COLORGRADING_ViaLevel(GradingController.GradingLevel level)
		{
			return default(bool);
		}

		// Token: 0x0600812F RID: 33071 RVA: 0x00038670 File Offset: 0x00036870
		[Token(Token = "0x600812F")]
		[Address(RVA = "0x2B057D0", Offset = "0x2B043D0", VA = "0x182B057D0")]
		private bool _Get_PP_BLOOM_ViaLevel(GradingController.GradingLevel level)
		{
			return default(bool);
		}

		// Token: 0x06008130 RID: 33072 RVA: 0x00038688 File Offset: 0x00036888
		[Token(Token = "0x6008130")]
		[Address(RVA = "0x2B058E0", Offset = "0x2B044E0", VA = "0x182B058E0")]
		private bool _Get_PP_VIGNETTE_ViaLevel(GradingController.GradingLevel level)
		{
			return default(bool);
		}

		// Token: 0x06008131 RID: 33073 RVA: 0x000386A0 File Offset: 0x000368A0
		[Token(Token = "0x6008131")]
		[Address(RVA = "0x2B055A0", Offset = "0x2B041A0", VA = "0x182B055A0")]
		private bool _Get_BUILDING_BLOOM_ViaLevel(GradingController.GradingLevel level)
		{
			return default(bool);
		}

		// Token: 0x06008132 RID: 33074 RVA: 0x000386B8 File Offset: 0x000368B8
		[Token(Token = "0x6008132")]
		[Address(RVA = "0x2B05A90", Offset = "0x2B04690", VA = "0x182B05A90")]
		private bool _Get_SP_WATEREFFECT_ViaLevel(GradingController.GradingLevel level)
		{
			return default(bool);
		}

		// Token: 0x06008133 RID: 33075 RVA: 0x000386D0 File Offset: 0x000368D0
		[Token(Token = "0x6008133")]
		[Address(RVA = "0x2B05A00", Offset = "0x2B04600", VA = "0x182B05A00")]
		private bool _Get_SP_SHADOWCAMERA_ViaLevel(GradingController.GradingLevel level)
		{
			return default(bool);
		}

		// Token: 0x06008134 RID: 33076 RVA: 0x000386E8 File Offset: 0x000368E8
		[Token(Token = "0x6008134")]
		[Address(RVA = "0x2B05970", Offset = "0x2B04570", VA = "0x182B05970")]
		private bool _Get_SP_ADDITIONAL_LIGHT_ViaLevel(GradingController.GradingLevel level)
		{
			return default(bool);
		}

		// Token: 0x06008135 RID: 33077 RVA: 0x00038700 File Offset: 0x00036900
		[Token(Token = "0x6008135")]
		[Address(RVA = "0x2B05630", Offset = "0x2B04230", VA = "0x182B05630")]
		private bool _Get_EnableHighLevelEffect_ViaLevel(GradingController.GradingLevel level)
		{
			return default(bool);
		}

		// Token: 0x06008136 RID: 33078 RVA: 0x00038718 File Offset: 0x00036918
		[Token(Token = "0x6008136")]
		[Address(RVA = "0x2B056C0", Offset = "0x2B042C0", VA = "0x182B056C0")]
		private bool _Get_EnableLargeDynIllust_ViaLevel(GradingController.GradingLevel level)
		{
			return default(bool);
		}

		// Token: 0x06008137 RID: 33079 RVA: 0x00038730 File Offset: 0x00036930
		[Token(Token = "0x6008137")]
		[Address(RVA = "0x2B05730", Offset = "0x2B04330", VA = "0x182B05730")]
		private GradingController.FpsStrategyType _Get_FPS_STRATEGY_ViaLevel(GradingController.GradingLevel level)
		{
			return GradingController.FpsStrategyType.FPS_STRATEGY_30;
		}

		// Token: 0x06008138 RID: 33080 RVA: 0x00038748 File Offset: 0x00036948
		[Token(Token = "0x6008138")]
		[Address(RVA = "0x2B05510", Offset = "0x2B04110", VA = "0x182B05510")]
		private bool _Get_AntialiasingFlag_ViaLevel(GradingController.GradingLevel level, GradingController.SimulatorStatus simulator)
		{
			return default(bool);
		}

		// Token: 0x06008139 RID: 33081 RVA: 0x00038760 File Offset: 0x00036960
		[Token(Token = "0x6008139")]
		[Address(RVA = "0x2B04C20", Offset = "0x2B03820", VA = "0x182B04C20")]
		public int GetValidIndexOfLevel(GradingController.GradingLevel level)
		{
			return 0;
		}

		// Token: 0x0600813A RID: 33082 RVA: 0x00038778 File Offset: 0x00036978
		[Token(Token = "0x600813A")]
		[Address(RVA = "0x2B04B70", Offset = "0x2B03770", VA = "0x182B04B70")]
		public GradingController.GradingLevel GetLevelViaIndex(int index)
		{
			return GradingController.GradingLevel.NODEFINE;
		}

		// Token: 0x040082C2 RID: 33474
		[Token(Token = "0x40082C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_GRADING_EXPIRE_FUNC_VERSION;

		// Token: 0x040082C3 RID: 33475
		[Token(Token = "0x40082C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_simulatorStatus;

		// Token: 0x040082C4 RID: 33476
		[Token(Token = "0x40082C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_simulatorStatus;

		// Token: 0x040082C5 RID: 33477
		[Token(Token = "0x40082C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isSimulator;

		// Token: 0x040082C6 RID: 33478
		[Token(Token = "0x40082C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040082C7 RID: 33479
		[Token(Token = "0x40082C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x040082C8 RID: 33480
		[Token(Token = "0x40082C8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitQualityLevel;

		// Token: 0x040082C9 RID: 33481
		[Token(Token = "0x40082C9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnSettingChange;

		// Token: 0x040082CA RID: 33482
		[Token(Token = "0x40082CA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_InitGradingSetting;

		// Token: 0x040082CB RID: 33483
		[Token(Token = "0x40082CB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckGradingResultExpired;

		// Token: 0x040082CC RID: 33484
		[Token(Token = "0x40082CC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ResetSettingsAfterAutoGrading;

		// Token: 0x040082CD RID: 33485
		[Token(Token = "0x40082CD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DoGradingStepFinish;

		// Token: 0x040082CE RID: 33486
		[Token(Token = "0x40082CE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdatePPGradingSetting;

		// Token: 0x040082CF RID: 33487
		[Token(Token = "0x40082CF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetGradingSetting;

		// Token: 0x040082D0 RID: 33488
		[Token(Token = "0x40082D0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_GetGradingSetting;

		// Token: 0x040082D1 RID: 33489
		[Token(Token = "0x40082D1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__Get_PP_COLORGRADING_ViaLevel;

		// Token: 0x040082D2 RID: 33490
		[Token(Token = "0x40082D2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__Get_PP_BLOOM_ViaLevel;

		// Token: 0x040082D3 RID: 33491
		[Token(Token = "0x40082D3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__Get_PP_VIGNETTE_ViaLevel;

		// Token: 0x040082D4 RID: 33492
		[Token(Token = "0x40082D4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__Get_BUILDING_BLOOM_ViaLevel;

		// Token: 0x040082D5 RID: 33493
		[Token(Token = "0x40082D5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__Get_SP_WATEREFFECT_ViaLevel;

		// Token: 0x040082D6 RID: 33494
		[Token(Token = "0x40082D6")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__Get_SP_SHADOWCAMERA_ViaLevel;

		// Token: 0x040082D7 RID: 33495
		[Token(Token = "0x40082D7")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__Get_SP_ADDITIONAL_LIGHT_ViaLevel;

		// Token: 0x040082D8 RID: 33496
		[Token(Token = "0x40082D8")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__Get_EnableHighLevelEffect_ViaLevel;

		// Token: 0x040082D9 RID: 33497
		[Token(Token = "0x40082D9")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__Get_EnableLargeDynIllust_ViaLevel;

		// Token: 0x040082DA RID: 33498
		[Token(Token = "0x40082DA")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__Get_FPS_STRATEGY_ViaLevel;

		// Token: 0x040082DB RID: 33499
		[Token(Token = "0x40082DB")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__Get_AntialiasingFlag_ViaLevel;

		// Token: 0x040082DC RID: 33500
		[Token(Token = "0x40082DC")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetValidIndexOfLevel;

		// Token: 0x040082DD RID: 33501
		[Token(Token = "0x40082DD")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetLevelViaIndex;

		// Token: 0x0200163C RID: 5692
		[Token(Token = "0x200163C")]
		public enum GradingResultExpireState
		{
			// Token: 0x040082DF RID: 33503
			[Token(Token = "0x40082DF")]
			NOT_EXIST,
			// Token: 0x040082E0 RID: 33504
			[Token(Token = "0x40082E0")]
			AVAILABLE,
			// Token: 0x040082E1 RID: 33505
			[Token(Token = "0x40082E1")]
			EXPIRED
		}

		// Token: 0x0200163D RID: 5693
		[Token(Token = "0x200163D")]
		public enum FpsStrategyType
		{
			// Token: 0x040082E3 RID: 33507
			[Token(Token = "0x40082E3")]
			FPS_STRATEGY_30,
			// Token: 0x040082E4 RID: 33508
			[Token(Token = "0x40082E4")]
			FPS_STRATEGY_60,
			// Token: 0x040082E5 RID: 33509
			[Token(Token = "0x40082E5")]
			FPS_STRATEGY_120,
			// Token: 0x040082E6 RID: 33510
			[Token(Token = "0x40082E6")]
			E_NUM
		}

		// Token: 0x0200163E RID: 5694
		[Token(Token = "0x200163E")]
		public enum GradingSetting
		{
			// Token: 0x040082E8 RID: 33512
			[Token(Token = "0x40082E8")]
			PP_COLORGRADING,
			// Token: 0x040082E9 RID: 33513
			[Token(Token = "0x40082E9")]
			PP_BLOOM,
			// Token: 0x040082EA RID: 33514
			[Token(Token = "0x40082EA")]
			PP_VIGNETTE,
			// Token: 0x040082EB RID: 33515
			[Token(Token = "0x40082EB")]
			BUILDING_BLOOM,
			// Token: 0x040082EC RID: 33516
			[Token(Token = "0x40082EC")]
			SP_WATEREFFECT,
			// Token: 0x040082ED RID: 33517
			[Token(Token = "0x40082ED")]
			SP_SHADOWCAMERA,
			// Token: 0x040082EE RID: 33518
			[Token(Token = "0x40082EE")]
			HIGH_LEVEL_EFFECT,
			// Token: 0x040082EF RID: 33519
			[Token(Token = "0x40082EF")]
			LARGE_DYN_ILLUST,
			// Token: 0x040082F0 RID: 33520
			[Token(Token = "0x40082F0")]
			UI_BLUR_GLASS,
			// Token: 0x040082F1 RID: 33521
			[Token(Token = "0x40082F1")]
			SP_ADDITIONAL_LIGHT
		}

		// Token: 0x0200163F RID: 5695
		[Token(Token = "0x200163F")]
		public enum GradingLevel
		{
			// Token: 0x040082F3 RID: 33523
			[Token(Token = "0x40082F3")]
			NODEFINE,
			// Token: 0x040082F4 RID: 33524
			[Token(Token = "0x40082F4")]
			LOW,
			// Token: 0x040082F5 RID: 33525
			[Token(Token = "0x40082F5")]
			MEDIUM,
			// Token: 0x040082F6 RID: 33526
			[Token(Token = "0x40082F6")]
			HIGH
		}

		// Token: 0x02001640 RID: 5696
		[Token(Token = "0x2001640")]
		public enum SimulatorStatus
		{
			// Token: 0x040082F8 RID: 33528
			[Token(Token = "0x40082F8")]
			NODEFINE,
			// Token: 0x040082F9 RID: 33529
			[Token(Token = "0x40082F9")]
			YES,
			// Token: 0x040082FA RID: 33530
			[Token(Token = "0x40082FA")]
			NO
		}
	}
}
