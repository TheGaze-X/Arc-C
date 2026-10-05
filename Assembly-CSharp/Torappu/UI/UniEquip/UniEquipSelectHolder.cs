using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C31 RID: 15409
	[Token(Token = "0x2003C31")]
	public class UniEquipSelectHolder : DataBinder<UniEquipSelectProperty>
	{
		// Token: 0x1700398E RID: 14734
		// (get) Token: 0x0601818A RID: 98698 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018189 RID: 98697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700398E")]
		public UIPage page
		{
			[Token(Token = "0x601818A")]
			[Address(RVA = "0x1098FA0", Offset = "0x1097BA0", VA = "0x181098FA0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6018189")]
			[Address(RVA = "0x1099000", Offset = "0x1097C00", VA = "0x181099000")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601818B RID: 98699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601818B")]
		[Address(RVA = "0x1098D20", Offset = "0x1097920", VA = "0x181098D20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601818C RID: 98700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601818C")]
		[Address(RVA = "0x1098760", Offset = "0x1097360", VA = "0x181098760", Slot = "7")]
		public override void OnValueChanged(UniEquipSelectProperty property)
		{
		}

		// Token: 0x0601818D RID: 98701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601818D")]
		[Address(RVA = "0x1098EC0", Offset = "0x1097AC0", VA = "0x181098EC0")]
		private void _OnRenderFinish()
		{
		}

		// Token: 0x0601818E RID: 98702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601818E")]
		[Address(RVA = "0x1098F30", Offset = "0x1097B30", VA = "0x181098F30")]
		public UniEquipSelectHolder()
		{
		}

		// Token: 0x0401D3E9 RID: 119785
		[Token(Token = "0x401D3E9")]
		private const float TWEEN_DURATION = 0.23f;

		// Token: 0x0401D3EA RID: 119786
		[Token(Token = "0x401D3EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401D3EB RID: 119787
		[Token(Token = "0x401D3EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UniEquipAttributeView _attibuteView;

		// Token: 0x0401D3EC RID: 119788
		[Token(Token = "0x401D3EC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UniEquipDescView _traitDescView;

		// Token: 0x0401D3ED RID: 119789
		[Token(Token = "0x401D3ED")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UniEquipInfoDetailTalentContentGroup _talentGroup;

		// Token: 0x0401D3EE RID: 119790
		[Token(Token = "0x401D3EE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0401D3EF RID: 119791
		[Token(Token = "0x401D3EF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIStringEvent _onUnlockAction;

		// Token: 0x0401D3F0 RID: 119792
		[Token(Token = "0x401D3F0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIStringEvent _onDetailAction;

		// Token: 0x0401D3F1 RID: 119793
		[Token(Token = "0x401D3F1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIStringEvent _onSelectAction;

		// Token: 0x0401D3F2 RID: 119794
		[Token(Token = "0x401D3F2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIStringEvent _onChangeAction;

		// Token: 0x0401D3F3 RID: 119795
		[Token(Token = "0x401D3F3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIStringEvent _onLevelUpAction;

		// Token: 0x0401D3F4 RID: 119796
		[Token(Token = "0x401D3F4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0401D3F5 RID: 119797
		[Token(Token = "0x401D3F5")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Action onRenderFinish;

		// Token: 0x0401D3F6 RID: 119798
		[Token(Token = "0x401D3F6")]
		[FieldOffset(Offset = "0x80")]
		private UniEquipSelectHolder.Adapter m_adapter;

		// Token: 0x0401D3F7 RID: 119799
		[Token(Token = "0x401D3F7")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0401D3F8 RID: 119800
		[Token(Token = "0x401D3F8")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_tween;

		// Token: 0x0401D3FA RID: 119802
		[Token(Token = "0x401D3FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0401D3FB RID: 119803
		[Token(Token = "0x401D3FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0401D3FC RID: 119804
		[Token(Token = "0x401D3FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D3FD RID: 119805
		[Token(Token = "0x401D3FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D3FE RID: 119806
		[Token(Token = "0x401D3FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnRenderFinish;

		// Token: 0x0401D3FF RID: 119807
		[Token(Token = "0x401D3FF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C32 RID: 15410
		[Token(Token = "0x2003C32")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x1700398F RID: 14735
			// (get) Token: 0x0601818F RID: 98703 RVA: 0x00099558 File Offset: 0x00097758
			[Token(Token = "0x1700398F")]
			public override int count
			{
				[Token(Token = "0x601818F")]
				[Address(RVA = "0x108DD00", Offset = "0x108C900", VA = "0x18108DD00", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018190 RID: 98704 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018190")]
			[Address(RVA = "0x108D680", Offset = "0x108C280", VA = "0x18108D680", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06018191 RID: 98705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018191")]
			[Address(RVA = "0x108DB80", Offset = "0x108C780", VA = "0x18108DB80")]
			private void _TraceForUnlockAvg(GameObject selectObj, GameObject unlockObj)
			{
			}

			// Token: 0x06018192 RID: 98706 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018192")]
			[Address(RVA = "0x108DAB0", Offset = "0x108C6B0", VA = "0x18108DAB0")]
			private void _TraceForLvlupAvg(GameObject obj)
			{
			}

			// Token: 0x06018193 RID: 98707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018193")]
			[Address(RVA = "0x108DCA0", Offset = "0x108C8A0", VA = "0x18108DCA0")]
			public Adapter()
			{
			}

			// Token: 0x0401D400 RID: 119808
			[Token(Token = "0x401D400")]
			[FieldOffset(Offset = "0x20")]
			[NonSerialized]
			public UIStringEvent onUnlockAction;

			// Token: 0x0401D401 RID: 119809
			[Token(Token = "0x401D401")]
			[FieldOffset(Offset = "0x28")]
			[NonSerialized]
			public UIStringEvent onDetailAction;

			// Token: 0x0401D402 RID: 119810
			[Token(Token = "0x401D402")]
			[FieldOffset(Offset = "0x30")]
			[NonSerialized]
			public UIStringEvent onSelectAction;

			// Token: 0x0401D403 RID: 119811
			[Token(Token = "0x401D403")]
			[FieldOffset(Offset = "0x38")]
			[NonSerialized]
			public UIStringEvent onChangeAction;

			// Token: 0x0401D404 RID: 119812
			[Token(Token = "0x401D404")]
			[FieldOffset(Offset = "0x40")]
			[NonSerialized]
			public UIStringEvent onLevelUpAction;

			// Token: 0x0401D405 RID: 119813
			[Token(Token = "0x401D405")]
			[FieldOffset(Offset = "0x48")]
			public UniEquipSelectList equipListViewModel;

			// Token: 0x0401D406 RID: 119814
			[Token(Token = "0x401D406")]
			[FieldOffset(Offset = "0x50")]
			public bool needShining;

			// Token: 0x0401D407 RID: 119815
			[Token(Token = "0x401D407")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D408 RID: 119816
			[Token(Token = "0x401D408")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401D409 RID: 119817
			[Token(Token = "0x401D409")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__TraceForUnlockAvg;

			// Token: 0x0401D40A RID: 119818
			[Token(Token = "0x401D40A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__TraceForLvlupAvg;

			// Token: 0x0401D40B RID: 119819
			[Token(Token = "0x401D40B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
