using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001995 RID: 6549
	[Token(Token = "0x2001995")]
	public class DIYFurnitureTitleView : DIYFurnitureVerticalListElementView
	{
		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x0600A43C RID: 42044 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A43D RID: 42045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170012FC")]
		public string text
		{
			[Token(Token = "0x600A43C")]
			[Address(RVA = "0x31DECD0", Offset = "0x31DD8D0", VA = "0x1831DECD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A43D")]
			[Address(RVA = "0x31DED60", Offset = "0x31DD960", VA = "0x1831DED60")]
			set
			{
			}
		}

		// Token: 0x0600A43E RID: 42046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A43E")]
		[Address(RVA = "0x31DEB90", Offset = "0x31DD790", VA = "0x1831DEB90")]
		public void OnInit(List<DIYItemViewData> itemViewDatas, DIYViewListModel.DIYViewListThemeState themeState)
		{
		}

		// Token: 0x0600A43F RID: 42047 RVA: 0x0003F948 File Offset: 0x0003DB48
		[Token(Token = "0x600A43F")]
		[Address(RVA = "0x31DEB00", Offset = "0x31DD700", VA = "0x1831DEB00")]
		public Vector2 GetTextRect()
		{
			return default(Vector2);
		}

		// Token: 0x0600A440 RID: 42048 RVA: 0x0003F960 File Offset: 0x0003DB60
		[Token(Token = "0x600A440")]
		[Address(RVA = "0x31DEA20", Offset = "0x31DD620", VA = "0x1831DEA20")]
		public TextGenerationSettings GetTextGenerationSettings(Vector2 extents)
		{
			return default(TextGenerationSettings);
		}

		// Token: 0x0600A441 RID: 42049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A441")]
		[Address(RVA = "0x31DEC70", Offset = "0x31DD870", VA = "0x1831DEC70")]
		public DIYFurnitureTitleView()
		{
		}

		// Token: 0x04009B6D RID: 39789
		[Token(Token = "0x4009B6D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x04009B6E RID: 39790
		[Token(Token = "0x4009B6E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DIYFurnitureRowView _rowView;

		// Token: 0x04009B6F RID: 39791
		[Token(Token = "0x4009B6F")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Func<DIYItemViewData, bool> furnitureSelected;

		// Token: 0x04009B70 RID: 39792
		[Token(Token = "0x4009B70")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Func<DIYItemViewData, bool> infoButtonPressed;

		// Token: 0x04009B71 RID: 39793
		[Token(Token = "0x4009B71")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_text;

		// Token: 0x04009B72 RID: 39794
		[Token(Token = "0x4009B72")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_text;

		// Token: 0x04009B73 RID: 39795
		[Token(Token = "0x4009B73")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04009B74 RID: 39796
		[Token(Token = "0x4009B74")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTextRect;

		// Token: 0x04009B75 RID: 39797
		[Token(Token = "0x4009B75")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetTextGenerationSettings;

		// Token: 0x04009B76 RID: 39798
		[Token(Token = "0x4009B76")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
