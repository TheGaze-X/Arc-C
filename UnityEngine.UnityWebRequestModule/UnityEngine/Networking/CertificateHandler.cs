using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
	[StructLayout(0)]
	public class CertificateHandler
	{
		// Token: 0x06000062 RID: 98
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x5B98350", Offset = "0x5B96F50", VA = "0x185B98350")]
		[NativeMethod(IsThreadSafe = true)]
		[MethodImpl(4096)]
		private extern void Release();

		// Token: 0x06000063 RID: 99 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x591F3A0", Offset = "0x591DFA0", VA = "0x18591F3A0", Slot = "4")]
		protected virtual bool ValidateCertificate(byte[] certificateData)
		{
			return default(bool);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x5B98390", Offset = "0x5B96F90", VA = "0x185B98390")]
		[RequiredByNativeCode]
		internal bool ValidateCertificateNative(byte[] certificateData)
		{
			return default(bool);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x5B982C0", Offset = "0x5B96EC0", VA = "0x185B982C0", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		internal IntPtr m_Ptr;
	}
}
