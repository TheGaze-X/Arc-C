using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Audio.Middleware.Data
{
	// Token: 0x02001FC5 RID: 8133
	[Token(Token = "0x2001FC5")]
	[Serializable]
	public class TorappuAudioData
	{
		// Token: 0x0600C9FC RID: 51708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9FC")]
		[Address(RVA = "0x34B48C0", Offset = "0x34B34C0", VA = "0x1834B48C0")]
		public TorappuAudioData()
		{
		}

		// Token: 0x0400D27C RID: 53884
		[Token(Token = "0x400D27C")]
		[FieldOffset(Offset = "0x10")]
		public BGMBank[] bgmBanks;

		// Token: 0x0400D27D RID: 53885
		[Token(Token = "0x400D27D")]
		[FieldOffset(Offset = "0x18")]
		public SoundFXBank[] soundFXBanks;

		// Token: 0x0400D27E RID: 53886
		[Token(Token = "0x400D27E")]
		[FieldOffset(Offset = "0x20")]
		public SoundFXCtrlBank[] soundFXCtrlBanks;

		// Token: 0x0400D27F RID: 53887
		[Token(Token = "0x400D27F")]
		[FieldOffset(Offset = "0x28")]
		public SnapshotBank[] snapshotBanks;

		// Token: 0x0400D280 RID: 53888
		[Token(Token = "0x400D280")]
		[FieldOffset(Offset = "0x30")]
		public BattleVoiceData battleVoice;

		// Token: 0x0400D281 RID: 53889
		[Token(Token = "0x400D281")]
		[FieldOffset(Offset = "0x38")]
		public MusicData[] musics;

		// Token: 0x0400D282 RID: 53890
		[Token(Token = "0x400D282")]
		[FieldOffset(Offset = "0x40")]
		public DuckingData[] duckings;

		// Token: 0x0400D283 RID: 53891
		[Token(Token = "0x400D283")]
		[FieldOffset(Offset = "0x48")]
		public FadeStyleData[] fadeStyles;

		// Token: 0x0400D284 RID: 53892
		[Token(Token = "0x400D284")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, SoundFXVoiceLangData> soundFxVoiceLang;

		// Token: 0x0400D285 RID: 53893
		[Token(Token = "0x400D285")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, string> bankAlias;
	}
}
