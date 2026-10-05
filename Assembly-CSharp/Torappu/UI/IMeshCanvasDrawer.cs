using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003990 RID: 14736
	[Token(Token = "0x2003990")]
	public interface IMeshCanvasDrawer
	{
		// Token: 0x060174C7 RID: 95431
		[Token(Token = "0x60174C7")]
		int GetLayer();

		// Token: 0x060174C8 RID: 95432
		[Token(Token = "0x60174C8")]
		void PopulateOperations(EditorMeshCanvas.DrawHandler handler);
	}
}
