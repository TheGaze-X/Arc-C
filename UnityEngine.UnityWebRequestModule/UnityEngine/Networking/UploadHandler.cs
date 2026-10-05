using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
	[StructLayout(0)]
	public class UploadHandler : IDisposable
	{
		// Token: 0x06000086 RID: 134
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x5B9BCE0", Offset = "0x5B9A8E0", VA = "0x185B9BCE0")]
		[NativeMethod(IsThreadSafe = true)]
		[MethodImpl(4096)]
		private extern void Release();

		// Token: 0x06000087 RID: 135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal UploadHandler()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x36C1240", Offset = "0x36BFE40", VA = "0x1836C1240", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x5B9BC00", Offset = "0x5B9A800", VA = "0x185B9BC00", Slot = "5")]
		public virtual void Dispose()
		{
		}

		// Token: 0x17000019 RID: 25
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000019")]
		public string contentType
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x5B9BD20", Offset = "0x5B9A920", VA = "0x185B9BD20")]
			set
			{
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x5B9BC90", Offset = "0x5B9A890", VA = "0x185B9BC90", Slot = "6")]
		internal virtual void SetContentType(string newContentType)
		{
		}

		// Token: 0x0600008C RID: 140
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x5B9BC90", Offset = "0x5B9A890", VA = "0x185B9BC90")]
		[NativeMethod("SetContentType")]
		[MethodImpl(4096)]
		private extern void InternalSetContentType(string newContentType);

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		internal IntPtr m_Ptr;
	}
}
