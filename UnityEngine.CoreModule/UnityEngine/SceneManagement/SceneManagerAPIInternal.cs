using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement
{
	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
	internal static class SceneManagerAPIInternal
	{
		// Token: 0x06000D07 RID: 3335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D07")]
		[Address(RVA = "0x596AD20", Offset = "0x5969920", VA = "0x18596AD20")]
		[NativeThrows]
		public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			return null;
		}

		// Token: 0x06000D08 RID: 3336
		[Token(Token = "0x6000D08")]
		[Address(RVA = "0x596AD80", Offset = "0x5969980", VA = "0x18596AD80")]
		[NativeThrows]
		[MethodImpl(4096)]
		public static extern AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess);

		// Token: 0x06000D09 RID: 3337
		[Token(Token = "0x6000D09")]
		[Address(RVA = "0x596ACB0", Offset = "0x59698B0", VA = "0x18596ACB0")]
		[MethodImpl(4096)]
		private static extern AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame);
	}
}
