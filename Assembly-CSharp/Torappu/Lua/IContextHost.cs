using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Lua
{
	// Token: 0x02001609 RID: 5641
	[Token(Token = "0x2001609")]
	public interface IContextHost
	{
		// Token: 0x06008007 RID: 32775
		[Token(Token = "0x6008007")]
		T LoadAsset<T>(string path) where T : UnityEngine.Object;

		// Token: 0x06008008 RID: 32776
		[Token(Token = "0x6008008")]
		void UnloadAsset(UnityEngine.Object asset);

		// Token: 0x06008009 RID: 32777
		[Token(Token = "0x6008009")]
		void OnLeaveContext();

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x0600800A RID: 32778
		[Token(Token = "0x17000F2A")]
		Transform root { [Token(Token = "0x600800A")] get; }

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x0600800B RID: 32779
		[Token(Token = "0x17000F2B")]
		string mainDialog { [Token(Token = "0x600800B")] get; }

		// Token: 0x0600800C RID: 32780
		[Token(Token = "0x600800C")]
		IDictionary<string, Type> CompDeclaration();

		// Token: 0x0600800D RID: 32781
		[Token(Token = "0x600800D")]
		UnityEngine.Object UICompDialogHost();
	}
}
