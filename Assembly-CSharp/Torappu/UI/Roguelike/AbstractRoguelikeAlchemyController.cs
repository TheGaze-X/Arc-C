using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200519A RID: 20890
	[Token(Token = "0x200519A")]
	public abstract class AbstractRoguelikeAlchemyController : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601EDC4 RID: 126404
		[Token(Token = "0x601EDC4")]
		public abstract void OnInit();

		// Token: 0x0601EDC5 RID: 126405
		[Token(Token = "0x601EDC5")]
		public abstract void BindState(State state);

		// Token: 0x0601EDC6 RID: 126406
		[Token(Token = "0x601EDC6")]
		public abstract void OnStateResume();

		// Token: 0x0601EDC7 RID: 126407
		[Token(Token = "0x601EDC7")]
		public abstract IRoguelikeAlchemyViewModel GeneViewData(string topicId);

		// Token: 0x0601EDC8 RID: 126408
		[Token(Token = "0x601EDC8")]
		public abstract void OnMessage(int key, ValueBundle msg);

		// Token: 0x0601EDC9 RID: 126409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDC9")]
		[Address(RVA = "0x1896E40", Offset = "0x1895A40", VA = "0x181896E40")]
		protected AbstractRoguelikeAlchemyController()
		{
		}

		// Token: 0x04029675 RID: 169589
		[Token(Token = "0x4029675")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
