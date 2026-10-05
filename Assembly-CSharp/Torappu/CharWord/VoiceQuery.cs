using System;
using Il2CppDummyDll;

namespace Torappu.CharWord
{
	// Token: 0x02001790 RID: 6032
	[Token(Token = "0x2001790")]
	public struct VoiceQuery
	{
		// Token: 0x06009860 RID: 39008 RVA: 0x0003B520 File Offset: 0x00039720
		[Token(Token = "0x6009860")]
		[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06009861 RID: 39009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009861")]
		[Address(RVA = "0x31356D0", Offset = "0x31342D0", VA = "0x1831356D0")]
		public string GetWordKey(CharWordShowType showType = CharWordShowType.E_ALL)
		{
			return null;
		}

		// Token: 0x06009862 RID: 39010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009862")]
		[Address(RVA = "0x31351B0", Offset = "0x3133DB0", VA = "0x1831351B0")]
		public string GetBaseWordKey(CharWordShowType showType = CharWordShowType.E_ALL)
		{
			return null;
		}

		// Token: 0x06009863 RID: 39011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009863")]
		[Address(RVA = "0x3135660", Offset = "0x3134260", VA = "0x183135660")]
		public string GetRealWordKey(CharWordShowType showType = CharWordShowType.E_ALL)
		{
			return null;
		}

		// Token: 0x06009864 RID: 39012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009864")]
		[Address(RVA = "0x31354B0", Offset = "0x31340B0", VA = "0x1831354B0")]
		public string GetRealWordKeyWithPlayerData(CharWordShowType showType = CharWordShowType.E_ALL)
		{
			return null;
		}

		// Token: 0x06009865 RID: 39013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009865")]
		[Address(RVA = "0x3135440", Offset = "0x3134040", VA = "0x183135440")]
		public string GetRealNonPatchKey()
		{
			return null;
		}

		// Token: 0x06009866 RID: 39014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009866")]
		[Address(RVA = "0x3135280", Offset = "0x3133E80", VA = "0x183135280")]
		public string GetRealNonPatchKeyWithPlayerData()
		{
			return null;
		}

		// Token: 0x06009867 RID: 39015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009867")]
		[Address(RVA = "0x3135850", Offset = "0x3134450", VA = "0x183135850")]
		private string _GetRealWordKey(string baseKey, VoiceLangType voiceLangType)
		{
			return null;
		}

		// Token: 0x06009868 RID: 39016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009868")]
		[Address(RVA = "0x3135250", Offset = "0x3133E50", VA = "0x183135250")]
		public string GetNonPatchWordKey()
		{
			return null;
		}

		// Token: 0x06009869 RID: 39017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009869")]
		[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
		public void SetVoiceLangType(VoiceLangType voiceLangType)
		{
		}

		// Token: 0x0600986A RID: 39018 RVA: 0x0003B538 File Offset: 0x00039738
		[Token(Token = "0x600986A")]
		[Address(RVA = "0x3135930", Offset = "0x3134530", VA = "0x183135930")]
		private static VoiceLangType _TryGetTypeFromPlayerData(string charId, VoiceLangType voiceLangType)
		{
			return VoiceLangType.NONE;
		}

		// Token: 0x0600986B RID: 39019 RVA: 0x0003B550 File Offset: 0x00039750
		[Token(Token = "0x600986B")]
		[Address(RVA = "0x3135770", Offset = "0x3134370", VA = "0x183135770")]
		public static VoiceQuery SimpleChar(string charId, VoiceLangType voiceLangType = VoiceLangType.NONE)
		{
			return default(VoiceQuery);
		}

		// Token: 0x0600986C RID: 39020 RVA: 0x0003B568 File Offset: 0x00039768
		[Token(Token = "0x600986C")]
		[Address(RVA = "0x3134EC0", Offset = "0x3133AC0", VA = "0x183134EC0")]
		public static VoiceQuery FromSkinId(string skinId, VoiceLangType voiceLangType = VoiceLangType.NONE)
		{
			return default(VoiceQuery);
		}

		// Token: 0x0600986D RID: 39021 RVA: 0x0003B580 File Offset: 0x00039780
		[Token(Token = "0x600986D")]
		[Address(RVA = "0x3135080", Offset = "0x3133C80", VA = "0x183135080")]
		public static VoiceQuery FromSkin(CharSkinData skinData, VoiceLangType voiceLangType = VoiceLangType.NONE)
		{
			return default(VoiceQuery);
		}

		// Token: 0x0600986E RID: 39022 RVA: 0x0003B598 File Offset: 0x00039798
		[Token(Token = "0x600986E")]
		[Address(RVA = "0x3134E10", Offset = "0x3133A10", VA = "0x183134E10")]
		public bool CheckIfUseVoiceId(CharWordShowType showType)
		{
			return default(bool);
		}

		// Token: 0x04008E52 RID: 36434
		[Token(Token = "0x4008E52")]
		[FieldOffset(Offset = "0x0")]
		public static readonly VoiceQuery EMPTY;

		// Token: 0x04008E53 RID: 36435
		[Token(Token = "0x4008E53")]
		[FieldOffset(Offset = "0x0")]
		public string charId;

		// Token: 0x04008E54 RID: 36436
		[Token(Token = "0x4008E54")]
		[FieldOffset(Offset = "0x8")]
		public string tmplId;

		// Token: 0x04008E55 RID: 36437
		[Token(Token = "0x4008E55")]
		[FieldOffset(Offset = "0x10")]
		public string voiceId;

		// Token: 0x04008E56 RID: 36438
		[Token(Token = "0x4008E56")]
		[FieldOffset(Offset = "0x18")]
		public SkinVoiceType voiceType;

		// Token: 0x04008E57 RID: 36439
		[Token(Token = "0x4008E57")]
		[FieldOffset(Offset = "0x1C")]
		public VoiceLangType voiceLangType;
	}
}
