using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EB7 RID: 7863
	[Token(Token = "0x2001EB7")]
	public class AVGTheaterLabel : ExecutorComponent
	{
		// Token: 0x0600C2CD RID: 49869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C2CD")]
		[Address(RVA = "0x33FFA00", Offset = "0x33FE600", VA = "0x1833FFA00", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C2CE RID: 49870 RVA: 0x000478B0 File Offset: 0x00045AB0
		[Token(Token = "0x600C2CE")]
		[Address(RVA = "0x33FFB20", Offset = "0x33FE720", VA = "0x1833FFB20")]
		private bool _ExecuteTheaterNode(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C2CF RID: 49871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2CF")]
		[Address(RVA = "0x33FF9A0", Offset = "0x33FE5A0", VA = "0x1833FF9A0", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C2D0 RID: 49872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2D0")]
		[Address(RVA = "0x33FFC20", Offset = "0x33FE820", VA = "0x1833FFC20")]
		public AVGTheaterLabel()
		{
		}

		// Token: 0x0400C4C4 RID: 50372
		[Token(Token = "0x400C4C4")]
		private const string COMMAND_NAME_THREATER_MODE = "theater";

		// Token: 0x0400C4C5 RID: 50373
		[Token(Token = "0x400C4C5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AVGController _avgController;

		// Token: 0x0400C4C6 RID: 50374
		[Token(Token = "0x400C4C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C4C7 RID: 50375
		[Token(Token = "0x400C4C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ExecuteTheaterNode;

		// Token: 0x0400C4C8 RID: 50376
		[Token(Token = "0x400C4C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C4C9 RID: 50377
		[Token(Token = "0x400C4C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
