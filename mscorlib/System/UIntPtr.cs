using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001D3 RID: 467
	[Token(Token = "0x20001D3")]
	[System.CLSCompliant(false)]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public readonly struct UIntPtr : System.Runtime.Serialization.ISerializable, System.IEquatable<System.UIntPtr>
	{
		// Token: 0x060010D1 RID: 4305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D1")]
		[Address(RVA = "0x4D5FE60", Offset = "0x4D5EA60", VA = "0x184D5FE60")]
		public UIntPtr(ulong value)
		{
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D2")]
		[Address(RVA = "0x4D5FE50", Offset = "0x4D5EA50", VA = "0x184D5FE50")]
		public UIntPtr(uint value)
		{
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D3")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		[System.CLSCompliant(false)]
		public unsafe UIntPtr(void* value)
		{
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0000D938 File Offset: 0x0000BB38
		[Token(Token = "0x60010D4")]
		[Address(RVA = "0x4D5FCB0", Offset = "0x4D5E8B0", VA = "0x184D5FCB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0000D950 File Offset: 0x0000BB50
		[Token(Token = "0x60010D5")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010D6")]
		[Address(RVA = "0x4D5FDF0", Offset = "0x4D5E9F0", VA = "0x184D5FDF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D7")]
		[Address(RVA = "0x4D5FD40", Offset = "0x4D5E940", VA = "0x184D5FD40", Slot = "4")]
		private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0000D968 File Offset: 0x0000BB68
		[Token(Token = "0x60010D8")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(System.UIntPtr value1, System.UIntPtr value2)
		{
			return default(bool);
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0000D980 File Offset: 0x0000BB80
		[Token(Token = "0x60010D9")]
		[Address(RVA = "0x4D00430", Offset = "0x4CFF030", VA = "0x184D00430")]
		public static bool operator !=(System.UIntPtr value1, System.UIntPtr value2)
		{
			return default(bool);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0000D998 File Offset: 0x0000BB98
		[Token(Token = "0x60010DA")]
		[Address(RVA = "0x4D5FEC0", Offset = "0x4D5EAC0", VA = "0x184D5FEC0")]
		public static explicit operator System.UIntPtr(ulong value)
		{
			return 0;
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
		[Token(Token = "0x60010DB")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator System.UIntPtr(uint value)
		{
			return 0;
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		[Token(Token = "0x17000185")]
		public static int Size
		{
			[Token(Token = "0x60010DC")]
			[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "5")]
		private bool Equals(System.UIntPtr other)
		{
			return default(bool);
		}

		// Token: 0x0400097E RID: 2430
		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly System.UIntPtr Zero;

		// Token: 0x0400097F RID: 2431
		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private unsafe readonly void* _pointer;
	}
}
