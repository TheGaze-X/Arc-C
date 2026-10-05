using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FA9 RID: 20393
	[Token(Token = "0x2004FA9")]
	public class EnemyDuelEntryRewardDialog : UICompDialog<EnemyDuelEntryRewardDialog.Param>
	{
		// Token: 0x0601E4E1 RID: 124129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E4E1")]
		[Address(RVA = "0x17FD090", Offset = "0x17FBC90", VA = "0x1817FD090", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601E4E2 RID: 124130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4E2")]
		[Address(RVA = "0x17FD1B0", Offset = "0x17FBDB0", VA = "0x1817FD1B0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601E4E3 RID: 124131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4E3")]
		[Address(RVA = "0x17FD0F0", Offset = "0x17FBCF0", VA = "0x1817FD0F0")]
		public void OnBackClick()
		{
		}

		// Token: 0x0601E4E4 RID: 124132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4E4")]
		[Address(RVA = "0x17FD240", Offset = "0x17FBE40", VA = "0x1817FD240", Slot = "18")]
		protected override void OnRender(EnemyDuelEntryRewardDialog.Param input)
		{
		}

		// Token: 0x0601E4E5 RID: 124133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4E5")]
		[Address(RVA = "0x17FD320", Offset = "0x17FBF20", VA = "0x1817FD320")]
		public EnemyDuelEntryRewardDialog()
		{
		}

		// Token: 0x0601E4E6 RID: 124134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E4E6")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601E4E7 RID: 124135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4E7")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x04028764 RID: 165732
		[Token(Token = "0x4028764")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _bg;

		// Token: 0x04028765 RID: 165733
		[Token(Token = "0x4028765")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x04028766 RID: 165734
		[Token(Token = "0x4028766")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private EnemyDuelEntryRewardView _view;

		// Token: 0x04028767 RID: 165735
		[Token(Token = "0x4028767")]
		[FieldOffset(Offset = "0x88")]
		private EnemyDuelEntryRewardProperty m_prop;

		// Token: 0x04028768 RID: 165736
		[Token(Token = "0x4028768")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04028769 RID: 165737
		[Token(Token = "0x4028769")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402876A RID: 165738
		[Token(Token = "0x402876A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x0402876B RID: 165739
		[Token(Token = "0x402876B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402876C RID: 165740
		[Token(Token = "0x402876C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FAA RID: 20394
		[Token(Token = "0x2004FAA")]
		public class Param
		{
			// Token: 0x0601E4E8 RID: 124136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4E8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0402876D RID: 165741
			[Token(Token = "0x402876D")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
