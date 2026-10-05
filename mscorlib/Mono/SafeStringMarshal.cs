using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Mono
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	internal struct SafeStringMarshal : System.IDisposable
	{
		// Token: 0x0600007F RID: 127
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x4AB1A20", Offset = "0x4AB0620", VA = "0x184AB1A20")]
		[MethodImpl(4096)]
		private static extern System.IntPtr StringToUtf8_icall(ref string str);

		// Token: 0x06000080 RID: 128 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x4AB1A30", Offset = "0x4AB0630", VA = "0x184AB1A30")]
		public static System.IntPtr StringToUtf8(string str)
		{
			return 0;
		}

		// Token: 0x06000081 RID: 129
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x4AB1A10", Offset = "0x4AB0610", VA = "0x184AB1A10")]
		[MethodImpl(4096)]
		public static extern void GFree(System.IntPtr ptr);

		// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x4AB1A50", Offset = "0x4AB0650", VA = "0x184AB1A50")]
		public SafeStringMarshal(string str)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x1700000F")]
		public System.IntPtr Value
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x4AB1AB0", Offset = "0x4AB06B0", VA = "0x184AB1AB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x4AB19A0", Offset = "0x4AB05A0", VA = "0x184AB19A0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x0")]
		private readonly string str;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x8")]
		private System.IntPtr marshaled_string;
	}
}
