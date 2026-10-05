using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BEE RID: 31726
	[Token(Token = "0x2007BEE")]
	[Flags]
	public enum VerifyPrefabTypeFlags
	{
		// Token: 0x04040288 RID: 262792
		[Token(Token = "0x4040288")]
		None = 1,
		// Token: 0x04040289 RID: 262793
		[Token(Token = "0x4040289")]
		Prefab = 2,
		// Token: 0x0404028A RID: 262794
		[Token(Token = "0x404028A")]
		ModelPrefab = 4,
		// Token: 0x0404028B RID: 262795
		[Token(Token = "0x404028B")]
		PrefabInstance = 8,
		// Token: 0x0404028C RID: 262796
		[Token(Token = "0x404028C")]
		ModelPrefabInstance = 16,
		// Token: 0x0404028D RID: 262797
		[Token(Token = "0x404028D")]
		MissingPrefabInstance = 32,
		// Token: 0x0404028E RID: 262798
		[Token(Token = "0x404028E")]
		DisconnectedPrefabInstance = 64,
		// Token: 0x0404028F RID: 262799
		[Token(Token = "0x404028F")]
		DisconnectedModelPrefabInstance = 128
	}
}
