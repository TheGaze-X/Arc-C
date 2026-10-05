using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class FoldoutGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002208 File Offset: 0x00000408
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000018")]
		public bool Expanded
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x4E18230", Offset = "0x4E16E30", VA = "0x184E18230")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002220 File Offset: 0x00000420
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		public bool HasDefinedExpanded
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x4FD480", Offset = "0x4FC080", VA = "0x1804FD480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x3249520", Offset = "0x3248120", VA = "0x183249520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x4E17B10", Offset = "0x4E16710", VA = "0x184E17B10")]
		public FoldoutGroupAttribute(string groupName, float order = 0f)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x4E18180", Offset = "0x4E16D80", VA = "0x184E18180")]
		public FoldoutGroupAttribute(string groupName, bool expanded, float order = 0f)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x4E180C0", Offset = "0x4E16CC0", VA = "0x184E180C0", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x38")]
		private bool expanded;
	}
}
