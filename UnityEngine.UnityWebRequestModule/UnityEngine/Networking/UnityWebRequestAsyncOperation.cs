using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[UsedByNativeCode]
	[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
	[NativeHeader("UnityWebRequestScriptingClasses.h")]
	[StructLayout(0)]
	public class UnityWebRequestAsyncOperation : AsyncOperation
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000004")]
		public UnityWebRequest webRequest
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x286AC00", Offset = "0x2869800", VA = "0x18286AC00")]
		public UnityWebRequestAsyncOperation()
		{
		}
	}
}
