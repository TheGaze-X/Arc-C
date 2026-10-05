using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055A5 RID: 21925
	[Token(Token = "0x20055A5")]
	public class RL05CopperPackageDetailView : DataBinder<RL05CopperPackageProperty>
	{
		// Token: 0x06020327 RID: 131879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020327")]
		[Address(RVA = "0x1A4AA10", Offset = "0x1A49610", VA = "0x181A4AA10", Slot = "7")]
		public override void OnValueChanged(RL05CopperPackageProperty property)
		{
		}

		// Token: 0x06020328 RID: 131880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020328")]
		[Address(RVA = "0x1A4B130", Offset = "0x1A49D30", VA = "0x181A4B130")]
		public RL05CopperPackageDetailView()
		{
		}

		// Token: 0x0402B881 RID: 178305
		[Token(Token = "0x402B881")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0402B882 RID: 178306
		[Token(Token = "0x402B882")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _selectToggle;

		// Token: 0x0402B883 RID: 178307
		[Token(Token = "0x402B883")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _selAnim;

		// Token: 0x0402B884 RID: 178308
		[Token(Token = "0x402B884")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _typeIcon;

		// Token: 0x0402B885 RID: 178309
		[Token(Token = "0x402B885")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402B886 RID: 178310
		[Token(Token = "0x402B886")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402B887 RID: 178311
		[Token(Token = "0x402B887")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _drawnFlag;

		// Token: 0x0402B888 RID: 178312
		[Token(Token = "0x402B888")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _undrawnFlag;

		// Token: 0x0402B889 RID: 178313
		[Token(Token = "0x402B889")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _drawnCntNode;

		// Token: 0x0402B88A RID: 178314
		[Token(Token = "0x402B88A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _drawnCnt;

		// Token: 0x0402B88B RID: 178315
		[Token(Token = "0x402B88B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text[] _poemTextList;

		// Token: 0x0402B88C RID: 178316
		[Token(Token = "0x402B88C")]
		[FieldOffset(Offset = "0x80")]
		private UICompDialogFinder m_dlgFinder;

		// Token: 0x0402B88D RID: 178317
		[Token(Token = "0x402B88D")]
		[FieldOffset(Offset = "0x90")]
		private RL05CommonCopperItemWithFrameView m_itemView;

		// Token: 0x0402B88E RID: 178318
		[Token(Token = "0x402B88E")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikePlayerCopperItemViewModel m_curCopper;

		// Token: 0x0402B88F RID: 178319
		[Token(Token = "0x402B88F")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_selectTween;

		// Token: 0x0402B890 RID: 178320
		[Token(Token = "0x402B890")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402B891 RID: 178321
		[Token(Token = "0x402B891")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
