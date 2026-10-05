using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E5B RID: 3675
	[Token(Token = "0x2000E5B")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActVecBreakV2ParticleType
	{
		// Token: 0x04004CEC RID: 19692
		[Token(Token = "0x4004CEC")]
		NONE,
		// Token: 0x04004CED RID: 19693
		[Token(Token = "0x4004CED")]
		HARD
	}
}
