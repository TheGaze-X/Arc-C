using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200018C RID: 396
	[Token(Token = "0x200018C")]
	public class MMKVPMarshaller
	{
		// Token: 0x060008FD RID: 2301 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x4EE1F10", Offset = "0x4EE0B10", VA = "0x184EE1F10")]
		public MMKVPMarshaller(MatchMakingKeyValuePair_t[] filters)
		{
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x4EE1DF0", Offset = "0x4EE09F0", VA = "0x184EE1DF0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00007E44 File Offset: 0x00006044
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x4469D30", Offset = "0x4468930", VA = "0x184469D30")]
		public static implicit operator IntPtr(MMKVPMarshaller that)
		{
			return 0;
		}

		// Token: 0x04000A5A RID: 2650
		[Token(Token = "0x4000A5A")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_pNativeArray;

		// Token: 0x04000A5B RID: 2651
		[Token(Token = "0x4000A5B")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_pArrayEntries;
	}
}
