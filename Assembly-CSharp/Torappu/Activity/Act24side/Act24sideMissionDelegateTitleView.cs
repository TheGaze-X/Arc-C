using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075CE RID: 30158
	[Token(Token = "0x20075CE")]
	public class Act24sideMissionDelegateTitleView : Act24sideMissionAbstractDelegateTileView
	{
		// Token: 0x0602A767 RID: 173927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A767")]
		[Address(RVA = "0x2623B10", Offset = "0x2622710", VA = "0x182623B10", Slot = "4")]
		public override void Render(Act24SideData.MissionType type)
		{
		}

		// Token: 0x0602A768 RID: 173928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A768")]
		[Address(RVA = "0x2623CF0", Offset = "0x26228F0", VA = "0x182623CF0")]
		private void _MissionTypeDisplay(Act24SideData.MissionType type)
		{
		}

		// Token: 0x0602A769 RID: 173929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A769")]
		[Address(RVA = "0x2623F60", Offset = "0x2622B60", VA = "0x182623F60")]
		private void _SetTypeDisplay(Color typeColor, Color titleColor, GameObject title, GameObject left)
		{
		}

		// Token: 0x0602A76A RID: 173930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A76A")]
		[Address(RVA = "0x2623EA0", Offset = "0x2622AA0", VA = "0x182623EA0")]
		private void _ResetAll()
		{
		}

		// Token: 0x0602A76B RID: 173931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A76B")]
		[Address(RVA = "0x2624200", Offset = "0x2622E00", VA = "0x182624200")]
		public Act24sideMissionDelegateTitleView()
		{
		}

		// Token: 0x0403D1C4 RID: 250308
		[Token(Token = "0x403D1C4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<UIAtlasImage> _typeColorAtlasImage;

		// Token: 0x0403D1C5 RID: 250309
		[Token(Token = "0x403D1C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _hunterColor;

		// Token: 0x0403D1C6 RID: 250310
		[Token(Token = "0x403D1C6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _collectionColor;

		// Token: 0x0403D1C7 RID: 250311
		[Token(Token = "0x403D1C7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _explorationColor;

		// Token: 0x0403D1C8 RID: 250312
		[Token(Token = "0x403D1C8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _titleHunterColor;

		// Token: 0x0403D1C9 RID: 250313
		[Token(Token = "0x403D1C9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _titleCollectionColor;

		// Token: 0x0403D1CA RID: 250314
		[Token(Token = "0x403D1CA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _titleExploraionColor;

		// Token: 0x0403D1CB RID: 250315
		[Token(Token = "0x403D1CB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _hunterLeft;

		// Token: 0x0403D1CC RID: 250316
		[Token(Token = "0x403D1CC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _collectionLeft;

		// Token: 0x0403D1CD RID: 250317
		[Token(Token = "0x403D1CD")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _explorationLeft;

		// Token: 0x0403D1CE RID: 250318
		[Token(Token = "0x403D1CE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _hunterTitle;

		// Token: 0x0403D1CF RID: 250319
		[Token(Token = "0x403D1CF")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _collectionTitle;

		// Token: 0x0403D1D0 RID: 250320
		[Token(Token = "0x403D1D0")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _explorationTitle;

		// Token: 0x0403D1D1 RID: 250321
		[Token(Token = "0x403D1D1")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _titleTxt;

		// Token: 0x0403D1D2 RID: 250322
		[Token(Token = "0x403D1D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D1D3 RID: 250323
		[Token(Token = "0x403D1D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__MissionTypeDisplay;

		// Token: 0x0403D1D4 RID: 250324
		[Token(Token = "0x403D1D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetTypeDisplay;

		// Token: 0x0403D1D5 RID: 250325
		[Token(Token = "0x403D1D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ResetAll;

		// Token: 0x0403D1D6 RID: 250326
		[Token(Token = "0x403D1D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
