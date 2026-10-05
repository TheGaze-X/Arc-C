using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000591 RID: 1425
	[Token(Token = "0x2000591")]
	internal static class EncodingTable
	{
		// Token: 0x06002ABF RID: 10943 RVA: 0x00017CE8 File Offset: 0x00015EE8
		[Token(Token = "0x6002ABF")]
		[Address(RVA = "0x4C4C330", Offset = "0x4C4AF30", VA = "0x184C4C330")]
		private static int GetNumEncodingItems()
		{
			return 0;
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x00017D00 File Offset: 0x00015F00
		[Token(Token = "0x6002AC0")]
		[Address(RVA = "0x4C4BDE0", Offset = "0x4C4A9E0", VA = "0x184C4BDE0")]
		private static InternalEncodingDataItem ENC(string name, ushort cp)
		{
			return default(InternalEncodingDataItem);
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x00017D18 File Offset: 0x00015F18
		[Token(Token = "0x6002AC1")]
		[Address(RVA = "0x4C4C390", Offset = "0x4C4AF90", VA = "0x184C4C390")]
		private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags)
		{
			return default(InternalCodePageDataItem);
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x00017D30 File Offset: 0x00015F30
		[Token(Token = "0x6002AC3")]
		[Address(RVA = "0x4C56540", Offset = "0x4C55140", VA = "0x184C56540")]
		private static int internalGetCodePageFromName(string name)
		{
			return 0;
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x00017D48 File Offset: 0x00015F48
		[Token(Token = "0x6002AC4")]
		[Address(RVA = "0x4C4C0E0", Offset = "0x4C4ACE0", VA = "0x184C4C0E0")]
		internal static int GetCodePageFromName(string name)
		{
			return 0;
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AC5")]
		[Address(RVA = "0x4C4BE20", Offset = "0x4C4AA20", VA = "0x184C4BE20")]
		internal static CodePageDataItem GetCodePageDataItem(int codepage)
		{
			return null;
		}

		// Token: 0x040018C4 RID: 6340
		[Token(Token = "0x40018C4")]
		[FieldOffset(Offset = "0x0")]
		internal static InternalEncodingDataItem[] encodingDataPtr;

		// Token: 0x040018C5 RID: 6341
		[Token(Token = "0x40018C5")]
		[FieldOffset(Offset = "0x8")]
		internal static InternalCodePageDataItem[] codePageDataPtr;

		// Token: 0x040018C6 RID: 6342
		[Token(Token = "0x40018C6")]
		[FieldOffset(Offset = "0x10")]
		private static int lastEncodingItem;

		// Token: 0x040018C7 RID: 6343
		[Token(Token = "0x40018C7")]
		[FieldOffset(Offset = "0x18")]
		private static System.Collections.Generic.Dictionary<string, int> hashByName;

		// Token: 0x040018C8 RID: 6344
		[Token(Token = "0x40018C8")]
		[FieldOffset(Offset = "0x20")]
		private static System.Collections.Generic.Dictionary<int, CodePageDataItem> hashByCodePage;
	}
}
