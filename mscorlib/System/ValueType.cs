using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001D4 RID: 468
	[Token(Token = "0x20001D4")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public abstract class ValueType
	{
		// Token: 0x060010DF RID: 4319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ValueType()
		{
		}

		// Token: 0x060010E0 RID: 4320
		[Token(Token = "0x60010E0")]
		[Address(RVA = "0x4D60250", Offset = "0x4D5EE50", VA = "0x184D60250")]
		[MethodImpl(4096)]
		private static extern bool InternalEquals(object o1, object o2, out object[] fields);

		// Token: 0x060010E1 RID: 4321 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		[Token(Token = "0x60010E1")]
		[Address(RVA = "0x4D5FF10", Offset = "0x4D5EB10", VA = "0x184D5FF10")]
		internal static bool DefaultEquals(object o1, object o2)
		{
			return default(bool);
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0000DA10 File Offset: 0x0000BC10
		[Token(Token = "0x60010E2")]
		[Address(RVA = "0x4D60070", Offset = "0x4D5EC70", VA = "0x184D60070", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060010E3 RID: 4323
		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x4D60260", Offset = "0x4D5EE60", VA = "0x184D60260")]
		[MethodImpl(4096)]
		internal static extern int InternalGetHashCode(object o, out object[] fields);

		// Token: 0x060010E4 RID: 4324 RVA: 0x0000DA28 File Offset: 0x0000BC28
		[Token(Token = "0x60010E4")]
		[Address(RVA = "0x4D601D0", Offset = "0x4D5EDD0", VA = "0x184D601D0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010E5")]
		[Address(RVA = "0x4D60270", Offset = "0x4D5EE70", VA = "0x184D60270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
