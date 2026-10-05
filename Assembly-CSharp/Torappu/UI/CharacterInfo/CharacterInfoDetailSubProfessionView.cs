using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using Torappu.UI.UniEquip;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FC1 RID: 24513
	[Token(Token = "0x2005FC1")]
	public class CharacterInfoDetailSubProfessionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023742 RID: 145218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023742")]
		[Address(RVA = "0x1E1EA10", Offset = "0x1E1D610", VA = "0x181E1EA10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023743 RID: 145219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023743")]
		[Address(RVA = "0x1E1E360", Offset = "0x1E1CF60", VA = "0x181E1E360")]
		public void Render(CharacterProfileViewModel profileViewModel)
		{
		}

		// Token: 0x06023744 RID: 145220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023744")]
		[Address(RVA = "0x1E1EB30", Offset = "0x1E1D730", VA = "0x181E1EB30")]
		public CharacterInfoDetailSubProfessionView()
		{
		}

		// Token: 0x0403107B RID: 200827
		[Token(Token = "0x403107B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterInfoDetailTalentContentGroup _contentGroup;

		// Token: 0x0403107C RID: 200828
		[Token(Token = "0x403107C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _subProfName;

		// Token: 0x0403107D RID: 200829
		[Token(Token = "0x403107D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommentedText _subProfDetailBasic;

		// Token: 0x0403107E RID: 200830
		[Token(Token = "0x403107E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICommentedText _subProfDetailAdditive;

		// Token: 0x0403107F RID: 200831
		[Token(Token = "0x403107F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _subProfImg;

		// Token: 0x04031080 RID: 200832
		[Token(Token = "0x4031080")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _uniEquipPart;

		// Token: 0x04031081 RID: 200833
		[Token(Token = "0x4031081")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _lockedPart;

		// Token: 0x04031082 RID: 200834
		[Token(Token = "0x4031082")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _haveEquipPart;

		// Token: 0x04031083 RID: 200835
		[Token(Token = "0x4031083")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text equipName;

		// Token: 0x04031084 RID: 200836
		[Token(Token = "0x4031084")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _lockedText;

		// Token: 0x04031085 RID: 200837
		[Token(Token = "0x4031085")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _uniEquipName;

		// Token: 0x04031086 RID: 200838
		[Token(Token = "0x4031086")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UICommonEquipTypeIcon _typeIcon;

		// Token: 0x04031087 RID: 200839
		[Token(Token = "0x4031087")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _typeContainer;

		// Token: 0x04031088 RID: 200840
		[Token(Token = "0x4031088")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04031089 RID: 200841
		[Token(Token = "0x4031089")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UniEquipImgHolder _imgHolder;

		// Token: 0x0403108A RID: 200842
		[Token(Token = "0x403108A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _scaleFloat;

		// Token: 0x0403108B RID: 200843
		[Token(Token = "0x403108B")]
		[FieldOffset(Offset = "0x98")]
		private UniEquipImgHolder m_imgHolder;

		// Token: 0x0403108C RID: 200844
		[Token(Token = "0x403108C")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x0403108D RID: 200845
		[Token(Token = "0x403108D")]
		[FieldOffset(Offset = "0xA8")]
		private UICommonEquipTypeIcon m_typeIcon;

		// Token: 0x0403108E RID: 200846
		[Token(Token = "0x403108E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403108F RID: 200847
		[Token(Token = "0x403108F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031090 RID: 200848
		[Token(Token = "0x4031090")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
