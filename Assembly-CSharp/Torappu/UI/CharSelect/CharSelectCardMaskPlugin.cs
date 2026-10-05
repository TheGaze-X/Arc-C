using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E1E RID: 24094
	[Token(Token = "0x2005E1E")]
	public abstract class CharSelectCardMaskPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022E9E RID: 143006
		[Token(Token = "0x6022E9E")]
		public abstract void Init(CharSelectCardView cardView, CharSelectStateBean stateBean, object context);

		// Token: 0x06022E9F RID: 143007
		[Token(Token = "0x6022E9F")]
		public abstract void Render(CharacterCardViewModel cardModel);

		// Token: 0x06022EA0 RID: 143008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EA0")]
		[Address(RVA = "0x1D662B0", Offset = "0x1D64EB0", VA = "0x181D662B0")]
		protected CharSelectCardMaskPlugin()
		{
		}

		// Token: 0x0403016E RID: 196974
		[Token(Token = "0x403016E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
