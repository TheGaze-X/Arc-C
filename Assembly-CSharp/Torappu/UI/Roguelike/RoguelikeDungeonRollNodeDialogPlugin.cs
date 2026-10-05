using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005279 RID: 21113
	[Token(Token = "0x2005279")]
	public abstract class RoguelikeDungeonRollNodeDialogPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F280 RID: 127616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F280")]
		[Address(RVA = "0x18E93A0", Offset = "0x18E7FA0", VA = "0x1818E93A0")]
		public void Init(RoguelikeDungeonRollNodeDialog closure)
		{
		}

		// Token: 0x0601F281 RID: 127617
		[Token(Token = "0x601F281")]
		public abstract void Render(RoguelikeDungeonRollNodeDialog.Options options);

		// Token: 0x0601F282 RID: 127618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F282")]
		[Address(RVA = "0x18E9420", Offset = "0x18E8020", VA = "0x1818E9420")]
		protected RoguelikeDungeonRollNodeDialogPlugin()
		{
		}

		// Token: 0x04029CDD RID: 171229
		[Token(Token = "0x4029CDD")]
		[FieldOffset(Offset = "0x18")]
		protected RoguelikeDungeonRollNodeDialog m_closure;

		// Token: 0x04029CDE RID: 171230
		[Token(Token = "0x4029CDE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04029CDF RID: 171231
		[Token(Token = "0x4029CDF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
