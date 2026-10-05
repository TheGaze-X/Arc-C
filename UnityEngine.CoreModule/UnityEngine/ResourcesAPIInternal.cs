using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
	[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
	internal static class ResourcesAPIInternal
	{
		// Token: 0x060008D1 RID: 2257
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x5952430", Offset = "0x5951030", VA = "0x185952430")]
		[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
		[FreeFunction("Resources_Bindings::FindObjectsOfTypeAll")]
		[MethodImpl(4096)]
		public static extern Object[] FindObjectsOfTypeAll(Type type);

		// Token: 0x060008D2 RID: 2258
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x5952470", Offset = "0x5951070", VA = "0x185952470")]
		[FreeFunction("GetShaderNameRegistry().FindShader")]
		[MethodImpl(4096)]
		public static extern Shader FindShaderByName(string name);

		// Token: 0x060008D3 RID: 2259
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x5952550", Offset = "0x5951150", VA = "0x185952550")]
		[FreeFunction("Resources_Bindings::Load")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		[NativeThrows]
		[MethodImpl(4096)]
		public static extern Object Load(string path, [NotNull("ArgumentNullException")] Type systemTypeInstance);

		// Token: 0x060008D4 RID: 2260
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x59524B0", Offset = "0x59510B0", VA = "0x1859524B0")]
		[NativeThrows]
		[FreeFunction("Resources_Bindings::LoadAll")]
		[MethodImpl(4096)]
		public static extern Object[] LoadAll([NotNull("ArgumentNullException")] string path, [NotNull("ArgumentNullException")] Type systemTypeInstance);

		// Token: 0x060008D5 RID: 2261
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x5952500", Offset = "0x5951100", VA = "0x185952500")]
		[FreeFunction("Resources_Bindings::LoadAsyncInternal")]
		[MethodImpl(4096)]
		internal static extern ResourceRequest LoadAsyncInternal(string path, Type type);

		// Token: 0x060008D6 RID: 2262
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x59525A0", Offset = "0x59511A0", VA = "0x1859525A0")]
		[FreeFunction("Scripting::UnloadAssetFromScripting")]
		[MethodImpl(4096)]
		public static extern void UnloadAsset(Object assetToUnload);
	}
}
