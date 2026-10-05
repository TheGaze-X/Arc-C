using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003627 RID: 13863
	[Token(Token = "0x2003627")]
	public static class UIPageEffects
	{
		// Token: 0x06016157 RID: 90455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016157")]
		[Address(RVA = "0xEA4890", Offset = "0xEA3490", VA = "0x180EA4890")]
		public static IEnumerator FadeInPush(UIPage page)
		{
			return null;
		}

		// Token: 0x06016158 RID: 90456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016158")]
		[Address(RVA = "0xEA4910", Offset = "0xEA3510", VA = "0x180EA4910")]
		public static IEnumerator FadeOutPop(UIPage page)
		{
			return null;
		}

		// Token: 0x06016159 RID: 90457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016159")]
		[Address(RVA = "0xEA4990", Offset = "0xEA3590", VA = "0x180EA4990")]
		public static IEnumerator StayInPop(UIPage page)
		{
			return null;
		}

		// Token: 0x0601615A RID: 90458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601615A")]
		[Address(RVA = "0xEA4A10", Offset = "0xEA3610", VA = "0x180EA4A10")]
		public static IEnumerator StayOutPush(UIPage page)
		{
			return null;
		}

		// Token: 0x0601615B RID: 90459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601615B")]
		[Address(RVA = "0xEA4800", Offset = "0xEA3400", VA = "0x180EA4800")]
		public static IEnumerator FadeInPushWithBlurBkg(UIPage page, UIRenderTextureImage blurBkg)
		{
			return null;
		}

		// Token: 0x0601615C RID: 90460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601615C")]
		[Address(RVA = "0xEA4A90", Offset = "0xEA3690", VA = "0x180EA4A90")]
		private static IList<CanvasGroup> _AchievePageCanvasGroups(UIPage page)
		{
			return null;
		}

		// Token: 0x0401A912 RID: 108818
		[Token(Token = "0x401A912")]
		public const float DEFAULT_FADE_DURATION = 0.23f;
	}
}
