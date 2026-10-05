using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class ProgressBarAttribute : Attribute
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		[Obsolete("Use the MinGetter member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MinMember
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003C")]
		[Obsolete("Use the MaxGetter member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MaxMember
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003D")]
		[Obsolete("Use the ColorGetter member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ColorMember
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		[Obsolete("Use the BackgroundColorGetter member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string BackgroundColorMember
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the CustomValueStringGetter member instead.", false)]
		public string CustomValueStringMember
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			set
			{
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x4E19610", Offset = "0x4E18210", VA = "0x184E19610")]
		public ProgressBarAttribute(double min, double max, float r = 0.15f, float g = 0.47f, float b = 0.74f)
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x4E194E0", Offset = "0x4E180E0", VA = "0x184E194E0")]
		public ProgressBarAttribute(string minGetter, double max, float r = 0.15f, float g = 0.47f, float b = 0.74f)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x4E19450", Offset = "0x4E18050", VA = "0x184E19450")]
		public ProgressBarAttribute(double min, string maxGetter, float r = 0.15f, float g = 0.47f, float b = 0.74f)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x4E19570", Offset = "0x4E18170", VA = "0x184E19570")]
		public ProgressBarAttribute(string minGetter, string maxGetter, float r = 0.15f, float g = 0.47f, float b = 0.74f)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00002460 File Offset: 0x00000660
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000040")]
		public bool DrawValueLabel
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1A88D30", Offset = "0x1A87930", VA = "0x181A88D30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x4E196C0", Offset = "0x4E182C0", VA = "0x184E196C0")]
			set
			{
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00002478 File Offset: 0x00000678
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000041")]
		public bool DrawValueLabelHasValue
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xE31BB0", Offset = "0xE307B0", VA = "0x180E31BB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x4BA2FE0", Offset = "0x4BA1BE0", VA = "0x184BA2FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00002490 File Offset: 0x00000690
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		public TextAlignment ValueLabelAlignment
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x12905C0", Offset = "0x128F1C0", VA = "0x1812905C0")]
			get
			{
				return TextAlignment.Left;
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x4E196E0", Offset = "0x4E182E0", VA = "0x184E196E0")]
			set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000111 RID: 273 RVA: 0x000024A8 File Offset: 0x000006A8
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		public bool ValueLabelAlignmentHasValue
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0xE31BA0", Offset = "0xE307A0", VA = "0x180E31BA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x4E196D0", Offset = "0x4E182D0", VA = "0x184E196D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000113 RID: 275 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x17000044")]
		public Color Color
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x4E196A0", Offset = "0x4E182A0", VA = "0x184E196A0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x10")]
		public double Min;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x18")]
		public double Max;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x20")]
		public string MinGetter;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x28")]
		public string MaxGetter;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x30")]
		public float R;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x34")]
		public float G;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x38")]
		public float B;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x3C")]
		public int Height;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x40")]
		public string ColorGetter;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x48")]
		public string BackgroundColorGetter;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x50")]
		public bool Segmented;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x58")]
		public string CustomValueStringGetter;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x60")]
		private bool drawValueLabel;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x64")]
		private TextAlignment valueLabelAlignment;
	}
}
