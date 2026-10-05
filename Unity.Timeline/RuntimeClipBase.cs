using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	internal abstract class RuntimeClipBase : RuntimeElement
	{
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000258 RID: 600
		[Token(Token = "0x170000A8")]
		public abstract double start { [Token(Token = "0x6000258")] get; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000259 RID: 601
		[Token(Token = "0x170000A9")]
		public abstract double duration { [Token(Token = "0x6000259")] get; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00003644 File Offset: 0x00001844
		[Token(Token = "0x170000AA")]
		public override long intervalStart
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x58EADC0", Offset = "0x58E99C0", VA = "0x1858EADC0", Slot = "6")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000365C File Offset: 0x0000185C
		[Token(Token = "0x170000AB")]
		public override long intervalEnd
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x58EACD0", Offset = "0x58E98D0", VA = "0x1858EACD0", Slot = "7")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected RuntimeClipBase()
		{
		}
	}
}
