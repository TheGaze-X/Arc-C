using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act44side.Battle.UI
{
	// Token: 0x020072EF RID: 29423
	[Token(Token = "0x20072EF")]
	public class Act44sideNormalUIPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700626B RID: 25195
		// (get) Token: 0x06029A1B RID: 170523 RVA: 0x000D6170 File Offset: 0x000D4370
		[Token(Token = "0x1700626B")]
		private int curScore
		{
			[Token(Token = "0x6029A1B")]
			[Address(RVA = "0x24EF710", Offset = "0x24EE310", VA = "0x1824EF710")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700626C RID: 25196
		// (get) Token: 0x06029A1C RID: 170524 RVA: 0x000D6188 File Offset: 0x000D4388
		[Token(Token = "0x1700626C")]
		private int totalScore
		{
			[Token(Token = "0x6029A1C")]
			[Address(RVA = "0x24EF780", Offset = "0x24EE380", VA = "0x1824EF780")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700626D RID: 25197
		// (get) Token: 0x06029A1D RID: 170525 RVA: 0x000D61A0 File Offset: 0x000D43A0
		[Token(Token = "0x1700626D")]
		private int curProgressMultiValue
		{
			[Token(Token = "0x6029A1D")]
			[Address(RVA = "0x24EF6A0", Offset = "0x24EE2A0", VA = "0x1824EF6A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06029A1E RID: 170526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A1E")]
		[Address(RVA = "0x24EF110", Offset = "0x24EDD10", VA = "0x1824EF110", Slot = "4")]
		public virtual void Init(Act44SideBattleManager envManager)
		{
		}

		// Token: 0x06029A1F RID: 170527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A1F")]
		[Address(RVA = "0x24EF2C0", Offset = "0x24EDEC0", VA = "0x1824EF2C0")]
		public void UpdateScoreDisplay()
		{
		}

		// Token: 0x06029A20 RID: 170528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A20")]
		[Address(RVA = "0x24EF510", Offset = "0x24EE110", VA = "0x1824EF510")]
		private void _PlaySliderProcessInitAnim()
		{
		}

		// Token: 0x06029A21 RID: 170529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A21")]
		[Address(RVA = "0x24EF640", Offset = "0x24EE240", VA = "0x1824EF640")]
		public Act44sideNormalUIPanel()
		{
		}

		// Token: 0x0403B8DE RID: 243934
		[Token(Token = "0x403B8DE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Progress Params")]
		private Slider _scoreSlider;

		// Token: 0x0403B8DF RID: 243935
		[Token(Token = "0x403B8DF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Progress Params")]
		private UIAnimationLocation _progressPerform;

		// Token: 0x0403B8E0 RID: 243936
		[Token(Token = "0x403B8E0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Progress Params")]
		private Text _progressMultiText;

		// Token: 0x0403B8E1 RID: 243937
		[Token(Token = "0x403B8E1")]
		[FieldOffset(Offset = "0x38")]
		protected Act44SideBattleManager m_envManager;

		// Token: 0x0403B8E2 RID: 243938
		[Token(Token = "0x403B8E2")]
		[FieldOffset(Offset = "0x40")]
		private bool _isScoreReadyToUpdate;

		// Token: 0x0403B8E3 RID: 243939
		[Token(Token = "0x403B8E3")]
		private const string PROGRESS_MULTI_TEXT_FORMAT = "×{0}";

		// Token: 0x0403B8E4 RID: 243940
		[Token(Token = "0x403B8E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curScore;

		// Token: 0x0403B8E5 RID: 243941
		[Token(Token = "0x403B8E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_totalScore;

		// Token: 0x0403B8E6 RID: 243942
		[Token(Token = "0x403B8E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_curProgressMultiValue;

		// Token: 0x0403B8E7 RID: 243943
		[Token(Token = "0x403B8E7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403B8E8 RID: 243944
		[Token(Token = "0x403B8E8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateScoreDisplay;

		// Token: 0x0403B8E9 RID: 243945
		[Token(Token = "0x403B8E9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlaySliderProcessInitAnim;

		// Token: 0x0403B8EA RID: 243946
		[Token(Token = "0x403B8EA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
