using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002DD RID: 733
	[Token(Token = "0x20002DD")]
	public class ObjectPool
	{
		// Token: 0x17000156 RID: 342
		[Token(Token = "0x17000156")]
		public object this[int i]
		{
			[Token(Token = "0x6003787")]
			[Address(RVA = "0x344C0A0", Offset = "0x344ACA0", VA = "0x18344C0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003788")]
		[Address(RVA = "0x344C040", Offset = "0x344AC40", VA = "0x18344C040")]
		public void Clear()
		{
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003789")]
		[Address(RVA = "0x344C2E0", Offset = "0x344AEE0", VA = "0x18344C2E0")]
		private void extend_capacity()
		{
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x00016860 File Offset: 0x00014A60
		[Token(Token = "0x600378A")]
		[Address(RVA = "0x344BCB0", Offset = "0x344A8B0", VA = "0x18344BCB0")]
		public int Add(object obj)
		{
			return 0;
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x00016878 File Offset: 0x00014A78
		[Token(Token = "0x600378B")]
		[Address(RVA = "0x344C200", Offset = "0x344AE00", VA = "0x18344C200")]
		public bool TryGetValue(int index, out object obj)
		{
			return default(bool);
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378C")]
		[Address(RVA = "0x344C0A0", Offset = "0x344ACA0", VA = "0x18344C0A0")]
		public object Get(int index)
		{
			return null;
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378D")]
		[Address(RVA = "0x344C0E0", Offset = "0x344ACE0", VA = "0x18344C0E0")]
		public object Remove(int index)
		{
			return null;
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378E")]
		[Address(RVA = "0x344C190", Offset = "0x344AD90", VA = "0x18344C190")]
		public object Replace(int index, object o)
		{
			return null;
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x00016890 File Offset: 0x00014A90
		[Token(Token = "0x600378F")]
		[Address(RVA = "0x344BEB0", Offset = "0x344AAB0", VA = "0x18344BEB0")]
		public int Check(int check_pos, int max_check, Func<object, bool> checker, Dictionary<object, int> reverse_map)
		{
			return 0;
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003790")]
		[Address(RVA = "0x344C280", Offset = "0x344AE80", VA = "0x18344C280")]
		public ObjectPool()
		{
		}

		// Token: 0x04000D66 RID: 3430
		[Token(Token = "0x4000D66")]
		private const int LIST_END = -1;

		// Token: 0x04000D67 RID: 3431
		[Token(Token = "0x4000D67")]
		private const int ALLOCED = -2;

		// Token: 0x04000D68 RID: 3432
		[Token(Token = "0x4000D68")]
		[FieldOffset(Offset = "0x10")]
		private ObjectPool.Slot[] list;

		// Token: 0x04000D69 RID: 3433
		[Token(Token = "0x4000D69")]
		[FieldOffset(Offset = "0x18")]
		private int freelist;

		// Token: 0x04000D6A RID: 3434
		[Token(Token = "0x4000D6A")]
		[FieldOffset(Offset = "0x1C")]
		private int count;

		// Token: 0x020002DE RID: 734
		[Token(Token = "0x20002DE")]
		private struct Slot
		{
			// Token: 0x06003791 RID: 14225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003791")]
			[Address(RVA = "0x5159D0", Offset = "0x5145D0", VA = "0x1805159D0")]
			public Slot(int next, object obj)
			{
			}

			// Token: 0x04000D6B RID: 3435
			[Token(Token = "0x4000D6B")]
			[FieldOffset(Offset = "0x0")]
			public int next;

			// Token: 0x04000D6C RID: 3436
			[Token(Token = "0x4000D6C")]
			[FieldOffset(Offset = "0x8")]
			public object obj;
		}
	}
}
