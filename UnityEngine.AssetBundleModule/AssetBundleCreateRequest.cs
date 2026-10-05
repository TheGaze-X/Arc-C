using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromAsyncOperation.h")]
	[StructLayout(0)]
	public class AssetBundleCreateRequest : AsyncOperation
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000018 RID: 24
		[Token(Token = "0x17000002")]
		public extern AssetBundle assetBundle { [Token(Token = "0x6000018")] [Address(RVA = "0x5919C00", Offset = "0x5918800", VA = "0x185919C00")] [NativeMethod("GetAssetBundleBlocking")] [MethodImpl(4096)] get; }

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x286AC00", Offset = "0x2869800", VA = "0x18286AC00")]
		public AssetBundleCreateRequest()
		{
		}
	}
}
