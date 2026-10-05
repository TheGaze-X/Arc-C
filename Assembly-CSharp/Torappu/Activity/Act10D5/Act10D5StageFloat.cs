using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B1D RID: 31517
	[Token(Token = "0x2007B1D")]
	public class Act10D5StageFloat : ActivityStageStateEngine
	{
		// Token: 0x0602C204 RID: 180740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C204")]
		[Address(RVA = "0x2809FF0", Offset = "0x2808BF0", VA = "0x182809FF0", Slot = "8")]
		public override IEnumerator LoadCoroutine()
		{
			return null;
		}

		// Token: 0x0602C205 RID: 180741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C205")]
		[Address(RVA = "0x280A0A0", Offset = "0x2808CA0", VA = "0x18280A0A0")]
		private IEnumerator _TryResumeStoryState()
		{
			return null;
		}

		// Token: 0x0602C206 RID: 180742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C206")]
		[Address(RVA = "0x280A150", Offset = "0x2808D50", VA = "0x18280A150")]
		public Act10D5StageFloat()
		{
		}

		// Token: 0x0602C208 RID: 180744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C208")]
		[Address(RVA = "0x24AE260", Offset = "0x24ACE60", VA = "0x1824AE260")]
		private IEnumerator <>xLuaBaseProxy_LoadCoroutine()
		{
			return null;
		}

		// Token: 0x0403FF86 RID: 262022
		[Token(Token = "0x403FF86")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadCoroutine;

		// Token: 0x0403FF87 RID: 262023
		[Token(Token = "0x403FF87")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryResumeStoryState;

		// Token: 0x0403FF88 RID: 262024
		[Token(Token = "0x403FF88")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
