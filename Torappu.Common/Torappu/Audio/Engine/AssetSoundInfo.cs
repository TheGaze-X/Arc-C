using System;
using Il2CppDummyDll;

namespace Torappu.Audio.Engine
{
	// Token: 0x0200026E RID: 622
	[Token(Token = "0x200026E")]
	public class AssetSoundInfo : ISoundInfo, IAudioInfo
	{
		// Token: 0x06000E24 RID: 3620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E24")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
		public string GetAsset()
		{
			return null;
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00009014 File Offset: 0x00007214
		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x557CDF0", Offset = "0x557B9F0", VA = "0x18557CDF0", Slot = "5")]
		public MixerDesc GetMixer()
		{
			return default(MixerDesc);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0000902C File Offset: 0x0000722C
		[Token(Token = "0x6000E26")]
		[Address(RVA = "0x557CE10", Offset = "0x557BA10", VA = "0x18557CE10", Slot = "8")]
		public bool IsSameAudio(IAudioInfo other)
		{
			return default(bool);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00009044 File Offset: 0x00007244
		[Token(Token = "0x6000E27")]
		[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70", Slot = "6")]
		public bool Loop()
		{
			return default(bool);
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0000905C File Offset: 0x0000725C
		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "7")]
		public float SpatialBlend()
		{
			return 0f;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E29")]
		[Address(RVA = "0x557CD70", Offset = "0x557B970", VA = "0x18557CD70")]
		public static AssetSoundInfo EngineOnly_Create(string path, bool loop)
		{
			return null;
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000E2A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private AssetSoundInfo()
		{
		}

		// Token: 0x04000EBA RID: 3770
		[Token(Token = "0x4000EBA")]
		[FieldOffset(Offset = "0x10")]
		public string path;

		// Token: 0x04000EBB RID: 3771
		[Token(Token = "0x4000EBB")]
		[FieldOffset(Offset = "0x18")]
		public bool loop;

		// Token: 0x04000EBC RID: 3772
		[Token(Token = "0x4000EBC")]
		[FieldOffset(Offset = "0x1C")]
		public MixerDesc.Category category;
	}
}
