using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B97 RID: 27543
	[Token(Token = "0x2006B97")]
	public class ArchiveLandmarkDataBinder : DataBinder<LandmarkProperty>
	{
		// Token: 0x17005CEA RID: 23786
		// (get) Token: 0x06027571 RID: 161137 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027572 RID: 161138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CEA")]
		public ActArchiveController controller
		{
			[Token(Token = "0x6027571")]
			[Address(RVA = "0x2284C80", Offset = "0x2283880", VA = "0x182284C80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027572")]
			[Address(RVA = "0x2284CE0", Offset = "0x22838E0", VA = "0x182284CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027573 RID: 161139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027573")]
		[Address(RVA = "0x2284740", Offset = "0x2283340", VA = "0x182284740", Slot = "7")]
		public override void OnValueChanged(LandmarkProperty property)
		{
		}

		// Token: 0x06027574 RID: 161140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027574")]
		[Address(RVA = "0x2284AF0", Offset = "0x22836F0", VA = "0x182284AF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027575 RID: 161141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027575")]
		[Address(RVA = "0x2284C10", Offset = "0x2283810", VA = "0x182284C10")]
		public ArchiveLandmarkDataBinder()
		{
		}

		// Token: 0x04037BB7 RID: 228279
		[Token(Token = "0x4037BB7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgItem;

		// Token: 0x04037BB8 RID: 228280
		[Token(Token = "0x4037BB8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04037BB9 RID: 228281
		[Token(Token = "0x4037BB9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textEngTitle;

		// Token: 0x04037BBA RID: 228282
		[Token(Token = "0x4037BBA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textItemDesc;

		// Token: 0x04037BBB RID: 228283
		[Token(Token = "0x4037BBB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _imgListItemIcon;

		// Token: 0x04037BBC RID: 228284
		[Token(Token = "0x4037BBC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _textScrollRect;

		// Token: 0x04037BBD RID: 228285
		[Token(Token = "0x4037BBD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x04037BBE RID: 228286
		[Token(Token = "0x4037BBE")]
		[FieldOffset(Offset = "0x58")]
		private ArchiveLandmarkModel m_cachedModel;

		// Token: 0x04037BBF RID: 228287
		[Token(Token = "0x4037BBF")]
		[FieldOffset(Offset = "0x60")]
		private ArchiveLandmarkDataBinder.Adapter m_adapter;

		// Token: 0x04037BC0 RID: 228288
		[Token(Token = "0x4037BC0")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x04037BC2 RID: 228290
		[Token(Token = "0x4037BC2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037BC3 RID: 228291
		[Token(Token = "0x4037BC3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037BC4 RID: 228292
		[Token(Token = "0x4037BC4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037BC5 RID: 228293
		[Token(Token = "0x4037BC5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037BC6 RID: 228294
		[Token(Token = "0x4037BC6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B98 RID: 27544
		[Token(Token = "0x2006B98")]
		public class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x17005CEB RID: 23787
			// (get) Token: 0x06027576 RID: 161142 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027577 RID: 161143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005CEB")]
			public ListDict<string, LandmarkItemModel> dataSet
			{
				[Token(Token = "0x6027576")]
				[Address(RVA = "0x2279250", Offset = "0x2277E50", VA = "0x182279250")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6027577")]
				[Address(RVA = "0x22792B0", Offset = "0x2277EB0", VA = "0x1822792B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005CEC RID: 23788
			// (get) Token: 0x06027578 RID: 161144 RVA: 0x000CE1F0 File Offset: 0x000CC3F0
			[Token(Token = "0x17005CEC")]
			public override int count
			{
				[Token(Token = "0x6027578")]
				[Address(RVA = "0x2279190", Offset = "0x2277D90", VA = "0x182279190", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027579 RID: 161145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027579")]
			[Address(RVA = "0x2278FA0", Offset = "0x2277BA0", VA = "0x182278FA0")]
			public Adapter(ArchiveLandmarkDataBinder closure)
			{
			}

			// Token: 0x0602757A RID: 161146 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602757A")]
			[Address(RVA = "0x2278C60", Offset = "0x2277860", VA = "0x182278C60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037BC7 RID: 228295
			[Token(Token = "0x4037BC7")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveLandmarkDataBinder m_closure;

			// Token: 0x04037BC9 RID: 228297
			[Token(Token = "0x4037BC9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x04037BCA RID: 228298
			[Token(Token = "0x4037BCA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x04037BCB RID: 228299
			[Token(Token = "0x4037BCB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037BCC RID: 228300
			[Token(Token = "0x4037BCC")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037BCD RID: 228301
			[Token(Token = "0x4037BCD")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
