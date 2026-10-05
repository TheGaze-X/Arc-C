using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Resource.AB
{
	// Token: 0x02001775 RID: 6005
	[Token(Token = "0x2001775")]
	public class BundleHolder : BundleRef
	{
		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06009782 RID: 38786 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009783 RID: 38787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700103E")]
		public AssetBundle ab
		{
			[Token(Token = "0x6009782")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009783")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06009784 RID: 38788 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009785 RID: 38789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700103F")]
		public ABResourceManager.BundleInfo info
		{
			[Token(Token = "0x6009784")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009785")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06009786 RID: 38790 RVA: 0x0003ADE8 File Offset: 0x00038FE8
		[Token(Token = "0x17001040")]
		public bool isCached
		{
			[Token(Token = "0x6009786")]
			[Address(RVA = "0x3120850", Offset = "0x311F450", VA = "0x183120850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06009787 RID: 38791 RVA: 0x0003AE00 File Offset: 0x00039000
		// (set) Token: 0x06009788 RID: 38792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001041")]
		public bool isSceneBundle
		{
			[Token(Token = "0x6009787")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6009788")]
			[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06009789 RID: 38793 RVA: 0x0003AE18 File Offset: 0x00039018
		// (set) Token: 0x0600978A RID: 38794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001042")]
		public bool isDestroyed
		{
			[Token(Token = "0x6009789")]
			[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600978A")]
			[Address(RVA = "0x31208C0", Offset = "0x311F4C0", VA = "0x1831208C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x0600978B RID: 38795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001043")]
		public string name
		{
			[Token(Token = "0x600978B")]
			[Address(RVA = "0x31208A0", Offset = "0x311F4A0", VA = "0x1831208A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600978C RID: 38796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600978C")]
		[Address(RVA = "0x311F860", Offset = "0x311E460", VA = "0x18311F860")]
		public static BundleHolder Create(ABResourceManager.BundleInfo info, IBundleRouter router)
		{
			return null;
		}

		// Token: 0x0600978D RID: 38797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600978D")]
		[Address(RVA = "0x31207C0", Offset = "0x311F3C0", VA = "0x1831207C0")]
		private BundleHolder(AssetBundle ab, ABResourceManager.BundleInfo info)
		{
		}

		// Token: 0x0600978E RID: 38798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600978E")]
		[Address(RVA = "0x311FA80", Offset = "0x311E680", VA = "0x18311FA80")]
		public void LateInit(ResourceOptions options)
		{
		}

		// Token: 0x0600978F RID: 38799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600978F")]
		public T Load<T>(BundleHolder.AssetKey key) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06009790 RID: 38800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009790")]
		[Address(RVA = "0x311FFB0", Offset = "0x311EBB0", VA = "0x18311FFB0")]
		public UnityEngine.Object Load(BundleHolder.AssetKey key)
		{
			return null;
		}

		// Token: 0x06009791 RID: 38801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009791")]
		public AsyncResource LoadAsync<T>(BundleHolder.AssetKey key) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06009792 RID: 38802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009792")]
		[Address(RVA = "0x311FE30", Offset = "0x311EA30", VA = "0x18311FE30")]
		public AsyncResource LoadAsync(BundleHolder.AssetKey key)
		{
			return null;
		}

		// Token: 0x06009793 RID: 38803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009793")]
		public T[] LoadAll<T>(BundleHolder.AssetKey key) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06009794 RID: 38804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009794")]
		[Address(RVA = "0x311FA90", Offset = "0x311E690", VA = "0x18311FA90")]
		public UnityEngine.Object[] LoadAll(BundleHolder.AssetKey key)
		{
			return null;
		}

		// Token: 0x06009795 RID: 38805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009795")]
		[Address(RVA = "0x31200F0", Offset = "0x311ECF0", VA = "0x1831200F0")]
		public void Unload(bool unloadAllLoadedAssets)
		{
		}

		// Token: 0x06009796 RID: 38806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009796")]
		[Address(RVA = "0x31200E0", Offset = "0x311ECE0", VA = "0x1831200E0", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06009797 RID: 38807 RVA: 0x0003AE30 File Offset: 0x00039030
		[Token(Token = "0x6009797")]
		[Address(RVA = "0x3120470", Offset = "0x311F070", VA = "0x183120470")]
		private bool _TryCacheAssets(ResourceOptions options)
		{
			return default(bool);
		}

		// Token: 0x06009798 RID: 38808 RVA: 0x0003AE48 File Offset: 0x00039048
		[Token(Token = "0x6009798")]
		[Address(RVA = "0x3120230", Offset = "0x311EE30", VA = "0x183120230")]
		private bool _CheckStreamingAsset(UnityEngine.Object obj)
		{
			return default(bool);
		}

		// Token: 0x06009799 RID: 38809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009799")]
		private T _LoadAssetFromAB<T>(BundleHolder.AssetKey key) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600979A RID: 38810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600979A")]
		[Address(RVA = "0x31202F0", Offset = "0x311EEF0", VA = "0x1831202F0")]
		private UnityEngine.Object _LoadAssetFromAB(BundleHolder.AssetKey key)
		{
			return null;
		}

		// Token: 0x0600979B RID: 38811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600979B")]
		private T _LoadAssetFromCache<T>(BundleHolder.AssetKey key) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600979C RID: 38812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600979C")]
		[Address(RVA = "0x3120390", Offset = "0x311EF90", VA = "0x183120390")]
		private UnityEngine.Object _LoadAssetFromCache(BundleHolder.AssetKey key)
		{
			return null;
		}

		// Token: 0x04008DB7 RID: 36279
		[Token(Token = "0x4008DB7")]
		[FieldOffset(Offset = "0x20")]
		private UnityEngine.Object[] m_cachedAssets;

		// Token: 0x04008DB8 RID: 36280
		[Token(Token = "0x4008DB8")]
		[FieldOffset(Offset = "0x28")]
		private UnityEngine.Object[][] m_cachedAssetsWithSubAssets;

		// Token: 0x02001776 RID: 6006
		[Token(Token = "0x2001776")]
		public struct AssetKey
		{
			// Token: 0x0600979D RID: 38813 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600979D")]
			[Address(RVA = "0x311F160", Offset = "0x311DD60", VA = "0x18311F160")]
			public string GetName4Load()
			{
				return null;
			}

			// Token: 0x04008DBD RID: 36285
			[Token(Token = "0x4008DBD")]
			[FieldOffset(Offset = "0x0")]
			public static readonly BundleHolder.AssetKey EMPTY;

			// Token: 0x04008DBE RID: 36286
			[Token(Token = "0x4008DBE")]
			[FieldOffset(Offset = "0x0")]
			public string path;

			// Token: 0x04008DBF RID: 36287
			[Token(Token = "0x4008DBF")]
			[FieldOffset(Offset = "0x8")]
			public string name;
		}
	}
}
