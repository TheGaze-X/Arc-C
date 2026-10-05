using System;
using System.Collections.Generic;
using System.ComponentModel;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	[Obsolete("Use BaseMeshEffect instead", true)]
	public abstract class BaseVertexEffect
	{
		// Token: 0x06000569 RID: 1385
		[Token(Token = "0x6000569")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", true)]
		public abstract void ModifyVertices(List<UIVertex> vertices);

		// Token: 0x0600056A RID: 1386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected BaseVertexEffect()
		{
		}
	}
}
