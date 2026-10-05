using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	internal sealed class LocalDataStoreHolder
	{
		// Token: 0x06000D8E RID: 3470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public LocalDataStoreHolder(LocalDataStore store)
		{
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0x4D1E950", Offset = "0x4D1D550", VA = "0x184D1E950", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000126")]
		public LocalDataStore Store
		{
			[Token(Token = "0x6000D90")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x040005D8 RID: 1496
		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0x10")]
		private LocalDataStore m_Store;
	}
}
