using System;
using Il2CppDummyDll;
using Torappu.DataBind;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054AC RID: 21676
	[Token(Token = "0x20054AC")]
	public class RoguelikeCharAttrViewProperty : DynamicBindProperty<RoguelikeCharAttrViewProperty, RoguelikeCharCardViewModel>
	{
		// Token: 0x0601FE3D RID: 130621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE3D")]
		[Address(RVA = "0x1A00280", Offset = "0x19FEE80", VA = "0x181A00280")]
		public RoguelikeCharAttrViewProperty()
		{
		}

		// Token: 0x0402B023 RID: 176163
		[Token(Token = "0x402B023")]
		[FieldOffset(Offset = "0x30")]
		public bool isSelected;
	}
}
