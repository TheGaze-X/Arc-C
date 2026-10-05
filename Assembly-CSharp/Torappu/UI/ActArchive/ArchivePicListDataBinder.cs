using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BDB RID: 27611
	[Token(Token = "0x2006BDB")]
	public class ArchivePicListDataBinder : DataBinder<PicProperty>
	{
		// Token: 0x17005D17 RID: 23831
		// (get) Token: 0x060276E5 RID: 161509 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060276E6 RID: 161510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D17")]
		public ActArchiveController controller
		{
			[Token(Token = "0x60276E5")]
			[Address(RVA = "0x229A9F0", Offset = "0x22995F0", VA = "0x18229A9F0")]
			private get
			{
				return null;
			}
			[Token(Token = "0x60276E6")]
			[Address(RVA = "0x229AA50", Offset = "0x2299650", VA = "0x18229AA50")]
			set
			{
			}
		}

		// Token: 0x060276E7 RID: 161511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276E7")]
		[Address(RVA = "0x229A5E0", Offset = "0x22991E0", VA = "0x18229A5E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060276E8 RID: 161512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276E8")]
		[Address(RVA = "0x229A440", Offset = "0x2299040", VA = "0x18229A440", Slot = "7")]
		public override void OnValueChanged(PicProperty property)
		{
		}

		// Token: 0x060276E9 RID: 161513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60276E9")]
		[Address(RVA = "0x229A360", Offset = "0x2298F60", VA = "0x18229A360")]
		public IEnumerator FocusOnSelectedItem(bool fastMode, float duration)
		{
			return null;
		}

		// Token: 0x060276EA RID: 161514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276EA")]
		[Address(RVA = "0x229A930", Offset = "0x2299530", VA = "0x18229A930")]
		public ArchivePicListDataBinder()
		{
		}

		// Token: 0x04037DDA RID: 228826
		[Token(Token = "0x4037DDA")]
		[FieldOffset(Offset = "0x20")]
		private string IMG_ITEM_TYPE_FORMAT;

		// Token: 0x04037DDB RID: 228827
		[Token(Token = "0x4037DDB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x04037DDC RID: 228828
		[Token(Token = "0x4037DDC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AutoFocusScrollView _scrollView;

		// Token: 0x04037DDD RID: 228829
		[Token(Token = "0x4037DDD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ArchivePicListDataBinder.ArchivePicIcon> _imgListItemTitleGroup;

		// Token: 0x04037DDE RID: 228830
		[Token(Token = "0x4037DDE")]
		[FieldOffset(Offset = "0x40")]
		private ArchivePicListDataBinder.Adapter m_listAdapter;

		// Token: 0x04037DDF RID: 228831
		[Token(Token = "0x4037DDF")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x04037DE0 RID: 228832
		[Token(Token = "0x4037DE0")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedPicItem;

		// Token: 0x04037DE1 RID: 228833
		[Token(Token = "0x4037DE1")]
		[FieldOffset(Offset = "0x58")]
		private ArchivePicModel m_cachedModel;

		// Token: 0x04037DE2 RID: 228834
		[Token(Token = "0x4037DE2")]
		[FieldOffset(Offset = "0x60")]
		private ActArchiveController m_controller;

		// Token: 0x04037DE3 RID: 228835
		[Token(Token = "0x4037DE3")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, Sprite> m_imgListItemTitleMap;

		// Token: 0x04037DE4 RID: 228836
		[Token(Token = "0x4037DE4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037DE5 RID: 228837
		[Token(Token = "0x4037DE5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037DE6 RID: 228838
		[Token(Token = "0x4037DE6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037DE7 RID: 228839
		[Token(Token = "0x4037DE7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037DE8 RID: 228840
		[Token(Token = "0x4037DE8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FocusOnSelectedItem;

		// Token: 0x04037DE9 RID: 228841
		[Token(Token = "0x4037DE9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006BDC RID: 27612
		[Token(Token = "0x2006BDC")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17005D18 RID: 23832
			// (get) Token: 0x060276EB RID: 161515 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060276EC RID: 161516 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005D18")]
			public ListDict<string, PicItemModel> dataSet
			{
				[Token(Token = "0x60276EB")]
				[Address(RVA = "0x228FA60", Offset = "0x228E660", VA = "0x18228FA60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60276EC")]
				[Address(RVA = "0x228FAC0", Offset = "0x228E6C0", VA = "0x18228FAC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005D19 RID: 23833
			// (get) Token: 0x060276ED RID: 161517 RVA: 0x000CE5B0 File Offset: 0x000CC7B0
			[Token(Token = "0x17005D19")]
			public override int count
			{
				[Token(Token = "0x60276ED")]
				[Address(RVA = "0x228F9A0", Offset = "0x228E5A0", VA = "0x18228F9A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060276EE RID: 161518 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60276EE")]
			[Address(RVA = "0x228F920", Offset = "0x228E520", VA = "0x18228F920")]
			public Adapter(ArchivePicListDataBinder closure)
			{
			}

			// Token: 0x060276EF RID: 161519 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60276EF")]
			[Address(RVA = "0x228F4C0", Offset = "0x228E0C0", VA = "0x18228F4C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037DEA RID: 228842
			[Token(Token = "0x4037DEA")]
			[FieldOffset(Offset = "0x20")]
			private ArchivePicListDataBinder m_closure;

			// Token: 0x04037DEC RID: 228844
			[Token(Token = "0x4037DEC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x04037DED RID: 228845
			[Token(Token = "0x4037DED")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x04037DEE RID: 228846
			[Token(Token = "0x4037DEE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037DEF RID: 228847
			[Token(Token = "0x4037DEF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037DF0 RID: 228848
			[Token(Token = "0x4037DF0")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02006BDD RID: 27613
		[Token(Token = "0x2006BDD")]
		[Serializable]
		public struct ArchivePicIcon
		{
			// Token: 0x04037DF1 RID: 228849
			[Token(Token = "0x4037DF1")]
			[FieldOffset(Offset = "0x0")]
			public string subType;

			// Token: 0x04037DF2 RID: 228850
			[Token(Token = "0x4037DF2")]
			[FieldOffset(Offset = "0x8")]
			public ActArchivePicType type;

			// Token: 0x04037DF3 RID: 228851
			[Token(Token = "0x4037DF3")]
			[FieldOffset(Offset = "0x10")]
			public Sprite imgIcon;
		}
	}
}
