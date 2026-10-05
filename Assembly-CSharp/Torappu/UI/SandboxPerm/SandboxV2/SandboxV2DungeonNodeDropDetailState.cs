using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041F2 RID: 16882
	[Token(Token = "0x20041F2")]
	public class SandboxV2DungeonNodeDropDetailState : PopupFloatState
	{
		// Token: 0x0601A0F1 RID: 106737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A0F1")]
		[Address(RVA = "0x12EBD50", Offset = "0x12EA950", VA = "0x1812EBD50", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A0F2 RID: 106738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0F2")]
		[Address(RVA = "0x12EBDB0", Offset = "0x12EA9B0", VA = "0x1812EBDB0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A0F3 RID: 106739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0F3")]
		[Address(RVA = "0x12EC060", Offset = "0x12EAC60", VA = "0x1812EC060")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A0F4 RID: 106740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0F4")]
		[Address(RVA = "0x12EBFC0", Offset = "0x12EABC0", VA = "0x1812EBFC0")]
		private void _DismissIfCan()
		{
		}

		// Token: 0x0601A0F5 RID: 106741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0F5")]
		[Address(RVA = "0x12EC160", Offset = "0x12EAD60", VA = "0x1812EC160")]
		public SandboxV2DungeonNodeDropDetailState()
		{
		}

		// Token: 0x0601A0F6 RID: 106742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0F6")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04020D26 RID: 134438
		[Token(Token = "0x4020D26")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2DungeonNodeDropDetailView _view;

		// Token: 0x04020D27 RID: 134439
		[Token(Token = "0x4020D27")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2DungeonNodeDropDetailStateBean m_stateBean;

		// Token: 0x04020D28 RID: 134440
		[Token(Token = "0x4020D28")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2DungeonNodeDropDetailProperty m_prop;

		// Token: 0x04020D29 RID: 134441
		[Token(Token = "0x4020D29")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04020D2A RID: 134442
		[Token(Token = "0x4020D2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04020D2B RID: 134443
		[Token(Token = "0x4020D2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020D2C RID: 134444
		[Token(Token = "0x4020D2C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020D2D RID: 134445
		[Token(Token = "0x4020D2D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DismissIfCan;

		// Token: 0x04020D2E RID: 134446
		[Token(Token = "0x4020D2E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
