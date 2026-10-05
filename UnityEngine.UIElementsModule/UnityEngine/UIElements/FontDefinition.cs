using System;
using Il2CppDummyDll;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	// Token: 0x02000222 RID: 546
	[Token(Token = "0x2000222")]
	public struct FontDefinition : IEquatable<FontDefinition>
	{
		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000391")]
		public Font font
		{
			[Token(Token = "0x6000F00")]
			[Address(RVA = "0x3BFB910", Offset = "0x3BFA510", VA = "0x183BFB910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000392")]
		public FontAsset fontAsset
		{
			[Token(Token = "0x6000F01")]
			[Address(RVA = "0x5981B50", Offset = "0x5980750", VA = "0x185981B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00007E30 File Offset: 0x00006030
		[Token(Token = "0x6000F02")]
		[Address(RVA = "0x5B07700", Offset = "0x5B06300", VA = "0x185B07700")]
		public static FontDefinition FromFont(Font f)
		{
			return default(FontDefinition);
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00007E48 File Offset: 0x00006048
		[Token(Token = "0x6000F03")]
		[Address(RVA = "0x5B078A0", Offset = "0x5B064A0", VA = "0x185B078A0")]
		public static FontDefinition FromSDFFont(FontAsset f)
		{
			return default(FontDefinition);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00007E60 File Offset: 0x00006060
		[Token(Token = "0x6000F04")]
		[Address(RVA = "0x5B07740", Offset = "0x5B06340", VA = "0x185B07740")]
		internal static FontDefinition FromObject(object obj)
		{
			return default(FontDefinition);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00007E78 File Offset: 0x00006078
		[Token(Token = "0x6000F05")]
		[Address(RVA = "0x5B07A00", Offset = "0x5B06600", VA = "0x185B07A00")]
		internal bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000F06")]
		[Address(RVA = "0x5B07A90", Offset = "0x5B06690", VA = "0x185B07A90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00007E90 File Offset: 0x00006090
		[Token(Token = "0x6000F07")]
		[Address(RVA = "0x5B076B0", Offset = "0x5B062B0", VA = "0x185B076B0", Slot = "4")]
		public bool Equals(FontDefinition other)
		{
			return default(bool);
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00007EA8 File Offset: 0x000060A8
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x5B07600", Offset = "0x5B06200", VA = "0x185B07600", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00007EC0 File Offset: 0x000060C0
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x5B078E0", Offset = "0x5B064E0", VA = "0x185B078E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00007ED8 File Offset: 0x000060D8
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x5B07B20", Offset = "0x5B06720", VA = "0x185B07B20")]
		public static bool operator ==(FontDefinition left, FontDefinition right)
		{
			return default(bool);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00007EF0 File Offset: 0x000060F0
		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x5B07B80", Offset = "0x5B06780", VA = "0x185B07B80")]
		public static bool operator !=(FontDefinition left, FontDefinition right)
		{
			return default(bool);
		}

		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		[FieldOffset(Offset = "0x0")]
		private Font m_Font;

		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		[FieldOffset(Offset = "0x8")]
		private FontAsset m_FontAsset;
	}
}
