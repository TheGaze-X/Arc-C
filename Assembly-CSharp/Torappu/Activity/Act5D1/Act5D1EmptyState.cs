using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007241 RID: 29249
	[Token(Token = "0x2007241")]
	public class Act5D1EmptyState : State
	{
		// Token: 0x0602971D RID: 169757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602971D")]
		[Address(RVA = "0x24C55D0", Offset = "0x24C41D0", VA = "0x1824C55D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602971E RID: 169758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602971E")]
		[Address(RVA = "0x24C58E0", Offset = "0x24C44E0", VA = "0x1824C58E0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602971F RID: 169759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602971F")]
		[Address(RVA = "0x24C5800", Offset = "0x24C4400", VA = "0x1824C5800", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06029720 RID: 169760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029720")]
		[Address(RVA = "0x24C5630", Offset = "0x24C4230", VA = "0x1824C5630")]
		public void JumpToMission()
		{
		}

		// Token: 0x06029721 RID: 169761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029721")]
		[Address(RVA = "0x24C56C0", Offset = "0x24C42C0", VA = "0x1824C56C0")]
		public void JumpToShop()
		{
		}

		// Token: 0x06029722 RID: 169762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029722")]
		[Address(RVA = "0x24C5750", Offset = "0x24C4350", VA = "0x1824C5750")]
		public void JumpToStage(string stageId)
		{
		}

		// Token: 0x06029723 RID: 169763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029723")]
		[Address(RVA = "0x24C5D80", Offset = "0x24C4980", VA = "0x1824C5D80")]
		private IEnumerator _TryResumeStageState()
		{
			return null;
		}

		// Token: 0x06029724 RID: 169764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029724")]
		[Address(RVA = "0x24C5E30", Offset = "0x24C4A30", VA = "0x1824C5E30")]
		public Act5D1EmptyState()
		{
		}

		// Token: 0x06029727 RID: 169767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029727")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06029728 RID: 169768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029728")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403B36F RID: 242543
		[Token(Token = "0x403B36F")]
		private const string ENTRY_GUIDE_SUBSIGNAL = "{0}_entry";

		// Token: 0x0403B370 RID: 242544
		[Token(Token = "0x403B370")]
		[FieldOffset(Offset = "0x50")]
		private string m_cacheStageId;

		// Token: 0x0403B371 RID: 242545
		[Token(Token = "0x403B371")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasTriedToResumeStage;

		// Token: 0x0403B372 RID: 242546
		[Token(Token = "0x403B372")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B373 RID: 242547
		[Token(Token = "0x403B373")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403B374 RID: 242548
		[Token(Token = "0x403B374")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403B375 RID: 242549
		[Token(Token = "0x403B375")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_JumpToMission;

		// Token: 0x0403B376 RID: 242550
		[Token(Token = "0x403B376")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_JumpToShop;

		// Token: 0x0403B377 RID: 242551
		[Token(Token = "0x403B377")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_JumpToStage;

		// Token: 0x0403B378 RID: 242552
		[Token(Token = "0x403B378")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryResumeStageState;

		// Token: 0x0403B379 RID: 242553
		[Token(Token = "0x403B379")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
