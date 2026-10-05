using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.FunLive
{
	// Token: 0x0200268B RID: 9867
	[Token(Token = "0x200268B")]
	public class FunLiveUIBattleMenuSystemPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060101DB RID: 66011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101DB")]
		[Address(RVA = "0x7C4960", Offset = "0x7C3560", VA = "0x1807C4960")]
		public void Init(FunLiveUISystemMenuState state)
		{
		}

		// Token: 0x060101DC RID: 66012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101DC")]
		[Address(RVA = "0x7C4B20", Offset = "0x7C3720", VA = "0x1807C4B20")]
		public void Show()
		{
		}

		// Token: 0x060101DD RID: 66013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101DD")]
		[Address(RVA = "0x7C4880", Offset = "0x7C3480", VA = "0x1807C4880")]
		public void CloseSystemMenuPanel()
		{
		}

		// Token: 0x060101DE RID: 66014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101DE")]
		[Address(RVA = "0x7C48F0", Offset = "0x7C34F0", VA = "0x1807C48F0")]
		public void FinishGameDirectly()
		{
		}

		// Token: 0x060101DF RID: 66015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101DF")]
		[Address(RVA = "0x7C4B90", Offset = "0x7C3790", VA = "0x1807C4B90")]
		public FunLiveUIBattleMenuSystemPanel()
		{
		}

		// Token: 0x04011F36 RID: 73526
		[Token(Token = "0x4011F36")]
		[FieldOffset(Offset = "0x18")]
		private FunLiveUISystemMenuState m_state;

		// Token: 0x04011F37 RID: 73527
		[Token(Token = "0x4011F37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04011F38 RID: 73528
		[Token(Token = "0x4011F38")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04011F39 RID: 73529
		[Token(Token = "0x4011F39")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CloseSystemMenuPanel;

		// Token: 0x04011F3A RID: 73530
		[Token(Token = "0x4011F3A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FinishGameDirectly;

		// Token: 0x04011F3B RID: 73531
		[Token(Token = "0x4011F3B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
