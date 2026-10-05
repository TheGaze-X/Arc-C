using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Mode
{
	// Token: 0x0200466A RID: 18026
	[Token(Token = "0x200466A")]
	public class RoguelikeTopicModeTab : RoguelikeTopicModeViewBase
	{
		// Token: 0x0601B5EA RID: 112106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5EA")]
		[Address(RVA = "0x14BD1A0", Offset = "0x14BBDA0", VA = "0x1814BD1A0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601B5EB RID: 112107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5EB")]
		[Address(RVA = "0x14BD210", Offset = "0x14BBE10", VA = "0x1814BD210", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B5EC RID: 112108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5EC")]
		[Address(RVA = "0x14BD2D0", Offset = "0x14BBED0", VA = "0x1814BD2D0")]
		public void SetVisible(bool v)
		{
		}

		// Token: 0x0601B5ED RID: 112109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5ED")]
		[Address(RVA = "0x14BD5A0", Offset = "0x14BC1A0", VA = "0x1814BD5A0")]
		private void _SetActive()
		{
		}

		// Token: 0x0601B5EE RID: 112110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5EE")]
		[Address(RVA = "0x14BD610", Offset = "0x14BC210", VA = "0x1814BD610")]
		public RoguelikeTopicModeTab()
		{
		}

		// Token: 0x0601B5EF RID: 112111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5EF")]
		[Address(RVA = "0x14BD530", Offset = "0x14BC130", VA = "0x1814BD530")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0601B5F0 RID: 112112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5F0")]
		[Address(RVA = "0x14BD590", Offset = "0x14BC190", VA = "0x1814BD590")]
		private void <>xLuaBaseProxy_OnValueChanged(RoguelikeTopicModeViewProperty P0)
		{
		}

		// Token: 0x040235EA RID: 144874
		[Token(Token = "0x40235EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeTopicModeViewType _viewType;

		// Token: 0x040235EB RID: 144875
		[Token(Token = "0x40235EB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x040235EC RID: 144876
		[Token(Token = "0x40235EC")]
		[FieldOffset(Offset = "0x50")]
		private bool m_visible;

		// Token: 0x040235ED RID: 144877
		[Token(Token = "0x40235ED")]
		[FieldOffset(Offset = "0x51")]
		private bool m_firstSetVisible;

		// Token: 0x040235EE RID: 144878
		[Token(Token = "0x40235EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040235EF RID: 144879
		[Token(Token = "0x40235EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040235F0 RID: 144880
		[Token(Token = "0x40235F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x040235F1 RID: 144881
		[Token(Token = "0x40235F1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetActive;

		// Token: 0x040235F2 RID: 144882
		[Token(Token = "0x40235F2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
