using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public interface IInputInteraction
	{
		// Token: 0x0600012B RID: 299
		[Token(Token = "0x600012B")]
		void Process(ref InputInteractionContext context);

		// Token: 0x0600012C RID: 300
		[Token(Token = "0x600012C")]
		void Reset();
	}
}
