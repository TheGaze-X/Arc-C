using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004341 RID: 17217
	[Token(Token = "0x2004341")]
	public class SandboxV2LogisticsSquadView : DataBinder<SandboxV2LogisticsHomeProperty>
	{
		// Token: 0x0601A713 RID: 108307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A713")]
		[Address(RVA = "0x138C690", Offset = "0x138B290", VA = "0x18138C690", Slot = "7")]
		public override void OnValueChanged(SandboxV2LogisticsHomeProperty property)
		{
		}

		// Token: 0x0601A714 RID: 108308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A714")]
		[Address(RVA = "0x138C990", Offset = "0x138B590", VA = "0x18138C990")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A715 RID: 108309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A715")]
		[Address(RVA = "0x138CAB0", Offset = "0x138B6B0", VA = "0x18138CAB0")]
		public SandboxV2LogisticsSquadView()
		{
		}

		// Token: 0x040219C6 RID: 137670
		[Token(Token = "0x40219C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtBasementLevel;

		// Token: 0x040219C7 RID: 137671
		[Token(Token = "0x40219C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtPopulation;

		// Token: 0x040219C8 RID: 137672
		[Token(Token = "0x40219C8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _layoutContent;

		// Token: 0x040219C9 RID: 137673
		[Token(Token = "0x40219C9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelUpdateBtn;

		// Token: 0x040219CA RID: 137674
		[Token(Token = "0x40219CA")]
		[FieldOffset(Offset = "0x40")]
		private SandboxV2LogisticsHomeViewModel m_cachedViewModel;

		// Token: 0x040219CB RID: 137675
		[Token(Token = "0x40219CB")]
		[FieldOffset(Offset = "0x48")]
		private SandboxV2LogisticsSquadView.SquadAdapter m_squadAdapter;

		// Token: 0x040219CC RID: 137676
		[Token(Token = "0x40219CC")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x040219CD RID: 137677
		[Token(Token = "0x40219CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040219CE RID: 137678
		[Token(Token = "0x40219CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040219CF RID: 137679
		[Token(Token = "0x40219CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004342 RID: 17218
		[Token(Token = "0x2004342")]
		private class SquadAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A716 RID: 108310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A716")]
			[Address(RVA = "0x13A5AC0", Offset = "0x13A46C0", VA = "0x1813A5AC0")]
			public SquadAdapter(SandboxV2LogisticsSquadView closure)
			{
			}

			// Token: 0x17003EBC RID: 16060
			// (get) Token: 0x0601A717 RID: 108311 RVA: 0x000A1C88 File Offset: 0x0009FE88
			[Token(Token = "0x17003EBC")]
			public override int count
			{
				[Token(Token = "0x601A717")]
				[Address(RVA = "0x13A5B40", Offset = "0x13A4740", VA = "0x1813A5B40", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A718 RID: 108312 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A718")]
			[Address(RVA = "0x13A57A0", Offset = "0x13A43A0", VA = "0x1813A57A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040219D0 RID: 137680
			[Token(Token = "0x40219D0")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2LogisticsSquadView m_closure;

			// Token: 0x040219D1 RID: 137681
			[Token(Token = "0x40219D1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040219D2 RID: 137682
			[Token(Token = "0x40219D2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040219D3 RID: 137683
			[Token(Token = "0x40219D3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
