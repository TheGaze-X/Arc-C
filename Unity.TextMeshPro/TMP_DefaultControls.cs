using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public static class TMP_DefaultControls
	{
		// Token: 0x06000173 RID: 371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x5884770", Offset = "0x5883370", VA = "0x185884770")]
		private static GameObject CreateUIElementRoot(string name, Vector2 size)
		{
			return null;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x5884810", Offset = "0x5883410", VA = "0x185884810")]
		private static GameObject CreateUIObject(string name, GameObject parent)
		{
			return null;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x5884920", Offset = "0x5883520", VA = "0x185884920")]
		private static void SetDefaultTextValues(TMP_Text lbl)
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x58848D0", Offset = "0x58834D0", VA = "0x1858848D0")]
		private static void SetDefaultColorTransitionValues(Selectable slider)
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x5884AB0", Offset = "0x58836B0", VA = "0x185884AB0")]
		private static void SetParentAndAlign(GameObject child, GameObject parent)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x58849D0", Offset = "0x58835D0", VA = "0x1858849D0")]
		private static void SetLayerRecursively(GameObject go, int layer)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x5884300", Offset = "0x5882F00", VA = "0x185884300")]
		public static GameObject CreateScrollbar(TMP_DefaultControls.Resources resources)
		{
			return null;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x5882200", Offset = "0x5880E00", VA = "0x185882200")]
		public static GameObject CreateButton(TMP_DefaultControls.Resources resources)
		{
			return null;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x58846C0", Offset = "0x58832C0", VA = "0x1858846C0")]
		public static GameObject CreateText(TMP_DefaultControls.Resources resources)
		{
			return null;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x5883870", Offset = "0x5882470", VA = "0x185883870")]
		public static GameObject CreateInputField(TMP_DefaultControls.Resources resources)
		{
			return null;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x5882620", Offset = "0x5881220", VA = "0x185882620")]
		public static GameObject CreateDropdown(TMP_DefaultControls.Resources resources)
		{
			return null;
		}

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		private const float kWidth = 160f;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		private const float kThickHeight = 30f;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		private const float kThinHeight = 20f;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 s_TextElementSize;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2 s_ThickElementSize;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x10")]
		private static Vector2 s_ThinElementSize;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x18")]
		private static Color s_DefaultSelectableColor;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x28")]
		private static Color s_TextColor;

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		public struct Resources
		{
			// Token: 0x0400017C RID: 380
			[Token(Token = "0x400017C")]
			[FieldOffset(Offset = "0x0")]
			public Sprite standard;

			// Token: 0x0400017D RID: 381
			[Token(Token = "0x400017D")]
			[FieldOffset(Offset = "0x8")]
			public Sprite background;

			// Token: 0x0400017E RID: 382
			[Token(Token = "0x400017E")]
			[FieldOffset(Offset = "0x10")]
			public Sprite inputField;

			// Token: 0x0400017F RID: 383
			[Token(Token = "0x400017F")]
			[FieldOffset(Offset = "0x18")]
			public Sprite knob;

			// Token: 0x04000180 RID: 384
			[Token(Token = "0x4000180")]
			[FieldOffset(Offset = "0x20")]
			public Sprite checkmark;

			// Token: 0x04000181 RID: 385
			[Token(Token = "0x4000181")]
			[FieldOffset(Offset = "0x28")]
			public Sprite dropdown;

			// Token: 0x04000182 RID: 386
			[Token(Token = "0x4000182")]
			[FieldOffset(Offset = "0x30")]
			public Sprite mask;
		}
	}
}
