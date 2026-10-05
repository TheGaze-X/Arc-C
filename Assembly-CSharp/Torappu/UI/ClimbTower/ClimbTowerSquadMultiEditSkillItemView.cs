using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D7B RID: 23931
	[Token(Token = "0x2005D7B")]
	public class ClimbTowerSquadMultiEditSkillItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170051CD RID: 20941
		// (get) Token: 0x06022AEA RID: 142058 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022AEB RID: 142059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051CD")]
		public Action<int, string> onSkillSelect
		{
			[Token(Token = "0x6022AEA")]
			[Address(RVA = "0x1D3ECE0", Offset = "0x1D3D8E0", VA = "0x181D3ECE0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022AEB")]
			[Address(RVA = "0x1D3ED40", Offset = "0x1D3D940", VA = "0x181D3ED40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022AEC RID: 142060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AEC")]
		[Address(RVA = "0x1D3E940", Offset = "0x1D3D540", VA = "0x181D3E940")]
		public void Render(int cardId, bool isSelect, SkillItemViewModel skillModel)
		{
		}

		// Token: 0x06022AED RID: 142061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AED")]
		[Address(RVA = "0x1D3EBD0", Offset = "0x1D3D7D0", VA = "0x181D3EBD0")]
		private void _HideAll()
		{
		}

		// Token: 0x06022AEE RID: 142062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AEE")]
		[Address(RVA = "0x1D3E860", Offset = "0x1D3D460", VA = "0x181D3E860")]
		public void OnSkillSelect()
		{
		}

		// Token: 0x06022AEF RID: 142063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AEF")]
		[Address(RVA = "0x1D3EC70", Offset = "0x1D3D870", VA = "0x181D3EC70")]
		public ClimbTowerSquadMultiEditSkillItemView()
		{
		}

		// Token: 0x0402FAE1 RID: 195297
		[Token(Token = "0x402FAE1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectBgGo;

		// Token: 0x0402FAE2 RID: 195298
		[Token(Token = "0x402FAE2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _iconSelectGo;

		// Token: 0x0402FAE3 RID: 195299
		[Token(Token = "0x402FAE3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x0402FAE4 RID: 195300
		[Token(Token = "0x402FAE4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x0402FAE5 RID: 195301
		[Token(Token = "0x402FAE5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _lockPartGo;

		// Token: 0x0402FAE6 RID: 195302
		[Token(Token = "0x402FAE6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgSkill;

		// Token: 0x0402FAE7 RID: 195303
		[Token(Token = "0x402FAE7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textSkillLv;

		// Token: 0x0402FAE8 RID: 195304
		[Token(Token = "0x402FAE8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgSpecializeLv;

		// Token: 0x0402FAE9 RID: 195305
		[Token(Token = "0x402FAE9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Sprite[] _skillLevelImages;

		// Token: 0x0402FAEA RID: 195306
		[Token(Token = "0x402FAEA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402FAEB RID: 195307
		[Token(Token = "0x402FAEB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _unselectAlpha;

		// Token: 0x0402FAEC RID: 195308
		[Token(Token = "0x402FAEC")]
		[FieldOffset(Offset = "0x6C")]
		private int m_cardId;

		// Token: 0x0402FAED RID: 195309
		[Token(Token = "0x402FAED")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isSelect;

		// Token: 0x0402FAEE RID: 195310
		[Token(Token = "0x402FAEE")]
		[FieldOffset(Offset = "0x78")]
		private SkillItemViewModel m_skillModel;

		// Token: 0x0402FAF0 RID: 195312
		[Token(Token = "0x402FAF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSkillSelect;

		// Token: 0x0402FAF1 RID: 195313
		[Token(Token = "0x402FAF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSkillSelect;

		// Token: 0x0402FAF2 RID: 195314
		[Token(Token = "0x402FAF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402FAF3 RID: 195315
		[Token(Token = "0x402FAF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HideAll;

		// Token: 0x0402FAF4 RID: 195316
		[Token(Token = "0x402FAF4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSkillSelect;

		// Token: 0x0402FAF5 RID: 195317
		[Token(Token = "0x402FAF5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
