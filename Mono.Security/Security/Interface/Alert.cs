using System;
using Il2CppDummyDll;

namespace Mono.Security.Interface
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public class Alert
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600013F RID: 319 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x1700005E")]
		public AlertLevel Level
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return (AlertLevel)0;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x1700005F")]
		public AlertDescription Description
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			get
			{
				return AlertDescription.CloseNotify;
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x4A90D30", Offset = "0x4A8F930", VA = "0x184A90D30")]
		public Alert(AlertDescription description)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x4A90DD0", Offset = "0x4A8F9D0", VA = "0x184A90DD0")]
		private void inferAlertLevel()
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x4A90C90", Offset = "0x4A8F890", VA = "0x184A90C90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x10")]
		private AlertLevel level;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x11")]
		private AlertDescription description;
	}
}
