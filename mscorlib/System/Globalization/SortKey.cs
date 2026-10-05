using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x0200058C RID: 1420
	[Token(Token = "0x200058C")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	[StructLayout(0)]
	public class SortKey
	{
		// Token: 0x06002A7A RID: 10874 RVA: 0x00017BF8 File Offset: 0x00015DF8
		[Token(Token = "0x6002A7A")]
		[Address(RVA = "0x4C37700", Offset = "0x4C36300", VA = "0x184C37700")]
		public static int Compare(SortKey sortkey1, SortKey sortkey2)
		{
			return 0;
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A7B")]
		[Address(RVA = "0x4C37E00", Offset = "0x4C36A00", VA = "0x184C37E00")]
		internal SortKey(int lcid, string source, CompareOptions opt)
		{
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A7C")]
		[Address(RVA = "0x4C37D40", Offset = "0x4C36940", VA = "0x184C37D40")]
		internal SortKey(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength)
		{
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A7D")]
		[Address(RVA = "0x4C37DB0", Offset = "0x4C369B0", VA = "0x184C37DB0")]
		internal SortKey(string localeName, string str, CompareOptions options, byte[] keyData)
		{
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06002A7E RID: 10878 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700066C")]
		public virtual string OriginalString
		{
			[Token(Token = "0x6002A7E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06002A7F RID: 10879 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700066D")]
		public virtual byte[] KeyData
		{
			[Token(Token = "0x6002A7F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x00017C10 File Offset: 0x00015E10
		[Token(Token = "0x6002A80")]
		[Address(RVA = "0x4C378D0", Offset = "0x4C364D0", VA = "0x184C378D0", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x00017C28 File Offset: 0x00015E28
		[Token(Token = "0x6002A81")]
		[Address(RVA = "0x4C37A30", Offset = "0x4C36630", VA = "0x184C37A30", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A82")]
		[Address(RVA = "0x4C37AA0", Offset = "0x4C366A0", VA = "0x184C37AA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A83")]
		[Address(RVA = "0x4C37EE0", Offset = "0x4C36AE0", VA = "0x184C37EE0")]
		internal SortKey()
		{
		}

		// Token: 0x0400188D RID: 6285
		[Token(Token = "0x400188D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string source;

		// Token: 0x0400188E RID: 6286
		[Token(Token = "0x400188E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly byte[] key;

		// Token: 0x0400188F RID: 6287
		[Token(Token = "0x400188F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly CompareOptions options;

		// Token: 0x04001890 RID: 6288
		[Token(Token = "0x4001890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private readonly int lcid;
	}
}
