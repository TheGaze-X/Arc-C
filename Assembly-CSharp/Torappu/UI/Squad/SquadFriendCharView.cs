using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E11 RID: 15889
	[Token(Token = "0x2003E11")]
	public class SquadFriendCharView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018B7A RID: 101242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B7A")]
		[Address(RVA = "0x1139D20", Offset = "0x1138920", VA = "0x181139D20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018B7B RID: 101243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B7B")]
		[Address(RVA = "0x1139660", Offset = "0x1138260", VA = "0x181139660")]
		public void Render(SharedCharData charData, bool isSelect = false, bool isSkillLimited = false)
		{
		}

		// Token: 0x06018B7C RID: 101244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B7C")]
		[Address(RVA = "0x1139EA0", Offset = "0x1138AA0", VA = "0x181139EA0")]
		public SquadFriendCharView()
		{
		}

		// Token: 0x0401E536 RID: 124214
		[Token(Token = "0x401E536")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyViewObject;

		// Token: 0x0401E537 RID: 124215
		[Token(Token = "0x401E537")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _charViewObject;

		// Token: 0x0401E538 RID: 124216
		[Token(Token = "0x401E538")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _charImg;

		// Token: 0x0401E539 RID: 124217
		[Token(Token = "0x401E539")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x0401E53A RID: 124218
		[Token(Token = "0x401E53A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _eliteImg;

		// Token: 0x0401E53B RID: 124219
		[Token(Token = "0x401E53B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _skillImg;

		// Token: 0x0401E53C RID: 124220
		[Token(Token = "0x401E53C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _skillObject;

		// Token: 0x0401E53D RID: 124221
		[Token(Token = "0x401E53D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _skillLevelText;

		// Token: 0x0401E53E RID: 124222
		[Token(Token = "0x401E53E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _skillSpecializedImg;

		// Token: 0x0401E53F RID: 124223
		[Token(Token = "0x401E53F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _skillLevelBg;

		// Token: 0x0401E540 RID: 124224
		[Token(Token = "0x401E540")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _normalSkillBgColor;

		// Token: 0x0401E541 RID: 124225
		[Token(Token = "0x401E541")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _limitSkillBgColor;

		// Token: 0x0401E542 RID: 124226
		[Token(Token = "0x401E542")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _emptySkillObject;

		// Token: 0x0401E543 RID: 124227
		[Token(Token = "0x401E543")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UICommonEquipTypeIcon _equipIconPrefab;

		// Token: 0x0401E544 RID: 124228
		[Token(Token = "0x401E544")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Transform _equipIconContainer;

		// Token: 0x0401E545 RID: 124229
		[Token(Token = "0x401E545")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _equipIconScale;

		// Token: 0x0401E546 RID: 124230
		[Token(Token = "0x401E546")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _panelEquip;

		// Token: 0x0401E547 RID: 124231
		[Token(Token = "0x401E547")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _panelEquipLevel;

		// Token: 0x0401E548 RID: 124232
		[Token(Token = "0x401E548")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _equipLevelText;

		// Token: 0x0401E549 RID: 124233
		[Token(Token = "0x401E549")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _emptyEquipObject;

		// Token: 0x0401E54A RID: 124234
		[Token(Token = "0x401E54A")]
		[FieldOffset(Offset = "0xC8")]
		private UICommonEquipTypeIcon m_equipIcon;

		// Token: 0x0401E54B RID: 124235
		[Token(Token = "0x401E54B")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isInited;

		// Token: 0x0401E54C RID: 124236
		[Token(Token = "0x401E54C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E54D RID: 124237
		[Token(Token = "0x401E54D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E54E RID: 124238
		[Token(Token = "0x401E54E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
