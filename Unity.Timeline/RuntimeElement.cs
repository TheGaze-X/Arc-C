using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	internal abstract class RuntimeElement : IInterval
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600025D RID: 605
		[Token(Token = "0x170000AC")]
		public abstract long intervalStart { [Token(Token = "0x600025D")] get; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600025E RID: 606
		[Token(Token = "0x170000AD")]
		public abstract long intervalEnd { [Token(Token = "0x600025E")] get; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00003674 File Offset: 0x00001874
		// (set) Token: 0x06000260 RID: 608 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000AE")]
		public int intervalBit
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000AF RID: 175
		// (set) Token: 0x06000261 RID: 609
		[Token(Token = "0x170000AF")]
		public abstract bool enable { [Token(Token = "0x6000261")] set; }

		// Token: 0x06000262 RID: 610
		[Token(Token = "0x6000262")]
		public abstract void EvaluateAt(double localTime, FrameData frameData);

		// Token: 0x06000263 RID: 611
		[Token(Token = "0x6000263")]
		public abstract void DisableAt(double localTime, double rootDuration, FrameData frameData);

		// Token: 0x06000264 RID: 612 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected RuntimeElement()
		{
		}
	}
}
