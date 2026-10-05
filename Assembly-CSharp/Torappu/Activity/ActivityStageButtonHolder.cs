using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D66 RID: 28006
	[Token(Token = "0x2006D66")]
	public class ActivityStageButtonHolder : ActivityAssetHolder, IStageButtonPatchCollection
	{
		// Token: 0x06027E94 RID: 163476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E94")]
		[Address(RVA = "0x233D110", Offset = "0x233BD10", VA = "0x18233D110", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x06027E95 RID: 163477 RVA: 0x000CFF48 File Offset: 0x000CE148
		[Token(Token = "0x6027E95")]
		[Address(RVA = "0x233D280", Offset = "0x233BE80", VA = "0x18233D280", Slot = "7")]
		protected override bool LockAspect(string curAspect, Action<string> setAspect)
		{
			return default(bool);
		}

		// Token: 0x06027E96 RID: 163478 RVA: 0x000CFF60 File Offset: 0x000CE160
		[Token(Token = "0x6027E96")]
		[Address(RVA = "0x233D580", Offset = "0x233C180", VA = "0x18233D580")]
		public bool TryGetStageButtonPatch(string stageId, out StageButtonPatch patch)
		{
			return default(bool);
		}

		// Token: 0x06027E97 RID: 163479 RVA: 0x000CFF78 File Offset: 0x000CE178
		[Token(Token = "0x6027E97")]
		[Address(RVA = "0x233D360", Offset = "0x233BF60", VA = "0x18233D360", Slot = "8")]
		public bool SavePatch(StageButtonPatch patch)
		{
			return default(bool);
		}

		// Token: 0x06027E98 RID: 163480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E98")]
		[Address(RVA = "0x233D6D0", Offset = "0x233C2D0", VA = "0x18233D6D0")]
		public ActivityStageButtonHolder()
		{
		}

		// Token: 0x06027E99 RID: 163481 RVA: 0x000CFF90 File Offset: 0x000CE190
		[Token(Token = "0x6027E99")]
		[Address(RVA = "0x1140F60", Offset = "0x113FB60", VA = "0x181140F60")]
		private bool <>xLuaBaseProxy_LockAspect(string P0, Action<string> P1)
		{
			return default(bool);
		}

		// Token: 0x04038921 RID: 231713
		[Token(Token = "0x4038921")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<StageButtonPatch> _btnPatches;

		// Token: 0x04038922 RID: 231714
		[Token(Token = "0x4038922")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x04038923 RID: 231715
		[Token(Token = "0x4038923")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LockAspect;

		// Token: 0x04038924 RID: 231716
		[Token(Token = "0x4038924")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetStageButtonPatch;

		// Token: 0x04038925 RID: 231717
		[Token(Token = "0x4038925")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SavePatch;

		// Token: 0x04038926 RID: 231718
		[Token(Token = "0x4038926")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
