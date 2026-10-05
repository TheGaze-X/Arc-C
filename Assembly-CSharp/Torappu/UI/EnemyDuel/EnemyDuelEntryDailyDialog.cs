using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FA7 RID: 20391
	[Token(Token = "0x2004FA7")]
	public class EnemyDuelEntryDailyDialog : UICompDialog<EnemyDuelEntryDailyDialog.Param>
	{
		// Token: 0x0601E4D9 RID: 124121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E4D9")]
		[Address(RVA = "0x17FC050", Offset = "0x17FAC50", VA = "0x1817FC050", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601E4DA RID: 124122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4DA")]
		[Address(RVA = "0x17FC170", Offset = "0x17FAD70", VA = "0x1817FC170", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601E4DB RID: 124123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4DB")]
		[Address(RVA = "0x17FC200", Offset = "0x17FAE00", VA = "0x1817FC200", Slot = "18")]
		protected override void OnRender(EnemyDuelEntryDailyDialog.Param input)
		{
		}

		// Token: 0x0601E4DC RID: 124124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4DC")]
		[Address(RVA = "0x17FC0B0", Offset = "0x17FACB0", VA = "0x1817FC0B0")]
		public void OnBackClick()
		{
		}

		// Token: 0x0601E4DD RID: 124125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4DD")]
		[Address(RVA = "0x17FC400", Offset = "0x17FB000", VA = "0x1817FC400")]
		public EnemyDuelEntryDailyDialog()
		{
		}

		// Token: 0x0601E4DE RID: 124126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E4DE")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601E4DF RID: 124127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4DF")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0402875A RID: 165722
		[Token(Token = "0x402875A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _bg;

		// Token: 0x0402875B RID: 165723
		[Token(Token = "0x402875B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x0402875C RID: 165724
		[Token(Token = "0x402875C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private EnemyDuelEntryDailyView _view;

		// Token: 0x0402875D RID: 165725
		[Token(Token = "0x402875D")]
		[FieldOffset(Offset = "0x88")]
		private EnemyDuelEntryDailyProperty m_prop;

		// Token: 0x0402875E RID: 165726
		[Token(Token = "0x402875E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0402875F RID: 165727
		[Token(Token = "0x402875F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04028760 RID: 165728
		[Token(Token = "0x4028760")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04028761 RID: 165729
		[Token(Token = "0x4028761")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x04028762 RID: 165730
		[Token(Token = "0x4028762")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FA8 RID: 20392
		[Token(Token = "0x2004FA8")]
		public class Param
		{
			// Token: 0x0601E4E0 RID: 124128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4E0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04028763 RID: 165731
			[Token(Token = "0x4028763")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
