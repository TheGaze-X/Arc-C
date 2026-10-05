using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004923 RID: 18723
	[Token(Token = "0x2004923")]
	public class MedalDIYPreviewState : PopupFloatState
	{
		// Token: 0x0601C3AF RID: 115631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3AF")]
		[Address(RVA = "0x15B0130", Offset = "0x15AED30", VA = "0x1815B0130")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C3B0 RID: 115632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C3B0")]
		[Address(RVA = "0x15AFC80", Offset = "0x15AE880", VA = "0x1815AFC80", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C3B1 RID: 115633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3B1")]
		[Address(RVA = "0x15AFCE0", Offset = "0x15AE8E0", VA = "0x1815AFCE0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C3B2 RID: 115634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3B2")]
		[Address(RVA = "0x15B0260", Offset = "0x15AEE60", VA = "0x1815B0260")]
		public MedalDIYPreviewState()
		{
		}

		// Token: 0x0601C3B3 RID: 115635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3B3")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04024EB7 RID: 151223
		[Token(Token = "0x4024EB7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x04024EB8 RID: 151224
		[Token(Token = "0x4024EB8")]
		[FieldOffset(Offset = "0x78")]
		private MedalDIYPreviewBean m_stateBean;

		// Token: 0x04024EB9 RID: 151225
		[Token(Token = "0x4024EB9")]
		[FieldOffset(Offset = "0x80")]
		private UIMedalGroupView m_groupView;

		// Token: 0x04024EBA RID: 151226
		[Token(Token = "0x4024EBA")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x04024EBB RID: 151227
		[Token(Token = "0x4024EBB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024EBC RID: 151228
		[Token(Token = "0x4024EBC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04024EBD RID: 151229
		[Token(Token = "0x4024EBD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04024EBE RID: 151230
		[Token(Token = "0x4024EBE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
