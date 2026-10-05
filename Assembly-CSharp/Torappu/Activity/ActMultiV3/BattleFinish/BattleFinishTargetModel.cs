using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x020070A0 RID: 28832
	[Token(Token = "0x20070A0")]
	public class BattleFinishTargetModel : IHotfixable
	{
		// Token: 0x1700611A RID: 24858
		// (get) Token: 0x06028FB7 RID: 167863 RVA: 0x000D3E60 File Offset: 0x000D2060
		// (set) Token: 0x06028FB8 RID: 167864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700611A")]
		public int index
		{
			[Token(Token = "0x6028FB7")]
			[Address(RVA = "0x2474900", Offset = "0x2473500", VA = "0x182474900")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028FB8")]
			[Address(RVA = "0x2474D00", Offset = "0x2473900", VA = "0x182474D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700611B RID: 24859
		// (get) Token: 0x06028FB9 RID: 167865 RVA: 0x000D3E78 File Offset: 0x000D2078
		// (set) Token: 0x06028FBA RID: 167866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700611B")]
		public float currentVal
		{
			[Token(Token = "0x6028FB9")]
			[Address(RVA = "0x24748A0", Offset = "0x24734A0", VA = "0x1824748A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6028FBA")]
			[Address(RVA = "0x2474C90", Offset = "0x2473890", VA = "0x182474C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700611C RID: 24860
		// (get) Token: 0x06028FBB RID: 167867 RVA: 0x000D3E90 File Offset: 0x000D2090
		// (set) Token: 0x06028FBC RID: 167868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700611C")]
		public float maxVal
		{
			[Token(Token = "0x6028FBB")]
			[Address(RVA = "0x2474A20", Offset = "0x2473620", VA = "0x182474A20")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6028FBC")]
			[Address(RVA = "0x2474E60", Offset = "0x2473A60", VA = "0x182474E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700611D RID: 24861
		// (get) Token: 0x06028FBD RID: 167869 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028FBE RID: 167870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700611D")]
		public string currentStr
		{
			[Token(Token = "0x6028FBD")]
			[Address(RVA = "0x2474840", Offset = "0x2473440", VA = "0x182474840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028FBE")]
			[Address(RVA = "0x2474C10", Offset = "0x2473810", VA = "0x182474C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700611E RID: 24862
		// (get) Token: 0x06028FBF RID: 167871 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028FC0 RID: 167872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700611E")]
		public string maxStr
		{
			[Token(Token = "0x6028FBF")]
			[Address(RVA = "0x24749C0", Offset = "0x24735C0", VA = "0x1824749C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028FC0")]
			[Address(RVA = "0x2474DE0", Offset = "0x24739E0", VA = "0x182474DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700611F RID: 24863
		// (get) Token: 0x06028FC1 RID: 167873 RVA: 0x000D3EA8 File Offset: 0x000D20A8
		// (set) Token: 0x06028FC2 RID: 167874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700611F")]
		public bool isComplete
		{
			[Token(Token = "0x6028FC1")]
			[Address(RVA = "0x2474960", Offset = "0x2473560", VA = "0x182474960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028FC2")]
			[Address(RVA = "0x2474D70", Offset = "0x2473970", VA = "0x182474D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006120 RID: 24864
		// (get) Token: 0x06028FC3 RID: 167875 RVA: 0x000D3EC0 File Offset: 0x000D20C0
		[Token(Token = "0x17006120")]
		public float progress
		{
			[Token(Token = "0x6028FC3")]
			[Address(RVA = "0x2474A80", Offset = "0x2473680", VA = "0x182474A80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06028FC4 RID: 167876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FC4")]
		[Address(RVA = "0x2474400", Offset = "0x2473000", VA = "0x182474400")]
		public void LoadData(int idx, BattleFinishDefenceModeRspData.ProgressRspData targetRspData)
		{
		}

		// Token: 0x06028FC5 RID: 167877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FC5")]
		[Address(RVA = "0x24745D0", Offset = "0x24731D0", VA = "0x1824745D0")]
		public void LoadData(int idx, BattleFinishNormalModeRspData.ProgressRspData targetRspData)
		{
		}

		// Token: 0x06028FC6 RID: 167878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FC6")]
		[Address(RVA = "0x24747E0", Offset = "0x24733E0", VA = "0x1824747E0")]
		public BattleFinishTargetModel()
		{
		}

		// Token: 0x0403A7F9 RID: 239609
		[Token(Token = "0x403A7F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_index;

		// Token: 0x0403A7FA RID: 239610
		[Token(Token = "0x403A7FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_index;

		// Token: 0x0403A7FB RID: 239611
		[Token(Token = "0x403A7FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_currentVal;

		// Token: 0x0403A7FC RID: 239612
		[Token(Token = "0x403A7FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_currentVal;

		// Token: 0x0403A7FD RID: 239613
		[Token(Token = "0x403A7FD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_maxVal;

		// Token: 0x0403A7FE RID: 239614
		[Token(Token = "0x403A7FE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_maxVal;

		// Token: 0x0403A7FF RID: 239615
		[Token(Token = "0x403A7FF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_currentStr;

		// Token: 0x0403A800 RID: 239616
		[Token(Token = "0x403A800")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_currentStr;

		// Token: 0x0403A801 RID: 239617
		[Token(Token = "0x403A801")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_maxStr;

		// Token: 0x0403A802 RID: 239618
		[Token(Token = "0x403A802")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_maxStr;

		// Token: 0x0403A803 RID: 239619
		[Token(Token = "0x403A803")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isComplete;

		// Token: 0x0403A804 RID: 239620
		[Token(Token = "0x403A804")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_isComplete;

		// Token: 0x0403A805 RID: 239621
		[Token(Token = "0x403A805")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_progress;

		// Token: 0x0403A806 RID: 239622
		[Token(Token = "0x403A806")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403A807 RID: 239623
		[Token(Token = "0x403A807")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_LoadData;

		// Token: 0x0403A808 RID: 239624
		[Token(Token = "0x403A808")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
