using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000EE")]
	[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
	[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
	public sealed class Resources
	{
		// Token: 0x060008E1 RID: 2273 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008E1")]
		internal static T[] ConvertObjects<T>(Object[] rawObjects) where T : Object
		{
			return null;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x5952940", Offset = "0x5951540", VA = "0x185952940")]
		public static Object[] FindObjectsOfTypeAll(Type type)
		{
			return null;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008E3")]
		public static T[] FindObjectsOfTypeAll<T>() where T : Object
		{
			return null;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x5953020", Offset = "0x5951C20", VA = "0x185953020")]
		public static Object Load(string path)
		{
			return null;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008E5")]
		public static T Load<T>(string path) where T : Object
		{
			return null;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x5952F80", Offset = "0x5951B80", VA = "0x185952F80")]
		public static Object Load(string path, Type systemTypeInstance)
		{
			return null;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x5952E90", Offset = "0x5951A90", VA = "0x185952E90")]
		public static ResourceRequest LoadAsync(string path)
		{
			return null;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008E8")]
		public static ResourceRequest LoadAsync<T>(string path) where T : Object
		{
			return null;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x5952DF0", Offset = "0x59519F0", VA = "0x185952DF0")]
		public static ResourceRequest LoadAsync(string path, Type type)
		{
			return null;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x5952D50", Offset = "0x5951950", VA = "0x185952D50")]
		public static Object[] LoadAll(string path, Type systemTypeInstance)
		{
			return null;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x5952C60", Offset = "0x5951860", VA = "0x185952C60")]
		public static Object[] LoadAll(string path)
		{
			return null;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008EC")]
		public static T[] LoadAll<T>(string path) where T : Object
		{
			return null;
		}

		// Token: 0x060008ED RID: 2285
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x59529D0", Offset = "0x59515D0", VA = "0x1859529D0")]
		[FreeFunction("GetScriptingBuiltinResource", ThrowsException = true)]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[MethodImpl(4096)]
		public static extern Object GetBuiltinResource([NotNull("ArgumentNullException")] Type type, string path);

		// Token: 0x060008EE RID: 2286 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008EE")]
		public static T GetBuiltinResource<T>(string path) where T : Object
		{
			return null;
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x59530E0", Offset = "0x5951CE0", VA = "0x1859530E0")]
		public static void UnloadAsset(Object assetToUnload)
		{
		}

		// Token: 0x060008F0 RID: 2288
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x59530A0", Offset = "0x5951CA0", VA = "0x1859530A0")]
		[FreeFunction("Scripting::UnloadAssetFromScripting")]
		[MethodImpl(4096)]
		private static extern void UnloadAssetImplResourceManager(Object assetToUnload);

		// Token: 0x060008F1 RID: 2289
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x5953170", Offset = "0x5951D70", VA = "0x185953170")]
		[FreeFunction("Resources_Bindings::UnloadUnusedAssets")]
		[MethodImpl(4096)]
		public static extern AsyncOperation UnloadUnusedAssets();

		// Token: 0x060008F2 RID: 2290
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x5952C20", Offset = "0x5951820", VA = "0x185952C20")]
		[FreeFunction("Resources_Bindings::InstanceIDToObject")]
		[MethodImpl(4096)]
		public static extern Object InstanceIDToObject(int instanceID);

		// Token: 0x060008F3 RID: 2291
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x5952BD0", Offset = "0x59517D0", VA = "0x185952BD0")]
		[FreeFunction("Resources_Bindings::InstanceIDToObjectList")]
		[MethodImpl(4096)]
		private static extern void InstanceIDToObjectList(IntPtr instanceIDs, int instanceCount, List<Object> objects);

		// Token: 0x060008F4 RID: 2292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x5952A20", Offset = "0x5951620", VA = "0x185952A20")]
		public static void InstanceIDToObjectList(NativeArray<int> instanceIDs, List<Object> objects)
		{
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Resources()
		{
		}
	}
}
