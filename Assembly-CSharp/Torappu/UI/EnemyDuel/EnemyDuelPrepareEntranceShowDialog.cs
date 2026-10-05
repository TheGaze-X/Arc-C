using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200502B RID: 20523
	[Token(Token = "0x200502B")]
	public class EnemyDuelPrepareEntranceShowDialog : UICompDialog<EnemyDuelPrepareEntranceShowDialog.Input>
	{
		// Token: 0x0601E719 RID: 124697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E719")]
		[Address(RVA = "0x1825720", Offset = "0x1824320", VA = "0x181825720")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E71A RID: 124698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E71A")]
		[Address(RVA = "0x18254A0", Offset = "0x18240A0", VA = "0x1818254A0", Slot = "18")]
		protected override void OnRender(EnemyDuelPrepareEntranceShowDialog.Input input)
		{
		}

		// Token: 0x0601E71B RID: 124699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E71B")]
		[Address(RVA = "0x18257C0", Offset = "0x18243C0", VA = "0x1818257C0")]
		private void _PickAnimAndPlay(EnemyDuelModeType modeType)
		{
		}

		// Token: 0x0601E71C RID: 124700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E71C")]
		[Address(RVA = "0x18258C0", Offset = "0x18244C0", VA = "0x1818258C0")]
		public EnemyDuelPrepareEntranceShowDialog()
		{
		}

		// Token: 0x04028BDD RID: 166877
		[Token(Token = "0x4028BDD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private EnemyDuelPrepareEntranceShowView _view;

		// Token: 0x04028BDE RID: 166878
		[Token(Token = "0x4028BDE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _operationAnim;

		// Token: 0x04028BDF RID: 166879
		[Token(Token = "0x4028BDF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _standAnim;

		// Token: 0x04028BE0 RID: 166880
		[Token(Token = "0x4028BE0")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x04028BE1 RID: 166881
		[Token(Token = "0x4028BE1")]
		[FieldOffset(Offset = "0xA0")]
		private EnemyDuelPrepareEntranceShowProperty m_prop;

		// Token: 0x04028BE2 RID: 166882
		[Token(Token = "0x4028BE2")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_cacheEnterTween;

		// Token: 0x04028BE3 RID: 166883
		[Token(Token = "0x4028BE3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028BE4 RID: 166884
		[Token(Token = "0x4028BE4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04028BE5 RID: 166885
		[Token(Token = "0x4028BE5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PickAnimAndPlay;

		// Token: 0x04028BE6 RID: 166886
		[Token(Token = "0x4028BE6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200502C RID: 20524
		[Token(Token = "0x200502C")]
		public class Input
		{
			// Token: 0x0601E71D RID: 124701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E71D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04028BE7 RID: 166887
			[Token(Token = "0x4028BE7")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
