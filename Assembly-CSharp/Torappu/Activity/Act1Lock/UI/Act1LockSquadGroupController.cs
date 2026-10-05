using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078BF RID: 30911
	[Token(Token = "0x20078BF")]
	public class Act1LockSquadGroupController : DataBinder<SquadGroupViewProperty>
	{
		// Token: 0x1700656C RID: 25964
		// (get) Token: 0x0602B596 RID: 177558 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B597 RID: 177559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700656C")]
		public Action<int> onSlotClicked
		{
			[Token(Token = "0x602B596")]
			[Address(RVA = "0x272EE90", Offset = "0x272DA90", VA = "0x18272EE90")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B597")]
			[Address(RVA = "0x272EEF0", Offset = "0x272DAF0", VA = "0x18272EEF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B598 RID: 177560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B598")]
		[Address(RVA = "0x272EBF0", Offset = "0x272D7F0", VA = "0x18272EBF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B599 RID: 177561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B599")]
		[Address(RVA = "0x272E980", Offset = "0x272D580", VA = "0x18272E980", Slot = "7")]
		public override void OnValueChanged(SquadGroupViewProperty property)
		{
		}

		// Token: 0x0602B59A RID: 177562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B59A")]
		[Address(RVA = "0x272ED30", Offset = "0x272D930", VA = "0x18272ED30")]
		private void _OnCharCardClicked(int index)
		{
		}

		// Token: 0x0602B59B RID: 177563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B59B")]
		[Address(RVA = "0x272EE10", Offset = "0x272DA10", VA = "0x18272EE10")]
		public Act1LockSquadGroupController()
		{
		}

		// Token: 0x0403EADE RID: 256734
		[Token(Token = "0x403EADE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _squadLayout;

		// Token: 0x0403EADF RID: 256735
		[Token(Token = "0x403EADF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelInterlockLogo;

		// Token: 0x0403EAE0 RID: 256736
		[Token(Token = "0x403EAE0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Show when the squad is not editable")]
		private GameObject _panelDisableLock;

		// Token: 0x0403EAE1 RID: 256737
		[Token(Token = "0x403EAE1")]
		[FieldOffset(Offset = "0x38")]
		private Act1LockSquadGroupController.SquadAdapter m_squadAdapter;

		// Token: 0x0403EAE2 RID: 256738
		[Token(Token = "0x403EAE2")]
		[FieldOffset(Offset = "0x40")]
		private SquadViewModel m_squadModel;

		// Token: 0x0403EAE3 RID: 256739
		[Token(Token = "0x403EAE3")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0403EAE4 RID: 256740
		[Token(Token = "0x403EAE4")]
		[FieldOffset(Offset = "0x50")]
		private SpriteHub m_professionHub;

		// Token: 0x0403EAE5 RID: 256741
		[Token(Token = "0x403EAE5")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isCardClickable;

		// Token: 0x0403EAE7 RID: 256743
		[Token(Token = "0x403EAE7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSlotClicked;

		// Token: 0x0403EAE8 RID: 256744
		[Token(Token = "0x403EAE8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSlotClicked;

		// Token: 0x0403EAE9 RID: 256745
		[Token(Token = "0x403EAE9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403EAEA RID: 256746
		[Token(Token = "0x403EAEA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403EAEB RID: 256747
		[Token(Token = "0x403EAEB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCharCardClicked;

		// Token: 0x0403EAEC RID: 256748
		[Token(Token = "0x403EAEC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020078C0 RID: 30912
		[Token(Token = "0x20078C0")]
		private class SquadAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602B59C RID: 177564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B59C")]
			[Address(RVA = "0x2734DE0", Offset = "0x27339E0", VA = "0x182734DE0")]
			public SquadAdapter(Act1LockSquadGroupController controller)
			{
			}

			// Token: 0x1700656D RID: 25965
			// (get) Token: 0x0602B59D RID: 177565 RVA: 0x000DB768 File Offset: 0x000D9968
			[Token(Token = "0x1700656D")]
			public override int count
			{
				[Token(Token = "0x602B59D")]
				[Address(RVA = "0x2734E60", Offset = "0x2733A60", VA = "0x182734E60", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B59E RID: 177566 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B59E")]
			[Address(RVA = "0x2734B10", Offset = "0x2733710", VA = "0x182734B10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403EAED RID: 256749
			[Token(Token = "0x403EAED")]
			[FieldOffset(Offset = "0x20")]
			private Act1LockSquadGroupController m_closure;

			// Token: 0x0403EAEE RID: 256750
			[Token(Token = "0x403EAEE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403EAEF RID: 256751
			[Token(Token = "0x403EAEF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403EAF0 RID: 256752
			[Token(Token = "0x403EAF0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
