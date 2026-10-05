using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000156 RID: 342
	[Token(Token = "0x2000156")]
	public class Toggle : BaseBoolField
	{
		// Token: 0x060009C7 RID: 2503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x5ACC590", Offset = "0x5ACB190", VA = "0x185ACC590")]
		public Toggle()
		{
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x5ACC470", Offset = "0x5ACB070", VA = "0x185ACC470")]
		public Toggle(string label)
		{
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x5ACC1D0", Offset = "0x5ACADD0", VA = "0x185ACC1D0", Slot = "108")]
		protected override void InitLabel()
		{
		}

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string ussClassName;

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x8")]
		public new static readonly string labelUssClassName;

		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x10")]
		public new static readonly string inputUssClassName;

		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000556")]
		[FieldOffset(Offset = "0x18")]
		[Obsolete]
		public static readonly string noTextVariantUssClassName;

		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000557")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string checkmarkUssClassName;

		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string textUssClassName;

		// Token: 0x02000157 RID: 343
		[Token(Token = "0x2000157")]
		public new class UxmlFactory : UxmlFactory<Toggle, Toggle.UxmlTraits>
		{
			// Token: 0x060009CB RID: 2507 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x5AD2CF0", Offset = "0x5AD18F0", VA = "0x185AD2CF0")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000158 RID: 344
		[Token(Token = "0x2000158")]
		public new class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription>
		{
			// Token: 0x060009CC RID: 2508 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x5AD2FB0", Offset = "0x5AD1BB0", VA = "0x185AD2FB0", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x060009CD RID: 2509 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x5AD7030", Offset = "0x5AD5C30", VA = "0x185AD7030")]
			public UxmlTraits()
			{
			}

			// Token: 0x04000559 RID: 1369
			[Token(Token = "0x4000559")]
			[FieldOffset(Offset = "0x88")]
			private UxmlStringAttributeDescription m_Text;
		}
	}
}
