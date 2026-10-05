using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu
{
	// Token: 0x020004CC RID: 1228
	[Token(Token = "0x20004CC")]
	[LuaCallCSharp(GenFlag.No)]
	public static class DOTweenExtensions
	{
		// Token: 0x06004DB4 RID: 19892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB4")]
		[Address(RVA = "0x187F920", Offset = "0x187E520", VA = "0x18187F920")]
		public static Tweener DOColorWithoutAlpha(this Image target, Color endValue, float duration)
		{
			return null;
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB5")]
		public static T SetIgnoreTimeScale<T>(this T tweener, bool ignoreTimeScale) where T : Tween
		{
			return null;
		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB6")]
		[Address(RVA = "0x187FAB0", Offset = "0x187E6B0", VA = "0x18187FAB0")]
		public static Tweener DoScrollHorzTo(this ScrollRect target, float horzPos, float duration)
		{
			return null;
		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB7")]
		[Address(RVA = "0x187FC30", Offset = "0x187E830", VA = "0x18187FC30")]
		public static Tweener DoScrollVertTo(this ScrollRect target, float vertPos, float duration)
		{
			return null;
		}

		// Token: 0x06004DB8 RID: 19896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB8")]
		public static Tween DisableAutoKillSafely<T>(this T t) where T : Tween
		{
			return null;
		}
	}
}
