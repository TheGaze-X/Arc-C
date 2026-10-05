using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E75 RID: 15989
	[Token(Token = "0x2003E75")]
	public abstract class SpecialOperatorBoardLvlupDetailViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003B51 RID: 15185
		// (get) Token: 0x06018D9D RID: 101789
		[Token(Token = "0x17003B51")]
		public abstract SpecialOperatorDetailNodeType nodeType { [Token(Token = "0x6018D9D")] get; }

		// Token: 0x06018D9E RID: 101790
		[Token(Token = "0x6018D9E")]
		public abstract void SetViewShow(bool isShow);

		// Token: 0x06018D9F RID: 101791
		[Token(Token = "0x6018D9F")]
		public abstract void OnRender(SpecialOperatorBoardNodeBase nodeData, bool isEnter);

		// Token: 0x06018DA0 RID: 101792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DA0")]
		[Address(RVA = "0x1188EC0", Offset = "0x1187AC0", VA = "0x181188EC0")]
		protected SpecialOperatorBoardLvlupDetailViewBase()
		{
		}

		// Token: 0x0401E974 RID: 125300
		[Token(Token = "0x401E974")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
