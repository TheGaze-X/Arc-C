using System;
using Il2CppDummyDll;
using Torappu.Audio.Middleware.Data;
using XLua;

namespace Torappu.Audio
{
	// Token: 0x02001FA6 RID: 8102
	[Token(Token = "0x2001FA6")]
	public class AudioMusicGroupHandler : IHotfixable
	{
		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x0600C941 RID: 51521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017D7")]
		public string channelName
		{
			[Token(Token = "0x600C941")]
			[Address(RVA = "0x34A0DD0", Offset = "0x349F9D0", VA = "0x1834A0DD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C942 RID: 51522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C942")]
		[Address(RVA = "0x34A0C10", Offset = "0x349F810", VA = "0x1834A0C10")]
		private AudioMusicGroupHandler()
		{
		}

		// Token: 0x0600C943 RID: 51523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C943")]
		[Address(RVA = "0x34A00D0", Offset = "0x349ECD0", VA = "0x1834A00D0")]
		public void CollectEffect(AudioChannelEffect channelEffect, AudioChannelEffect.EffectInputParam inputParam)
		{
		}

		// Token: 0x0600C944 RID: 51524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C944")]
		[Address(RVA = "0x34A0360", Offset = "0x349EF60", VA = "0x1834A0360")]
		public string PlayMusic(AudioMusicGroupHandler.GroupPlayOption groupPlayOption)
		{
			return null;
		}

		// Token: 0x0600C945 RID: 51525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C945")]
		[Address(RVA = "0x34A05A0", Offset = "0x349F1A0", VA = "0x1834A05A0")]
		public void Stop()
		{
		}

		// Token: 0x0600C946 RID: 51526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C946")]
		[Address(RVA = "0x34A08F0", Offset = "0x349F4F0", VA = "0x1834A08F0")]
		private void _PlayMusicWithChannelToSync(string bankName, string channelNameToSync)
		{
		}

		// Token: 0x0600C947 RID: 51527 RVA: 0x00049248 File Offset: 0x00047448
		[Token(Token = "0x600C947")]
		[Address(RVA = "0x34A0670", Offset = "0x349F270", VA = "0x1834A0670")]
		private AudioManager.AudioFadeParam _GeneMusicFadeParam(BGMBank bgmBank)
		{
			return default(AudioManager.AudioFadeParam);
		}

		// Token: 0x0600C948 RID: 51528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C948")]
		[Address(RVA = "0x34A0B80", Offset = "0x349F780", VA = "0x1834A0B80")]
		private void _StopChannel(AudioManager.AudioFadeParam fadeParam)
		{
		}

		// Token: 0x0400D003 RID: 53251
		[Token(Token = "0x400D003")]
		[FieldOffset(Offset = "0x10")]
		private string m_channelName;

		// Token: 0x0400D004 RID: 53252
		[Token(Token = "0x400D004")]
		[FieldOffset(Offset = "0x18")]
		private AudioManager.AudioFadeParam m_cachedFadeParam;

		// Token: 0x0400D005 RID: 53253
		[Token(Token = "0x400D005")]
		[FieldOffset(Offset = "0x28")]
		private LatchUtils.SetWhenBind<string, AudioChannelEffect> m_setEffect;

		// Token: 0x0400D006 RID: 53254
		[Token(Token = "0x400D006")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_channelName;

		// Token: 0x0400D007 RID: 53255
		[Token(Token = "0x400D007")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400D008 RID: 53256
		[Token(Token = "0x400D008")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CollectEffect;

		// Token: 0x0400D009 RID: 53257
		[Token(Token = "0x400D009")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayMusic;

		// Token: 0x0400D00A RID: 53258
		[Token(Token = "0x400D00A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0400D00B RID: 53259
		[Token(Token = "0x400D00B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayMusicWithChannelToSync;

		// Token: 0x0400D00C RID: 53260
		[Token(Token = "0x400D00C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GeneMusicFadeParam;

		// Token: 0x0400D00D RID: 53261
		[Token(Token = "0x400D00D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__StopChannel;

		// Token: 0x02001FA7 RID: 8103
		[Token(Token = "0x2001FA7")]
		public class Mgr : Singleton<AudioMusicGroupHandler.Mgr>
		{
			// Token: 0x0600C949 RID: 51529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C949")]
			[Address(RVA = "0x34AFC00", Offset = "0x34AE800", VA = "0x1834AFC00")]
			private Mgr()
			{
			}

			// Token: 0x0600C94A RID: 51530 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C94A")]
			[Address(RVA = "0x34AF980", Offset = "0x34AE580", VA = "0x1834AF980")]
			public AudioMusicGroupHandler Request()
			{
				return null;
			}

			// Token: 0x0400D00E RID: 53262
			[Token(Token = "0x400D00E")]
			private const string CHANNEL_NAME_PREFIX = "CHANNEL_GROUP_";

			// Token: 0x0400D00F RID: 53263
			[Token(Token = "0x400D00F")]
			[FieldOffset(Offset = "0x10")]
			private int m_instId;

			// Token: 0x0400D010 RID: 53264
			[Token(Token = "0x400D010")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400D011 RID: 53265
			[Token(Token = "0x400D011")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Request;
		}

		// Token: 0x02001FA8 RID: 8104
		[Token(Token = "0x2001FA8")]
		public struct GroupPlayOption
		{
			// Token: 0x0400D012 RID: 53266
			[Token(Token = "0x400D012")]
			[FieldOffset(Offset = "0x0")]
			public string musicId;

			// Token: 0x0400D013 RID: 53267
			[Token(Token = "0x400D013")]
			[FieldOffset(Offset = "0x8")]
			public string channelNameToSync;

			// Token: 0x0400D014 RID: 53268
			[Token(Token = "0x400D014")]
			[FieldOffset(Offset = "0x10")]
			public string bankName;
		}
	}
}
