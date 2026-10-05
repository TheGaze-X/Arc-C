using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x02007093 RID: 28819
	[Token(Token = "0x2007093")]
	public class ActMultiV3BattleFinishRaftModeView : ActMultiV3BattleFinishModeViewBase
	{
		// Token: 0x170060E6 RID: 24806
		// (get) Token: 0x06028F1D RID: 167709 RVA: 0x000D3A58 File Offset: 0x000D1C58
		[Token(Token = "0x170060E6")]
		public override ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x6028F1D")]
			[Address(RVA = "0x2450330", Offset = "0x244EF30", VA = "0x182450330", Slot = "4")]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
		}

		// Token: 0x06028F1E RID: 167710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028F1E")]
		[Address(RVA = "0x244FD40", Offset = "0x244E940", VA = "0x18244FD40", Slot = "5")]
		public override Tween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x06028F1F RID: 167711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F1F")]
		[Address(RVA = "0x24500E0", Offset = "0x244ECE0", VA = "0x1824500E0", Slot = "6")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028F20 RID: 167712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F20")]
		[Address(RVA = "0x2450280", Offset = "0x244EE80", VA = "0x182450280")]
		public ActMultiV3BattleFinishRaftModeView()
		{
		}

		// Token: 0x0403A6ED RID: 239341
		[Token(Token = "0x403A6ED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _scoreText;

		// Token: 0x0403A6EE RID: 239342
		[Token(Token = "0x403A6EE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _scoreNumTweenDuration;

		// Token: 0x0403A6EF RID: 239343
		[Token(Token = "0x403A6EF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0403A6F0 RID: 239344
		[Token(Token = "0x403A6F0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _animScore;

		// Token: 0x0403A6F1 RID: 239345
		[Token(Token = "0x403A6F1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _animNewRecord;

		// Token: 0x0403A6F2 RID: 239346
		[Token(Token = "0x403A6F2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _newRecordVariant;

		// Token: 0x0403A6F3 RID: 239347
		[Token(Token = "0x403A6F3")]
		[FieldOffset(Offset = "0x78")]
		private BattleFinishRaftMapModel m_raftModel;

		// Token: 0x0403A6F4 RID: 239348
		[Token(Token = "0x403A6F4")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_animTween;

		// Token: 0x0403A6F5 RID: 239349
		[Token(Token = "0x403A6F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x0403A6F6 RID: 239350
		[Token(Token = "0x403A6F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x0403A6F7 RID: 239351
		[Token(Token = "0x403A6F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403A6F8 RID: 239352
		[Token(Token = "0x403A6F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
