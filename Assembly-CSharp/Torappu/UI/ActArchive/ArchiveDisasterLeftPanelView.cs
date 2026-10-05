using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B60 RID: 27488
	[Token(Token = "0x2006B60")]
	public class ArchiveDisasterLeftPanelView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005CD1 RID: 23761
		// (get) Token: 0x06027477 RID: 160887 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027478 RID: 160888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CD1")]
		public ArchiveDisasterController controller
		{
			[Token(Token = "0x6027477")]
			[Address(RVA = "0x2279880", Offset = "0x2278480", VA = "0x182279880")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027478")]
			[Address(RVA = "0x22798E0", Offset = "0x22784E0", VA = "0x1822798E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027479 RID: 160889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027479")]
		[Address(RVA = "0x2279690", Offset = "0x2278290", VA = "0x182279690")]
		public void Render(DisasterTypeModel typeModel)
		{
		}

		// Token: 0x0602747A RID: 160890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602747A")]
		[Address(RVA = "0x2279820", Offset = "0x2278420", VA = "0x182279820")]
		public ArchiveDisasterLeftPanelView()
		{
		}

		// Token: 0x040379BF RID: 227775
		[Token(Token = "0x40379BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bigIcon;

		// Token: 0x040379C0 RID: 227776
		[Token(Token = "0x40379C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _disasterName;

		// Token: 0x040379C1 RID: 227777
		[Token(Token = "0x40379C1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _disasterDesc;

		// Token: 0x040379C3 RID: 227779
		[Token(Token = "0x40379C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040379C4 RID: 227780
		[Token(Token = "0x40379C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040379C5 RID: 227781
		[Token(Token = "0x40379C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040379C6 RID: 227782
		[Token(Token = "0x40379C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
