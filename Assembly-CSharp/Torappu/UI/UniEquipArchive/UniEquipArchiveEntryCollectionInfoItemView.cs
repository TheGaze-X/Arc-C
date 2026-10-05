using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BEC RID: 15340
	[Token(Token = "0x2003BEC")]
	public class UniEquipArchiveEntryCollectionInfoItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018004 RID: 98308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018004")]
		[Address(RVA = "0x107B060", Offset = "0x1079C60", VA = "0x18107B060")]
		public void Render(UniEquipArchiveEntryCollectionInfoItemViewModel infoItemViewModel)
		{
		}

		// Token: 0x06018005 RID: 98309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018005")]
		[Address(RVA = "0x107B440", Offset = "0x107A040", VA = "0x18107B440")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018006 RID: 98310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018006")]
		[Address(RVA = "0x107B520", Offset = "0x107A120", VA = "0x18107B520")]
		public UniEquipArchiveEntryCollectionInfoItemView()
		{
		}

		// Token: 0x0401D121 RID: 119073
		[Token(Token = "0x401D121")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtTitle;

		// Token: 0x0401D122 RID: 119074
		[Token(Token = "0x401D122")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtCurCount;

		// Token: 0x0401D123 RID: 119075
		[Token(Token = "0x401D123")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasTotal;

		// Token: 0x0401D124 RID: 119076
		[Token(Token = "0x401D124")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtTotalCount;

		// Token: 0x0401D125 RID: 119077
		[Token(Token = "0x401D125")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objSplitLine;

		// Token: 0x0401D126 RID: 119078
		[Token(Token = "0x401D126")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0401D127 RID: 119079
		[Token(Token = "0x401D127")]
		[FieldOffset(Offset = "0x44")]
		private UniEquipArchiveCollectionInfoType m_cachedType;

		// Token: 0x0401D128 RID: 119080
		[Token(Token = "0x401D128")]
		[FieldOffset(Offset = "0x48")]
		private FadeSwitchTween m_tweenTotalPart;

		// Token: 0x0401D129 RID: 119081
		[Token(Token = "0x401D129")]
		private const string TOTAL_FORMAT = "/{0}";

		// Token: 0x0401D12A RID: 119082
		[Token(Token = "0x401D12A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D12B RID: 119083
		[Token(Token = "0x401D12B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D12C RID: 119084
		[Token(Token = "0x401D12C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
