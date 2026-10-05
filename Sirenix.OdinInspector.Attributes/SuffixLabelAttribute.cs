using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
	public sealed class SuffixLabelAttribute : Attribute
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00002580 File Offset: 0x00000780
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		public SdfIconType Icon
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return SdfIconType.None;
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x4E1B100", Offset = "0x4E19D00", VA = "0x184E1B100")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002598 File Offset: 0x00000798
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000052")]
		public bool HasDefinedIcon
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x4CEC6B0", Offset = "0x4CEB2B0", VA = "0x184CEC6B0")]
		public SuffixLabelAttribute(string label, bool overlay = false)
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x4E1B0A0", Offset = "0x4E19CA0", VA = "0x184E1B0A0")]
		public SuffixLabelAttribute(string label, SdfIconType icon, bool overlay = false)
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x4E1B070", Offset = "0x4E19C70", VA = "0x184E1B070")]
		public SuffixLabelAttribute(SdfIconType icon)
		{
		}

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x10")]
		public string Label;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x18")]
		public bool Overlay;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x20")]
		public string IconColor;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x2C")]
		private SdfIconType icon;
	}
}
