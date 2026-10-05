using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A87 RID: 10887
	[Token(Token = "0x2002A87")]
	public struct SandboxLevelConfig
	{
		// Token: 0x04014761 RID: 83809
		[Token(Token = "0x4014761")]
		[FieldOffset(Offset = "0x0")]
		public bool enableCamera;

		// Token: 0x04014762 RID: 83810
		[Token(Token = "0x4014762")]
		[FieldOffset(Offset = "0x1")]
		public bool enableWarFog;

		// Token: 0x04014763 RID: 83811
		[Token(Token = "0x4014763")]
		[FieldOffset(Offset = "0x2")]
		public bool disableCharacterGbuff;

		// Token: 0x04014764 RID: 83812
		[Token(Token = "0x4014764")]
		[FieldOffset(Offset = "0x3")]
		public bool disableTrapGbuff;

		// Token: 0x04014765 RID: 83813
		[Token(Token = "0x4014765")]
		[FieldOffset(Offset = "0x4")]
		public bool disableEnemyGbuff;

		// Token: 0x04014766 RID: 83814
		[Token(Token = "0x4014766")]
		[FieldOffset(Offset = "0x5")]
		public bool enableNormalEnemyWhenRush;
	}
}
