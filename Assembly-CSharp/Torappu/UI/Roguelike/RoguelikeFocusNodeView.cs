using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005269 RID: 21097
	[Token(Token = "0x2005269")]
	public class RoguelikeFocusNodeView : DataBinder<RoguelikeFocusViewProperty>
	{
		// Token: 0x0601F210 RID: 127504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F210")]
		[Address(RVA = "0x18D7870", Offset = "0x18D6470", VA = "0x1818D7870")]
		private GameObject _LoadFocusImg(RoguelikeDungeonController controller, string topicId)
		{
			return null;
		}

		// Token: 0x0601F211 RID: 127505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F211")]
		[Address(RVA = "0x18D7360", Offset = "0x18D5F60", VA = "0x1818D7360", Slot = "7")]
		public override void OnValueChanged(RoguelikeFocusViewProperty property)
		{
		}

		// Token: 0x0601F212 RID: 127506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F212")]
		[Address(RVA = "0x18D6FB0", Offset = "0x18D5BB0", VA = "0x1818D6FB0")]
		public void Init(RoguelikeDungeonController controller)
		{
		}

		// Token: 0x0601F213 RID: 127507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F213")]
		[Address(RVA = "0x18D79B0", Offset = "0x18D65B0", VA = "0x1818D79B0")]
		public RoguelikeFocusNodeView()
		{
		}

		// Token: 0x04029C45 RID: 171077
		[Token(Token = "0x4029C45")]
		private const float TWEEN_DURATION = 0.2f;

		// Token: 0x04029C46 RID: 171078
		[Token(Token = "0x4029C46")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04029C47 RID: 171079
		[Token(Token = "0x4029C47")]
		[FieldOffset(Offset = "0x28")]
		private GameObject m_imageObj;

		// Token: 0x04029C48 RID: 171080
		[Token(Token = "0x4029C48")]
		[FieldOffset(Offset = "0x30")]
		private Image m_imageFocus;

		// Token: 0x04029C49 RID: 171081
		[Token(Token = "0x4029C49")]
		[FieldOffset(Offset = "0x38")]
		private IRoguelikeFocusNodePlugin m_plugin;

		// Token: 0x04029C4A RID: 171082
		[Token(Token = "0x4029C4A")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_alphaTweener;

		// Token: 0x04029C4B RID: 171083
		[Token(Token = "0x4029C4B")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_posTweener;

		// Token: 0x04029C4C RID: 171084
		[Token(Token = "0x4029C4C")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeDungeonController m_controller;

		// Token: 0x04029C4D RID: 171085
		[Token(Token = "0x4029C4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LoadFocusImg;

		// Token: 0x04029C4E RID: 171086
		[Token(Token = "0x4029C4E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04029C4F RID: 171087
		[Token(Token = "0x4029C4F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04029C50 RID: 171088
		[Token(Token = "0x4029C50")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
