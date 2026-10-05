using System;
using Il2CppDummyDll;

namespace System.Security
{
	// Token: 0x020002BC RID: 700
	[Token(Token = "0x20002BC")]
	[System.Serializable]
	internal sealed class SecurityDocument
	{
		// Token: 0x0600177F RID: 6015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177F")]
		[Address(RVA = "0x4B19280", Offset = "0x4B17E80", VA = "0x184B19280")]
		public SecurityDocument(int numData)
		{
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001780")]
		[Address(RVA = "0x4B18F50", Offset = "0x4B17B50", VA = "0x184B18F50")]
		public void GuaranteeSize(int size)
		{
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001781")]
		[Address(RVA = "0x4B187F0", Offset = "0x4B173F0", VA = "0x184B187F0")]
		public void AddString(string str, ref int position)
		{
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001782")]
		[Address(RVA = "0x4B18A90", Offset = "0x4B17690", VA = "0x184B18A90")]
		public void AppendString(string str, ref int position)
		{
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00011088 File Offset: 0x0000F288
		[Token(Token = "0x6001783")]
		[Address(RVA = "0x4B18B40", Offset = "0x4B17740", VA = "0x184B18B40")]
		public static int EncodedStringSize(string str)
		{
			return 0;
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001784")]
		[Address(RVA = "0x4B18BB0", Offset = "0x4B177B0", VA = "0x184B18BB0")]
		public string GetString(ref int position, bool bCreate)
		{
			return null;
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001785")]
		[Address(RVA = "0x4B189A0", Offset = "0x4B175A0", VA = "0x184B189A0")]
		public void AddToken(byte b, ref int position)
		{
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001786")]
		[Address(RVA = "0x4B18B80", Offset = "0x4B17780", VA = "0x184B18B80")]
		public SecurityElement GetRootElement()
		{
			return null;
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001787")]
		[Address(RVA = "0x4B18B60", Offset = "0x4B17760", VA = "0x184B18B60")]
		public SecurityElement GetElement(int position, bool bCreate)
		{
			return null;
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001788")]
		[Address(RVA = "0x4B18FF0", Offset = "0x4B17BF0", VA = "0x184B18FF0")]
		internal SecurityElement InternalGetElement(ref int position, bool bCreate)
		{
			return null;
		}

		// Token: 0x04000CBC RID: 3260
		[Token(Token = "0x4000CBC")]
		[FieldOffset(Offset = "0x10")]
		internal byte[] m_data;
	}
}
