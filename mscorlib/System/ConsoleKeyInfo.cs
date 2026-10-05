using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200015E RID: 350
	[Token(Token = "0x200015E")]
	[System.Serializable]
	public readonly struct ConsoleKeyInfo
	{
		// Token: 0x06000C77 RID: 3191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x4CF4BC0", Offset = "0x4CF37C0", VA = "0x184CF4BC0")]
		public ConsoleKeyInfo(char keyChar, System.ConsoleKey key, bool shift, bool alt, bool control)
		{
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0000BF70 File Offset: 0x0000A170
		[Token(Token = "0x1700010F")]
		public char KeyChar
		{
			[Token(Token = "0x6000C78")]
			[Address(RVA = "0x3D28B50", Offset = "0x3D27750", VA = "0x183D28B50")]
			get
			{
				return '\0';
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x0000BF88 File Offset: 0x0000A188
		[Token(Token = "0x17000110")]
		public System.ConsoleKey Key
		{
			[Token(Token = "0x6000C79")]
			[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
			get
			{
				return (System.ConsoleKey)0;
			}
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x4CF4AF0", Offset = "0x4CF36F0", VA = "0x184CF4AF0", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x4CF4AD0", Offset = "0x4CF36D0", VA = "0x184CF4AD0")]
		public bool Equals(System.ConsoleKeyInfo obj)
		{
			return default(bool);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x4CF4BA0", Offset = "0x4CF37A0", VA = "0x184CF4BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x0")]
		private readonly char _keyChar;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x4")]
		private readonly System.ConsoleKey _key;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x8")]
		private readonly System.ConsoleModifiers _mods;
	}
}
