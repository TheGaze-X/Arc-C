using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections.Specialized
{
	// Token: 0x02000245 RID: 581
	[Token(Token = "0x2000245")]
	[Serializable]
	public class NameValueCollection : NameObjectCollectionBase
	{
		// Token: 0x06000FC3 RID: 4035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0x51844F0", Offset = "0x51830F0", VA = "0x1851844F0")]
		public NameValueCollection()
		{
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x5184390", Offset = "0x5182F90", VA = "0x185184390")]
		public NameValueCollection(int capacity)
		{
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x5184310", Offset = "0x5182F10", VA = "0x185184310")]
		public NameValueCollection(int capacity, IEqualityComparer equalityComparer)
		{
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC6")]
		[Address(RVA = "0x5184480", Offset = "0x5183080", VA = "0x185184480")]
		protected NameValueCollection(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x51840C0", Offset = "0x5182CC0", VA = "0x1851840C0")]
		protected void InvalidateCachedArrays()
		{
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC8")]
		[Address(RVA = "0x5183AA0", Offset = "0x51826A0", VA = "0x185183AA0")]
		private static string GetAsOneString(ArrayList list)
		{
			return null;
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC9")]
		[Address(RVA = "0x5183CE0", Offset = "0x51828E0", VA = "0x185183CE0")]
		private static string[] GetAsStringArray(ArrayList list)
		{
			return null;
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCA")]
		[Address(RVA = "0x51838E0", Offset = "0x51824E0", VA = "0x1851838E0", Slot = "15")]
		public virtual void Add(string name, string value)
		{
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCB")]
		[Address(RVA = "0x5184000", Offset = "0x5182C00", VA = "0x185184000", Slot = "16")]
		public virtual string Get(string name)
		{
			return null;
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCC")]
		[Address(RVA = "0x5183DC0", Offset = "0x51829C0", VA = "0x185183DC0", Slot = "17")]
		public virtual string[] GetValues(string name)
		{
			return null;
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCD")]
		[Address(RVA = "0x5184150", Offset = "0x5182D50", VA = "0x185184150", Slot = "18")]
		public virtual void Set(string name, string value)
		{
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0x5184100", Offset = "0x5182D00", VA = "0x185184100", Slot = "19")]
		public virtual void Remove(string name)
		{
		}

		// Token: 0x1700032A RID: 810
		[Token(Token = "0x1700032A")]
		public string this[string name]
		{
			[Token(Token = "0x6000FCF")]
			[Address(RVA = "0x51845D0", Offset = "0x51831D0", VA = "0x1851845D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FD0")]
			[Address(RVA = "0x5184620", Offset = "0x5183220", VA = "0x185184620")]
			set
			{
			}
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x5183F40", Offset = "0x5182B40", VA = "0x185183F40", Slot = "20")]
		public virtual string Get(int index)
		{
			return null;
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x5183E80", Offset = "0x5182A80", VA = "0x185183E80", Slot = "21")]
		public virtual string[] GetValues(int index)
		{
			return null;
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0x5183DB0", Offset = "0x51829B0", VA = "0x185183DB0", Slot = "22")]
		public virtual string GetKey(int index)
		{
			return null;
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD4")]
		[Address(RVA = "0x5184580", Offset = "0x5183180", VA = "0x185184580")]
		internal NameValueCollection(DBNull dummy)
		{
		}

		// Token: 0x04000834 RID: 2100
		[Token(Token = "0x4000834")]
		[FieldOffset(Offset = "0x50")]
		private string[] _all;

		// Token: 0x04000835 RID: 2101
		[Token(Token = "0x4000835")]
		[FieldOffset(Offset = "0x58")]
		private string[] _allKeys;
	}
}
