using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200022C RID: 556
	[Token(Token = "0x200022C")]
	internal sealed class WeakHashtable : Hashtable
	{
		// Token: 0x06000F63 RID: 3939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F63")]
		[Address(RVA = "0x5197890", Offset = "0x5196490", VA = "0x185197890")]
		internal WeakHashtable()
		{
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x5197270", Offset = "0x5195E70", VA = "0x185197270", Slot = "24")]
		public override void Clear()
		{
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F65")]
		[Address(RVA = "0x5197280", Offset = "0x5195E80", VA = "0x185197280", Slot = "39")]
		public override void Remove(object key)
		{
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F66")]
		[Address(RVA = "0x5197730", Offset = "0x5196330", VA = "0x185197730")]
		public void SetWeak(object key, object value)
		{
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F67")]
		[Address(RVA = "0x5197290", Offset = "0x5195E90", VA = "0x185197290")]
		private void ScavengeKeys()
		{
		}

		// Token: 0x04000812 RID: 2066
		[Token(Token = "0x4000812")]
		[FieldOffset(Offset = "0x0")]
		private static IEqualityComparer _comparer;

		// Token: 0x04000813 RID: 2067
		[Token(Token = "0x4000813")]
		[FieldOffset(Offset = "0x50")]
		private long _lastGlobalMem;

		// Token: 0x04000814 RID: 2068
		[Token(Token = "0x4000814")]
		[FieldOffset(Offset = "0x58")]
		private int _lastHashCount;

		// Token: 0x0200022D RID: 557
		[Token(Token = "0x200022D")]
		private class WeakKeyComparer : IEqualityComparer
		{
			// Token: 0x06000F69 RID: 3945 RVA: 0x00007AE8 File Offset: 0x00005CE8
			[Token(Token = "0x6000F69")]
			[Address(RVA = "0x51978F0", Offset = "0x51964F0", VA = "0x1851978F0", Slot = "4")]
			private bool Equals(object x, object y)
			{
				return default(bool);
			}

			// Token: 0x06000F6A RID: 3946 RVA: 0x00007B00 File Offset: 0x00005D00
			[Token(Token = "0x6000F6A")]
			[Address(RVA = "0x3699C20", Offset = "0x3698820", VA = "0x183699C20", Slot = "5")]
			private int GetHashCode(object obj)
			{
				return 0;
			}

			// Token: 0x06000F6B RID: 3947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000F6B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public WeakKeyComparer()
			{
			}
		}

		// Token: 0x0200022E RID: 558
		[Token(Token = "0x200022E")]
		private sealed class EqualityWeakReference : WeakReference
		{
			// Token: 0x06000F6C RID: 3948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000F6C")]
			[Address(RVA = "0x517DEF0", Offset = "0x517CAF0", VA = "0x18517DEF0")]
			internal EqualityWeakReference(object o)
			{
			}

			// Token: 0x06000F6D RID: 3949 RVA: 0x00007B18 File Offset: 0x00005D18
			[Token(Token = "0x6000F6D")]
			[Address(RVA = "0x517DE60", Offset = "0x517CA60", VA = "0x18517DE60", Slot = "0")]
			public override bool Equals(object o)
			{
				return default(bool);
			}

			// Token: 0x06000F6E RID: 3950 RVA: 0x00007B30 File Offset: 0x00005D30
			[Token(Token = "0x6000F6E")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x04000815 RID: 2069
			[Token(Token = "0x4000815")]
			[FieldOffset(Offset = "0x20")]
			private int _hashCode;
		}
	}
}
