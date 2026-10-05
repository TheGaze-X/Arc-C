using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007ACC RID: 31436
	[Token(Token = "0x2007ACC")]
	public class Act12D6StageController : ActivityStageController, IHotfixable
	{
		// Token: 0x1700672D RID: 26413
		// (get) Token: 0x0602C055 RID: 180309 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C056 RID: 180310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700672D")]
		public Action onRogueLikeEnd
		{
			[Token(Token = "0x602C055")]
			[Address(RVA = "0x27F97C0", Offset = "0x27F83C0", VA = "0x1827F97C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C056")]
			[Address(RVA = "0x27F9820", Offset = "0x27F8420", VA = "0x1827F9820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602C057 RID: 180311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C057")]
		[Address(RVA = "0x27F8BE0", Offset = "0x27F77E0", VA = "0x1827F8BE0", Slot = "5")]
		protected override ActivityStageBridge CreateBridge()
		{
			return null;
		}

		// Token: 0x0602C058 RID: 180312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C058")]
		[Address(RVA = "0x27F8F30", Offset = "0x27F7B30", VA = "0x1827F8F30", Slot = "10")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x0602C059 RID: 180313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C059")]
		[Address(RVA = "0x27F9330", Offset = "0x27F7F30", VA = "0x1827F9330", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x0602C05A RID: 180314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C05A")]
		[Address(RVA = "0x27F9140", Offset = "0x27F7D40", VA = "0x1827F9140", Slot = "14")]
		protected override void OnRewardTimeout()
		{
		}

		// Token: 0x0602C05B RID: 180315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C05B")]
		[Address(RVA = "0x27F9290", Offset = "0x27F7E90", VA = "0x1827F9290", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x0602C05C RID: 180316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C05C")]
		[Address(RVA = "0x27F8C70", Offset = "0x27F7870", VA = "0x1827F8C70", Slot = "7")]
		protected override string GetBGMSignal()
		{
			return null;
		}

		// Token: 0x0602C05D RID: 180317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C05D")]
		[Address(RVA = "0x27F8E20", Offset = "0x27F7A20", VA = "0x1827F8E20", Slot = "20")]
		public override IEnumerator GetReadySignalForStagePage()
		{
			return null;
		}

		// Token: 0x0602C05E RID: 180318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C05E")]
		[Address(RVA = "0x27F9480", Offset = "0x27F8080", VA = "0x1827F9480", Slot = "15")]
		protected override IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x0602C05F RID: 180319 RVA: 0x000DDEB0 File Offset: 0x000DC0B0
		[Token(Token = "0x602C05F")]
		[Address(RVA = "0x27F9530", Offset = "0x27F8130", VA = "0x1827F9530")]
		private bool _CheckIfToShowGameEnd()
		{
			return default(bool);
		}

		// Token: 0x0602C060 RID: 180320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C060")]
		[Address(RVA = "0x27F9600", Offset = "0x27F8200", VA = "0x1827F9600")]
		private IEnumerator _OpenGameEndCoroutine()
		{
			return null;
		}

		// Token: 0x0602C061 RID: 180321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C061")]
		[Address(RVA = "0x27F96B0", Offset = "0x27F82B0", VA = "0x1827F96B0")]
		private IEnumerator _WaitForControllerReady()
		{
			return null;
		}

		// Token: 0x0602C062 RID: 180322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C062")]
		[Address(RVA = "0x27F9760", Offset = "0x27F8360", VA = "0x1827F9760")]
		public Act12D6StageController()
		{
		}

		// Token: 0x0602C064 RID: 180324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C064")]
		[Address(RVA = "0x22DB660", Offset = "0x22DA260", VA = "0x1822DB660")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0602C065 RID: 180325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C065")]
		[Address(RVA = "0x22DB6C0", Offset = "0x22DA2C0", VA = "0x1822DB6C0")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x0602C066 RID: 180326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C066")]
		[Address(RVA = "0x247CFA0", Offset = "0x247BBA0", VA = "0x18247CFA0")]
		private void <>xLuaBaseProxy_OnRewardTimeout()
		{
		}

		// Token: 0x0602C067 RID: 180327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C067")]
		[Address(RVA = "0x22DB680", Offset = "0x22DA280", VA = "0x1822DB680")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x0602C068 RID: 180328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C068")]
		[Address(RVA = "0x256A040", Offset = "0x2568C40", VA = "0x18256A040")]
		private string <>xLuaBaseProxy_GetBGMSignal()
		{
			return null;
		}

		// Token: 0x0602C069 RID: 180329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C069")]
		[Address(RVA = "0x2717CC0", Offset = "0x27168C0", VA = "0x182717CC0")]
		private IEnumerator <>xLuaBaseProxy_GetReadySignalForStagePage()
		{
			return null;
		}

		// Token: 0x0602C06A RID: 180330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C06A")]
		[Address(RVA = "0x246D2A0", Offset = "0x246BEA0", VA = "0x18246D2A0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine()
		{
			return null;
		}

		// Token: 0x0403FCA0 RID: 261280
		[Token(Token = "0x403FCA0")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isControllerReady;

		// Token: 0x0403FCA2 RID: 261282
		[Token(Token = "0x403FCA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onRogueLikeEnd;

		// Token: 0x0403FCA3 RID: 261283
		[Token(Token = "0x403FCA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onRogueLikeEnd;

		// Token: 0x0403FCA4 RID: 261284
		[Token(Token = "0x403FCA4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateBridge;

		// Token: 0x0403FCA5 RID: 261285
		[Token(Token = "0x403FCA5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403FCA6 RID: 261286
		[Token(Token = "0x403FCA6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403FCA7 RID: 261287
		[Token(Token = "0x403FCA7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnRewardTimeout;

		// Token: 0x0403FCA8 RID: 261288
		[Token(Token = "0x403FCA8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403FCA9 RID: 261289
		[Token(Token = "0x403FCA9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetBGMSignal;

		// Token: 0x0403FCAA RID: 261290
		[Token(Token = "0x403FCAA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetReadySignalForStagePage;

		// Token: 0x0403FCAB RID: 261291
		[Token(Token = "0x403FCAB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403FCAC RID: 261292
		[Token(Token = "0x403FCAC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckIfToShowGameEnd;

		// Token: 0x0403FCAD RID: 261293
		[Token(Token = "0x403FCAD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OpenGameEndCoroutine;

		// Token: 0x0403FCAE RID: 261294
		[Token(Token = "0x403FCAE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__WaitForControllerReady;

		// Token: 0x0403FCAF RID: 261295
		[Token(Token = "0x403FCAF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007ACD RID: 31437
		[Token(Token = "0x2007ACD")]
		public class Bridge : ActivityStageBridge
		{
			// Token: 0x0602C06B RID: 180331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C06B")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Bridge()
			{
			}
		}
	}
}
