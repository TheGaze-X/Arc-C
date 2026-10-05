using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041F8 RID: 16888
	[Token(Token = "0x20041F8")]
	public class SandboxV2DungeonState : SandboxV2TransparentState
	{
		// Token: 0x0601A10A RID: 106762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A10A")]
		[Address(RVA = "0x12F5C50", Offset = "0x12F4850", VA = "0x1812F5C50", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A10B RID: 106763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A10B")]
		[Address(RVA = "0x12F5CB0", Offset = "0x12F48B0", VA = "0x1812F5CB0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A10C RID: 106764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A10C")]
		[Address(RVA = "0x12F5D50", Offset = "0x12F4950", VA = "0x1812F5D50", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601A10D RID: 106765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A10D")]
		[Address(RVA = "0x12F5DD0", Offset = "0x12F49D0", VA = "0x1812F5DD0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601A10E RID: 106766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A10E")]
		[Address(RVA = "0x12F5EA0", Offset = "0x12F4AA0", VA = "0x1812F5EA0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601A10F RID: 106767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A10F")]
		[Address(RVA = "0x12F6800", Offset = "0x12F5400", VA = "0x1812F6800")]
		private void _OnJumpToNodeUpgrade(IStateBean stateBean)
		{
		}

		// Token: 0x0601A110 RID: 106768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A110")]
		[Address(RVA = "0x12F6680", Offset = "0x12F5280", VA = "0x1812F6680")]
		private void _OnJumpToNodeStagePreview(IStateBean stateBean)
		{
		}

		// Token: 0x0601A111 RID: 106769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A111")]
		[Address(RVA = "0x12F63B0", Offset = "0x12F4FB0", VA = "0x1812F63B0")]
		private void _OnJumpToNodeDropDetail(IStateBean stateBean)
		{
		}

		// Token: 0x0601A112 RID: 106770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A112")]
		[Address(RVA = "0x12F6150", Offset = "0x12F4D50", VA = "0x1812F6150")]
		private void _OnJumpToDungeonSquad(IStateBean stateBean)
		{
		}

		// Token: 0x0601A113 RID: 106771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A113")]
		[Address(RVA = "0x12F6A40", Offset = "0x12F5640", VA = "0x1812F6A40")]
		public SandboxV2DungeonState()
		{
		}

		// Token: 0x0601A114 RID: 106772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A114")]
		[Address(RVA = "0x12A1BB0", Offset = "0x12A07B0", VA = "0x1812A1BB0")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601A115 RID: 106773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A115")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0601A116 RID: 106774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A116")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601A117 RID: 106775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A117")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04020D50 RID: 134480
		[Token(Token = "0x4020D50")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2DungeonCameraController _cameraController;

		// Token: 0x04020D51 RID: 134481
		[Token(Token = "0x4020D51")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2DungeonController m_controller;

		// Token: 0x04020D52 RID: 134482
		[Token(Token = "0x4020D52")]
		[FieldOffset(Offset = "0x80")]
		private UIPage m_page;

		// Token: 0x04020D53 RID: 134483
		[Token(Token = "0x4020D53")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04020D54 RID: 134484
		[Token(Token = "0x4020D54")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020D55 RID: 134485
		[Token(Token = "0x4020D55")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04020D56 RID: 134486
		[Token(Token = "0x4020D56")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04020D57 RID: 134487
		[Token(Token = "0x4020D57")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04020D58 RID: 134488
		[Token(Token = "0x4020D58")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnJumpToNodeUpgrade;

		// Token: 0x04020D59 RID: 134489
		[Token(Token = "0x4020D59")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnJumpToNodeStagePreview;

		// Token: 0x04020D5A RID: 134490
		[Token(Token = "0x4020D5A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJumpToNodeDropDetail;

		// Token: 0x04020D5B RID: 134491
		[Token(Token = "0x4020D5B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnJumpToDungeonSquad;

		// Token: 0x04020D5C RID: 134492
		[Token(Token = "0x4020D5C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
