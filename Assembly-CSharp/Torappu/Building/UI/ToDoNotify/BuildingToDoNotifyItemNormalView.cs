using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.ToDoNotify
{
	// Token: 0x02001C55 RID: 7253
	[Token(Token = "0x2001C55")]
	public class BuildingToDoNotifyItemNormalView : BuildingToDoNotifyItemBase
	{
		// Token: 0x0600B47C RID: 46204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B47C")]
		[Address(RVA = "0x32F3E10", Offset = "0x32F2A10", VA = "0x1832F3E10", Slot = "4")]
		public override void Render(BuildingToDoCategory category, BuildingToDoNotifyItemModel itemModel, bool isSelected, BuildingToDoNotifyView.ItemClickStatusData itemClickStatusData)
		{
		}

		// Token: 0x0600B47D RID: 46205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B47D")]
		[Address(RVA = "0x32F4410", Offset = "0x32F3010", VA = "0x1832F4410")]
		private Sprite _FindIcon(BuildingData.BuildingToDoType type)
		{
			return null;
		}

		// Token: 0x0600B47E RID: 46206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B47E")]
		[Address(RVA = "0x32F45D0", Offset = "0x32F31D0", VA = "0x1832F45D0")]
		public BuildingToDoNotifyItemNormalView()
		{
		}

		// Token: 0x0600B47F RID: 46207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B47F")]
		[Address(RVA = "0x32F4400", Offset = "0x32F3000", VA = "0x1832F4400")]
		private void <>xLuaBaseProxy_Render(BuildingToDoCategory P0, BuildingToDoNotifyItemModel P1, bool P2, BuildingToDoNotifyView.ItemClickStatusData P3)
		{
		}

		// Token: 0x0400B02F RID: 45103
		[Token(Token = "0x400B02F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BuildingToDoNotifyItemNormalView.Config[] _configs;

		// Token: 0x0400B030 RID: 45104
		[Token(Token = "0x400B030")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0400B031 RID: 45105
		[Token(Token = "0x400B031")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0400B032 RID: 45106
		[Token(Token = "0x400B032")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0400B033 RID: 45107
		[Token(Token = "0x400B033")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _colorEmer;

		// Token: 0x0400B034 RID: 45108
		[Token(Token = "0x400B034")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x0400B035 RID: 45109
		[Token(Token = "0x400B035")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _bkgCount;

		// Token: 0x0400B036 RID: 45110
		[Token(Token = "0x400B036")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CanvasGroup _effectCanvasGroup;

		// Token: 0x0400B037 RID: 45111
		[Token(Token = "0x400B037")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textClick;

		// Token: 0x0400B038 RID: 45112
		[Token(Token = "0x400B038")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _panelCount;

		// Token: 0x0400B039 RID: 45113
		[Token(Token = "0x400B039")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _panelClick;

		// Token: 0x0400B03A RID: 45114
		[Token(Token = "0x400B03A")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIColorGraphic _graphic;

		// Token: 0x0400B03B RID: 45115
		[Token(Token = "0x400B03B")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Color _colorUnselected;

		// Token: 0x0400B03C RID: 45116
		[Token(Token = "0x400B03C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B03D RID: 45117
		[Token(Token = "0x400B03D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FindIcon;

		// Token: 0x0400B03E RID: 45118
		[Token(Token = "0x400B03E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001C56 RID: 7254
		[Token(Token = "0x2001C56")]
		[Serializable]
		private struct Config
		{
			// Token: 0x0400B03F RID: 45119
			[Token(Token = "0x400B03F")]
			[FieldOffset(Offset = "0x0")]
			public BuildingData.BuildingToDoType type;

			// Token: 0x0400B040 RID: 45120
			[Token(Token = "0x400B040")]
			[FieldOffset(Offset = "0x8")]
			public Sprite icon;
		}
	}
}
