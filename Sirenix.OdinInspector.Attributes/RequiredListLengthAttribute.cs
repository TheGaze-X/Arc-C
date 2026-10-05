using System;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	public sealed class RequiredListLengthAttribute : Attribute
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000024D8 File Offset: 0x000006D8
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public int MinLength
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x4E19D90", Offset = "0x4E18990", VA = "0x184E19D90")]
			set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000024F0 File Offset: 0x000006F0
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000048")]
		public int MaxLength
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x4E19D80", Offset = "0x4E18980", VA = "0x184E19D80")]
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x17000049")]
		public bool MinLengthIsSet
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x1700004A")]
		public bool MaxLengthIsSet
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x4F61F0", Offset = "0x4F4DF0", VA = "0x1804F61F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x1700004B")]
		public bool PrefabKindIsSet
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00002550 File Offset: 0x00000750
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004C")]
		public PrefabKind PrefabKind
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return PrefabKind.None;
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x4E19420", Offset = "0x4E18020", VA = "0x184E19420")]
			set
			{
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RequiredListLengthAttribute()
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x4E19D00", Offset = "0x4E18900", VA = "0x184E19D00")]
		public RequiredListLengthAttribute(int fixedLength)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x4E19C70", Offset = "0x4E18870", VA = "0x184E19C70")]
		public RequiredListLengthAttribute(int minLength, int maxLength)
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x4E19CB0", Offset = "0x4E188B0", VA = "0x184E19CB0")]
		public RequiredListLengthAttribute(int minLength, string maxLengthGetter)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x4E19BE0", Offset = "0x4E187E0", VA = "0x184E19BE0")]
		public RequiredListLengthAttribute(string fixedLengthGetter)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x4E19C20", Offset = "0x4E18820", VA = "0x184E19C20")]
		public RequiredListLengthAttribute(string minLengthGetter, string maxLengthGetter)
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x4E19D30", Offset = "0x4E18930", VA = "0x184E19D30")]
		public RequiredListLengthAttribute(string minLengthGetter, int maxLength)
		{
		}

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x10")]
		private PrefabKind prefabKind;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x14")]
		private bool prefabKindIsSet;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x18")]
		private int minLength;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x1C")]
		private int maxLength;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x20")]
		private bool minLengthIsSet;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x21")]
		private bool maxLengthIsSet;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x28")]
		public string MinLengthGetter;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x30")]
		public string MaxLengthGetter;
	}
}
