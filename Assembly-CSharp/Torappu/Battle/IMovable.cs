using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200221E RID: 8734
	[Token(Token = "0x200221E")]
	public interface IMovable : ILocatable
	{
		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x0600DBF2 RID: 56306
		[Token(Token = "0x17001BB5")]
		float moveSpeed { [Token(Token = "0x600DBF2")] get; }

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x0600DBF3 RID: 56307
		[Token(Token = "0x17001BB6")]
		MotionMode pathMotionMode { [Token(Token = "0x600DBF3")] get; }

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x0600DBF4 RID: 56308
		[Token(Token = "0x17001BB7")]
		SideType side { [Token(Token = "0x600DBF4")] get; }

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x0600DBF5 RID: 56309
		[Token(Token = "0x17001BB8")]
		Vector2 footMapPosition { [Token(Token = "0x600DBF5")] get; }

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x0600DBF6 RID: 56310
		[Token(Token = "0x17001BB9")]
		Vector2 offsetMapPosition { [Token(Token = "0x600DBF6")] get; }

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x0600DBF7 RID: 56311
		[Token(Token = "0x17001BBA")]
		bool canMove { [Token(Token = "0x600DBF7")] get; }
	}
}
