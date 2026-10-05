using System;
using System.ComponentModel;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Composites
{
	// Token: 0x02000269 RID: 617
	[Token(Token = "0x2000269")]
	[DisplayStringFormat("{modifier}+{binding}")]
	[DisplayName("Binding With One Modifier")]
	public class OneModifierComposite : InputBindingComposite
	{
		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005ED")]
		public override Type valueType
		{
			[Token(Token = "0x6001632")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		[Token(Token = "0x170005EE")]
		public override int valueSizeInBytes
		{
			[Token(Token = "0x6001633")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x0000C000 File Offset: 0x0000A200
		[Token(Token = "0x6001634")]
		[Address(RVA = "0x5612620", Offset = "0x5611220", VA = "0x185612620", Slot = "8")]
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001635")]
		[Address(RVA = "0x5612810", Offset = "0x5611410", VA = "0x185612810", Slot = "6")]
		public unsafe override void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize)
		{
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x0000C018 File Offset: 0x0000A218
		[Token(Token = "0x6001636")]
		[Address(RVA = "0x5612750", Offset = "0x5611350", VA = "0x185612750")]
		private bool ModifierIsPressed(ref InputBindingCompositeContext context)
		{
			return default(bool);
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001637")]
		[Address(RVA = "0x56126B0", Offset = "0x56112B0", VA = "0x1856126B0", Slot = "9")]
		protected override void FinishSetup(ref InputBindingCompositeContext context)
		{
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001638")]
		[Address(RVA = "0x56127C0", Offset = "0x56113C0", VA = "0x1856127C0", Slot = "7")]
		public override object ReadValueAsObject(ref InputBindingCompositeContext context)
		{
			return null;
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001639")]
		[Address(RVA = "0x56121C0", Offset = "0x5610DC0", VA = "0x1856121C0")]
		internal static void DetermineValueTypeAndSize(ref InputBindingCompositeContext context, int part, out Type valueType, out int valueSizeInBytes, out bool isButton)
		{
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163A")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public OneModifierComposite()
		{
		}

		// Token: 0x04000C90 RID: 3216
		[Token(Token = "0x4000C90")]
		[FieldOffset(Offset = "0x10")]
		[InputControl(layout = "Button")]
		public int modifier;

		// Token: 0x04000C91 RID: 3217
		[Token(Token = "0x4000C91")]
		[FieldOffset(Offset = "0x14")]
		[InputControl]
		public int binding;

		// Token: 0x04000C92 RID: 3218
		[Token(Token = "0x4000C92")]
		[FieldOffset(Offset = "0x18")]
		public bool overrideModifiersNeedToBePressedFirst;

		// Token: 0x04000C93 RID: 3219
		[Token(Token = "0x4000C93")]
		[FieldOffset(Offset = "0x1C")]
		private int m_ValueSizeInBytes;

		// Token: 0x04000C94 RID: 3220
		[Token(Token = "0x4000C94")]
		[FieldOffset(Offset = "0x20")]
		private Type m_ValueType;

		// Token: 0x04000C95 RID: 3221
		[Token(Token = "0x4000C95")]
		[FieldOffset(Offset = "0x28")]
		private bool m_BindingIsButton;
	}
}
