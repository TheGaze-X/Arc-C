using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CommonFriendAssist
{
	// Token: 0x02005BC2 RID: 23490
	[Token(Token = "0x2005BC2")]
	public class CommonFriendAssistProfessionTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022106 RID: 139526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022106")]
		[Address(RVA = "0x1C8B730", Offset = "0x1C8A330", VA = "0x181C8B730")]
		public void Render(CommonFriendAssistViewModel.ProfTabModel model, CommonFriendAssistProfessionTabView.ICtrl ctrl)
		{
		}

		// Token: 0x06022107 RID: 139527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022107")]
		[Address(RVA = "0x1C8B620", Offset = "0x1C8A220", VA = "0x181C8B620")]
		public void EventOnClick()
		{
		}

		// Token: 0x06022108 RID: 139528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022108")]
		[Address(RVA = "0x1C8B870", Offset = "0x1C8A470", VA = "0x181C8B870")]
		public CommonFriendAssistProfessionTabView()
		{
		}

		// Token: 0x0402EBA2 RID: 191394
		[Token(Token = "0x402EBA2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _selectStateToggle;

		// Token: 0x0402EBA3 RID: 191395
		[Token(Token = "0x402EBA3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _selectedProfessionImg;

		// Token: 0x0402EBA4 RID: 191396
		[Token(Token = "0x402EBA4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _unselectedProfessionImg;

		// Token: 0x0402EBA5 RID: 191397
		[Token(Token = "0x402EBA5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _hotspot;

		// Token: 0x0402EBA6 RID: 191398
		[Token(Token = "0x402EBA6")]
		[FieldOffset(Offset = "0x38")]
		private CommonFriendAssistProfessionTabView.ICtrl m_ctrl;

		// Token: 0x0402EBA7 RID: 191399
		[Token(Token = "0x402EBA7")]
		[FieldOffset(Offset = "0x40")]
		private ProfessionCategory m_professionCategory;

		// Token: 0x0402EBA8 RID: 191400
		[Token(Token = "0x402EBA8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EBA9 RID: 191401
		[Token(Token = "0x402EBA9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0402EBAA RID: 191402
		[Token(Token = "0x402EBAA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005BC3 RID: 23491
		[Token(Token = "0x2005BC3")]
		public interface ICtrl
		{
			// Token: 0x06022109 RID: 139529
			[Token(Token = "0x6022109")]
			void ChangeProfGrp(ProfessionCategory prof);
		}
	}
}
