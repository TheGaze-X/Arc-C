using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
	[IncludeMyAttributes]
	public class ButtonGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		public IconAlignment IconAlignment
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			get
			{
				return IconAlignment.LeftOfText;
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x4E17BD0", Offset = "0x4E167D0", VA = "0x184E17BD0")]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002178 File Offset: 0x00000378
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000E")]
		public int ButtonAlignment
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x1793F50", Offset = "0x1792B50", VA = "0x181793F50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x4E17BB0", Offset = "0x4E167B0", VA = "0x184E17BB0")]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002190 File Offset: 0x00000390
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		public bool Stretch
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x4E17BE0", Offset = "0x4E167E0", VA = "0x184E17BE0")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000021A8 File Offset: 0x000003A8
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public bool HasDefinedButtonIconAlignment
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1DBF210", Offset = "0x1DBDE10", VA = "0x181DBF210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1DBF2F0", Offset = "0x1DBDEF0", VA = "0x181DBF2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000021C0 File Offset: 0x000003C0
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public bool HasDefinedButtonAlignment
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x4A55A10", Offset = "0x4A54610", VA = "0x184A55A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x4A55E70", Offset = "0x4A54A70", VA = "0x184A55E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000021D8 File Offset: 0x000003D8
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public bool HasDefinedStretch
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x4E17BA0", Offset = "0x4E167A0", VA = "0x184E17BA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x4E17BC0", Offset = "0x4E167C0", VA = "0x184E17BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x4E17B10", Offset = "0x4E16710", VA = "0x184E17B10")]
		public ButtonGroupAttribute(string group = "_DefaultGroup", float order = 0f)
		{
		}

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x38")]
		public int ButtonHeight;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x40")]
		private IconAlignment buttonIconAlignment;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x44")]
		private int buttonAlignment;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x48")]
		private bool stretch;
	}
}
