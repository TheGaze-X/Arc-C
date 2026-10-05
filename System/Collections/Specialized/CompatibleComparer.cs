using System;
using Il2CppDummyDll;

namespace System.Collections.Specialized
{
	// Token: 0x0200024F RID: 591
	[Token(Token = "0x200024F")]
	[Serializable]
	internal class CompatibleComparer : IEqualityComparer
	{
		// Token: 0x0600103B RID: 4155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600103B")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		internal CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider)
		{
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00007F08 File Offset: 0x00006108
		[Token(Token = "0x600103C")]
		[Address(RVA = "0x5177FA0", Offset = "0x5176BA0", VA = "0x185177FA0", Slot = "4")]
		public bool Equals(object a, object b)
		{
			return default(bool);
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00007F20 File Offset: 0x00006120
		[Token(Token = "0x600103D")]
		[Address(RVA = "0x5178090", Offset = "0x5176C90", VA = "0x185178090", Slot = "5")]
		public int GetHashCode(object obj)
		{
			return 0;
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000349")]
		public IComparer Comparer
		{
			[Token(Token = "0x600103E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034A")]
		public IHashCodeProvider HashCodeProvider
		{
			[Token(Token = "0x600103F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034B")]
		public static IComparer DefaultComparer
		{
			[Token(Token = "0x6001040")]
			[Address(RVA = "0x5178170", Offset = "0x5176D70", VA = "0x185178170")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034C")]
		public static IHashCodeProvider DefaultHashCodeProvider
		{
			[Token(Token = "0x6001041")]
			[Address(RVA = "0x5178260", Offset = "0x5176E60", VA = "0x185178260")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[FieldOffset(Offset = "0x10")]
		private IComparer _comparer;

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[FieldOffset(Offset = "0x0")]
		private static IComparer defaultComparer;

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		[FieldOffset(Offset = "0x18")]
		private IHashCodeProvider _hcp;

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[FieldOffset(Offset = "0x8")]
		private static IHashCodeProvider defaultHashProvider;
	}
}
