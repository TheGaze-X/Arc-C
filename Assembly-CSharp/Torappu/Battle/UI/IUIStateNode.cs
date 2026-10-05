using System;
using Il2CppDummyDll;

namespace Torappu.Battle.UI
{
	// Token: 0x0200334F RID: 13135
	[Token(Token = "0x200334F")]
	public interface IUIStateNode : StateMachine.IStateNode
	{
		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x06014F5C RID: 85852
		[Token(Token = "0x170031B1")]
		UIStateEnum uiState { [Token(Token = "0x6014F5C")] get; }

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x06014F5D RID: 85853
		[Token(Token = "0x170031B2")]
		bool enablePause { [Token(Token = "0x6014F5D")] get; }

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x06014F5E RID: 85854
		[Token(Token = "0x170031B3")]
		bool enableSpeedSwitch { [Token(Token = "0x6014F5E")] get; }

		// Token: 0x170031B4 RID: 12724
		// (get) Token: 0x06014F5F RID: 85855
		[Token(Token = "0x170031B4")]
		bool enableShowRange { [Token(Token = "0x6014F5F")] get; }

		// Token: 0x170031B5 RID: 12725
		// (get) Token: 0x06014F60 RID: 85856
		[Token(Token = "0x170031B5")]
		bool enablePerspectiveCanvas { [Token(Token = "0x6014F60")] get; }

		// Token: 0x170031B6 RID: 12726
		// (get) Token: 0x06014F61 RID: 85857
		[Token(Token = "0x170031B6")]
		bool enableBackpress { [Token(Token = "0x6014F61")] get; }

		// Token: 0x170031B7 RID: 12727
		// (get) Token: 0x06014F62 RID: 85858
		[Token(Token = "0x170031B7")]
		bool enableCameraDrag { [Token(Token = "0x6014F62")] get; }

		// Token: 0x06014F63 RID: 85859
		[Token(Token = "0x6014F63")]
		void OnInit(UIStateEnum state, UIStateMachine stateMachine);
	}
}
