using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200495E RID: 18782
	[Token(Token = "0x200495E")]
	public class MedalGroupDisplayState : PopupFloatState
	{
		// Token: 0x0601C4F4 RID: 115956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C4F4")]
		[Address(RVA = "0x15CAF60", Offset = "0x15C9B60", VA = "0x1815CAF60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C4F5 RID: 115957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4F5")]
		[Address(RVA = "0x15CB4F0", Offset = "0x15CA0F0", VA = "0x1815CB4F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C4F6 RID: 115958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4F6")]
		[Address(RVA = "0x15CB150", Offset = "0x15C9D50", VA = "0x1815CB150", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C4F7 RID: 115959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4F7")]
		[Address(RVA = "0x15CAFC0", Offset = "0x15C9BC0", VA = "0x1815CAFC0")]
		public void OnDropToMedalPage()
		{
		}

		// Token: 0x0601C4F8 RID: 115960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4F8")]
		[Address(RVA = "0x15CB620", Offset = "0x15CA220", VA = "0x1815CB620")]
		private void _RenderMedalGroup(MedalGroupViewModel groupModel)
		{
		}

		// Token: 0x0601C4F9 RID: 115961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4F9")]
		[Address(RVA = "0x15CB820", Offset = "0x15CA420", VA = "0x1815CB820")]
		public MedalGroupDisplayState()
		{
		}

		// Token: 0x0601C4FA RID: 115962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4FA")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04025078 RID: 151672
		[Token(Token = "0x4025078")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MedalDisplayCommonView _view;

		// Token: 0x04025079 RID: 151673
		[Token(Token = "0x4025079")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _medalGroupContainer;

		// Token: 0x0402507A RID: 151674
		[Token(Token = "0x402507A")]
		[FieldOffset(Offset = "0x80")]
		private UIMedalGroupView m_medalGroup;

		// Token: 0x0402507B RID: 151675
		[Token(Token = "0x402507B")]
		[FieldOffset(Offset = "0x88")]
		private MedalGroupDisplayStateBean m_stateBean;

		// Token: 0x0402507C RID: 151676
		[Token(Token = "0x402507C")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0402507D RID: 151677
		[Token(Token = "0x402507D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402507E RID: 151678
		[Token(Token = "0x402507E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402507F RID: 151679
		[Token(Token = "0x402507F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025080 RID: 151680
		[Token(Token = "0x4025080")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDropToMedalPage;

		// Token: 0x04025081 RID: 151681
		[Token(Token = "0x4025081")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderMedalGroup;

		// Token: 0x04025082 RID: 151682
		[Token(Token = "0x4025082")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
