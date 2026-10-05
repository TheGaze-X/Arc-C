using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006D1E RID: 27934
	[Token(Token = "0x2006D1E")]
	[RequireComponent(typeof(StateEngine))]
	public abstract class ActivityStageStateEngine : ActivityStageSingleComponent
	{
		// Token: 0x17005E3E RID: 24126
		// (get) Token: 0x06027D5B RID: 163163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E3E")]
		public StateEngine stateEngine
		{
			[Token(Token = "0x6027D5B")]
			[Address(RVA = "0x22F6800", Offset = "0x22F5400", VA = "0x1822F6800")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027D5C RID: 163164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D5C")]
		[Address(RVA = "0x22F6600", Offset = "0x22F5200", VA = "0x1822F6600", Slot = "7")]
		protected override void OnControllerBinded()
		{
		}

		// Token: 0x06027D5D RID: 163165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027D5D")]
		[Address(RVA = "0x22F6550", Offset = "0x22F5150", VA = "0x1822F6550", Slot = "8")]
		public override IEnumerator LoadCoroutine()
		{
			return null;
		}

		// Token: 0x06027D5E RID: 163166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D5E")]
		[Address(RVA = "0x22F6720", Offset = "0x22F5320", VA = "0x1822F6720")]
		protected ActivityStageStateEngine()
		{
		}

		// Token: 0x06027D60 RID: 163168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D60")]
		[Address(RVA = "0x22F3500", Offset = "0x22F2100", VA = "0x1822F3500")]
		private void <>xLuaBaseProxy_OnControllerBinded()
		{
		}

		// Token: 0x06027D61 RID: 163169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027D61")]
		[Address(RVA = "0x22F6710", Offset = "0x22F5310", VA = "0x1822F6710")]
		private IEnumerator <>xLuaBaseProxy_LoadCoroutine()
		{
			return null;
		}

		// Token: 0x04038782 RID: 231298
		[Token(Token = "0x4038782")]
		[FieldOffset(Offset = "0x20")]
		private StateEngine m_stateEngine;

		// Token: 0x04038783 RID: 231299
		[Token(Token = "0x4038783")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stateEngine;

		// Token: 0x04038784 RID: 231300
		[Token(Token = "0x4038784")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnControllerBinded;

		// Token: 0x04038785 RID: 231301
		[Token(Token = "0x4038785")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadCoroutine;

		// Token: 0x04038786 RID: 231302
		[Token(Token = "0x4038786")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
