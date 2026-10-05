using System;
using System.Collections;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x020017CF RID: 6095
	[Token(Token = "0x20017CF")]
	public interface IBuildingMode : StateMachine.IStateNode, IHotfixable
	{
		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06009A02 RID: 39426
		// (set) Token: 0x06009A03 RID: 39427
		[Token(Token = "0x170010B0")]
		bool isRaycastBlocked { [Token(Token = "0x6009A02")] get; [Token(Token = "0x6009A03")] set; }

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06009A04 RID: 39428
		[Token(Token = "0x170010B1")]
		RoomSlotModel selectedRoom { [Token(Token = "0x6009A04")] get; }

		// Token: 0x06009A05 RID: 39429
		[Token(Token = "0x6009A05")]
		void Register(BuildingStateMachine stateMachine);

		// Token: 0x06009A06 RID: 39430
		[Token(Token = "0x6009A06")]
		IEnumerator ShowCoroutine(BuildingStateMachine.TransitionParam param);

		// Token: 0x06009A07 RID: 39431
		[Token(Token = "0x6009A07")]
		IEnumerator HideCoroutine(BuildingStateMachine.TransitionParam param);
	}
}
