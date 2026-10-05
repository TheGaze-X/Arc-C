using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BF3 RID: 7155
	[Token(Token = "0x2001BF3")]
	public class WorkshopFormulaView : MonoBehaviour
	{
		// Token: 0x1400005B RID: 91
		// (add) Token: 0x0600B26D RID: 45677 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600B26E RID: 45678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400005B")]
		public event Action<IWorkshopFormula> onFormulaClicked
		{
			[Token(Token = "0x600B26D")]
			[Address(RVA = "0x32EB1E0", Offset = "0x32E9DE0", VA = "0x1832EB1E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600B26E")]
			[Address(RVA = "0x32EB290", Offset = "0x32E9E90", VA = "0x1832EB290")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600B26F RID: 45679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B26F")]
		[Address(RVA = "0x32EAA30", Offset = "0x32E9630", VA = "0x1832EAA30")]
		public void Setup(IWorkshopFormula formula)
		{
		}

		// Token: 0x0600B270 RID: 45680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B270")]
		[Address(RVA = "0x32EAE50", Offset = "0x32E9A50", VA = "0x1832EAE50")]
		private void _Init(IWorkshopFormula formula)
		{
		}

		// Token: 0x0600B271 RID: 45681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B271")]
		[Address(RVA = "0x32EB100", Offset = "0x32E9D00", VA = "0x1832EB100")]
		private void _OnFormulaClicked()
		{
		}

		// Token: 0x0600B272 RID: 45682 RVA: 0x00044088 File Offset: 0x00042288
		[Token(Token = "0x600B272")]
		[Address(RVA = "0x32EB120", Offset = "0x32E9D20", VA = "0x1832EB120")]
		private bool _OnFormulaLongPressed()
		{
			return default(bool);
		}

		// Token: 0x0600B273 RID: 45683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B273")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public WorkshopFormulaView()
		{
		}

		// Token: 0x0400AD7E RID: 44414
		[Token(Token = "0x400AD7E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _outcomeContainer;

		// Token: 0x0400AD7F RID: 44415
		[Token(Token = "0x400AD7F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _targetScale;

		// Token: 0x0400AD80 RID: 44416
		[Token(Token = "0x400AD80")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _costContainer;

		// Token: 0x0400AD81 RID: 44417
		[Token(Token = "0x400AD81")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400AD82 RID: 44418
		[Token(Token = "0x400AD82")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCost;

		// Token: 0x0400AD83 RID: 44419
		[Token(Token = "0x400AD83")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0400AD84 RID: 44420
		[Token(Token = "0x400AD84")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelHotspot;

		// Token: 0x0400AD85 RID: 44421
		[Token(Token = "0x400AD85")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textUnlockCond;

		// Token: 0x0400AD86 RID: 44422
		[Token(Token = "0x400AD86")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UILongPressButton _btnFormula;

		// Token: 0x0400AD87 RID: 44423
		[Token(Token = "0x400AD87")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _apCostLabel;

		// Token: 0x0400AD88 RID: 44424
		[Token(Token = "0x400AD88")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _apCostPanel;

		// Token: 0x0400AD89 RID: 44425
		[Token(Token = "0x400AD89")]
		[FieldOffset(Offset = "0x70")]
		private bool m_inited;

		// Token: 0x0400AD8A RID: 44426
		[Token(Token = "0x400AD8A")]
		[FieldOffset(Offset = "0x78")]
		private WorkshopFormulaView.CostAdapter m_costAdapter;

		// Token: 0x0400AD8B RID: 44427
		[Token(Token = "0x400AD8B")]
		[FieldOffset(Offset = "0x80")]
		private UIItemCard m_outcomeItemCard;

		// Token: 0x0400AD8C RID: 44428
		[Token(Token = "0x400AD8C")]
		[FieldOffset(Offset = "0x88")]
		private IWorkshopFormula m_currentFormula;

		// Token: 0x02001BF4 RID: 7156
		[Token(Token = "0x2001BF4")]
		private class CostAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600B274 RID: 45684 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B274")]
			[Address(RVA = "0x32E4030", Offset = "0x32E2C30", VA = "0x1832E4030")]
			public CostAdapter(IWorkshopFormula formula)
			{
			}

			// Token: 0x17001553 RID: 5459
			// (get) Token: 0x0600B275 RID: 45685 RVA: 0x000440A0 File Offset: 0x000422A0
			[Token(Token = "0x17001553")]
			public override int count
			{
				[Token(Token = "0x600B275")]
				[Address(RVA = "0x32E40B0", Offset = "0x32E2CB0", VA = "0x1832E40B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B276 RID: 45686 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B276")]
			[Address(RVA = "0x32E3E60", Offset = "0x32E2A60", VA = "0x1832E3E60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400AD8E RID: 44430
			[Token(Token = "0x400AD8E")]
			[FieldOffset(Offset = "0x20")]
			public IWorkshopFormula formula;

			// Token: 0x0400AD8F RID: 44431
			[Token(Token = "0x400AD8F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400AD90 RID: 44432
			[Token(Token = "0x400AD90")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400AD91 RID: 44433
			[Token(Token = "0x400AD91")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
