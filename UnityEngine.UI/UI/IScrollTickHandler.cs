using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	public interface IScrollTickHandler
	{
		// Token: 0x0600058D RID: 1421
		[Token(Token = "0x600058D")]
		void Init(Action<Vector2> onMove);

		// Token: 0x0600058E RID: 1422
		[Token(Token = "0x600058E")]
		void AddVelocity(Vector2 acceleration);

		// Token: 0x0600058F RID: 1423
		[Token(Token = "0x600058F")]
		void Interrupt();

		// Token: 0x06000590 RID: 1424
		[Token(Token = "0x6000590")]
		void Tick(float deltaTime);

		// Token: 0x06000591 RID: 1425
		[Token(Token = "0x6000591")]
		bool IsScrolling();
	}
}
