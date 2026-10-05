using System;
using Il2CppDummyDll;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	// Token: 0x02000261 RID: 609
	[Token(Token = "0x2000261")]
	internal interface ITextHandle
	{
		// Token: 0x06001131 RID: 4401
		[Token(Token = "0x6001131")]
		Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling);

		// Token: 0x06001132 RID: 4402
		[Token(Token = "0x6001132")]
		float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling);

		// Token: 0x06001133 RID: 4403
		[Token(Token = "0x6001133")]
		float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling);

		// Token: 0x06001134 RID: 4404
		[Token(Token = "0x6001134")]
		float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint);

		// Token: 0x06001135 RID: 4405
		[Token(Token = "0x6001135")]
		TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint);

		// Token: 0x06001136 RID: 4406
		[Token(Token = "0x6001136")]
		bool IsLegacy();

		// Token: 0x06001137 RID: 4407
		[Token(Token = "0x6001137")]
		bool IsElided();

		// Token: 0x1700045A RID: 1114
		// (set) Token: 0x06001138 RID: 4408
		[Token(Token = "0x1700045A")]
		Vector2 MeasuredSizes { [Token(Token = "0x6001138")] set; }

		// Token: 0x1700045B RID: 1115
		// (set) Token: 0x06001139 RID: 4409
		[Token(Token = "0x1700045B")]
		Vector2 RoundedSizes { [Token(Token = "0x6001139")] set; }
	}
}
