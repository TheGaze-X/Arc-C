using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	public abstract class AtlasAssetBase : ScriptableObject
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000490 RID: 1168
		[Token(Token = "0x17000170")]
		public abstract Material PrimaryMaterial { [Token(Token = "0x6000490")] get; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000491 RID: 1169
		[Token(Token = "0x17000171")]
		public abstract IEnumerable<Material> Materials { [Token(Token = "0x6000491")] get; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000492 RID: 1170
		[Token(Token = "0x17000172")]
		public abstract int MaterialCount { [Token(Token = "0x6000492")] get; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000493 RID: 1171
		[Token(Token = "0x17000173")]
		public abstract bool IsLoaded { [Token(Token = "0x6000493")] get; }

		// Token: 0x06000494 RID: 1172
		[Token(Token = "0x6000494")]
		public abstract void Clear();

		// Token: 0x06000495 RID: 1173
		[Token(Token = "0x6000495")]
		public abstract Atlas GetAtlas();

		// Token: 0x06000496 RID: 1174 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		protected AtlasAssetBase()
		{
		}
	}
}
