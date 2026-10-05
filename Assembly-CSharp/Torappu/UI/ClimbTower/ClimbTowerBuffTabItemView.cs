using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CEC RID: 23788
	[Token(Token = "0x2005CEC")]
	public class ClimbTowerBuffTabItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005100 RID: 20736
		// (get) Token: 0x0602270C RID: 141068 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602270D RID: 141069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005100")]
		public Action<ProfessionCategory, int> onTabClick
		{
			[Token(Token = "0x602270C")]
			[Address(RVA = "0x1CD0750", Offset = "0x1CCF350", VA = "0x181CD0750")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602270D")]
			[Address(RVA = "0x1CD07B0", Offset = "0x1CCF3B0", VA = "0x181CD07B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602270E RID: 141070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602270E")]
		[Address(RVA = "0x1CD0440", Offset = "0x1CCF040", VA = "0x181CD0440")]
		public void Render(int index, bool isSelect, TacticalBuffItemModel buffItemModel)
		{
		}

		// Token: 0x0602270F RID: 141071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602270F")]
		[Address(RVA = "0x1CD02F0", Offset = "0x1CCEEF0", VA = "0x181CD02F0")]
		public void OnTabClick()
		{
		}

		// Token: 0x06022710 RID: 141072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022710")]
		[Address(RVA = "0x1CD06F0", Offset = "0x1CCF2F0", VA = "0x181CD06F0")]
		public ClimbTowerBuffTabItemView()
		{
		}

		// Token: 0x0402F565 RID: 193893
		[Token(Token = "0x402F565")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _displayToggle;

		// Token: 0x0402F566 RID: 193894
		[Token(Token = "0x402F566")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textType1;

		// Token: 0x0402F567 RID: 193895
		[Token(Token = "0x402F567")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textType2;

		// Token: 0x0402F568 RID: 193896
		[Token(Token = "0x402F568")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgUnselectBg;

		// Token: 0x0402F569 RID: 193897
		[Token(Token = "0x402F569")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _colorLocked;

		// Token: 0x0402F56A RID: 193898
		[Token(Token = "0x402F56A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x0402F56C RID: 193900
		[Token(Token = "0x402F56C")]
		[FieldOffset(Offset = "0x60")]
		private int m_index;

		// Token: 0x0402F56D RID: 193901
		[Token(Token = "0x402F56D")]
		[FieldOffset(Offset = "0x68")]
		private TacticalBuffItemModel m_buffItemModel;

		// Token: 0x0402F56E RID: 193902
		[Token(Token = "0x402F56E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onTabClick;

		// Token: 0x0402F56F RID: 193903
		[Token(Token = "0x402F56F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onTabClick;

		// Token: 0x0402F570 RID: 193904
		[Token(Token = "0x402F570")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F571 RID: 193905
		[Token(Token = "0x402F571")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTabClick;

		// Token: 0x0402F572 RID: 193906
		[Token(Token = "0x402F572")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
