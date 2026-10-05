using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200692E RID: 26926
	[Token(Token = "0x200692E")]
	public class StageUseOverrideBuffDialog : UICustomDialog<StageUseOverrideBuffDialog.Option>
	{
		// Token: 0x06026908 RID: 157960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026908")]
		[Address(RVA = "0x21B7A20", Offset = "0x21B6620", VA = "0x1821B7A20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026909 RID: 157961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026909")]
		[Address(RVA = "0x21B7450", Offset = "0x21B6050", VA = "0x1821B7450")]
		public void OnClick()
		{
		}

		// Token: 0x0602690A RID: 157962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602690A")]
		[Address(RVA = "0x21B74D0", Offset = "0x21B60D0", VA = "0x1821B74D0")]
		public void OnClose()
		{
		}

		// Token: 0x0602690B RID: 157963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602690B")]
		[Address(RVA = "0x21B73F0", Offset = "0x21B5FF0", VA = "0x1821B73F0", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602690C RID: 157964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602690C")]
		[Address(RVA = "0x21B7540", Offset = "0x21B6140", VA = "0x1821B7540", Slot = "7")]
		protected override void OnRender(StageUseOverrideBuffDialog.Option options)
		{
		}

		// Token: 0x0602690D RID: 157965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602690D")]
		[Address(RVA = "0x21B7C60", Offset = "0x21B6860", VA = "0x1821B7C60")]
		public StageUseOverrideBuffDialog()
		{
		}

		// Token: 0x04036645 RID: 222789
		[Token(Token = "0x4036645")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIRenderTextureImage _blurImg;

		// Token: 0x04036646 RID: 222790
		[Token(Token = "0x4036646")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _startContainer;

		// Token: 0x04036647 RID: 222791
		[Token(Token = "0x4036647")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StageStartBattleETButton _etButton;

		// Token: 0x04036648 RID: 222792
		[Token(Token = "0x4036648")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SimpleLayoutContent _rewardContent;

		// Token: 0x04036649 RID: 222793
		[Token(Token = "0x4036649")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _name;

		// Token: 0x0403664A RID: 222794
		[Token(Token = "0x403664A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _enName;

		// Token: 0x0403664B RID: 222795
		[Token(Token = "0x403664B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _ensureText;

		// Token: 0x0403664C RID: 222796
		[Token(Token = "0x403664C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _descText;

		// Token: 0x0403664D RID: 222797
		[Token(Token = "0x403664D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _remainCount;

		// Token: 0x0403664E RID: 222798
		[Token(Token = "0x403664E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _iconImg;

		// Token: 0x0403664F RID: 222799
		[Token(Token = "0x403664F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _countImg;

		// Token: 0x04036650 RID: 222800
		[Token(Token = "0x4036650")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _scaler;

		// Token: 0x04036651 RID: 222801
		[Token(Token = "0x4036651")]
		[FieldOffset(Offset = "0xB0")]
		private StageUseOverrideBuffDialog.Adapter m_adapter;

		// Token: 0x04036652 RID: 222802
		[Token(Token = "0x4036652")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isInited;

		// Token: 0x04036653 RID: 222803
		[Token(Token = "0x4036653")]
		[FieldOffset(Offset = "0xC0")]
		private StageStartBattleETButton m_etButton;

		// Token: 0x04036654 RID: 222804
		[Token(Token = "0x4036654")]
		[FieldOffset(Offset = "0xC8")]
		private Action m_onClickAction;

		// Token: 0x04036655 RID: 222805
		[Token(Token = "0x4036655")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036656 RID: 222806
		[Token(Token = "0x4036656")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04036657 RID: 222807
		[Token(Token = "0x4036657")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClose;

		// Token: 0x04036658 RID: 222808
		[Token(Token = "0x4036658")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04036659 RID: 222809
		[Token(Token = "0x4036659")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403665A RID: 222810
		[Token(Token = "0x403665A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200692F RID: 26927
		[Token(Token = "0x200692F")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17005B0D RID: 23309
			// (get) Token: 0x0602690E RID: 157966 RVA: 0x000CBB80 File Offset: 0x000C9D80
			[Token(Token = "0x17005B0D")]
			public override int count
			{
				[Token(Token = "0x602690E")]
				[Address(RVA = "0x21A5FC0", Offset = "0x21A4BC0", VA = "0x1821A5FC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602690F RID: 157967 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602690F")]
			[Address(RVA = "0x21A5650", Offset = "0x21A4250", VA = "0x1821A5650", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06026910 RID: 157968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026910")]
			[Address(RVA = "0x21A5D30", Offset = "0x21A4930", VA = "0x1821A5D30")]
			public Adapter()
			{
			}

			// Token: 0x0403665B RID: 222811
			[Token(Token = "0x403665B")]
			[FieldOffset(Offset = "0x20")]
			public float itemCardScale;

			// Token: 0x0403665C RID: 222812
			[Token(Token = "0x403665C")]
			[FieldOffset(Offset = "0x28")]
			public List<UIItemViewModel> itemViewModels;

			// Token: 0x0403665D RID: 222813
			[Token(Token = "0x403665D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403665E RID: 222814
			[Token(Token = "0x403665E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403665F RID: 222815
			[Token(Token = "0x403665F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006931 RID: 26929
		[Token(Token = "0x2006931")]
		public struct Option
		{
			// Token: 0x04036662 RID: 222818
			[Token(Token = "0x4036662")]
			[FieldOffset(Offset = "0x0")]
			public StageViewModel stageViewModel;

			// Token: 0x04036663 RID: 222819
			[Token(Token = "0x4036663")]
			[FieldOffset(Offset = "0x8")]
			public PreviewConfigViewModel previewConfigViewModel;

			// Token: 0x04036664 RID: 222820
			[Token(Token = "0x4036664")]
			[FieldOffset(Offset = "0x10")]
			public Action clickEvent;
		}
	}
}
