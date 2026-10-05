using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	public class NameTable : XmlNameTable
	{
		// Token: 0x0600063B RID: 1595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x4FC98D0", Offset = "0x4FC84D0", VA = "0x184FC98D0")]
		public NameTable()
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x4FC9280", Offset = "0x4FC7E80", VA = "0x184FC9280", Slot = "6")]
		public override string Add(string key)
		{
			return null;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x4FC9410", Offset = "0x4FC8010", VA = "0x184FC9410", Slot = "5")]
		public override string Add(char[] key, int start, int len)
		{
			return null;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x4FC95E0", Offset = "0x4FC81E0", VA = "0x184FC95E0", Slot = "4")]
		public override string Get(string value)
		{
			return null;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x4FC9000", Offset = "0x4FC7C00", VA = "0x184FC9000")]
		private string AddEntry(string str, int hashCode)
		{
			return null;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x4FC9760", Offset = "0x4FC8360", VA = "0x184FC9760")]
		private void Grow()
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x4D90F60", Offset = "0x4D8FB60", VA = "0x184D90F60")]
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
			return default(bool);
		}

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x10")]
		private NameTable.Entry[] entries;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x18")]
		private int count;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x1C")]
		private int mask;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x20")]
		private int hashCodeRandomizer;

		// Token: 0x02000087 RID: 135
		[Token(Token = "0x2000087")]
		private class Entry
		{
			// Token: 0x06000642 RID: 1602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x3DD65F0", Offset = "0x3DD51F0", VA = "0x183DD65F0")]
			internal Entry(string str, int hashCode, NameTable.Entry next)
			{
			}

			// Token: 0x04000305 RID: 773
			[Token(Token = "0x4000305")]
			[FieldOffset(Offset = "0x10")]
			internal string str;

			// Token: 0x04000306 RID: 774
			[Token(Token = "0x4000306")]
			[FieldOffset(Offset = "0x18")]
			internal int hashCode;

			// Token: 0x04000307 RID: 775
			[Token(Token = "0x4000307")]
			[FieldOffset(Offset = "0x20")]
			internal NameTable.Entry next;
		}
	}
}
