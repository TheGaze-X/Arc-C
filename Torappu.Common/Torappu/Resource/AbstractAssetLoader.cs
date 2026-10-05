using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Resource
{
	// Token: 0x020001B9 RID: 441
	[Token(Token = "0x20001B9")]
	public abstract class AbstractAssetLoader : ILoadAsset, IDisposable
	{
		// Token: 0x06000A3F RID: 2623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A3F")]
		public virtual T Load<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x55493E0", Offset = "0x5547FE0", VA = "0x1855493E0")]
		public UnityEngine.Object Load(string path)
		{
			return null;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A41")]
		public virtual T[] LoadAll<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x5549210", Offset = "0x5547E10", VA = "0x185549210")]
		public UnityEngine.Object[] LoadAll(string path)
		{
			return null;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A43")]
		public AsyncResource LoadAsync<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x55497B0", Offset = "0x55483B0", VA = "0x1855497B0")]
		public AsyncResource LoadAsync(string path)
		{
			return null;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A45")]
		public void LoadAsync<T>(string path, Action<bool, T> cb) where T : UnityEngine.Object
		{
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x5549570", Offset = "0x5548170", VA = "0x185549570")]
		public void LoadAsync(string path, Action<bool, UnityEngine.Object> cb)
		{
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000077B4 File Offset: 0x000059B4
		[Token(Token = "0x6000A47")]
		public bool TryLoad<T>(string path, out T obj) where T : UnityEngine.Object
		{
			return default(bool);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x000077CC File Offset: 0x000059CC
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x5549AF0", Offset = "0x55486F0", VA = "0x185549AF0")]
		public bool TryLoad(string path, out UnityEngine.Object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x5549BA0", Offset = "0x55487A0", VA = "0x185549BA0")]
		public void Unload(UnityEngine.Object asset)
		{
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x5549BF0", Offset = "0x55487F0", VA = "0x185549BF0")]
		public void UnloadByInstanceId(int instanceId)
		{
		}

		// Token: 0x06000A4B RID: 2635
		[Token(Token = "0x6000A4B")]
		public abstract void ClearAll();

		// Token: 0x06000A4C RID: 2636
		[Token(Token = "0x6000A4C")]
		protected abstract void OnAssetLoaded(string path, UnityEngine.Object asset);

		// Token: 0x06000A4D RID: 2637
		[Token(Token = "0x6000A4D")]
		protected abstract void OnAssetUnloading(UnityEngine.Object asset);

		// Token: 0x06000A4E RID: 2638 RVA: 0x000077E4 File Offset: 0x000059E4
		[Token(Token = "0x6000A4E")]
		protected virtual bool TryGetAsset<T>(string path, out T asset) where T : UnityEngine.Object
		{
			return default(bool);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x000077FC File Offset: 0x000059FC
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x3771A60", Offset = "0x3770660", VA = "0x183771A60", Slot = "14")]
		protected virtual bool TryGetAsset(string path, out UnityEngine.Object asset)
		{
			return default(bool);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00007814 File Offset: 0x00005A14
		[Token(Token = "0x6000A50")]
		protected virtual bool TryGetAssets<T>(string path, out T[] assets) where T : UnityEngine.Object
		{
			return default(bool);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0000782C File Offset: 0x00005A2C
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x3771A60", Offset = "0x3770660", VA = "0x183771A60", Slot = "16")]
		protected virtual bool TryGetAssets(string path, out UnityEngine.Object[] assets)
		{
			return default(bool);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x3104A50", Offset = "0x3103650", VA = "0x183104A50", Slot = "17")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A53")]
		public T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x55493E0", Offset = "0x5547FE0", VA = "0x1855493E0", Slot = "5")]
		public UnityEngine.Object LoadAsset(string path)
		{
			return null;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x5549BA0", Offset = "0x55487A0", VA = "0x185549BA0", Slot = "6")]
		public void UnloadAsset(UnityEngine.Object asset)
		{
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AbstractAssetLoader()
		{
		}
	}
}
