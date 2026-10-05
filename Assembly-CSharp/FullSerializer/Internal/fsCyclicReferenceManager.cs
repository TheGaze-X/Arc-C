using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B93 RID: 31635
	[Token(Token = "0x2007B93")]
	public class fsCyclicReferenceManager
	{
		// Token: 0x0602C493 RID: 181395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C493")]
		[Address(RVA = "0x7CDBF0", Offset = "0x7CC7F0", VA = "0x1807CDBF0")]
		public void Enter()
		{
		}

		// Token: 0x0602C494 RID: 181396 RVA: 0x000DF4B8 File Offset: 0x000DD6B8
		[Token(Token = "0x602C494")]
		[Address(RVA = "0x28233C0", Offset = "0x2821FC0", VA = "0x1828233C0")]
		public bool Exit()
		{
			return default(bool);
		}

		// Token: 0x0602C495 RID: 181397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C495")]
		[Address(RVA = "0x28235E0", Offset = "0x28221E0", VA = "0x1828235E0")]
		public object GetReferenceObject(int id)
		{
			return null;
		}

		// Token: 0x0602C496 RID: 181398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C496")]
		[Address(RVA = "0x2823350", Offset = "0x2821F50", VA = "0x182823350")]
		public void AddReferenceWithId(int id, object reference)
		{
		}

		// Token: 0x0602C497 RID: 181399 RVA: 0x000DF4D0 File Offset: 0x000DD6D0
		[Token(Token = "0x602C497")]
		[Address(RVA = "0x2823540", Offset = "0x2822140", VA = "0x182823540")]
		public int GetReferenceId(object item)
		{
			return 0;
		}

		// Token: 0x0602C498 RID: 181400 RVA: 0x000DF4E8 File Offset: 0x000DD6E8
		[Token(Token = "0x602C498")]
		[Address(RVA = "0x28236F0", Offset = "0x28222F0", VA = "0x1828236F0")]
		public bool IsReference(object item)
		{
			return default(bool);
		}

		// Token: 0x0602C499 RID: 181401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C499")]
		[Address(RVA = "0x2823760", Offset = "0x2822360", VA = "0x182823760")]
		public void MarkSerialized(object item)
		{
		}

		// Token: 0x0602C49A RID: 181402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C49A")]
		[Address(RVA = "0x28238A0", Offset = "0x28224A0", VA = "0x1828238A0")]
		public fsCyclicReferenceManager()
		{
		}

		// Token: 0x040401D8 RID: 262616
		[Token(Token = "0x40401D8")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<object, int> _objectIds;

		// Token: 0x040401D9 RID: 262617
		[Token(Token = "0x40401D9")]
		[FieldOffset(Offset = "0x18")]
		private int _nextId;

		// Token: 0x040401DA RID: 262618
		[Token(Token = "0x40401DA")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, object> _marked;

		// Token: 0x040401DB RID: 262619
		[Token(Token = "0x40401DB")]
		[FieldOffset(Offset = "0x28")]
		private int _depth;

		// Token: 0x02007B94 RID: 31636
		[Token(Token = "0x2007B94")]
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object>
		{
			// Token: 0x0602C49B RID: 181403 RVA: 0x000DF500 File Offset: 0x000DD700
			[Token(Token = "0x602C49B")]
			[Address(RVA = "0x281EE50", Offset = "0x281DA50", VA = "0x18281EE50", Slot = "4")]
			private bool Equals(object x, object y)
			{
				return default(bool);
			}

			// Token: 0x0602C49C RID: 181404 RVA: 0x000DF518 File Offset: 0x000DD718
			[Token(Token = "0x602C49C")]
			[Address(RVA = "0x281EE60", Offset = "0x281DA60", VA = "0x18281EE60", Slot = "5")]
			private int GetHashCode(object obj)
			{
				return 0;
			}

			// Token: 0x0602C49D RID: 181405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C49D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ObjectReferenceEqualityComparator()
			{
			}

			// Token: 0x040401DC RID: 262620
			[Token(Token = "0x40401DC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly IEqualityComparer<object> Instance;
		}
	}
}
