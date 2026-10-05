using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY
{
	// Token: 0x0200188B RID: 6283
	[Token(Token = "0x200188B")]
	public interface IDIYRoomTemplate
	{
		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x06009EEA RID: 40682
		[Token(Token = "0x170011DD")]
		string id { [Token(Token = "0x6009EEA")] get; }

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x06009EEB RID: 40683
		[Token(Token = "0x170011DE")]
		int width { [Token(Token = "0x6009EEB")] get; }

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x06009EEC RID: 40684
		[Token(Token = "0x170011DF")]
		int height { [Token(Token = "0x6009EEC")] get; }

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06009EED RID: 40685
		[Token(Token = "0x170011E0")]
		int depth { [Token(Token = "0x6009EED")] get; }

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x06009EEE RID: 40686
		[Token(Token = "0x170011E1")]
		GameObject prefab { [Token(Token = "0x6009EEE")] get; }

		// Token: 0x06009EEF RID: 40687
		[Token(Token = "0x6009EEF")]
		void ForEachObstacle(Action<Obstacle> action);
	}
}
