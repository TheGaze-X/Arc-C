using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200103D RID: 4157
	[Token(Token = "0x200103D")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnemyHandBookDamageType
	{
		// Token: 0x04005846 RID: 22598
		[Token(Token = "0x4005846")]
		PHYSIC,
		// Token: 0x04005847 RID: 22599
		[Token(Token = "0x4005847")]
		MAGIC,
		// Token: 0x04005848 RID: 22600
		[Token(Token = "0x4005848")]
		HEAL,
		// Token: 0x04005849 RID: 22601
		[Token(Token = "0x4005849")]
		NO_DAMAGE
	}
}
