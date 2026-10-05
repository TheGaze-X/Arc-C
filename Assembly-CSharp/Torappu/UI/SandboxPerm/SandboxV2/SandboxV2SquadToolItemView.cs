using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004444 RID: 17476
	[Token(Token = "0x2004444")]
	public class SandboxV2SquadToolItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003F63 RID: 16227
		// (get) Token: 0x0601AB4A RID: 109386 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AB4B RID: 109387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F63")]
		public Action<int> onToolClick
		{
			[Token(Token = "0x601AB4A")]
			[Address(RVA = "0x13D2AF0", Offset = "0x13D16F0", VA = "0x1813D2AF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AB4B")]
			[Address(RVA = "0x13D2BD0", Offset = "0x13D17D0", VA = "0x1813D2BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003F64 RID: 16228
		// (get) Token: 0x0601AB4C RID: 109388 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AB4D RID: 109389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F64")]
		public Action<int> onBtnBuildClick
		{
			[Token(Token = "0x601AB4C")]
			[Address(RVA = "0x13D2A90", Offset = "0x13D1690", VA = "0x1813D2A90")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AB4D")]
			[Address(RVA = "0x13D2B50", Offset = "0x13D1750", VA = "0x1813D2B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AB4E RID: 109390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB4E")]
		[Address(RVA = "0x13D2610", Offset = "0x13D1210", VA = "0x1813D2610")]
		public void Render(int index, int capacity, SandboxV2SquadToolModel toolModel, bool disableBtnBuild)
		{
		}

		// Token: 0x0601AB4F RID: 109391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB4F")]
		[Address(RVA = "0x13D2500", Offset = "0x13D1100", VA = "0x1813D2500")]
		public void EventOnToolClick()
		{
		}

		// Token: 0x0601AB50 RID: 109392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB50")]
		[Address(RVA = "0x13D23F0", Offset = "0x13D0FF0", VA = "0x1813D23F0")]
		public void EventOnBtnBuild()
		{
		}

		// Token: 0x0601AB51 RID: 109393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB51")]
		[Address(RVA = "0x13D2A30", Offset = "0x13D1630", VA = "0x1813D2A30")]
		public SandboxV2SquadToolItemView()
		{
		}

		// Token: 0x04022198 RID: 139672
		[Token(Token = "0x4022198")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2ItemCard _itemCardPrefab;

		// Token: 0x04022199 RID: 139673
		[Token(Token = "0x4022199")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x0402219A RID: 139674
		[Token(Token = "0x402219A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0402219B RID: 139675
		[Token(Token = "0x402219B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402219C RID: 139676
		[Token(Token = "0x402219C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textPosition;

		// Token: 0x0402219D RID: 139677
		[Token(Token = "0x402219D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textTotalCnt;

		// Token: 0x0402219E RID: 139678
		[Token(Token = "0x402219E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x0402219F RID: 139679
		[Token(Token = "0x402219F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x040221A0 RID: 139680
		[Token(Token = "0x40221A0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgTagBg;

		// Token: 0x040221A1 RID: 139681
		[Token(Token = "0x40221A1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textTagName;

		// Token: 0x040221A2 RID: 139682
		[Token(Token = "0x40221A2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _btnBuildGo;

		// Token: 0x040221A3 RID: 139683
		[Token(Token = "0x40221A3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _btnBuildBgGo;

		// Token: 0x040221A4 RID: 139684
		[Token(Token = "0x40221A4")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040221A5 RID: 139685
		[Token(Token = "0x40221A5")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2ItemCard m_itemCard;

		// Token: 0x040221A6 RID: 139686
		[Token(Token = "0x40221A6")]
		[FieldOffset(Offset = "0x90")]
		private int m_index;

		// Token: 0x040221A9 RID: 139689
		[Token(Token = "0x40221A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onToolClick;

		// Token: 0x040221AA RID: 139690
		[Token(Token = "0x40221AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onToolClick;

		// Token: 0x040221AB RID: 139691
		[Token(Token = "0x40221AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onBtnBuildClick;

		// Token: 0x040221AC RID: 139692
		[Token(Token = "0x40221AC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onBtnBuildClick;

		// Token: 0x040221AD RID: 139693
		[Token(Token = "0x40221AD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040221AE RID: 139694
		[Token(Token = "0x40221AE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnToolClick;

		// Token: 0x040221AF RID: 139695
		[Token(Token = "0x40221AF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBtnBuild;

		// Token: 0x040221B0 RID: 139696
		[Token(Token = "0x40221B0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
