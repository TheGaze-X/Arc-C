using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Internal
{
	// Token: 0x02007CA0 RID: 31904
	[Token(Token = "0x2007CA0")]
	public static class fiRectUtility
	{
		// Token: 0x0602C8DE RID: 182494 RVA: 0x000E0BB0 File Offset: 0x000DEDB0
		[Token(Token = "0x602C8DE")]
		[Address(RVA = "0x286CD50", Offset = "0x286B950", VA = "0x18286CD50")]
		public static Rect IndentedRect(Rect source)
		{
			return default(Rect);
		}

		// Token: 0x0602C8DF RID: 182495 RVA: 0x000E0BC8 File Offset: 0x000DEDC8
		[Token(Token = "0x602C8DF")]
		[Address(RVA = "0x286CEC0", Offset = "0x286BAC0", VA = "0x18286CEC0")]
		public static Rect MoveDown(Rect rect, float amount)
		{
			return default(Rect);
		}

		// Token: 0x0602C8E0 RID: 182496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C8E0")]
		[Address(RVA = "0x286D380", Offset = "0x286BF80", VA = "0x18286D380")]
		public static void SplitLeftHorizontalExact(Rect rect, float leftWidth, float margin, out Rect left, out Rect right)
		{
		}

		// Token: 0x0602C8E1 RID: 182497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C8E1")]
		[Address(RVA = "0x286D400", Offset = "0x286C000", VA = "0x18286D400")]
		public static void SplitRightHorizontalExact(Rect rect, float rightWidth, float margin, out Rect left, out Rect right)
		{
		}

		// Token: 0x0602C8E2 RID: 182498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C8E2")]
		[Address(RVA = "0x286D270", Offset = "0x286BE70", VA = "0x18286D270")]
		public static void SplitHorizontalPercentage(Rect rect, float percentage, float margin, out Rect left, out Rect right)
		{
		}

		// Token: 0x0602C8E3 RID: 182499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C8E3")]
		[Address(RVA = "0x286D0B0", Offset = "0x286BCB0", VA = "0x18286D0B0")]
		public static void SplitHorizontalMiddleExact(Rect rect, float middleWidth, float margin, out Rect left, out Rect middle, out Rect right)
		{
		}

		// Token: 0x0602C8E4 RID: 182500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C8E4")]
		[Address(RVA = "0x286CF30", Offset = "0x286BB30", VA = "0x18286CF30")]
		public static void SplitHorizontalFlexibleMiddle(Rect rect, float leftWidth, float rightWidth, out Rect left, out Rect middle, out Rect right)
		{
		}

		// Token: 0x0602C8E5 RID: 182501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C8E5")]
		[Address(RVA = "0x286CCB0", Offset = "0x286B8B0", VA = "0x18286CCB0")]
		public static void CenterRect(Rect toCenter, float height, out Rect centered)
		{
		}

		// Token: 0x0602C8E6 RID: 182502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C8E6")]
		[Address(RVA = "0x286CE10", Offset = "0x286BA10", VA = "0x18286CE10")]
		public static void Margin(Rect container, float horizontalMargin, float verticalMargin, out Rect smaller)
		{
		}

		// Token: 0x0602C8E7 RID: 182503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C8E7")]
		[Address(RVA = "0x286D510", Offset = "0x286C110", VA = "0x18286D510")]
		public static void SplitVerticalPercentage(Rect rect, float percentage, float margin, out Rect top, out Rect bottom)
		{
		}

		// Token: 0x0404039D RID: 263069
		[Token(Token = "0x404039D")]
		public const float IndentHorizontal = 15f;

		// Token: 0x0404039E RID: 263070
		[Token(Token = "0x404039E")]
		public const float IndentVertical = 2f;
	}
}
