using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072BC RID: 29372
	[Token(Token = "0x20072BC")]
	public class Act45SideLivePage : StateEnginePage, IHotfixable
	{
		// Token: 0x1700624A RID: 25162
		// (get) Token: 0x06029924 RID: 170276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700624A")]
		public string actId
		{
			[Token(Token = "0x6029924")]
			[Address(RVA = "0x24F3FB0", Offset = "0x24F2BB0", VA = "0x1824F3FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700624B RID: 25163
		// (get) Token: 0x06029925 RID: 170277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700624B")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x6029925")]
			[Address(RVA = "0x24F4090", Offset = "0x24F2C90", VA = "0x1824F4090")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029926 RID: 170278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029926")]
		[Address(RVA = "0x24F3DC0", Offset = "0x24F29C0", VA = "0x1824F3DC0")]
		public void PlayMusic(string gameMusicId)
		{
		}

		// Token: 0x06029927 RID: 170279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029927")]
		[Address(RVA = "0x24F3C40", Offset = "0x24F2840", VA = "0x1824F3C40", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06029928 RID: 170280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029928")]
		[Address(RVA = "0x24F3B80", Offset = "0x24F2780", VA = "0x1824F3B80", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x06029929 RID: 170281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029929")]
		[Address(RVA = "0x24F3E70", Offset = "0x24F2A70", VA = "0x1824F3E70")]
		private void _OnBackImpl()
		{
		}

		// Token: 0x0602992A RID: 170282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602992A")]
		[Address(RVA = "0x24F3F50", Offset = "0x24F2B50", VA = "0x1824F3F50")]
		public Act45SideLivePage()
		{
		}

		// Token: 0x0602992C RID: 170284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602992C")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0602992D RID: 170285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602992D")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0403B724 RID: 243492
		[Token(Token = "0x403B724")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _topMenuHolder;

		// Token: 0x0403B725 RID: 243493
		[Token(Token = "0x403B725")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0403B726 RID: 243494
		[Token(Token = "0x403B726")]
		[FieldOffset(Offset = "0x100")]
		private Act45SideLivePage.Params m_param;

		// Token: 0x0403B727 RID: 243495
		[Token(Token = "0x403B727")]
		[FieldOffset(Offset = "0x108")]
		private DataBundle m_savedInst;

		// Token: 0x0403B728 RID: 243496
		[Token(Token = "0x403B728")]
		[FieldOffset(Offset = "0x110")]
		private UICompDialogMgr m_diaglogMgr;

		// Token: 0x0403B729 RID: 243497
		[Token(Token = "0x403B729")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403B72A RID: 243498
		[Token(Token = "0x403B72A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x0403B72B RID: 243499
		[Token(Token = "0x403B72B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayMusic;

		// Token: 0x0403B72C RID: 243500
		[Token(Token = "0x403B72C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403B72D RID: 243501
		[Token(Token = "0x403B72D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0403B72E RID: 243502
		[Token(Token = "0x403B72E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnBackImpl;

		// Token: 0x0403B72F RID: 243503
		[Token(Token = "0x403B72F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020072BD RID: 29373
		[Token(Token = "0x20072BD")]
		public class Params : IHotfixable
		{
			// Token: 0x0602992E RID: 170286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602992E")]
			[Address(RVA = "0x2501A90", Offset = "0x2500690", VA = "0x182501A90")]
			public Params()
			{
			}

			// Token: 0x0403B730 RID: 243504
			[Token(Token = "0x403B730")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403B731 RID: 243505
			[Token(Token = "0x403B731")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
