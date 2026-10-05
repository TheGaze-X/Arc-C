using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F3E RID: 16190
	[Token(Token = "0x2003F3E")]
	public class SiracusaOperaRewardState : PopupFloatState
	{
		// Token: 0x0601924A RID: 102986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601924A")]
		[Address(RVA = "0x11DCE50", Offset = "0x11DBA50", VA = "0x1811DCE50", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601924B RID: 102987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601924B")]
		[Address(RVA = "0x11DCEB0", Offset = "0x11DBAB0", VA = "0x1811DCEB0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601924C RID: 102988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601924C")]
		[Address(RVA = "0x11DD1D0", Offset = "0x11DBDD0", VA = "0x1811DD1D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601924D RID: 102989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601924D")]
		[Address(RVA = "0x11DCDD0", Offset = "0x11DB9D0", VA = "0x1811DCDD0")]
		public void EventOnClose()
		{
		}

		// Token: 0x0601924E RID: 102990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601924E")]
		[Address(RVA = "0x11DD2F0", Offset = "0x11DBEF0", VA = "0x1811DD2F0")]
		public SiracusaOperaRewardState()
		{
		}

		// Token: 0x0601924F RID: 102991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601924F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401F25A RID: 127578
		[Token(Token = "0x401F25A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SiracusaOperaRewardView _view;

		// Token: 0x0401F25B RID: 127579
		[Token(Token = "0x401F25B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0401F25C RID: 127580
		[Token(Token = "0x401F25C")]
		[FieldOffset(Offset = "0x80")]
		private SiracusaOperaRewardStateBean m_stateBean;

		// Token: 0x0401F25D RID: 127581
		[Token(Token = "0x401F25D")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0401F25E RID: 127582
		[Token(Token = "0x401F25E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401F25F RID: 127583
		[Token(Token = "0x401F25F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401F260 RID: 127584
		[Token(Token = "0x401F260")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F261 RID: 127585
		[Token(Token = "0x401F261")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClose;

		// Token: 0x0401F262 RID: 127586
		[Token(Token = "0x401F262")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
