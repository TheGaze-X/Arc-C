using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Audio.Test
{
	// Token: 0x02001FB3 RID: 8115
	[Token(Token = "0x2001FB3")]
	public class AudioTester : MonoBehaviour
	{
		// Token: 0x0600C97B RID: 51579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C97B")]
		[Address(RVA = "0x34A1800", Offset = "0x34A0400", VA = "0x1834A1800")]
		private void Awake()
		{
		}

		// Token: 0x0600C97C RID: 51580 RVA: 0x000492D8 File Offset: 0x000474D8
		[Token(Token = "0x600C97C")]
		[Address(RVA = "0x34A1C60", Offset = "0x34A0860", VA = "0x1834A1C60")]
		private float _LayoutHorizontalSlider(string title, float titleWidth, float value, float left = 0f, float right = 1f, string valueFormat = "0.00")
		{
			return 0f;
		}

		// Token: 0x0600C97D RID: 51581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C97D")]
		[Address(RVA = "0x34A1E40", Offset = "0x34A0A40", VA = "0x1834A1E40")]
		private string _LayoutTextField(string title, float titleWidth, string text, float fieldWidth = -1f)
		{
			return null;
		}

		// Token: 0x0600C97E RID: 51582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C97E")]
		[Address(RVA = "0x34A2CE0", Offset = "0x34A18E0", VA = "0x1834A2CE0")]
		private void _MakeMixerWindow(int windowID)
		{
		}

		// Token: 0x0600C97F RID: 51583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C97F")]
		[Address(RVA = "0x34A3030", Offset = "0x34A1C30", VA = "0x1834A3030")]
		private void _MakeMusicWindow(int windowID)
		{
		}

		// Token: 0x0600C980 RID: 51584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C980")]
		[Address(RVA = "0x34A39C0", Offset = "0x34A25C0", VA = "0x1834A39C0")]
		private void _MakeVoiceWindow(int windowID)
		{
		}

		// Token: 0x0600C981 RID: 51585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C981")]
		[Address(RVA = "0x34A3250", Offset = "0x34A1E50", VA = "0x1834A3250")]
		private void _MakeSoundWindow(int windowID)
		{
		}

		// Token: 0x0600C982 RID: 51586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C982")]
		[Address(RVA = "0x34A1FF0", Offset = "0x34A0BF0", VA = "0x1834A1FF0")]
		private void _MakeAudioClipManagerWindow(int windowID)
		{
		}

		// Token: 0x0600C983 RID: 51587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C983")]
		[Address(RVA = "0x34A26C0", Offset = "0x34A12C0", VA = "0x1834A26C0")]
		private void _MakeChannelWindow(int windowID)
		{
		}

		// Token: 0x0600C984 RID: 51588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C984")]
		[Address(RVA = "0x34A1810", Offset = "0x34A0410", VA = "0x1834A1810")]
		private void OnGUI()
		{
		}

		// Token: 0x0600C985 RID: 51589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C985")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		[Obsolete("AudioManager doesn't supports these Unity specific operations")]
		public static AudioChannel PlaySoundFx(string key, AudioManager.AudioPlayOption playOption, AudioManager.FXCategory fxCategory = AudioManager.FXCategory.FX_UI, bool important = false)
		{
			return null;
		}

		// Token: 0x0600C986 RID: 51590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C986")]
		[Address(RVA = "0x34A3EA0", Offset = "0x34A2AA0", VA = "0x1834A3EA0")]
		public AudioTester()
		{
		}

		// Token: 0x0400D1E4 RID: 53732
		[Token(Token = "0x400D1E4")]
		[FieldOffset(Offset = "0x18")]
		private Rect m_mixerWindowRect;

		// Token: 0x0400D1E5 RID: 53733
		[Token(Token = "0x400D1E5")]
		[FieldOffset(Offset = "0x28")]
		private string m_mixerTransitionToSnapshot;

		// Token: 0x0400D1E6 RID: 53734
		[Token(Token = "0x400D1E6")]
		[FieldOffset(Offset = "0x30")]
		private float m_mixerTransitionDuration;

		// Token: 0x0400D1E7 RID: 53735
		[Token(Token = "0x400D1E7")]
		[FieldOffset(Offset = "0x34")]
		private Rect m_musicWindowRect;

		// Token: 0x0400D1E8 RID: 53736
		[Token(Token = "0x400D1E8")]
		[FieldOffset(Offset = "0x48")]
		private string m_musicIntroKey;

		// Token: 0x0400D1E9 RID: 53737
		[Token(Token = "0x400D1E9")]
		[FieldOffset(Offset = "0x50")]
		private string m_musicLoopKey;

		// Token: 0x0400D1EA RID: 53738
		[Token(Token = "0x400D1EA")]
		[FieldOffset(Offset = "0x58")]
		private float m_musicVolume;

		// Token: 0x0400D1EB RID: 53739
		[Token(Token = "0x400D1EB")]
		[FieldOffset(Offset = "0x5C")]
		private float m_musicDelay;

		// Token: 0x0400D1EC RID: 53740
		[Token(Token = "0x400D1EC")]
		[FieldOffset(Offset = "0x60")]
		private float m_musicCrossfadeDuration;

		// Token: 0x0400D1ED RID: 53741
		[Token(Token = "0x400D1ED")]
		[FieldOffset(Offset = "0x64")]
		private Rect m_voiceWindowRect;

		// Token: 0x0400D1EE RID: 53742
		[Token(Token = "0x400D1EE")]
		[FieldOffset(Offset = "0x78")]
		private string m_voiceKey;

		// Token: 0x0400D1EF RID: 53743
		[Token(Token = "0x400D1EF")]
		[FieldOffset(Offset = "0x80")]
		private string m_voiceChannel;

		// Token: 0x0400D1F0 RID: 53744
		[Token(Token = "0x400D1F0")]
		[FieldOffset(Offset = "0x88")]
		private float m_voiceVolume;

		// Token: 0x0400D1F1 RID: 53745
		[Token(Token = "0x400D1F1")]
		[FieldOffset(Offset = "0x8C")]
		private float m_voiceDelay;

		// Token: 0x0400D1F2 RID: 53746
		[Token(Token = "0x400D1F2")]
		[FieldOffset(Offset = "0x90")]
		private bool m_voiceLoop;

		// Token: 0x0400D1F3 RID: 53747
		[Token(Token = "0x400D1F3")]
		[FieldOffset(Offset = "0x94")]
		private Rect m_fxWindowRect;

		// Token: 0x0400D1F4 RID: 53748
		[Token(Token = "0x400D1F4")]
		[FieldOffset(Offset = "0xA8")]
		private string m_fxKey;

		// Token: 0x0400D1F5 RID: 53749
		[Token(Token = "0x400D1F5")]
		[FieldOffset(Offset = "0xB0")]
		private string m_fxChannel;

		// Token: 0x0400D1F6 RID: 53750
		[Token(Token = "0x400D1F6")]
		[FieldOffset(Offset = "0xB8")]
		private float m_fxVolume;

		// Token: 0x0400D1F7 RID: 53751
		[Token(Token = "0x400D1F7")]
		[FieldOffset(Offset = "0xBC")]
		private float m_fxDelay;

		// Token: 0x0400D1F8 RID: 53752
		[Token(Token = "0x400D1F8")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_fxLoop;

		// Token: 0x0400D1F9 RID: 53753
		[Token(Token = "0x400D1F9")]
		[FieldOffset(Offset = "0xC4")]
		private Rect m_audioClipManagerWindowRect;

		// Token: 0x0400D1FA RID: 53754
		[Token(Token = "0x400D1FA")]
		[FieldOffset(Offset = "0xD8")]
		private string m_audioSignalToPreload;

		// Token: 0x0400D1FB RID: 53755
		[Token(Token = "0x400D1FB")]
		[FieldOffset(Offset = "0xE0")]
		private string m_preloadPersistTag;

		// Token: 0x0400D1FC RID: 53756
		[Token(Token = "0x400D1FC")]
		[FieldOffset(Offset = "0xE8")]
		private int m_audioMaxInstance;

		// Token: 0x0400D1FD RID: 53757
		[Token(Token = "0x400D1FD")]
		[FieldOffset(Offset = "0xEC")]
		private Vector2 m_audioClipScroll;

		// Token: 0x0400D1FE RID: 53758
		[Token(Token = "0x400D1FE")]
		[FieldOffset(Offset = "0xF4")]
		private Rect m_channelWindowRect;

		// Token: 0x0400D1FF RID: 53759
		[Token(Token = "0x400D1FF")]
		[FieldOffset(Offset = "0x104")]
		private Vector2 m_channelScroll;
	}
}
