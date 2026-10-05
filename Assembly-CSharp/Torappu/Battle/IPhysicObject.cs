using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002239 RID: 8761
	[Token(Token = "0x2002239")]
	public interface IPhysicObject
	{
		// Token: 0x0600DC24 RID: 56356
		[Token(Token = "0x600DC24")]
		void OnPhysicObjectInit();

		// Token: 0x0600DC25 RID: 56357
		[Token(Token = "0x600DC25")]
		void OnPhysicObjectRecycle();

		// Token: 0x0600DC26 RID: 56358
		[Token(Token = "0x600DC26")]
		void OnAfterPhysicSimulate(float fixedDeltaTime);
	}
}
