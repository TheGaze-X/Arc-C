using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	public abstract class Attachment
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000166 RID: 358 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700005C")]
		public string Name
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x4E43410", Offset = "0x4E42010", VA = "0x184E43410")]
		protected Attachment(string name)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000169 RID: 361
		[Token(Token = "0x6000169")]
		public abstract Attachment Copy();
	}
}
