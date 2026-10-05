using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	[Preserve]
	internal class PropertyNameTable
	{
		// Token: 0x060002C0 RID: 704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x4D91030", Offset = "0x4D8FC30", VA = "0x184D91030")]
		public PropertyNameTable()
		{
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x4D90C20", Offset = "0x4D8F820", VA = "0x184D90C20")]
		public string Get(char[] key, int start, int length)
		{
			return null;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x4D90A60", Offset = "0x4D8F660", VA = "0x184D90A60")]
		public string Add(string key)
		{
			return null;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x4D907E0", Offset = "0x4D8F3E0", VA = "0x184D907E0")]
		private string AddEntry(string str, int hashCode)
		{
			return null;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x4D90E00", Offset = "0x4D8FA00", VA = "0x184D90E00")]
		private void Grow()
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x4D90F60", Offset = "0x4D8FB60", VA = "0x184D90F60")]
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
			return default(bool);
		}

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int HashCodeRandomizer;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x10")]
		private int _count;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x18")]
		private PropertyNameTable.Entry[] _entries;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x20")]
		private int _mask;

		// Token: 0x02000043 RID: 67
		[Token(Token = "0x2000043")]
		private class Entry
		{
			// Token: 0x060002C6 RID: 710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x3DD65F0", Offset = "0x3DD51F0", VA = "0x183DD65F0")]
			internal Entry(string value, int hashCode, PropertyNameTable.Entry next)
			{
			}

			// Token: 0x0400017B RID: 379
			[Token(Token = "0x400017B")]
			[FieldOffset(Offset = "0x10")]
			internal readonly string Value;

			// Token: 0x0400017C RID: 380
			[Token(Token = "0x400017C")]
			[FieldOffset(Offset = "0x18")]
			internal readonly int HashCode;

			// Token: 0x0400017D RID: 381
			[Token(Token = "0x400017D")]
			[FieldOffset(Offset = "0x20")]
			internal PropertyNameTable.Entry Next;
		}
	}
}
