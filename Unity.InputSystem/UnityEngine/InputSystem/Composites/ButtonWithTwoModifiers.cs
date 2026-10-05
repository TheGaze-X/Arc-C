using System;
using System.ComponentModel;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Composites
{
	// Token: 0x02000268 RID: 616
	[Token(Token = "0x2000268")]
	[DisplayStringFormat("{modifier1}+{modifier2}+{button}")]
	[DesignTimeVisible(false)]
	public class ButtonWithTwoModifiers : InputBindingComposite<float>
	{
		// Token: 0x0600162D RID: 5677 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		[Token(Token = "0x600162D")]
		[Address(RVA = "0x560F2B0", Offset = "0x560DEB0", VA = "0x18560F2B0", Slot = "10")]
		public override float ReadValue(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x560F1F0", Offset = "0x560DDF0", VA = "0x18560F1F0")]
		private bool ModifiersArePressed(ref InputBindingCompositeContext context)
		{
			return default(bool);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		[Token(Token = "0x600162F")]
		[Address(RVA = "0x560EF60", Offset = "0x560DB60", VA = "0x18560EF60", Slot = "8")]
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001630")]
		[Address(RVA = "0x560F180", Offset = "0x560DD80", VA = "0x18560F180", Slot = "9")]
		protected override void FinishSetup(ref InputBindingCompositeContext context)
		{
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001631")]
		[Address(RVA = "0x560F390", Offset = "0x560DF90", VA = "0x18560F390")]
		public ButtonWithTwoModifiers()
		{
		}

		// Token: 0x04000C8C RID: 3212
		[Token(Token = "0x4000C8C")]
		[FieldOffset(Offset = "0x10")]
		[InputControl(layout = "Button")]
		public int modifier1;

		// Token: 0x04000C8D RID: 3213
		[Token(Token = "0x4000C8D")]
		[FieldOffset(Offset = "0x14")]
		[InputControl(layout = "Button")]
		public int modifier2;

		// Token: 0x04000C8E RID: 3214
		[Token(Token = "0x4000C8E")]
		[FieldOffset(Offset = "0x18")]
		[InputControl(layout = "Button")]
		public int button;

		// Token: 0x04000C8F RID: 3215
		[Token(Token = "0x4000C8F")]
		[FieldOffset(Offset = "0x1C")]
		public bool overrideModifiersNeedToBePressedFirst;
	}
}
