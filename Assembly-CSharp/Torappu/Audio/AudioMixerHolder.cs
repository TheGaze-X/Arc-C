using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using XLua;

namespace Torappu.Audio
{
	// Token: 0x02001FA5 RID: 8101
	[Token(Token = "0x2001FA5")]
	public class AudioMixerHolder : ScriptableObject, IHotfixable
	{
		// Token: 0x0600C940 RID: 51520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C940")]
		[Address(RVA = "0x34A0070", Offset = "0x349EC70", VA = "0x1834A0070")]
		public AudioMixerHolder()
		{
		}

		// Token: 0x0400CFFA RID: 53242
		[Token(Token = "0x400CFFA")]
		[FieldOffset(Offset = "0x18")]
		public AudioMixer mainMixer;

		// Token: 0x0400CFFB RID: 53243
		[Token(Token = "0x400CFFB")]
		[FieldOffset(Offset = "0x20")]
		public AudioMixerGroup musicGroup;

		// Token: 0x0400CFFC RID: 53244
		[Token(Token = "0x400CFFC")]
		[FieldOffset(Offset = "0x28")]
		public AudioMixerGroup voiceGroup;

		// Token: 0x0400CFFD RID: 53245
		[Token(Token = "0x400CFFD")]
		[FieldOffset(Offset = "0x30")]
		public AudioMixerGroup fxGroup;

		// Token: 0x0400CFFE RID: 53246
		[Token(Token = "0x400CFFE")]
		[FieldOffset(Offset = "0x38")]
		public AudioMixerGroup uiFxGroup;

		// Token: 0x0400CFFF RID: 53247
		[Token(Token = "0x400CFFF")]
		[FieldOffset(Offset = "0x40")]
		public AudioMixerGroup importantUIFxGroup;

		// Token: 0x0400D000 RID: 53248
		[Token(Token = "0x400D000")]
		[FieldOffset(Offset = "0x48")]
		public AudioMixerGroup battleFxGroup;

		// Token: 0x0400D001 RID: 53249
		[Token(Token = "0x400D001")]
		[FieldOffset(Offset = "0x50")]
		public AudioMixerGroup importantBattleFxGroup;

		// Token: 0x0400D002 RID: 53250
		[Token(Token = "0x400D002")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
