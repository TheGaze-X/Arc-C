using System;
using System.ComponentModel;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Composites
{
	// Token: 0x0200026A RID: 618
	[Token(Token = "0x200026A")]
	[DisplayName("Binding With Two Modifiers")]
	[DisplayStringFormat("{modifier1}+{modifier2}+{binding}")]
	public class TwoModifiersComposite : InputBindingComposite
	{
		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005EF")]
		public override Type valueType
		{
			[Token(Token = "0x600163B")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x0000C030 File Offset: 0x0000A230
		[Token(Token = "0x170005F0")]
		public override int valueSizeInBytes
		{
			[Token(Token = "0x600163C")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0000C048 File Offset: 0x0000A248
		[Token(Token = "0x600163D")]
		[Address(RVA = "0x56174B0", Offset = "0x56160B0", VA = "0x1856174B0", Slot = "8")]
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x56176C0", Offset = "0x56162C0", VA = "0x1856176C0", Slot = "6")]
		public unsafe override void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize)
		{
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0000C060 File Offset: 0x0000A260
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x56175A0", Offset = "0x56161A0", VA = "0x1856175A0")]
		private bool ModifiersArePressed(ref InputBindingCompositeContext context)
		{
			return default(bool);
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x5617500", Offset = "0x5616100", VA = "0x185617500", Slot = "9")]
		protected override void FinishSetup(ref InputBindingCompositeContext context)
		{
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001641")]
		[Address(RVA = "0x5617660", Offset = "0x5616260", VA = "0x185617660", Slot = "7")]
		public override object ReadValueAsObject(ref InputBindingCompositeContext context)
		{
			return null;
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001642")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public TwoModifiersComposite()
		{
		}

		// Token: 0x04000C96 RID: 3222
		[Token(Token = "0x4000C96")]
		[FieldOffset(Offset = "0x10")]
		[InputControl(layout = "Button")]
		public int modifier1;

		// Token: 0x04000C97 RID: 3223
		[Token(Token = "0x4000C97")]
		[FieldOffset(Offset = "0x14")]
		[InputControl(layout = "Button")]
		public int modifier2;

		// Token: 0x04000C98 RID: 3224
		[Token(Token = "0x4000C98")]
		[FieldOffset(Offset = "0x18")]
		[InputControl]
		public int binding;

		// Token: 0x04000C99 RID: 3225
		[Token(Token = "0x4000C99")]
		[FieldOffset(Offset = "0x1C")]
		public bool overrideModifiersNeedToBePressedFirst;

		// Token: 0x04000C9A RID: 3226
		[Token(Token = "0x4000C9A")]
		[FieldOffset(Offset = "0x20")]
		private int m_ValueSizeInBytes;

		// Token: 0x04000C9B RID: 3227
		[Token(Token = "0x4000C9B")]
		[FieldOffset(Offset = "0x28")]
		private Type m_ValueType;

		// Token: 0x04000C9C RID: 3228
		[Token(Token = "0x4000C9C")]
		[FieldOffset(Offset = "0x30")]
		private bool m_BindingIsButton;
	}
}
