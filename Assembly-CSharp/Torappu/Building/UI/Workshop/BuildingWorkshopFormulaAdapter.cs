using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BE3 RID: 7139
	[Token(Token = "0x2001BE3")]
	public class BuildingWorkshopFormulaAdapter : LoopScrollAdapter<BuildingWorkshopFormulaAdapter.ViewHolder, IWorkshopFormula>
	{
		// Token: 0x14000059 RID: 89
		// (add) Token: 0x0600B215 RID: 45589 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600B216 RID: 45590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000059")]
		public event Action<IWorkshopFormula> onFormulaClicked
		{
			[Token(Token = "0x600B215")]
			[Address(RVA = "0x32BCA70", Offset = "0x32BB670", VA = "0x1832BCA70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600B216")]
			[Address(RVA = "0x32BCB70", Offset = "0x32BB770", VA = "0x1832BCB70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600B217 RID: 45591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B217")]
		[Address(RVA = "0x32BC430", Offset = "0x32BB030", VA = "0x1832BC430", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0600B218 RID: 45592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B218")]
		[Address(RVA = "0x32BC5C0", Offset = "0x32BB1C0", VA = "0x1832BC5C0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, BuildingWorkshopFormulaAdapter.ViewHolder holder, IWorkshopFormula data)
		{
		}

		// Token: 0x0600B219 RID: 45593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B219")]
		[Address(RVA = "0x32BC4F0", Offset = "0x32BB0F0", VA = "0x1832BC4F0", Slot = "12")]
		protected override void OnDataSourceChanged()
		{
		}

		// Token: 0x0600B21A RID: 45594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B21A")]
		[Address(RVA = "0x32BC860", Offset = "0x32BB460", VA = "0x1832BC860")]
		private void _OnFormulaClicked(IWorkshopFormula formula)
		{
		}

		// Token: 0x0600B21B RID: 45595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B21B")]
		[Address(RVA = "0x32BC8E0", Offset = "0x32BB4E0", VA = "0x1832BC8E0")]
		private void _TryRegisterAVGFirstItem(WorkshopFormulaView view)
		{
		}

		// Token: 0x0600B21C RID: 45596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B21C")]
		[Address(RVA = "0x32BCA00", Offset = "0x32BB600", VA = "0x1832BCA00")]
		public BuildingWorkshopFormulaAdapter()
		{
		}

		// Token: 0x0400ACBB RID: 44219
		[Token(Token = "0x400ACBB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _formulaProto;

		// Token: 0x0400ACBC RID: 44220
		[Token(Token = "0x400ACBC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _poolTransform;

		// Token: 0x0400ACBE RID: 44222
		[Token(Token = "0x400ACBE")]
		[FieldOffset(Offset = "0x70")]
		private bool m_AVGIsFirstItemRegistered;

		// Token: 0x0400ACBF RID: 44223
		[Token(Token = "0x400ACBF")]
		[FieldOffset(Offset = "0x74")]
		private int m_dataSourceCountCache;

		// Token: 0x0400ACC0 RID: 44224
		[Token(Token = "0x400ACC0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_onFormulaClicked;

		// Token: 0x0400ACC1 RID: 44225
		[Token(Token = "0x400ACC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_onFormulaClicked;

		// Token: 0x0400ACC2 RID: 44226
		[Token(Token = "0x400ACC2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0400ACC3 RID: 44227
		[Token(Token = "0x400ACC3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0400ACC4 RID: 44228
		[Token(Token = "0x400ACC4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x0400ACC5 RID: 44229
		[Token(Token = "0x400ACC5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnFormulaClicked;

		// Token: 0x0400ACC6 RID: 44230
		[Token(Token = "0x400ACC6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryRegisterAVGFirstItem;

		// Token: 0x0400ACC7 RID: 44231
		[Token(Token = "0x400ACC7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001BE4 RID: 7140
		[Token(Token = "0x2001BE4")]
		public class ViewHolder
		{
			// Token: 0x0600B21D RID: 45597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B21D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}
		}
	}
}
