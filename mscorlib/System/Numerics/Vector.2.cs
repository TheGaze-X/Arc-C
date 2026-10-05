using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Numerics
{
	// Token: 0x02000557 RID: 1367
	[Token(Token = "0x2000557")]
	[Intrinsic]
	public static class Vector
	{
		// Token: 0x0600283D RID: 10301 RVA: 0x00016008 File Offset: 0x00014208
		[Token(Token = "0x600283D")]
		[MethodImpl(256)]
		public static Vector<T> Equals<T>(Vector<T> left, Vector<T> right) where T : struct
		{
			return default(Vector<T>);
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600283E RID: 10302 RVA: 0x00016020 File Offset: 0x00014220
		[Token(Token = "0x170005CE")]
		public static bool IsHardwareAccelerated
		{
			[Token(Token = "0x600283E")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			[Intrinsic]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x00016038 File Offset: 0x00014238
		[Token(Token = "0x600283F")]
		[System.CLSCompliant(false)]
		[MethodImpl(256)]
		public static Vector<ulong> AsVectorUInt64<T>(Vector<T> value) where T : struct
		{
			return default(Vector<ulong>);
		}
	}
}
