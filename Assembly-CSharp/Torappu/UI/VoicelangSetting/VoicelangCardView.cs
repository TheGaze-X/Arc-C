using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BB5 RID: 15285
	[Token(Token = "0x2003BB5")]
	public class VoicelangCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017F07 RID: 98055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F07")]
		[Address(RVA = "0x106D750", Offset = "0x106C350", VA = "0x18106D750")]
		public void RenderCard(VoicelangCardViewModel viewModel)
		{
		}

		// Token: 0x06017F08 RID: 98056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F08")]
		[Address(RVA = "0x106DD90", Offset = "0x106C990", VA = "0x18106DD90")]
		public void SetListenerIfNot(UISelectCardEvent listener)
		{
		}

		// Token: 0x06017F09 RID: 98057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F09")]
		[Address(RVA = "0x106D690", Offset = "0x106C290", VA = "0x18106D690")]
		public void OnClick()
		{
		}

		// Token: 0x06017F0A RID: 98058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F0A")]
		[Address(RVA = "0x106DE10", Offset = "0x106CA10", VA = "0x18106DE10")]
		public VoicelangCardView()
		{
		}

		// Token: 0x0401CF2D RID: 118573
		[Token(Token = "0x401CF2D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text lb_name;

		// Token: 0x0401CF2E RID: 118574
		[Token(Token = "0x401CF2E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage image_ChrPortrait;

		// Token: 0x0401CF2F RID: 118575
		[Token(Token = "0x401CF2F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject go_HightLight;

		// Token: 0x0401CF30 RID: 118576
		[Token(Token = "0x401CF30")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject go_selectMask;

		// Token: 0x0401CF31 RID: 118577
		[Token(Token = "0x401CF31")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject go_New;

		// Token: 0x0401CF32 RID: 118578
		[Token(Token = "0x401CF32")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text lb_langTypeName;

		// Token: 0x0401CF33 RID: 118579
		[Token(Token = "0x401CF33")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject go_undownloadMask;

		// Token: 0x0401CF34 RID: 118580
		[Token(Token = "0x401CF34")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject go_voiceMark;

		// Token: 0x0401CF35 RID: 118581
		[Token(Token = "0x401CF35")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text lb_lackVoice;

		// Token: 0x0401CF36 RID: 118582
		[Token(Token = "0x401CF36")]
		[FieldOffset(Offset = "0x60")]
		private UISelectCardEvent m_onClick;

		// Token: 0x0401CF37 RID: 118583
		[Token(Token = "0x401CF37")]
		[FieldOffset(Offset = "0x68")]
		private string m_portraitCache;

		// Token: 0x0401CF38 RID: 118584
		[Token(Token = "0x401CF38")]
		[FieldOffset(Offset = "0x70")]
		private VoicelangCardViewModel m_viewModel;

		// Token: 0x0401CF39 RID: 118585
		[Token(Token = "0x401CF39")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x0401CF3A RID: 118586
		[Token(Token = "0x401CF3A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetListenerIfNot;

		// Token: 0x0401CF3B RID: 118587
		[Token(Token = "0x401CF3B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401CF3C RID: 118588
		[Token(Token = "0x401CF3C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
