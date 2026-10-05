using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005840 RID: 22592
	[Token(Token = "0x2005840")]
	public class RL03MenuTotemViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x0602103A RID: 135226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602103A")]
		[Address(RVA = "0x1B4AA70", Offset = "0x1B49670", VA = "0x181B4AA70", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0602103B RID: 135227 RVA: 0x000B8290 File Offset: 0x000B6490
		[Token(Token = "0x602103B")]
		[Address(RVA = "0x1B4AD10", Offset = "0x1B49910", VA = "0x181B4AD10")]
		private bool _CheckTotemsCanUse(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0602103C RID: 135228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602103C")]
		[Address(RVA = "0x1B4B1D0", Offset = "0x1B49DD0", VA = "0x181B4B1D0")]
		public RL03MenuTotemViewModel()
		{
		}

		// Token: 0x0602103D RID: 135229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602103D")]
		[Address(RVA = "0x1A629A0", Offset = "0x1A615A0", VA = "0x181A629A0")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402CE67 RID: 183911
		[Token(Token = "0x402CE67")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x0402CE68 RID: 183912
		[Token(Token = "0x402CE68")]
		[FieldOffset(Offset = "0x20")]
		public bool totemCanUse;

		// Token: 0x0402CE69 RID: 183913
		[Token(Token = "0x402CE69")]
		[FieldOffset(Offset = "0x21")]
		public bool haveTotemDivination;

		// Token: 0x0402CE6A RID: 183914
		[Token(Token = "0x402CE6A")]
		[FieldOffset(Offset = "0x22")]
		public bool initProcessing;

		// Token: 0x0402CE6B RID: 183915
		[Token(Token = "0x402CE6B")]
		[FieldOffset(Offset = "0x28")]
		private List<RL03TotemViewModel> m_totemViewModels;

		// Token: 0x0402CE6C RID: 183916
		[Token(Token = "0x402CE6C")]
		[FieldOffset(Offset = "0x30")]
		private List<RL03TotemViewModel> m_locationTotemViewModels;

		// Token: 0x0402CE6D RID: 183917
		[Token(Token = "0x402CE6D")]
		[FieldOffset(Offset = "0x38")]
		private List<RL03TotemViewModel> m_effectTotemViewModels;

		// Token: 0x0402CE6E RID: 183918
		[Token(Token = "0x402CE6E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402CE6F RID: 183919
		[Token(Token = "0x402CE6F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckTotemsCanUse;

		// Token: 0x0402CE70 RID: 183920
		[Token(Token = "0x402CE70")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
