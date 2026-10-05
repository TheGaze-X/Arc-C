using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F2D RID: 28461
	[Token(Token = "0x2006F2D")]
	public class ActMultiV3EntryStageViewModel : IHotfixable
	{
		// Token: 0x060286DC RID: 165596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286DC")]
		[Address(RVA = "0x23AF450", Offset = "0x23AE050", VA = "0x1823AF450")]
		public void LoadData(string actId, PlayerActivity.PlayerMultiV3Activity playerActivity, ActMultiV3Data actData)
		{
		}

		// Token: 0x060286DD RID: 165597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286DD")]
		[Address(RVA = "0x23AF930", Offset = "0x23AE530", VA = "0x1823AF930")]
		public ActMultiV3EntryStageViewModel()
		{
		}

		// Token: 0x04039800 RID: 235520
		[Token(Token = "0x4039800")]
		[FieldOffset(Offset = "0x10")]
		public bool hasNewUnlockedStage;

		// Token: 0x04039801 RID: 235521
		[Token(Token = "0x4039801")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ActMultiV3StageItemViewModel> stages;

		// Token: 0x04039802 RID: 235522
		[Token(Token = "0x4039802")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, int> modeStarCount;

		// Token: 0x04039803 RID: 235523
		[Token(Token = "0x4039803")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039804 RID: 235524
		[Token(Token = "0x4039804")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
