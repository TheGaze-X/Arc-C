using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A6D RID: 10861
	[Token(Token = "0x2002A6D")]
	[Serializable]
	public class SandboxPlacedItemStatusValue
	{
		// Token: 0x170027A4 RID: 10148
		// (get) Token: 0x06012102 RID: 73986 RVA: 0x0006E910 File Offset: 0x0006CB10
		// (set) Token: 0x06012101 RID: 73985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170027A4")]
		[JsonIgnore]
		public float statusHpRatio
		{
			[Token(Token = "0x6012102")]
			[Address(RVA = "0xA27A30", Offset = "0xA26630", VA = "0x180A27A30")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6012101")]
			[Address(RVA = "0xA33F00", Offset = "0xA32B00", VA = "0x180A33F00")]
			set
			{
			}
		}

		// Token: 0x06012103 RID: 73987 RVA: 0x0006E928 File Offset: 0x0006CB28
		[Token(Token = "0x6012103")]
		[Address(RVA = "0xA33DD0", Offset = "0xA329D0", VA = "0x180A33DD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06012104 RID: 73988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012104")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxPlacedItemStatusValue()
		{
		}

		// Token: 0x04014684 RID: 83588
		[Token(Token = "0x4014684")]
		[FieldOffset(Offset = "0x10")]
		public int hpRatio;

		// Token: 0x04014685 RID: 83589
		[Token(Token = "0x4014685")]
		[FieldOffset(Offset = "0x14")]
		public SharedConsts.Direction direction;
	}
}
