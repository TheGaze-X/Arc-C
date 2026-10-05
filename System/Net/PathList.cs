using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002ED RID: 749
	[Token(Token = "0x20002ED")]
	[Serializable]
	internal class PathList
	{
		// Token: 0x060014B2 RID: 5298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x505C000", Offset = "0x505AC00", VA = "0x18505C000")]
		public PathList()
		{
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x00009C48 File Offset: 0x00007E48
		[Token(Token = "0x17000462")]
		public int Count
		{
			[Token(Token = "0x60014B3")]
			[Address(RVA = "0x4C5C060", Offset = "0x4C5AC60", VA = "0x184C5C060")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00009C60 File Offset: 0x00007E60
		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x505BBE0", Offset = "0x505A7E0", VA = "0x18505BBE0")]
		public int GetCookiesCount()
		{
			return 0;
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000463")]
		public ICollection Values
		{
			[Token(Token = "0x60014B5")]
			[Address(RVA = "0x4C5BA30", Offset = "0x4C5A630", VA = "0x184C5BA30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000464 RID: 1124
		[Token(Token = "0x17000464")]
		public object this[string s]
		{
			[Token(Token = "0x60014B6")]
			[Address(RVA = "0x505C0C0", Offset = "0x505ACC0", VA = "0x18505C0C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60014B7")]
			[Address(RVA = "0x505C120", Offset = "0x505AD20", VA = "0x18505C120")]
			set
			{
			}
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B8")]
		[Address(RVA = "0x505BFB0", Offset = "0x505ABB0", VA = "0x18505BFB0")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000465")]
		public object SyncRoot
		{
			[Token(Token = "0x60014B9")]
			[Address(RVA = "0x4C679C0", Offset = "0x4C665C0", VA = "0x184C679C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000B5B RID: 2907
		[Token(Token = "0x4000B5B")]
		[FieldOffset(Offset = "0x10")]
		private SortedList m_list;

		// Token: 0x020002EE RID: 750
		[Token(Token = "0x20002EE")]
		[Serializable]
		private class PathListComparer : IComparer
		{
			// Token: 0x060014BA RID: 5306 RVA: 0x00009C78 File Offset: 0x00007E78
			[Token(Token = "0x60014BA")]
			[Address(RVA = "0x505B8F0", Offset = "0x505A4F0", VA = "0x18505B8F0", Slot = "4")]
			private int Compare(object ol, object or)
			{
				return 0;
			}

			// Token: 0x060014BB RID: 5307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60014BB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PathListComparer()
			{
			}

			// Token: 0x04000B5C RID: 2908
			[Token(Token = "0x4000B5C")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly PathList.PathListComparer StaticInstance;
		}
	}
}
