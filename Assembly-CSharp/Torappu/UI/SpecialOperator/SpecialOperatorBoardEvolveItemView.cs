using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E87 RID: 16007
	[Token(Token = "0x2003E87")]
	public abstract class SpecialOperatorBoardEvolveItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018DE6 RID: 101862
		[Token(Token = "0x6018DE6")]
		public abstract SpecialOperatorBoardEvolveItemType GetItemType();

		// Token: 0x06018DE7 RID: 101863
		[Token(Token = "0x6018DE7")]
		public abstract void Render(ISpecialOperatorBoardEvolveItemViewModel viewModel, SpecialOperatorBoardEvolveItemView.Param param);

		// Token: 0x06018DE8 RID: 101864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DE8")]
		[Address(RVA = "0x1185F30", Offset = "0x1184B30", VA = "0x181185F30")]
		protected SpecialOperatorBoardEvolveItemView()
		{
		}

		// Token: 0x0401EA0A RID: 125450
		[Token(Token = "0x401EA0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E88 RID: 16008
		[Token(Token = "0x2003E88")]
		public struct Param
		{
			// Token: 0x0401EA0B RID: 125451
			[Token(Token = "0x401EA0B")]
			[FieldOffset(Offset = "0x0")]
			public bool isFastMode;

			// Token: 0x0401EA0C RID: 125452
			[Token(Token = "0x401EA0C")]
			[FieldOffset(Offset = "0x8")]
			public string selectedNodeId;
		}
	}
}
