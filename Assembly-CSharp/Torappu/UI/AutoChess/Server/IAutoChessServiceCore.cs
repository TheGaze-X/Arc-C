using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x020063D4 RID: 25556
	[Token(Token = "0x20063D4")]
	public interface IAutoChessServiceCore
	{
		// Token: 0x06024D91 RID: 150929
		[Token(Token = "0x6024D91")]
		void TriggerEvent(AutoChessServiceEvent evt, [Optional] object arg);

		// Token: 0x06024D92 RID: 150930
		[Token(Token = "0x6024D92")]
		void RefreshStatus();

		// Token: 0x1700570A RID: 22282
		// (get) Token: 0x06024D93 RID: 150931
		[Token(Token = "0x1700570A")]
		IAutoChessServiceStepReceiver stepReceiver { [Token(Token = "0x6024D93")] get; }

		// Token: 0x1700570B RID: 22283
		// (get) Token: 0x06024D94 RID: 150932
		[Token(Token = "0x1700570B")]
		AutoChessServiceParam serviceParam { [Token(Token = "0x6024D94")] get; }
	}
}
