using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	internal interface IStylePainter
	{
		// Token: 0x0600025D RID: 605
		[Token(Token = "0x600025D")]
		void DrawText(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint);

		// Token: 0x0600025E RID: 606
		[Token(Token = "0x600025E")]
		void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams);

		// Token: 0x0600025F RID: 607
		[Token(Token = "0x600025F")]
		void DrawImmediate(Action callback, bool cullingEnabled);
	}
}
