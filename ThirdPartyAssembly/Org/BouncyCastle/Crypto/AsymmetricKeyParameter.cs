using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x0200020B RID: 523
	[Token(Token = "0x200020B")]
	public abstract class AsymmetricKeyParameter : ICipherParameters
	{
		// Token: 0x06001296 RID: 4758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001296")]
		[Address(RVA = "0x485B310", Offset = "0x4859F10", VA = "0x18485B310")]
		protected AsymmetricKeyParameter(bool privateKey)
		{
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x0000A440 File Offset: 0x00008640
		[Token(Token = "0x1700029B")]
		public bool IsPrivate
		{
			[Token(Token = "0x6001297")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0000A458 File Offset: 0x00008658
		[Token(Token = "0x6001298")]
		[Address(RVA = "0x521F420", Offset = "0x521E020", VA = "0x18521F420", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0000A470 File Offset: 0x00008670
		[Token(Token = "0x6001299")]
		[Address(RVA = "0x521F4C0", Offset = "0x521E0C0", VA = "0x18521F4C0")]
		protected bool Equals(AsymmetricKeyParameter other)
		{
			return default(bool);
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0000A488 File Offset: 0x00008688
		[Token(Token = "0x600129A")]
		[Address(RVA = "0x521F4E0", Offset = "0x521E0E0", VA = "0x18521F4E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400094E RID: 2382
		[Token(Token = "0x400094E")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool privateKey;
	}
}
