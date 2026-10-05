using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Resource
{
	// Token: 0x020001CA RID: 458
	[Token(Token = "0x20001CA")]
	public class AsyncResource : CustomYieldInstruction
	{
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x000079C4 File Offset: 0x00005BC4
		[Token(Token = "0x170000F4")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x554B670", Offset = "0x554A270", VA = "0x18554B670", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x000079DC File Offset: 0x00005BDC
		[Token(Token = "0x170000F5")]
		public bool isDone
		{
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x554B630", Offset = "0x554A230", VA = "0x18554B630")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x4E182C0", Offset = "0x4E16EC0", VA = "0x184E182C0")]
		public AsyncResource(ResourceRequest resRequest)
		{
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x518B2B0", Offset = "0x5189EB0", VA = "0x18518B2B0")]
		public AsyncResource(AssetBundleRequest abRequest)
		{
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x24BE8D0", Offset = "0x24BD4D0", VA = "0x1824BE8D0")]
		public AsyncResource(UnityEngine.Object asset)
		{
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
		public ResourceRequest GetResourceRequest()
		{
			return null;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
		public AssetBundleRequest GetAssetBundleRequest()
		{
			return null;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x554B420", Offset = "0x554A020", VA = "0x18554B420")]
		public void AddLoadedCallback(Action<UnityEngine.Object> onLoaded)
		{
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x554B530", Offset = "0x554A130", VA = "0x18554B530", Slot = "9")]
		public virtual UnityEngine.Object GetAsset()
		{
			return null;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ABB")]
		public T GetAsset<T>() where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ABC")]
		public TComp GetComponent<TComp>() where TComp : Component
		{
			return null;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x554B5A0", Offset = "0x554A1A0", VA = "0x18554B5A0")]
		private void _OnLoadFinished()
		{
		}

		// Token: 0x04000A5F RID: 2655
		[Token(Token = "0x4000A5F")]
		[FieldOffset(Offset = "0x10")]
		private Action<UnityEngine.Object> m_onLoaded;

		// Token: 0x04000A60 RID: 2656
		[Token(Token = "0x4000A60")]
		[FieldOffset(Offset = "0x18")]
		private UnityEngine.Object m_asset;

		// Token: 0x04000A61 RID: 2657
		[Token(Token = "0x4000A61")]
		[FieldOffset(Offset = "0x20")]
		private ResourceRequest m_resRequest;

		// Token: 0x04000A62 RID: 2658
		[Token(Token = "0x4000A62")]
		[FieldOffset(Offset = "0x28")]
		private AssetBundleRequest m_abRequest;

		// Token: 0x04000A63 RID: 2659
		[Token(Token = "0x4000A63")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isLoaded;
	}
}
