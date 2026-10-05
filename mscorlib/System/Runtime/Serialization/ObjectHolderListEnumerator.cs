using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x02000408 RID: 1032
	[Token(Token = "0x2000408")]
	internal class ObjectHolderListEnumerator
	{
		// Token: 0x0600202C RID: 8236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202C")]
		[Address(RVA = "0x4BA1CD0", Offset = "0x4BA08D0", VA = "0x184BA1CD0")]
		internal ObjectHolderListEnumerator(ObjectHolderList list, bool isFixupEnumerator)
		{
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x000134A0 File Offset: 0x000116A0
		[Token(Token = "0x600202D")]
		[Address(RVA = "0x4BA1C30", Offset = "0x4BA0830", VA = "0x184BA1C30")]
		internal bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000442")]
		internal ObjectHolder Current
		{
			[Token(Token = "0x600202E")]
			[Address(RVA = "0x4BA1D40", Offset = "0x4BA0940", VA = "0x184BA1D40")]
			get
			{
				return null;
			}
		}

		// Token: 0x040010E2 RID: 4322
		[Token(Token = "0x40010E2")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isFixupEnumerator;

		// Token: 0x040010E3 RID: 4323
		[Token(Token = "0x40010E3")]
		[FieldOffset(Offset = "0x18")]
		private ObjectHolderList m_list;

		// Token: 0x040010E4 RID: 4324
		[Token(Token = "0x40010E4")]
		[FieldOffset(Offset = "0x20")]
		private int m_startingVersion;

		// Token: 0x040010E5 RID: 4325
		[Token(Token = "0x40010E5")]
		[FieldOffset(Offset = "0x24")]
		private int m_currPos;
	}
}
