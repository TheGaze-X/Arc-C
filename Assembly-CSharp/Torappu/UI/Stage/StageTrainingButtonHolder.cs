using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006995 RID: 27029
	[Token(Token = "0x2006995")]
	public class StageTrainingButtonHolder : StageButtonOnMapHolder
	{
		// Token: 0x17005B53 RID: 23379
		// (get) Token: 0x06026ACB RID: 158411 RVA: 0x000CBFA0 File Offset: 0x000CA1A0
		[Token(Token = "0x17005B53")]
		public bool isDependOnPrevious
		{
			[Token(Token = "0x6026ACB")]
			[Address(RVA = "0x21BC9C0", Offset = "0x21BB5C0", VA = "0x1821BC9C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06026ACC RID: 158412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ACC")]
		[Address(RVA = "0x21BC960", Offset = "0x21BB560", VA = "0x1821BC960")]
		public StageTrainingButtonHolder()
		{
		}

		// Token: 0x04036990 RID: 223632
		[Token(Token = "0x4036990")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _isDependOnPrevious;

		// Token: 0x04036991 RID: 223633
		[Token(Token = "0x4036991")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isDependOnPrevious;

		// Token: 0x04036992 RID: 223634
		[Token(Token = "0x4036992")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
