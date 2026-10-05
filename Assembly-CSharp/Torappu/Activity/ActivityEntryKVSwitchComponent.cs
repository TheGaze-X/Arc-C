using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D4C RID: 27980
	[Token(Token = "0x2006D4C")]
	public class ActivityEntryKVSwitchComponent : ActivityStageComponent, IHotfixable
	{
		// Token: 0x06027E17 RID: 163351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E17")]
		[Address(RVA = "0x22F0F50", Offset = "0x22EFB50", VA = "0x1822F0F50", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x06027E18 RID: 163352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E18")]
		[Address(RVA = "0x22F1380", Offset = "0x22EFF80", VA = "0x1822F1380")]
		private string _FindValidKVId(ListDict<string, KVSwitchInfo> kvSwitchInfos)
		{
			return null;
		}

		// Token: 0x06027E19 RID: 163353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E19")]
		[Address(RVA = "0x22F1520", Offset = "0x22F0120", VA = "0x1822F1520")]
		private void _SetKVImgs(string kvId, string actId)
		{
		}

		// Token: 0x06027E1A RID: 163354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E1A")]
		[Address(RVA = "0x22F1730", Offset = "0x22F0330", VA = "0x1822F1730")]
		public ActivityEntryKVSwitchComponent()
		{
		}

		// Token: 0x06027E1B RID: 163355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E1B")]
		[Address(RVA = "0x22F1320", Offset = "0x22EFF20", VA = "0x1822F1320")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0403887B RID: 231547
		[Token(Token = "0x403887B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image[] _kvImgs;

		// Token: 0x0403887C RID: 231548
		[Token(Token = "0x403887C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403887D RID: 231549
		[Token(Token = "0x403887D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FindValidKVId;

		// Token: 0x0403887E RID: 231550
		[Token(Token = "0x403887E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetKVImgs;

		// Token: 0x0403887F RID: 231551
		[Token(Token = "0x403887F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
