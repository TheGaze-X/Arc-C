using System;
using System.Collections.Generic;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;

namespace DG.Tweening.Plugins.Core
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	internal static class PluginsManager
	{
		// Token: 0x06000386 RID: 902 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000386")]
		internal static ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>() where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000387")]
		public static ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>() where TPlugin : ITweenPlugin, new() where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x374FA50", Offset = "0x374E650", VA = "0x18374FA50")]
		internal static void PurgeAll()
		{
		}

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x0")]
		private static ITweenPlugin _floatPlugin;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x8")]
		private static ITweenPlugin _doublePlugin;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x10")]
		private static ITweenPlugin _intPlugin;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x18")]
		private static ITweenPlugin _uintPlugin;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x20")]
		private static ITweenPlugin _longPlugin;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x28")]
		private static ITweenPlugin _ulongPlugin;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x30")]
		private static ITweenPlugin _vector2Plugin;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x38")]
		private static ITweenPlugin _vector3Plugin;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x40")]
		private static ITweenPlugin _vector4Plugin;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x48")]
		private static ITweenPlugin _quaternionPlugin;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x50")]
		private static ITweenPlugin _colorPlugin;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x58")]
		private static ITweenPlugin _rectPlugin;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x60")]
		private static ITweenPlugin _rectOffsetPlugin;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x68")]
		private static ITweenPlugin _stringPlugin;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x70")]
		private static ITweenPlugin _vector3ArrayPlugin;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x78")]
		private static ITweenPlugin _color2Plugin;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		private const int _MaxCustomPlugins = 20;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x80")]
		private static Dictionary<Type, ITweenPlugin> _customPlugins;
	}
}
