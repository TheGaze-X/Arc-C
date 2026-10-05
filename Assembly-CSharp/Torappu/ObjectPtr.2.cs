using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000528 RID: 1320
	[Token(Token = "0x2000528")]
	public struct ObjectPtr<T> : IComparable<ObjectPtr<T>> where T : class, IPtrObject
	{
		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06004F77 RID: 20343 RVA: 0x0002E548 File Offset: 0x0002C748
		[Token(Token = "0x1700024E")]
		public bool isValid
		{
			[Token(Token = "0x6004F77")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004F78 RID: 20344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F78")]
		public ObjectPtr(T obj)
		{
		}

		// Token: 0x06004F79 RID: 20345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F79")]
		public T Lock()
		{
			return null;
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06004F7A RID: 20346 RVA: 0x0002E560 File Offset: 0x0002C760
		[Token(Token = "0x1700024F")]
		public uint instanceUid
		{
			[Token(Token = "0x6004F7A")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x0002E578 File Offset: 0x0002C778
		[Token(Token = "0x6004F7B")]
		public static implicit operator ObjectPtr<T>(T obj)
		{
			return default(ObjectPtr<T>);
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F7C")]
		public static explicit operator T(ObjectPtr<T> ptr)
		{
			return null;
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x0002E590 File Offset: 0x0002C790
		[Token(Token = "0x6004F7D")]
		public static explicit operator bool(ObjectPtr<T> ptr)
		{
			return default(bool);
		}

		// Token: 0x06004F7E RID: 20350 RVA: 0x0002E5A8 File Offset: 0x0002C7A8
		[Token(Token = "0x6004F7E")]
		public static bool operator ==(ObjectPtr<T> lhs, ObjectPtr<T> rhs)
		{
			return default(bool);
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x0002E5C0 File Offset: 0x0002C7C0
		[Token(Token = "0x6004F7F")]
		public static bool operator !=(ObjectPtr<T> lhs, ObjectPtr<T> rhs)
		{
			return default(bool);
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x0002E5D8 File Offset: 0x0002C7D8
		[Token(Token = "0x6004F80")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06004F81 RID: 20353 RVA: 0x0002E5F0 File Offset: 0x0002C7F0
		[Token(Token = "0x6004F81")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x0002E608 File Offset: 0x0002C808
		[Token(Token = "0x6004F82")]
		public int CompareTo(ObjectPtr<T> other)
		{
			return 0;
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F83")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040013FE RID: 5118
		[Token(Token = "0x40013FE")]
		[FieldOffset(Offset = "0x0")]
		public readonly T obj;

		// Token: 0x040013FF RID: 5119
		[Token(Token = "0x40013FF")]
		[FieldOffset(Offset = "0x0")]
		public readonly uint cachedUid;
	}
}
