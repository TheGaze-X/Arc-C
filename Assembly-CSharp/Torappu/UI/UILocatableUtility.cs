using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200395B RID: 14683
	[Token(Token = "0x200395B")]
	public static class UILocatableUtility
	{
		// Token: 0x0601733F RID: 95039 RVA: 0x00095430 File Offset: 0x00093630
		[Token(Token = "0x601733F")]
		[Address(RVA = "0xF95A20", Offset = "0xF94620", VA = "0x180F95A20")]
		public static Bounds GetFixedBoundsInLocal(RectTransform target, RectTransform local)
		{
			return default(Bounds);
		}

		// Token: 0x06017340 RID: 95040 RVA: 0x00095448 File Offset: 0x00093648
		[Token(Token = "0x6017340")]
		[Address(RVA = "0xF95C30", Offset = "0xF94830", VA = "0x180F95C30")]
		public static float GetLocateDistanceHorizontal(Bounds item, Vector2 itemPivot, Bounds focusInContent, Vector2 focusPivot)
		{
			return 0f;
		}

		// Token: 0x06017341 RID: 95041 RVA: 0x00095460 File Offset: 0x00093660
		[Token(Token = "0x6017341")]
		[Address(RVA = "0xF95CF0", Offset = "0xF948F0", VA = "0x180F95CF0")]
		public static float GetLocateDistanceVertical(Bounds item, Vector2 itemPivot, Bounds focusInContent, Vector2 focusPivot)
		{
			return 0f;
		}

		// Token: 0x06017342 RID: 95042 RVA: 0x00095478 File Offset: 0x00093678
		[Token(Token = "0x6017342")]
		[Address(RVA = "0xF95DD0", Offset = "0xF949D0", VA = "0x180F95DD0")]
		public static float GetLocatePositionHorizontal(Vector2 contentSize, Vector2 viewportSize, Bounds item, Vector2 itemPivot, Bounds focusInViewport, Vector2 focusPivot)
		{
			return 0f;
		}

		// Token: 0x06017343 RID: 95043 RVA: 0x00095490 File Offset: 0x00093690
		[Token(Token = "0x6017343")]
		[Address(RVA = "0xF95F30", Offset = "0xF94B30", VA = "0x180F95F30")]
		public static float GetLocatePositionVertical(Vector2 contentSize, Vector2 viewportSize, Bounds item, Vector2 itemPivot, Bounds focusInViewport, Vector2 focusPivot)
		{
			return 0f;
		}
	}
}
