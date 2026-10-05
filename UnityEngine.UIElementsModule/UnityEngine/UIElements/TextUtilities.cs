using System;
using Il2CppDummyDll;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x02000264 RID: 612
	[Token(Token = "0x2000264")]
	internal static class TextUtilities
	{
		// Token: 0x0600115A RID: 4442 RVA: 0x00009780 File Offset: 0x00007980
		[Token(Token = "0x600115A")]
		[Address(RVA = "0x5B281C0", Offset = "0x5B26DC0", VA = "0x185B281C0")]
		public static float ComputeTextScaling(Matrix4x4 worldMatrix, float pixelsPerPoint)
		{
			return 0f;
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00009798 File Offset: 0x00007998
		[Token(Token = "0x600115B")]
		[Address(RVA = "0x5B290D0", Offset = "0x5B27CD0", VA = "0x185B290D0")]
		internal static Vector2 MeasureVisualElementTextSize(VisualElement ve, string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode, ITextHandle textHandle)
		{
			return default(Vector2);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600115C")]
		[Address(RVA = "0x5B28320", Offset = "0x5B26F20", VA = "0x185B28320")]
		internal static FontAsset GetFontAsset(MeshGenerationContextUtils.TextParams textParam)
		{
			return null;
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600115D")]
		[Address(RVA = "0x5B284A0", Offset = "0x5B270A0", VA = "0x185B284A0")]
		internal static FontAsset GetFontAsset(VisualElement ve)
		{
			return null;
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600115E")]
		[Address(RVA = "0x5B286F0", Offset = "0x5B272F0", VA = "0x185B286F0")]
		internal static Font GetFont(MeshGenerationContextUtils.TextParams textParam)
		{
			return null;
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600115F")]
		[Address(RVA = "0x5B287E0", Offset = "0x5B273E0", VA = "0x185B287E0")]
		internal static Font GetFont(VisualElement ve)
		{
			return null;
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x000097B0 File Offset: 0x000079B0
		[Token(Token = "0x6001160")]
		[Address(RVA = "0x5B29000", Offset = "0x5B27C00", VA = "0x185B29000")]
		internal static bool IsFontAssigned(VisualElement ve)
		{
			return default(bool);
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x000097C8 File Offset: 0x000079C8
		[Token(Token = "0x6001161")]
		[Address(RVA = "0x5B28F80", Offset = "0x5B27B80", VA = "0x185B28F80")]
		internal static bool IsFontAssigned(MeshGenerationContextUtils.TextParams textParams)
		{
			return default(bool);
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001162")]
		[Address(RVA = "0x5B28DB0", Offset = "0x5B279B0", VA = "0x185B28DB0")]
		internal static PanelTextSettings GetTextSettingsFrom(VisualElement ve)
		{
			return null;
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001163")]
		[Address(RVA = "0x5B28E90", Offset = "0x5B27A90", VA = "0x185B28E90")]
		internal static PanelTextSettings GetTextSettingsFrom(MeshGenerationContextUtils.TextParams textParam)
		{
			return null;
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x000097E0 File Offset: 0x000079E0
		[Token(Token = "0x6001164")]
		[Address(RVA = "0x5B28980", Offset = "0x5B27580", VA = "0x185B28980")]
		internal static TextCoreSettings GetTextCoreSettingsForElement(VisualElement ve)
		{
			return default(TextCoreSettings);
		}
	}
}
