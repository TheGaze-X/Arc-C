using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.TemplateTrap;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act32side
{
	// Token: 0x0200748A RID: 29834
	[Token(Token = "0x200748A")]
	public class Act32SideTrapView : TemplateTrapView, IHotfixable
	{
		// Token: 0x17006332 RID: 25394
		// (get) Token: 0x0602A133 RID: 172339 RVA: 0x000D7628 File Offset: 0x000D5828
		[Token(Token = "0x17006332")]
		public override TemplateTrapState.TemplateTrapSaveType saveType
		{
			[Token(Token = "0x602A133")]
			[Address(RVA = "0x25BE310", Offset = "0x25BCF10", VA = "0x1825BE310", Slot = "8")]
			get
			{
				return TemplateTrapState.TemplateTrapSaveType.NONE;
			}
		}

		// Token: 0x0602A134 RID: 172340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A134")]
		[Address(RVA = "0x25BE170", Offset = "0x25BCD70", VA = "0x1825BE170", Slot = "10")]
		public override void SetAction(TemplateTrapState.ActionConfig action)
		{
		}

		// Token: 0x0602A135 RID: 172341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A135")]
		[Address(RVA = "0x25BE220", Offset = "0x25BCE20", VA = "0x1825BE220", Slot = "9")]
		public override Tween StartFadeInTween()
		{
			return null;
		}

		// Token: 0x0602A136 RID: 172342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A136")]
		[Address(RVA = "0x25BDCA0", Offset = "0x25BC8A0", VA = "0x1825BDCA0", Slot = "7")]
		public override void OnValueChanged(TemplateTrapProperty property)
		{
		}

		// Token: 0x0602A137 RID: 172343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A137")]
		[Address(RVA = "0x25BDC30", Offset = "0x25BC830", VA = "0x1825BDC30")]
		public void OnClickSaveSquad()
		{
		}

		// Token: 0x0602A138 RID: 172344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A138")]
		[Address(RVA = "0x25BDD40", Offset = "0x25BC940", VA = "0x1825BDD40")]
		public void RenderView(TemplateTrapGroupViewModel viewModel)
		{
		}

		// Token: 0x0602A139 RID: 172345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A139")]
		[Address(RVA = "0x25BE2B0", Offset = "0x25BCEB0", VA = "0x1825BE2B0")]
		public Act32SideTrapView()
		{
		}

		// Token: 0x0403C64F RID: 247375
		[Token(Token = "0x403C64F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0403C650 RID: 247376
		[Token(Token = "0x403C650")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<PrefabInstHolder> _trapItemViewList;

		// Token: 0x0403C651 RID: 247377
		[Token(Token = "0x403C651")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<PrefabInstHolder> _selectedViewList;

		// Token: 0x0403C652 RID: 247378
		[Token(Token = "0x403C652")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasObject _atlasHub;

		// Token: 0x0403C653 RID: 247379
		[Token(Token = "0x403C653")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _selectCount;

		// Token: 0x0403C654 RID: 247380
		[Token(Token = "0x403C654")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _saveBtn;

		// Token: 0x0403C655 RID: 247381
		[Token(Token = "0x403C655")]
		[FieldOffset(Offset = "0x50")]
		private Action<string, int> m_onSelectAction;

		// Token: 0x0403C656 RID: 247382
		[Token(Token = "0x403C656")]
		[FieldOffset(Offset = "0x58")]
		private Action m_onSaveSquad;

		// Token: 0x0403C657 RID: 247383
		[Token(Token = "0x403C657")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_saveType;

		// Token: 0x0403C658 RID: 247384
		[Token(Token = "0x403C658")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetAction;

		// Token: 0x0403C659 RID: 247385
		[Token(Token = "0x403C659")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_StartFadeInTween;

		// Token: 0x0403C65A RID: 247386
		[Token(Token = "0x403C65A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403C65B RID: 247387
		[Token(Token = "0x403C65B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickSaveSquad;

		// Token: 0x0403C65C RID: 247388
		[Token(Token = "0x403C65C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403C65D RID: 247389
		[Token(Token = "0x403C65D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
