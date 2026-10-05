using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200655B RID: 25947
	[Token(Token = "0x200655B")]
	public class ArtMagazineDiyDecorState : ArtMagazineDiySidePanelState, IHotfixable
	{
		// Token: 0x060254F6 RID: 152822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60254F6")]
		[Address(RVA = "0x20457B0", Offset = "0x20443B0", VA = "0x1820457B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060254F7 RID: 152823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254F7")]
		[Address(RVA = "0x2045810", Offset = "0x2044410", VA = "0x182045810", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060254F8 RID: 152824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254F8")]
		[Address(RVA = "0x20459E0", Offset = "0x20445E0", VA = "0x1820459E0", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x060254F9 RID: 152825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254F9")]
		[Address(RVA = "0x2045950", Offset = "0x2044550", VA = "0x182045950", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x060254FA RID: 152826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254FA")]
		[Address(RVA = "0x20458B0", Offset = "0x20444B0", VA = "0x1820458B0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x060254FB RID: 152827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254FB")]
		[Address(RVA = "0x2045A90", Offset = "0x2044690", VA = "0x182045A90")]
		public ArtMagazineDiyDecorState()
		{
		}

		// Token: 0x060254FC RID: 152828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254FC")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060254FD RID: 152829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254FD")]
		[Address(RVA = "0x2045A80", Offset = "0x2044680", VA = "0x182045A80")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x060254FE RID: 152830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254FE")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x060254FF RID: 152831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254FF")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04034596 RID: 214422
		[Token(Token = "0x4034596")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ArtMagazineDiyDecorView _view;

		// Token: 0x04034597 RID: 214423
		[Token(Token = "0x4034597")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04034598 RID: 214424
		[Token(Token = "0x4034598")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04034599 RID: 214425
		[Token(Token = "0x4034599")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0403459A RID: 214426
		[Token(Token = "0x403459A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0403459B RID: 214427
		[Token(Token = "0x403459B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403459C RID: 214428
		[Token(Token = "0x403459C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
