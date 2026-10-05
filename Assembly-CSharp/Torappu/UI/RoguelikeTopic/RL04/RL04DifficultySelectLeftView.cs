using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046CD RID: 18125
	[Token(Token = "0x20046CD")]
	public class RL04DifficultySelectLeftView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004171 RID: 16753
		// (get) Token: 0x0601B7BE RID: 112574 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B7BF RID: 112575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004171")]
		public Func<string, Sprite> buffIconLoader
		{
			[Token(Token = "0x601B7BE")]
			[Address(RVA = "0x14C6840", Offset = "0x14C5440", VA = "0x1814C6840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B7BF")]
			[Address(RVA = "0x14C68A0", Offset = "0x14C54A0", VA = "0x1814C68A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B7C0 RID: 112576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7C0")]
		[Address(RVA = "0x14C5A40", Offset = "0x14C4640", VA = "0x1814C5A40")]
		public void Render(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B7C1 RID: 112577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B7C1")]
		[Address(RVA = "0x14C6280", Offset = "0x14C4E80", VA = "0x1814C6280")]
		private RoguelikeTopicDifficultyViewModel _FindBuffDifficultyModel(RoguelikeTopicModeViewModel model)
		{
			return null;
		}

		// Token: 0x0601B7C2 RID: 112578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B7C2")]
		[Address(RVA = "0x14C6430", Offset = "0x14C5030", VA = "0x1814C6430")]
		private RoguelikeTopicDifficultyViewModel _FindDifficultyModel(RoguelikeTopicModeViewModel model, RoguelikeTopicMode mode, int grade)
		{
			return null;
		}

		// Token: 0x0601B7C3 RID: 112579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7C3")]
		[Address(RVA = "0x14C5D60", Offset = "0x14C4960", VA = "0x1814C5D60")]
		public void UpdateSelect(RL04DifficultyViewModel difficulty, int selectIdx, bool fastMode)
		{
		}

		// Token: 0x0601B7C4 RID: 112580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7C4")]
		[Address(RVA = "0x14C6560", Offset = "0x14C5160", VA = "0x1814C6560")]
		private void _TweenBuffIconTo(int buffCnt, bool fastMode)
		{
		}

		// Token: 0x0601B7C5 RID: 112581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7C5")]
		[Address(RVA = "0x14C58A0", Offset = "0x14C44A0", VA = "0x1814C58A0")]
		public void EventShowAddDetail()
		{
		}

		// Token: 0x0601B7C6 RID: 112582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7C6")]
		[Address(RVA = "0x14C5970", Offset = "0x14C4570", VA = "0x1814C5970")]
		public void EventShowRules()
		{
		}

		// Token: 0x0601B7C7 RID: 112583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7C7")]
		[Address(RVA = "0x14C67E0", Offset = "0x14C53E0", VA = "0x1814C67E0")]
		public RL04DifficultySelectLeftView()
		{
		}

		// Token: 0x0402397F RID: 145791
		[Token(Token = "0x402397F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _buffActiveBg;

		// Token: 0x04023980 RID: 145792
		[Token(Token = "0x4023980")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _buffDisactiveBg;

		// Token: 0x04023981 RID: 145793
		[Token(Token = "0x4023981")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _bpNum;

		// Token: 0x04023982 RID: 145794
		[Token(Token = "0x4023982")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _bossNum;

		// Token: 0x04023983 RID: 145795
		[Token(Token = "0x4023983")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _addRoot;

		// Token: 0x04023984 RID: 145796
		[Token(Token = "0x4023984")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _relicDevLevel;

		// Token: 0x04023985 RID: 145797
		[Token(Token = "0x4023985")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _disasterLevel;

		// Token: 0x04023986 RID: 145798
		[Token(Token = "0x4023986")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _weightDevLevel;

		// Token: 0x04023987 RID: 145799
		[Token(Token = "0x4023987")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image[] _buffIconImages;

		// Token: 0x04023988 RID: 145800
		[Token(Token = "0x4023988")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Sprite _lockedBuffSprite;

		// Token: 0x04023989 RID: 145801
		[Token(Token = "0x4023989")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _buffActiveTips;

		// Token: 0x0402398A RID: 145802
		[Token(Token = "0x402398A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _buffSwitchAnim;

		// Token: 0x0402398B RID: 145803
		[Token(Token = "0x402398B")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeTopicModeViewProperty m_cachedProp;

		// Token: 0x0402398C RID: 145804
		[Token(Token = "0x402398C")]
		[FieldOffset(Offset = "0x88")]
		private int m_currSel;

		// Token: 0x0402398D RID: 145805
		[Token(Token = "0x402398D")]
		[FieldOffset(Offset = "0x8C")]
		private float m_animPos;

		// Token: 0x0402398E RID: 145806
		[Token(Token = "0x402398E")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_animTween;

		// Token: 0x04023990 RID: 145808
		[Token(Token = "0x4023990")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buffIconLoader;

		// Token: 0x04023991 RID: 145809
		[Token(Token = "0x4023991")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_buffIconLoader;

		// Token: 0x04023992 RID: 145810
		[Token(Token = "0x4023992")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023993 RID: 145811
		[Token(Token = "0x4023993")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FindBuffDifficultyModel;

		// Token: 0x04023994 RID: 145812
		[Token(Token = "0x4023994")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FindDifficultyModel;

		// Token: 0x04023995 RID: 145813
		[Token(Token = "0x4023995")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateSelect;

		// Token: 0x04023996 RID: 145814
		[Token(Token = "0x4023996")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TweenBuffIconTo;

		// Token: 0x04023997 RID: 145815
		[Token(Token = "0x4023997")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventShowAddDetail;

		// Token: 0x04023998 RID: 145816
		[Token(Token = "0x4023998")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventShowRules;

		// Token: 0x04023999 RID: 145817
		[Token(Token = "0x4023999")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
