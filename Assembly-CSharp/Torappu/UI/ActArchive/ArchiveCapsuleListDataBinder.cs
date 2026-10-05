using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B20 RID: 27424
	[Token(Token = "0x2006B20")]
	public class ArchiveCapsuleListDataBinder : DataBinder<CapsuleProperty>
	{
		// Token: 0x17005CA5 RID: 23717
		// (get) Token: 0x06027346 RID: 160582 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027347 RID: 160583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CA5")]
		public ArchiveCapsuleController controller
		{
			[Token(Token = "0x6027346")]
			[Address(RVA = "0x2264800", Offset = "0x2263400", VA = "0x182264800")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027347")]
			[Address(RVA = "0x2264860", Offset = "0x2263460", VA = "0x182264860")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027348 RID: 160584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027348")]
		[Address(RVA = "0x2264670", Offset = "0x2263270", VA = "0x182264670")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027349 RID: 160585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027349")]
		[Address(RVA = "0x2263F80", Offset = "0x2262B80", VA = "0x182263F80", Slot = "7")]
		public override void OnValueChanged(CapsuleProperty property)
		{
		}

		// Token: 0x0602734A RID: 160586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602734A")]
		[Address(RVA = "0x2264790", Offset = "0x2263390", VA = "0x182264790")]
		public ArchiveCapsuleListDataBinder()
		{
		}

		// Token: 0x04037775 RID: 227189
		[Token(Token = "0x4037775")]
		private const string UNLOCK_CAPSULE_DETAIL_TITLE = "???";

		// Token: 0x04037776 RID: 227190
		[Token(Token = "0x4037776")]
		private const string UNLOCK_CAPSULE_ENGLISH_TITLE = "Unknown";

		// Token: 0x04037777 RID: 227191
		[Token(Token = "0x4037777")]
		public const string UNKNOWN_CAPSULE_ICON_ID = "unknown";

		// Token: 0x04037778 RID: 227192
		[Token(Token = "0x4037778")]
		public const string UNKNOWN_RED_CAPSULE_ICON_ID = "red_unknown";

		// Token: 0x04037779 RID: 227193
		[Token(Token = "0x4037779")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArchiveCapsuleRecycleAdapter _adapter;

		// Token: 0x0403777A RID: 227194
		[Token(Token = "0x403777A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Item detail panel")]
		private Text _textTitle;

		// Token: 0x0403777B RID: 227195
		[Token(Token = "0x403777B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Item detail panel")]
		private Text _textUnlockTitle;

		// Token: 0x0403777C RID: 227196
		[Token(Token = "0x403777C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Item detail panel")]
		private Image _imgItem;

		// Token: 0x0403777D RID: 227197
		[Token(Token = "0x403777D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Item detail panel")]
		private Text _textUsage;

		// Token: 0x0403777E RID: 227198
		[Token(Token = "0x403777E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Item detail panel")]
		private Text _textDesc;

		// Token: 0x0403777F RID: 227199
		[Token(Token = "0x403777F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Item detail panel")]
		private Text _textEnglishName;

		// Token: 0x04037780 RID: 227200
		[Token(Token = "0x4037780")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x04037782 RID: 227202
		[Token(Token = "0x4037782")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037783 RID: 227203
		[Token(Token = "0x4037783")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037784 RID: 227204
		[Token(Token = "0x4037784")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037785 RID: 227205
		[Token(Token = "0x4037785")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037786 RID: 227206
		[Token(Token = "0x4037786")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
