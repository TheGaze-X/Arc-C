using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012FB RID: 4859
	[Token(Token = "0x20012FB")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxPermItemType
	{
		// Token: 0x04006BA0 RID: 27552
		[Token(Token = "0x4006BA0")]
		NONE,
		// Token: 0x04006BA1 RID: 27553
		[Token(Token = "0x4006BA1")]
		TACTICAL,
		// Token: 0x04006BA2 RID: 27554
		[Token(Token = "0x4006BA2")]
		BUILDING,
		// Token: 0x04006BA3 RID: 27555
		[Token(Token = "0x4006BA3")]
		BUILDINGMAT,
		// Token: 0x04006BA4 RID: 27556
		[Token(Token = "0x4006BA4")]
		FOOD,
		// Token: 0x04006BA5 RID: 27557
		[Token(Token = "0x4006BA5")]
		FOODMAT,
		// Token: 0x04006BA6 RID: 27558
		[Token(Token = "0x4006BA6")]
		SPECIALMAT,
		// Token: 0x04006BA7 RID: 27559
		[Token(Token = "0x4006BA7")]
		COIN = 9,
		// Token: 0x04006BA8 RID: 27560
		[Token(Token = "0x4006BA8")]
		CRAFT,
		// Token: 0x04006BA9 RID: 27561
		[Token(Token = "0x4006BA9")]
		PLACEHOLDER,
		// Token: 0x04006BAA RID: 27562
		[Token(Token = "0x4006BAA")]
		STAMINAPOT,
		// Token: 0x04006BAB RID: 27563
		[Token(Token = "0x4006BAB")]
		ANIMAL,
		// Token: 0x04006BAC RID: 27564
		[Token(Token = "0x4006BAC")]
		INSECT,
		// Token: 0x04006BAD RID: 27565
		[Token(Token = "0x4006BAD")]
		SLUGITEM
	}
}
