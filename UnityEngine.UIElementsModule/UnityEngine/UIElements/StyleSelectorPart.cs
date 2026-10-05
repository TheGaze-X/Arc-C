using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200024F RID: 591
	[Token(Token = "0x200024F")]
	[Serializable]
	internal struct StyleSelectorPart
	{
		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700044B")]
		public string value
		{
			[Token(Token = "0x60010D9")]
			[Address(RVA = "0x3BFB910", Offset = "0x3BFA510", VA = "0x183BFB910")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x000092A0 File Offset: 0x000074A0
		// (set) Token: 0x060010DB RID: 4315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044C")]
		public StyleSelectorType type
		{
			[Token(Token = "0x60010DA")]
			[Address(RVA = "0x4226DD0", Offset = "0x42259D0", VA = "0x184226DD0")]
			get
			{
				return StyleSelectorType.Unknown;
			}
			[Token(Token = "0x60010DB")]
			[Address(RVA = "0x15EA020", Offset = "0x15E8C20", VA = "0x1815EA020")]
			internal set
			{
			}
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60010DC")]
		[Address(RVA = "0x5B21F60", Offset = "0x5B20B60", VA = "0x185B21F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x000092B8 File Offset: 0x000074B8
		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x5B21E50", Offset = "0x5B20A50", VA = "0x185B21E50")]
		public static StyleSelectorPart CreateClass(string className)
		{
			return default(StyleSelectorPart);
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x000092D0 File Offset: 0x000074D0
		[Token(Token = "0x60010DE")]
		[Address(RVA = "0x5B21EB0", Offset = "0x5B20AB0", VA = "0x185B21EB0")]
		public static StyleSelectorPart CreateId(string Id)
		{
			return default(StyleSelectorPart);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x000092E8 File Offset: 0x000074E8
		[Token(Token = "0x60010DF")]
		[Address(RVA = "0x5B21F10", Offset = "0x5B20B10", VA = "0x185B21F10")]
		public static StyleSelectorPart CreatePredicate(object predicate)
		{
			return default(StyleSelectorPart);
		}

		// Token: 0x040008A0 RID: 2208
		[Token(Token = "0x40008A0")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string m_Value;

		// Token: 0x040008A1 RID: 2209
		[Token(Token = "0x40008A1")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private StyleSelectorType m_Type;

		// Token: 0x040008A2 RID: 2210
		[Token(Token = "0x40008A2")]
		[FieldOffset(Offset = "0x10")]
		internal object tempData;
	}
}
