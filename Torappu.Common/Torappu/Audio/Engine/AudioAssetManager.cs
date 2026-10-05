using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Audio.Engine
{
	// Token: 0x0200025F RID: 607
	[Token(Token = "0x200025F")]
	public abstract class AudioAssetManager : IDisposable, IHotfixable, AudioEngine.IOnReloadBanks
	{
		// Token: 0x06000DDF RID: 3551 RVA: 0x00008EF4 File Offset: 0x000070F4
		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x557CE90", Offset = "0x557BA90", VA = "0x18557CE90")]
		public AudioAsset LoadAsset(string signal, IAudioInfo info, LoadAssetOptions options)
		{
			return default(AudioAsset);
		}

		// Token: 0x06000DE0 RID: 3552
		[Token(Token = "0x6000DE0")]
		protected abstract AudioAsset LoadSound(string signal, ISoundInfo info, LoadAssetOptions options);

		// Token: 0x06000DE1 RID: 3553
		[Token(Token = "0x6000DE1")]
		protected abstract AudioAsset LoadMusic(string signal, IMusicInfo info, LoadAssetOptions options);

		// Token: 0x06000DE2 RID: 3554
		[Token(Token = "0x6000DE2")]
		public abstract void FindAssetsByTag(string persistTag, AudioAssetRefCollection collection);

		// Token: 0x06000DE3 RID: 3555
		[Token(Token = "0x6000DE3")]
		public abstract void ForceUnloadAssets(AudioAssetRefCollection collection);

		// Token: 0x06000DE4 RID: 3556
		[Token(Token = "0x6000DE4")]
		public abstract void UnloadAssetByRef(AudioAsset asset);

		// Token: 0x06000DE5 RID: 3557
		[Token(Token = "0x6000DE5")]
		public abstract void OnReloadBanks();

		// Token: 0x06000DE6 RID: 3558
		[Token(Token = "0x6000DE6")]
		public abstract void Dispose();

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x557D120", Offset = "0x557BD20", VA = "0x18557D120")]
		protected AudioAssetManager()
		{
		}

		// Token: 0x04000E87 RID: 3719
		[Token(Token = "0x4000E87")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate280 __Hotfix0_LoadAsset;

		// Token: 0x04000E88 RID: 3720
		[Token(Token = "0x4000E88")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
