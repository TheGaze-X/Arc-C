using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061AA RID: 25002
	[Token(Token = "0x20061AA")]
	public class BossRushStageChooseButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005523 RID: 21795
		// (get) Token: 0x06024153 RID: 147795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005523")]
		public AnimationWrapper buttonAnim
		{
			[Token(Token = "0x6024153")]
			[Address(RVA = "0x1EC3170", Offset = "0x1EC1D70", VA = "0x181EC3170")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024154 RID: 147796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024154")]
		[Address(RVA = "0x1EC2B50", Offset = "0x1EC1750", VA = "0x181EC2B50")]
		public void OnButtonClick()
		{
		}

		// Token: 0x06024155 RID: 147797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024155")]
		[Address(RVA = "0x1EC2960", Offset = "0x1EC1560", VA = "0x181EC2960")]
		public void Init(int cardNumber, Action<string> onStageGroupClicked)
		{
		}

		// Token: 0x06024156 RID: 147798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024156")]
		[Address(RVA = "0x1EC2BE0", Offset = "0x1EC17E0", VA = "0x181EC2BE0")]
		public void Render(BossRushStageChooseItemModel itemModel)
		{
		}

		// Token: 0x06024157 RID: 147799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024157")]
		[Address(RVA = "0x1EC2FE0", Offset = "0x1EC1BE0", VA = "0x181EC2FE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024158 RID: 147800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024158")]
		[Address(RVA = "0x1EC3110", Offset = "0x1EC1D10", VA = "0x181EC3110")]
		public BossRushStageChooseButtonView()
		{
		}

		// Token: 0x0403223F RID: 205375
		[Token(Token = "0x403223F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textStageGroupName;

		// Token: 0x04032240 RID: 205376
		[Token(Token = "0x4032240")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIColorGraphic _buttonGraphic;

		// Token: 0x04032241 RID: 205377
		[Token(Token = "0x4032241")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04032242 RID: 205378
		[Token(Token = "0x4032242")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _toggleBkg;

		// Token: 0x04032243 RID: 205379
		[Token(Token = "0x4032243")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _toggleAllComplete;

		// Token: 0x04032244 RID: 205380
		[Token(Token = "0x4032244")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _toggleCompleteFinal;

		// Token: 0x04032245 RID: 205381
		[Token(Token = "0x4032245")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle _toggleStageGroupUnlock;

		// Token: 0x04032246 RID: 205382
		[Token(Token = "0x4032246")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BossRushStageChooseButtonView.StageChooseButtonIconConfig[] _iconConfigList;

		// Token: 0x04032247 RID: 205383
		[Token(Token = "0x4032247")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject[] _bossIconList;

		// Token: 0x04032248 RID: 205384
		[Token(Token = "0x4032248")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _completeStageContent;

		// Token: 0x04032249 RID: 205385
		[Token(Token = "0x4032249")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textButtonNumber;

		// Token: 0x0403224A RID: 205386
		[Token(Token = "0x403224A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textUnlockCond;

		// Token: 0x0403224B RID: 205387
		[Token(Token = "0x403224B")]
		[FieldOffset(Offset = "0x78")]
		private BossRushStageChooseItemModel m_cachedModel;

		// Token: 0x0403224C RID: 205388
		[Token(Token = "0x403224C")]
		[FieldOffset(Offset = "0x80")]
		private BossRushStageChooseButtonView.Adapter m_adapter;

		// Token: 0x0403224D RID: 205389
		[Token(Token = "0x403224D")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0403224E RID: 205390
		[Token(Token = "0x403224E")]
		[FieldOffset(Offset = "0x90")]
		private Action<string> m_onStageGroupClicked;

		// Token: 0x0403224F RID: 205391
		[Token(Token = "0x403224F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buttonAnim;

		// Token: 0x04032250 RID: 205392
		[Token(Token = "0x4032250")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnButtonClick;

		// Token: 0x04032251 RID: 205393
		[Token(Token = "0x4032251")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04032252 RID: 205394
		[Token(Token = "0x4032252")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032253 RID: 205395
		[Token(Token = "0x4032253")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032254 RID: 205396
		[Token(Token = "0x4032254")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020061AB RID: 25003
		[Token(Token = "0x20061AB")]
		[Serializable]
		private struct StageChooseButtonIconConfig
		{
			// Token: 0x04032255 RID: 205397
			[Token(Token = "0x4032255")]
			[FieldOffset(Offset = "0x0")]
			public int completeStageCount;

			// Token: 0x04032256 RID: 205398
			[Token(Token = "0x4032256")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panelIcon;
		}

		// Token: 0x020061AC RID: 25004
		[Token(Token = "0x20061AC")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06024159 RID: 147801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024159")]
			[Address(RVA = "0x1EB4380", Offset = "0x1EB2F80", VA = "0x181EB4380")]
			public Adapter(BossRushStageChooseButtonView closure)
			{
			}

			// Token: 0x17005524 RID: 21796
			// (get) Token: 0x0602415A RID: 147802 RVA: 0x000C3168 File Offset: 0x000C1368
			[Token(Token = "0x17005524")]
			public override int count
			{
				[Token(Token = "0x602415A")]
				[Address(RVA = "0x1EB4660", Offset = "0x1EB3260", VA = "0x181EB4660", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602415B RID: 147803 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602415B")]
			[Address(RVA = "0x1EB3BC0", Offset = "0x1EB27C0", VA = "0x181EB3BC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04032257 RID: 205399
			[Token(Token = "0x4032257")]
			[FieldOffset(Offset = "0x20")]
			private BossRushStageChooseButtonView m_closure;

			// Token: 0x04032258 RID: 205400
			[Token(Token = "0x4032258")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04032259 RID: 205401
			[Token(Token = "0x4032259")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403225A RID: 205402
			[Token(Token = "0x403225A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
