using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061B9 RID: 25017
	[Token(Token = "0x20061B9")]
	public class BossRushStageDetailInfoView : DataBinder<BossRushStageDetailProperty>, IHotfixable
	{
		// Token: 0x1700552F RID: 21807
		// (get) Token: 0x06024196 RID: 147862 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024197 RID: 147863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700552F")]
		public Action onEnemyDetailClick
		{
			[Token(Token = "0x6024196")]
			[Address(RVA = "0x1EC67E0", Offset = "0x1EC53E0", VA = "0x181EC67E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024197")]
			[Address(RVA = "0x1EC6840", Offset = "0x1EC5440", VA = "0x181EC6840")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024198 RID: 147864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024198")]
		[Address(RVA = "0x1EC62E0", Offset = "0x1EC4EE0", VA = "0x181EC62E0")]
		public void OnEnemyDetailClick()
		{
		}

		// Token: 0x06024199 RID: 147865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024199")]
		[Address(RVA = "0x1EC63B0", Offset = "0x1EC4FB0", VA = "0x181EC63B0", Slot = "7")]
		public override void OnValueChanged(BossRushStageDetailProperty property)
		{
		}

		// Token: 0x0602419A RID: 147866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602419A")]
		[Address(RVA = "0x1EC6640", Offset = "0x1EC5240", VA = "0x181EC6640")]
		private void _RefreshView()
		{
		}

		// Token: 0x0602419B RID: 147867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602419B")]
		[Address(RVA = "0x1EC6740", Offset = "0x1EC5340", VA = "0x181EC6740")]
		public BossRushStageDetailInfoView()
		{
		}

		// Token: 0x040322C0 RID: 205504
		[Token(Token = "0x40322C0")]
		private const string ANIM_HIDE = "bossrush_stage_detail_hide_anim";

		// Token: 0x040322C1 RID: 205505
		[Token(Token = "0x40322C1")]
		private const string ANIM_SHOW = "bossrush_stage_detail_show_anim";

		// Token: 0x040322C2 RID: 205506
		[Token(Token = "0x40322C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x040322C3 RID: 205507
		[Token(Token = "0x40322C3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textStageTitle;

		// Token: 0x040322C4 RID: 205508
		[Token(Token = "0x40322C4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textStageCode;

		// Token: 0x040322C5 RID: 205509
		[Token(Token = "0x40322C5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textStageDesc;

		// Token: 0x040322C6 RID: 205510
		[Token(Token = "0x40322C6")]
		[FieldOffset(Offset = "0x40")]
		private UISwitchTween.TweenWrapper m_tweenWrapper;

		// Token: 0x040322C7 RID: 205511
		[Token(Token = "0x40322C7")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedStageGroupId;

		// Token: 0x040322C8 RID: 205512
		[Token(Token = "0x40322C8")]
		[FieldOffset(Offset = "0x50")]
		private ActivityBossRushData.BossRushStageType m_cachedType;

		// Token: 0x040322C9 RID: 205513
		[Token(Token = "0x40322C9")]
		[FieldOffset(Offset = "0x58")]
		private BossRushStageModel m_cachedStageModel;

		// Token: 0x040322CB RID: 205515
		[Token(Token = "0x40322CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onEnemyDetailClick;

		// Token: 0x040322CC RID: 205516
		[Token(Token = "0x40322CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onEnemyDetailClick;

		// Token: 0x040322CD RID: 205517
		[Token(Token = "0x40322CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnemyDetailClick;

		// Token: 0x040322CE RID: 205518
		[Token(Token = "0x40322CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040322CF RID: 205519
		[Token(Token = "0x40322CF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x040322D0 RID: 205520
		[Token(Token = "0x40322D0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
