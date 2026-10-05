using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;

namespace Torappu.UI.ActivityPage
{
	// Token: 0x02006774 RID: 26484
	[Token(Token = "0x2006774")]
	public class AvgParam
	{
		// Token: 0x06025FE7 RID: 155623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FE7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AvgParam()
		{
		}

		// Token: 0x0403574F RID: 218959
		[Token(Token = "0x403574F")]
		[FieldOffset(Offset = "0x10")]
		public string operationKey;

		// Token: 0x04035750 RID: 218960
		[Token(Token = "0x4035750")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, GameObject> objectToRegister;

		// Token: 0x04035751 RID: 218961
		[Token(Token = "0x4035751")]
		[FieldOffset(Offset = "0x20")]
		public Action<Story> onStoryFinish;

		// Token: 0x04035752 RID: 218962
		[Token(Token = "0x4035752")]
		[FieldOffset(Offset = "0x28")]
		public Func<bool> triggerCondition;
	}
}
