using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandlerRaw.h")]
	[StructLayout(0)]
	public sealed class UploadHandlerRaw : UploadHandler
	{
		// Token: 0x0600008D RID: 141
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x5B9B880", Offset = "0x5B9A480", VA = "0x185B9B880")]
		[MethodImpl(4096)]
		private unsafe static extern IntPtr Create(UploadHandlerRaw self, byte* data, int dataLength);

		// Token: 0x0600008E RID: 142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x5B9B9B0", Offset = "0x5B9A5B0", VA = "0x185B9B9B0")]
		public UploadHandlerRaw(byte[] data)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x5B9BB10", Offset = "0x5B9A710", VA = "0x185B9BB10")]
		public UploadHandlerRaw(NativeArray<byte> data, bool transferOwnership)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x5B9B8E0", Offset = "0x5B9A4E0", VA = "0x185B9B8E0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private NativeArray<byte> m_Payload;
	}
}
