using System;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005C8 RID: 1480
	[Token(Token = "0x20005C8")]
	[System.Serializable]
	internal sealed class CompatibleComparer : IEqualityComparer
	{
		// Token: 0x06002BD9 RID: 11225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD9")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		internal CompatibleComparer(IHashCodeProvider hashCodeProvider, IComparer comparer)
		{
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006D4")]
		internal IHashCodeProvider HashCodeProvider
		{
			[Token(Token = "0x6002BDA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06002BDB RID: 11227 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006D5")]
		internal IComparer Comparer
		{
			[Token(Token = "0x6002BDB")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x00018198 File Offset: 0x00016398
		[Token(Token = "0x6002BDC")]
		[Address(RVA = "0x4C5CDC0", Offset = "0x4C5B9C0", VA = "0x184C5CDC0", Slot = "4")]
		public bool Equals(object a, object b)
		{
			return default(bool);
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x000181B0 File Offset: 0x000163B0
		[Token(Token = "0x6002BDD")]
		[Address(RVA = "0x4C5CBF0", Offset = "0x4C5B7F0", VA = "0x184C5CBF0")]
		public int Compare(object a, object b)
		{
			return 0;
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x000181C8 File Offset: 0x000163C8
		[Token(Token = "0x6002BDE")]
		[Address(RVA = "0x4C5CF70", Offset = "0x4C5BB70", VA = "0x184C5CF70", Slot = "5")]
		public int GetHashCode(object obj)
		{
			return 0;
		}

		// Token: 0x0400198B RID: 6539
		[Token(Token = "0x400198B")]
		[FieldOffset(Offset = "0x10")]
		private readonly IHashCodeProvider _hcp;

		// Token: 0x0400198C RID: 6540
		[Token(Token = "0x400198C")]
		[FieldOffset(Offset = "0x18")]
		private readonly IComparer _comparer;
	}
}
