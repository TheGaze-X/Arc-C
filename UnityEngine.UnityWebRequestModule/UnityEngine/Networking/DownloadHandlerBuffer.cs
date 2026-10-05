using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerBuffer.h")]
	[StructLayout(0)]
	public sealed class DownloadHandlerBuffer : DownloadHandler
	{
		// Token: 0x0600007E RID: 126
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x5B983E0", Offset = "0x5B96FE0", VA = "0x185B983E0")]
		[MethodImpl(4096)]
		private static extern IntPtr Create(DownloadHandlerBuffer obj);

		// Token: 0x0600007F RID: 127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x5B985F0", Offset = "0x5B971F0", VA = "0x185B985F0")]
		private void InternalCreateBuffer()
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x5B98630", Offset = "0x5B97230", VA = "0x185B98630")]
		public DownloadHandlerBuffer()
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x5B984D0", Offset = "0x5B970D0", VA = "0x185B984D0", Slot = "6")]
		protected override NativeArray<byte> GetNativeData()
		{
			return default(NativeArray<byte>);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x5B98420", Offset = "0x5B97020", VA = "0x185B98420", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private NativeArray<byte> m_NativeData;
	}
}
