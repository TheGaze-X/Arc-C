using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	public interface IMeshModifier
	{
		// Token: 0x06000573 RID: 1395
		[Token(Token = "0x6000573")]
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", false)]
		void ModifyMesh(Mesh mesh);

		// Token: 0x06000574 RID: 1396
		[Token(Token = "0x6000574")]
		void ModifyMesh(VertexHelper verts);
	}
}
