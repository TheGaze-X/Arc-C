using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Torappu.Resource
{
	// Token: 0x020001D1 RID: 465
	[Token(Token = "0x20001D1")]
	public static class ResourceManager
	{
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F8")]
		private static IResourceManager instance
		{
			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0x555AA60", Offset = "0x5559660", VA = "0x18555AA60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x555A3A0", Offset = "0x5558FA0", VA = "0x18555A3A0")]
		public static void ResourceManagerEntryOnly_SetImplementation(IResourceManager inst)
		{
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00007A24 File Offset: 0x00005C24
		[Token(Token = "0x170000F9")]
		public static bool inited
		{
			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0x555AA00", Offset = "0x5559600", VA = "0x18555AA00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x5559B10", Offset = "0x5558710", VA = "0x185559B10")]
		public static void InitIfNot()
		{
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x5559880", Offset = "0x5558480", VA = "0x185559880")]
		public static void ForceReInit()
		{
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x5559A10", Offset = "0x5558610", VA = "0x185559A10")]
		public static string GetDebugStr()
		{
			return null;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF0")]
		public static T Load<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x555A100", Offset = "0x5558D00", VA = "0x18555A100")]
		public static UnityEngine.Object Load(string path)
		{
			return null;
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF2")]
		public static AsyncResource LoadAsync<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x5559DB0", Offset = "0x55589B0", VA = "0x185559DB0")]
		public static AsyncResource LoadAsync(string path)
		{
			return null;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AF4")]
		public static void LoadAsync<T>(string path, Action<bool, T> cb) where T : UnityEngine.Object
		{
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x5559C90", Offset = "0x5558890", VA = "0x185559C90")]
		public static void LoadAsync(string path, Action<bool, UnityEngine.Object> cb)
		{
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF6")]
		public static T[] LoadAll<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x5559B80", Offset = "0x5558780", VA = "0x185559B80")]
		public static UnityEngine.Object[] LoadAll(string path)
		{
			return null;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00007A3C File Offset: 0x00005C3C
		[Token(Token = "0x6000AF8")]
		public static bool TryLoadAsset<T>(string path, out T obj) where T : UnityEngine.Object
		{
			return default(bool);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00007A54 File Offset: 0x00005C54
		[Token(Token = "0x6000AF9")]
		public static bool TryLoadAsset<T>(string path, out UnityEngine.Object obj)
		{
			return default(bool);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x555A650", Offset = "0x5559250", VA = "0x18555A650")]
		public static void UnloadAsset(UnityEngine.Object obj)
		{
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x555A540", Offset = "0x5559140", VA = "0x18555A540")]
		public static void UnloadAssetByInstanceId(int instanceId)
		{
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00007A6C File Offset: 0x00005C6C
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x5559770", Offset = "0x5558370", VA = "0x185559770")]
		public static bool CheckExists(string path)
		{
			return default(bool);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x5559EC0", Offset = "0x5558AC0", VA = "0x185559EC0")]
		public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode = LoadSceneMode.Single)
		{
			return null;
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x5559FE0", Offset = "0x5558BE0", VA = "0x185559FE0")]
		public static void LoadScene(string sceneName, LoadSceneMode mode = LoadSceneMode.Single)
		{
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x555A760", Offset = "0x5559360", VA = "0x18555A760")]
		public static void UnloadScene(string sceneName, bool forceUnloadEvenUsed)
		{
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x555A880", Offset = "0x5559480", VA = "0x18555A880")]
		public static AsyncOperation UnloadUnusedAssets()
		{
			return null;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x555A4D0", Offset = "0x55590D0", VA = "0x18555A4D0")]
		public static IEnumerator UnloadAllAssets(bool forceUnloadEvenUsed)
		{
			return null;
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x555A440", Offset = "0x5559040", VA = "0x18555A440")]
		public static IEnumerator UnloadAllAssetsExcept(string[] excludedPrefixes, bool forceUnloadEvenUsed)
		{
			return null;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x555A320", Offset = "0x5558F20", VA = "0x18555A320")]
		public static void RegisterListener(IResourceListener listener)
		{
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x555A980", Offset = "0x5559580", VA = "0x18555A980")]
		public static void UnregisterListener(IResourceListener listener)
		{
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x555A210", Offset = "0x5558E10", VA = "0x18555A210")]
		public static void MarkAssetInvalid(string resPath)
		{
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x55598F0", Offset = "0x55584F0", VA = "0x1855598F0")]
		public static string GenerateAssetFullPath(string resPath, out bool isStreaming)
		{
			return null;
		}

		// Token: 0x04000A70 RID: 2672
		[Token(Token = "0x4000A70")]
		[FieldOffset(Offset = "0x0")]
		private static IResourceManager s_instance;
	}
}
