using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020001A0 RID: 416
	[Token(Token = "0x20001A0")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
	public class SceneManager
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000D11 RID: 3345
		[Token(Token = "0x170002A4")]
		public static extern int sceneCount { [Token(Token = "0x6000D11")] [Address(RVA = "0x596BF30", Offset = "0x596AB30", VA = "0x18596BF30")] [NativeMethod("GetSceneCount")] [NativeHeader("Runtime/SceneManager/SceneManager.h")] [StaticAccessor("GetSceneManager()", StaticAccessorType.Dot)] [MethodImpl(4096)] get; }

		// Token: 0x06000D12 RID: 3346 RVA: 0x00006B58 File Offset: 0x00004D58
		[Token(Token = "0x6000D12")]
		[Address(RVA = "0x596B080", Offset = "0x5969C80", VA = "0x18596B080")]
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		public static Scene GetActiveScene()
		{
			return default(Scene);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00006B70 File Offset: 0x00004D70
		[Token(Token = "0x6000D13")]
		[Address(RVA = "0x596B130", Offset = "0x5969D30", VA = "0x18596B130")]
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		[NativeThrows]
		public static Scene GetSceneAt(int index)
		{
			return default(Scene);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D14")]
		[Address(RVA = "0x596B420", Offset = "0x596A020", VA = "0x18596B420")]
		private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			return null;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D15")]
		[Address(RVA = "0x596BAB0", Offset = "0x596A6B0", VA = "0x18596BAB0")]
		private static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			return null;
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x596B390", Offset = "0x5969F90", VA = "0x18596B390")]
		[RequiredByNativeCode]
		internal static AsyncOperation LoadFirstScene_Internal(bool async)
		{
			return null;
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000D17 RID: 3351 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000D18 RID: 3352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000011")]
		public static event UnityAction<Scene, LoadSceneMode> sceneLoaded
		{
			[Token(Token = "0x6000D17")]
			[Address(RVA = "0x596BD10", Offset = "0x596A910", VA = "0x18596BD10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000D18")]
			[Address(RVA = "0x596C070", Offset = "0x596AC70", VA = "0x18596C070")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000D19 RID: 3353 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000D1A RID: 3354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000012")]
		public static event UnityAction<Scene> sceneUnloaded
		{
			[Token(Token = "0x6000D19")]
			[Address(RVA = "0x596BE20", Offset = "0x596AA20", VA = "0x18596BE20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000D1A")]
			[Address(RVA = "0x596C180", Offset = "0x596AD80", VA = "0x18596C180")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000D1B RID: 3355 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000D1C RID: 3356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000013")]
		public static event UnityAction<Scene, Scene> activeSceneChanged
		{
			[Token(Token = "0x6000D1B")]
			[Address(RVA = "0x596BC00", Offset = "0x596A800", VA = "0x18596BC00")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000D1C")]
			[Address(RVA = "0x596BF60", Offset = "0x596AB60", VA = "0x18596BF60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0x596B790", Offset = "0x596A390", VA = "0x18596B790")]
		public static void LoadScene(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
		{
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D1E")]
		[Address(RVA = "0x596B930", Offset = "0x596A530", VA = "0x18596B930")]
		[ExcludeFromDocs]
		public static void LoadScene(string sceneName)
		{
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00006B88 File Offset: 0x00004D88
		[Token(Token = "0x6000D1F")]
		[Address(RVA = "0x596B890", Offset = "0x596A490", VA = "0x18596B890")]
		public static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
		{
			return default(Scene);
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D20")]
		[Address(RVA = "0x596B6D0", Offset = "0x596A2D0", VA = "0x18596B6D0")]
		[ExcludeFromDocs]
		public static void LoadScene(int sceneBuildIndex)
		{
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00006BA0 File Offset: 0x00004DA0
		[Token(Token = "0x6000D21")]
		[Address(RVA = "0x596B800", Offset = "0x596A400", VA = "0x18596B800")]
		public static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters)
		{
			return default(Scene);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x596B520", Offset = "0x596A120", VA = "0x18596B520")]
		public static AsyncOperation LoadSceneAsync(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
		{
			return null;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x596B5C0", Offset = "0x596A1C0", VA = "0x18596B5C0")]
		[ExcludeFromDocs]
		public static AsyncOperation LoadSceneAsync(string sceneName)
		{
			return null;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x596B660", Offset = "0x596A260", VA = "0x18596B660")]
		public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters)
		{
			return null;
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x596B990", Offset = "0x596A590", VA = "0x18596B990")]
		public static AsyncOperation UnloadSceneAsync(string sceneName)
		{
			return null;
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x596B250", Offset = "0x5969E50", VA = "0x18596B250")]
		[RequiredByNativeCode]
		private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x596B2F0", Offset = "0x5969EF0", VA = "0x18596B2F0")]
		[RequiredByNativeCode]
		private static void Internal_SceneUnloaded(Scene scene)
		{
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x596B1B0", Offset = "0x5969DB0", VA = "0x18596B1B0")]
		[RequiredByNativeCode]
		private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
		{
		}

		// Token: 0x06000D2A RID: 3370
		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0x596B040", Offset = "0x5969C40", VA = "0x18596B040")]
		[MethodImpl(4096)]
		private static extern void GetActiveScene_Injected(out Scene ret);

		// Token: 0x06000D2B RID: 3371
		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0x596B0F0", Offset = "0x5969CF0", VA = "0x18596B0F0")]
		[MethodImpl(4096)]
		private static extern void GetSceneAt_Injected(int index, out Scene ret);

		// Token: 0x040005E5 RID: 1509
		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x0")]
		internal static bool s_AllowLoadScene;
	}
}
