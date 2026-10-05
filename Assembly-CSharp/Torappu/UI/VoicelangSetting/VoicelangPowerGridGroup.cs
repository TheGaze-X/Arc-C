using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BB6 RID: 15286
	[Token(Token = "0x2003BB6")]
	public class VoicelangPowerGridGroup : DataBinder<VoicelangPowerGroupViewProperty>
	{
		// Token: 0x06017F0B RID: 98059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F0B")]
		[Address(RVA = "0x106DE70", Offset = "0x106CA70", VA = "0x18106DE70", Slot = "7")]
		public override void OnValueChanged(VoicelangPowerGroupViewProperty property)
		{
		}

		// Token: 0x06017F0C RID: 98060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F0C")]
		[Address(RVA = "0x106E020", Offset = "0x106CC20", VA = "0x18106E020")]
		private void _BuildVirtualViews(VoicelangPowerGroupViewModel viewModel)
		{
		}

		// Token: 0x06017F0D RID: 98061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F0D")]
		[Address(RVA = "0x106E510", Offset = "0x106D110", VA = "0x18106E510")]
		private void _UpdateView(VoicelangPowerGroupViewModel viewModel)
		{
		}

		// Token: 0x06017F0E RID: 98062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F0E")]
		[Address(RVA = "0x106DF50", Offset = "0x106CB50", VA = "0x18106DF50")]
		protected void Update()
		{
		}

		// Token: 0x06017F0F RID: 98063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F0F")]
		[Address(RVA = "0x106E7D0", Offset = "0x106D3D0", VA = "0x18106E7D0")]
		public VoicelangPowerGridGroup()
		{
		}

		// Token: 0x0401CF3D RID: 118589
		[Token(Token = "0x401CF3D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIRecycleLayoutGroup m_content;

		// Token: 0x0401CF3E RID: 118590
		[Token(Token = "0x401CF3E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VoicelangPowerItemView m_prefab;

		// Token: 0x0401CF3F RID: 118591
		[Token(Token = "0x401CF3F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UISelectPowerEvent m_onClick;

		// Token: 0x0401CF40 RID: 118592
		[Token(Token = "0x401CF40")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image m_imgPower;

		// Token: 0x0401CF41 RID: 118593
		[Token(Token = "0x401CF41")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text m_lbPower;

		// Token: 0x0401CF42 RID: 118594
		[Token(Token = "0x401CF42")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Sprite m_powerAllSprite;

		// Token: 0x0401CF43 RID: 118595
		[Token(Token = "0x401CF43")]
		[FieldOffset(Offset = "0x50")]
		private List<UIRecycleLayoutAdapter.IVirtualView> m_viewList;

		// Token: 0x0401CF44 RID: 118596
		[Token(Token = "0x401CF44")]
		[FieldOffset(Offset = "0x58")]
		private VoicelangPowerGridGroup.Adapter m_adapter;

		// Token: 0x0401CF45 RID: 118597
		[Token(Token = "0x401CF45")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401CF46 RID: 118598
		[Token(Token = "0x401CF46")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__BuildVirtualViews;

		// Token: 0x0401CF47 RID: 118599
		[Token(Token = "0x401CF47")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x0401CF48 RID: 118600
		[Token(Token = "0x401CF48")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401CF49 RID: 118601
		[Token(Token = "0x401CF49")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BB7 RID: 15287
		[Token(Token = "0x2003BB7")]
		private class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x06017F10 RID: 98064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F10")]
			[Address(RVA = "0x105E1E0", Offset = "0x105CDE0", VA = "0x18105E1E0")]
			public Adapter(VoicelangPowerGridGroup closure)
			{
			}

			// Token: 0x06017F11 RID: 98065 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017F11")]
			[Address(RVA = "0x105DD10", Offset = "0x105C910", VA = "0x18105DD10", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x06017F12 RID: 98066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F12")]
			[Address(RVA = "0x105DD80", Offset = "0x105C980", VA = "0x18105DD80")]
			public void RebuildAll()
			{
			}

			// Token: 0x06017F13 RID: 98067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F13")]
			[Address(RVA = "0x105E0D0", Offset = "0x105CCD0", VA = "0x18105E0D0")]
			public void UpdateAllView()
			{
			}

			// Token: 0x0401CF4A RID: 118602
			[Token(Token = "0x401CF4A")]
			[FieldOffset(Offset = "0x18")]
			private VoicelangPowerGridGroup m_closure;

			// Token: 0x0401CF4B RID: 118603
			[Token(Token = "0x401CF4B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401CF4C RID: 118604
			[Token(Token = "0x401CF4C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0401CF4D RID: 118605
			[Token(Token = "0x401CF4D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RebuildAll;

			// Token: 0x0401CF4E RID: 118606
			[Token(Token = "0x401CF4E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_UpdateAllView;
		}
	}
}
