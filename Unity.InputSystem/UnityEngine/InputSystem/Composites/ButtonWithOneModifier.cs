using System;
using System.ComponentModel;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Composites
{
	// Token: 0x02000267 RID: 615
	[Token(Token = "0x2000267")]
	[DesignTimeVisible(false)]
	[DisplayStringFormat("{modifier}+{button}")]
	public class ButtonWithOneModifier : InputBindingComposite<float>
	{
		// Token: 0x06001628 RID: 5672 RVA: 0x0000BF58 File Offset: 0x0000A158
		[Token(Token = "0x6001628")]
		[Address(RVA = "0x560F090", Offset = "0x560DC90", VA = "0x18560F090", Slot = "10")]
		public override float ReadValue(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x0000BF70 File Offset: 0x0000A170
		[Token(Token = "0x6001629")]
		[Address(RVA = "0x560F020", Offset = "0x560DC20", VA = "0x18560F020")]
		private bool ModifierIsPressed(ref InputBindingCompositeContext context)
		{
			return default(bool);
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0000BF88 File Offset: 0x0000A188
		[Token(Token = "0x600162A")]
		[Address(RVA = "0x560EF60", Offset = "0x560DB60", VA = "0x18560EF60", Slot = "8")]
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162B")]
		[Address(RVA = "0x560EFB0", Offset = "0x560DBB0", VA = "0x18560EFB0", Slot = "9")]
		protected override void FinishSetup(ref InputBindingCompositeContext context)
		{
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162C")]
		[Address(RVA = "0x560F140", Offset = "0x560DD40", VA = "0x18560F140")]
		public ButtonWithOneModifier()
		{
		}

		// Token: 0x04000C89 RID: 3209
		[Token(Token = "0x4000C89")]
		[FieldOffset(Offset = "0x10")]
		[InputControl(layout = "Button")]
		public int modifier;

		// Token: 0x04000C8A RID: 3210
		[Token(Token = "0x4000C8A")]
		[FieldOffset(Offset = "0x14")]
		[InputControl(layout = "Button")]
		public int button;

		// Token: 0x04000C8B RID: 3211
		[Token(Token = "0x4000C8B")]
		[FieldOffset(Offset = "0x18")]
		public bool overrideModifiersNeedToBePressedFirst;
	}
}
