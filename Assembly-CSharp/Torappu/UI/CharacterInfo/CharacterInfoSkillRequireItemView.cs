using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FBA RID: 24506
	[Token(Token = "0x2005FBA")]
	public class CharacterInfoSkillRequireItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023718 RID: 145176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023718")]
		[Address(RVA = "0x1E20610", Offset = "0x1E1F210", VA = "0x181E20610")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023719 RID: 145177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023719")]
		[Address(RVA = "0x1E20140", Offset = "0x1E1ED40", VA = "0x181E20140")]
		public void RenderItem(int index, RequireViewModel viewModel)
		{
		}

		// Token: 0x0602371A RID: 145178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602371A")]
		[Address(RVA = "0x1E20960", Offset = "0x1E1F560", VA = "0x181E20960")]
		private void _RenderFavorItem(RequireViewModel viewModel)
		{
		}

		// Token: 0x0602371B RID: 145179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602371B")]
		[Address(RVA = "0x1E20860", Offset = "0x1E1F460", VA = "0x181E20860")]
		private void _OnItemClicked(int index)
		{
		}

		// Token: 0x0602371C RID: 145180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602371C")]
		[Address(RVA = "0x1E20A50", Offset = "0x1E1F650", VA = "0x181E20A50")]
		public CharacterInfoSkillRequireItemView()
		{
		}

		// Token: 0x04031018 RID: 200728
		[Token(Token = "0x4031018")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Content to show when require type is ITEM")]
		private GameObject _contentForItem;

		// Token: 0x04031019 RID: 200729
		[Token(Token = "0x4031019")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x0403101A RID: 200730
		[Token(Token = "0x403101A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Content to show when require type is LEVEL")]
		private GameObject _contentForText;

		// Token: 0x0403101B RID: 200731
		[Token(Token = "0x403101B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _contentTextValue;

		// Token: 0x0403101C RID: 200732
		[Token(Token = "0x403101C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Content to show when require type is FAVOR")]
		private GameObject _contentForFavor;

		// Token: 0x0403101D RID: 200733
		[Token(Token = "0x403101D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _contentFavorValue;

		// Token: 0x0403101E RID: 200734
		[Token(Token = "0x403101E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int _textValueUnitSize;

		// Token: 0x0403101F RID: 200735
		[Token(Token = "0x403101F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _contentEvolveState;

		// Token: 0x04031020 RID: 200736
		[Token(Token = "0x4031020")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _satisfiedLabel;

		// Token: 0x04031021 RID: 200737
		[Token(Token = "0x4031021")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _unsatisfiedLabel;

		// Token: 0x04031022 RID: 200738
		[Token(Token = "0x4031022")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _labelCountDesc;

		// Token: 0x04031023 RID: 200739
		[Token(Token = "0x4031023")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Tooltip("Color for unsatisfied part of the label")]
		private Color _unsatisfiedLabelColor;

		// Token: 0x04031024 RID: 200740
		[Token(Token = "0x4031024")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Tooltip("Char limit of the bottom label. If the content exceeds this, it will be shorten with some mechanism")]
		private int _labelLengthLimit;

		// Token: 0x04031025 RID: 200741
		[Token(Token = "0x4031025")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		[Tooltip("The scale to show an item card")]
		private float _itemCardScale;

		// Token: 0x04031026 RID: 200742
		[Token(Token = "0x4031026")]
		[FieldOffset(Offset = "0x88")]
		private UIItemCard m_itemCard;

		// Token: 0x04031027 RID: 200743
		[Token(Token = "0x4031027")]
		[FieldOffset(Offset = "0x90")]
		private long m_cachedNeedCount;

		// Token: 0x04031028 RID: 200744
		[Token(Token = "0x4031028")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x04031029 RID: 200745
		[Token(Token = "0x4031029")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403102A RID: 200746
		[Token(Token = "0x403102A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderItem;

		// Token: 0x0403102B RID: 200747
		[Token(Token = "0x403102B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderFavorItem;

		// Token: 0x0403102C RID: 200748
		[Token(Token = "0x403102C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x0403102D RID: 200749
		[Token(Token = "0x403102D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
