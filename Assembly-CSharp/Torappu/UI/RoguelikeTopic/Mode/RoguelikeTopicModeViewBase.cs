using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Mode
{
	// Token: 0x0200466B RID: 18027
	[Token(Token = "0x200466B")]
	public abstract class RoguelikeTopicModeViewBase : DataBinder<RoguelikeTopicModeViewProperty>
	{
		// Token: 0x0601B5F1 RID: 112113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5F1")]
		[Address(RVA = "0x14BE100", Offset = "0x14BCD00", VA = "0x1814BE100")]
		public void Init(RoguelikeTopicState.Bridge bridge)
		{
		}

		// Token: 0x0601B5F2 RID: 112114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5F2")]
		[Address(RVA = "0x14BE490", Offset = "0x14BD090", VA = "0x1814BE490", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B5F3 RID: 112115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5F3")]
		[Address(RVA = "0x14BE570", Offset = "0x14BD170", VA = "0x1814BE570", Slot = "8")]
		public virtual void SetEffectEnable(bool enable)
		{
		}

		// Token: 0x0601B5F4 RID: 112116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5F4")]
		[Address(RVA = "0x14BD530", Offset = "0x14BC130", VA = "0x1814BD530", Slot = "9")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x0601B5F5 RID: 112117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5F5")]
		[Address(RVA = "0x14BE650", Offset = "0x14BD250", VA = "0x1814BE650")]
		protected RoguelikeTopicModeViewBase()
		{
		}

		// Token: 0x040235F3 RID: 144883
		[Token(Token = "0x40235F3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _viewPath;

		// Token: 0x040235F4 RID: 144884
		[Token(Token = "0x40235F4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeTopicSubView _viewPrefab;

		// Token: 0x040235F5 RID: 144885
		[Token(Token = "0x40235F5")]
		[FieldOffset(Offset = "0x30")]
		private RoguelikeTopicSubView m_view;

		// Token: 0x040235F6 RID: 144886
		[Token(Token = "0x40235F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040235F7 RID: 144887
		[Token(Token = "0x40235F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040235F8 RID: 144888
		[Token(Token = "0x40235F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetEffectEnable;

		// Token: 0x040235F9 RID: 144889
		[Token(Token = "0x40235F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040235FA RID: 144890
		[Token(Token = "0x40235FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
