using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003516 RID: 13590
	[Token(Token = "0x2003516")]
	public class UICharacterProfessionFilterProfItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015AB8 RID: 88760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AB8")]
		[Address(RVA = "0xE3ED00", Offset = "0xE3D900", VA = "0x180E3ED00")]
		public void Render(UICharacterProfessionFilterViewModel model, ProfessionFilterProfItemViewModel itemModel, bool isAllItem)
		{
		}

		// Token: 0x06015AB9 RID: 88761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AB9")]
		[Address(RVA = "0xE3F050", Offset = "0xE3DC50", VA = "0x180E3F050")]
		private void _RenderImpl(UICharacterProfessionFilterProfItem.ProfState profState, bool isSubProfSelected, bool isSubShow)
		{
		}

		// Token: 0x06015ABA RID: 88762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ABA")]
		[Address(RVA = "0xE3EBF0", Offset = "0xE3D7F0", VA = "0x180E3EBF0")]
		public void OnAllClick()
		{
		}

		// Token: 0x06015ABB RID: 88763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ABB")]
		[Address(RVA = "0xE3EC70", Offset = "0xE3D870", VA = "0x180E3EC70")]
		public void OnProfessionClick()
		{
		}

		// Token: 0x06015ABC RID: 88764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ABC")]
		[Address(RVA = "0xE3F1C0", Offset = "0xE3DDC0", VA = "0x180E3F1C0")]
		public UICharacterProfessionFilterProfItem()
		{
		}

		// Token: 0x0401A000 RID: 106496
		[Token(Token = "0x401A000")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _profIcon;

		// Token: 0x0401A001 RID: 106497
		[Token(Token = "0x401A001")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Graphic _colorGraphic;

		// Token: 0x0401A002 RID: 106498
		[Token(Token = "0x401A002")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSubShow;

		// Token: 0x0401A003 RID: 106499
		[Token(Token = "0x401A003")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelSubHide;

		// Token: 0x0401A004 RID: 106500
		[Token(Token = "0x401A004")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelSubSelected;

		// Token: 0x0401A005 RID: 106501
		[Token(Token = "0x401A005")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorSelected;

		// Token: 0x0401A006 RID: 106502
		[Token(Token = "0x401A006")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorUnSelected;

		// Token: 0x0401A007 RID: 106503
		[Token(Token = "0x401A007")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colorBanned;

		// Token: 0x0401A008 RID: 106504
		[Token(Token = "0x401A008")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelHotSpot;

		// Token: 0x0401A009 RID: 106505
		[Token(Token = "0x401A009")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public ILoadAsset assetLoader;

		// Token: 0x0401A00A RID: 106506
		[Token(Token = "0x401A00A")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Action<ProfessionCategory, bool> onProfessionClick;

		// Token: 0x0401A00B RID: 106507
		[Token(Token = "0x401A00B")]
		[FieldOffset(Offset = "0x88")]
		private ProfessionCategory m_cachedProf;

		// Token: 0x0401A00C RID: 106508
		[Token(Token = "0x401A00C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401A00D RID: 106509
		[Token(Token = "0x401A00D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderImpl;

		// Token: 0x0401A00E RID: 106510
		[Token(Token = "0x401A00E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAllClick;

		// Token: 0x0401A00F RID: 106511
		[Token(Token = "0x401A00F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProfessionClick;

		// Token: 0x0401A010 RID: 106512
		[Token(Token = "0x401A010")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003517 RID: 13591
		[Token(Token = "0x2003517")]
		public enum ProfState
		{
			// Token: 0x0401A012 RID: 106514
			[Token(Token = "0x401A012")]
			UNSELECTED,
			// Token: 0x0401A013 RID: 106515
			[Token(Token = "0x401A013")]
			SELECTED,
			// Token: 0x0401A014 RID: 106516
			[Token(Token = "0x401A014")]
			BANNED
		}
	}
}
