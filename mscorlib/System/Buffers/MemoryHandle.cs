using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Buffers
{
	// Token: 0x02000639 RID: 1593
	[Token(Token = "0x2000639")]
	public struct MemoryHandle : System.IDisposable
	{
		// Token: 0x06002FDD RID: 12253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FDD")]
		[Address(RVA = "0x4C68830", Offset = "0x4C67430", VA = "0x184C68830")]
		[System.CLSCompliant(false)]
		public unsafe MemoryHandle(void* pointer, [System.Runtime.InteropServices.Optional] System.Runtime.InteropServices.GCHandle handle, [System.Runtime.InteropServices.Optional] IPinnable pinnable)
		{
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06002FDE RID: 12254 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007BC")]
		[System.CLSCompliant(false)]
		public unsafe void* Pointer
		{
			[Token(Token = "0x6002FDE")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FDF")]
		[Address(RVA = "0x4C68790", Offset = "0x4C67390", VA = "0x184C68790", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04001A8C RID: 6796
		[Token(Token = "0x4001A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private unsafe void* _pointer;

		// Token: 0x04001A8D RID: 6797
		[Token(Token = "0x4001A8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private System.Runtime.InteropServices.GCHandle _handle;

		// Token: 0x04001A8E RID: 6798
		[Token(Token = "0x4001A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IPinnable _pinnable;
	}
}
