using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Audio.Engine
{
	// Token: 0x0200026F RID: 623
	[Token(Token = "0x200026F")]
	public abstract class AudioPlayback : IHotfixable
	{
		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000E2B RID: 3627
		// (set) Token: 0x06000E2C RID: 3628
		[Token(Token = "0x170001A8")]
		public abstract string name { [Token(Token = "0x6000E2B")] get; [Token(Token = "0x6000E2C")] set; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000E2D RID: 3629
		// (set) Token: 0x06000E2E RID: 3630
		[Token(Token = "0x170001A9")]
		public abstract float pitch { [Token(Token = "0x6000E2D")] get; [Token(Token = "0x6000E2E")] set; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000E2F RID: 3631
		// (set) Token: 0x06000E30 RID: 3632
		[Token(Token = "0x170001AA")]
		public abstract Vector3 position { [Token(Token = "0x6000E2F")] get; [Token(Token = "0x6000E30")] set; }

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000E31 RID: 3633
		[Token(Token = "0x170001AB")]
		public abstract float length { [Token(Token = "0x6000E31")] get; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000E32 RID: 3634
		[Token(Token = "0x170001AC")]
		public abstract float currentTime { [Token(Token = "0x6000E32")] get; }

		// Token: 0x06000E33 RID: 3635
		[Token(Token = "0x6000E33")]
		public abstract void PlaySound(ISoundInfo sound, AudioPlayback.PlayOptions options);

		// Token: 0x06000E34 RID: 3636
		[Token(Token = "0x6000E34")]
		public abstract void PlayMusic(IMusicInfo music, AudioPlayback.PlayOptions options);

		// Token: 0x06000E35 RID: 3637
		[Token(Token = "0x6000E35")]
		public abstract void PlayMusicSyncStatus(IMusicInfo music, AudioPlayback.PlayOptions options, ChannelPlayStatus status);

		// Token: 0x06000E36 RID: 3638
		[Token(Token = "0x6000E36")]
		public abstract void Stop();

		// Token: 0x06000E37 RID: 3639
		[Token(Token = "0x6000E37")]
		public abstract void SetVolume(float volume);

		// Token: 0x06000E38 RID: 3640
		[Token(Token = "0x6000E38")]
		public abstract bool IsPlaying();

		// Token: 0x06000E39 RID: 3641
		[Token(Token = "0x6000E39")]
		protected abstract void OnInit(Transform parent);

		// Token: 0x06000E3A RID: 3642
		[Token(Token = "0x6000E3A")]
		public abstract void OnReuse();

		// Token: 0x06000E3B RID: 3643
		[Token(Token = "0x6000E3B")]
		public abstract void OnRecycle();

		// Token: 0x06000E3C RID: 3644
		[Token(Token = "0x6000E3C")]
		public abstract ChannelPlayStatus GetChannelPlayStatus();

		// Token: 0x06000E3D RID: 3645
		[Token(Token = "0x6000E3D")]
		public abstract string LogAudioMixer();

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170001AD")]
		private protected AudioEngine engine
		{
			[Token(Token = "0x6000E3E")]
			[Address(RVA = "0x557ED10", Offset = "0x557D910", VA = "0x18557ED10")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6000E3F")]
			[Address(RVA = "0x557ED70", Offset = "0x557D970", VA = "0x18557ED70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000E40")]
		[Address(RVA = "0x557EBA0", Offset = "0x557D7A0", VA = "0x18557EBA0")]
		public void Init(Transform parent, AudioEngine engine)
		{
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000E41")]
		[Address(RVA = "0x557ECB0", Offset = "0x557D8B0", VA = "0x18557ECB0")]
		protected AudioPlayback()
		{
		}

		// Token: 0x04000EBE RID: 3774
		[Token(Token = "0x4000EBE")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate288 __Hotfix0_get_engine;

		// Token: 0x04000EBF RID: 3775
		[Token(Token = "0x4000EBF")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate0 __Hotfix0_set_engine;

		// Token: 0x04000EC0 RID: 3776
		[Token(Token = "0x4000EC0")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate5 __Hotfix0_Init;

		// Token: 0x04000EC1 RID: 3777
		[Token(Token = "0x4000EC1")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000270 RID: 624
		[Token(Token = "0x2000270")]
		public struct PlayOptions
		{
			// Token: 0x04000EC2 RID: 3778
			[Token(Token = "0x4000EC2")]
			[FieldOffset(Offset = "0x0")]
			public string signal;

			// Token: 0x04000EC3 RID: 3779
			[Token(Token = "0x4000EC3")]
			[FieldOffset(Offset = "0x8")]
			public float delay;

			// Token: 0x04000EC4 RID: 3780
			[Token(Token = "0x4000EC4")]
			[FieldOffset(Offset = "0x10")]
			public AudioAsset asset;
		}
	}
}
