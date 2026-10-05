using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000DFB RID: 3579
	[Token(Token = "0x2000DFB")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnemyDuelModeType
	{
		// Token: 0x04004A3D RID: 19005
		[Token(Token = "0x4004A3D")]
		OPERATION,
		// Token: 0x04004A3E RID: 19006
		[Token(Token = "0x4004A3E")]
		STAND
	}
}
