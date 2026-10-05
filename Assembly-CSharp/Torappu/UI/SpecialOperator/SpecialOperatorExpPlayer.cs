using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E5A RID: 15962
	[Token(Token = "0x2003E5A")]
	public class SpecialOperatorExpPlayer : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018D3A RID: 101690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D3A")]
		[Address(RVA = "0x117AA10", Offset = "0x1179610", VA = "0x18117AA10")]
		public void Play(SpecialOperatorExpPlayer.Param param)
		{
		}

		// Token: 0x06018D3B RID: 101691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D3B")]
		[Address(RVA = "0x117AC90", Offset = "0x1179890", VA = "0x18117AC90")]
		private SpecialOperatorExpPlayer.ClipTween _EnsurePlayer()
		{
			return null;
		}

		// Token: 0x06018D3C RID: 101692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D3C")]
		[Address(RVA = "0x117AF90", Offset = "0x1179B90", VA = "0x18117AF90")]
		private void _FillClips(SpecialOperatorExpPlayer.Param param, List<SpecialOperatorExpPlayer.Clip> clips)
		{
		}

		// Token: 0x06018D3D RID: 101693 RVA: 0x0009C150 File Offset: 0x0009A350
		[Token(Token = "0x6018D3D")]
		[Address(RVA = "0x117B200", Offset = "0x1179E00", VA = "0x18117B200")]
		private bool _TryFetchExpMapForCurrentEvolvePhase(SpecialOperatorDetailData detailData, EvolvePhase evolvePhase, out int[] expMap)
		{
			return default(bool);
		}

		// Token: 0x06018D3E RID: 101694 RVA: 0x0009C168 File Offset: 0x0009A368
		[Token(Token = "0x6018D3E")]
		[Address(RVA = "0x117AE00", Offset = "0x1179A00", VA = "0x18117AE00")]
		private int _FetchLevelUpExp(int[] map, EvolvePhase evolvePhase, int level)
		{
			return 0;
		}

		// Token: 0x06018D3F RID: 101695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D3F")]
		[Address(RVA = "0x117B380", Offset = "0x1179F80", VA = "0x18117B380")]
		public SpecialOperatorExpPlayer()
		{
		}

		// Token: 0x0401E85E RID: 125022
		[Token(Token = "0x401E85E")]
		private const string EXP_FORMAT = "<color=#FFD800>{0}</color>/{1}";

		// Token: 0x0401E85F RID: 125023
		[Token(Token = "0x401E85F")]
		private const string MAX_EXP = "<color=#FFD800>-</color>/-";

		// Token: 0x0401E860 RID: 125024
		[Token(Token = "0x401E860")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x0401E861 RID: 125025
		[Token(Token = "0x401E861")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _expText;

		// Token: 0x0401E862 RID: 125026
		[Token(Token = "0x401E862")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _expFill;

		// Token: 0x0401E863 RID: 125027
		[Token(Token = "0x401E863")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _playDuration;

		// Token: 0x0401E864 RID: 125028
		[Token(Token = "0x401E864")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Ease _playEase;

		// Token: 0x0401E865 RID: 125029
		[Token(Token = "0x401E865")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _levelUpParticle;

		// Token: 0x0401E866 RID: 125030
		[Token(Token = "0x401E866")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<SpecialOperatorExpPlayer.Clip> m_clips;

		// Token: 0x0401E867 RID: 125031
		[Token(Token = "0x401E867")]
		[FieldOffset(Offset = "0x48")]
		private SpecialOperatorExpPlayer.ClipTween m_tween;

		// Token: 0x0401E868 RID: 125032
		[Token(Token = "0x401E868")]
		[FieldOffset(Offset = "0x50")]
		private bool m_particleCanPlay;

		// Token: 0x0401E869 RID: 125033
		[Token(Token = "0x401E869")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0401E86A RID: 125034
		[Token(Token = "0x401E86A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsurePlayer;

		// Token: 0x0401E86B RID: 125035
		[Token(Token = "0x401E86B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__FillClips;

		// Token: 0x0401E86C RID: 125036
		[Token(Token = "0x401E86C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryFetchExpMapForCurrentEvolvePhase;

		// Token: 0x0401E86D RID: 125037
		[Token(Token = "0x401E86D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FetchLevelUpExp;

		// Token: 0x0401E86E RID: 125038
		[Token(Token = "0x401E86E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E5B RID: 15963
		[Token(Token = "0x2003E5B")]
		public struct Param
		{
			// Token: 0x0401E86F RID: 125039
			[Token(Token = "0x401E86F")]
			[FieldOffset(Offset = "0x0")]
			public string operatorId;

			// Token: 0x0401E870 RID: 125040
			[Token(Token = "0x401E870")]
			[FieldOffset(Offset = "0x8")]
			public RarityRank rarityRank;

			// Token: 0x0401E871 RID: 125041
			[Token(Token = "0x401E871")]
			[FieldOffset(Offset = "0xC")]
			public EvolvePhase evolvePhase;

			// Token: 0x0401E872 RID: 125042
			[Token(Token = "0x401E872")]
			[FieldOffset(Offset = "0x10")]
			public int levelStart;

			// Token: 0x0401E873 RID: 125043
			[Token(Token = "0x401E873")]
			[FieldOffset(Offset = "0x14")]
			public int levelEnd;

			// Token: 0x0401E874 RID: 125044
			[Token(Token = "0x401E874")]
			[FieldOffset(Offset = "0x18")]
			public int expStart;

			// Token: 0x0401E875 RID: 125045
			[Token(Token = "0x401E875")]
			[FieldOffset(Offset = "0x1C")]
			public int expEnd;
		}

		// Token: 0x02003E5C RID: 15964
		[Token(Token = "0x2003E5C")]
		private struct Clip : IProceduralClip
		{
			// Token: 0x06018D40 RID: 101696 RVA: 0x0009C180 File Offset: 0x0009A380
			[Token(Token = "0x6018D40")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510", Slot = "4")]
			public int GetLength()
			{
				return 0;
			}

			// Token: 0x0401E876 RID: 125046
			[Token(Token = "0x401E876")]
			[FieldOffset(Offset = "0x0")]
			public int levelValue;

			// Token: 0x0401E877 RID: 125047
			[Token(Token = "0x401E877")]
			[FieldOffset(Offset = "0x4")]
			public int expValueStart;

			// Token: 0x0401E878 RID: 125048
			[Token(Token = "0x401E878")]
			[FieldOffset(Offset = "0x8")]
			public int expValuePush;

			// Token: 0x0401E879 RID: 125049
			[Token(Token = "0x401E879")]
			[FieldOffset(Offset = "0xC")]
			public int expVolume;
		}

		// Token: 0x02003E5D RID: 15965
		[Token(Token = "0x2003E5D")]
		private class ClipTween : UIProceduralTween<SpecialOperatorExpPlayer.Clip>
		{
			// Token: 0x06018D41 RID: 101697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018D41")]
			[Address(RVA = "0x116A480", Offset = "0x1169080", VA = "0x18116A480")]
			public ClipTween(SpecialOperatorExpPlayer closure)
			{
			}

			// Token: 0x06018D42 RID: 101698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018D42")]
			[Address(RVA = "0x116A1C0", Offset = "0x1168DC0", VA = "0x18116A1C0", Slot = "4")]
			protected override void SampleClip(SpecialOperatorExpPlayer.Clip clip, int localIndex)
			{
			}

			// Token: 0x06018D43 RID: 101699 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018D43")]
			[Address(RVA = "0x116A090", Offset = "0x1168C90", VA = "0x18116A090", Slot = "5")]
			protected override void OnClipPlayed(SpecialOperatorExpPlayer.Clip clip)
			{
			}

			// Token: 0x0401E87A RID: 125050
			[Token(Token = "0x401E87A")]
			[FieldOffset(Offset = "0x48")]
			private readonly SpecialOperatorExpPlayer m_closure;

			// Token: 0x0401E87B RID: 125051
			[Token(Token = "0x401E87B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E87C RID: 125052
			[Token(Token = "0x401E87C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SampleClip;

			// Token: 0x0401E87D RID: 125053
			[Token(Token = "0x401E87D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnClipPlayed;
		}
	}
}
