using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Ending
{
	// Token: 0x0200468F RID: 18063
	[Token(Token = "0x200468F")]
	public class RoguelikeTopicEndingSPOperatorLevelView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B6A9 RID: 112297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6A9")]
		[Address(RVA = "0x14B6B40", Offset = "0x14B5740", VA = "0x1814B6B40")]
		public void Render(RoguelikeTopicEndingSPOperatorViewModel model)
		{
		}

		// Token: 0x0601B6AA RID: 112298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6AA")]
		[Address(RVA = "0x14B6FB0", Offset = "0x14B5BB0", VA = "0x1814B6FB0")]
		private void _SampleClip(RoguelikeTopicEndingSPOperatorViewModel.LevelPlayClip clip, int localPosition)
		{
		}

		// Token: 0x0601B6AB RID: 112299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6AB")]
		[Address(RVA = "0x14B71F0", Offset = "0x14B5DF0", VA = "0x1814B71F0")]
		public RoguelikeTopicEndingSPOperatorLevelView()
		{
		}

		// Token: 0x04023759 RID: 145241
		[Token(Token = "0x4023759")]
		private const string LEVEL_VOLUME_FORMAT = "/{0}";

		// Token: 0x0402375A RID: 145242
		[Token(Token = "0x402375A")]
		private const string EXP_FORMAT = "<color=#FFD800>{0}</color>/{1}";

		// Token: 0x0402375B RID: 145243
		[Token(Token = "0x402375B")]
		private const string MAX_EXP = "<color=#FFD800>-</color>/-";

		// Token: 0x0402375C RID: 145244
		[Token(Token = "0x402375C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _eliteImage;

		// Token: 0x0402375D RID: 145245
		[Token(Token = "0x402375D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _levelVolumeText;

		// Token: 0x0402375E RID: 145246
		[Token(Token = "0x402375E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _levelValueText;

		// Token: 0x0402375F RID: 145247
		[Token(Token = "0x402375F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _expFill;

		// Token: 0x04023760 RID: 145248
		[Token(Token = "0x4023760")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _expText;

		// Token: 0x04023761 RID: 145249
		[Token(Token = "0x4023761")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _maxPanel;

		// Token: 0x04023762 RID: 145250
		[Token(Token = "0x4023762")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _levelUpEffect;

		// Token: 0x04023763 RID: 145251
		[Token(Token = "0x4023763")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Ease _tweenEase;

		// Token: 0x04023764 RID: 145252
		[Token(Token = "0x4023764")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x04023765 RID: 145253
		[Token(Token = "0x4023765")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _tweenOffset;

		// Token: 0x04023766 RID: 145254
		[Token(Token = "0x4023766")]
		[FieldOffset(Offset = "0x5C")]
		private int m_loadedEliteId;

		// Token: 0x04023767 RID: 145255
		[Token(Token = "0x4023767")]
		[FieldOffset(Offset = "0x60")]
		private int m_levelVolume;

		// Token: 0x04023768 RID: 145256
		[Token(Token = "0x4023768")]
		[FieldOffset(Offset = "0x64")]
		private bool m_levelUpCanPlay;

		// Token: 0x04023769 RID: 145257
		[Token(Token = "0x4023769")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeTopicEndingSPOperatorLevelView.ProceduralTween m_proceduralTween;

		// Token: 0x0402376A RID: 145258
		[Token(Token = "0x402376A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402376B RID: 145259
		[Token(Token = "0x402376B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SampleClip;

		// Token: 0x0402376C RID: 145260
		[Token(Token = "0x402376C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004690 RID: 18064
		[Token(Token = "0x2004690")]
		public class ProceduralTween : UIProceduralTween<RoguelikeTopicEndingSPOperatorViewModel.LevelPlayClip>
		{
			// Token: 0x0601B6AC RID: 112300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B6AC")]
			[Address(RVA = "0x14ABB80", Offset = "0x14AA780", VA = "0x1814ABB80")]
			public ProceduralTween(RoguelikeTopicEndingSPOperatorLevelView closure)
			{
			}

			// Token: 0x0601B6AD RID: 112301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B6AD")]
			[Address(RVA = "0x14ABAC0", Offset = "0x14AA6C0", VA = "0x1814ABAC0", Slot = "4")]
			protected override void SampleClip(RoguelikeTopicEndingSPOperatorViewModel.LevelPlayClip clip, int localIndex)
			{
			}

			// Token: 0x0601B6AE RID: 112302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B6AE")]
			[Address(RVA = "0x14AB9F0", Offset = "0x14AA5F0", VA = "0x1814AB9F0", Slot = "5")]
			protected override void OnClipPlayed(RoguelikeTopicEndingSPOperatorViewModel.LevelPlayClip clip)
			{
			}

			// Token: 0x0402376D RID: 145261
			[Token(Token = "0x402376D")]
			[FieldOffset(Offset = "0x48")]
			private readonly RoguelikeTopicEndingSPOperatorLevelView m_closure;

			// Token: 0x0402376E RID: 145262
			[Token(Token = "0x402376E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402376F RID: 145263
			[Token(Token = "0x402376F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SampleClip;

			// Token: 0x04023770 RID: 145264
			[Token(Token = "0x4023770")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnClipPlayed;
		}
	}
}
