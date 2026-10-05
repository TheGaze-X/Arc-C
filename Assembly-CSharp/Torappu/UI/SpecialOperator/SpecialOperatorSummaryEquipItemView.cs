using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterShow;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E69 RID: 15977
	[Token(Token = "0x2003E69")]
	public class SpecialOperatorSummaryEquipItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018D7D RID: 101757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D7D")]
		[Address(RVA = "0x117CB30", Offset = "0x117B730", VA = "0x18117CB30")]
		public void Render(CharacterShowEquipModel equipModel, CharacterShowV2Model charModel)
		{
		}

		// Token: 0x06018D7E RID: 101758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D7E")]
		[Address(RVA = "0x117CDF0", Offset = "0x117B9F0", VA = "0x18117CDF0")]
		public SpecialOperatorSummaryEquipItemView()
		{
		}

		// Token: 0x0401E8E9 RID: 125161
		[Token(Token = "0x401E8E9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyPartGO;

		// Token: 0x0401E8EA RID: 125162
		[Token(Token = "0x401E8EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _activePartGO;

		// Token: 0x0401E8EB RID: 125163
		[Token(Token = "0x401E8EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _equipLvGO;

		// Token: 0x0401E8EC RID: 125164
		[Token(Token = "0x401E8EC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textEquipLv;

		// Token: 0x0401E8ED RID: 125165
		[Token(Token = "0x401E8ED")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgBg;

		// Token: 0x0401E8EE RID: 125166
		[Token(Token = "0x401E8EE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICommonEquipTypeIcon _equipTypeIcon;

		// Token: 0x0401E8EF RID: 125167
		[Token(Token = "0x401E8EF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorBgLock;

		// Token: 0x0401E8F0 RID: 125168
		[Token(Token = "0x401E8F0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _colorBgNormal;

		// Token: 0x0401E8F1 RID: 125169
		[Token(Token = "0x401E8F1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _colorEquipIconLock;

		// Token: 0x0401E8F2 RID: 125170
		[Token(Token = "0x401E8F2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _colorEquipIconNormal;

		// Token: 0x0401E8F3 RID: 125171
		[Token(Token = "0x401E8F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E8F4 RID: 125172
		[Token(Token = "0x401E8F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
