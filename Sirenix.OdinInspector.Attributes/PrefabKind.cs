using System;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	[Flags]
	public enum PrefabKind
	{
		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		None = 0,
		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		InstanceInScene = 1,
		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		InstanceInPrefab = 2,
		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		Regular = 4,
		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		Variant = 8,
		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		NonPrefabInstance = 16,
		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		PrefabInstance = 3,
		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		PrefabAsset = 12,
		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		PrefabInstanceAndNonPrefabInstance = 19,
		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		All = 31
	}
}
