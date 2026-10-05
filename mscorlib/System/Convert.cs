using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	public static class Convert
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x00005028 File Offset: 0x00003228
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x4CB3550", Offset = "0x4CB2150", VA = "0x184CB3550")]
		private static bool TryDecodeFromUtf16(System.ReadOnlySpan<char> utf16, System.Span<byte> bytes, out int consumed, out int written)
		{
			return default(bool);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00005040 File Offset: 0x00003240
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x4CAC500", Offset = "0x4CAB100", VA = "0x184CAC500")]
		[MethodImpl(256)]
		private static int Decode(ref char encodedChars, ref sbyte decodingMap)
		{
			return 0;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x4CB3F10", Offset = "0x4CB2B10", VA = "0x184CB3F10")]
		[MethodImpl(256)]
		private static void WriteThreeLowOrderBytes(ref byte destination, int value)
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x4CAD630", Offset = "0x4CAC230", VA = "0x184CAD630")]
		public static System.TypeCode GetTypeCode(object value)
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x4CABBF0", Offset = "0x4CAA7F0", VA = "0x184CABBF0")]
		public static object ChangeType(object value, System.TypeCode typeCode, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x4CAC560", Offset = "0x4CAB160", VA = "0x184CAC560")]
		internal static object DefaultToType(System.IConvertible value, System.Type targetType, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x4CAB1B0", Offset = "0x4CA9DB0", VA = "0x184CAB1B0")]
		public static object ChangeType(object value, System.Type conversionType)
		{
			return null;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x4CAB250", Offset = "0x4CA9E50", VA = "0x184CAB250")]
		public static object ChangeType(object value, System.Type conversionType, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x4CAD730", Offset = "0x4CAC330", VA = "0x184CAD730")]
		[MethodImpl(8)]
		private static void ThrowCharOverflowException()
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x4CAD6D0", Offset = "0x4CAC2D0", VA = "0x184CAD6D0")]
		[MethodImpl(8)]
		private static void ThrowByteOverflowException()
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x4CAD8B0", Offset = "0x4CAC4B0", VA = "0x184CAD8B0")]
		[MethodImpl(8)]
		private static void ThrowSByteOverflowException()
		{
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x4CAD790", Offset = "0x4CAC390", VA = "0x184CAD790")]
		[MethodImpl(8)]
		private static void ThrowInt16OverflowException()
		{
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x4CAD910", Offset = "0x4CAC510", VA = "0x184CAD910")]
		[MethodImpl(8)]
		private static void ThrowUInt16OverflowException()
		{
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x4CAD7F0", Offset = "0x4CAC3F0", VA = "0x184CAD7F0")]
		[MethodImpl(8)]
		private static void ThrowInt32OverflowException()
		{
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x4CAD970", Offset = "0x4CAC570", VA = "0x184CAD970")]
		[MethodImpl(8)]
		private static void ThrowUInt32OverflowException()
		{
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x4CAD850", Offset = "0x4CAC450", VA = "0x184CAD850")]
		[MethodImpl(8)]
		private static void ThrowInt64OverflowException()
		{
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x4CAD9D0", Offset = "0x4CAC5D0", VA = "0x184CAD9D0")]
		[MethodImpl(8)]
		private static void ThrowUInt64OverflowException()
		{
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00005070 File Offset: 0x00003270
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x4CAE6A0", Offset = "0x4CAD2A0", VA = "0x184CAE6A0")]
		public static bool ToBoolean(object value)
		{
			return default(bool);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00005088 File Offset: 0x00003288
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x4CAE5E0", Offset = "0x4CAD1E0", VA = "0x184CAE5E0")]
		public static bool ToBoolean(object value, System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000050A0 File Offset: 0x000032A0
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x4CAE5D0", Offset = "0x4CAD1D0", VA = "0x184CAE5D0")]
		[System.CLSCompliant(false)]
		public static bool ToBoolean(sbyte value)
		{
			return default(bool);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000050B8 File Offset: 0x000032B8
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x4CAE5D0", Offset = "0x4CAD1D0", VA = "0x184CAE5D0")]
		public static bool ToBoolean(byte value)
		{
			return default(bool);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000050D0 File Offset: 0x000032D0
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x4CAE7B0", Offset = "0x4CAD3B0", VA = "0x184CAE7B0")]
		public static bool ToBoolean(short value)
		{
			return default(bool);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000050E8 File Offset: 0x000032E8
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x4CAE7B0", Offset = "0x4CAD3B0", VA = "0x184CAE7B0")]
		[System.CLSCompliant(false)]
		public static bool ToBoolean(ushort value)
		{
			return default(bool);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00005100 File Offset: 0x00003300
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x4CAE690", Offset = "0x4CAD290", VA = "0x184CAE690")]
		public static bool ToBoolean(int value)
		{
			return default(bool);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00005118 File Offset: 0x00003318
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x4CAE690", Offset = "0x4CAD290", VA = "0x184CAE690")]
		[System.CLSCompliant(false)]
		public static bool ToBoolean(uint value)
		{
			return default(bool);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00005130 File Offset: 0x00003330
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x4CAE5C0", Offset = "0x4CAD1C0", VA = "0x184CAE5C0")]
		public static bool ToBoolean(long value)
		{
			return default(bool);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00005148 File Offset: 0x00003348
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x4CAE5C0", Offset = "0x4CAD1C0", VA = "0x184CAE5C0")]
		[System.CLSCompliant(false)]
		public static bool ToBoolean(ulong value)
		{
			return default(bool);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00005160 File Offset: 0x00003360
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x4CAE740", Offset = "0x4CAD340", VA = "0x184CAE740")]
		public static bool ToBoolean(string value)
		{
			return default(bool);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00005178 File Offset: 0x00003378
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x4CAE860", Offset = "0x4CAD460", VA = "0x184CAE860")]
		public static bool ToBoolean(string value, System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00005190 File Offset: 0x00003390
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x4CAE7A0", Offset = "0x4CAD3A0", VA = "0x184CAE7A0")]
		public static bool ToBoolean(float value)
		{
			return default(bool);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000051A8 File Offset: 0x000033A8
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x4CAE7C0", Offset = "0x4CAD3C0", VA = "0x184CAE7C0")]
		public static bool ToBoolean(double value)
		{
			return default(bool);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000051C0 File Offset: 0x000033C0
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x4CAE7E0", Offset = "0x4CAD3E0", VA = "0x184CAE7E0")]
		public static bool ToBoolean(decimal value)
		{
			return default(bool);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000051D8 File Offset: 0x000033D8
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x4CAF210", Offset = "0x4CADE10", VA = "0x184CAF210")]
		public static char ToChar(object value)
		{
			return '\0';
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000051F0 File Offset: 0x000033F0
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x4CAF4A0", Offset = "0x4CAE0A0", VA = "0x184CAF4A0")]
		public static char ToChar(object value, System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00005208 File Offset: 0x00003408
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x4CAF450", Offset = "0x4CAE050", VA = "0x184CAF450")]
		[System.CLSCompliant(false)]
		public static char ToChar(sbyte value)
		{
			return '\0';
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00005220 File Offset: 0x00003420
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x3B13DD0", Offset = "0x3B129D0", VA = "0x183B13DD0")]
		public static char ToChar(byte value)
		{
			return '\0';
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00005238 File Offset: 0x00003438
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x4CAF3B0", Offset = "0x4CADFB0", VA = "0x184CAF3B0")]
		public static char ToChar(short value)
		{
			return '\0';
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00005250 File Offset: 0x00003450
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x4AE96C0", Offset = "0x4AE82C0", VA = "0x184AE96C0")]
		[System.CLSCompliant(false)]
		public static char ToChar(ushort value)
		{
			return '\0';
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00005268 File Offset: 0x00003468
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x4CAF550", Offset = "0x4CAE150", VA = "0x184CAF550")]
		public static char ToChar(int value)
		{
			return '\0';
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00005280 File Offset: 0x00003480
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x4CAF400", Offset = "0x4CAE000", VA = "0x184CAF400")]
		[System.CLSCompliant(false)]
		public static char ToChar(uint value)
		{
			return '\0';
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00005298 File Offset: 0x00003498
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x4CAF1C0", Offset = "0x4CADDC0", VA = "0x184CAF1C0")]
		public static char ToChar(long value)
		{
			return '\0';
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x000052B0 File Offset: 0x000034B0
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x4CAF0A0", Offset = "0x4CADCA0", VA = "0x184CAF0A0")]
		[System.CLSCompliant(false)]
		public static char ToChar(ulong value)
		{
			return '\0';
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000052C8 File Offset: 0x000034C8
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x4CAF2B0", Offset = "0x4CADEB0", VA = "0x184CAF2B0")]
		public static char ToChar(string value)
		{
			return '\0';
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000052E0 File Offset: 0x000034E0
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x4CAF0F0", Offset = "0x4CADCF0", VA = "0x184CAF0F0")]
		public static char ToChar(string value, System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x000052F8 File Offset: 0x000034F8
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x4CB12D0", Offset = "0x4CAFED0", VA = "0x184CB12D0")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(object value)
		{
			return 0;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00005310 File Offset: 0x00003510
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x4CB1840", Offset = "0x4CB0440", VA = "0x184CB1840")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(object value, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00005328 File Offset: 0x00003528
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x4CAE5D0", Offset = "0x4CAD1D0", VA = "0x184CAE5D0")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(bool value)
		{
			return 0;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00005340 File Offset: 0x00003540
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x4CB1750", Offset = "0x4CB0350", VA = "0x184CB1750")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(char value)
		{
			return 0;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00005358 File Offset: 0x00003558
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x4CB17F0", Offset = "0x4CB03F0", VA = "0x184CB17F0")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(byte value)
		{
			return 0;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00005370 File Offset: 0x00003570
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x4CB16A0", Offset = "0x4CB02A0", VA = "0x184CB16A0")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(short value)
		{
			return 0;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00005388 File Offset: 0x00003588
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x4CB1490", Offset = "0x4CB0090", VA = "0x184CB1490")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(ushort value)
		{
			return 0;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x000053A0 File Offset: 0x000035A0
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x4CB1700", Offset = "0x4CB0300", VA = "0x184CB1700")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(int value)
		{
			return 0;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000053B8 File Offset: 0x000035B8
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x4CB1370", Offset = "0x4CAFF70", VA = "0x184CB1370")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(uint value)
		{
			return 0;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x000053D0 File Offset: 0x000035D0
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x4CB13C0", Offset = "0x4CAFFC0", VA = "0x184CB13C0")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(long value)
		{
			return 0;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x000053E8 File Offset: 0x000035E8
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x4CB17A0", Offset = "0x4CB03A0", VA = "0x184CB17A0")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(ulong value)
		{
			return 0;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00005400 File Offset: 0x00003600
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x4CB1420", Offset = "0x4CB0020", VA = "0x184CB1420")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(float value)
		{
			return 0;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00005418 File Offset: 0x00003618
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x4CB1230", Offset = "0x4CAFE30", VA = "0x184CB1230")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(double value)
		{
			return 0;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00005430 File Offset: 0x00003630
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x4CB14E0", Offset = "0x4CB00E0", VA = "0x184CB14E0")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(decimal value)
		{
			return 0;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00005448 File Offset: 0x00003648
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x4CB1480", Offset = "0x4CB0080", VA = "0x184CB1480")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(string value, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00005460 File Offset: 0x00003660
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x4CAEF30", Offset = "0x4CADB30", VA = "0x184CAEF30")]
		public static byte ToByte(object value)
		{
			return 0;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00005478 File Offset: 0x00003678
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x4CAE9C0", Offset = "0x4CAD5C0", VA = "0x184CAE9C0")]
		public static byte ToByte(object value, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00005490 File Offset: 0x00003690
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x4CAE5D0", Offset = "0x4CAD1D0", VA = "0x184CAE5D0")]
		public static byte ToByte(bool value)
		{
			return 0;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x000054A8 File Offset: 0x000036A8
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x4CAEBE0", Offset = "0x4CAD7E0", VA = "0x184CAEBE0")]
		public static byte ToByte(char value)
		{
			return 0;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000054C0 File Offset: 0x000036C0
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x4CAEE90", Offset = "0x4CADA90", VA = "0x184CAEE90")]
		[System.CLSCompliant(false)]
		public static byte ToByte(sbyte value)
		{
			return 0;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000054D8 File Offset: 0x000036D8
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x4CAE910", Offset = "0x4CAD510", VA = "0x184CAE910")]
		public static byte ToByte(short value)
		{
			return 0;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x000054F0 File Offset: 0x000036F0
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x4CAEEE0", Offset = "0x4CADAE0", VA = "0x184CAEEE0")]
		[System.CLSCompliant(false)]
		public static byte ToByte(ushort value)
		{
			return 0;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00005508 File Offset: 0x00003708
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x4CAEC30", Offset = "0x4CAD830", VA = "0x184CAEC30")]
		public static byte ToByte(int value)
		{
			return 0;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00005520 File Offset: 0x00003720
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x4CAED20", Offset = "0x4CAD920", VA = "0x184CAED20")]
		[System.CLSCompliant(false)]
		public static byte ToByte(uint value)
		{
			return 0;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00005538 File Offset: 0x00003738
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x4CAEB90", Offset = "0x4CAD790", VA = "0x184CAEB90")]
		public static byte ToByte(long value)
		{
			return 0;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00005550 File Offset: 0x00003750
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x4CAE8C0", Offset = "0x4CAD4C0", VA = "0x184CAE8C0")]
		[System.CLSCompliant(false)]
		public static byte ToByte(ulong value)
		{
			return 0;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00005568 File Offset: 0x00003768
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x4CAE960", Offset = "0x4CAD560", VA = "0x184CAE960")]
		public static byte ToByte(float value)
		{
			return 0;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00005580 File Offset: 0x00003780
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x4CAEAF0", Offset = "0x4CAD6F0", VA = "0x184CAEAF0")]
		public static byte ToByte(double value)
		{
			return 0;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00005598 File Offset: 0x00003798
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x4CAEA70", Offset = "0x4CAD670", VA = "0x184CAEA70")]
		public static byte ToByte(decimal value)
		{
			return 0;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000055B0 File Offset: 0x000037B0
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x4CAEFD0", Offset = "0x4CADBD0", VA = "0x184CAEFD0")]
		public static byte ToByte(string value)
		{
			return 0;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000055C8 File Offset: 0x000037C8
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x4CAEC80", Offset = "0x4CAD880", VA = "0x184CAEC80")]
		public static byte ToByte(string value, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000055E0 File Offset: 0x000037E0
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x4CB05B0", Offset = "0x4CAF1B0", VA = "0x184CB05B0")]
		public static short ToInt16(object value)
		{
			return 0;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x000055F8 File Offset: 0x000037F8
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x4CB01C0", Offset = "0x4CAEDC0", VA = "0x184CB01C0")]
		public static short ToInt16(object value, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00005610 File Offset: 0x00003810
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x4CB0160", Offset = "0x4CAED60", VA = "0x184CB0160")]
		public static short ToInt16(bool value)
		{
			return 0;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00005628 File Offset: 0x00003828
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x4CB04D0", Offset = "0x4CAF0D0", VA = "0x184CB04D0")]
		public static short ToInt16(char value)
		{
			return 0;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00005640 File Offset: 0x00003840
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x4CB0520", Offset = "0x4CAF120", VA = "0x184CB0520")]
		[System.CLSCompliant(false)]
		public static short ToInt16(sbyte value)
		{
			return 0;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00005658 File Offset: 0x00003858
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x3B13DD0", Offset = "0x3B129D0", VA = "0x183B13DD0")]
		public static short ToInt16(byte value)
		{
			return 0;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00005670 File Offset: 0x00003870
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x4CB0170", Offset = "0x4CAED70", VA = "0x184CB0170")]
		[System.CLSCompliant(false)]
		public static short ToInt16(ushort value)
		{
			return 0;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00005688 File Offset: 0x00003888
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x4CB0650", Offset = "0x4CAF250", VA = "0x184CB0650")]
		public static short ToInt16(int value)
		{
			return 0;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000056A0 File Offset: 0x000038A0
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x4CB06A0", Offset = "0x4CAF2A0", VA = "0x184CB06A0")]
		[System.CLSCompliant(false)]
		public static short ToInt16(uint value)
		{
			return 0;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x000056B8 File Offset: 0x000038B8
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x4CB0270", Offset = "0x4CAEE70", VA = "0x184CB0270")]
		public static short ToInt16(long value)
		{
			return 0;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x000056D0 File Offset: 0x000038D0
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x4CB02D0", Offset = "0x4CAEED0", VA = "0x184CB02D0")]
		[System.CLSCompliant(false)]
		public static short ToInt16(ulong value)
		{
			return 0;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000056E8 File Offset: 0x000038E8
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x4CB0550", Offset = "0x4CAF150", VA = "0x184CB0550")]
		public static short ToInt16(float value)
		{
			return 0;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00005700 File Offset: 0x00003900
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x4CB06F0", Offset = "0x4CAF2F0", VA = "0x184CB06F0")]
		public static short ToInt16(double value)
		{
			return 0;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00005718 File Offset: 0x00003918
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x4CB0450", Offset = "0x4CAF050", VA = "0x184CB0450")]
		public static short ToInt16(decimal value)
		{
			return 0;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00005730 File Offset: 0x00003930
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x4CB0530", Offset = "0x4CAF130", VA = "0x184CB0530")]
		public static short ToInt16(string value, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00005748 File Offset: 0x00003948
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x4CB2710", Offset = "0x4CB1310", VA = "0x184CB2710")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(object value)
		{
			return 0;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00005760 File Offset: 0x00003960
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x4CB2660", Offset = "0x4CB1260", VA = "0x184CB2660")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(object value, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00005778 File Offset: 0x00003978
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x4CB0160", Offset = "0x4CAED60", VA = "0x184CB0160")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(bool value)
		{
			return 0;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00005790 File Offset: 0x00003990
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x4AE96C0", Offset = "0x4AE82C0", VA = "0x184AE96C0")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(char value)
		{
			return 0;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000057A8 File Offset: 0x000039A8
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x4CB24D0", Offset = "0x4CB10D0", VA = "0x184CB24D0")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(sbyte value)
		{
			return 0;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000057C0 File Offset: 0x000039C0
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x3B13DD0", Offset = "0x3B129D0", VA = "0x183B13DD0")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(byte value)
		{
			return 0;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000057D8 File Offset: 0x000039D8
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x4CB2610", Offset = "0x4CB1210", VA = "0x184CB2610")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(short value)
		{
			return 0;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000057F0 File Offset: 0x000039F0
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x4CB27B0", Offset = "0x4CB13B0", VA = "0x184CB27B0")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(int value)
		{
			return 0;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00005808 File Offset: 0x00003A08
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x4CB2850", Offset = "0x4CB1450", VA = "0x184CB2850")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(uint value)
		{
			return 0;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00005820 File Offset: 0x00003A20
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x4CB25A0", Offset = "0x4CB11A0", VA = "0x184CB25A0")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(long value)
		{
			return 0;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00005838 File Offset: 0x00003A38
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x4CB2800", Offset = "0x4CB1400", VA = "0x184CB2800")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(ulong value)
		{
			return 0;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00005850 File Offset: 0x00003A50
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x4CB2940", Offset = "0x4CB1540", VA = "0x184CB2940")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(float value)
		{
			return 0;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00005868 File Offset: 0x00003A68
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x4CB28A0", Offset = "0x4CB14A0", VA = "0x184CB28A0")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(double value)
		{
			return 0;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00005880 File Offset: 0x00003A80
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x4CB2520", Offset = "0x4CB1120", VA = "0x184CB2520")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(decimal value)
		{
			return 0;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00005898 File Offset: 0x00003A98
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x4CB25F0", Offset = "0x4CB11F0", VA = "0x184CB25F0")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(string value, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000058B0 File Offset: 0x00003AB0
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x4CB0AE0", Offset = "0x4CAF6E0", VA = "0x184CB0AE0")]
		public static int ToInt32(object value)
		{
			return 0;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x000058C8 File Offset: 0x00003AC8
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x4CB0930", Offset = "0x4CAF530", VA = "0x184CB0930")]
		public static int ToInt32(object value, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000058E0 File Offset: 0x00003AE0
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x4CB08D0", Offset = "0x4CAF4D0", VA = "0x184CB08D0")]
		public static int ToInt32(bool value)
		{
			return 0;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000058F8 File Offset: 0x00003AF8
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x4AE96C0", Offset = "0x4AE82C0", VA = "0x184AE96C0")]
		public static int ToInt32(char value)
		{
			return 0;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00005910 File Offset: 0x00003B10
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x4CB0520", Offset = "0x4CAF120", VA = "0x184CB0520")]
		[System.CLSCompliant(false)]
		public static int ToInt32(sbyte value)
		{
			return 0;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00005928 File Offset: 0x00003B28
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x3B13DD0", Offset = "0x3B129D0", VA = "0x183B13DD0")]
		public static int ToInt32(byte value)
		{
			return 0;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00005940 File Offset: 0x00003B40
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x4CB0AD0", Offset = "0x4CAF6D0", VA = "0x184CB0AD0")]
		public static int ToInt32(short value)
		{
			return 0;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00005958 File Offset: 0x00003B58
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x4AE96C0", Offset = "0x4AE82C0", VA = "0x184AE96C0")]
		[System.CLSCompliant(false)]
		public static int ToInt32(ushort value)
		{
			return 0;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00005970 File Offset: 0x00003B70
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x4CB08E0", Offset = "0x4CAF4E0", VA = "0x184CB08E0")]
		[System.CLSCompliant(false)]
		public static int ToInt32(uint value)
		{
			return 0;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00005988 File Offset: 0x00003B88
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x4CB0B80", Offset = "0x4CAF780", VA = "0x184CB0B80")]
		public static int ToInt32(long value)
		{
			return 0;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x4CB0820", Offset = "0x4CAF420", VA = "0x184CB0820")]
		[System.CLSCompliant(false)]
		public static int ToInt32(ulong value)
		{
			return 0;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x4CB0870", Offset = "0x4CAF470", VA = "0x184CB0870")]
		public static int ToInt32(float value)
		{
			return 0;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000059D0 File Offset: 0x00003BD0
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x4CB09E0", Offset = "0x4CAF5E0", VA = "0x184CB09E0")]
		public static int ToInt32(double value)
		{
			return 0;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000059E8 File Offset: 0x00003BE8
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x4CB0BE0", Offset = "0x4CAF7E0", VA = "0x184CB0BE0")]
		public static int ToInt32(decimal value)
		{
			return 0;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00005A00 File Offset: 0x00003C00
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x4CB0790", Offset = "0x4CAF390", VA = "0x184CB0790")]
		public static int ToInt32(string value)
		{
			return 0;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00005A18 File Offset: 0x00003C18
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x4CB0800", Offset = "0x4CAF400", VA = "0x184CB0800")]
		public static int ToInt32(string value, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00005A30 File Offset: 0x00003C30
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x4CB2AF0", Offset = "0x4CB16F0", VA = "0x184CB2AF0")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(object value)
		{
			return 0U;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00005A48 File Offset: 0x00003C48
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x4CB2E70", Offset = "0x4CB1A70", VA = "0x184CB2E70")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(object value, System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00005A60 File Offset: 0x00003C60
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x4CB08D0", Offset = "0x4CAF4D0", VA = "0x184CB08D0")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(bool value)
		{
			return 0U;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00005A78 File Offset: 0x00003C78
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x4AE96C0", Offset = "0x4AE82C0", VA = "0x184AE96C0")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(char value)
		{
			return 0U;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00005A90 File Offset: 0x00003C90
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x4CB2E00", Offset = "0x4CB1A00", VA = "0x184CB2E00")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(sbyte value)
		{
			return 0U;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x3B13DD0", Offset = "0x3B129D0", VA = "0x183B13DD0")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(byte value)
		{
			return 0U;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x4CB29A0", Offset = "0x4CB15A0", VA = "0x184CB29A0")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(short value)
		{
			return 0U;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x4AE96C0", Offset = "0x4AE82C0", VA = "0x184AE96C0")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(ushort value)
		{
			return 0U;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x4CB2AA0", Offset = "0x4CB16A0", VA = "0x184CB2AA0")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(int value)
		{
			return 0U;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00005B08 File Offset: 0x00003D08
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x4CB2CF0", Offset = "0x4CB18F0", VA = "0x184CB2CF0")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(long value)
		{
			return 0U;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00005B20 File Offset: 0x00003D20
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x4CB2A50", Offset = "0x4CB1650", VA = "0x184CB2A50")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(ulong value)
		{
			return 0U;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00005B38 File Offset: 0x00003D38
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x4CB29F0", Offset = "0x4CB15F0", VA = "0x184CB29F0")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(float value)
		{
			return 0U;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00005B50 File Offset: 0x00003D50
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x4CB2D40", Offset = "0x4CB1940", VA = "0x184CB2D40")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(double value)
		{
			return 0U;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00005B68 File Offset: 0x00003D68
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x4CB2F20", Offset = "0x4CB1B20", VA = "0x184CB2F20")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(decimal value)
		{
			return 0U;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00005B80 File Offset: 0x00003D80
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x4CB2C80", Offset = "0x4CB1880", VA = "0x184CB2C80")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(string value)
		{
			return 0U;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00005B98 File Offset: 0x00003D98
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x4CB2E50", Offset = "0x4CB1A50", VA = "0x184CB2E50")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(string value, System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x4CB1110", Offset = "0x4CAFD10", VA = "0x184CB1110")]
		public static long ToInt64(object value)
		{
			return 0L;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00005BC8 File Offset: 0x00003DC8
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x4CB0F30", Offset = "0x4CAFB30", VA = "0x184CB0F30")]
		public static long ToInt64(object value, System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x4CB1220", Offset = "0x4CAFE20", VA = "0x184CB1220")]
		public static long ToInt64(bool value)
		{
			return 0L;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x4AE96C0", Offset = "0x4AE82C0", VA = "0x184AE96C0")]
		public static long ToInt64(char value)
		{
			return 0L;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x4CB1010", Offset = "0x4CAFC10", VA = "0x184CB1010")]
		[System.CLSCompliant(false)]
		public static long ToInt64(sbyte value)
		{
			return 0L;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x3B13DD0", Offset = "0x3B129D0", VA = "0x183B13DD0")]
		public static long ToInt64(byte value)
		{
			return 0L;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x4CB0F20", Offset = "0x4CAFB20", VA = "0x184CB0F20")]
		public static long ToInt64(short value)
		{
			return 0L;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x4AE96C0", Offset = "0x4AE82C0", VA = "0x184AE96C0")]
		[System.CLSCompliant(false)]
		public static long ToInt64(ushort value)
		{
			return 0L;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00005C70 File Offset: 0x00003E70
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x4CB1000", Offset = "0x4CAFC00", VA = "0x184CB1000")]
		public static long ToInt64(int value)
		{
			return 0L;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00005C88 File Offset: 0x00003E88
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		[System.CLSCompliant(false)]
		public static long ToInt64(uint value)
		{
			return 0L;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x4CB1020", Offset = "0x4CAFC20", VA = "0x184CB1020")]
		[System.CLSCompliant(false)]
		public static long ToInt64(ulong value)
		{
			return 0L;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00005CB8 File Offset: 0x00003EB8
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x4CB0E40", Offset = "0x4CAFA40", VA = "0x184CB0E40")]
		public static long ToInt64(float value)
		{
			return 0L;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00005CD0 File Offset: 0x00003ED0
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x4CB1080", Offset = "0x4CAFC80", VA = "0x184CB1080")]
		public static long ToInt64(double value)
		{
			return 0L;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00005CE8 File Offset: 0x00003EE8
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x4CB0EA0", Offset = "0x4CAFAA0", VA = "0x184CB0EA0")]
		public static long ToInt64(decimal value)
		{
			return 0L;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00005D00 File Offset: 0x00003F00
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x4CB11B0", Offset = "0x4CAFDB0", VA = "0x184CB11B0")]
		public static long ToInt64(string value)
		{
			return 0L;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00005D18 File Offset: 0x00003F18
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x4CB0FE0", Offset = "0x4CAFBE0", VA = "0x184CB0FE0")]
		public static long ToInt64(string value, System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00005D30 File Offset: 0x00003F30
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x4CB3240", Offset = "0x4CB1E40", VA = "0x184CB3240")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(object value)
		{
			return 0UL;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00005D48 File Offset: 0x00003F48
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x4CB3190", Offset = "0x4CB1D90", VA = "0x184CB3190")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(object value, System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00005D60 File Offset: 0x00003F60
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x4CB08D0", Offset = "0x4CAF4D0", VA = "0x184CB08D0")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(bool value)
		{
			return 0UL;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00005D78 File Offset: 0x00003F78
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x4AE96C0", Offset = "0x4AE82C0", VA = "0x184AE96C0")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(char value)
		{
			return 0UL;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00005D90 File Offset: 0x00003F90
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x4CB2FA0", Offset = "0x4CB1BA0", VA = "0x184CB2FA0")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(sbyte value)
		{
			return 0UL;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00005DA8 File Offset: 0x00003FA8
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x3B13DD0", Offset = "0x3B129D0", VA = "0x183B13DD0")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(byte value)
		{
			return 0UL;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00005DC0 File Offset: 0x00003FC0
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x4CB33C0", Offset = "0x4CB1FC0", VA = "0x184CB33C0")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(short value)
		{
			return 0UL;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00005DD8 File Offset: 0x00003FD8
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x4AE96C0", Offset = "0x4AE82C0", VA = "0x184AE96C0")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(ushort value)
		{
			return 0UL;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00005DF0 File Offset: 0x00003FF0
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x4CB3010", Offset = "0x4CB1C10", VA = "0x184CB3010")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(int value)
		{
			return 0UL;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00005E08 File Offset: 0x00004008
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(uint value)
		{
			return 0UL;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00005E20 File Offset: 0x00004020
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x4CB3410", Offset = "0x4CB2010", VA = "0x184CB3410")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(long value)
		{
			return 0UL;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00005E38 File Offset: 0x00004038
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x4CB32E0", Offset = "0x4CB1EE0", VA = "0x184CB32E0")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(float value)
		{
			return 0UL;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00005E50 File Offset: 0x00004050
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x4CB3060", Offset = "0x4CB1C60", VA = "0x184CB3060")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(double value)
		{
			return 0UL;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00005E68 File Offset: 0x00004068
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x4CB3340", Offset = "0x4CB1F40", VA = "0x184CB3340")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(decimal value)
		{
			return 0UL;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00005E80 File Offset: 0x00004080
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x4CB3120", Offset = "0x4CB1D20", VA = "0x184CB3120")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(string value)
		{
			return 0UL;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00005E98 File Offset: 0x00004098
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x4CB2FF0", Offset = "0x4CB1BF0", VA = "0x184CB2FF0")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(string value, System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00005EB0 File Offset: 0x000040B0
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x4CB19B0", Offset = "0x4CB05B0", VA = "0x184CB19B0")]
		public static float ToSingle(object value)
		{
			return 0f;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00005EC8 File Offset: 0x000040C8
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x4CB1B30", Offset = "0x4CB0730", VA = "0x184CB1B30")]
		public static float ToSingle(object value, System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00005EE0 File Offset: 0x000040E0
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x4CB1A50", Offset = "0x4CB0650", VA = "0x184CB1A50")]
		[System.CLSCompliant(false)]
		public static float ToSingle(sbyte value)
		{
			return 0f;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00005EF8 File Offset: 0x000040F8
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x4CB1900", Offset = "0x4CB0500", VA = "0x184CB1900")]
		public static float ToSingle(byte value)
		{
			return 0f;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00005F10 File Offset: 0x00004110
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x4CB1910", Offset = "0x4CB0510", VA = "0x184CB1910")]
		public static float ToSingle(short value)
		{
			return 0f;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00005F28 File Offset: 0x00004128
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x4CB18F0", Offset = "0x4CB04F0", VA = "0x184CB18F0")]
		[System.CLSCompliant(false)]
		public static float ToSingle(ushort value)
		{
			return 0f;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00005F40 File Offset: 0x00004140
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x4CB1B20", Offset = "0x4CB0720", VA = "0x184CB1B20")]
		public static float ToSingle(int value)
		{
			return 0f;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00005F58 File Offset: 0x00004158
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x4CB1990", Offset = "0x4CB0590", VA = "0x184CB1990")]
		[System.CLSCompliant(false)]
		public static float ToSingle(uint value)
		{
			return 0f;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00005F70 File Offset: 0x00004170
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x4CB19A0", Offset = "0x4CB05A0", VA = "0x184CB19A0")]
		public static float ToSingle(long value)
		{
			return 0f;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00005F88 File Offset: 0x00004188
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x4CB1A80", Offset = "0x4CB0680", VA = "0x184CB1A80")]
		[System.CLSCompliant(false)]
		public static float ToSingle(ulong value)
		{
			return 0f;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00005FA0 File Offset: 0x000041A0
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x4CB1BE0", Offset = "0x4CB07E0", VA = "0x184CB1BE0")]
		public static float ToSingle(double value)
		{
			return 0f;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00005FB8 File Offset: 0x000041B8
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x4CB1AB0", Offset = "0x4CB06B0", VA = "0x184CB1AB0")]
		public static float ToSingle(decimal value)
		{
			return 0f;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00005FD0 File Offset: 0x000041D0
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x4CB1920", Offset = "0x4CB0520", VA = "0x184CB1920")]
		public static float ToSingle(string value)
		{
			return 0f;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00005FE8 File Offset: 0x000041E8
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x4CB1A60", Offset = "0x4CB0660", VA = "0x184CB1A60")]
		public static float ToSingle(string value, System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00006000 File Offset: 0x00004200
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x4CB1B10", Offset = "0x4CB0710", VA = "0x184CB1B10")]
		public static float ToSingle(bool value)
		{
			return 0f;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00006018 File Offset: 0x00004218
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x4CAFF00", Offset = "0x4CAEB00", VA = "0x184CAFF00")]
		public static double ToDouble(object value)
		{
			return 0.0;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00006030 File Offset: 0x00004230
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x4CAFFA0", Offset = "0x4CAEBA0", VA = "0x184CAFFA0")]
		public static double ToDouble(object value, System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x4CAFE10", Offset = "0x4CAEA10", VA = "0x184CAFE10")]
		[System.CLSCompliant(false)]
		public static double ToDouble(sbyte value)
		{
			return 0.0;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00006060 File Offset: 0x00004260
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x4CAFEF0", Offset = "0x4CAEAF0", VA = "0x184CAFEF0")]
		public static double ToDouble(byte value)
		{
			return 0.0;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00006078 File Offset: 0x00004278
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x4CB0150", Offset = "0x4CAED50", VA = "0x184CB0150")]
		public static double ToDouble(short value)
		{
			return 0.0;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00006090 File Offset: 0x00004290
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x4CAFE80", Offset = "0x4CAEA80", VA = "0x184CAFE80")]
		[System.CLSCompliant(false)]
		public static double ToDouble(ushort value)
		{
			return 0.0;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x000060A8 File Offset: 0x000042A8
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x4CAFE20", Offset = "0x4CAEA20", VA = "0x184CAFE20")]
		public static double ToDouble(int value)
		{
			return 0.0;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x000060C0 File Offset: 0x000042C0
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x4CB0050", Offset = "0x4CAEC50", VA = "0x184CB0050")]
		[System.CLSCompliant(false)]
		public static double ToDouble(uint value)
		{
			return 0.0;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x000060D8 File Offset: 0x000042D8
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x4CAFE30", Offset = "0x4CAEA30", VA = "0x184CAFE30")]
		public static double ToDouble(long value)
		{
			return 0.0;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000060F0 File Offset: 0x000042F0
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x4CAFE50", Offset = "0x4CAEA50", VA = "0x184CAFE50")]
		[System.CLSCompliant(false)]
		public static double ToDouble(ulong value)
		{
			return 0.0;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00006108 File Offset: 0x00004308
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x4CB0060", Offset = "0x4CAEC60", VA = "0x184CB0060")]
		public static double ToDouble(float value)
		{
			return 0.0;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00006120 File Offset: 0x00004320
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x4CAFE90", Offset = "0x4CAEA90", VA = "0x184CAFE90")]
		public static double ToDouble(decimal value)
		{
			return 0.0;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00006138 File Offset: 0x00004338
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x4CB0070", Offset = "0x4CAEC70", VA = "0x184CB0070")]
		public static double ToDouble(string value, System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00006150 File Offset: 0x00004350
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x4CAFE40", Offset = "0x4CAEA40", VA = "0x184CAFE40")]
		public static double ToDouble(bool value)
		{
			return 0.0;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00006168 File Offset: 0x00004368
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x4CAF8D0", Offset = "0x4CAE4D0", VA = "0x184CAF8D0")]
		public static decimal ToDecimal(object value, System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00006180 File Offset: 0x00004380
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x4CAFB30", Offset = "0x4CAE730", VA = "0x184CAFB30")]
		[System.CLSCompliant(false)]
		public static decimal ToDecimal(sbyte value)
		{
			return 0m;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00006198 File Offset: 0x00004398
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x4CAF7F0", Offset = "0x4CAE3F0", VA = "0x184CAF7F0")]
		public static decimal ToDecimal(byte value)
		{
			return 0m;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x000061B0 File Offset: 0x000043B0
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x4CAFAC0", Offset = "0x4CAE6C0", VA = "0x184CAFAC0")]
		public static decimal ToDecimal(short value)
		{
			return 0m;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x000061C8 File Offset: 0x000043C8
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x4CAFBA0", Offset = "0x4CAE7A0", VA = "0x184CAFBA0")]
		[System.CLSCompliant(false)]
		public static decimal ToDecimal(ushort value)
		{
			return 0m;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x000061E0 File Offset: 0x000043E0
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x4CAF9E0", Offset = "0x4CAE5E0", VA = "0x184CAF9E0")]
		public static decimal ToDecimal(int value)
		{
			return 0m;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000061F8 File Offset: 0x000043F8
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x4CAFCF0", Offset = "0x4CAE8F0", VA = "0x184CAFCF0")]
		[System.CLSCompliant(false)]
		public static decimal ToDecimal(uint value)
		{
			return 0m;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00006210 File Offset: 0x00004410
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x4CAF860", Offset = "0x4CAE460", VA = "0x184CAF860")]
		public static decimal ToDecimal(long value)
		{
			return 0m;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00006228 File Offset: 0x00004428
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x4CAFC10", Offset = "0x4CAE810", VA = "0x184CAFC10")]
		[System.CLSCompliant(false)]
		public static decimal ToDecimal(ulong value)
		{
			return 0m;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00006240 File Offset: 0x00004440
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x4CAF780", Offset = "0x4CAE380", VA = "0x184CAF780")]
		public static decimal ToDecimal(float value)
		{
			return 0m;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00006258 File Offset: 0x00004458
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x4CAFC80", Offset = "0x4CAE880", VA = "0x184CAFC80")]
		public static decimal ToDecimal(double value)
		{
			return 0m;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00006270 File Offset: 0x00004470
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x4CAFD60", Offset = "0x4CAE960", VA = "0x184CAFD60")]
		public static decimal ToDecimal(string value, System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00006288 File Offset: 0x00004488
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x4CAFA50", Offset = "0x4CAE650", VA = "0x184CAFA50")]
		public static decimal ToDecimal(bool value)
		{
			return 0m;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000062A0 File Offset: 0x000044A0
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x4CAF5A0", Offset = "0x4CAE1A0", VA = "0x184CAF5A0")]
		public static System.DateTime ToDateTime(object value, System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000062B8 File Offset: 0x000044B8
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x4CAF6F0", Offset = "0x4CAE2F0", VA = "0x184CAF6F0")]
		public static System.DateTime ToDateTime(string value)
		{
			return default(System.DateTime);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000062D0 File Offset: 0x000044D0
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x4CAF680", Offset = "0x4CAE280", VA = "0x184CAF680")]
		public static System.DateTime ToDateTime(string value, System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x4CB1BF0", Offset = "0x4CB07F0", VA = "0x184CB1BF0")]
		public static string ToString(object value)
		{
			return null;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x4CB1F00", Offset = "0x4CB0B00", VA = "0x184CB1F00")]
		public static string ToString(object value, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x4CB1EB0", Offset = "0x4CB0AB0", VA = "0x184CB1EB0")]
		public static string ToString(char value)
		{
			return null;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x4CB22D0", Offset = "0x4CB0ED0", VA = "0x184CB22D0")]
		public static string ToString(char value, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x4CB21C0", Offset = "0x4CB0DC0", VA = "0x184CB21C0")]
		public static string ToString(int value, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x4CB21E0", Offset = "0x4CB0DE0", VA = "0x184CB21E0")]
		public static string ToString(long value)
		{
			return null;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x4CB1D80", Offset = "0x4CB0980", VA = "0x184CB1D80")]
		public static string ToString(long value, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x4CB2110", Offset = "0x4CB0D10", VA = "0x184CB2110")]
		[System.CLSCompliant(false)]
		public static string ToString(ulong value, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x4CB1E40", Offset = "0x4CB0A40", VA = "0x184CB1E40")]
		public static string ToString(double value, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x4CB2350", Offset = "0x4CB0F50", VA = "0x184CB2350")]
		public static string ToString(decimal value, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x4CB2080", Offset = "0x4CB0C80", VA = "0x184CB2080")]
		public static string ToString(System.DateTime value, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static string ToString(string value)
		{
			return null;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x000062E8 File Offset: 0x000044E8
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x4CAED70", Offset = "0x4CAD970", VA = "0x184CAED70")]
		public static byte ToByte(string value, int fromBase)
		{
			return 0;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00006300 File Offset: 0x00004500
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x4CB1560", Offset = "0x4CB0160", VA = "0x184CB1560")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(string value, int fromBase)
		{
			return 0;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00006318 File Offset: 0x00004518
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x4CB0320", Offset = "0x4CAEF20", VA = "0x184CB0320")]
		public static short ToInt16(string value, int fromBase)
		{
			return 0;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00006330 File Offset: 0x00004530
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x4CB23B0", Offset = "0x4CB0FB0", VA = "0x184CB23B0")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(string value, int fromBase)
		{
			return 0;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00006348 File Offset: 0x00004548
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x4CB0C60", Offset = "0x4CAF860", VA = "0x184CB0C60")]
		public static int ToInt32(string value, int fromBase)
		{
			return 0;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00006360 File Offset: 0x00004560
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x4CB2B90", Offset = "0x4CB1790", VA = "0x184CB2B90")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(string value, int fromBase)
		{
			return 0U;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00006378 File Offset: 0x00004578
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x4CB0D50", Offset = "0x4CAF950", VA = "0x184CB0D50")]
		public static long ToInt64(string value, int fromBase)
		{
			return 0L;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00006390 File Offset: 0x00004590
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x4CB3460", Offset = "0x4CB2060", VA = "0x184CB3460")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(string value, int fromBase)
		{
			return 0UL;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x4CB1DA0", Offset = "0x4CB09A0", VA = "0x184CB1DA0")]
		public static string ToString(byte value, int toBase)
		{
			return null;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x4CB2130", Offset = "0x4CB0D30", VA = "0x184CB2130")]
		public static string ToString(int value, int toBase)
		{
			return null;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x4CB2240", Offset = "0x4CB0E40", VA = "0x184CB2240")]
		public static string ToString(long value, int toBase)
		{
			return null;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x4CAE380", Offset = "0x4CACF80", VA = "0x184CAE380")]
		public static string ToBase64String(byte[] inArray)
		{
			return null;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x4CAE460", Offset = "0x4CAD060", VA = "0x184CAE460")]
		public static string ToBase64String(byte[] inArray, int offset, int length)
		{
			return null;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x4CADF40", Offset = "0x4CACB40", VA = "0x184CADF40")]
		public static string ToBase64String(byte[] inArray, int offset, int length, System.Base64FormattingOptions options)
		{
			return null;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x4CAE1A0", Offset = "0x4CACDA0", VA = "0x184CAE1A0")]
		public static string ToBase64String(System.ReadOnlySpan<byte> bytes, System.Base64FormattingOptions options = System.Base64FormattingOptions.None)
		{
			return null;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000063A8 File Offset: 0x000045A8
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x4CADA30", Offset = "0x4CAC630", VA = "0x184CADA30")]
		public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut)
		{
			return 0;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000063C0 File Offset: 0x000045C0
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x4CADAC0", Offset = "0x4CAC6C0", VA = "0x184CADAC0")]
		public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, System.Base64FormattingOptions options)
		{
			return 0;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000063D8 File Offset: 0x000045D8
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x4CAC150", Offset = "0x4CAAD50", VA = "0x184CAC150")]
		private unsafe static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks)
		{
			return 0;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000063F0 File Offset: 0x000045F0
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x4CAE4E0", Offset = "0x4CAD0E0", VA = "0x184CAE4E0")]
		private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks)
		{
			return 0;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x4CAD4A0", Offset = "0x4CAC0A0", VA = "0x184CAD4A0")]
		public static byte[] FromBase64String(string s)
		{
			return null;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00006408 File Offset: 0x00004608
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x4CB3900", Offset = "0x4CB2500", VA = "0x184CB3900")]
		public static bool TryFromBase64Chars(System.ReadOnlySpan<char> chars, System.Span<byte> bytes, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x4CAC3F0", Offset = "0x4CAAFF0", VA = "0x184CAC3F0")]
		private static void CopyToTempBufferWithoutWhiteSpace(System.ReadOnlySpan<char> chars, System.Span<char> tempBuffer, out int consumed, out int charsWritten)
		{
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00006420 File Offset: 0x00004620
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x4CAD6A0", Offset = "0x4CAC2A0", VA = "0x184CAD6A0")]
		[MethodImpl(256)]
		private static bool IsSpace(this char c)
		{
			return default(bool);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x4CACFC0", Offset = "0x4CABBC0", VA = "0x184CACFC0")]
		public static byte[] FromBase64CharArray(char[] inArray, int offset, int length)
		{
			return null;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x4CAD250", Offset = "0x4CABE50", VA = "0x184CAD250")]
		private unsafe static byte[] FromBase64CharPtr(char* inputPtr, int inputLength)
		{
			return null;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00006438 File Offset: 0x00004638
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x4CAD560", Offset = "0x4CAC160", VA = "0x184CAD560")]
		private unsafe static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength)
		{
			return 0;
		}

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly sbyte[] s_decodingMap;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly System.Type[] ConvertTypes;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x10")]
		private static readonly System.Type EnumType;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly char[] base64Table;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x20")]
		public static readonly object DBNull;
	}
}
