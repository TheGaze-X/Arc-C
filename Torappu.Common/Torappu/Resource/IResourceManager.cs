using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Torappu.Resource
{
	// Token: 0x020001CD RID: 461
	[Token(Token = "0x20001CD")]
	public interface IResourceManager
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000AC6 RID: 2758
		[Token(Token = "0x170000F6")]
		bool inited { [Token(Token = "0x6000AC6")] get; }

		// Token: 0x06000AC7 RID: 2759
		[Token(Token = "0x6000AC7")]
		void InitIfNot();

		// Token: 0x06000AC8 RID: 2760
		[Token(Token = "0x6000AC8")]
		void ForceReInit();

		// Token: 0x06000AC9 RID: 2761
		[Token(Token = "0x6000AC9")]
		string GetDebugStr();

		// Token: 0x06000ACA RID: 2762
		[Token(Token = "0x6000ACA")]
		T Load<T>(string path) where T : UnityEngine.Object;

		// Token: 0x06000ACB RID: 2763
		[Token(Token = "0x6000ACB")]
		UnityEngine.Object Load(string path);

		// Token: 0x06000ACC RID: 2764
		[Token(Token = "0x6000ACC")]
		T[] LoadAll<T>(string path) where T : UnityEngine.Object;

		// Token: 0x06000ACD RID: 2765
		[Token(Token = "0x6000ACD")]
		UnityEngine.Object[] LoadAll(string path);

		// Token: 0x06000ACE RID: 2766
		[Token(Token = "0x6000ACE")]
		AsyncResource LoadAsync<T>(string path) where T : UnityEngine.Object;

		// Token: 0x06000ACF RID: 2767
		[Token(Token = "0x6000ACF")]
		AsyncResource LoadAsync(string path);

		// Token: 0x06000AD0 RID: 2768
		[Token(Token = "0x6000AD0")]
		void LoadAsync<T>(string path, Action<bool, T> cb) where T : UnityEngine.Object;

		// Token: 0x06000AD1 RID: 2769
		[Token(Token = "0x6000AD1")]
		void LoadAsync(string path, Action<bool, UnityEngine.Object> cb);

		// Token: 0x06000AD2 RID: 2770
		[Token(Token = "0x6000AD2")]
		bool TryLoad<T>(string path, out T obj) where T : UnityEngine.Object;

		// Token: 0x06000AD3 RID: 2771
		[Token(Token = "0x6000AD3")]
		bool TryLoad(string path, out UnityEngine.Object obj);

		// Token: 0x06000AD4 RID: 2772
		[Token(Token = "0x6000AD4")]
		void UnloadAsset(UnityEngine.Object assetToUnload);

		// Token: 0x06000AD5 RID: 2773
		[Token(Token = "0x6000AD5")]
		void UnloadAssetByInstanceId(int instanceId);

		// Token: 0x06000AD6 RID: 2774
		[Token(Token = "0x6000AD6")]
		bool CheckExists(string path);

		// Token: 0x06000AD7 RID: 2775
		[Token(Token = "0x6000AD7")]
		AsyncOperation LoadSceneAsync(string path, LoadSceneMode mode);

		// Token: 0x06000AD8 RID: 2776
		[Token(Token = "0x6000AD8")]
		bool LoadScene(string path, LoadSceneMode mode);

		// Token: 0x06000AD9 RID: 2777
		[Token(Token = "0x6000AD9")]
		void UnloadScene(string path, bool forceUnloadEvenUsed);

		// Token: 0x06000ADA RID: 2778
		[Token(Token = "0x6000ADA")]
		AsyncOperation UnloadUnusedAssets();

		// Token: 0x06000ADB RID: 2779
		[Token(Token = "0x6000ADB")]
		IEnumerator UnloadAllAssets(bool forceUnloadEvenUsed);

		// Token: 0x06000ADC RID: 2780
		[Token(Token = "0x6000ADC")]
		IEnumerator UnloadAllAssetsExcept(string[] excludedPrefixes, bool forceUnloadEvenUsed);

		// Token: 0x06000ADD RID: 2781
		[Token(Token = "0x6000ADD")]
		void RegisterListener(IResourceListener listener);

		// Token: 0x06000ADE RID: 2782
		[Token(Token = "0x6000ADE")]
		void UnregisterListener(IResourceListener listener);

		// Token: 0x06000ADF RID: 2783
		[Token(Token = "0x6000ADF")]
		void MarkAssetInvalid(string path);

		// Token: 0x06000AE0 RID: 2784
		[Token(Token = "0x6000AE0")]
		string GenerateAssetFullPath(string resPath, out bool isStreaming);
	}
}
