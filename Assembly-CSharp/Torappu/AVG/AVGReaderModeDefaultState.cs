using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F28 RID: 7976
	[Token(Token = "0x2001F28")]
	public class AVGReaderModeDefaultState : State
	{
		// Token: 0x0600C63A RID: 50746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C63A")]
		[Address(RVA = "0x346A8D0", Offset = "0x34694D0", VA = "0x18346A8D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600C63B RID: 50747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C63B")]
		[Address(RVA = "0x346A9C0", Offset = "0x34695C0", VA = "0x18346A9C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600C63C RID: 50748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C63C")]
		[Address(RVA = "0x346AB10", Offset = "0x3469710", VA = "0x18346AB10", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600C63D RID: 50749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C63D")]
		[Address(RVA = "0x346AC40", Offset = "0x3469840", VA = "0x18346AC40")]
		private void _InitComponent()
		{
		}

		// Token: 0x0600C63E RID: 50750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C63E")]
		[Address(RVA = "0x346AA70", Offset = "0x3469670", VA = "0x18346AA70", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0600C63F RID: 50751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C63F")]
		[Address(RVA = "0x346A930", Offset = "0x3469530", VA = "0x18346A930")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600C640 RID: 50752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C640")]
		[Address(RVA = "0x346ACD0", Offset = "0x34698D0", VA = "0x18346ACD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600C641 RID: 50753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C641")]
		[Address(RVA = "0x346ABE0", Offset = "0x34697E0", VA = "0x18346ABE0")]
		private void _Cleanup()
		{
		}

		// Token: 0x0600C642 RID: 50754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C642")]
		[Address(RVA = "0x346A820", Offset = "0x3469420", VA = "0x18346A820")]
		public void EventOnOpenReader()
		{
		}

		// Token: 0x0600C643 RID: 50755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C643")]
		[Address(RVA = "0x346AD40", Offset = "0x3469940", VA = "0x18346AD40")]
		public AVGReaderModeDefaultState()
		{
		}

		// Token: 0x0600C644 RID: 50756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C644")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600C645 RID: 50757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C645")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0600C646 RID: 50758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C646")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0400CB54 RID: 52052
		[Token(Token = "0x400CB54")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _readerBtn;

		// Token: 0x0400CB55 RID: 52053
		[Token(Token = "0x400CB55")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0400CB56 RID: 52054
		[Token(Token = "0x400CB56")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400CB57 RID: 52055
		[Token(Token = "0x400CB57")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400CB58 RID: 52056
		[Token(Token = "0x400CB58")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400CB59 RID: 52057
		[Token(Token = "0x400CB59")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitComponent;

		// Token: 0x0400CB5A RID: 52058
		[Token(Token = "0x400CB5A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400CB5B RID: 52059
		[Token(Token = "0x400CB5B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400CB5C RID: 52060
		[Token(Token = "0x400CB5C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400CB5D RID: 52061
		[Token(Token = "0x400CB5D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Cleanup;

		// Token: 0x0400CB5E RID: 52062
		[Token(Token = "0x400CB5E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnOpenReader;

		// Token: 0x0400CB5F RID: 52063
		[Token(Token = "0x400CB5F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
