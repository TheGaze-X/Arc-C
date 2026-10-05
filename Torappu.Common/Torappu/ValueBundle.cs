using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	public struct ValueBundle : ILuaCallCSharp
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x55122B0", Offset = "0x5510EB0", VA = "0x1855122B0")]
		public ValueBundle(object value)
		{
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000058AC File Offset: 0x00003AAC
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x55123A0", Offset = "0x5510FA0", VA = "0x1855123A0")]
		public static implicit operator ValueBundle(bool value)
		{
			return default(ValueBundle);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x000058C4 File Offset: 0x00003AC4
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x11F7680", Offset = "0x11F6280", VA = "0x1811F7680")]
		public static implicit operator bool(ValueBundle val)
		{
			return default(bool);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x000058DC File Offset: 0x00003ADC
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x55123C0", Offset = "0x5510FC0", VA = "0x1855123C0")]
		public static implicit operator ValueBundle(long val)
		{
			return default(ValueBundle);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000058F4 File Offset: 0x00003AF4
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
		public static implicit operator long(ValueBundle val)
		{
			return 0L;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0000590C File Offset: 0x00003B0C
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x55123E0", Offset = "0x5510FE0", VA = "0x1855123E0")]
		public static implicit operator ValueBundle(double val)
		{
			return default(ValueBundle);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00005924 File Offset: 0x00003B24
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x4007440", Offset = "0x4006040", VA = "0x184007440")]
		public static implicit operator double(ValueBundle val)
		{
			return 0.0;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000593C File Offset: 0x00003B3C
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x5512370", Offset = "0x5510F70", VA = "0x185512370")]
		public static implicit operator ValueBundle(string val)
		{
			return default(ValueBundle);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
		public static implicit operator string(ValueBundle val)
		{
			return null;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00005954 File Offset: 0x00003B54
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x5512030", Offset = "0x5510C30", VA = "0x185512030")]
		public bool Equals(ValueBundle other)
		{
			return default(bool);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0000596C File Offset: 0x00003B6C
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x55120A0", Offset = "0x5510CA0", VA = "0x1855120A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00005984 File Offset: 0x00003B84
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x5512180", Offset = "0x5510D80", VA = "0x185512180", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0000599C File Offset: 0x00003B9C
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x55122F0", Offset = "0x5510EF0", VA = "0x1855122F0")]
		public static bool operator ==(ValueBundle a, ValueBundle b)
		{
			return default(bool);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x000059B4 File Offset: 0x00003BB4
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x5512400", Offset = "0x5511000", VA = "0x185512400")]
		public static bool operator !=(ValueBundle a, ValueBundle b)
		{
			return default(bool);
		}

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ValueBundle EMPTY;

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0x0")]
		public long intVal;

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x8")]
		public double floatVal;

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x10")]
		public string strVal;

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x18")]
		public object objVal;
	}
}
