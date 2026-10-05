using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A22 RID: 31266
	[Token(Token = "0x2007A22")]
	public class Act13sideDailyMissionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170066BB RID: 26299
		// (get) Token: 0x0602BD0B RID: 179467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066BB")]
		public Button btnNavToPool
		{
			[Token(Token = "0x602BD0B")]
			[Address(RVA = "0x27AD4B0", Offset = "0x27AC0B0", VA = "0x1827AD4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066BC RID: 26300
		// (get) Token: 0x0602BD0C RID: 179468 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BD0D RID: 179469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066BC")]
		public Action<int> onMissionCancel
		{
			[Token(Token = "0x602BD0C")]
			[Address(RVA = "0x27AD510", Offset = "0x27AC110", VA = "0x1827AD510")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BD0D")]
			[Address(RVA = "0x27AD690", Offset = "0x27AC290", VA = "0x1827AD690")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170066BD RID: 26301
		// (get) Token: 0x0602BD0E RID: 179470 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BD0F RID: 179471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066BD")]
		public Action<int> onMissionCommit
		{
			[Token(Token = "0x602BD0E")]
			[Address(RVA = "0x27AD570", Offset = "0x27AC170", VA = "0x1827AD570")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BD0F")]
			[Address(RVA = "0x27AD710", Offset = "0x27AC310", VA = "0x1827AD710")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170066BE RID: 26302
		// (get) Token: 0x0602BD10 RID: 179472 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BD11 RID: 179473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066BE")]
		public Action onNavToPool
		{
			[Token(Token = "0x602BD10")]
			[Address(RVA = "0x27AD5D0", Offset = "0x27AC1D0", VA = "0x1827AD5D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BD11")]
			[Address(RVA = "0x27AD790", Offset = "0x27AC390", VA = "0x1827AD790")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170066BF RID: 26303
		// (get) Token: 0x0602BD12 RID: 179474 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BD13 RID: 179475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066BF")]
		public Action<string> onNavToStage
		{
			[Token(Token = "0x602BD12")]
			[Address(RVA = "0x27AD630", Offset = "0x27AC230", VA = "0x1827AD630")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BD13")]
			[Address(RVA = "0x27AD810", Offset = "0x27AC410", VA = "0x1827AD810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602BD14 RID: 179476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD14")]
		[Address(RVA = "0x27ACD50", Offset = "0x27AB950", VA = "0x1827ACD50")]
		public void Render(string actId, int position, int boardMax, Act13sideDailyMissionItemViewModel itemModel)
		{
		}

		// Token: 0x0602BD15 RID: 179477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD15")]
		[Address(RVA = "0x27ACBB0", Offset = "0x27AB7B0", VA = "0x1827ACBB0")]
		public void PlayCompleAnim(Action onComplete)
		{
		}

		// Token: 0x0602BD16 RID: 179478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD16")]
		[Address(RVA = "0x27AC820", Offset = "0x27AB420", VA = "0x1827AC820")]
		public void OnBtnCommit()
		{
		}

		// Token: 0x0602BD17 RID: 179479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD17")]
		[Address(RVA = "0x27AC710", Offset = "0x27AB310", VA = "0x1827AC710")]
		public void OnBtnCancel()
		{
		}

		// Token: 0x0602BD18 RID: 179480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD18")]
		[Address(RVA = "0x27AC930", Offset = "0x27AB530", VA = "0x1827AC930")]
		public void OnNavToPool()
		{
		}

		// Token: 0x0602BD19 RID: 179481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD19")]
		[Address(RVA = "0x27ACA40", Offset = "0x27AB640", VA = "0x1827ACA40")]
		public void OnNavToStage()
		{
		}

		// Token: 0x0602BD1A RID: 179482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD1A")]
		[Address(RVA = "0x27AD440", Offset = "0x27AC040", VA = "0x1827AD440")]
		public Act13sideDailyMissionItemView()
		{
		}

		// Token: 0x0403F650 RID: 259664
		[Token(Token = "0x403F650")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x0403F651 RID: 259665
		[Token(Token = "0x403F651")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _completeMaskGo;

		// Token: 0x0403F652 RID: 259666
		[Token(Token = "0x403F652")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x0403F653 RID: 259667
		[Token(Token = "0x403F653")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _navPartGo;

		// Token: 0x0403F654 RID: 259668
		[Token(Token = "0x403F654")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _battleEndGo;

		// Token: 0x0403F655 RID: 259669
		[Token(Token = "0x403F655")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textPrincipalName;

		// Token: 0x0403F656 RID: 259670
		[Token(Token = "0x403F656")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textMissionName;

		// Token: 0x0403F657 RID: 259671
		[Token(Token = "0x403F657")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textMissionDesc;

		// Token: 0x0403F658 RID: 259672
		[Token(Token = "0x403F658")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textPrestigeDesc;

		// Token: 0x0403F659 RID: 259673
		[Token(Token = "0x403F659")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textAgenda;

		// Token: 0x0403F65A RID: 259674
		[Token(Token = "0x403F65A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgOrgLogo;

		// Token: 0x0403F65B RID: 259675
		[Token(Token = "0x403F65B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgPrincipalBg;

		// Token: 0x0403F65C RID: 259676
		[Token(Token = "0x403F65C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _btnNavGo;

		// Token: 0x0403F65D RID: 259677
		[Token(Token = "0x403F65D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _btnCommitGo;

		// Token: 0x0403F65E RID: 259678
		[Token(Token = "0x403F65E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SimpleLayoutContent _rewardList;

		// Token: 0x0403F65F RID: 259679
		[Token(Token = "0x403F65F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0403F660 RID: 259680
		[Token(Token = "0x403F660")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _completeAnim;

		// Token: 0x0403F661 RID: 259681
		[Token(Token = "0x403F661")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Button _btnNavToPool;

		// Token: 0x0403F666 RID: 259686
		[Token(Token = "0x403F666")]
		[FieldOffset(Offset = "0xD0")]
		private int m_boardIdx;

		// Token: 0x0403F667 RID: 259687
		[Token(Token = "0x403F667")]
		[FieldOffset(Offset = "0xD8")]
		private Act13sideDailyMissionItemViewModel m_itemModel;

		// Token: 0x0403F668 RID: 259688
		[Token(Token = "0x403F668")]
		[FieldOffset(Offset = "0xE0")]
		private Act13sideDailyMissionItemView.Adapter m_adapter;

		// Token: 0x0403F669 RID: 259689
		[Token(Token = "0x403F669")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_btnNavToPool;

		// Token: 0x0403F66A RID: 259690
		[Token(Token = "0x403F66A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onMissionCancel;

		// Token: 0x0403F66B RID: 259691
		[Token(Token = "0x403F66B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onMissionCancel;

		// Token: 0x0403F66C RID: 259692
		[Token(Token = "0x403F66C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onMissionCommit;

		// Token: 0x0403F66D RID: 259693
		[Token(Token = "0x403F66D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_onMissionCommit;

		// Token: 0x0403F66E RID: 259694
		[Token(Token = "0x403F66E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_onNavToPool;

		// Token: 0x0403F66F RID: 259695
		[Token(Token = "0x403F66F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_onNavToPool;

		// Token: 0x0403F670 RID: 259696
		[Token(Token = "0x403F670")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_onNavToStage;

		// Token: 0x0403F671 RID: 259697
		[Token(Token = "0x403F671")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_onNavToStage;

		// Token: 0x0403F672 RID: 259698
		[Token(Token = "0x403F672")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F673 RID: 259699
		[Token(Token = "0x403F673")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_PlayCompleAnim;

		// Token: 0x0403F674 RID: 259700
		[Token(Token = "0x403F674")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBtnCommit;

		// Token: 0x0403F675 RID: 259701
		[Token(Token = "0x403F675")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBtnCancel;

		// Token: 0x0403F676 RID: 259702
		[Token(Token = "0x403F676")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnNavToPool;

		// Token: 0x0403F677 RID: 259703
		[Token(Token = "0x403F677")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnNavToStage;

		// Token: 0x0403F678 RID: 259704
		[Token(Token = "0x403F678")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A23 RID: 31267
		[Token(Token = "0x2007A23")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602BD1B RID: 179483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BD1B")]
			[Address(RVA = "0x27BF970", Offset = "0x27BE570", VA = "0x1827BF970")]
			public Adapter(Act13sideDailyMissionItemView closure)
			{
			}

			// Token: 0x170066C0 RID: 26304
			// (get) Token: 0x0602BD1C RID: 179484 RVA: 0x000DD538 File Offset: 0x000DB738
			[Token(Token = "0x170066C0")]
			public override int count
			{
				[Token(Token = "0x602BD1C")]
				[Address(RVA = "0x27BFCE0", Offset = "0x27BE8E0", VA = "0x1827BFCE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602BD1D RID: 179485 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BD1D")]
			[Address(RVA = "0x27BEB20", Offset = "0x27BD720", VA = "0x1827BEB20", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403F679 RID: 259705
			[Token(Token = "0x403F679")]
			[FieldOffset(Offset = "0x20")]
			private Act13sideDailyMissionItemView m_closure;

			// Token: 0x0403F67A RID: 259706
			[Token(Token = "0x403F67A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403F67B RID: 259707
			[Token(Token = "0x403F67B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403F67C RID: 259708
			[Token(Token = "0x403F67C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
