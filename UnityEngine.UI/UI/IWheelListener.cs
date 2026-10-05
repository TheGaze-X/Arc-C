using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	public interface IWheelListener
	{
		// Token: 0x060005A8 RID: 1448
		[Token(Token = "0x60005A8")]
		WheelSorting GetWheelSorting();

		// Token: 0x060005A9 RID: 1449
		[Token(Token = "0x60005A9")]
		Vector2 TreatValue(PointerEventData eventData);
	}
}
