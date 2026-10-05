using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Audio.Test
{
	// Token: 0x02001FB2 RID: 8114
	[Token(Token = "0x2001FB2")]
	public class AudioImportConfig : MonoBehaviour
	{
		// Token: 0x0600C97A RID: 51578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C97A")]
		[Address(RVA = "0x349F7D0", Offset = "0x349E3D0", VA = "0x18349F7D0")]
		public AudioImportConfig()
		{
		}

		// Token: 0x0400D1DD RID: 53725
		[Token(Token = "0x400D1DD")]
		private const string ASSET_PATH = "Assets/Torappu/DevConfigs/Audio/audio_import_config.prefab";

		// Token: 0x0400D1DE RID: 53726
		[Token(Token = "0x400D1DE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Max bit-rate to use full quality for BGM in kbps for ogg files.")]
		private float _fullQualityBGMKbps;

		// Token: 0x0400D1DF RID: 53727
		[Token(Token = "0x400D1DF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("AudioSE in AVG longer than this would use low quality.")]
		private float _fullQualityAVGSELength;

		// Token: 0x0400D1E0 RID: 53728
		[Token(Token = "0x400D1E0")]
		[FieldOffset(Offset = "0x20")]
		private readonly string[] FORCE_STREAMING_SE_PATH_PREFIX;

		// Token: 0x0400D1E1 RID: 53729
		[Token(Token = "0x400D1E1")]
		[FieldOffset(Offset = "0x28")]
		private readonly string[] AUTO_STREAMING_SE_PATH_PREFIX;

		// Token: 0x0400D1E2 RID: 53730
		[Token(Token = "0x400D1E2")]
		private const string DYNENTRANCE_PATH_PREFIX = "Audio/Sound_Beta_2/DynEntrance";

		// Token: 0x0400D1E3 RID: 53731
		[Token(Token = "0x400D1E3")]
		private const string AVG_SE_PATH_PREFIX = "Audio/Sound_Beta_2/AVG/";
	}
}
