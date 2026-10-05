using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	public struct TextShadow : IEquatable<TextShadow>
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x5A913F0", Offset = "0x5A8FFF0", VA = "0x185A913F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x5A914A0", Offset = "0x5A900A0", VA = "0x185A914A0", Slot = "4")]
		public bool Equals(TextShadow other)
		{
			return default(bool);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x5A91580", Offset = "0x5A90180", VA = "0x185A91580", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x5A918A0", Offset = "0x5A904A0", VA = "0x185A918A0")]
		public static bool operator ==(TextShadow style1, TextShadow style2)
		{
			return default(bool);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x5A918D0", Offset = "0x5A904D0", VA = "0x185A918D0")]
		public static bool operator !=(TextShadow style1, TextShadow style2)
		{
			return default(bool);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x5A917C0", Offset = "0x5A903C0", VA = "0x185A917C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x5A91670", Offset = "0x5A90270", VA = "0x185A91670")]
		internal static TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t)
		{
			return default(TextShadow);
		}

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 offset;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x8")]
		public float blurRadius;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0xC")]
		public Color color;
	}
}
