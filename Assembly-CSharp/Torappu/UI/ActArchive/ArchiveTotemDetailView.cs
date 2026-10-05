using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C45 RID: 27717
	[Token(Token = "0x2006C45")]
	public class ArchiveTotemDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005D79 RID: 23929
		// (get) Token: 0x0602790C RID: 162060 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602790D RID: 162061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D79")]
		public ArchiveTotemController controller
		{
			[Token(Token = "0x602790C")]
			[Address(RVA = "0x22C1610", Offset = "0x22C0210", VA = "0x1822C1610")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602790D")]
			[Address(RVA = "0x22C1670", Offset = "0x22C0270", VA = "0x1822C1670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602790E RID: 162062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602790E")]
		[Address(RVA = "0x22C1180", Offset = "0x22BFD80", VA = "0x1822C1180")]
		public void Render(TotemItemModel model)
		{
		}

		// Token: 0x0602790F RID: 162063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602790F")]
		[Address(RVA = "0x22C15B0", Offset = "0x22C01B0", VA = "0x1822C15B0")]
		public ArchiveTotemDetailView()
		{
		}

		// Token: 0x040381A5 RID: 229797
		[Token(Token = "0x40381A5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x040381A6 RID: 229798
		[Token(Token = "0x40381A6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _usageText;

		// Token: 0x040381A7 RID: 229799
		[Token(Token = "0x40381A7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _descText;

		// Token: 0x040381A8 RID: 229800
		[Token(Token = "0x40381A8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x040381A9 RID: 229801
		[Token(Token = "0x40381A9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x040381AA RID: 229802
		[Token(Token = "0x40381AA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _lockedPanel;

		// Token: 0x040381AB RID: 229803
		[Token(Token = "0x40381AB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _redTotemPanel;

		// Token: 0x040381AC RID: 229804
		[Token(Token = "0x40381AC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _greenTotemPanel;

		// Token: 0x040381AD RID: 229805
		[Token(Token = "0x40381AD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _blueTotemPanel;

		// Token: 0x040381AE RID: 229806
		[Token(Token = "0x40381AE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _noneTotemPanel;

		// Token: 0x040381AF RID: 229807
		[Token(Token = "0x40381AF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _affixPanel;

		// Token: 0x040381B0 RID: 229808
		[Token(Token = "0x40381B0")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_finder;

		// Token: 0x040381B2 RID: 229810
		[Token(Token = "0x40381B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040381B3 RID: 229811
		[Token(Token = "0x40381B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040381B4 RID: 229812
		[Token(Token = "0x40381B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040381B5 RID: 229813
		[Token(Token = "0x40381B5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
