using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000535 RID: 1333
	[Token(Token = "0x2000535")]
	public interface IKeyMoveHandler
	{
		// Token: 0x06004FC1 RID: 20417
		[Token(Token = "0x6004FC1")]
		void OnMove(Vector2 move);

		// Token: 0x06004FC2 RID: 20418
		[Token(Token = "0x6004FC2")]
		void OnStop();

		// Token: 0x06004FC3 RID: 20419
		[Token(Token = "0x6004FC3")]
		int GetInstId();
	}
}
