using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.Utilities
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	public static class GUILayoutOptions
	{
		// Token: 0x060002C7 RID: 711 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x4E23540", Offset = "0x4E22140", VA = "0x184E23540")]
		public static GUILayoutOptions.GUILayoutOptionsInstance Width(float width)
		{
			return null;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x4E231D0", Offset = "0x4E21DD0", VA = "0x184E231D0")]
		public static GUILayoutOptions.GUILayoutOptionsInstance Height(float height)
		{
			return null;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x4E23280", Offset = "0x4E21E80", VA = "0x184E23280")]
		public static GUILayoutOptions.GUILayoutOptionsInstance MaxHeight(float height)
		{
			return null;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x4E23330", Offset = "0x4E21F30", VA = "0x184E23330")]
		public static GUILayoutOptions.GUILayoutOptionsInstance MaxWidth(float width)
		{
			return null;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x4E23490", Offset = "0x4E22090", VA = "0x184E23490")]
		public static GUILayoutOptions.GUILayoutOptionsInstance MinWidth(float width)
		{
			return null;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x4E233E0", Offset = "0x4E21FE0", VA = "0x184E233E0")]
		public static GUILayoutOptions.GUILayoutOptionsInstance MinHeight(float height)
		{
			return null;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x4E23070", Offset = "0x4E21C70", VA = "0x184E23070")]
		public static GUILayoutOptions.GUILayoutOptionsInstance ExpandHeight(bool expand = true)
		{
			return null;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x4E23120", Offset = "0x4E21D20", VA = "0x184E23120")]
		public static GUILayoutOptions.GUILayoutOptionsInstance ExpandWidth(bool expand = true)
		{
			return null;
		}

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x0")]
		private static int CurrentCacheIndex;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x8")]
		private static readonly GUILayoutOptions.GUILayoutOptionsInstance[] GUILayoutOptionsInstanceCache;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<GUILayoutOptions.GUILayoutOptionsInstance, GUILayoutOption[]> GUILayoutOptionsCache;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x18")]
		public static readonly GUILayoutOption[] EmptyGUIOptions;

		// Token: 0x0200006D RID: 109
		[Token(Token = "0x200006D")]
		internal enum GUILayoutOptionType
		{
			// Token: 0x040001A4 RID: 420
			[Token(Token = "0x40001A4")]
			Width,
			// Token: 0x040001A5 RID: 421
			[Token(Token = "0x40001A5")]
			Height,
			// Token: 0x040001A6 RID: 422
			[Token(Token = "0x40001A6")]
			MinWidth,
			// Token: 0x040001A7 RID: 423
			[Token(Token = "0x40001A7")]
			MaxHeight,
			// Token: 0x040001A8 RID: 424
			[Token(Token = "0x40001A8")]
			MaxWidth,
			// Token: 0x040001A9 RID: 425
			[Token(Token = "0x40001A9")]
			MinHeight,
			// Token: 0x040001AA RID: 426
			[Token(Token = "0x40001AA")]
			ExpandHeight,
			// Token: 0x040001AB RID: 427
			[Token(Token = "0x40001AB")]
			ExpandWidth
		}

		// Token: 0x0200006E RID: 110
		[Token(Token = "0x200006E")]
		public sealed class GUILayoutOptionsInstance : IEquatable<GUILayoutOptions.GUILayoutOptionsInstance>
		{
			// Token: 0x060002CF RID: 719 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x4E22870", Offset = "0x4E21470", VA = "0x184E22870")]
			private GUILayoutOption[] GetCachedOptions()
			{
				return null;
			}

			// Token: 0x060002D0 RID: 720 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x4E22E70", Offset = "0x4E21A70", VA = "0x184E22E70")]
			public static implicit operator GUILayoutOption[](GUILayoutOptions.GUILayoutOptionsInstance options)
			{
				return null;
			}

			// Token: 0x060002D1 RID: 721 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x4E22560", Offset = "0x4E21160", VA = "0x184E22560")]
			private GUILayoutOption[] CreateOptionsArary()
			{
				return null;
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x4E22480", Offset = "0x4E21080", VA = "0x184E22480")]
			private GUILayoutOptions.GUILayoutOptionsInstance Clone()
			{
				return null;
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			internal GUILayoutOptionsInstance()
			{
			}

			// Token: 0x060002D4 RID: 724 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x4E22DE0", Offset = "0x4E219E0", VA = "0x184E22DE0")]
			public GUILayoutOptions.GUILayoutOptionsInstance Width(float width)
			{
				return null;
			}

			// Token: 0x060002D5 RID: 725 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x4E22AE0", Offset = "0x4E216E0", VA = "0x184E22AE0")]
			public GUILayoutOptions.GUILayoutOptionsInstance Height(float height)
			{
				return null;
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x4E22B70", Offset = "0x4E21770", VA = "0x184E22B70")]
			public GUILayoutOptions.GUILayoutOptionsInstance MaxHeight(float height)
			{
				return null;
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x4E22C00", Offset = "0x4E21800", VA = "0x184E22C00")]
			public GUILayoutOptions.GUILayoutOptionsInstance MaxWidth(float width)
			{
				return null;
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x4E22C90", Offset = "0x4E21890", VA = "0x184E22C90")]
			public GUILayoutOptions.GUILayoutOptionsInstance MinHeight(float height)
			{
				return null;
			}

			// Token: 0x060002D9 RID: 729 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x4E22D20", Offset = "0x4E21920", VA = "0x184E22D20")]
			public GUILayoutOptions.GUILayoutOptionsInstance MinWidth(float width)
			{
				return null;
			}

			// Token: 0x060002DA RID: 730 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x4E22750", Offset = "0x4E21350", VA = "0x184E22750")]
			public GUILayoutOptions.GUILayoutOptionsInstance ExpandHeight(bool expand = true)
			{
				return null;
			}

			// Token: 0x060002DB RID: 731 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x4E227E0", Offset = "0x4E213E0", VA = "0x184E227E0")]
			public GUILayoutOptions.GUILayoutOptionsInstance ExpandWidth(bool expand = true)
			{
				return null;
			}

			// Token: 0x060002DC RID: 732 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x4E22DD0", Offset = "0x4E219D0", VA = "0x184E22DD0")]
			internal void SetValue(GUILayoutOptions.GUILayoutOptionType type, float value)
			{
			}

			// Token: 0x060002DD RID: 733 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x4E22DB0", Offset = "0x4E219B0", VA = "0x184E22DB0")]
			internal void SetValue(GUILayoutOptions.GUILayoutOptionType type, bool value)
			{
			}

			// Token: 0x060002DE RID: 734 RVA: 0x0000317C File Offset: 0x0000137C
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x4E226F0", Offset = "0x4E212F0", VA = "0x184E226F0", Slot = "4")]
			public bool Equals(GUILayoutOptions.GUILayoutOptionsInstance other)
			{
				return default(bool);
			}

			// Token: 0x060002DF RID: 735 RVA: 0x00003194 File Offset: 0x00001394
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x4E22A50", Offset = "0x4E21650", VA = "0x184E22A50", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x040001AC RID: 428
			[Token(Token = "0x40001AC")]
			[FieldOffset(Offset = "0x10")]
			private float value;

			// Token: 0x040001AD RID: 429
			[Token(Token = "0x40001AD")]
			[FieldOffset(Offset = "0x18")]
			internal GUILayoutOptions.GUILayoutOptionsInstance Parent;

			// Token: 0x040001AE RID: 430
			[Token(Token = "0x40001AE")]
			[FieldOffset(Offset = "0x20")]
			internal GUILayoutOptions.GUILayoutOptionType GUILayoutOptionType;
		}
	}
}
