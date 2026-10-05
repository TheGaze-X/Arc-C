using System;
using System.Diagnostics;
using System.Threading;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000105 RID: 261
	[Token(Token = "0x2000105")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(LazyDebugView<>))]
	[System.Diagnostics.DebuggerDisplay("ThreadSafetyMode={Mode}, IsValueCreated={IsValueCreated}, IsValueFaulted={IsValueFaulted}, Value={ValueForDebugDisplay}")]
	[System.Serializable]
	public class Lazy<T>
	{
		// Token: 0x06000889 RID: 2185 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000889")]
		private static T CreateViaDefaultConstructor()
		{
			return null;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088A")]
		public Lazy()
		{
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088B")]
		public Lazy(System.Func<T> valueFactory)
		{
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088C")]
		private Lazy(System.Func<T> valueFactory, System.Threading.LazyThreadSafetyMode mode, bool useDefaultConstructor)
		{
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088D")]
		private void ViaConstructor()
		{
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088E")]
		private void ViaFactory(System.Threading.LazyThreadSafetyMode mode)
		{
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088F")]
		private void ExecutionAndPublication(LazyHelper executionAndPublication, bool useDefaultConstructor)
		{
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000890")]
		private void PublicationOnly(LazyHelper publicationOnly, T possibleValue)
		{
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000891")]
		private void PublicationOnlyViaConstructor(LazyHelper initializer)
		{
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000892")]
		private void PublicationOnlyViaFactory(LazyHelper initializer)
		{
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000893")]
		private void PublicationOnlyWaitForOtherThreadToPublish()
		{
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000894")]
		private T CreateValue()
		{
			return null;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000895")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00008940 File Offset: 0x00006B40
		[Token(Token = "0x17000099")]
		public bool IsValueCreated
		{
			[Token(Token = "0x6000896")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700009A")]
		[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
		public T Value
		{
			[Token(Token = "0x6000897")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x0")]
		private LazyHelper _state;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x0")]
		private System.Func<T> _factory;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x0")]
		private T _value;
	}
}
