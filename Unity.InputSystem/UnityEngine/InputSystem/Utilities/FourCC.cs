using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000236 RID: 566
	[Token(Token = "0x2000236")]
	public struct FourCC : IEquatable<FourCC>
	{
		// Token: 0x06001481 RID: 5249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001481")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public FourCC(int code)
		{
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x55FD0B0", Offset = "0x55FBCB0", VA = "0x1855FD0B0")]
		public FourCC(char a, char b = ' ', char c = ' ', char d = ' ')
		{
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001483")]
		[Address(RVA = "0x55FCF10", Offset = "0x55FBB10", VA = "0x1855FCF10")]
		public FourCC(string str)
		{
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x0000AB78 File Offset: 0x00008D78
		[Token(Token = "0x6001484")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		[MethodImpl(256)]
		public static implicit operator int(FourCC fourCC)
		{
			return 0;
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0000AB90 File Offset: 0x00008D90
		[Token(Token = "0x6001485")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		[MethodImpl(256)]
		public static implicit operator FourCC(int i)
		{
			return default(FourCC);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001486")]
		[Address(RVA = "0x55FCCF0", Offset = "0x55FB8F0", VA = "0x1855FCCF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		[Token(Token = "0x6001487")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(FourCC other)
		{
			return default(bool);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		[Token(Token = "0x6001488")]
		[Address(RVA = "0x55FCC70", Offset = "0x55FB870", VA = "0x1855FCC70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		[Token(Token = "0x6001489")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		[Token(Token = "0x600148A")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		[MethodImpl(256)]
		public static bool operator ==(FourCC left, FourCC right)
		{
			return default(bool);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x0000AC08 File Offset: 0x00008E08
		[Token(Token = "0x600148B")]
		[Address(RVA = "0x263CB30", Offset = "0x263B730", VA = "0x18263CB30")]
		[MethodImpl(256)]
		public static bool operator !=(FourCC left, FourCC right)
		{
			return default(bool);
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x0000AC20 File Offset: 0x00008E20
		[Token(Token = "0x600148C")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		[MethodImpl(256)]
		public static FourCC FromInt32(int i)
		{
			return default(FourCC);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0000AC38 File Offset: 0x00008E38
		[Token(Token = "0x600148D")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		[MethodImpl(256)]
		public static int ToInt32(FourCC fourCC)
		{
			return 0;
		}

		// Token: 0x04000C01 RID: 3073
		[Token(Token = "0x4000C01")]
		[FieldOffset(Offset = "0x0")]
		private int m_Code;
	}
}
