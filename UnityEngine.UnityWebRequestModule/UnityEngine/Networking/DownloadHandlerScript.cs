using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerScript.h")]
	[StructLayout(0)]
	public class DownloadHandlerScript : DownloadHandler
	{
		// Token: 0x06000083 RID: 131
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x5B98670", Offset = "0x5B97270", VA = "0x185B98670")]
		[MethodImpl(4096)]
		private static extern IntPtr CreatePreallocated(DownloadHandlerScript obj, [Unmarshalled] byte[] preallocatedBuffer);

		// Token: 0x06000084 RID: 132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x5B986C0", Offset = "0x5B972C0", VA = "0x185B986C0")]
		private void InternalCreateScript(byte[] preallocatedBuffer)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x5B98710", Offset = "0x5B97310", VA = "0x185B98710")]
		public DownloadHandlerScript(byte[] preallocatedBuffer)
		{
		}
	}
}
