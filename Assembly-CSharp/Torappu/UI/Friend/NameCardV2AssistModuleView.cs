using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DF4 RID: 19956
	[Token(Token = "0x2004DF4")]
	public class NameCardV2AssistModuleView : NameCardV2BaseRemovableModuleView<NameCardV2AssistModuleModel>
	{
		// Token: 0x17004601 RID: 17921
		// (get) Token: 0x0601DD3A RID: 122170 RVA: 0x000AC740 File Offset: 0x000AA940
		[Token(Token = "0x17004601")]
		public bool isSwitchTweenShow
		{
			[Token(Token = "0x601DD3A")]
			[Address(RVA = "0x1759AB0", Offset = "0x17586B0", VA = "0x181759AB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601DD3B RID: 122171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD3B")]
		[Address(RVA = "0x17591D0", Offset = "0x1757DD0", VA = "0x1817591D0", Slot = "20")]
		public override void OnModuleViewRendered(NameCardV2AssistModuleModel model)
		{
		}

		// Token: 0x0601DD3C RID: 122172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD3C")]
		[Address(RVA = "0x1758F50", Offset = "0x1757B50", VA = "0x181758F50", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x0601DD3D RID: 122173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD3D")]
		[Address(RVA = "0x1759850", Offset = "0x1758450", VA = "0x181759850")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DD3E RID: 122174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD3E")]
		[Address(RVA = "0x1759540", Offset = "0x1758140", VA = "0x181759540")]
		public void OpenAssistState()
		{
		}

		// Token: 0x0601DD3F RID: 122175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD3F")]
		[Address(RVA = "0x17595D0", Offset = "0x17581D0", VA = "0x1817595D0")]
		public void SwitchModuleStyle()
		{
		}

		// Token: 0x0601DD40 RID: 122176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD40")]
		[Address(RVA = "0x1759A40", Offset = "0x1758640", VA = "0x181759A40")]
		public NameCardV2AssistModuleView()
		{
		}

		// Token: 0x0601DD41 RID: 122177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD41")]
		[Address(RVA = "0x1759840", Offset = "0x1758440", VA = "0x181759840")]
		private void <>xLuaBaseProxy_OnApplyStyle(NameCardV2SkinStyle P0)
		{
		}

		// Token: 0x0402783F RID: 161855
		[Token(Token = "0x402783F")]
		private const int ASSIST_CHAR_SLOT = 3;

		// Token: 0x04027840 RID: 161856
		[Token(Token = "0x4027840")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Colored")]
		private Image _bgImg;

		// Token: 0x04027841 RID: 161857
		[Token(Token = "0x4027841")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Colored")]
		private Image[] _coloredIcons;

		// Token: 0x04027842 RID: 161858
		[Token(Token = "0x4027842")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Colored")]
		private Text[] _coloredTexts;

		// Token: 0x04027843 RID: 161859
		[Token(Token = "0x4027843")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private SimpleLayoutContent _assistCharContent;

		// Token: 0x04027844 RID: 161860
		[Token(Token = "0x4027844")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x04027845 RID: 161861
		[Token(Token = "0x4027845")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIAnimationLocation _switchIconAnim;

		// Token: 0x04027846 RID: 161862
		[Token(Token = "0x4027846")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject[] _switchIconGos;

		// Token: 0x04027847 RID: 161863
		[Token(Token = "0x4027847")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Button _openAssistStateBtn;

		// Token: 0x04027848 RID: 161864
		[Token(Token = "0x4027848")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIColorGraphic _clickColorGraphic;

		// Token: 0x04027849 RID: 161865
		[Token(Token = "0x4027849")]
		[FieldOffset(Offset = "0x110")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0402784A RID: 161866
		[Token(Token = "0x402784A")]
		[FieldOffset(Offset = "0x118")]
		private bool m_hasInited;

		// Token: 0x0402784B RID: 161867
		[Token(Token = "0x402784B")]
		[FieldOffset(Offset = "0x120")]
		private Tween m_switchIconTween;

		// Token: 0x0402784C RID: 161868
		[Token(Token = "0x402784C")]
		[FieldOffset(Offset = "0x128")]
		private NameCardV2AssistModuleModel m_cachedModel;

		// Token: 0x0402784D RID: 161869
		[Token(Token = "0x402784D")]
		[FieldOffset(Offset = "0x130")]
		private NameCardV2AssistModuleView.AssistCharAdapter m_adapter;

		// Token: 0x0402784E RID: 161870
		[Token(Token = "0x402784E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isSwitchTweenShow;

		// Token: 0x0402784F RID: 161871
		[Token(Token = "0x402784F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnModuleViewRendered;

		// Token: 0x04027850 RID: 161872
		[Token(Token = "0x4027850")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x04027851 RID: 161873
		[Token(Token = "0x4027851")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027852 RID: 161874
		[Token(Token = "0x4027852")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OpenAssistState;

		// Token: 0x04027853 RID: 161875
		[Token(Token = "0x4027853")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SwitchModuleStyle;

		// Token: 0x04027854 RID: 161876
		[Token(Token = "0x4027854")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DF5 RID: 19957
		[Token(Token = "0x2004DF5")]
		public class VirtualView : NameCardV2RemovableModuleVirtualView<NameCardV2AssistModuleView, NameCardV2AssistModuleModel>
		{
			// Token: 0x0601DD42 RID: 122178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DD42")]
			[Address(RVA = "0x17680A0", Offset = "0x1766CA0", VA = "0x1817680A0")]
			public VirtualView(NameCardV2BaseRemovableModuleView prefab, NameCardV2RemovableModuleBaseModel model)
			{
			}

			// Token: 0x04027855 RID: 161877
			[Token(Token = "0x4027855")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004DF6 RID: 19958
		[Token(Token = "0x2004DF6")]
		private class AssistCharAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601DD43 RID: 122179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DD43")]
			[Address(RVA = "0x1750960", Offset = "0x174F560", VA = "0x181750960")]
			public AssistCharAdapter(NameCardV2AssistModuleView closure)
			{
			}

			// Token: 0x17004602 RID: 17922
			// (get) Token: 0x0601DD44 RID: 122180 RVA: 0x000AC758 File Offset: 0x000AA958
			[Token(Token = "0x17004602")]
			public override int count
			{
				[Token(Token = "0x601DD44")]
				[Address(RVA = "0x17509E0", Offset = "0x174F5E0", VA = "0x1817509E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601DD45 RID: 122181 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DD45")]
			[Address(RVA = "0x17506B0", Offset = "0x174F2B0", VA = "0x1817506B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04027856 RID: 161878
			[Token(Token = "0x4027856")]
			[FieldOffset(Offset = "0x20")]
			private NameCardV2AssistModuleView m_closure;

			// Token: 0x04027857 RID: 161879
			[Token(Token = "0x4027857")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04027858 RID: 161880
			[Token(Token = "0x4027858")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04027859 RID: 161881
			[Token(Token = "0x4027859")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
