using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FA8 RID: 28584
	[Token(Token = "0x2006FA8")]
	public class ActMultiV3MatchMapModel : IHotfixable
	{
		// Token: 0x17005FCD RID: 24525
		// (get) Token: 0x06028992 RID: 166290 RVA: 0x000D2570 File Offset: 0x000D0770
		// (set) Token: 0x06028993 RID: 166291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FCD")]
		public int totalStar
		{
			[Token(Token = "0x6028992")]
			[Address(RVA = "0x23D5900", Offset = "0x23D4500", VA = "0x1823D5900")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028993")]
			[Address(RVA = "0x23D5A40", Offset = "0x23D4640", VA = "0x1823D5A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FCE RID: 24526
		// (get) Token: 0x06028994 RID: 166292 RVA: 0x000D2588 File Offset: 0x000D0788
		// (set) Token: 0x06028995 RID: 166293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FCE")]
		public int currStar
		{
			[Token(Token = "0x6028994")]
			[Address(RVA = "0x23D5780", Offset = "0x23D4380", VA = "0x1823D5780")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028995")]
			[Address(RVA = "0x23D5960", Offset = "0x23D4560", VA = "0x1823D5960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FCF RID: 24527
		// (get) Token: 0x06028996 RID: 166294 RVA: 0x000D25A0 File Offset: 0x000D07A0
		// (set) Token: 0x06028997 RID: 166295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FCF")]
		public long exScore
		{
			[Token(Token = "0x6028996")]
			[Address(RVA = "0x23D57E0", Offset = "0x23D43E0", VA = "0x1823D57E0")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6028997")]
			[Address(RVA = "0x23D59D0", Offset = "0x23D45D0", VA = "0x1823D59D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FD0 RID: 24528
		// (get) Token: 0x06028998 RID: 166296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005FD0")]
		public string stageId
		{
			[Token(Token = "0x6028998")]
			[Address(RVA = "0x23D5840", Offset = "0x23D4440", VA = "0x1823D5840")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005FD1 RID: 24529
		// (get) Token: 0x06028999 RID: 166297 RVA: 0x000D25B8 File Offset: 0x000D07B8
		[Token(Token = "0x17005FD1")]
		public long startTime
		{
			[Token(Token = "0x6028999")]
			[Address(RVA = "0x23D58A0", Offset = "0x23D44A0", VA = "0x1823D58A0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0602899A RID: 166298 RVA: 0x000D25D0 File Offset: 0x000D07D0
		[Token(Token = "0x602899A")]
		[Address(RVA = "0x23D5440", Offset = "0x23D4040", VA = "0x1823D5440")]
		public bool CheckIfOpen(long currTs)
		{
			return default(bool);
		}

		// Token: 0x0602899B RID: 166299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602899B")]
		[Address(RVA = "0x23D54B0", Offset = "0x23D40B0", VA = "0x1823D54B0")]
		public void LoadData(string actId, ActMultiV3Data actData, ActMultiV3MapData mapData)
		{
		}

		// Token: 0x0602899C RID: 166300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602899C")]
		[Address(RVA = "0x23D55E0", Offset = "0x23D41E0", VA = "0x1823D55E0")]
		public void UpdatePlayerData()
		{
		}

		// Token: 0x0602899D RID: 166301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602899D")]
		[Address(RVA = "0x23D5720", Offset = "0x23D4320", VA = "0x1823D5720")]
		public ActMultiV3MatchMapModel()
		{
		}

		// Token: 0x04039D1F RID: 236831
		[Token(Token = "0x4039D1F")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x04039D20 RID: 236832
		[Token(Token = "0x4039D20")]
		[FieldOffset(Offset = "0x18")]
		private string m_stageId;

		// Token: 0x04039D21 RID: 236833
		[Token(Token = "0x4039D21")]
		[FieldOffset(Offset = "0x20")]
		private long m_startTime;

		// Token: 0x04039D25 RID: 236837
		[Token(Token = "0x4039D25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_totalStar;

		// Token: 0x04039D26 RID: 236838
		[Token(Token = "0x4039D26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_totalStar;

		// Token: 0x04039D27 RID: 236839
		[Token(Token = "0x4039D27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_currStar;

		// Token: 0x04039D28 RID: 236840
		[Token(Token = "0x4039D28")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_currStar;

		// Token: 0x04039D29 RID: 236841
		[Token(Token = "0x4039D29")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_exScore;

		// Token: 0x04039D2A RID: 236842
		[Token(Token = "0x4039D2A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_exScore;

		// Token: 0x04039D2B RID: 236843
		[Token(Token = "0x4039D2B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x04039D2C RID: 236844
		[Token(Token = "0x4039D2C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_startTime;

		// Token: 0x04039D2D RID: 236845
		[Token(Token = "0x4039D2D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIfOpen;

		// Token: 0x04039D2E RID: 236846
		[Token(Token = "0x4039D2E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039D2F RID: 236847
		[Token(Token = "0x4039D2F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x04039D30 RID: 236848
		[Token(Token = "0x4039D30")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
