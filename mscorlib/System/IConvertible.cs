using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	[System.CLSCompliant(false)]
	public interface IConvertible
	{
		// Token: 0x060007F7 RID: 2039
		[Token(Token = "0x60007F7")]
		System.TypeCode GetTypeCode();

		// Token: 0x060007F8 RID: 2040
		[Token(Token = "0x60007F8")]
		bool ToBoolean(System.IFormatProvider provider);

		// Token: 0x060007F9 RID: 2041
		[Token(Token = "0x60007F9")]
		char ToChar(System.IFormatProvider provider);

		// Token: 0x060007FA RID: 2042
		[Token(Token = "0x60007FA")]
		sbyte ToSByte(System.IFormatProvider provider);

		// Token: 0x060007FB RID: 2043
		[Token(Token = "0x60007FB")]
		byte ToByte(System.IFormatProvider provider);

		// Token: 0x060007FC RID: 2044
		[Token(Token = "0x60007FC")]
		short ToInt16(System.IFormatProvider provider);

		// Token: 0x060007FD RID: 2045
		[Token(Token = "0x60007FD")]
		ushort ToUInt16(System.IFormatProvider provider);

		// Token: 0x060007FE RID: 2046
		[Token(Token = "0x60007FE")]
		int ToInt32(System.IFormatProvider provider);

		// Token: 0x060007FF RID: 2047
		[Token(Token = "0x60007FF")]
		uint ToUInt32(System.IFormatProvider provider);

		// Token: 0x06000800 RID: 2048
		[Token(Token = "0x6000800")]
		long ToInt64(System.IFormatProvider provider);

		// Token: 0x06000801 RID: 2049
		[Token(Token = "0x6000801")]
		ulong ToUInt64(System.IFormatProvider provider);

		// Token: 0x06000802 RID: 2050
		[Token(Token = "0x6000802")]
		float ToSingle(System.IFormatProvider provider);

		// Token: 0x06000803 RID: 2051
		[Token(Token = "0x6000803")]
		double ToDouble(System.IFormatProvider provider);

		// Token: 0x06000804 RID: 2052
		[Token(Token = "0x6000804")]
		decimal ToDecimal(System.IFormatProvider provider);

		// Token: 0x06000805 RID: 2053
		[Token(Token = "0x6000805")]
		System.DateTime ToDateTime(System.IFormatProvider provider);

		// Token: 0x06000806 RID: 2054
		[Token(Token = "0x6000806")]
		string ToString(System.IFormatProvider provider);

		// Token: 0x06000807 RID: 2055
		[Token(Token = "0x6000807")]
		object ToType(System.Type conversionType, System.IFormatProvider provider);
	}
}
