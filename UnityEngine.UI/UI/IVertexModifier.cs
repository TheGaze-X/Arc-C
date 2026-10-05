using System;
using System.Collections.Generic;
using System.ComponentModel;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use IMeshModifier instead", true)]
	public interface IVertexModifier
	{
		// Token: 0x06000572 RID: 1394
		[Token(Token = "0x6000572")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", true)]
		void ModifyVertices(List<UIVertex> verts);
	}
}
