using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052AC RID: 21164
	[Token(Token = "0x20052AC")]
	public abstract class RoguelikeEndingCharItemViewPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F38E RID: 127886
		[Token(Token = "0x601F38E")]
		public abstract void Render(string topicId, RoguelikeCharCardViewModel viewModel);

		// Token: 0x0601F38F RID: 127887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F38F")]
		[Address(RVA = "0x18EA1C0", Offset = "0x18E8DC0", VA = "0x1818EA1C0")]
		protected RoguelikeEndingCharItemViewPlugin()
		{
		}

		// Token: 0x04029ECF RID: 171727
		[Token(Token = "0x4029ECF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
