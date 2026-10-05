using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[ExcludeFromPreset]
	[NativeHeader("Runtime/Scripting/ScriptingExportUtility.h")]
	[NativeHeader("Runtime/Scripting/ScriptingObjectWithIntPtrField.h")]
	[NativeHeader("Runtime/Scripting/ScriptingUtility.h")]
	[NativeHeader("AssetBundleScriptingClasses.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleSaveAndLoadHelper.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleUtility.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetUtility.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromManagedStreamAsyncOperation.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromFileAsyncOperation.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromMemoryAsyncOperation.h")]
	public class AssetBundle : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x591AA40", Offset = "0x5919640", VA = "0x18591AA40")]
		private AssetBundle()
		{
		}

		// Token: 0x06000002 RID: 2
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x591A8E0", Offset = "0x59194E0", VA = "0x18591A8E0")]
		[FreeFunction("LoadFromFile")]
		[MethodImpl(4096)]
		internal static extern AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset);

		// Token: 0x06000003 RID: 3 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x591A930", Offset = "0x5919530", VA = "0x18591A930")]
		public static AssetBundle LoadFromFile(string path)
		{
			return null;
		}

		// Token: 0x06000004 RID: 4
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x591A970", Offset = "0x5919570", VA = "0x18591A970")]
		[FreeFunction("LoadFromMemoryAsync")]
		[MethodImpl(4096)]
		internal static extern AssetBundleCreateRequest LoadFromMemoryAsync_Internal(byte[] binary, uint crc);

		// Token: 0x06000005 RID: 5 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x591A9B0", Offset = "0x59195B0", VA = "0x18591A9B0")]
		public static AssetBundleCreateRequest LoadFromMemoryAsync(byte[] binary)
		{
			return null;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6
		[Token(Token = "0x17000001")]
		public extern bool isStreamedSceneAssetBundle { [Token(Token = "0x6000006")] [Address(RVA = "0x591AA90", Offset = "0x5919690", VA = "0x18591AA90")] [NativeMethod("GetIsStreamedSceneAssetBundle")] [MethodImpl(4096)] get; }

		// Token: 0x06000007 RID: 7 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x591A730", Offset = "0x5919330", VA = "0x18591A730")]
		public Object LoadAsset(string name)
		{
			return null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000008")]
		public T LoadAsset<T>(string name) where T : Object
		{
			return null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x591A5D0", Offset = "0x59191D0", VA = "0x18591A5D0")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		public Object LoadAsset(string name, Type type)
		{
			return null;
		}

		// Token: 0x0600000A RID: 10
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x591A570", Offset = "0x5919170", VA = "0x18591A570")]
		[NativeMethod("LoadAsset_Internal")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		[NativeThrows]
		[MethodImpl(4096)]
		private extern Object LoadAsset_Internal(string name, Type type);

		// Token: 0x0600000B RID: 11 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x5919F50", Offset = "0x5918B50", VA = "0x185919F50")]
		public AssetBundleRequest LoadAssetAsync(string name)
		{
			return null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000C")]
		public AssetBundleRequest LoadAssetAsync<T>(string name)
		{
			return null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x591A100", Offset = "0x5918D00", VA = "0x18591A100")]
		public AssetBundleRequest LoadAssetAsync(string name, Type type)
		{
			return null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x591A3E0", Offset = "0x5918FE0", VA = "0x18591A3E0")]
		public Object[] LoadAssetWithSubAssets(string name)
		{
			return null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000F")]
		internal static T[] ConvertObjects<T>(Object[] rawObjects) where T : Object
		{
			return null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000010")]
		public T[] LoadAssetWithSubAssets<T>(string name) where T : Object
		{
			return null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x591A2C0", Offset = "0x5918EC0", VA = "0x18591A2C0")]
		public Object[] LoadAssetWithSubAssets(string name, Type type)
		{
			return null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x5919D00", Offset = "0x5918900", VA = "0x185919D00")]
		public Object[] LoadAllAssets()
		{
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x5919E20", Offset = "0x5918A20", VA = "0x185919E20")]
		public Object[] LoadAllAssets(Type type)
		{
			return null;
		}

		// Token: 0x06000014 RID: 20
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x5919EF0", Offset = "0x5918AF0", VA = "0x185919EF0")]
		[NativeThrows]
		[NativeMethod("LoadAssetAsync_Internal")]
		[MethodImpl(4096)]
		private extern AssetBundleRequest LoadAssetAsync_Internal(string name, Type type);

		// Token: 0x06000015 RID: 21
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x591A9F0", Offset = "0x59195F0", VA = "0x18591A9F0")]
		[NativeThrows]
		[NativeMethod("Unload")]
		[MethodImpl(4096)]
		public extern void Unload(bool unloadAllLoadedObjects);

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5919CC0", Offset = "0x59188C0", VA = "0x185919CC0")]
		[NativeMethod("GetAllScenePaths")]
		[MethodImpl(4096)]
		public extern string[] GetAllScenePaths();

		// Token: 0x06000017 RID: 23
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x591A260", Offset = "0x5918E60", VA = "0x18591A260")]
		[NativeMethod("LoadAssetWithSubAssets_Internal")]
		[NativeThrows]
		[MethodImpl(4096)]
		internal extern Object[] LoadAssetWithSubAssets_Internal(string name, Type type);
	}
}
