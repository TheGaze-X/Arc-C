using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E28 RID: 28200
	[Token(Token = "0x2006E28")]
	public class ActVecBreakV2DefenseStageSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06028237 RID: 164407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028237")]
		[Address(RVA = "0x236B7A0", Offset = "0x236A3A0", VA = "0x18236B7A0")]
		public void LoadData(string actId, string focusStageId)
		{
		}

		// Token: 0x06028238 RID: 164408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028238")]
		[Address(RVA = "0x236BA00", Offset = "0x236A600", VA = "0x18236BA00")]
		public void RefreshData(string actId)
		{
		}

		// Token: 0x06028239 RID: 164409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028239")]
		[Address(RVA = "0x236BAC0", Offset = "0x236A6C0", VA = "0x18236BAC0")]
		public void SelectStage(string stageId)
		{
		}

		// Token: 0x0602823A RID: 164410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602823A")]
		[Address(RVA = "0x236BB80", Offset = "0x236A780", VA = "0x18236BB80")]
		public ActVecBreakV2DefenseStageSelectStateBean()
		{
		}

		// Token: 0x04038FFC RID: 233468
		[Token(Token = "0x4038FFC")]
		[FieldOffset(Offset = "0x10")]
		public ActVecBreakV2DefenseStageSelectProperty property;

		// Token: 0x04038FFD RID: 233469
		[Token(Token = "0x4038FFD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038FFE RID: 233470
		[Token(Token = "0x4038FFE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04038FFF RID: 233471
		[Token(Token = "0x4038FFF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SelectStage;

		// Token: 0x04039000 RID: 233472
		[Token(Token = "0x4039000")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
