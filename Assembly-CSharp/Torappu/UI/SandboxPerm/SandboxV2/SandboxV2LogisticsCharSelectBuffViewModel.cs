using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004059 RID: 16473
	[Token(Token = "0x2004059")]
	public class SandboxV2LogisticsCharSelectBuffViewModel : IHotfixable
	{
		// Token: 0x17003CAB RID: 15531
		// (get) Token: 0x060197B3 RID: 104371 RVA: 0x0009E430 File Offset: 0x0009C630
		// (set) Token: 0x060197B2 RID: 104370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CAB")]
		public int index
		{
			[Token(Token = "0x60197B3")]
			[Address(RVA = "0x123EB70", Offset = "0x123D770", VA = "0x18123EB70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60197B2")]
			[Address(RVA = "0x123EC30", Offset = "0x123D830", VA = "0x18123EC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003CAC RID: 15532
		// (get) Token: 0x060197B4 RID: 104372 RVA: 0x0009E448 File Offset: 0x0009C648
		[Token(Token = "0x17003CAC")]
		public bool isFullBuff
		{
			[Token(Token = "0x60197B4")]
			[Address(RVA = "0x123EBD0", Offset = "0x123D7D0", VA = "0x18123EBD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003CAD RID: 15533
		// (get) Token: 0x060197B5 RID: 104373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003CAD")]
		public string fullDesc
		{
			[Token(Token = "0x60197B5")]
			[Address(RVA = "0x123EB00", Offset = "0x123D700", VA = "0x18123EB00")]
			get
			{
				return null;
			}
		}

		// Token: 0x060197B6 RID: 104374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197B6")]
		[Address(RVA = "0x123E600", Offset = "0x123D200", VA = "0x18123E600")]
		public void InitData(SandboxV2Data sandboxV2Data, ProfessionCategory professionCategory, int index)
		{
		}

		// Token: 0x060197B7 RID: 104375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197B7")]
		[Address(RVA = "0x123E430", Offset = "0x123D030", VA = "0x18123E430")]
		public void AddCharInBuffViewModel(SandboxV2CharViewModel charViewModel)
		{
		}

		// Token: 0x060197B8 RID: 104376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197B8")]
		[Address(RVA = "0x123E770", Offset = "0x123D370", VA = "0x18123E770")]
		public void RemoveCharInBuffViewModel(SandboxV2CharViewModel charViewModel)
		{
		}

		// Token: 0x060197B9 RID: 104377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197B9")]
		[Address(RVA = "0x123E570", Offset = "0x123D170", VA = "0x18123E570")]
		public void ClearCharsInBuffViewModel()
		{
		}

		// Token: 0x060197BA RID: 104378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60197BA")]
		[Address(RVA = "0x123E8D0", Offset = "0x123D4D0", VA = "0x18123E8D0")]
		private SandboxV2LogisticsData _GetLogisticsDataByProfession(SandboxV2Data gameData, ProfessionCategory professionCategory)
		{
			return null;
		}

		// Token: 0x060197BB RID: 104379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197BB")]
		[Address(RVA = "0x123EAA0", Offset = "0x123D6A0", VA = "0x18123EAA0")]
		public SandboxV2LogisticsCharSelectBuffViewModel()
		{
		}

		// Token: 0x0401FC22 RID: 130082
		[Token(Token = "0x401FC22")]
		[FieldOffset(Offset = "0x10")]
		public ProfessionCategory professionCategory;

		// Token: 0x0401FC23 RID: 130083
		[Token(Token = "0x401FC23")]
		[FieldOffset(Offset = "0x14")]
		public int maxValidBuffCount;

		// Token: 0x0401FC24 RID: 130084
		[Token(Token = "0x401FC24")]
		[FieldOffset(Offset = "0x18")]
		public int currentBuffCount;

		// Token: 0x0401FC25 RID: 130085
		[Token(Token = "0x401FC25")]
		[FieldOffset(Offset = "0x20")]
		public string buffParam;

		// Token: 0x0401FC26 RID: 130086
		[Token(Token = "0x401FC26")]
		[FieldOffset(Offset = "0x28")]
		private SandboxV2LogisticsData m_logisticsData;

		// Token: 0x0401FC27 RID: 130087
		[Token(Token = "0x401FC27")]
		[FieldOffset(Offset = "0x30")]
		private string m_noBuffDesc;

		// Token: 0x0401FC28 RID: 130088
		[Token(Token = "0x401FC28")]
		[FieldOffset(Offset = "0x38")]
		private string m_formatDesc;

		// Token: 0x0401FC2A RID: 130090
		[Token(Token = "0x401FC2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_index;

		// Token: 0x0401FC2B RID: 130091
		[Token(Token = "0x401FC2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_index;

		// Token: 0x0401FC2C RID: 130092
		[Token(Token = "0x401FC2C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isFullBuff;

		// Token: 0x0401FC2D RID: 130093
		[Token(Token = "0x401FC2D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_fullDesc;

		// Token: 0x0401FC2E RID: 130094
		[Token(Token = "0x401FC2E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401FC2F RID: 130095
		[Token(Token = "0x401FC2F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AddCharInBuffViewModel;

		// Token: 0x0401FC30 RID: 130096
		[Token(Token = "0x401FC30")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RemoveCharInBuffViewModel;

		// Token: 0x0401FC31 RID: 130097
		[Token(Token = "0x401FC31")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ClearCharsInBuffViewModel;

		// Token: 0x0401FC32 RID: 130098
		[Token(Token = "0x401FC32")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetLogisticsDataByProfession;

		// Token: 0x0401FC33 RID: 130099
		[Token(Token = "0x401FC33")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
