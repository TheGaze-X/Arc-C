using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
	[StructLayout(0)]
	public class AssetBundleRequest : ResourceRequest
	{
		// Token: 0x0600001A RID: 26
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x5919C40", Offset = "0x5918840", VA = "0x185919C40", Slot = "4")]
		[NativeMethod("GetLoadedAsset")]
		[MethodImpl(4096)]
		protected override extern Object GetResult();

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000003")]
		public new Object asset
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x5919C80", Offset = "0x5918880", VA = "0x185919C80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x286AC00", Offset = "0x2869800", VA = "0x18286AC00")]
		public AssetBundleRequest()
		{
		}
	}
}
