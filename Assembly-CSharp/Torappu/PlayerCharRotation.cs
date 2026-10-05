using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000C08 RID: 3080
	[Token(Token = "0x2000C08")]
	public class PlayerCharRotation
	{
		// Token: 0x0600689E RID: 26782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600689E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerCharRotation()
		{
		}

		// Token: 0x04003ED3 RID: 16083
		[Token(Token = "0x4003ED3")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "current")]
		public string currentPresetId;

		// Token: 0x04003ED4 RID: 16084
		[Token(Token = "0x4003ED4")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty(PropertyName = "preset")]
		public Dictionary<string, PlayerCharRotationPreset> presets;
	}
}
