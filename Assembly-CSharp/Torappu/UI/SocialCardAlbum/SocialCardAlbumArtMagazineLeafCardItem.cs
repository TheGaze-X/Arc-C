using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.ArtMagazine;
using UnityEngine;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EAD RID: 16045
	[Token(Token = "0x2003EAD")]
	public class SocialCardAlbumArtMagazineLeafCardItem : SocialCardAlbumCardItemBase, IExposure
	{
		// Token: 0x17003B66 RID: 15206
		// (get) Token: 0x06018E74 RID: 102004 RVA: 0x0009C618 File Offset: 0x0009A818
		[Token(Token = "0x17003B66")]
		public override CardType cardType
		{
			[Token(Token = "0x6018E74")]
			[Address(RVA = "0x1183420", Offset = "0x1182020", VA = "0x181183420", Slot = "4")]
			get
			{
				return CardType.NAME_CARD;
			}
		}

		// Token: 0x17003B67 RID: 15207
		// (get) Token: 0x06018E75 RID: 102005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003B67")]
		public string exposureId
		{
			[Token(Token = "0x6018E75")]
			[Address(RVA = "0x1183480", Offset = "0x1182080", VA = "0x181183480", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003B68 RID: 15208
		// (get) Token: 0x06018E76 RID: 102006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003B68")]
		public Action onExpose
		{
			[Token(Token = "0x6018E76")]
			[Address(RVA = "0x11835A0", Offset = "0x11821A0", VA = "0x1811835A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003B69 RID: 15209
		// (get) Token: 0x06018E77 RID: 102007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003B69")]
		public RectTransform exposureRectTransform
		{
			[Token(Token = "0x6018E77")]
			[Address(RVA = "0x1183510", Offset = "0x1182110", VA = "0x181183510", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003B6A RID: 15210
		// (get) Token: 0x06018E78 RID: 102008 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018E79 RID: 102009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B6A")]
		public Action<IExposure> registerExposure
		{
			[Token(Token = "0x6018E78")]
			[Address(RVA = "0x1183650", Offset = "0x1182250", VA = "0x181183650", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018E79")]
			[Address(RVA = "0x1183770", Offset = "0x1182370", VA = "0x181183770", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003B6B RID: 15211
		// (get) Token: 0x06018E7A RID: 102010 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018E7B RID: 102011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B6B")]
		public Action<IExposure> unregisterExposure
		{
			[Token(Token = "0x6018E7A")]
			[Address(RVA = "0x1183710", Offset = "0x1182310", VA = "0x181183710", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018E7B")]
			[Address(RVA = "0x1183870", Offset = "0x1182470", VA = "0x181183870", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003B6C RID: 15212
		// (get) Token: 0x06018E7C RID: 102012 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018E7D RID: 102013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B6C")]
		public Action tickExposure
		{
			[Token(Token = "0x6018E7C")]
			[Address(RVA = "0x11836B0", Offset = "0x11822B0", VA = "0x1811836B0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018E7D")]
			[Address(RVA = "0x11837F0", Offset = "0x11823F0", VA = "0x1811837F0", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06018E7E RID: 102014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E7E")]
		[Address(RVA = "0x11831D0", Offset = "0x1181DD0", VA = "0x1811831D0", Slot = "5")]
		public override void Render(CardViewModel card)
		{
		}

		// Token: 0x06018E7F RID: 102015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E7F")]
		[Address(RVA = "0x1183310", Offset = "0x1181F10", VA = "0x181183310")]
		private void _OnExpose()
		{
		}

		// Token: 0x06018E80 RID: 102016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E80")]
		[Address(RVA = "0x11830C0", Offset = "0x1181CC0", VA = "0x1811830C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06018E81 RID: 102017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E81")]
		[Address(RVA = "0x1183010", Offset = "0x1181C10", VA = "0x181183010")]
		private void OnDisable()
		{
		}

		// Token: 0x06018E82 RID: 102018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E82")]
		[Address(RVA = "0x1182EB0", Offset = "0x1181AB0", VA = "0x181182EB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06018E83 RID: 102019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E83")]
		[Address(RVA = "0x1183380", Offset = "0x1181F80", VA = "0x181183380")]
		public SocialCardAlbumArtMagazineLeafCardItem()
		{
		}

		// Token: 0x0401EBA1 RID: 125857
		[Token(Token = "0x401EBA1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArtMagazineLeafViewHolder _viewHolder;

		// Token: 0x0401EBA5 RID: 125861
		[Token(Token = "0x401EBA5")]
		[FieldOffset(Offset = "0x40")]
		private string m_cacheFriendUid;

		// Token: 0x0401EBA6 RID: 125862
		[Token(Token = "0x401EBA6")]
		[FieldOffset(Offset = "0x48")]
		private bool m_cacheIsFriend;

		// Token: 0x0401EBA7 RID: 125863
		[Token(Token = "0x401EBA7")]
		[FieldOffset(Offset = "0x50")]
		private string m_cacheLeafId;

		// Token: 0x0401EBA8 RID: 125864
		[Token(Token = "0x401EBA8")]
		[FieldOffset(Offset = "0x58")]
		private int m_cacheIndex;

		// Token: 0x0401EBA9 RID: 125865
		[Token(Token = "0x401EBA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardType;

		// Token: 0x0401EBAA RID: 125866
		[Token(Token = "0x401EBAA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_exposureId;

		// Token: 0x0401EBAB RID: 125867
		[Token(Token = "0x401EBAB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onExpose;

		// Token: 0x0401EBAC RID: 125868
		[Token(Token = "0x401EBAC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_exposureRectTransform;

		// Token: 0x0401EBAD RID: 125869
		[Token(Token = "0x401EBAD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_registerExposure;

		// Token: 0x0401EBAE RID: 125870
		[Token(Token = "0x401EBAE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_registerExposure;

		// Token: 0x0401EBAF RID: 125871
		[Token(Token = "0x401EBAF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_unregisterExposure;

		// Token: 0x0401EBB0 RID: 125872
		[Token(Token = "0x401EBB0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_unregisterExposure;

		// Token: 0x0401EBB1 RID: 125873
		[Token(Token = "0x401EBB1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_tickExposure;

		// Token: 0x0401EBB2 RID: 125874
		[Token(Token = "0x401EBB2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_tickExposure;

		// Token: 0x0401EBB3 RID: 125875
		[Token(Token = "0x401EBB3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EBB4 RID: 125876
		[Token(Token = "0x401EBB4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnExpose;

		// Token: 0x0401EBB5 RID: 125877
		[Token(Token = "0x401EBB5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401EBB6 RID: 125878
		[Token(Token = "0x401EBB6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401EBB7 RID: 125879
		[Token(Token = "0x401EBB7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401EBB8 RID: 125880
		[Token(Token = "0x401EBB8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
