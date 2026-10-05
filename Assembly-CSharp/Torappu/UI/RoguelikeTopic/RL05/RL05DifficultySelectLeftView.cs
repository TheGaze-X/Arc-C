using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL05
{
	// Token: 0x02004597 RID: 17815
	[Token(Token = "0x2004597")]
	public class RL05DifficultySelectLeftView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170040A3 RID: 16547
		// (get) Token: 0x0601B1E9 RID: 111081 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B1EA RID: 111082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040A3")]
		public Func<string, Sprite> buffIconLoader
		{
			[Token(Token = "0x601B1E9")]
			[Address(RVA = "0x1450290", Offset = "0x144EE90", VA = "0x181450290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B1EA")]
			[Address(RVA = "0x14502F0", Offset = "0x144EEF0", VA = "0x1814502F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B1EB RID: 111083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1EB")]
		[Address(RVA = "0x144F530", Offset = "0x144E130", VA = "0x18144F530")]
		public void Render(RoguelikeTopicModeViewProperty prop)
		{
		}

		// Token: 0x0601B1EC RID: 111084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B1EC")]
		[Address(RVA = "0x144FCD0", Offset = "0x144E8D0", VA = "0x18144FCD0")]
		private RoguelikeTopicDifficultyViewModel _FindBuffDifficultyModel(RoguelikeTopicModeViewModel model)
		{
			return null;
		}

		// Token: 0x0601B1ED RID: 111085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B1ED")]
		[Address(RVA = "0x144FE80", Offset = "0x144EA80", VA = "0x18144FE80")]
		private RoguelikeTopicDifficultyViewModel _FindDifficultyModel(RoguelikeTopicModeViewModel model, RoguelikeTopicMode mode, int grade)
		{
			return null;
		}

		// Token: 0x0601B1EE RID: 111086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1EE")]
		[Address(RVA = "0x144F850", Offset = "0x144E450", VA = "0x18144F850")]
		public void UpdateSelect(RL05DifficultyViewModel difficulty, int selectIdx, bool fastMode)
		{
		}

		// Token: 0x0601B1EF RID: 111087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1EF")]
		[Address(RVA = "0x144FFB0", Offset = "0x144EBB0", VA = "0x18144FFB0")]
		private void _TweenBuffIconTo(int buffCnt, bool fastMode)
		{
		}

		// Token: 0x0601B1F0 RID: 111088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1F0")]
		[Address(RVA = "0x144F390", Offset = "0x144DF90", VA = "0x18144F390")]
		public void EventShowAddDetail()
		{
		}

		// Token: 0x0601B1F1 RID: 111089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1F1")]
		[Address(RVA = "0x144F460", Offset = "0x144E060", VA = "0x18144F460")]
		public void EventShowRules()
		{
		}

		// Token: 0x0601B1F2 RID: 111090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1F2")]
		[Address(RVA = "0x1450230", Offset = "0x144EE30", VA = "0x181450230")]
		public RL05DifficultySelectLeftView()
		{
		}

		// Token: 0x04022E5D RID: 142941
		[Token(Token = "0x4022E5D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _buffActiveBg;

		// Token: 0x04022E5E RID: 142942
		[Token(Token = "0x4022E5E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _buffDisactiveBg;

		// Token: 0x04022E5F RID: 142943
		[Token(Token = "0x4022E5F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _bpNum;

		// Token: 0x04022E60 RID: 142944
		[Token(Token = "0x4022E60")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _bossNum;

		// Token: 0x04022E61 RID: 142945
		[Token(Token = "0x4022E61")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _addRoot;

		// Token: 0x04022E62 RID: 142946
		[Token(Token = "0x4022E62")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _relicDevLevel;

		// Token: 0x04022E63 RID: 142947
		[Token(Token = "0x4022E63")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _wrathLevel;

		// Token: 0x04022E64 RID: 142948
		[Token(Token = "0x4022E64")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _gildLevel;

		// Token: 0x04022E65 RID: 142949
		[Token(Token = "0x4022E65")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image[] _buffIconImages;

		// Token: 0x04022E66 RID: 142950
		[Token(Token = "0x4022E66")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Sprite _lockedBuffSprite;

		// Token: 0x04022E67 RID: 142951
		[Token(Token = "0x4022E67")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _buffActiveTips;

		// Token: 0x04022E68 RID: 142952
		[Token(Token = "0x4022E68")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _buffSwitchAnim;

		// Token: 0x04022E69 RID: 142953
		[Token(Token = "0x4022E69")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeTopicModeViewProperty m_cachedProp;

		// Token: 0x04022E6A RID: 142954
		[Token(Token = "0x4022E6A")]
		[FieldOffset(Offset = "0x88")]
		private float m_animPos;

		// Token: 0x04022E6B RID: 142955
		[Token(Token = "0x4022E6B")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_animTween;

		// Token: 0x04022E6D RID: 142957
		[Token(Token = "0x4022E6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buffIconLoader;

		// Token: 0x04022E6E RID: 142958
		[Token(Token = "0x4022E6E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_buffIconLoader;

		// Token: 0x04022E6F RID: 142959
		[Token(Token = "0x4022E6F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022E70 RID: 142960
		[Token(Token = "0x4022E70")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FindBuffDifficultyModel;

		// Token: 0x04022E71 RID: 142961
		[Token(Token = "0x4022E71")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FindDifficultyModel;

		// Token: 0x04022E72 RID: 142962
		[Token(Token = "0x4022E72")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateSelect;

		// Token: 0x04022E73 RID: 142963
		[Token(Token = "0x4022E73")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TweenBuffIconTo;

		// Token: 0x04022E74 RID: 142964
		[Token(Token = "0x4022E74")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventShowAddDetail;

		// Token: 0x04022E75 RID: 142965
		[Token(Token = "0x4022E75")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventShowRules;

		// Token: 0x04022E76 RID: 142966
		[Token(Token = "0x4022E76")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
