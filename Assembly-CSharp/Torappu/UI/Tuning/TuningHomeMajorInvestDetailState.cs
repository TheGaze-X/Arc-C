using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CB9 RID: 15545
	[Token(Token = "0x2003CB9")]
	public class TuningHomeMajorInvestDetailState : PopupFloatState, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x060183EC RID: 99308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60183EC")]
		[Address(RVA = "0x10BC900", Offset = "0x10BB500", VA = "0x1810BC900", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060183ED RID: 99309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183ED")]
		[Address(RVA = "0x10BC960", Offset = "0x10BB560", VA = "0x1810BC960", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060183EE RID: 99310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183EE")]
		[Address(RVA = "0x10BCCC0", Offset = "0x10BB8C0", VA = "0x1810BCCC0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060183EF RID: 99311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183EF")]
		[Address(RVA = "0x10BCB80", Offset = "0x10BB780", VA = "0x1810BCB80", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060183F0 RID: 99312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183F0")]
		[Address(RVA = "0x10BCD80", Offset = "0x10BB980", VA = "0x1810BCD80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060183F1 RID: 99313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183F1")]
		[Address(RVA = "0x10BCE20", Offset = "0x10BBA20", VA = "0x1810BCE20")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x060183F2 RID: 99314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183F2")]
		[Address(RVA = "0x10BCEC0", Offset = "0x10BBAC0", VA = "0x1810BCEC0")]
		public TuningHomeMajorInvestDetailState()
		{
		}

		// Token: 0x060183F3 RID: 99315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183F3")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060183F4 RID: 99316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183F4")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0401D917 RID: 121111
		[Token(Token = "0x401D917")]
		[NonSerialized]
		public const int ON_BACK_BTN_CLICKED = 0;

		// Token: 0x0401D918 RID: 121112
		[Token(Token = "0x401D918")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TuningHomeMajorInvestDetailView _detailView;

		// Token: 0x0401D919 RID: 121113
		[Token(Token = "0x401D919")]
		[FieldOffset(Offset = "0x78")]
		private TuningHomeMajorInvestDetailStateBean m_stateBean;

		// Token: 0x0401D91A RID: 121114
		[Token(Token = "0x401D91A")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0401D91B RID: 121115
		[Token(Token = "0x401D91B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401D91C RID: 121116
		[Token(Token = "0x401D91C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401D91D RID: 121117
		[Token(Token = "0x401D91D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401D91E RID: 121118
		[Token(Token = "0x401D91E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401D91F RID: 121119
		[Token(Token = "0x401D91F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D920 RID: 121120
		[Token(Token = "0x401D920")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x0401D921 RID: 121121
		[Token(Token = "0x401D921")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
