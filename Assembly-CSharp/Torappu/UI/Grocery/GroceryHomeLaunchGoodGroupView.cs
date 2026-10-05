using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CAF RID: 19631
	[Token(Token = "0x2004CAF")]
	public class GroceryHomeLaunchGoodGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D6BD RID: 120509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6BD")]
		[Address(RVA = "0x16F5200", Offset = "0x16F3E00", VA = "0x1816F5200")]
		public void Render(GroceryHomeLaunchPanelGoodGroupModel groupModel)
		{
		}

		// Token: 0x0601D6BE RID: 120510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6BE")]
		[Address(RVA = "0x16F5560", Offset = "0x16F4160", VA = "0x1816F5560")]
		public GroceryHomeLaunchGoodGroupView()
		{
		}

		// Token: 0x04026C08 RID: 158728
		[Token(Token = "0x4026C08")]
		private const float ALPHA_NOT_CURRENT = 0.5f;

		// Token: 0x04026C09 RID: 158729
		[Token(Token = "0x4026C09")]
		private const float ALPHA_CURRENT = 1f;

		// Token: 0x04026C0A RID: 158730
		[Token(Token = "0x4026C0A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelCurr;

		// Token: 0x04026C0B RID: 158731
		[Token(Token = "0x4026C0B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelFuture;

		// Token: 0x04026C0C RID: 158732
		[Token(Token = "0x4026C0C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelPass;

		// Token: 0x04026C0D RID: 158733
		[Token(Token = "0x4026C0D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelStageLocked;

		// Token: 0x04026C0E RID: 158734
		[Token(Token = "0x4026C0E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text[] _textDateDesc;

		// Token: 0x04026C0F RID: 158735
		[Token(Token = "0x4026C0F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textGoodNameDesc;

		// Token: 0x04026C10 RID: 158736
		[Token(Token = "0x4026C10")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup[] _canvasContent;

		// Token: 0x04026C11 RID: 158737
		[Token(Token = "0x4026C11")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textStageUnlockDesc;

		// Token: 0x04026C12 RID: 158738
		[Token(Token = "0x4026C12")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image[] _goodIcon;

		// Token: 0x04026C13 RID: 158739
		[Token(Token = "0x4026C13")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026C14 RID: 158740
		[Token(Token = "0x4026C14")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026C15 RID: 158741
		[Token(Token = "0x4026C15")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
