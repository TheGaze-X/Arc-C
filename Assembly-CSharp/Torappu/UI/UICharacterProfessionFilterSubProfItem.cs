using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200351A RID: 13594
	[Token(Token = "0x200351A")]
	public class UICharacterProfessionFilterSubProfItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015AC6 RID: 88774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AC6")]
		[Address(RVA = "0xE3FD70", Offset = "0xE3E970", VA = "0x180E3FD70")]
		public void Render(UICharacterProfessionFilterViewModel model, ProfessionFilterSubProfItemViewModel itemModel, bool isAllItem)
		{
		}

		// Token: 0x06015AC7 RID: 88775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AC7")]
		[Address(RVA = "0xE40310", Offset = "0xE3EF10", VA = "0x180E40310")]
		private void _RenderView(string name, string iconId)
		{
		}

		// Token: 0x06015AC8 RID: 88776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AC8")]
		[Address(RVA = "0xE40170", Offset = "0xE3ED70", VA = "0x180E40170")]
		private void _RenderSelect(bool isSelected, bool isSubProfInvalid)
		{
		}

		// Token: 0x06015AC9 RID: 88777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AC9")]
		[Address(RVA = "0xE3FC60", Offset = "0xE3E860", VA = "0x180E3FC60")]
		public void OnAllClick()
		{
		}

		// Token: 0x06015ACA RID: 88778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ACA")]
		[Address(RVA = "0xE3FCE0", Offset = "0xE3E8E0", VA = "0x180E3FCE0")]
		public void OnProfessionClick()
		{
		}

		// Token: 0x06015ACB RID: 88779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ACB")]
		[Address(RVA = "0xE40460", Offset = "0xE3F060", VA = "0x180E40460")]
		public UICharacterProfessionFilterSubProfItem()
		{
		}

		// Token: 0x0401A02E RID: 106542
		[Token(Token = "0x401A02E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x0401A02F RID: 106543
		[Token(Token = "0x401A02F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _profIcon;

		// Token: 0x0401A030 RID: 106544
		[Token(Token = "0x401A030")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _bg;

		// Token: 0x0401A031 RID: 106545
		[Token(Token = "0x401A031")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorSelected;

		// Token: 0x0401A032 RID: 106546
		[Token(Token = "0x401A032")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorUnSelected;

		// Token: 0x0401A033 RID: 106547
		[Token(Token = "0x401A033")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _alphaInvalid;

		// Token: 0x0401A034 RID: 106548
		[Token(Token = "0x401A034")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public ILoadAsset assetLoader;

		// Token: 0x0401A035 RID: 106549
		[Token(Token = "0x401A035")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Action<string, bool> onSubProfessionClick;

		// Token: 0x0401A036 RID: 106550
		[Token(Token = "0x401A036")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedSubProf;

		// Token: 0x0401A037 RID: 106551
		[Token(Token = "0x401A037")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401A038 RID: 106552
		[Token(Token = "0x401A038")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x0401A039 RID: 106553
		[Token(Token = "0x401A039")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderSelect;

		// Token: 0x0401A03A RID: 106554
		[Token(Token = "0x401A03A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAllClick;

		// Token: 0x0401A03B RID: 106555
		[Token(Token = "0x401A03B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnProfessionClick;

		// Token: 0x0401A03C RID: 106556
		[Token(Token = "0x401A03C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
