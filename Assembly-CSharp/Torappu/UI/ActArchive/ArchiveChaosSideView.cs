using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B3C RID: 27452
	[Token(Token = "0x2006B3C")]
	public class ArchiveChaosSideView : MonoBehaviour
	{
		// Token: 0x17005CBD RID: 23741
		// (get) Token: 0x060273E1 RID: 160737 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060273E2 RID: 160738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CBD")]
		public ArchiveChaosController controller
		{
			[Token(Token = "0x60273E1")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60273E2")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060273E3 RID: 160739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273E3")]
		[Address(RVA = "0x226AD50", Offset = "0x2269950", VA = "0x18226AD50")]
		public void Render(ChaosItemModel model)
		{
		}

		// Token: 0x060273E4 RID: 160740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273E4")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ArchiveChaosSideView()
		{
		}

		// Token: 0x04037868 RID: 227432
		[Token(Token = "0x4037868")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color ICON_ATTAINED_COLOR;

		// Token: 0x04037869 RID: 227433
		[Token(Token = "0x4037869")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color ICON_UNATTAINED_COLOR;

		// Token: 0x0403786A RID: 227434
		[Token(Token = "0x403786A")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Color NAME_ATTAINED_COLOR;

		// Token: 0x0403786B RID: 227435
		[Token(Token = "0x403786B")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Color NAME_UNATTAINED_COLOR;

		// Token: 0x0403786C RID: 227436
		[Token(Token = "0x403786C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x0403786D RID: 227437
		[Token(Token = "0x403786D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x0403786E RID: 227438
		[Token(Token = "0x403786E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _fixedNameText;

		// Token: 0x0403786F RID: 227439
		[Token(Token = "0x403786F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _levelGroup;

		// Token: 0x04037870 RID: 227440
		[Token(Token = "0x4037870")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _usageText;

		// Token: 0x04037871 RID: 227441
		[Token(Token = "0x4037871")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _descText;

		// Token: 0x04037872 RID: 227442
		[Token(Token = "0x4037872")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _attainedPanel;

		// Token: 0x04037873 RID: 227443
		[Token(Token = "0x4037873")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _unattainedPanel;
	}
}
