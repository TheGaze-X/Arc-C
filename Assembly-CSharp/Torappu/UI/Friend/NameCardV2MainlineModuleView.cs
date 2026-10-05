using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E0F RID: 19983
	[Token(Token = "0x2004E0F")]
	public class NameCardV2MainlineModuleView : NameCardV2BaseRemovableModuleView<NameCardV2MainlineModuleModel>
	{
		// Token: 0x0601DDBB RID: 122299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDBB")]
		[Address(RVA = "0x1776780", Offset = "0x1775380", VA = "0x181776780", Slot = "20")]
		public override void OnModuleViewRendered(NameCardV2MainlineModuleModel model)
		{
		}

		// Token: 0x0601DDBC RID: 122300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDBC")]
		[Address(RVA = "0x1776420", Offset = "0x1775020", VA = "0x181776420", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x0601DDBD RID: 122301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDBD")]
		[Address(RVA = "0x1776900", Offset = "0x1775500", VA = "0x181776900")]
		public NameCardV2MainlineModuleView()
		{
		}

		// Token: 0x0601DDBE RID: 122302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDBE")]
		[Address(RVA = "0x1772BA0", Offset = "0x17717A0", VA = "0x181772BA0")]
		private void <>xLuaBaseProxy_OnApplyStyle(NameCardV2SkinStyle P0)
		{
		}

		// Token: 0x0402793F RID: 162111
		[Token(Token = "0x402793F")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Colored")]
		private Image _bgImg;

		// Token: 0x04027940 RID: 162112
		[Token(Token = "0x4027940")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Colored")]
		private Image[] _coloredIcons;

		// Token: 0x04027941 RID: 162113
		[Token(Token = "0x4027941")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Colored")]
		private Text[] _coloredTexts;

		// Token: 0x04027942 RID: 162114
		[Token(Token = "0x4027942")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Image _chapterTitleBg;

		// Token: 0x04027943 RID: 162115
		[Token(Token = "0x4027943")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text _chapterEnName;

		// Token: 0x04027944 RID: 162116
		[Token(Token = "0x4027944")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text _stageCode;

		// Token: 0x04027945 RID: 162117
		[Token(Token = "0x4027945")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private TwoStateToggle _stageAllCompleteToggle;

		// Token: 0x04027946 RID: 162118
		[Token(Token = "0x4027946")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnModuleViewRendered;

		// Token: 0x04027947 RID: 162119
		[Token(Token = "0x4027947")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x04027948 RID: 162120
		[Token(Token = "0x4027948")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E10 RID: 19984
		[Token(Token = "0x2004E10")]
		public class VirtualView : NameCardV2RemovableModuleVirtualView<NameCardV2MainlineModuleView, NameCardV2MainlineModuleModel>
		{
			// Token: 0x0601DDBF RID: 122303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DDBF")]
			[Address(RVA = "0x177EE80", Offset = "0x177DA80", VA = "0x18177EE80")]
			public VirtualView(NameCardV2BaseRemovableModuleView prefab, NameCardV2RemovableModuleBaseModel model)
			{
			}

			// Token: 0x04027949 RID: 162121
			[Token(Token = "0x4027949")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
