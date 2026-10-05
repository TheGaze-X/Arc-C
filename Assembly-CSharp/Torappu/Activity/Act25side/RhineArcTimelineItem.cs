using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074ED RID: 29933
	[Token(Token = "0x20074ED")]
	public class RhineArcTimelineItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A309 RID: 172809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A309")]
		[Address(RVA = "0x25D87D0", Offset = "0x25D73D0", VA = "0x1825D87D0")]
		public void Render(RhineArcViewModel.Item item)
		{
		}

		// Token: 0x0602A30A RID: 172810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A30A")]
		[Address(RVA = "0x25D85F0", Offset = "0x25D71F0", VA = "0x1825D85F0")]
		public void OnClickItemBtn()
		{
		}

		// Token: 0x0602A30B RID: 172811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A30B")]
		[Address(RVA = "0x25D8C20", Offset = "0x25D7820", VA = "0x1825D8C20")]
		public RhineArcTimelineItem()
		{
		}

		// Token: 0x0403C9F3 RID: 248307
		[Token(Token = "0x403C9F3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _unAvailPart;

		// Token: 0x0403C9F4 RID: 248308
		[Token(Token = "0x403C9F4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _availPart;

		// Token: 0x0403C9F5 RID: 248309
		[Token(Token = "0x403C9F5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _unAvailDot;

		// Token: 0x0403C9F6 RID: 248310
		[Token(Token = "0x403C9F6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _unAvailFirstDot;

		// Token: 0x0403C9F7 RID: 248311
		[Token(Token = "0x403C9F7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _availDot;

		// Token: 0x0403C9F8 RID: 248312
		[Token(Token = "0x403C9F8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _newTrack;

		// Token: 0x0403C9F9 RID: 248313
		[Token(Token = "0x403C9F9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _newTrackDot;

		// Token: 0x0403C9FA RID: 248314
		[Token(Token = "0x403C9FA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _id;

		// Token: 0x0403C9FB RID: 248315
		[Token(Token = "0x403C9FB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _name;

		// Token: 0x0403C9FC RID: 248316
		[Token(Token = "0x403C9FC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x0403C9FD RID: 248317
		[Token(Token = "0x403C9FD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _itemSmallIcon;

		// Token: 0x0403C9FE RID: 248318
		[Token(Token = "0x403C9FE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _textBack;

		// Token: 0x0403C9FF RID: 248319
		[Token(Token = "0x403C9FF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasImage _itemMask;

		// Token: 0x0403CA00 RID: 248320
		[Token(Token = "0x403CA00")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _lockTextBackAlpha;

		// Token: 0x0403CA01 RID: 248321
		[Token(Token = "0x403CA01")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private Color _newMaskColor;

		// Token: 0x0403CA02 RID: 248322
		[Token(Token = "0x403CA02")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private Color _unlockMaskColor;

		// Token: 0x0403CA03 RID: 248323
		[Token(Token = "0x403CA03")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private Color _lockMaskColor;

		// Token: 0x0403CA04 RID: 248324
		[Token(Token = "0x403CA04")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private List<RhineArcTimelineItem.ItemSmallIcon> _smallIconList;

		// Token: 0x0403CA05 RID: 248325
		[Token(Token = "0x403CA05")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Button _itemBtn;

		// Token: 0x0403CA06 RID: 248326
		[Token(Token = "0x403CA06")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403CA07 RID: 248327
		[Token(Token = "0x403CA07")]
		[FieldOffset(Offset = "0xD8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403CA08 RID: 248328
		[Token(Token = "0x403CA08")]
		[FieldOffset(Offset = "0xE8")]
		private RhineArcViewModel.Item m_cachedItem;

		// Token: 0x0403CA09 RID: 248329
		[Token(Token = "0x403CA09")]
		[FieldOffset(Offset = "0xF0")]
		[NonSerialized]
		public bool isBehindAvailItem;

		// Token: 0x0403CA0A RID: 248330
		[Token(Token = "0x403CA0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CA0B RID: 248331
		[Token(Token = "0x403CA0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickItemBtn;

		// Token: 0x0403CA0C RID: 248332
		[Token(Token = "0x403CA0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020074EE RID: 29934
		[Token(Token = "0x20074EE")]
		[Serializable]
		private class ItemSmallIcon : IHotfixable
		{
			// Token: 0x0602A30C RID: 172812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A30C")]
			[Address(RVA = "0x25D4840", Offset = "0x25D3440", VA = "0x1825D4840")]
			public ItemSmallIcon()
			{
			}

			// Token: 0x0403CA0D RID: 248333
			[Token(Token = "0x403CA0D")]
			[FieldOffset(Offset = "0x10")]
			public Act25SideData.Act25SideArchiveItemType type;

			// Token: 0x0403CA0E RID: 248334
			[Token(Token = "0x403CA0E")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;

			// Token: 0x0403CA0F RID: 248335
			[Token(Token = "0x403CA0F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020074EF RID: 29935
		[Token(Token = "0x20074EF")]
		public class RhineArcKeyItemClickParam : IHotfixable
		{
			// Token: 0x0602A30D RID: 172813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A30D")]
			[Address(RVA = "0x25D8240", Offset = "0x25D6E40", VA = "0x1825D8240")]
			public RhineArcKeyItemClickParam()
			{
			}

			// Token: 0x0403CA10 RID: 248336
			[Token(Token = "0x403CA10")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x0403CA11 RID: 248337
			[Token(Token = "0x403CA11")]
			[FieldOffset(Offset = "0x18")]
			public string keyToast;

			// Token: 0x0403CA12 RID: 248338
			[Token(Token = "0x403CA12")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
