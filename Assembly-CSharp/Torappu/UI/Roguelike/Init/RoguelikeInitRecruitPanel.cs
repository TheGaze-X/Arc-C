using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057ED RID: 22509
	[Token(Token = "0x20057ED")]
	public class RoguelikeInitRecruitPanel : RoguelikeInitStepPanel<RoguelikeInitRecruitContext>
	{
		// Token: 0x06020E97 RID: 134807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020E97")]
		[Address(RVA = "0x1B3FC30", Offset = "0x1B3E830", VA = "0x181B3FC30")]
		private RoguelikeInitRecruit _CreateRecruit()
		{
			return null;
		}

		// Token: 0x06020E98 RID: 134808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E98")]
		[Address(RVA = "0x1B3FE70", Offset = "0x1B3EA70", VA = "0x181B3FE70")]
		private void _EventOnConfirm()
		{
		}

		// Token: 0x06020E99 RID: 134809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E99")]
		[Address(RVA = "0x1B3F770", Offset = "0x1B3E370", VA = "0x181B3F770", Slot = "8")]
		protected override void OnUpdateContext(bool isNew)
		{
		}

		// Token: 0x17004D3A RID: 19770
		// (set) Token: 0x06020E9A RID: 134810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D3A")]
		public RoguelikeInitConfirmBtn confirmBtnPrefab
		{
			[Token(Token = "0x6020E9A")]
			[Address(RVA = "0x1B3FF70", Offset = "0x1B3EB70", VA = "0x181B3FF70")]
			set
			{
			}
		}

		// Token: 0x06020E9B RID: 134811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E9B")]
		[Address(RVA = "0x1B3FF00", Offset = "0x1B3EB00", VA = "0x181B3FF00")]
		public RoguelikeInitRecruitPanel()
		{
		}

		// Token: 0x0402CBB9 RID: 183225
		[Token(Token = "0x402CBB9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _listRoot;

		// Token: 0x0402CBBA RID: 183226
		[Token(Token = "0x402CBBA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationWrapper _anim;

		// Token: 0x0402CBBB RID: 183227
		[Token(Token = "0x402CBBB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _btnContainer;

		// Token: 0x0402CBBC RID: 183228
		[Token(Token = "0x402CBBC")]
		private const string ALL_RECUIT_ANIM = "init_enter_show";

		// Token: 0x0402CBBD RID: 183229
		[Token(Token = "0x402CBBD")]
		[FieldOffset(Offset = "0x50")]
		private ItemPool<RoguelikeInitRecruit> m_recruits;

		// Token: 0x0402CBBE RID: 183230
		[Token(Token = "0x402CBBE")]
		[FieldOffset(Offset = "0x58")]
		private RoguelikeInitConfirmBtn m_confirmBtn;

		// Token: 0x0402CBBF RID: 183231
		[Token(Token = "0x402CBBF")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeInitConfirmBtn m_confirmBtnPrefab;

		// Token: 0x0402CBC0 RID: 183232
		[Token(Token = "0x402CBC0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CreateRecruit;

		// Token: 0x0402CBC1 RID: 183233
		[Token(Token = "0x402CBC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EventOnConfirm;

		// Token: 0x0402CBC2 RID: 183234
		[Token(Token = "0x402CBC2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnUpdateContext;

		// Token: 0x0402CBC3 RID: 183235
		[Token(Token = "0x402CBC3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_confirmBtnPrefab;

		// Token: 0x0402CBC4 RID: 183236
		[Token(Token = "0x402CBC4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
