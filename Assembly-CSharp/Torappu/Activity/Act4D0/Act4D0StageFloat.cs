using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x0200726D RID: 29293
	[Token(Token = "0x200726D")]
	public class Act4D0StageFloat : ActivityStageStateEngine
	{
		// Token: 0x06029802 RID: 169986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029802")]
		[Address(RVA = "0x24E18E0", Offset = "0x24E04E0", VA = "0x1824E18E0", Slot = "8")]
		public override IEnumerator LoadCoroutine()
		{
			return null;
		}

		// Token: 0x06029803 RID: 169987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029803")]
		[Address(RVA = "0x24E19C0", Offset = "0x24E05C0", VA = "0x1824E19C0")]
		private IEnumerator _TryResumeStoryState()
		{
			return null;
		}

		// Token: 0x06029804 RID: 169988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029804")]
		[Address(RVA = "0x24E1A70", Offset = "0x24E0670", VA = "0x1824E1A70")]
		public Act4D0StageFloat()
		{
		}

		// Token: 0x06029807 RID: 169991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029807")]
		[Address(RVA = "0x24AE260", Offset = "0x24ACE60", VA = "0x1824AE260")]
		private IEnumerator <>xLuaBaseProxy_LoadCoroutine()
		{
			return null;
		}

		// Token: 0x0403B4D5 RID: 242901
		[Token(Token = "0x403B4D5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _barContainer;

		// Token: 0x0403B4D6 RID: 242902
		[Token(Token = "0x403B4D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadCoroutine;

		// Token: 0x0403B4D7 RID: 242903
		[Token(Token = "0x403B4D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryResumeStoryState;

		// Token: 0x0403B4D8 RID: 242904
		[Token(Token = "0x403B4D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
