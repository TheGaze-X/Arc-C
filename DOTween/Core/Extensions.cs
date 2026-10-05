using System;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;

namespace DG.Tweening.Core
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	public static class Extensions
	{
		// Token: 0x0600041A RID: 1050 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600041A")]
		public static T SetSpecialStartupMode<T>(this T t, SpecialStartupMode mode) where T : Tween
		{
			return null;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600041B")]
		public static TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600041C")]
		public static TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}
	}
}
