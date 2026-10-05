using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DC7 RID: 28103
	[Token(Token = "0x2006DC7")]
	public class ActVecBreakV2AchvHardStageModel : IHotfixable
	{
		// Token: 0x17005EA1 RID: 24225
		// (get) Token: 0x0602804A RID: 163914 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602804B RID: 163915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005EA1")]
		public string stageCode
		{
			[Token(Token = "0x602804A")]
			[Address(RVA = "0x2345980", Offset = "0x2344580", VA = "0x182345980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602804B")]
			[Address(RVA = "0x2345BB0", Offset = "0x23447B0", VA = "0x182345BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005EA2 RID: 24226
		// (get) Token: 0x0602804C RID: 163916 RVA: 0x000D0680 File Offset: 0x000CE880
		// (set) Token: 0x0602804D RID: 163917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005EA2")]
		public bool isBossDecoEmpty
		{
			[Token(Token = "0x602804C")]
			[Address(RVA = "0x2345860", Offset = "0x2344460", VA = "0x182345860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602804D")]
			[Address(RVA = "0x2345A60", Offset = "0x2344660", VA = "0x182345A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005EA3 RID: 24227
		// (get) Token: 0x0602804E RID: 163918 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602804F RID: 163919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005EA3")]
		public string bossDeco
		{
			[Token(Token = "0x602804E")]
			[Address(RVA = "0x2345800", Offset = "0x2344400", VA = "0x182345800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602804F")]
			[Address(RVA = "0x23459E0", Offset = "0x23445E0", VA = "0x1823459E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005EA4 RID: 24228
		// (get) Token: 0x06028050 RID: 163920 RVA: 0x000D0698 File Offset: 0x000CE898
		// (set) Token: 0x06028051 RID: 163921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005EA4")]
		public ActVecBreakV2StageOrderType orderType
		{
			[Token(Token = "0x6028050")]
			[Address(RVA = "0x2345920", Offset = "0x2344520", VA = "0x182345920")]
			[CompilerGenerated]
			get
			{
				return ActVecBreakV2StageOrderType.NONE;
			}
			[Token(Token = "0x6028051")]
			[Address(RVA = "0x2345B40", Offset = "0x2344740", VA = "0x182345B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005EA5 RID: 24229
		// (get) Token: 0x06028052 RID: 163922 RVA: 0x000D06B0 File Offset: 0x000CE8B0
		// (set) Token: 0x06028053 RID: 163923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005EA5")]
		public bool isComplete
		{
			[Token(Token = "0x6028052")]
			[Address(RVA = "0x23458C0", Offset = "0x23444C0", VA = "0x1823458C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028053")]
			[Address(RVA = "0x2345AD0", Offset = "0x23446D0", VA = "0x182345AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028054 RID: 163924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028054")]
		[Address(RVA = "0x23454F0", Offset = "0x23440F0", VA = "0x1823454F0")]
		public void LoadData(ActVecBreakV2HardStageData hardStageData, VecBreakV2StageInfo stageInfo)
		{
		}

		// Token: 0x06028055 RID: 163925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028055")]
		[Address(RVA = "0x23457A0", Offset = "0x23443A0", VA = "0x1823457A0")]
		public ActVecBreakV2AchvHardStageModel()
		{
		}

		// Token: 0x04038BDE RID: 232414
		[Token(Token = "0x4038BDE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageCode;

		// Token: 0x04038BDF RID: 232415
		[Token(Token = "0x4038BDF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_stageCode;

		// Token: 0x04038BE0 RID: 232416
		[Token(Token = "0x4038BE0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isBossDecoEmpty;

		// Token: 0x04038BE1 RID: 232417
		[Token(Token = "0x4038BE1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isBossDecoEmpty;

		// Token: 0x04038BE2 RID: 232418
		[Token(Token = "0x4038BE2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_bossDeco;

		// Token: 0x04038BE3 RID: 232419
		[Token(Token = "0x4038BE3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_bossDeco;

		// Token: 0x04038BE4 RID: 232420
		[Token(Token = "0x4038BE4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_orderType;

		// Token: 0x04038BE5 RID: 232421
		[Token(Token = "0x4038BE5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_orderType;

		// Token: 0x04038BE6 RID: 232422
		[Token(Token = "0x4038BE6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isComplete;

		// Token: 0x04038BE7 RID: 232423
		[Token(Token = "0x4038BE7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isComplete;

		// Token: 0x04038BE8 RID: 232424
		[Token(Token = "0x4038BE8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038BE9 RID: 232425
		[Token(Token = "0x4038BE9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
