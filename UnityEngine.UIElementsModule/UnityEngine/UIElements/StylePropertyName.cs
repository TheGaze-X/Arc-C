using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	public struct StylePropertyName : IEquatable<StylePropertyName>
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x17000120")]
		internal readonly StylePropertyId id
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			[CompilerGenerated]
			get
			{
				return StylePropertyId.Unknown;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000121")]
		private readonly string name
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x5A8FA70", Offset = "0x5A8E670", VA = "0x185A8FA70")]
		internal static StylePropertyId StylePropertyIdFromString(string name)
		{
			return StylePropertyId.Unknown;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x5A8FBF0", Offset = "0x5A8E7F0", VA = "0x185A8FBF0")]
		internal StylePropertyName(StylePropertyId stylePropertyId)
		{
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x5A8FB10", Offset = "0x5A8E710", VA = "0x185A8FB10")]
		public StylePropertyName(string name)
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x5A8FA60", Offset = "0x5A8E660", VA = "0x185A8FA60")]
		public static bool operator ==(StylePropertyName lhs, StylePropertyName rhs)
		{
			return default(bool);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x5A8FCF0", Offset = "0x5A8E8F0", VA = "0x185A8FCF0")]
		public static bool operator !=(StylePropertyName lhs, StylePropertyName rhs)
		{
			return default(bool);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x5A8FCB0", Offset = "0x5A8E8B0", VA = "0x185A8FCB0")]
		public static implicit operator StylePropertyName(string name)
		{
			return default(StylePropertyName);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x5A8F9D0", Offset = "0x5A8E5D0", VA = "0x185A8F9D0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x5A8FA60", Offset = "0x5A8E660", VA = "0x185A8FA60", Slot = "4")]
		public bool Equals(StylePropertyName other)
		{
			return default(bool);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x5981B50", Offset = "0x5980750", VA = "0x185981B50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
