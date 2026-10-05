using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E11 RID: 19985
	[Token(Token = "0x2004E11")]
	public class NameCardV2MedalModuleView : NameCardV2BaseRemovableModuleView<NameCardV2MedalModuleModel>
	{
		// Token: 0x1700460E RID: 17934
		// (get) Token: 0x0601DDC0 RID: 122304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700460E")]
		protected UIPageListener pageListener
		{
			[Token(Token = "0x601DDC0")]
			[Address(RVA = "0x1776D30", Offset = "0x1775930", VA = "0x181776D30")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601DDC1 RID: 122305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDC1")]
		[Address(RVA = "0x1776970", Offset = "0x1775570", VA = "0x181776970", Slot = "20")]
		public override void OnModuleViewRendered(NameCardV2MedalModuleModel model)
		{
		}

		// Token: 0x0601DDC2 RID: 122306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDC2")]
		[Address(RVA = "0x1776C30", Offset = "0x1775830", VA = "0x181776C30")]
		public void OpenMedalState()
		{
		}

		// Token: 0x0601DDC3 RID: 122307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDC3")]
		[Address(RVA = "0x1776CC0", Offset = "0x17758C0", VA = "0x181776CC0")]
		public NameCardV2MedalModuleView()
		{
		}

		// Token: 0x0402794A RID: 162122
		[Token(Token = "0x402794A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private FriendNameCardMedalItem _medalItem;

		// Token: 0x0402794B RID: 162123
		[Token(Token = "0x402794B")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _medalSettingIcon;

		// Token: 0x0402794C RID: 162124
		[Token(Token = "0x402794C")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Button _openFriendMedalStateBtn;

		// Token: 0x0402794D RID: 162125
		[Token(Token = "0x402794D")]
		[FieldOffset(Offset = "0xD0")]
		private UIPageListener m_pageListener;

		// Token: 0x0402794E RID: 162126
		[Token(Token = "0x402794E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pageListener;

		// Token: 0x0402794F RID: 162127
		[Token(Token = "0x402794F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnModuleViewRendered;

		// Token: 0x04027950 RID: 162128
		[Token(Token = "0x4027950")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenMedalState;

		// Token: 0x04027951 RID: 162129
		[Token(Token = "0x4027951")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E12 RID: 19986
		[Token(Token = "0x2004E12")]
		public class VirtualView : NameCardV2RemovableModuleVirtualView<NameCardV2MedalModuleView, NameCardV2MedalModuleModel>
		{
			// Token: 0x0601DDC4 RID: 122308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DDC4")]
			[Address(RVA = "0x177F060", Offset = "0x177DC60", VA = "0x18177F060")]
			public VirtualView(NameCardV2BaseRemovableModuleView prefab, NameCardV2RemovableModuleBaseModel model)
			{
			}

			// Token: 0x04027952 RID: 162130
			[Token(Token = "0x4027952")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
