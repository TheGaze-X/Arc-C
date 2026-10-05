using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005165 RID: 20837
	[Token(Token = "0x2005165")]
	public class DeepSeaRPNodeChoiceItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170047B5 RID: 18357
		// (get) Token: 0x0601EC9A RID: 126106 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EC9B RID: 126107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047B5")]
		public Action<int, Act17sideData.EventData> onItemSelect
		{
			[Token(Token = "0x601EC9A")]
			[Address(RVA = "0x186BEC0", Offset = "0x186AAC0", VA = "0x18186BEC0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601EC9B")]
			[Address(RVA = "0x186BF80", Offset = "0x186AB80", VA = "0x18186BF80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170047B6 RID: 18358
		// (get) Token: 0x0601EC9C RID: 126108 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EC9D RID: 126109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047B6")]
		public Action onLeave
		{
			[Token(Token = "0x601EC9C")]
			[Address(RVA = "0x186BF20", Offset = "0x186AB20", VA = "0x18186BF20")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601EC9D")]
			[Address(RVA = "0x186C000", Offset = "0x186AC00", VA = "0x18186C000")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601EC9E RID: 126110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC9E")]
		[Address(RVA = "0x186BAB0", Offset = "0x186A6B0", VA = "0x18186BAB0")]
		public void Render(DeepSeaRPChoiceModel choiceModel, int position)
		{
		}

		// Token: 0x0601EC9F RID: 126111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC9F")]
		[Address(RVA = "0x186B9D0", Offset = "0x186A5D0", VA = "0x18186B9D0")]
		public void OnItemSelected()
		{
		}

		// Token: 0x0601ECA0 RID: 126112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECA0")]
		[Address(RVA = "0x186B8C0", Offset = "0x186A4C0", VA = "0x18186B8C0")]
		public void OnBtnLeave()
		{
		}

		// Token: 0x0601ECA1 RID: 126113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECA1")]
		[Address(RVA = "0x186BE60", Offset = "0x186AA60", VA = "0x18186BE60")]
		public DeepSeaRPNodeChoiceItemView()
		{
		}

		// Token: 0x04029477 RID: 169079
		[Token(Token = "0x4029477")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leavePanelGo;

		// Token: 0x04029478 RID: 169080
		[Token(Token = "0x4029478")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _commonPanelGo;

		// Token: 0x04029479 RID: 169081
		[Token(Token = "0x4029479")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _btnChoiceGo;

		// Token: 0x0402947A RID: 169082
		[Token(Token = "0x402947A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _activeBg;

		// Token: 0x0402947B RID: 169083
		[Token(Token = "0x402947B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0402947C RID: 169084
		[Token(Token = "0x402947C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int _heightLow;

		// Token: 0x0402947D RID: 169085
		[Token(Token = "0x402947D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int _heightHigh;

		// Token: 0x0402947E RID: 169086
		[Token(Token = "0x402947E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textLeave;

		// Token: 0x0402947F RID: 169087
		[Token(Token = "0x402947F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04029480 RID: 169088
		[Token(Token = "0x4029480")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textUnlockDes;

		// Token: 0x04029481 RID: 169089
		[Token(Token = "0x4029481")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _imgTriangle;

		// Token: 0x04029482 RID: 169090
		[Token(Token = "0x4029482")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _colorGrey;

		// Token: 0x04029483 RID: 169091
		[Token(Token = "0x4029483")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x04029484 RID: 169092
		[Token(Token = "0x4029484")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _colorLocked;

		// Token: 0x04029485 RID: 169093
		[Token(Token = "0x4029485")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _colorBgNormal;

		// Token: 0x04029486 RID: 169094
		[Token(Token = "0x4029486")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _colorBgLocked;

		// Token: 0x04029489 RID: 169097
		[Token(Token = "0x4029489")]
		[FieldOffset(Offset = "0xC8")]
		private int m_position;

		// Token: 0x0402948A RID: 169098
		[Token(Token = "0x402948A")]
		[FieldOffset(Offset = "0xD0")]
		private Act17sideData.EventData m_eventData;

		// Token: 0x0402948B RID: 169099
		[Token(Token = "0x402948B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemSelect;

		// Token: 0x0402948C RID: 169100
		[Token(Token = "0x402948C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemSelect;

		// Token: 0x0402948D RID: 169101
		[Token(Token = "0x402948D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onLeave;

		// Token: 0x0402948E RID: 169102
		[Token(Token = "0x402948E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onLeave;

		// Token: 0x0402948F RID: 169103
		[Token(Token = "0x402948F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029490 RID: 169104
		[Token(Token = "0x4029490")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnItemSelected;

		// Token: 0x04029491 RID: 169105
		[Token(Token = "0x4029491")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnLeave;

		// Token: 0x04029492 RID: 169106
		[Token(Token = "0x4029492")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
